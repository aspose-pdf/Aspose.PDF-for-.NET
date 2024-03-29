var annotationIcnosDict = {
    "Line": '<i class="bi bi-dash" style="color:white"></i>',
    "Square": '<i class="bi bi-square" style="color:white"></i>',
    "Circle": '<i class="bi bi-circle" style="color:white"></i>',
    "Polygon": '<i class="bi bi-pentagon" style="color:white"></i>',
    "PolyLine": '<i class="bi bi-vector-pen" style="color:white"></i>',
    "Ink": '<i class="bi bi-pen" style="color:white"></i>',
    "Highlight": '<i class="bi bi-pen" style="color:white"></i>',
    "Underline": '<i class="bi bi-type-underline" style="color:white"></i>',
    "Squiggly": '<i class="bi bi-vector-pen" style="color:white"></i>',
    "StrikeOut": '<i class="bi bi-type-strikethrough" style="color:white"></i>',
    "Stamp": '<i class="bi bi-award" style="color:white"></i>',
    "Caret": '<i class="bi bi-caret-down-fill" style="color:white"></i>',
    "Watermark": '<i class="bi bi-water" style="color:white"></i>',
    "Sound": '<i class="bi bi-volume-up" style="color:white"></i>',
    "Movie": '<i class="bi bi-film" style="color:white"></i>',
    "Screen": '<i class="bi bi-display" style="color:white"></i>',
    "Text": '<i class="bi bi-fonts" style="color:white"></i>',
    "Link": '<i class="bi bi-link-45deg" style="color:white"></i>',
    "FreeText": '<i class="bi bi-text-paragraph" style="color:white"></i>',
    "Redact": '<i class="bi bi-eye-slash" style="color:white"></i>',
};

function setPosition(obj, x, y, pageNumber) {
    // Check if the object has a 'pageNumber' field and set it if provided

    if (obj.hasOwnProperty('PageNumber')) {
        obj.PageNumber = pageNumber !== undefined ? pageNumber : obj.PageNumber;
    }

    if (obj.hasOwnProperty('PopupPageNumber')) {
        obj.PopupPageNumber = pageNumber !== undefined ? pageNumber : obj.PopupPageNumber;
    }

    if (obj.hasOwnProperty('X')) {
        obj.X = x !== undefined ? x : obj.X;
    }

    if (obj.hasOwnProperty('Y')) {
        obj.Y = y !== undefined ? y : obj.Y;
    }

    if (obj.hasOwnProperty('StartX')) {
        obj.StartX = x !== undefined ? x : obj.StartX;
    }

    if (obj.hasOwnProperty('StartY')) {
        obj.StartY = y !== undefined ? y : obj.StartY;
    }

    if (obj.hasOwnProperty('EndX')) {
        obj.EndX = x !== undefined ? x + 20 : obj.StartX;
    }

    if (obj.hasOwnProperty('EndY')) {
        obj.EndY = y !== undefined ? y + 20 : obj.EndY;
    }

    if (obj.hasOwnProperty('XIndent')) {
        obj.XIndent = x !== undefined ? x : obj.XIndent;
    }

    if (obj.hasOwnProperty('YIndent')) {
        obj.YIndent = y !== undefined ? y : obj.YIndent;
    }

    if (obj.hasOwnProperty('Points')) {
        if (obj.Points.length == 1) {
            obj.Points = [new PointModel(x, y)];
        }
        else {
            obj.Points = [new PointModel(x, y), new PointModel(x + 10, y + 10)];
        }
    }

    if (obj.hasOwnProperty('Llx')) {
        obj.Llx = x !== undefined ? x : obj.Llx;
        obj.Urx = obj.Llx + 10;
    }

    if (obj.hasOwnProperty('Lly')) {
        obj.Lly = y !== undefined ? y : obj.Lly;
        obj.Ury = obj.Lly + 10;
    }

    if (obj.hasOwnProperty('PopupLlx')) {
        obj.PopupLlx = x !== undefined ? x : obj.PopupLlx;
        obj.PopupUrx = obj.PopupLlx + 10;
    }

    if (obj.hasOwnProperty('PopupLly')) {
        obj.PopupLly = y !== undefined ? y : obj.PopupLly;
        obj.PopupUry = obj.PopupLly + 10;
    }
}

function toogleAnnotationToolbar(disabled) {
    document.getElementById('btnLine').disabled = disabled;
    document.getElementById('btnSquare').disabled = disabled;
    document.getElementById('btnCircle').disabled = disabled;
    document.getElementById('btnPolygon').disabled = disabled;
    document.getElementById('btnPolyLine').disabled = disabled;
    document.getElementById('btnInk').disabled = disabled;
    document.getElementById('btnHighlight').disabled = disabled;
    document.getElementById('btnUnderline').disabled = disabled;
    document.getElementById('btnSquiggly').disabled = disabled;
    document.getElementById('btnStrikeOut').disabled = disabled;
    document.getElementById('btnStamp').disabled = disabled;
    document.getElementById('btnCaret').disabled = disabled;
    document.getElementById('btnWatermark').disabled = disabled;
    document.getElementById('btnSound').disabled = disabled;
    document.getElementById('btnMovie').disabled = disabled;
    document.getElementById('btnScreen').disabled = disabled;
    document.getElementById('btnText').disabled = disabled;
    document.getElementById('btnLink').disabled = disabled;
    document.getElementById('btnFreeText').disabled = disabled;
    document.getElementById('btnRedact').disabled = disabled;
    document.getElementById('btnUnderline').disabled = disabled;
    document.getElementById('btnAnnotate').disabled = disabled;
}

function addButtons(formContainer, applyCallback) {
    // Create the button container
    var buttonContainer = document.createElement('div');
    buttonContainer.id = 'buttonContainer';

    // Create the Cancel button
    var cancelButton = document.createElement('button');
    cancelButton.id = 'cancelButton';
    cancelButton.className = 'button';
    cancelButton.textContent = 'Cancel';

    // Create the Apply button
    var applyButton = document.createElement('button');
    applyButton.id = 'applyButton';
    applyButton.className = 'button';
    applyButton.textContent = 'Apply';

    // Append the buttons to the button container
    buttonContainer.appendChild(cancelButton);
    buttonContainer.appendChild(applyButton);

    // Append the button container to the div
    formContainer.appendChild(buttonContainer);

    // Add event listeners to the buttons
    cancelButton.addEventListener('click', function () {
        // Handle cancel button click
        formContainer.innerHTML = '';
        document.getElementById(formContainer.dataid).remove();
        toogleAnnotationToolbar(false);
    });

    applyButton.addEventListener('click', function () {
        applyCallback();
        toogleAnnotationToolbar(false);
        document.getElementById(formContainer.dataid).remove();
    });
}

function putMarker(x, y, className) {
    // Create a new div to hold the icon
    let iconDiv = document.createElement('div');
    iconDiv.style.position = 'absolute'; // Make it position: absolute
    iconDiv.style.pointerEvents = 'none'; // Ensure the icon doesn't interfere with pointer events
    iconDiv.style.left = x + 'pt'; // Set the icon's left position
    iconDiv.style.top = y + 'pt'; // Set the icon's top position
    iconDiv.style.zIndex = 100; // Ensure the icon is above the canvas
    iconDiv.style.borderRadius = '4pt';
    iconDiv.style.width = '20pt';
    iconDiv.style.outline = '4px solid #CCC';
    iconDiv.style.padding = '2px';
    iconDiv.style.backgroundColor = '#0d6efd';
    // Set the icon content
    iconDiv.innerHTML = annotationIcnosDict[className];

    const id = "id" + Math.random().toString(16).slice(2);
    iconDiv.id = id;

    // Append the icon div to the canvas
    canvas.parentNode.appendChild(iconDiv);

    return id;
}

function postAnnotation(obj, className) {
    $('#loadingModal').modal('show');
    var d = {};
    d[className] = obj;
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}annotation/add/${documentId}`,
        data: JSON.stringify(d), // Stringify the data to send as JSON
        contentType: 'application/json', // Set the content type to JSON
        dataType: 'json',
        success: function (data) {
            documentId = data.documentId;
            window.folderName = data.documentId;
            window.fileName = "document.pdf";
            GetDocumentInfo();
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
        .done(function () {
            $('#loadingModal').modal('hide');
        });
}

function annotationSetup(className) {

    function PointClick(event) {
        let canvas = document.getElementById('imageTemp');
        var ctx = canvas.getBoundingClientRect();

        // Get the mouse position relative to the canvas

        let ARect = canvas.getBoundingClientRect();

        var x = (event.clientX - ARect.left) * (canvas.width / ARect.width);
        var y = (event.clientY - ARect.top) * (canvas.height / ARect.height);

        var id = putMarker(x, y, className);
        canvas.removeEventListener("mousedown", PointClick, false);

        let mouseX = (event.clientX - ARect.left) * (canvas.width / ARect.width);
        let mouseY = canvas.height - (event.clientY - ARect.top) * (canvas.height / ARect.height);

        // Scale factors for DPI conversion
        let widthScaleFactor = 8.27 / (canvas.width / 72);
        let heightScaleFactor = 11.69 / (canvas.height / 72);

        // Convert the coordinates to A4 PDF DPI
        let pdfMouseX = mouseX * heightScaleFactor;
        let pdfMouseY = mouseY * heightScaleFactor;
        createFormAndInsertIntoDiv(
            function () {
                let obj = getFilledObjectFromForm(className + 'Model', 'annotationForm');
                postAnnotation(obj, className);
                document.getElementById('annotationForm').innerHTML = '';
            },
            id, Math.round(pdfMouseX), Math.round(pdfMouseY), className);

        toogleAnnotationToolbar(true);
    }

    canvas.addEventListener("mousedown", PointClick, false);
}
