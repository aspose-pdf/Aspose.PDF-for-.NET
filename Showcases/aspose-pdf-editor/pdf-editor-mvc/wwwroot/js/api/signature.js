function saveSignature() {
    const signatureCanvas = document.querySelector('#signCanvas');
    const imageData = signatureCanvas.toDataURL('image/png');

    var form = new FormData();
    form.append("documentId", documentId);
    signatureCanvas.toBlob(function (blob) {
        form.append(imageData, blob, "signature.png");
        $.ajax({
            type: 'POST',
            url: `${apiBaseUrl}shape/upload`,
            data: form,
            processData: false,
            contentType: false,
            success: function (data) {
                InsertImages(data.pages, signX, signY);
                $('#divSignature').css('visibility', 'hidden');
                currentTools = 'dragging';
                document.getElementById('btnDrag').click();
                var e = jQuery.Event('mousedown', { pageX: signX, pageY: signY });
                $('#imageView').trigger(e);
            }
        })
            .done(function () { $('#loadingModal').modal('hide'); });
    }, 'image/png');
}

function closeSignature() {
    $('#divSignature').css('visibility', 'hidden');
}

function clearSignature() {
    const signatureCanvas = document.querySelector('#signCanvas');
    signatureCanvas.width = signatureCanvas.width;
    const ctx = signatureCanvas.getContext('2d');
    ctx.lineWidth = 5;
    ctx.lineJoin = 'round';
    ctx.lineCap = 'round';
    ctx.strokeStyle = 'blue';
}