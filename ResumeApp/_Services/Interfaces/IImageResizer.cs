namespace ResumeApp.Services.Interfaces
{
    public interface IImageResizer
    {
        /// <summary>
        /// Receives an image stream and returns a resized image as a bytearray
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        byte[] ResizeWithSkiaSharp(Stream stream);
    }
}
