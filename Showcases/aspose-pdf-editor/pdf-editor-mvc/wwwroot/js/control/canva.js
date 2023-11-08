// This function draws the #imageTemp canvas on top of #imageView, after which 
// #imageTemp is cleared. This function is called each time when the user 
// completes a drawing operation.
function img_update() {
    contexto.drawImage(canvas, 0, 0);
    context.clearRect(0, 0, canvas.width, canvas.height);
}

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
                textWidth: tempW,
                fontHeight: tempH,
                page: currentPage,
                f: Npages[currentPage - 1],
                text: '',
                fontText: '',
                fontSize: '',
                fontColor: '',
                fontWeight: '',
                fontStyle: '',
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
                            context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].textWidth, shapes[dragIndex].fontHeight);
                        }


                        if (shapes[dragIndex].Itype === 'image') {
                            context.fillStyle = 'rgba(255, 230, 81, 1)';
                            context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                            context.fillRect(shapes[dragIndex].x + shapes[dragIndex].textWidth - 10, shapes[dragIndex].y, 10, 10);
                            context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].fontHeight) - 10, 10, 10);
                            context.fillRect(shapes[dragIndex].x + shapes[dragIndex].textWidth - 10, (shapes[dragIndex].y + shapes[dragIndex].fontHeight) - 10, 10, 10);

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
                context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].textWidth, shapes[dragIndex].fontHeight);
            }
            if (shapes[dragIndex].Itype === 'image') {

                context.fillStyle = 'rgba(255, 230, 81, 1)';
                context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                context.fillRect((shapes[dragIndex].x + shapes[dragIndex].textWidth) - 10, shapes[dragIndex].y, 10, 10);
                context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].fontHeight) - 10, 10, 10);
                context.fillRect((shapes[dragIndex].x + shapes[dragIndex].textWidth) - 10, (shapes[dragIndex].y + shapes[dragIndex].fontHeight) - 10, 10, 10);

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

            var dx = mouseX - shapes[dragIndex].x + (shapes[dragIndex].textWidth) / 2;
            var dy = mouseY - shapes[dragIndex].y + (shapes[dragIndex].fontHeight) / 2;
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

            imgWidth = (shapes[dragIndex].x + shapes[dragIndex].textWidth);
            imgHeight = (shapes[dragIndex].y + shapes[dragIndex].fontHeight);

            // resize the image
            switch (anchorVal) {
                case 0:
                    //top-left
                    shapes[dragIndex].x = posX;
                    shapes[dragIndex].y = posY;
                    shapes[dragIndex].textWidth = imgWidth - posX;
                    shapes[dragIndex].fontHeight = imgHeight - posY;
                    break;
                case 1:
                    //top-right
                    shapes[dragIndex].y = posY;
                    shapes[dragIndex].textWidth = shapes[dragIndex].textWidth - (imgWidth - mouseX);
                    shapes[dragIndex].fontHeight = imgHeight - posY;
                    break;
                case 2:
                    //bottom-right
                    shapes[dragIndex].x = posX;
                    shapes[dragIndex].textWidth = imgWidth - posX;
                    shapes[dragIndex].fontHeight = shapes[dragIndex].fontHeight - (imgHeight - mouseY);
                    break;
                case 3:
                    //bottom-left
                    shapes[dragIndex].textWidth = shapes[dragIndex].textWidth - (imgWidth - mouseX);
                    shapes[dragIndex].fontHeight = shapes[dragIndex].fontHeight - (imgHeight - mouseY);
                    break;

            }


            if (shapes[dragIndex].textWidth < 25) { shapes[dragIndex].textWidth = 25; }
            if (shapes[dragIndex].fontHeight < 25) { shapes[dragIndex].fontHeight = 25; }

            canvas.width = canvas.width;


            DrawScreen();

            DrawShapes();

            if (shapes[dragIndex].Itype !== 'text') {
                context.strokeStyle = 'brown';
                context.setLineDash([6]);
                context.strokeRect(shapes[dragIndex].x, shapes[dragIndex].y, shapes[dragIndex].textWidth, shapes[dragIndex].fontHeight);
            }
            else if (shapes[dragIndex].Itype === 'text') {

                drawRotationHandle(shapes[dragIndex], context);

            }
            if (shapes[dragIndex].Itype === 'image') {

                context.fillStyle = 'rgba(255, 230, 81, 1)';
                context.fillRect(shapes[dragIndex].x, shapes[dragIndex].y, 10, 10);
                context.fillRect((shapes[dragIndex].x + shapes[dragIndex].textWidth) - 10, shapes[dragIndex].y, 10, 10);
                context.fillRect(shapes[dragIndex].x, (shapes[dragIndex].y + shapes[dragIndex].fontHeight) - 10, 10, 10);
                context.fillRect((shapes[dragIndex].x + shapes[dragIndex].textWidth) - 10, (shapes[dragIndex].y + shapes[dragIndex].fontHeight) - 10, 10, 10);

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
                if (shapes[i].text !== '') {

                    if (hitTest(shapes[i], textX, textY, context)) {
                        editText = i;
                        $('#textareaTest').val(shapes[i].text);
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

    this.mousemove = function () {
        if (!tool.started) {
            return;
        }
    };

    this.mouseup = function () {
        if (tool.started) {
            tool.started = false;
        }
        if (dragging) {
            dragging = false;
        }
    };

};

function anchorHitTest(shape, x, y, context) {
    anchorVal = -1;
    if (x > shape.x && x < (shape.x + 10) && y < (shape.y + 10) && y > shape.y && shape.Itype === 'image') {
        anchorVal = 0;
        return anchorVal;
    }
    else if (x > (shape.x + shape.textWidth - 10) && x < (shape.x + shape.textWidth) && y < (shape.y + 10) && y > shape.y && shape.Itype === 'image') {

        anchorVal = 1;

        return anchorVal;
    }
    else if (x > shape.x && x < (shape.x + 10) && y > (shape.y + shape.fontHeight - 10) && y < (shape.y + shape.fontHeight) && shape.Itype === 'image') {

        anchorVal = 2;
        return anchorVal;
    }
    else if (x > (shape.x + shape.textWidth - 10) && x < (shape.x + shape.textWidth) && y > (shape.y + shape.fontHeight - 10) && y < (shape.y + shape.fontHeight) && shape.Itype === 'image') {
        anchorVal = 3;
        return anchorVal;
    }

    else if (x > (shape.x + shape.textWidth - 5) && x < (shape.x + shape.textWidth + 5) && y < (shape.y + (shape.fontHeight / 2) + 10) && y > (shape.y + (shape.fontHeight / 2) - 10) && shape.Itype === 'text') {
        anchorVal = 5;
        return anchorVal;
    }
    else if (shape.Itype === 'text') {

        context.save();

        context.translate(shape.x, shape.y + parseInt(shape.fontSize));
        context.rotate(shape.fieldType);

        context.beginPath();
        context.rect(shape.textWidth - 5, (shape.fontHeight / -2) - 5, 10, 10);

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

        context.translate(shape.x, shape.y + parseInt(shape.fontSize));
        context.rotate(shape.fieldType);

        context.beginPath();
        context.rect(0, -shape.fontHeight, shape.textWidth + 5, shape.fontHeight);

        var result = context.isPointInPath(mx, my);

        context.restore();

        return result;
    }

    if (mx > shape.x && mx < shape.x + shape.textWidth) {
        if (my > shape.y && my < shape.y + shape.fontHeight) {
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

function DrawScreen() {
    let canvas = document.getElementById('imageView');
    let context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.width, canvas.height);
    document.getElementById('imageTemp').getContext('2d').clearRect(0, 0, canvas.width, canvas.height);
}