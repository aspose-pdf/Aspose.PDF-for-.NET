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

function putMarker(x, y, className){
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
    console.log(JSON.stringify(d));
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
    let canvas = document.getElementById('imageTemp');
        
    function PointClick(event) {
        var ctx = canvas.getBoundingClientRect();

        // Get the mouse position relative to the canvas
        var x = event.clientX - ctx.left;
        var y = event.clientY - ctx.top;

        var id = putMarker(x, y, className);
        canvas.removeEventListener("mousedown", PointClick, false);
        
        let ARect = canvas.getBoundingClientRect();
        var mouseX = (event.clientX - ARect.left) * (canvas.width / ARect.width);
        var mouseY = (event.clientY - ARect.top) * (canvas.height / ARect.height);

        createFormAndInsertIntoDiv(
            function () {
                var obj = getFilledObjectFromForm(className+'Model', 'annotationForm');
                postAnnotation(obj, className);
                document.getElementById('annotationForm').innerHTML = '';
            },
         id, Math.round(mouseX * 0.58), Math.round((913 - mouseY) * 0.8), className);
         
         
          document.getElementById('btnLine').disabled = true;
          document.getElementById('btnSquare').disabled = true;
          document.getElementById('btnCircle').disabled = true;
          document.getElementById('btnPolygon').disabled = true;
          document.getElementById('btnPolyLine').disabled = true;
          document.getElementById('btnInk').disabled = true;
          document.getElementById('btnHighlight').disabled = true;
          document.getElementById('btnUnderline').disabled = true;
          document.getElementById('btnSquiggly').disabled = true;
          document.getElementById('btnStrikeOut').disabled = true;
          document.getElementById('btnStamp').disabled = true;
          document.getElementById('btnCaret').disabled = true;
          document.getElementById('btnWatermark').disabled = true;
          document.getElementById('btnSound').disabled = true;
          document.getElementById('btnMovie').disabled = true;
          document.getElementById('btnScreen').disabled = true;
          document.getElementById('btnText').disabled = true;
          document.getElementById('btnLink').disabled = true;
          document.getElementById('btnFreeText').disabled = true;
          document.getElementById('btnRedact').disabled = true;
          document.getElementById('btnUnderline').disabled = true;
    }

    canvas.addEventListener("mousedown", PointClick, false);
}
