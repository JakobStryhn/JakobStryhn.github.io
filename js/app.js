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

window.downloadResumeFile = async (englishresume) => {

    var fileName
    if (englishresume) {
        fileName = "Jakob-Min-Stryhn-Resume.pdf"
    }
    else {
        fileName = "Jakob-Min-Stryhn-CV.pdf"
    }

    response = await fetch(`/files/${fileName}`)

    const blob = await response.blob();
    const url = URL.createObjectURL(blob)

    const a = document.createElement('a');
    a.href = url;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
};