function SaveText() {
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
                textWidth: ctx.measureText(text).width, 
                fontHeight: parseInt(fontSize), 
                page: currentPage, 
                f: Npages[currentPage - 1], 
                text: text, 
                fontText: fontText, 
                fontSize: fontSize, 
                fontColor: fontColor, 
                fontWeight: fontWeight, 
                fontStyle: fontStyle, 
                ratio: aRatio[currentPage - 1], 
                imfile: '', 
                imName: '', 
                Itype: 'text', 
                fieldType: r 
            };

            shapes.push(tempShape);
        }
        else {

            shapes[editText].text = text;
            shapes[editText].fontWeight = fontWeight;
            shapes[editText].fontSize = fontSize;
            shapes[editText].fontText = fontText;
            shapes[editText].fontStyle = fontStyle;
            shapes[editText].fontColor = fontColor;
            shapes[editText].fontHeight = parseInt(fontSize);

            DrawScreen();
            DrawShapes();
            shapes[editText].textWidth = ctx.measureText(text).width;
        }
        ctx.save();
        ctx.restore();
    }
}

function DeleteShapes() {
    for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].Page === Npages[currentPage - 1]) {

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

function InsertImages(data, imgLeft, imgTop) {
    let canvas = document.getElementById('imageView');
    let context = canvas.getContext('2d');

    let image1 = `${apiBaseUrl}page/preview/${documentId}/${data}?Dummy=${Math.random()}`;

    let imgWidth = 0;
    let imgHeight = 0;

    var imageObj = new Image();

    imageObj.onload = function () {
        context.drawImage(imageObj, imgLeft, imgTop);
        imgWidth = this.width;
        imgHeight = this.height;

        tempShape =
        {
            x: imgLeft,
            y: imgTop,
            textWidth: imgWidth,
            fontHeight: imgHeight,
            page: currentPage,
            f: Npages[currentPage - 1],
            text: '',
            fontText: '',
            fontSize: '',
            fontColor: '',
            fontWeight: '',
            fontStyle: '',
            ratio: aRatio[currentPage - 1],
            imfile: imageObj,
            imName: data,
            Itype: 'image',
            fieldType: ''
        };
        shapes.push(tempShape);

    };
    imageObj.src = image1;
    imageObj.style.zIndex = 500 + shapes.length;
}

function drawRotationHandle(shape, context) {
    context.save();

    context.translate(shape.x, shape.y + parseInt(shape.fontSize));
    context.rotate(shape.fieldType);

    context.strokeStyle = 'brown';
    context.setLineDash([6]);
    context.strokeRect(0, -shape.fontHeight, shape.textWidth, shape.fontHeight);

    context.fillStyle = '#7171C6';
    context.fillRect(shape.textWidth - 5, (shape.fontHeight / -2) - 5, 10, 10);

    context.restore();
}

function addFields(fieldData) {
    if (fieldData !== '') {
        var dataValues = fieldData.split('$#$');

        for (i = 0; i < dataValues.length; i++) {
            tempShape =
            {
                x: dataValues[i + 0],
                y: dataValues[i + 1],
                textWidth: dataValues[i + 2],
                fontHeight: dataValues[i + 3],
                page: dataValues[i + 4],
                f: dataValues[i + 5],
                text: dataValues[i + 6],
                fontText: dataValues[i + 7],
                fontSize: dataValues[i + 8],
                fontColor: dataValues[i + 9],
                fontWeight: dataValues[i + 10],
                fontStyle: dataValues[i + 11],
                ratio: dataValues[i + 12],
                imfile: dataValues[i + 13],
                imName: dataValues[i + 14],
                Itype: 'field',
                fieldType: dataValues[i + 15]
            };
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

    for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].f === Npages[currentPage - 1]) {

            if (shapes[i].Itype === 'field') {

                var rect = canvas.getBoundingClientRect();

                var fld = document.getElementById('div_' + shapes[i].imName + '');

                if (fld === null) {
                    var wrapper = document.createElement('div');

                    wrapper.style.left = (rect.left + parseInt(shapes[i].x) + 2) + 'px';
                    wrapper.style.top = (rect.top + parseInt(shapes[i].y) + 2) + 'px';
                    wrapper.style.width = parseInt(shapes[i].textWidth - 2) + 'px';
                    wrapper.style.height = parseInt(shapes[i].fontHeight - 2) + 'px';
                    wrapper.id = 'div_' + shapes[i].imName;
                    wrapper.style.zIndex = 50 + i;


                    if (shapes[i].fieldType === 'Text') {
                        wrapper.className = 'info';
                        wrapper.setAttribute('display', 'block');
                        var textarea = document.createElement('textarea');
                        textarea.className = 'tbox';
                        textarea.value = shapes[i].text;
                        textarea.style.width = (parseInt(shapes[i].textWidth) - 2) + 'px';
                        textarea.style.height = (parseInt(shapes[i].fontHeight) - 2) + 'px';
                        textarea.style.left = '0px';
                        textarea.style.top = '0px';
                        textarea.style.zIndex = 150 + i;

                        if (shapes[i].fontStyle === 'True') {
                            textarea.style.backgroundColor = '#FFE4E1';
                        }
                        textarea.id = shapes[i].imName;

                        wrapper.appendChild(textarea);
                    }
                    else if (shapes[i].fieldType === 'CheckBox') {

                        wrapper.className = 'info';
                        wrapper.style.left = (rect.left + (parseInt(shapes[i].x))) + 'px';
                        wrapper.style.top = (rect.top + (parseInt(shapes[i].y))) + 'px';
                        wrapper.style.width = (parseInt(shapes[i].textWidth) + 5) + 'px';
                        wrapper.style.height = (parseInt(shapes[i].fontHeight) + 5) + 'px';
                        if (shapes[i].fontStyle === 'True') {
                            wrapper.style.backgroundColor = '#FFE4E1';
                        }
                        var checkbox = document.createElement('input');
                        checkbox.type = 'checkbox';
                        checkbox.name = shapes[i].imfile;

                        if (shapes[i].text === 'true') {
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
                        wrapper.style.width = (parseInt(shapes[i].textWidth) + 5) + 'px';
                        wrapper.style.height = (parseInt(shapes[i].fontHeight) + 5) + 'px';
                        if (shapes[i].fontStyle === 'True') {
                            wrapper.style.backgroundColor = '#FFE4E1';
                        }
                        var radio = document.createElement('input');
                        radio.type = 'radio';
                        radio.id = shapes[i].imName;
                        radio.name = shapes[i].imfile;
                        if (shapes[i].text === 'true') {
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
                        var values = shapes[i].text.split('^^^');
                        combo.className = 'tbox';
                        combo.style.width = (shapes[i].textWidth - 2) + 'px';
                        if (shapes[i].fontStyle === 'True') {
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

function DrawShapes() {
    let canvas = document.getElementById('imageView');
    let context = canvas.getContext('2d');

    for (let i = 0; i < shapes.length; i++) {
        if (shapes[i].f === Npages[currentPage - 1]) {

            if (shapes[i].Itype === 'highlight') {
                context.fillStyle = 'rgba(255, 230, 81, 0.5)';
                context.fillRect(shapes[i].x, shapes[i].y, shapes[i].textWidth, shapes[i].fontHeight);
            }
            if (shapes[i].Itype === 'image') {

                var imageObj = shapes[i].imfile;
                context.drawImage(imageObj, shapes[i].x, shapes[i].y, shapes[i].textWidth, shapes[i].fontHeight);

            }
            if (shapes[i].Itype === 'text') {


                context.save();
                context.translate(shapes[i].x, shapes[i].y + parseInt(shapes[i].fontSize));

                context.rotate(shapes[i].fieldType);

                //set the font styles
                var font = shapes[i].fontText;
                var fontsize = shapes[i].fontSize;
                var fontweight = shapes[i].fontWeight;
                var fontstyle = shapes[i].fontStyle;
                context.fillStyle = shapes[i].fontColor;

                //draw the text
                context.font = fontstyle + ' ' + fontweight + ' ' + fontsize + 'px ' + font;

                context.fillText(shapes[i].text, 0, 0);

                context.restore();
            }

        }
    }
}