
function wait(ms) {
    var deferred = jQuery.Deferred();
    var intervalId = setInterval(function () {
        clearInterval(intervalId);
        deferred.resolve();
    }, 100);
    return deferred.promise();
}

function AfterSearch() {
    DrawScreen();
    DrawPage(Npages[currentPage - 1]);
    var promise = jQuery.when().promise();
    promise = promise.then(wait);
    promise.done(function () {
        DrawShapes();
    });
}

function ReplaceText() {
    let txtFind = $('#txtFind').val();
    let txtReplace = $('#txtReplace').val();
    let movedata = JSON.stringify(
        { 
            'txtFind': txtFind, 
            'txtReplace': txtReplace, 
            'pageList': Npages, 
            'documentId': documentId 
        });

    $('#loadingModal').modal('show');
    // Sending the image data to Server
    $.ajax({
        type: 'PUT',
        url: `${apiBaseUrl}text/replace`,
        data: movedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            AfterSearch();
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }

    })
    .done(function () { $('#loadingModal').modal('hide'); });
}


function clearSearchClicked() {
    let cleardata = JSON.stringify(
        { 
            'searchText': '', 
            'pageList': Npages, 
            'documentId': documentId 
        });

    $.ajax({
        type: 'DELETE',
        url: `${apiBaseUrl}text/clear`,
        data: cleardata,
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