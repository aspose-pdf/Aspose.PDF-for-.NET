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

function annotationSetup(className) {
    let canvas = document.getElementById('imageTemp');
        
    function PointClick(event) {
        var ctx = canvas.getBoundingClientRect();

        var x = event.clientX - ctx.left;
        var y = event.clientY - ctx.top;
        canvas.removeEventListener("mousedown", PointClick, false);
        createFormAndInsertIntoDiv(x, y, className);

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

        // Append the icon div to the canvas
        canvas.parentNode.appendChild(iconDiv);

    }

    canvas.addEventListener("mousedown", PointClick, false);
}
