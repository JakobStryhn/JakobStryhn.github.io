window.downloadFileFromByteArray = (filename, contentType, byteArray) => {
    const blob = new Blob([byteArray], { type: contentType });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = filename;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
};

window.downloadResumeFile = async () => {
    const response = await fetch("/files/Jakob Min Stryhns Resume.pdf");

    const blob = await response.blob();
    const url = URL.createObjectURL(blob)

    const a = document.createElement('a');
    a.href = url;
    a.download = "Jakob Min Stryhns Resume.pdf";
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
};