
function ddFontChange() {
    let dFont = document.getElementById('ddFont');
    fontText = dFont.options[dFont.selectedIndex].value;
    $('#textareaTest').css('font-family', fontText);
}

function ddSizeChange() {
    let dSize = document.getElementById('ddSize');
    fontSize = dSize.options[dSize.selectedIndex].value;
    $('#textareaTest').css('font-size', fontSize + 'px');
}

function makeBold() {
    if ($('#btnBold').hasClass('active')) {

        $('#textareaTest').css('font-weight', 'normal');
        fontWeight = 'normal';
    }
    else {
        $('#textareaTest').css('font-weight', 'bold');
        fontWeight = 'bold';
    }
}

function makeItalic() {
    if ($('#btnItalic').hasClass('active')) {

        $('#textareaTest').css('font-style', 'italic');
        fontStyle = '';
    }
    else {
        $('#textareaTest').css('font-style', 'italic');
        fontStyle = 'italic';
    }
}

function selectColor(color_this) {
    $('#textareaTest').css('color', color_this.name);
    $('#btnColor').css('background-color', color_this.name);
    fontColor = color_this.name;
    $('#myColors').modal('hide');
}

function closeTextEditor() {
    $('#textAreaPopUp').css('visibility', 'hidden');
}

function moveModeClose() {
    $('#hdnMove').val('');
}


function fileSelected() {
    $('#uploadModal').modal('hide');
    let fd = new FormData();
    fd.append('fileToUpload', document.getElementById('fileToUpload').files[0]);
    fd.append('Opp', $('#hdnOpp').val());
    if (typeof documentId !== 'undefined' && documentId != 'undefined')
        fd.append('documentId', documentId);

    if ($('#hdnOpp').val() === 'appending') {
        fd.append('pages', Npages);
        fd.append('ratios', aRatio);
        fd.append('heights', heights);

    }
    var xhr = new XMLHttpRequest();
    switch($('#hdnOpp').val())
    {
        case 'uploading':
            xhr.open('PUT', `${apiBaseUrl}document/upload`);
            break;
        case 'appending':
            xhr.open('PUT', `${apiBaseUrl}document/append`);
            break;
        case 'addAttachment':
            xhr.open('POST', `${apiBaseUrl}attachment/add`);
            break;
        default:
            xhr.open('POST', `${apiBaseUrl}shape/upload`);
            break;
    }

    xhr.upload.onprogress = function (event) {
        if (event.lengthComputable) {
            $('.progress-bar').width('60%');
        }
    };

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            if(xhr.status >= 300)
            {
                alertModal(xhr.statusText);
                return;
            }
            
            data = JSON.parse(xhr.responseText);
            dataLoad = data.pages;
            documentId = data.documentId;
            if ($('#hdnOpp').val() === 'appending') {
                First();
            }
            else
                if ($('#hdnOpp').val() === 'uploading') {
                    for (i = 0; i < shapes.length; i++) {
                        var shapeDiv = document.getElementById('div_' + shapes[i].imName + '');
                        var shape = document.getElementById(shapes[i].imName);
                        if (shape !== null) {
                            $('#' + shapes[i].imName + '').remove();
                        }
                        if (shapeDiv !== null) {
                            shapeDiv.parentNode.removeChild(shapeDiv);
                        }
                    }

                    shapes2.length = 0;
                    shapes.length = 0;
                    Attachments.length = 0;
                    GetAttachments();
                    First();
                }
                else if ($('#hdnOpp').val() === 'addAttachment') {
                    GetAttachments();
                }
                else {
                    InsertImages(data.pages, 50, 50);
                    xhr.onreadystatechange = null;
                }

            $('.progress-bar').width('100%');
            

            $('#fileToUpload').wrap('<form>').parent('form').trigger('reset');
            $('#fileToUpload').unwrap();
            $('#fileToUpload').prop('files')[0] = null;
            $('#fileToUpload').replaceWith($('#fileToUpload'));
            $('.progress-bar').width('0%');
        }
    };

    xhr.send(fd);
}

$(document).on('click', '.open-uploadModal', function () {
    let operationId = $(this).data('id');
    $('#hdnOpp').val(operationId);
});


function alertModal (msg, xhr, textStatus, error){
    if(xhr != null && xhr.responseJSON != null) {
        msg += xhr.responseJSON.detail;
    }
    
    if(error != null) {
        msg += error;
    }

    $("#errorModal").html(msg);
    $('#loadingModal').modal('hide');
    $("#errorModal").fadeTo(4000, 500).slideUp(500, function () {
        $("#errorModal").slideUp(500);
    });
}
