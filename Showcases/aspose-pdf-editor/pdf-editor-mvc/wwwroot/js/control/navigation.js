

function First() {
    let dataP = dataLoad.split('%#');
    Npages = dataP[0].split(',');
    aRatio = dataP[1].split(',');
    heights = dataP[2].split(',');
    if (dataP.length > 3)
        fieldData = dataP[3];
    else
        fieldData = '';

    addFields(fieldData);
    for (var i = 0; i < heights.length; i++) {
        pageHeights[Npages[i]] = heights[i];
    }

    if ($('#hdnOpp').val() === 'uploading' || $('#hdnOpp').val() === 'dbox' || $('#hdnOpp').val() === 'Empty') {
        currentPage = 1;
        onStartup();
    }

    DrawPic(Npages[currentPage - 1]);
    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
    DrawShapes();

    ManageFields();
}

function Next() {
    if (currentPage < Npages.length) {
        currentPage = currentPage + 1;
        DrawScreen();
        DrawPic(Npages[currentPage - 1]);
        var promise = jQuery.when().promise();
        promise = promise.then(wait);
        promise.done(function () {
            DrawShapes();
            ManageFields();
        });
    }

    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}

function Previous() {
    if (currentPage > 1) {
        currentPage = currentPage - 1;
        DrawScreen();
        DrawPic(Npages[currentPage - 1]);
        var promise = jQuery.when().promise();
        promise = promise.then(wait);
        promise.done(function () {
            DrawShapes();
            ManageFields();
        });
    }

    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}