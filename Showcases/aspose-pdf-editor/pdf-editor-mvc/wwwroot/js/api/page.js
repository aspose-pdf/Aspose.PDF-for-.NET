function NewFileClick() {
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}document/create`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            dataLoad = data.pages;
            documentId = data.documentId;
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

            $('#hdnOpp').val('Empty');
            shapes2.length = 0;
            shapes.length = 0;
            Attachments.length = 0;
            First();
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function DrawPage(imageId) {
    var canvas = document.getElementById('imageView');
    canvas.height = pageHeights[imageId];

    var canvas2 = document.getElementById('imageTemp');
    canvas2.height = pageHeights[imageId];

    var context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.width, canvas.height);

    var image1 = '';
    var rand = Math.random();
    
    image1 = `${apiBaseUrl}page/preview/${documentId}/${imageId}`;
    $('#imageView').css('background-size', 'contain');
    $('#imageView').css('background-repeat', 'no-repeat');
    $('#imageView').css('background-image', 'url(' + image1 + '?Dummy=' + rand + ')');

    return true;
}

function AddPage() {
    $('#loadingModal').modal('show');

    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}page/add/${documentId}`,
        data: '{ "lastpage" : "' + Npages[Npages.length - 1] + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            datasplit = data.pages.split("#");
            Npages.push(datasplit[0]);
            aRatio.push(datasplit[2]);
            heights.push(datasplit[1]);
            for (let i = 0; i < heights.length; i++) {
                pageHeights[Npages[i]] = heights[i];
            }
            document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function DeletePage() {
    $('#loadingModal').modal('show');

    function isFromPage(page) {
        return page == currentPage;
    }

    shapes = shapes.filter(isFromPage);

    var deleteData = JSON.stringify(
        { 
            'pageNumber': currentPage, 
            'documentId': documentId 
        });

    return $.ajax({
        type: 'DELETE',
        url: `${apiBaseUrl}page/delete`,
        data: deleteData,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            updateIndexesDelete();
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function updateIndexesDelete() {
    DeleteShapes();

    Npages.splice(currentPage - 1, 1);

    if (currentPage > Npages.length) {
        currentPage = Npages.length;
    }

    DrawPage(Npages[currentPage - 1]);
    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}

function Move() {
    $('#loadingModal').modal('show');

    let moveTo = $('#txtMove').val();

    if ($('#hdnMove').val() === 'moving') {
        movedata = JSON.stringify(
            { 
                'moveFrom': currentPage, 
                'moveTo': moveTo, 
                'pageList': Npages, 
                'documentId': documentId 
            });

        $.ajax({
            type: 'PUT',
            url: `${apiBaseUrl}page/move`,
            data: movedata,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                Npages = data.pageList;
                MoveUpdate();
            },
            error: function (xhr, textStatus, error) {
                alertModal('Error: ', xhr, textStatus, error);
            }
        })
        .done(function () { $('#loadingModal').modal('hide'); });
    }
    else {
        movedata = JSON.stringify(
            { 
                'searchText': moveTo, 
                'pageList': Npages, 
                'documentId': documentId 
            });
            
        $.ajax({
            type: 'POST',
            url: `${apiBaseUrl}text/search`,
            data: movedata,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function () {
                AfterSearch();
            },
            error: function (xhr, textStatus, error) {
                alertModal('Error: ', xhr, textStatus, error);
            }
        })
        .done(function () { $('#loadingModal').modal('hide'); });
    }
}

function MoveUpdate() {
    for (var i = 0; i < Npages.length; i++) {
        for (var j = 0; j < shapes.length; j++) {

            if (Npages[i] === shapes[j].f) {
                shapes[j].page = i + 1;
            }
        }

    }

    DrawScreen();
    DrawPage(Npages[currentPage - 1]);
    DrawShapes();

    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}