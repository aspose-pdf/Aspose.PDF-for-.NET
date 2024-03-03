function annotationSetup(className) {
    let canvas = document.getElementById('imageTemp');
        
    function PointClick(event) {
        var ctx = canvas.getBoundingClientRect();

        var x = event.clientX - ctx.left;
        var y = event.clientY - ctx.top;
        console.log("x: " + x + " y: " + y);
        canvas.removeEventListener("mousedown", PointClick, false);
        createFormAndInsertIntoDiv(x, y, className);
    }

    canvas.addEventListener("mousedown", PointClick, false);
}
