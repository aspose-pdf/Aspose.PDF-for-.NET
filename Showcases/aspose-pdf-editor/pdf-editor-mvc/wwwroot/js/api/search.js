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
    $.ajax({
        type: 'PUT',
        url: `${apiBaseUrl}text/replace`,
        data: movedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function () {
            DrawScreen();
            DrawPage(Npages[currentPage - 1]);
            var promise = jQuery.when().promise();
            promise = promise.then(wait);
            promise.done(function () {
                DrawShapes();
            });
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }

    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function ClearSearch() {
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