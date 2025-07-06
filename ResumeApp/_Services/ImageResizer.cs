using ResumeApp.Services.Interfaces;
using SkiaSharp;

namespace ResumeApp.Services
{
    public class ImageResizer() : IImageResizer
    {
        const long TargetedFileSizeInBytes = 1 * 1024 * 1024; // 1 MB
        const int MaxIterations = 15;
        const int MinJpegQuality = 40;      // Don't reduce quality too much
        const int initialJpegQuality = 85;        // Assumed JPEG quality 
        const float initialScaleFactor = 1.0f;    // 100%
        const float MinScaleFactor = 0.1f;  // Don't scale down too 

        public byte[] ResizeWithSkiaSharp(Stream stream)
        {
            try
            {
                if (stream is null)
                {
                    Console.WriteLine("Stream is null");
                    throw new ArgumentNullException("ImageResizer: Received null instead of a stream");
                }

                using var skData = SKData.Create(stream);
                using var codec = SKCodec.Create(skData);
                stream.Position = 0; // Reset position
                using var originalBitmap = SKBitmap.Decode(stream);

                if (codec is null)
                {
                    Console.WriteLine("Codec is null");
                    throw new ArgumentNullException();
                }
                if (originalBitmap is null)
                {
                    Console.WriteLine("OriginalBitMap is null");
                    throw new ArgumentNullException();
                }

                float currentScaleFactor = initialScaleFactor;
                int currentJpegQuality = initialJpegQuality;

                using MemoryStream outputStream = new();

                for (int i = 0; i < MaxIterations; i++)
                {
                    outputStream.SetLength(0); // Reset for each attempt
                    outputStream.Position = 0;

                    int newWidth = (int)(originalBitmap.Width * currentScaleFactor);
                    int newHeight = (int)(originalBitmap.Height * currentScaleFactor);

                    // Ensure aspect ratio
                    newWidth = Math.Max(1, newWidth);
                    newHeight = Math.Max(1, newHeight);

                    using (var scaledBitmap = originalBitmap.Resize(new SKSizeI(newWidth, newHeight), SKSamplingOptions.Default))
                    {

                        scaledBitmap.Encode(outputStream, format: SKEncodedImageFormat.Jpeg, quality: currentJpegQuality);

                        Console.WriteLine($"Current encoded size: {outputStream.Length} bytes. Target: {TargetedFileSizeInBytes} bytes.");

                        // Inspect the size and return if below or equal to expected output size
                        if (outputStream.Length <= TargetedFileSizeInBytes)
                        {
                            outputStream.Position = 0;
                            return outputStream.ToArray();
                        }

                        // Start downscaling further
                        if (currentScaleFactor > MinScaleFactor)
                        {
                            currentScaleFactor *= 0.9f;
                            if (currentScaleFactor < MinScaleFactor) currentScaleFactor = MinScaleFactor;
                        }
                        else if (currentJpegQuality > MinJpegQuality)
                        {
                            currentJpegQuality -= 5;
                            if (currentJpegQuality < MinJpegQuality) currentJpegQuality = MinJpegQuality;
                        }
                        else
                        {
                            // Limit reached
                            outputStream.Position = 0;
                            outputStream.ToArray();
                        }

                        // If both scale and limit is reached, give up and return
                        if (currentScaleFactor == MinScaleFactor)
                        {
                            outputStream.Position = 0;
                            return outputStream.ToArray();
                        }
                    }
                }
                // Fallback
                outputStream.Position = 0;
                return outputStream.ToArray();
            }
            catch (Exception ex) { Console.WriteLine("SkiaSharp Exception Message: " + ex.ToString()); return null; }
        }
    }
}
