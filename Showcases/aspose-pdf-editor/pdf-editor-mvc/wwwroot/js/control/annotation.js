var annotationIcnosDict = {
    "Line": '<i class="bi bi-dash"></i>',
    "Square": '<i class="bi bi-square"></i>',
    "Circle": '<i class="bi bi-circle"></i>',
    "Polygon": '<i class="bi bi-pentagon"></i>',
    "PolyLine": '<i class="bi bi-vector-pen"></i>',
    "Ink": '<i class="bi bi-pen"></i>',
    "Highlight": '<i class="bi bi-pen"></i>',
    "Underline": '<i class="bi bi-type-underline"></i>',
    "Squiggly": '<i class="bi bi-vector-pen"></i>',
    "StrikeOut": '<i class="bi bi-type-strikethrough"></i>',
    "Stamp": '<i class="bi bi-award"></i>',
    "Caret": '<i class="bi bi-caret-down-fill"></i>',
    "Watermark": '<i class="bi bi-water"></i>',
    "Sound": '<i class="bi bi-volume-up"></i>',
    "Movie": '<i class="bi bi-film"></i>',
    "Screen": '<i class="bi bi-display"></i>',
    "Text": '<i class="bi bi-fonts"></i>',
    "Link": '<i class="bi bi-link-45deg"></i>',
    "FreeText": '<i class="bi bi-text-paragraph"></i>',
    "Redact": '<i class="bi bi-eye-slash"></i>',
};


function annotationSetup(className) {
    let canvas = document.getElementById('imageTemp');
        
    function PointClick(event) {
        var ctx = canvas.getBoundingClientRect();

        var x = event.clientX - ctx.left;
        var y = event.clientY - ctx.top;
        console.log("x: " + x + " y: " + y);
        canvas.removeEventListener("mousedown", PointClick, false);
        createFormAndInsertIntoDiv(x, y, className);

        // Create a new div to hold the icon
        let iconDiv = document.createElement('div');
        iconDiv.style.position = 'absolute'; // Make it position: absolute
        iconDiv.style.pointerEvents = 'none'; // Ensure the icon doesn't interfere with pointer events
        iconDiv.style.left = x + 'pt'; // Set the icon's left position
        iconDiv.style.top = y + 'pt'; // Set the icon's top position
        iconDiv.style.zIndex = 100; // Ensure the icon is above the canvas
        // Set the icon content
        iconDiv.innerHTML = annotationIcnosDict[className];

        // Append the icon div to the canvas
        canvas.parentNode.appendChild(iconDiv);

    }

    canvas.addEventListener("mousedown", PointClick, false);
}
