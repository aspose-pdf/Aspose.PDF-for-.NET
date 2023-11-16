function GetDocumentInfo() {
    var folder = typeof window.folderName !== 'undefined' 
        && window.folderName != 'undefined' ? 
        window.folderName : "";
    
    var file = typeof window.fileName !== 'undefined' 
        && window.fileName != 'undefined' ?
        window.fileName : "";
        
    $.ajax({
        type: 'GET',
        url: `${apiBaseUrl}document/info?folder=${folder}&fileName=${file}`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            dataLoad = data.pages;
            documentId = data.documentId;
            for (let i = 0; i < shapes.length; i++) {
                var shapeDiv = document.getElementById('div_' + shapes[i].imName + '');
                var shape = document.getElementById(shapes[i].imName);
                if (shape !== null) {
                    $('#' + shapes[i].imName + '').remove();
                }

                if (shapeDiv !== null) {
                    shapeDiv.parentNode.removeChild(shapeDiv);
                }
            }

            $('#hdnOpp').val('Empty');
            shapes2.length = 0;
            shapes.length = 0;
            Attachments.length = 0;
            $('#loadingModal').modal('hide');
            First();
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function SavePdf() {
    $('#loadingModal').modal('show');
    let filename = 'image'.concat(currentPage).concat('.png');

    shapes2 = [];

    for (var i = 0; i < shapes.length; i++) {
        tempShape = {
            x: shapes[i].x,
            y: shapes[i].y,
            textWidth: shapes[i].textWidth,
            fontHeight: shapes[i].fontHeight,
            page: shapes[i].page,
            f: shapes[i].f,
            text: shapes[i].text,
            fontText: shapes[i].fontText,
            fontSize: shapes[i].fontSize,
            fontColor: shapes[i].fontColor,
            fontWeight: shapes[i].fontWeight,
            fontStyle: shapes[i].fontStyle,
            ratio: shapes[i].ratio,
            imfile: '',
            imName: shapes[i].imName,
            Itype: shapes[i].Itype,
            fieldType: shapes[i].fieldType
        };
        shapes2.push(tempShape);
    }

    wholedata = JSON.stringify(
        { 
            'shapes': shapes2, 
            'filename': filename, 
            'aspectRatio': ratio, 
            'documentId': documentId 
        });

    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}shape/add`,
        data: wholedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function () {
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

function ExportFile(fileType) {
    $('#loadingModal').modal('show');

    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}document/export?fileType=${fileType}&folder=${documentId}`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function () {
            const a = document.createElement('a')
            a.href = `${apiBaseUrl}document/download/${fileType}/${documentId}`
            a.download = `${apiBaseUrl}}document/download/${fileType}/${documentId}`.split('/').pop() + '.' + fileType;
            document.body.appendChild(a)
            a.click()
            document.body.removeChild(a);
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}
