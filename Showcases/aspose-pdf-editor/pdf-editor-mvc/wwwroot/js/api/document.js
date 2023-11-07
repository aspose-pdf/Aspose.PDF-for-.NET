function btnExportClick() {
    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}export-pdf`,
        data: '{}',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json'
    });

}

function SavePdf() {
    $('#loadingModal').modal('show');
    let filename = 'image'.concat(currentPage).concat('.png');

    shapes2 = [];

    for (var i = 0; i < shapes.length; i++) {
        tempShape = {
            x: shapes[i].x.toString(),
            y: shapes[i].y.toString(),
            textWidth: shapes[i].textWidth.toString(),
            fontHeight: shapes[i].fontHeight.toString(),
            page: shapes[i].page.toString(),
            f: shapes[i].f.toString(),
            text: shapes[i].text.toString(),
            fontText: shapes[i].fontText.toString(),
            fontSize: shapes[i].fontSize.toString(),
            fontColor: shapes[i].fontColor.toString(),
            fontWeight: shapes[i].fontWeight.toString(),
            fontStyle: shapes[i].fontStyle.toString(),
            ratio: shapes[i].ratio.toString(),
            imfile: '',
            imName: shapes[i].imName,
            Itype: shapes[i].Itype.toString(),
            fieldType: shapes[i].fieldType.toString()
        };
        shapes2.push(tempShape);
    }

    wholedata = JSON.stringify({ 'shapes': shapes2, 'filename': filename, 'aspectRatio': ratio.toString(), 'documentId': documentId });

    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}shape/add`,
        data: wholedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            $("#savingModal").fadeTo(2000, 500).slideUp(500, function () {
                $("#savingModal").slideUp(500);
            });
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function ExportByType(fileType, documentId) {
    
    const a = document.createElement('a')
    a.href = `${apiBaseUrl}document/download/${fileType}/${documentId}`
    a.download = `${apiBaseUrl}}document/download/${fileType}/${documentId}`.split('/').pop() + '.' + fileType;
    document.body.appendChild(a)
    a.click()
    document.body.removeChild(a);
}

function ExportFile(fileType) {
    $('#loadingModal').modal('show');
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}document/export?fileType=${fileType}&folder=${documentId}`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            ExportByType(fileType, documentId);
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}
