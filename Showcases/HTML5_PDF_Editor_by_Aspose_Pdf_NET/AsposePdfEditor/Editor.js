var ratio = 1;
var canvasHeight;
var canvasWidth;
var currentPage;
Npages = [];
aRatio = [];
var dataLoad;
shapes = [];
shapes2 = [];
Attachments = [];
var fontText = 'Arial';
var fontSize = 16;
var fontWieght = "";
var fontStyle = "";
var fontColor = "black";
var mouseX;
var mouseY;
var textX;
var textY;
var editText = -1;
var imageObj;
var selectedShape = -1;
var searchFolder = "";
var pageHeights = Object.create(null);
var heights;
var myTools = "reading";
var anchorVal = -1;
var signX = 5;
var signY = 5;
var r = 0;

var isDown = false;

// Keep everything in anonymous function, called on window load.
if (window.addEventListener) {
    window.addEventListener('load', function () {
        var canvas, context, canvaso, contexto;

        var tempX;
        var tempY;
        var tempW;
        var tempH;
        var numShapes = 0;
        var dragIndex;
        var dragging;

        var dragHoldX;
        var dragHoldY;
        canvasWidth = 1138;
        canvasHeight = 760;

        // The active tool instance.
        var tool;
        var tool_default;

        function init() {

            // Find the canvas element.
            canvaso = document.getElementById('imageView');
            canvaso.width = canvasWidth;
            canvaso.height = canvasHeight;
            //  shapes = [];

            tempX = 0;
            tempY = 0;
            tempW = 0;
            tempH = 0;
            tool_default = "reading";

            if (!canvaso) {
                alert('Error: I cannot find the canvas element!');
                return;
            }

            if (!canvaso.getContext) {
                alert('Error: no canvas.getContext!');
                return;
            }

            // Get the 2D canvas context.
            contexto = canvaso.getContext('2d');

            if (!contexto) {
                alert('Error: failed to getContext!');
                return;
            }

            // Add the temporary canvas.
            var container = canvaso.parentNode;
            canvas = document.createElement('canvas');
            if (!canvas) {
                alert('Error: I cannot create a new canvas element!');
                return;
            }

            canvas.id = 'imageTemp';
            canvas.width = canvaso.width;
            canvas.height = canvaso.height;
            container.appendChild(canvas);
            context = canvas.getContext('2d');



            // Get the tool select input.
            var tool_select = document.getElementById('btnRect');
            var tool_select2 = document.getElementById('btnRead');
            var tool_select3 = document.getElementById('btnDrag');
            var tool_select4 = document.getElementById('btnTexting');
            var tool_select5 = document.getElementById('btnSignature');

            if (!tool_select) {
                alert('Error: failed to get the dtool element!');
                return;
            }
            tool_select.addEventListener('click', ev_tool_change);
            tool_select2.addEventListener('click', ev_tool_change2);
            tool_select3.addEventListener('click', ev_tool_change3);
            tool_select4.addEventListener('click', ev_tool_change4);
            tool_select5.addEventListener('click', ev_tool_change5);

            // Activate the default tool.
            if (tools[tool_default]) {
                tool = new tools[tool_default]();
                tool_select.value = tool_default;
            }

            // Attach the mousedown, mousemove and mouseup event listeners.
            canvas.addEventListener('mousedown', ev_canvas, false);
            canvas.addEventListener('mousemove', ev_canvas, false);
            canvas.addEventListener('mouseup', ev_canvas, false);
        }

        // The general-purpose event handler. This function just determines the mouse 
        // position relative to the canvas element.
        function ev_canvas(ev) {
            if (ev.layerX || ev.layerX == 0) { // Firefox
                ev._x = ev.layerX;
                ev._y = ev.layerY;
            } else if (ev.offsetX || ev.offsetX == 0) { // Opera
                ev._x = ev.offsetX;
                ev._y = ev.offsetY;
            }

            // Call the event handler of the tool.
            var func = tool[ev.type];
            if (func) {
                func(ev);

            }

        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change(ev) {

            if (tools['rect'] && myTools == 'Rect') {
                tool = new tools['rect']();

            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change2(ev) {

            if (tools['reading'] && myTools == 'Read') {
                tool = new tools['reading']();

            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change3(ev) {

            if (tools['dragging'] && myTools == 'Drag') {
                tool = new tools['dragging']();

            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change4(ev) {

            if (tools['texting']) {
                tool = new tools['texting']();

            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change5(ev) {

            if (tools['signature'] && myTools == 'signature') {
                tool = new tools['signature']();

            }
        }

        // This function draws the #imageTemp canvas on top of #imageView, after which 
        // #imageTemp is cleared. This function is called each time when the user 
        // completes a drawing operation.
        function img_update() {
            contexto.drawImage(canvas, 0, 0);
            context.clearRect(0, 0, canvas.width, canvas.height);
        }

        // This object holds the implementation of each drawing tool.
        var tools = {};

        // The rectangle tool.
        tools.rect = function () {
            var tool = this;
            this.started = false;

            this.mousedown = function (ev) {
                if (myTools == 'Rect') {
                    tool.started = true;
                    tool.x0 = ev._x;
                    tool.y0 = ev._y;
                }
            };

            this.mousemove = function (ev) {
                if (!tool.started) {
                    return;
                }

                var x = Math.min(ev._x, tool.x0),
          y = Math.min(ev._y, tool.y0),
          w = Math.abs(ev._x - tool.x0),
          h = Math.abs(ev._y - tool.y0);

                context.clearRect(0, 0, canvas.width, canvas.height);

                if (!w || !h) {
                    return;
                }

                context.fillStyle = 'rgba(255, 230, 81, 0.5)';
                context.fillRect(x, y, w, h);

                tempX = x;
                tempY = y;
                tempW = w;
                tempH = h;
                numShapes = numShapes + 1;

            };

            this.mouseup = function (ev) {
                if (tool.started) {
                    tool.mousemove(ev);
                    tool.started = false;
                    img_update();
                    tempShape = { x: tempX, y: tempY, w: tempW, h: tempH, p: currentPage, f: Npages[currentPage - 1], t: "", n: "", s: "", c: "", wt: "", st: "", ratio: aRatio[currentPage - 1], imfile: "", imName: "", Itype: "highlight", fieldType: "" };
                    shapes.push(tempShape);
                }
            };
        };

        // The signature tool.
        tools.signature = function (ev) {

            var tool = this;
            this.started = false;

            this.mousedown = function (ev) {


                var ARect = canvas.getBoundingClientRect();
                mouseX = (ev.clientX - ARect.left) * (canvas.width / ARect.width);
                mouseY = (ev.clientY - ARect.top) * (canvas.height / ARect.height);

                $('#divSignature').css('visibility', 'visible');
                $('#divSignature').css('left', mouseX);
                $('#divSignature').css('top', mouseY);

                signX = mouseX;
                signY = mouseY;

                var signatureCanvas = document.querySelector('#signCanvas');
                var ctx = signatureCanvas.getContext('2d');

                var mouse = { x: 0, y: 0 };
                var last_mouse = { x: 0, y: 0 };

                /* Mouse Capturing Work */
                signatureCanvas.addEventListener('mousemove', function (ev) {
                    last_mouse.x = mouse.x;
                    last_mouse.y = mouse.y;

                    var bRect = signatureCanvas.getBoundingClientRect();
                    mouse.x = (ev.clientX - bRect.left) * (signatureCanvas.width / bRect.width);
                    mouse.y = (ev.clientY - bRect.top) * (signatureCanvas.height / bRect.height);

                }, false);


                /* Drawing on Paint App */
                ctx.lineWidth = 5;
                ctx.lineJoin = 'round';
                ctx.lineCap = 'round';
                ctx.strokeStyle = 'blue';

                signatureCanvas.addEventListener('mousedown', function (ev) {


                    signatureCanvas.addEventListener('mousemove', onPaint, false);
                }, false);

                signatureCanvas.addEventListener('mouseup', function () {
                    signatureCanvas.removeEventListener('mousemove', onPaint, false);
                }, false);

                var onPaint = function () {
                    ctx.beginPath();
                    ctx.moveTo(last_mouse.x, last_mouse.y);
                    ctx.lineTo(mouse.x, mouse.y);
                    ctx.closePath();
                    ctx.stroke();
                };
            }
        };

        // The reading tool.
        tools.reading = function () {
            var tool = this;
            this.started = false;
        };


        // The reading tool.
        tools.dragging = function () {
            var tool = this;
            this.started = false;
            // canvas.addEventListener("mousedown", mouseDownListener, false);
            this.mousedown = function (ev) {

                if (myTools == 'Drag') {
                    tool.started = true;
                    tool.x0 = ev._x;
                    tool.y0 = ev._y;

                    var i;
                    //We are going to pay attention to the layering order of the objects so that if a mouse down occurs over more than object,
                    //only the topmost one will be dragged.
                    var highestIndex = -1;

                    //getting mouse position correctly, being mindful of resizing that may have occured in the browser:
                    var bRect = canvas.getBoundingClientRect();
                    mouseX = (ev.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (ev.clientY - bRect.top) * (canvas.height / bRect.height);

                    //find which shape was clicked
                    for (i = 0; i < shapes.length; i++) {

                        if (hitTest(shapes[i], mouseX, mouseY, context) || rotateTest(shapes[i], mouseX, mouseY, context)) {

                            if (anchorHitTest(shapes[i], mouseX, mouseY, context) == -1) {


                                dragging = true;
                                anchorVal = -1;
                                isDown = false;
                            }
                            else {

                                if (shapes[i].Itype == 'image') {
                                    dragging = false;
                                    isDown = false;
                                }
                                else if (shapes[i].Itype == 'text' && anchorVal == 5) {

                                    dragging = false;
                                    isDown = true;
                                }
                                else {
                                    dragging = true;
                                    anchorVal = -1;
                                    isDown = false;
                                }
                            }
                            selectedShape = i;
                            if (i > highestIndex) {
                                //We will pay attention to the point on the object where the mouse is "holding" the object:
                                dragHoldX = mouseX - shapes[i].x;
                                dragHoldY = mouseY - shapes[i].y;
                                highestIndex = i;
                                dragIndex = i;

                                var rect = canvas.getBoundingClientRect();


                               if (shapes[dragIndex].Itype != 'text') {
                                    context.strokeStyle = 'brown';
                                    context.setLineDash([6]);
                                    context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].w, shapes[dragIndex].h);
                                }


                                if (shapes[dragIndex].Itype == 'image') {

                                    context.fillStyle = 'rgba(255, 230, 81, 1)';
                                    context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                                    context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, shapes[dragIndex].y, 10, 10);
                                    context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);
                                    context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);

                                }
                                else if (shapes[dragIndex].Itype == 'text') {
                                       drawRotationHandle(shapes[dragIndex], context);
                                 //   context.fillStyle = "blue";
                                 //   context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, (shapes[dragIndex].y + shapes[dragIndex].h/2) - 5, 10, 10);
                                }
                                mouseX = ev.pageX - canvas.offsetLeft;
                                mouseY = ev.pageY - canvas.offsetTop;



                                $('#divDel').css('visibility', 'visible');
                                // $('#divDel').css('left', rect.left + shapes[dragIndex].x + shapes[dragIndex].w);
                                $('#divDel').css('left', rect.left + shapes[dragIndex].x - 50);
                                $('#divDel').css('top', rect.top + shapes[dragIndex].y);
                                //                                var isDown = context.isPointInPath(mouseX, mouseY);
                                //                                if (isDown) {
                                //                                    alert(isDown);
                                //                                }
                                break;
                            }
                        }
                        else {

                            $('#divDel').css('visibility', 'hidden');
                            document.getElementById('imageView').getContext('2d').width = document.getElementById('imageTemp').getContext('2d').width;
                            drawScreen();
                            DrawShapes();

                        }
                    }

                    //code below prevents the mouse down from having an effect on the main browser window:
                    if (ev.preventDefault) {
                        ev.preventDefault();
                    } //standard
                    else if (ev.returnValue) {
                        ev.returnValue = false;
                    } //older IE
                    return false;
                }
            };

            this.mousemove = function (evt) {

                if (!tool.started) {
                    return;
                }

                if (dragging) {

                    var posX;
                    var posY;
                    //getting mouse position correctly 
                    var bRect = canvas.getBoundingClientRect();
                    mouseX = (evt.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (evt.clientY - bRect.top) * (canvas.height / bRect.height);

                    //clamp x and y positions to prevent object from dragging outside of canvas
                    posX = mouseX - dragHoldX;

                    posY = mouseY - dragHoldY;


                    shapes[dragIndex].x = posX;
                    shapes[dragIndex].y = posY;

                    canvas.width = canvas.width;


                    drawScreen();

                    DrawShapes();

                    mouseX = evt.pageX - canvas.offsetLeft;
                    mouseY = evt.pageY - canvas.offsetTop;


                    if (shapes[dragIndex].Itype != 'text') {
                        context.strokeStyle = 'brown';
                        context.setLineDash([6]);
                        context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].w, shapes[dragIndex].h);
                    }
                    if (shapes[dragIndex].Itype == 'image') {

                        context.fillStyle = 'rgba(255, 230, 81, 1)';
                        context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                        context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, shapes[dragIndex].y, 10, 10);
                        context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);
                        context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);

                    }
                    else if (shapes[dragIndex].Itype == 'text') {

                        drawRotationHandle(shapes[dragIndex], context);

                    }


                    $('#divDel').css('visibility', 'hidden');

                }

                else if (isDown) {
                    var posX;
                    var posY;
                    //getting mouse position correctly 
                    var bRect = canvas.getBoundingClientRect();
                    mouseX = (evt.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (evt.clientY - bRect.top) * (canvas.height / bRect.height);

                    //clamp x and y positions to prevent object from dragging outside of canvas
                    posX = mouseX - dragHoldX; // -(canvas.width / 2);
                    // alert(mouseX);

                    posY = mouseY - dragHoldY; // -(canvas.height / 2);

                    

                    var dx = mouseX - shapes[dragIndex].x + (shapes[dragIndex].w) / 2;
                    var dy = mouseY - shapes[dragIndex].y + (shapes[dragIndex].h) / 2;
                    var angle = Math.atan2(dy, dx);
                    r = angle;

                    shapes[dragIndex].fieldType = r;

                    
                    drawScreen();

                    DrawShapes();

                    drawRotationHandle(shapes[dragIndex], context);

                }
                else {


                    var posX;
                    var posY;
                    //getting mouse position correctly 
                    var bRect = canvas.getBoundingClientRect();
                    mouseX = (evt.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (evt.clientY - bRect.top) * (canvas.height / bRect.height);

                    //clamp x and y positions to prevent object from dragging outside of canvas
                    posX = mouseX - dragHoldX;
                    // alert(mouseX);

                    posY = mouseY - dragHoldY;

                    imgWidth = (shapes[dragIndex].x + shapes[dragIndex].w);
                    imgHeight = (shapes[dragIndex].y + shapes[dragIndex].h)

                    // resize the image
                    switch (anchorVal) {
                        case 0:
                            //top-left
                            shapes[dragIndex].x = posX;
                            shapes[dragIndex].y = posY;
                            shapes[dragIndex].w = imgWidth - posX;
                            shapes[dragIndex].h = imgHeight - posY;
                            break;
                        case 1:
                            //top-right
                            shapes[dragIndex].y = posY;
                            shapes[dragIndex].w = shapes[dragIndex].w - (imgWidth - mouseX);
                            shapes[dragIndex].h = imgHeight - posY;
                            break;
                        case 2:
                            //bottom-right
                            shapes[dragIndex].x = posX;
                            shapes[dragIndex].w = imgWidth - posX;
                            shapes[dragIndex].h = shapes[dragIndex].h - (imgHeight - mouseY);
                            break;
                        case 3:
                            //bottom-left
                            shapes[dragIndex].w = shapes[dragIndex].w - (imgWidth - mouseX);
                            shapes[dragIndex].h = shapes[dragIndex].h - (imgHeight - mouseY);
                            break;

                    }


                    if (shapes[dragIndex].w < 25) { shapes[dragIndex].w = 25; }
                    if (shapes[dragIndex].h < 25) { shapes[dragIndex].h = 25; }

                    canvas.width = canvas.width;


                    drawScreen();

                    DrawShapes();

                    if (shapes[dragIndex].Itype != 'text') {
                        context.strokeStyle = 'brown';
                        context.setLineDash([6]);
                        context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].w, shapes[dragIndex].h);
                    }
                    else if (shapes[dragIndex].Itype == 'text') {

                        drawRotationHandle(shapes[dragIndex], context);
                    
                    }
                    if (shapes[dragIndex].Itype == 'image') {

                        context.fillStyle = 'rgba(255, 230, 81, 1)';
                        context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                        context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, shapes[dragIndex].y, 10, 10);
                        context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);
                        context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);

                    }

                    mouseX = evt.pageX - canvas.offsetLeft;
                    mouseY = evt.pageY - canvas.offsetTop;

                    $('#divDel').css('visibility', 'hidden');

                }

            };

            this.mouseup = function (evt) {

                if (tool.started) {
                    tool.started = false;
                }
                isDown = false;
                if (dragging) {
                    var rect = canvas.getBoundingClientRect();
                    $('#divDel').css('visibility', 'visible');
                    //$('#divDel').css('left', rect.left + shapes[dragIndex].x + shapes[dragIndex].w);
                    $('#divDel').css('left', rect.left + shapes[dragIndex].x - 50);
                    $('#divDel').css('top', rect.top + shapes[dragIndex].y);

                    dragging = false;
                    

                }
            };

        };

        //Testing
        // The reading tool.
        tools.texting = function () {

            var tool = this;
            this.started = false;
            this.mousedown = function (ev) {

                if (myTools == 'Text') {
                    tool.started = true;
                    tool.x0 = ev._x;
                    tool.y0 = ev._y;

                    textX = ev._x;
                    textY = ev._y;

                    $('#textareaTest').val("");


                    //find which shape was clicked
                    for (i = 0; i < shapes.length; i++) {
                        if (shapes[i].t != "") {

                            if (hitTest(shapes[i], textX, textY, context)) {
                                editText = i;
                                $('#textareaTest').val(shapes[i].t);
                                break;
                            }
                            else {
                                editText = -1;
                            }
                        }
                    }


                    mouseX = ev.pageX - canvas.offsetLeft;
                    mouseY = ev.pageY - canvas.offsetTop;

                    $('#textAreaPopUp').css('visibility', 'visible');
                    $('#textAreaPopUp').css('left', mouseX);
                    $('#textAreaPopUp').css('top', mouseY);
                    var editor = $('#textareaTest');
                    editor.focus();
                }
            };

            this.mousemove = function (evt) {

                if (!tool.started) {
                    return;
                }



            };

            this.mouseup = function (evt) {

                if (tool.started) {
                    tool.started = false;
                }
                if (dragging) {
                    dragging = false;
                }
            };

        };
        //EndTesting

        $('#myColors').on('shown.bs.modal', function (e) {


            $('#myColors').modal().css('top', $('#textAreaPopUp').position().top);
            $('#myColors').modal().css('left', $('#textAreaPopUp').position().left);


        });


        $(".btn-group > .btn").click(function () {
            $(".btn-group > .btn").removeClass("active");
            $(this).addClass("active");
        });



        init();



    }, false);
}


function saveTextFromArea() {

    
    //get the value of the textarea
    var text = $('#textareaTest').val();
    $('#textAreaPopUp').css('visibility', 'hidden');

    if (text != "") {

        r = 0;
        var canvas = document.getElementById('imageView');
        var ctx = canvas.getContext('2d');

        if (editText == -1) {
            //set the font styles
            ctx.fillStyle = fontColor;

            //draw the text
            ctx.font = fontStyle + " " + fontWieght + " " + fontSize + "px " + fontText;

            ctx.fillText(text, textX, textY + parseInt(fontSize));

            tempShape = { x: textX, y: textY, w: ctx.measureText(text).width, h: parseInt(fontSize), p: currentPage, f: Npages[currentPage - 1], t: text, n: fontText, s: fontSize, c: fontColor, wt: fontWieght, st: fontStyle, ratio: aRatio[currentPage - 1], imfile: "", imName: "", Itype: "text", fieldType: r };
            shapes.push(tempShape);

        }
        else {

            shapes[editText].t = text;
            shapes[editText].wt = fontWieght;
            shapes[editText].s = fontSize;
            shapes[editText].n = fontText;
            shapes[editText].st = fontStyle;
            shapes[editText].c = fontColor;
            shapes[editText].h = parseInt(fontSize);

            drawScreen();
            DrawShapes();
            shapes[editText].w = ctx.measureText(text).width;
        }
        ctx.save();
        ctx.restore();
    }
}

function DrawPic(imageId) {

    var canvas = document.getElementById('imageView');
    canvas.height = pageHeights[imageId];

    var canvas2 = document.getElementById('imageTemp');
    canvas2.height = pageHeights[imageId];
 
    var context = canvas.getContext('2d');
    
    context.clearRect(0, 0, canvas.width, canvas.height);

    var image1 = "";
    var rand = Math.random();

    if ($("#hdnMove").val() == "searching") {
        image1 = 'search/' + searchFolder + "/" + imageId;
    }
    else {
          

        image1 = 'Input/'.concat(imageId);
    }
    
    $("#imageView").css('background-image', 'url(' + image1 + "?Dummy="+ rand + ')');

    return true;

}

function Previous() {

   
    if (currentPage > 1) {
        currentPage = currentPage - 1;
        drawScreen();
        DrawPic(Npages[currentPage - 1]);
        var promise = jQuery.when().promise();
        promise = promise.then(wait);
        promise.done(function () {
            DrawShapes();
            manageFields();
        });
    }
    
    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length; ;

    
}

function AddPage() {

    sendAdd();
    
}

function sendAdd() {

   
    $('#loadingModal').modal('show');
    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/AddPage_Click',
        data: '{ "lastpage" : "' + Npages[Npages.length - 1] + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            Npages.push(data.d);
            document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
            $('#loadingModal').modal('hide');
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            $('#loadingModal').modal('hide');
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}


function DeletePage() {

    sendDelete();
    
}

function sendDelete() {

   
    $('#loadingModal').modal('show');
    var deleteData = JSON.stringify({ 'imageData': currentPage, 'imageName': Npages[currentPage-1] });
    // Sending the image data to Server
    return $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/DeletePage_Click',
        data: deleteData,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            updateIndexesDelete();
            $('#loadingModal').modal('hide');
        },

        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            $('#loadingModal').modal('hide');
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}

function updateIndexesDelete() {

    DeleteShapes();

    Npages.splice(currentPage - 1, 1);

    if (currentPage > Npages.length) {

       currentPage = Npages.length
        }

   DrawPic(Npages[currentPage - 1]);
   document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}

function DeleteShapes() {

    var i;

    for (i = 0; i < shapes.length; i++) {
        if (shapes[i].p == Npages[currentPage-1]) {

            shapes.splice(i, 1);
        }
    }
    
}

function DelShape() {

    $('#divDel').css('visibility', 'hidden');
    drawScreen();
    
    shapes.splice(selectedShape, 1);
    DrawShapes();
    
    selectedShape = -1;
}


function Next() {

    if (currentPage < Npages.length) {
        currentPage = currentPage + 1;
        drawScreen();
        DrawPic(Npages[currentPage - 1]);
        var promise = jQuery.when().promise();
        promise = promise.then(wait);
        promise.done(function () {
            DrawShapes();
            manageFields();
        });
        
        
    }

    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length; ;
}

function wait(ms) {
    var deferred = jQuery.Deferred();
    var intervalId = setInterval(function () {
        clearInterval(intervalId);
        deferred.resolve();
    }, 100);
    return deferred.promise();
}

function ReplaceText() {

    var txtFind = $("#txtFind").val();
    var txtReplace = $("#txtReplace").val();
    var movedata = JSON.stringify({ 'txtFind': txtFind, 'txtReplace': txtReplace, 'pageList': Npages });

    $('#loadingModal').modal('show');
    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/ReplaceText',
        data: movedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) { AfterSearch();  $('#loadingModal').modal('hide'); },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            $('#loadingModal').modal('hide');
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}
function Move() {

    var moveTo = $("#txtMove").val();
    if ($("#hdnMove").val() == "moving") {
        movedata = JSON.stringify({ 'moveFrom': currentPage, 'moveTo': moveTo, 'pageList': Npages });

        $('#loadingModal').modal('show');
        // Sending the image data to Server
        $.ajax({
            type: 'POST',
            url: 'CanvasSave.aspx/MovePages',
            data: movedata,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, textStatus, jqXHR) { Npages = data.d; MoveUpdate(); $('#loadingModal').modal('hide'); },
            //call on ajax call failure
            error: function (xhr, textStatus, error) {
                $('#loadingModal').modal('hide');
                //called on ajax call success
                alert("Error: " + xhr.responseJSON.Message);
            }

        });
    }
    else {

        $('#loadingModal').modal('show');
        movedata = JSON.stringify({ 'searchText': moveTo, 'pageList': Npages });
        // Sending the image data to Server
        $.ajax({
            type: 'POST',
            url: 'CanvasSave.aspx/SearchData',
            data: movedata,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, textStatus, jqXHR) { searchFolder = data.d; AfterSearch(); $('#loadingModal').modal('hide'); },
            //call on ajax call failure
            error: function (xhr, textStatus, error) {
                $('#loadingModal').modal('hide');
                //called on ajax call success
                alert("Error: " + xhr.responseJSON.Message);
            }

        });
    
    
    }
}


function ClearSearchClicked() {

    $("#hdnMove").val("");

    drawScreen();
    DrawPic(Npages[currentPage - 1]);
    var promise = jQuery.when().promise();
    promise = promise.then(wait);
    promise.done(function () {
        DrawShapes();
    });


}

function AfterSearch() {

    drawScreen();
    DrawPic(Npages[currentPage-1]);
    var promise = jQuery.when().promise();
    promise = promise.then(wait);
    promise.done(function () {
        DrawShapes();
    });



}

function btnExportClick() {

    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'Default.aspx/btnExportPDFClick',
        data: '{}',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json'
        
    });

}
function First() {

    var dataP = dataLoad.split('%#');
    Npages = dataP[0].split(',');
    aRatio = dataP[1].split(',');
    heights = dataP[2].split(',');
    fieldData = dataP[3];
    addFields(fieldData);
    for (var i = 0; i < heights.length; i++) {

        pageHeights[Npages[i]] = heights[i];
    
    }

    if ($("#hdnOpp").val() == 'uploading' || $("#hdnOpp").val() == 'dbox' || $("#hdnOpp").val() == 'Empty') {
        currentPage = 1;
        onStartup();
        
    }

    DrawPic(Npages[currentPage - 1]);
    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length; ;
    DrawShapes();

    manageFields();
}

function MoveUpdate() {

  
    for (var i = 0; i < Npages.length; i++) {
        for (var j = 0; j < shapes.length; j++) {

            if (Npages[i] == shapes[j].f) {
                shapes[j].p = i + 1;
            }
        }
    
    }
    drawScreen();
    
    DrawPic(Npages[currentPage - 1]);

    DrawShapes();

    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;

   // $('#inputModal').modal('hide');
}

function UploadPic() {

    sendFile();

}

function sendFile() {

    $('#loadingModal').modal('show');
    var filename = 'image'.concat(currentPage).concat('.png');


    shapes2 = [];

    for (var i = 0; i < shapes.length; i++) {

        tempShape = { x: shapes[i].x, y: shapes[i].y, w: shapes[i].w, h: shapes[i].h, p: shapes[i].p, f: shapes[i].f, t: shapes[i].t, n: shapes[i].n, s: shapes[i].s, c: shapes[i].c, wt: shapes[i].wt, st: shapes[i].st, ratio: shapes[i].ratio, imfile: "", imName: shapes[i].imName, Itype: shapes[i].Itype, fieldType: shapes[i].fieldType };
        
        shapes2.push(tempShape);         
        
    }

    wholedata = JSON.stringify({ 'shapes': shapes2, 'filename': filename, 'aspectRatio': ratio.toString() });

    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/UploadPic',
        data: wholedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) { $('#loadingModal').modal('hide'); alert('File Saved'); },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {

            $('#loadingModal').modal('hide');
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);

        }

    });
}


function drawScreen() {
    //bg

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.width, canvas.height);

    document.getElementById('imageTemp').getContext('2d').clearRect(0, 0, canvas.width, canvas.height);

}

function DrawShapes() {

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');  
    

    var i;
    for (i = 0; i < shapes.length; i++) {
        if (shapes[i].f == Npages[currentPage - 1]) {
          
            if (shapes[i].Itype == "highlight") {
                context.fillStyle = 'rgba(255, 230, 81, 0.5)';
                context.fillRect(shapes[i].x, shapes[i].y, shapes[i].w, shapes[i].h);
            }
            if (shapes[i].Itype == "image") {

                var image1 = 'Images/'.concat(shapes[i].imfile);

                imageObj = shapes[i].imfile;

                context.drawImage(imageObj, shapes[i].x, shapes[i].y, shapes[i].w, shapes[i].h);
            
            }
            if (shapes[i].Itype== "text") {

               
                context.save();
                context.translate(shapes[i].x, shapes[i].y + parseInt(shapes[i].s));

                context.rotate(shapes[i].fieldType);

                //set the font styles
                var font = shapes[i].n;
                var fontsize = shapes[i].s;
                var fontweight = shapes[i].wt;
                var fontstyle = shapes[i].st;
                context.fillStyle = shapes[i].c;

                //draw the text
                context.font = fontstyle + " " + fontweight + " " + fontsize + "px " + font;

                context.fillText(shapes[i].t, 0,0);

                context.restore();
            }

        }
}    

}

$(document).on("click", ".open-myModal", function () {
  
    var myId = $(this).data('id');

    $("#hdnOpp").val(myId);

})

$(document).on("click", ".open-moveModal", function () {
  
    var myId = $(this).data('id');
    
    $("#hdnMove").val(myId);

    if (myId == "searching") {

        $('#btnMove').html("Search")
        $("#H1").html("Search Text");
        $("#lblpagemove").html("Enter Text to Search");
        //    $("#btnMove").val("Search");
    }
    else {

        $('#btnMove').html("Move")
        $("#H1").html("Move Page After");
        $("#lblpagemove").html("Enter Page Number");
    }
})

function fileSelected() {


    var fd = new FormData();
    fd.append("fileToUpload", document.getElementById('fileToUpload').files[0]);
    fd.append("Opp", $("#hdnOpp").val());


    if ($("#hdnOpp").val() == "appending") {
        fd.append("pages", Npages);
        fd.append("ratios", aRatio);
        fd.append("heights", heights);
    }
    var xhr = new XMLHttpRequest();
    xhr.open("POST", "CanvasSave.aspx");
    xhr.onload = function () {
       // progress.value = progress.innerHTML = 100 + '%';
    };

    xhr.upload.onprogress = function (event) {
        if (event.lengthComputable) {
            var complete = (event.loaded / event.total * 99 | 0);
            $(".progress-bar").width('60%');
        }
    }




    xhr.onreadystatechange = function () {
        if (xhr.readyState == 4) {
            data = (xhr.responseText);
            dataLoad = data;

            if (data.indexOf("Evaluation") == -1) {

                if ($("#hdnOpp").val() == "appending") {
                    First();
                }
                else if ($("#hdnOpp").val() == "uploading") {

                    for (i = 0; i < shapes.length; i++) {

                        var shapeDiv = document.getElementById("div_" + shapes[i].imName + "");

                        var shape = document.getElementById(shapes[i].imName);
                        if (shape != null) {

                            $('#' + shapes[i].imName + '').remove();
                        }

                        if (shapeDiv != null) {

                            shapeDiv.parentNode.removeChild(shapeDiv);
                        }

                    }

                    shapes2.length = 0;
                    shapes.length = 0;
                    Attachments.length = 0;
                    CheckLicense();
                    GetAttachments();
                    First();


                }
                else if ($("#hdnOpp").val() == "addAttachment") {
                    GetAttachments();
                }
                else {


                    InsertImages(data, 50, 50);

                }
            }
            else {

                alert(data);
            }
            $(".progress-bar").width('100%');
            $("#myModal").modal("hide");

            $("#fileToUpload").wrap('<form>').parent('form').trigger('reset');
            $("#fileToUpload").unwrap();
            $("#fileToUpload").prop('files')[0] = null;
            $("#fileToUpload").replaceWith($("#fileToUpload"));
            $(".progress-bar").width('0%');
        }
    }

    xhr.send(fd);
}

function anchorHitTest(shape,x, y, context) {

    var dx, dy;

    anchorVal = -1;

    if (x > shape.x && x < (shape.x + 10) && y < (shape.y + 10) && y > shape.y && shape.Itype == 'image') {

        anchorVal = 0;
        return anchorVal;
    }
    else if (x > (shape.x + shape.w - 10) && x < (shape.x + shape.w) && y < (shape.y + 10) && y > shape.y && shape.Itype == 'image') {

        anchorVal = 1;

        return anchorVal;
    }
    else if (x > shape.x && x < (shape.x + 10) && y > (shape.y + shape.h - 10) && y < (shape.y + shape.h) && shape.Itype == 'image') {

        anchorVal = 2;
        return anchorVal;
    }
    else if (x > (shape.x + shape.w - 10) && x < (shape.x + shape.w) && y > (shape.y + shape.h - 10) && y < (shape.y + shape.h) && shape.Itype == 'image') {
        anchorVal = 3;
        return anchorVal;
    }

    else if (x > (shape.x + shape.w - 5) && x < (shape.x + shape.w + 5) && y < (shape.y + (shape.h / 2) + 10) && y > (shape.y + (shape.h / 2) - 10) && shape.Itype == 'text') {

        anchorVal = 5;

        return anchorVal;
    }
    else if (shape.Itype == 'text') {

        context.save();

        context.translate(shape.x, shape.y + parseInt(shape.s));
        context.rotate(shape.fieldType);

        context.beginPath();
        context.rect(shape.w - 5, (shape.h / -2) - 5, 10, 10);

        var result = context.isPointInPath(x, y);

        context.restore();
        if (result) {

            anchorVal = 5;
        }
        return anchorVal;

    }
    else { return -1; }

}

function hitTest(shape, mx, my, context) {

    if (shape.Itype == 'text') {

        context.save();
        
        context.translate(shape.x, shape.y + parseInt(shape.s));
        context.rotate(shape.fieldType);
                
        context.beginPath();
        context.rect(0, -shape.h, shape.w+5, shape.h);

        var result = context.isPointInPath(mx, my);

        context.restore();

        return result;
    }

    //if (shape.Itype != 'text') {
        if (mx > shape.x && mx < shape.x + shape.w) {
            if (my > shape.y && my < shape.y + shape.h) {
                return true;
            }
            else {

                return false;
            }
        }
   // }
//    else if (shape.Itype == 'text') {

//        context.save();
//        context.translate(shape.x + (shape.w / 2), shape.y + (shape.h / 2));
//        context.rotate(shape.fieldType);

//     //   context.fillStyle = 'green';
//     //   context.fillRect(mx - (shape.x + shape.w), my - (shape.y + shape.h), shape.w, shape.h);

//        if (mx > shape.x && mx < shape.x + shape.w) {
//            if (my > shape.y && my < shape.y + shape.h) {
//                context.restore();
//                return true;
//            }
//            else {
//                context.restore();
//                return false;
//            }
//        }
//    }
    else {

        return false;
    }

}

function rotateTest(shape, mx, my, context) {

    
//    if (shape.Itype == 'text') {

//        drawRotationHandle(shape,context);
//        anchorVal = 5;
//    }
//    
//    var down = context.isPointInPath(mx, my);

    return false;
}

function SaveToDisk() {

    window.open('Convert/output.pdf', '_blank');
}

function InsertImages(data, imgLeft, imgTop) {

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');


    var bRect = canvas.getBoundingClientRect();

    var image1 = 'Images/'.concat(data);
    var imgWidth = 0;
    var imgHeight = 0;
    
    imageObj = new Image();

    imageObj.onload = function () {
        context.drawImage(imageObj, imgLeft, imgTop);
        imgWidth = this.width;
        imgHeight = this.height;
        
        tempShape = { x: imgLeft, y: imgTop, w: imgWidth, h: imgHeight, p: currentPage, f: Npages[currentPage - 1], t: "", n: "", s: "", c: "", wt: "", st: "", ratio: aRatio[currentPage - 1], imfile: imageObj, imName: data, Itype: "image", fieldType: "" };
        shapes.push(tempShape);
        
    };
    imageObj.src = image1;
    imageObj.style.zIndex = 500 + shapes.length;
    
    
   
    
}

function SaveToText(fileType) {

    // Create an IFRAME.
    var iframe = document.createElement("iframe");

    // Point the IFRAME to GenerateFile
    iframe.src = "CanvasSave.aspx?Download=" +fileType;

    // This makes the IFRAME invisible to the user.
    iframe.style.display = "none";

    // Add the IFRAME to the page.  This will trigger a request to GenerateFile now.
    document.body.appendChild(iframe); 

    
}

function CheckLicense() {

    
    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/CheckLicense',
        data: '{ }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {

        
            if (data.d == true) {

            }
            else {
                alert('Only 4 elements of each collection are loaded due to evaluation version limitations. To avoid these limitations, please get a free trial license from Aspose Sales.');
            }

        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            $('#loadingModal').modal('hide');
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}

function SaveText(fileType) {

    $('#loadingModal').modal('show');

    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/btnTextExport_Click',
        data: '{ "fileType" : "' + fileType + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) { SaveToText('Convert/' + data.d); $('#loadingModal').modal('hide'); },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            $('#loadingModal').modal('hide');
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}


function ddFontChange() {

    var dFont = document.getElementById('ddFont');
    fontText = dFont.options[dFont.selectedIndex].value;

    $('#textareaTest').css('font-family', fontText);
}

function ddSizeChange() {

    var dSize = document.getElementById('ddSize');
    fontSize = dSize.options[dSize.selectedIndex].value;

    $('#textareaTest').css('font-size', fontSize + "px");
}



function makeBold() {

    if ($('#btnBold').hasClass('active')) {

        $('#textareaTest').css('font-weight', 'normal');
        fontWieght = "normal";
    }
    else {
        $('#textareaTest').css('font-weight', 'bold');
        fontWieght = "bold";
    }
}

function makeItalic() {

    if ($('#btnItalic').hasClass('active')) {

        $('#textareaTest').css('font-style', 'italic');
        fontStyle = "";
    }
    else {
        $('#textareaTest').css('font-style', 'italic');
        fontStyle = "italic";
    }
}

function selectColor(color_this) {

    $('#textareaTest').css('color', color_this.name);
    $('#btnColor').css('background-color', color_this.name);
    fontColor = color_this.name;
    $('#myColors').modal('hide');
}

function closeTextEditor() {

    $('#textAreaPopUp').css('visibility', 'hidden');
    
}



function onDropboxChooserClicked(from) {
    if (!Dropbox.isBrowserSupported()) {
        alert("Your browser is not supported to use this feature.");
        return false;
    }
    Dropbox.choose({
        success: function (files) {
            var link = files[0].link;
            // alert(link);
            $("#hdnOpp").val('dbox');
            // $('#Image1').css("zIndex", 10)
            $('#loadingModal').modal('show'); //.html('<img src="loading.gif"> loading...');
            wholedata = JSON.stringify({ 'file_url': link, 'process': from});
            
                
                // Sending the image data to Server
                $.ajax({
                    type: 'POST',
                    url: 'CanvasSave.aspx/Download_Dropbox',
                    data: wholedata,
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (data, textStatus, jqXHR) {
                    if (from == 'upload') {
                        dataLoad = data.d;
                        First();
                        
                        }
                        else{

                            InsertImages(data.d, 50, 50);
                        }
                        $('#loadingModal').modal('hide');
                    },
                    //call on ajax call failure
                    error: function (xhr, textStatus, error) {
                        $('#loadingModal').modal('hide');
                        //called on ajax call success
                        alert("Error: " + xhr.responseJSON.Message);

                    }

                });

           

        },
        linkType: "direct",
       // extensions: ['.pdf', '.odp'],
        multiselect: false
    });

    
   
    return false;
}

function generalSetup(process) {

    for (i = 0; i < shapes.length; i++) {

        if (shapes[i].f == Npages[currentPage - 1]) {

            if (shapes[i].Itype == 'field') {

                var getField = document.getElementById(shapes[i].imName);

                if (getField != null) {

                    if (shapes[i].fieldType == 'Text') {
                        shapes[i].t = getField.value;
                    }
                    else if (shapes[i].fieldType == 'ComboBox') {

                        var optValues = getField.value;

                        for (x = 0; x < getField.options.length; x++) {
                            optValues = optValues + "^^^" + getField.options[x].value;
                        }
                                                  
                        shapes[i].t = optValues;
                    }
                    else if (shapes[i].fieldType == 'CheckBox' || shapes[i].fieldType == 'Radio') {

                        shapes[i].t = getField.checked;
                    }
                }

            }

        }
    }

    $('#textAreaPopUp').css('visibility', 'hidden');
    $('#divDel').css('visibility', 'hidden');
    $('#divSignature').css('visibility', 'hidden');

    document.getElementById('imageView').getContext('2d').width = document.getElementById('imageView').getContext('2d').width;
    drawScreen();
    DrawShapes();

    myTools = process;
}

function moveModeClose() {

    $("#hdnMove").val("");

}

function addFields(fieldData) {

    if (fieldData != "") {

        var dataValues = fieldData.split('$#$');

        for (i = 0; i < dataValues.length; i++) {

            tempShape = { x: dataValues[i + 0], y: dataValues[i + 1], w: dataValues[i + 2], h: dataValues[i + 3], p: dataValues[i + 4], f: dataValues[i + 5], t: dataValues[i + 6], n: dataValues[i + 7], s: dataValues[i + 8], c: dataValues[i + 9], wt: dataValues[i + 10], st: dataValues[i + 11], ratio: dataValues[i + 12], imfile: dataValues[i + 13], imName: dataValues[i + 14], Itype: "field", fieldType: dataValues[i + 15] };
            shapes.push(tempShape);
            i = i + 15;

        }

    }
}

function manageFields() {

     for (i = 0; i < shapes.length; i++) {

        var shapeDiv = document.getElementById("div_" + shapes[i].imName + "");

        var shape = document.getElementById(shapes[i].imName);
        if (shape != null) {
            
            $('#' + shapes[i].imName + '').remove();
        }

        if (shapeDiv != null) {

            shapeDiv.parentNode.removeChild(shapeDiv);
        }

    }

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');


    for (i = 0; i < shapes.length; i++) {
        if (shapes[i].f == Npages[currentPage - 1]) {

            if (shapes[i].Itype == "field") {

                var rect = canvas.getBoundingClientRect();

                var fld = document.getElementById("div_" + shapes[i].imName + "");

                if (fld == null) {
                    var wrapper = document.createElement('div');


                    wrapper.style.left = (rect.left + parseInt(shapes[i].x) + 2) + "px";
                    wrapper.style.top = (rect.top + parseInt(shapes[i].y) + 2) + "px";
                    wrapper.style.width = parseInt(shapes[i].w - 2) + "px";
                    wrapper.style.height = parseInt(shapes[i].h - 2) + "px";
                    wrapper.id = "div_" + shapes[i].imName;
                    wrapper.style.zIndex = 50 + i;

                    

                    
                    if (shapes[i].fieldType == "Text") {
                        wrapper.className = 'info';
                        wrapper.setAttribute("display", 'block');
                        var textarea = document.createElement('textarea');
                        textarea.className = 'tbox';
                        textarea.value = shapes[i].t;
                        textarea.style.width = (parseInt(shapes[i].w) - 2) + "px";
                        textarea.style.height = (parseInt(shapes[i].h) - 2) + "px";
                        textarea.style.left = "0px";
                        textarea.style.top = "0px";
                        textarea.style.zIndex = 150 + i;
                        
                        if (shapes[i].st == 'True') {
                            textarea.style.backgroundColor = '#FFE4E1';
                        }
                        textarea.id = shapes[i].imName;

                        wrapper.appendChild(textarea);
                    }
                    else if (shapes[i].fieldType == "CheckBox") {

                       wrapper.className = 'info';
                       wrapper.style.left = (rect.left + (parseInt(shapes[i].x))) + "px";
                       wrapper.style.top = (rect.top + (parseInt(shapes[i].y))) + "px";
                       wrapper.style.width = (parseInt(shapes[i].w) + 5) + "px";
                       wrapper.style.height = (parseInt(shapes[i].h) + 5) + "px";
                       if (shapes[i].st == 'True') {
                           wrapper.style.backgroundColor = '#FFE4E1';
                       } 
                        var checkbox = document.createElement('input');
                        checkbox.type = "checkbox";
                        checkbox.name = shapes[i].imfile; //shapes[i].imName;

                        if (shapes[i].t == 'true') {
                            checkbox.checked = true;

                        }
                        else {

                            checkbox.checked = false;
                        }
                        checkbox.style.zIndex = 150 + i;
                        checkbox.id = shapes[i].imName;
                        
                        wrapper.appendChild(checkbox);

                    }
                    else if (shapes[i].fieldType == "Radio") {


                        wrapper.className = 'Mine';
                        wrapper.style.left = (rect.left  + parseInt(shapes[i].x)) + "px";
                        wrapper.style.top = (rect.top - 1 + parseInt(shapes[i].y)) + "px";
                        wrapper.style.width = (parseInt(shapes[i].w) + 5) + "px";
                        wrapper.style.height = (parseInt(shapes[i].h) + 5) + "px";
                        if (shapes[i].st == 'True') {
                            wrapper.style.backgroundColor = '#FFE4E1';
                        }
                        var radio = document.createElement('input');
                        radio.type = "radio";
                        radio.id = shapes[i].imName;
                        radio.name = shapes[i].imfile;
                        if (shapes[i].t == 'true') {
                            radio.checked = true;

                        }
                        else {

                            radio.checked = false;
                        }
                        radio.style.zIndex = 150 + i;
                        radio.id = shapes[i].imName;
                        wrapper.appendChild(radio);

                                                
                    }
                    else if (shapes[i].fieldType == "ComboBox") {

                        wrapper.className = 'tbox';
                        var combo = document.createElement("select");
                        combo.id = shapes[i].imName;
                        combo.style.zIndex = 150 + i;
                        var values = shapes[i].t.split('^^^');
                        combo.className = 'tbox';
                        combo.style.width = (shapes[i].w - 2)+ 'px';
                        if (shapes[i].st == 'True') {
                            combo.style.backgroundColor = '#FFE4E1';
                        }
                        for (j = 1; j < values.length; j++) {

                            var option1 = document.createElement("option");
                            option1.value = values[j];
                            option1.innerHTML = values[j];
                            combo.appendChild(option1);

                        }
                        if (values[0] != '') {

                            var opts = combo.options.length;
                            for (var k = 0; k < opts; k++) {
                                if (combo.options[k].value == values[0]) {
                                    combo.options[k].selected = true;
                                    break;
                                }
                            }
                        }
                        wrapper.appendChild(combo);
                    }

                    document.body.appendChild(wrapper);
                }
            }
        }
    }  
}


function GetAttachments() {

   // $('#loadingModal').modal('show');

    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/GetFileAttachments',
        data: '{}',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            //  alert(data.d);
            Attachments = data.d.split(',');

            var table = document.getElementById("tblAttach");
            while (table.rows.length > 1) {
                table.deleteRow(1);
            }
            var count = 1;
            for (i = 0; i < Attachments.length - 1; i++) {

                var row = table.insertRow(table.rows.lenght);
                var cell1 = row.insertCell(0);
                var cell2 = row.insertCell(1);
                var cell3 = row.insertCell(2);
                var cell4 = row.insertCell(3);


                // Add some text to the new cells:
                cell1.innerHTML = Attachments[i];
                cell2.innerHTML = Attachments[i + 1];

                var name = 'Attachments/' + Attachments[i];
                var button = document.createElement('input'); // create a button
                button.setAttribute('type', 'button'); // set attributes ...
                button.setAttribute('name', "down_" + count);
                button.setAttribute('value', 'Download');
                button.onclick = (function () {

                    var currentName = name;
                    return function () {

                        SaveToText(currentName);
                    }

                })();
                cell3.appendChild(button);

                name = Attachments[i];

                button = document.createElement('input'); // create a button
                button.setAttribute('type', 'button'); // set attributes ...
                button.setAttribute('name', count);
                button.setAttribute('value', 'Remove');
                button.onclick = (function () {

                    var currentName = name;
                    var index = count;
                    return function () {

                        RemoveAttachment(currentName, index);
                    }

                })();


                cell4.appendChild(button);

                count = count + 1;
                i = i + 1;

            }
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}

function RemoveAttachment(name, rowId) {

    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/RemoveAttachments',
        data: '{ "name" : "' + name + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {

            document.getElementById("tblAttach").deleteRow(rowId);
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}

function onNewFileClicked() {

    // Sending the image data to Server
    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/CreateNewFile',
        data: '{ }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {

            dataLoad = data.d;
            for (i = 0; i < shapes.length; i++) {

                var shapeDiv = document.getElementById("div_" + shapes[i].imName + "");

                var shape = document.getElementById(shapes[i].imName);
                if (shape != null) {

                    $('#' + shapes[i].imName + '').remove();
                }

                if (shapeDiv != null) {

                    shapeDiv.parentNode.removeChild(shapeDiv);
                }

            }

            $("#hdnOpp").val("Empty");
            shapes2.length = 0;
            shapes.length = 0;
            Attachments.length = 0;
            CheckLicense();
            First();
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            //called on ajax call success
            alert("Error: " + xhr.responseJSON.Message);
        }

    });

}

function setupSignature() {




}

function clearSignature() {

    var signatureCanvas = document.querySelector('#signCanvas');
    signatureCanvas.width = signatureCanvas.width;
}

function saveSignature() {


    var signatureCanvas = document.querySelector('#signCanvas');
    var image = signatureCanvas.toDataURL("image/png");
    
    image = image.replace('data:image/png;base64,', '');


    $.ajax({
        type: 'POST',
        url: 'CanvasSave.aspx/CreateSignature',
        data: '{ "imageData" : "' + image + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {

            InsertImages(data.d, signX, signY);
            $('#divSignature').css('visibility', 'hidden');
            myTools = "dragging";
            document.getElementById('btnDrag').click();
            var e = jQuery.Event("mousedown", { pageX: signX, pageY: signY });
            $('#imageView').trigger(e);
        }
    });

}

function closeSignature() {

  $('#divSignature').css('visibility', 'hidden');
  
}

function onStartup() {

    document.getElementById("btnAddPage").disabled = false;
    document.getElementById("btnDeletePage").disabled = false;
    document.getElementById("btnMoving").disabled = false;
    document.getElementById("btnAppending").disabled = false;
    document.getElementById("btnSave").disabled = false;
    document.getElementById("btnExporting").disabled = false;
    document.getElementById("btnPrevious").disabled = false;
    document.getElementById("btnNext").disabled = false;
    document.getElementById("btnSearching").disabled = false;
    document.getElementById("btnImage").disabled = false;
    document.getElementById("btnRect").disabled = false;
    document.getElementById("btnRead").disabled = false;
    document.getElementById("btnDrag").disabled = false;
    document.getElementById("btnTexting").disabled = false;
    document.getElementById("btnAttachments").disabled = false;
    document.getElementById("btnSignature").disabled = false;

}

function drawRotationHandle(shape, context) {

    context.save();
    
    context.translate(shape.x , shape.y + parseInt(shape.s));
    context.rotate(shape.fieldType);

    context.strokeStyle = 'brown';
    context.setLineDash([6]);
    context.strokeRect(0, -shape.h, shape.w, shape.h);

    context.fillStyle = "#7171C6";
    context.fillRect(shape.w - 5, (shape.h/-2) - 5, 10, 10);
    
    context.restore();
}


