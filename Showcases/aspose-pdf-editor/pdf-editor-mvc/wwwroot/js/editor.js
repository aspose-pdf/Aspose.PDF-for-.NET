let apiBaseUrl = '/api/';
let documentId = '';
let originalFileName = 'document.pdf';
let ratio = 1;
let canvasHeight;
let canvasWidth;
let currentPage;
let Npages = [];
let aRatio = [];
let dataLoad;
let shapes = [];
let shapes2 = [];
let Attachments = [];
let fontText = 'Arial';
let fontSize = 16;
let fontWeight = '';
let fontStyle = '';
let fontColor = 'black';
let mouseX;
let mouseY;
let textX;
let textY;
let editText = -1;
let imageObj;
let selectedShape = -1;
let searchFolder = '';
let pageHeights = {};
let heights;
let currentTools = 'reading';
let anchorVal = -1;
let signX = 5;
let signY = 5;
let r = 0;
let isDown = false;

// The active tool instance.
let tool;
let tool_default;

function alertModal (msg, xhr, textStatus, error){
    if(xhr != null && xhr.responseJSON != null) {
        msg += xhr.responseJSON.detail;
    }
    
    if(error != null) {
        msg += error;
    }

    $("#errorModal").html(msg);
    $('#loadingModal').modal('hide');
    $("#errorModal").fadeTo(4000, 500).slideUp(500, function () {
        $("#errorModal").slideUp(500);
    });
}

// Keep everything in anonymous function, called on window load.
if (window.addEventListener) {
    window.addEventListener('load', function () {
        let canvas, context, canvaso, contexto;

        let tempX;
        let tempY;
        let tempW;
        let tempH;
        let numShapes = 0;
        let dragIndex;
        let dragging;

        let dragHoldX;
        let dragHoldY;
        canvasWidth = 1138;
        canvasHeight = 760;

        $('#loadingModal').modal('show');

        function init() {
            // Find the canvas element.
            canvaso = document.getElementById('imageView');
            canvaso.width = canvasWidth;
            canvaso.height = canvasHeight;

            tempX = 0;
            tempY = 0;
            tempW = 0;
            tempH = 0;
            tool_default = 'reading';

            if (!canvaso) {
                alertModal('Error: I cannot find the canvas element!');
                return;
            }

            if (!canvaso.getContext) {
                alertModal('Error: no canvas.getContext!');
                return;
            }

            // Get the 2D canvas context.
            contexto = canvaso.getContext('2d');

            if (!contexto) {
                alertModal('Error: failed to getContext!');
                return;
            }

            // Add the temporary canvas.
            var container = canvaso.parentNode;
            canvas = document.createElement('canvas');
            if (!canvas) {
                alertModal('Error: I cannot create a new canvas element!');
                return;
            }

            canvas.id = 'imageTemp';
            canvas.display = 'none';
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
                alertModal('Error: failed to get the dtool element!');
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
            
            GetFileExists();
        }

        // The general-purpose event handler. This function just determines the mouse 
        // position relative to the canvas element.
        function ev_canvas(ev) {
            if (ev.layerX || ev.layerX === 0) { // Firefox
                ev._x = ev.layerX;
                ev._y = ev.layerY;
            } else if (ev.offsetX || ev.offsetX === 0) { // Opera
                ev._x = ev.offsetX;
                ev._y = ev.offsetY;
            }
            // Call the event handler of the tool.
            let func = tool[ev.type];
            if (func) {
                func(ev);
            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change(ev) {
            if (tools['rect'] && currentTools === 'Rect') {
                tool = new tools['rect']();
            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change2(ev) {
            if (tools['reading'] && currentTools === 'Read') {
                tool = new tools['reading']();
            }
        }

        // The event handler for any changes made to the tool selector.
        function ev_tool_change3(ev) {
            if (tools['dragging'] && currentTools === 'Drag') {
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
        function ev_tool_change5() {
            if (tools['signature'] && currentTools === 'signature') {
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
            let tool = this;
            this.started = false;
            this.mousedown = function (ev) {
                if (currentTools === 'Rect') {
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
                    tempShape = {
                        x: tempX,
                        y: tempY,
                        w: tempW,
                        h: tempH,
                        p: currentPage,
                        f: Npages[currentPage - 1],
                        t: '',
                        n: '',
                        s: '',
                        c: '',
                        wt: '',
                        st: '',
                        ratio: aRatio[currentPage - 1],
                        imfile: '',
                        imName: '',
                        Itype: 'highlight',
                        fieldType: ''
                    };
                    shapes.push(tempShape);
                }
            };
        };

        // The signature tool.
        tools.signature = function (ev) {
            tool = this;
            this.started = false;

            this.mousedown = function (ev) {
                let ARect = canvas.getBoundingClientRect();
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
            };
        };

        // The reading tool.
        tools.reading = function () {
            tool = this;
            this.started = false;
        };


        // The reading tool.
        tools.dragging = function () {
            tool = this;
            this.started = false;
            // canvas.addEventListener("mousedown", mouseDownListener, false);
            this.mousedown = function (ev) {
                if (currentTools === 'Drag') {
                    tool.started = true;
                    tool.x0 = ev._x;
                    tool.y0 = ev._y;

                    var i;
                    //We are going to pay attention to the layering order of the objects so that if a mouse down occurs over more than object,
                    //only the topmost one will be dragged.
                    var highestIndex = -1;

                    //getting mouse position correctly, being mindful of resizing that may have occured in the browser:
                    let bRect = canvas.getBoundingClientRect();
                    mouseX = (ev.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (ev.clientY - bRect.top) * (canvas.height / bRect.height);

                    //find which shape was clicked
                    for (i = 0; i < shapes.length; i++) {
                        if (hitTest(shapes[i], mouseX, mouseY, context)) {
                            if (anchorHitTest(shapes[i], mouseX, mouseY, context) === -1) {
                                dragging = true;
                                anchorVal = -1;
                                isDown = false;
                            }
                            else {

                                if (shapes[i].Itype === 'image') {
                                    dragging = false;
                                    isDown = false;
                                }
                                else if (shapes[i].Itype === 'text' && anchorVal === 5) {

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


                                if (shapes[dragIndex].Itype !== 'text') {
                                    context.strokeStyle = 'brown';
                                    context.setLineDash([6]);
                                    context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].w, shapes[dragIndex].h);
                                }


                                if (shapes[dragIndex].Itype === 'image') {
                                    context.fillStyle = 'rgba(255, 230, 81, 1)';
                                    context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                                    context.fillRect(shapes[dragIndex].x + shapes[dragIndex].w - 10, shapes[dragIndex].y, 10, 10);
                                    context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);
                                    context.fillRect(shapes[dragIndex].x + shapes[dragIndex].w - 10, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);

                                }
                                else if (shapes[dragIndex].Itype === 'text') {
                                    drawRotationHandle(shapes[dragIndex], context);
                                }

                                mouseX = ev.pageX - canvas.offsetLeft;
                                mouseY = ev.pageY - canvas.offsetTop;

                                $('#divDel').css('visibility', 'visible');
                                $('#divDel').css('left', rect.left + shapes[dragIndex].x - 50);
                                $('#divDel').css('top', rect.top + shapes[dragIndex].y);
                                break;
                            }
                        }
                        else {
                            $('#divDel').css('visibility', 'hidden');
                            document.getElementById('imageView').getContext('2d').width = document.getElementById('imageTemp').getContext('2d').width;
                            DrawScreen();
                            DrawShapes();
                        }
                    }

                    //code below prevents the mouse down from having an effect on the main browser window:
                    if (ev.preventDefault) {
                        ev.preventDefault();
                    } //standard
                    else if (ev.returnValue) {
                        ev.returnValue = false;
                    } 
                    
                    //older IE
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

                    DrawScreen();

                    DrawShapes();

                    mouseX = evt.pageX - canvas.offsetLeft;
                    mouseY = evt.pageY - canvas.offsetTop;


                    if (shapes[dragIndex].Itype !== 'text') {
                        context.strokeStyle = 'brown';
                        context.setLineDash([6]);
                        context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].w, shapes[dragIndex].h);
                    }
                    if (shapes[dragIndex].Itype === 'image') {

                        context.fillStyle = 'rgba(255, 230, 81, 1)';
                        context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                        context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, shapes[dragIndex].y, 10, 10);
                        context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);
                        context.fillRect((shapes[dragIndex].x + shapes[dragIndex].w) - 10, (shapes[dragIndex].y + shapes[dragIndex].h) - 10, 10, 10);

                    }
                    else if (shapes[dragIndex].Itype === 'text') {

                        drawRotationHandle(shapes[dragIndex], context);

                    }

                    $('#divDel').css('visibility', 'hidden');

                }

                else if (isDown) {
                    let posX;
                    let posY;
                    //getting mouse position correctly 
                    let bRect = canvas.getBoundingClientRect();
                    mouseX = (evt.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (evt.clientY - bRect.top) * (canvas.height / bRect.height);

                    //clamp x and y positions to prevent object from dragging outside of canvas
                    posX = mouseX - dragHoldX; 

                    posY = mouseY - dragHoldY; 

                    var dx = mouseX - shapes[dragIndex].x + (shapes[dragIndex].w) / 2;
                    var dy = mouseY - shapes[dragIndex].y + (shapes[dragIndex].h) / 2;
                    var angle = Math.atan2(dy, dx);
                    r = angle;

                    shapes[dragIndex].fieldType = r;

                    DrawScreen();
                    DrawShapes();
                    drawRotationHandle(shapes[dragIndex], context);

                }
                else {

                    let posX;
                    let posY;
                    //getting mouse position correctly 
                    let bRect = canvas.getBoundingClientRect();
                    mouseX = (evt.clientX - bRect.left) * (canvas.width / bRect.width);
                    mouseY = (evt.clientY - bRect.top) * (canvas.height / bRect.height);

                    //clamp x and y positions to prevent object from dragging outside of canvas
                    posX = mouseX - dragHoldX;
                    posY = mouseY - dragHoldY;

                    imgWidth = (shapes[dragIndex].x + shapes[dragIndex].w);
                    imgHeight = (shapes[dragIndex].y + shapes[dragIndex].h);

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


                    DrawScreen();

                    DrawShapes();

                    if (shapes[dragIndex].Itype !== 'text') {
                        context.strokeStyle = 'brown';
                        context.setLineDash([6]);
                        context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].w, shapes[dragIndex].h);
                    }
                    else if (shapes[dragIndex].Itype === 'text') {

                        drawRotationHandle(shapes[dragIndex], context);

                    }
                    if (shapes[dragIndex].Itype === 'image') {

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
                    $('#divDel').css('left', rect.left + shapes[dragIndex].x - 50);
                    $('#divDel').css('top', rect.top + shapes[dragIndex].y);

                    dragging = false;


                }
            };
        };

        // Testing
        // The reading tool.
        tools.texting = function () {
            let tool = this;
            this.started = false;
            this.mousedown = function (ev) {

                if (currentTools === 'Text') {
                    tool.started = true;
                    tool.x0 = ev._x;
                    tool.y0 = ev._y;

                    textX = ev._x;
                    textY = ev._y;

                    $('#textareaTest').val('');

                    //find which shape was clicked
                    for (i = 0; i < shapes.length; i++) {
                        if (shapes[i].t !== '') {

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


        $('.btn-group > .btn').click(function () {
            $('.btn-group > .btn').removeClass('active');
            $(this).addClass('active');
        });

        init();

    }, false);
}

function saveTextFromArea() {
    //get the value of the textarea
    var text = $('#textareaTest').val();
    $('#textAreaPopUp').css('visibility', 'hidden');

    if (text !== '') {
        r = 0;
        var canvas = document.getElementById('imageView');
        var ctx = canvas.getContext('2d');

        if (editText === -1) {
            //set the font styles
            ctx.fillStyle = fontColor;

            //draw the text
            ctx.font = fontStyle + ' ' + fontWeight + ' ' + fontSize + 'px ' + fontText;

            ctx.fillText(text, textX, textY + parseInt(fontSize));

            tempShape =  { 
                x: textX, 
                y: textY, 
                w: ctx.measureText(text).width, 
                h: parseInt(fontSize), 
                p: currentPage, 
                f: Npages[currentPage - 1], 
                t: text, 
                n: fontText, 
                s: fontSize, 
                c: fontColor, 
                wt: fontWeight, 
                st: fontStyle, 
                ratio: aRatio[currentPage - 1], 
                imfile: '', 
                imName: '', 
                Itype: 'text', 
                fieldType: r 
            };

            shapes.push(tempShape);
        }
        else {

            shapes[editText].t = text;
            shapes[editText].wt = fontWeight;
            shapes[editText].s = fontSize;
            shapes[editText].n = fontText;
            shapes[editText].st = fontStyle;
            shapes[editText].c = fontColor;
            shapes[editText].h = parseInt(fontSize);

            DrawScreen();
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

    var image1 = '';
    var rand = Math.random();
    
    image1 = `${apiBaseUrl}page/preview/${documentId}/${imageId}`;
    $('#imageView').css('background-image', 'url(' + image1 + '?Dummy=' + rand + ')');

    return true;
}

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

function AddPage() {
    $('#loadingModal').modal('show');
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}page/add/${documentId}`,
        data: '{ "lastpage" : "' + Npages[Npages.length - 1] + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            datasplit = data.pages.split("#");
            Npages.push(datasplit[0]);
            aRatio.push(datasplit[2]);
            heights.push(datasplit[1]);
            for (let i = 0; i < heights.length; i++) {
                pageHeights[Npages[i]] = heights[i];
            }
            document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function DeletePage() {
    $('#loadingModal').modal('show');

    function isFromPage(page) {
        return page == currentPage;
    }
    shapes = shapes.filter(isFromPage);

    var deleteData = JSON.stringify({ 'pageNumber': currentPage, 'documentId': documentId });
    return $.ajax({
        type: 'DELETE',
        url: `${apiBaseUrl}page/delete`,
        data: deleteData,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            updateIndexesDelete();
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function updateIndexesDelete() {
    DeleteShapes();

    Npages.splice(currentPage - 1, 1);

    if (currentPage > Npages.length) {
        currentPage = Npages.length;
    }

    DrawPic(Npages[currentPage - 1]);
    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}

function DeleteShapes() {
    for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].p === Npages[currentPage - 1]) {

            shapes.splice(i, 1);
        }
    }
}

function DelShape() {
    $('#divDel').css('visibility', 'hidden');
    DrawScreen();

    shapes.splice(selectedShape, 1);
    DrawShapes();

    selectedShape = -1;
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
    let txtFind = $('#txtFind').val();
    let txtReplace = $('#txtReplace').val();
    let movedata = JSON.stringify({ 'txtFind': txtFind, 'txtReplace': txtReplace, 'pageList': Npages, 'documentId': documentId });

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
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }

    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function Move() {
    let moveTo = $('#txtMove').val();
    if ($('#hdnMove').val() === 'moving') {
        movedata = JSON.stringify({ 'moveFrom': currentPage.toString(), 'moveTo': moveTo, 'pageList': Npages, 'documentId': documentId });
        $('#loadingModal').modal('show');
        $.ajax({
            type: 'PUT',
            url: `${apiBaseUrl}page/move`,
            data: movedata,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, textStatus, jqXHR) {
                Npages = data.pageList;
                MoveUpdate();
            },
            error: function (xhr, textStatus, error) {
                alertModal('Error: ', xhr, textStatus, error);
            }
        })
        .done(function () { $('#loadingModal').modal('hide'); });
    }
    else {
        $('#loadingModal').modal('show');
        movedata = JSON.stringify({ 'searchText': moveTo, 'pageList': Npages, 'documentId': documentId });
        // Sending the image data to Server
        $.ajax({
            type: 'POST',
            url: `${apiBaseUrl}text/search`,
            data: movedata,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, textStatus, jqXHR) {
                AfterSearch();
            },
            //call on ajax call failure
            error: function (xhr, textStatus, error) {
                alertModal('Error: ', xhr, textStatus, error);
            }
        })
        .done(function () { $('#loadingModal').modal('hide'); });
    }
}

function moveClick(event) {
    event.preventDefault();
    GeneralSetup('Move');
}

function appendClick(event) {
    event.preventDefault();
    GeneralSetup('Append');
}

function clearSearchClicked() {
    let cleardata = JSON.stringify({ 'searchText': '', 'pageList': Npages, 'documentId': documentId });
    $.ajax({
        type: 'DELETE',
        url: `${apiBaseUrl}text/clear`,
        data: cleardata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            AfterSearch();
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function AfterSearch() {
    DrawScreen();
    DrawPic(Npages[currentPage - 1]);
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
        url: `${apiBaseUrl}export-pdf`,
        data: '{}',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json'
    });

}

function MoveUpdate() {
    for (var i = 0; i < Npages.length; i++) {
        for (var j = 0; j < shapes.length; j++) {

            if (Npages[i] === shapes[j].f) {
                shapes[j].p = i + 1;
            }
        }

    }
    DrawScreen();

    DrawPic(Npages[currentPage - 1]);

    DrawShapes();

    document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;
}

function SavePdf() {
    $('#loadingModal').modal('show');
    let filename = 'image'.concat(currentPage).concat('.png');

    shapes2 = [];

    for (var i = 0; i < shapes.length; i++) {
        tempShape = {
            x: shapes[i].x.toString(),
            y: shapes[i].y.toString(),
            w: shapes[i].w.toString(),
            h: shapes[i].h.toString(),
            p: shapes[i].p.toString(),
            f: shapes[i].f.toString(),
            t: shapes[i].t.toString(),
            n: shapes[i].n.toString(),
            s: shapes[i].s.toString(),
            c: shapes[i].c.toString(),
            wt: shapes[i].wt.toString(),
            st: shapes[i].st.toString(),
            ratio: shapes[i].ratio.toString(),
            imfile: '',
            imName: shapes[i].imName,
            Itype: shapes[i].Itype.toString(),
            fieldType: shapes[i].fieldType.toString()
        };
        shapes2.push(tempShape);
    }

    wholedata = JSON.stringify({ 'shapes': shapes2, 'filename': filename, 'aspectRatio': ratio.toString(), 'documentId': documentId });

    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}shape/add`,
        data: wholedata,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            $("#savingModal").fadeTo(2000, 500).slideUp(500, function () {
                $("#savingModal").slideUp(500);
            });
        },
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function DrawScreen() {
    let canvas = document.getElementById('imageView');
    let context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.width, canvas.height);
    document.getElementById('imageTemp').getContext('2d').clearRect(0, 0, canvas.width, canvas.height);
}

function DrawShapes() {
    let canvas = document.getElementById('imageView');
    let context = canvas.getContext('2d');

    for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].f === Npages[currentPage - 1]) {

            if (shapes[i].Itype === 'highlight') {
                context.fillStyle = 'rgba(255, 230, 81, 0.5)';
                context.fillRect(shapes[i].x, shapes[i].y, shapes[i].w, shapes[i].h);
            }
            if (shapes[i].Itype === 'image') {

                var image1 = 'Images/'.concat(shapes[i].imfile);

                imageObj = shapes[i].imfile;

                context.drawImage(imageObj, shapes[i].x, shapes[i].y, shapes[i].w, shapes[i].h);

            }
            if (shapes[i].Itype === 'text') {


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
                context.font = fontstyle + ' ' + fontweight + ' ' + fontsize + 'px ' + font;

                context.fillText(shapes[i].t, 0, 0);

                context.restore();
            }

        }
    }

}

$(document).on('click', '.open-uploadModal', function () {
    let operationId = $(this).data('id');
    console.log(operationId);
    $('#hdnOpp').val(operationId);
});

$(document).on('click', '.open-moveModal', function () {

    let myId = $(this).data('id');

    $('#hdnMove').val(myId);

    if (myId === 'searching') {

        $('#btnMove').html('Search');
        $('#H1').html('Search Text');
        $('#lblpagemove').html('Enter Text to Search');
    }
    else {

        $('#btnMove').html('Move');
        $('#H1').html('Move Page After');
        $('#lblpagemove').html('Enter Page Number');
    }
});

function fileSelected() {
    $('#uploadModal').modal('hide');
    let fd = new FormData();
    fd.append('fileToUpload', document.getElementById('fileToUpload').files[0]);
    fd.append('Opp', $('#hdnOpp').val());
    if (typeof documentId !== 'undefined' && documentId != 'undefined')
        fd.append('documentId', documentId);

    if ($('#hdnOpp').val() === 'appending') {
        fd.append('pages', Npages);
        fd.append('ratios', aRatio);
        fd.append('heights', heights);

    }
    var xhr = new XMLHttpRequest();
    console.log($('#hdnOpp').val());
    switch($('#hdnOpp').val())
    {
        case 'uploading':
            xhr.open('PUT', `${apiBaseUrl}document/upload`);
        break;
        case 'appending':
            xhr.open('PUT', `${apiBaseUrl}document/append`);
        break;
        case 'addAttachment':
            xhr.open('POST', `${apiBaseUrl}attachment/add`);
        break;
        default:
            xhr.open('POST', `${apiBaseUrl}shape/upload`);
    }

    xhr.upload.onprogress = function (event) {
        if (event.lengthComputable) {
            $('.progress-bar').width('60%');
        }
    };

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            if(xhr.status >= 300)
            {
                alertModal(xhr.statusText);
                return;
            }
            
            data = JSON.parse(xhr.responseText);
            dataLoad = data.pages;
            documentId = data.path;
            originalFileName = data.originalFileName;
            if ($('#hdnOpp').val() === 'appending') {
                First();
            }
            else
                if ($('#hdnOpp').val() === 'uploading') {
                    for (i = 0; i < shapes.length; i++) {
                        var shapeDiv = document.getElementById('div_' + shapes[i].imName + '');
                        var shape = document.getElementById(shapes[i].imName);
                        if (shape !== null) {
                            $('#' + shapes[i].imName + '').remove();
                        }
                        if (shapeDiv !== null) {
                            shapeDiv.parentNode.removeChild(shapeDiv);
                        }
                    }

                    shapes2.length = 0;
                    shapes.length = 0;
                    Attachments.length = 0;
                    GetAttachments();
                    First();
                }
                else if ($('#hdnOpp').val() === 'addAttachment') {
                    GetAttachments();
                }
                else {
                    InsertImages(data.pages, 50, 50);
                }

            $('.progress-bar').width('100%');
            

            $('#fileToUpload').wrap('<form>').parent('form').trigger('reset');
            $('#fileToUpload').unwrap();
            $('#fileToUpload').prop('files')[0] = null;
            $('#fileToUpload').replaceWith($('#fileToUpload'));
            $('.progress-bar').width('0%');
        }
    };

    xhr.send(fd);
}

function anchorHitTest(shape, x, y, context) {
    anchorVal = -1;
    if (x > shape.x && x < (shape.x + 10) && y < (shape.y + 10) && y > shape.y && shape.Itype === 'image') {
        anchorVal = 0;
        return anchorVal;
    }
    else if (x > (shape.x + shape.w - 10) && x < (shape.x + shape.w) && y < (shape.y + 10) && y > shape.y && shape.Itype === 'image') {

        anchorVal = 1;

        return anchorVal;
    }
    else if (x > shape.x && x < (shape.x + 10) && y > (shape.y + shape.h - 10) && y < (shape.y + shape.h) && shape.Itype === 'image') {

        anchorVal = 2;
        return anchorVal;
    }
    else if (x > (shape.x + shape.w - 10) && x < (shape.x + shape.w) && y > (shape.y + shape.h - 10) && y < (shape.y + shape.h) && shape.Itype === 'image') {
        anchorVal = 3;
        return anchorVal;
    }

    else if (x > (shape.x + shape.w - 5) && x < (shape.x + shape.w + 5) && y < (shape.y + (shape.h / 2) + 10) && y > (shape.y + (shape.h / 2) - 10) && shape.Itype === 'text') {
        anchorVal = 5;
        return anchorVal;
    }
    else if (shape.Itype === 'text') {

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

    if (shape.Itype === 'text') {

        context.save();

        context.translate(shape.x, shape.y + parseInt(shape.s));
        context.rotate(shape.fieldType);

        context.beginPath();
        context.rect(0, -shape.h, shape.w + 5, shape.h);

        var result = context.isPointInPath(mx, my);

        context.restore();

        return result;
    }

    if (mx > shape.x && mx < shape.x + shape.w) {
        if (my > shape.y && my < shape.y + shape.h) {
            return true;
        }
        else {

            return false;
        }
    }
    else {

        return false;
    }

}

function InsertImages(data, imgLeft, imgTop) {
    let canvas = document.getElementById('imageView');
    let context = canvas.getContext('2d');

    let bRect = canvas.getBoundingClientRect();
    let image1 = `${apiBaseUrl}page/preview/${documentId}/${data}?Dummy=${Math.random()}`;

    let imgWidth = 0;
    let imgHeight = 0;

    imageObj = new Image();

    imageObj.onload = function () {
        context.drawImage(imageObj, imgLeft, imgTop);
        imgWidth = this.width;
        imgHeight = this.height;

        tempShape = { x: imgLeft, y: imgTop, w: imgWidth, h: imgHeight, p: currentPage, f: Npages[currentPage - 1], t: '', n: '', s: '', c: '', wt: '', st: '', ratio: aRatio[currentPage - 1], imfile: imageObj, imName: data, Itype: 'image', fieldType: '' };
        shapes.push(tempShape);

    };
    imageObj.src = image1;
    imageObj.style.zIndex = 500 + shapes.length;
}

function ExportByType(fileType, documentId) {
    
    const a = document.createElement('a')
    a.href = `${apiBaseUrl}document/download/${fileType}/${documentId}`
    a.download = `${apiBaseUrl}}document/download/${fileType}/${documentId}`.split('/').pop() + '.' + fileType;
    document.body.appendChild(a)
    a.click()
    document.body.removeChild(a);
}

function ExportFile(fileType) {
    $('#loadingModal').modal('show');
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}document/export?fileType=${fileType}&folder=${documentId}`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            ExportByType(fileType, documentId);
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function ddFontChange() {
    let dFont = document.getElementById('ddFont');
    fontText = dFont.options[dFont.selectedIndex].value;
    $('#textareaTest').css('font-family', fontText);
}

function ddSizeChange() {
    let dSize = document.getElementById('ddSize');
    fontSize = dSize.options[dSize.selectedIndex].value;
    $('#textareaTest').css('font-size', fontSize + 'px');
}

function makeBold() {
    if ($('#btnBold').hasClass('active')) {

        $('#textareaTest').css('font-weight', 'normal');
        fontWeight = 'normal';
    }
    else {
        $('#textareaTest').css('font-weight', 'bold');
        fontWeight = 'bold';
    }
}

function makeItalic() {
    if ($('#btnItalic').hasClass('active')) {

        $('#textareaTest').css('font-style', 'italic');
        fontStyle = '';
    }
    else {
        $('#textareaTest').css('font-style', 'italic');
        fontStyle = 'italic';
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

function GeneralSetup(process) {
    for (i = 0; i < shapes.length; i++) {
        if (shapes[i].f === Npages[currentPage - 1]) {
            if (shapes[i].Itype === 'field') {
                let getField = document.getElementById(shapes[i].imName);
                if (getField !== null) {
                    if (shapes[i].fieldType === 'Text') {
                        shapes[i].t = getField.value;
                    }
                    else if (shapes[i].fieldType === 'ComboBox') {
                        let optValues = getField.value;
                        for (x = 0; x < getField.options.length; x++) {
                            optValues = optValues + '^^^' + getField.options[x].value;
                        }
                        shapes[i].t = optValues;
                    }
                    else if (shapes[i].fieldType === 'CheckBox' || shapes[i].fieldType === 'Radio') {
                        shapes[i].t = getField.checked;
                    }
                }
            }
        }
    }

    $('#textAreaPopUp').css('visibility', 'hidden');
    $('#divDel').css('visibility', 'hidden');
    $('#divSignature').css('visibility', 'hidden');

    DrawScreen();
    DrawShapes();

    currentTools = process;
}

function moveModeClose() {
    $('#hdnMove').val('');
}

function addFields(fieldData) {
    if (fieldData !== '') {
        var dataValues = fieldData.split('$#$');

        for (i = 0; i < dataValues.length; i++) {
            tempShape = { x: dataValues[i + 0], y: dataValues[i + 1], w: dataValues[i + 2], h: dataValues[i + 3], p: dataValues[i + 4], f: dataValues[i + 5], t: dataValues[i + 6], n: dataValues[i + 7], s: dataValues[i + 8], c: dataValues[i + 9], wt: dataValues[i + 10], st: dataValues[i + 11], ratio: dataValues[i + 12], imfile: dataValues[i + 13], imName: dataValues[i + 14], Itype: 'field', fieldType: dataValues[i + 15] };
            shapes.push(tempShape);
            i = i + 15;
        }
    }
}

function ManageFields() {
    for (let i = 0; i < shapes.length; i++) {
        var shapeDiv = document.getElementById('div_' + shapes[i].imName + '');
        var shape = document.getElementById(shapes[i].imName);
        
        if (shape !== null) {
            $('#' + shapes[i].imName + '').remove();
        }

        if (shapeDiv !== null) {
            shapeDiv.parentNode.removeChild(shapeDiv);
        }
    }

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');


    for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].f === Npages[currentPage - 1]) {

            if (shapes[i].Itype === 'field') {

                var rect = canvas.getBoundingClientRect();

                var fld = document.getElementById('div_' + shapes[i].imName + '');

                if (fld === null) {
                    var wrapper = document.createElement('div');

                    wrapper.style.left = (rect.left + parseInt(shapes[i].x) + 2) + 'px';
                    wrapper.style.top = (rect.top + parseInt(shapes[i].y) + 2) + 'px';
                    wrapper.style.width = parseInt(shapes[i].w - 2) + 'px';
                    wrapper.style.height = parseInt(shapes[i].h - 2) + 'px';
                    wrapper.id = 'div_' + shapes[i].imName;
                    wrapper.style.zIndex = 50 + i;


                    if (shapes[i].fieldType === 'Text') {
                        wrapper.className = 'info';
                        wrapper.setAttribute('display', 'block');
                        var textarea = document.createElement('textarea');
                        textarea.className = 'tbox';
                        textarea.value = shapes[i].t;
                        textarea.style.width = (parseInt(shapes[i].w) - 2) + 'px';
                        textarea.style.height = (parseInt(shapes[i].h) - 2) + 'px';
                        textarea.style.left = '0px';
                        textarea.style.top = '0px';
                        textarea.style.zIndex = 150 + i;

                        if (shapes[i].st === 'True') {
                            textarea.style.backgroundColor = '#FFE4E1';
                        }
                        textarea.id = shapes[i].imName;

                        wrapper.appendChild(textarea);
                    }
                    else if (shapes[i].fieldType === 'CheckBox') {

                        wrapper.className = 'info';
                        wrapper.style.left = (rect.left + (parseInt(shapes[i].x))) + 'px';
                        wrapper.style.top = (rect.top + (parseInt(shapes[i].y))) + 'px';
                        wrapper.style.width = (parseInt(shapes[i].w) + 5) + 'px';
                        wrapper.style.height = (parseInt(shapes[i].h) + 5) + 'px';
                        if (shapes[i].st === 'True') {
                            wrapper.style.backgroundColor = '#FFE4E1';
                        }
                        var checkbox = document.createElement('input');
                        checkbox.type = 'checkbox';
                        checkbox.name = shapes[i].imfile;

                        if (shapes[i].t === 'true') {
                            checkbox.checked = true;

                        }
                        else {

                            checkbox.checked = false;
                        }
                        checkbox.style.zIndex = 150 + i;
                        checkbox.id = shapes[i].imName;

                        wrapper.appendChild(checkbox);

                    }
                    else if (shapes[i].fieldType === 'Radio') {
                        wrapper.className = 'Mine';
                        wrapper.style.left = (rect.left + parseInt(shapes[i].x)) + 'px';
                        wrapper.style.top = (rect.top - 1 + parseInt(shapes[i].y)) + 'px';
                        wrapper.style.width = (parseInt(shapes[i].w) + 5) + 'px';
                        wrapper.style.height = (parseInt(shapes[i].h) + 5) + 'px';
                        if (shapes[i].st === 'True') {
                            wrapper.style.backgroundColor = '#FFE4E1';
                        }
                        var radio = document.createElement('input');
                        radio.type = 'radio';
                        radio.id = shapes[i].imName;
                        radio.name = shapes[i].imfile;
                        if (shapes[i].t === 'true') {
                            radio.checked = true;

                        }
                        else {

                            radio.checked = false;
                        }
                        radio.style.zIndex = 150 + i;
                        radio.id = shapes[i].imName;
                        wrapper.appendChild(radio);
                    }
                    else if (shapes[i].fieldType === 'ComboBox') {

                        wrapper.className = 'tbox';
                        var combo = document.createElement('select');
                        combo.id = shapes[i].imName;
                        combo.style.zIndex = 150 + i;
                        var values = shapes[i].t.split('^^^');
                        combo.className = 'tbox';
                        combo.style.width = (shapes[i].w - 2) + 'px';
                        if (shapes[i].st === 'True') {
                            combo.style.backgroundColor = '#FFE4E1';
                        }
                        for (j = 1; j < values.length; j++) {

                            var option1 = document.createElement('option');
                            option1.value = values[j];
                            option1.innerHTML = values[j];
                            combo.appendChild(option1);

                        }
                        if (values[0] !== '') {

                            var opts = combo.options.length;
                            for (var k = 0; k < opts; k++) {
                                if (combo.options[k].value === values[0]) {
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
        success: function (data, textStatus, jqXHR) {
            document.getElementById('tblAttach').deleteRow(rowId);
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function GetFileExists() {
    var folder = typeof window.folderName !== 'undefined' 
        && window.folderName != 'undefined' ? 
        window.folderName : "";
    
    var file = typeof window.fileName !== 'undefined' 
        && window.fileName != 'undefined' ?
        window.fileName : "";
        
    $.ajax({
        type: 'GET',
        url: `${apiBaseUrl}document/info?folder=${folder}&fileName=${file}`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            dataLoad = data.pages;
            documentId = data.path;
            console.log(data);
            for (let i = 0; i < shapes.length; i++) {
                var shapeDiv = document.getElementById('div_' + shapes[i].imName + '');
                var shape = document.getElementById(shapes[i].imName);
                if (shape !== null) {
                    $('#' + shapes[i].imName + '').remove();
                }

                if (shapeDiv !== null) {
                    shapeDiv.parentNode.removeChild(shapeDiv);
                }
            }

            $('#hdnOpp').val('Empty');
            shapes2.length = 0;
            shapes.length = 0;
            Attachments.length = 0;
            $('#loadingModal').modal('hide');
            First();
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function newFileClick(action) {
    $.ajax({
        type: 'POST',
        url: `${apiBaseUrl}document/create`,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data, textStatus, jqXHR) {
            dataLoad = data.pages;
            documentId = data.path;
            for (i = 0; i < shapes.length; i++) {

                var shapeDiv = document.getElementById('div_' + shapes[i].imName + '');

                var shape = document.getElementById(shapes[i].imName);
                if (shape !== null) {
                    $('#' + shapes[i].imName + '').remove();
                }

                if (shapeDiv !== null) {
                    shapeDiv.parentNode.removeChild(shapeDiv);
                }
            }

            $('#hdnOpp').val('Empty');
            shapes2.length = 0;
            shapes.length = 0;
            Attachments.length = 0;
            First();
        },
        //call on ajax call failure
        error: function (xhr, textStatus, error) {
            alertModal('Error: ', xhr, textStatus, error);
        }
    })
    .done(function () { $('#loadingModal').modal('hide'); });
}

function clearSignature() {
    const signatureCanvas = document.querySelector('#signCanvas');
    signatureCanvas.width = signatureCanvas.width;    
    const ctx = signatureCanvas.getContext('2d');
    ctx.lineWidth = 5;
    ctx.lineJoin = 'round';
    ctx.lineCap = 'round';
    ctx.strokeStyle = 'blue';
}

function saveSignature() {
    const signatureCanvas = document.querySelector('#signCanvas');
    const imageData = signatureCanvas.toDataURL('image/png');

    var form = new FormData();
    form.append("documentId", documentId);
    signatureCanvas.toBlob(function (blob) {
        form.append(imageData, blob, "signature.png");
        $.ajax({
            type: 'POST',
            url: `${apiBaseUrl}shape/upload`,
            data: form,
            processData: false,
            contentType: false,
            success: function (data) {
                InsertImages(data.pages, signX, signY);
                $('#divSignature').css('visibility', 'hidden');
                currentTools = 'dragging';
                document.getElementById('btnDrag').click();
                var e = jQuery.Event('mousedown', { pageX: signX, pageY: signY });
                $('#imageView').trigger(e);
            }
        })
            .done(function () { $('#loadingModal').modal('hide'); });
    }, 'image/png');
}

function closeSignature() {
    $('#divSignature').css('visibility', 'hidden');
}

function onStartup() {
    document.getElementById('btnAddPage').disabled = false;
    document.getElementById('btnDeletePage').disabled = false;
    document.getElementById('btnMoving').disabled = false;
    document.getElementById('btnAppending').disabled = false;
    document.getElementById('btnSave').disabled = false;
    document.getElementById('btnExporting').disabled = false;
    document.getElementById('btnPrevious').disabled = false;
    document.getElementById('btnNext').disabled = false;
    document.getElementById('btnSearching').disabled = false;
    document.getElementById('btnImage').disabled = false;
    document.getElementById('btnRect').disabled = false;
    document.getElementById('btnRead').disabled = false;
    document.getElementById('btnDrag').disabled = false;
    document.getElementById('btnTexting').disabled = false;
    document.getElementById('btnAttachments').disabled = false;
    document.getElementById('btnSignature').disabled = false;
}

function drawRotationHandle(shape, context) {
    context.save();

    context.translate(shape.x, shape.y + parseInt(shape.s));
    context.rotate(shape.fieldType);

    context.strokeStyle = 'brown';
    context.setLineDash([6]);
    context.strokeRect(0, -shape.h, shape.w, shape.h);

    context.fillStyle = '#7171C6';
    context.fillRect(shape.w - 5, (shape.h / -2) - 5, 10, 10);

    context.restore();
}