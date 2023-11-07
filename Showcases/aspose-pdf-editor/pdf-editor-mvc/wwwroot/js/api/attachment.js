function GetAttachments() {
    // Sending the image data to Server
    $.ajax({
        type: 'GET',
        url: `${apiBaseUrl}attachment/all/${documentId}`,
        data: { 'documentId': documentId },
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            Attachments = data.files.split(',');
            var table = document.getElementById('tblAttach');
            while (table.rows.length > 1) {
                table.deleteRow(1);
            }
            var count = 1;
            for (i = 0; i < Attachments.length - 1; i++) {

                var row = table.insertRow(table.rows.length);
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);


                // Add some text to the new cells:
                cell1.innerHTML = Attachments[i];
                cell2.innerHTML = Attachments[i + 1];

                let pos = Attachments[i].lastIndexOf('.');
                let attachFileName = Attachments[i].substr(0, pos) + '_' + Attachments[i].substr(pos + 1);
                cell3.innerHTML = `<a href="${apiBaseUrl}GetFileAttachment/${documentId}/${attachFileName}" download class="btn btn-default" role="button">Download</a>`;

                name = Attachments[i];

                button = document.createElement('input'); // create a button
                button.setAttribute('type', 'button'); // set attributes ...
                button.setAttribute('name', count);
                button.setAttribute('value', 'Remove');
                button.setAttribute('class', 'btn btn-danger');
                button.onclick = (function () {
                    let currentName = name;
                    let index = count;
                    return function () {
                        RemoveAttachment(currentName, index);
                    };

                })();

                cell4.appendChild(button);
                count = count + 1;
                i = i + 1;
            }
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function RemoveAttachment(name, rowId) {
    let removeData = JSON.stringify({ 'attachmentFileName': name, 'documentId': documentId });
    // Sending the image data to Server
    $.ajax({
        type: 'DELETE',
        url: `${apiBaseUrl}attachment/remove`,
        data: removeData,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function () {
            document.getElementById('tblAttach').deleteRow(rowId);
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}