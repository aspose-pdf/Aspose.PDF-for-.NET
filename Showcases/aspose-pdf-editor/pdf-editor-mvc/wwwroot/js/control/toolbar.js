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
function ev_tool_change() {
    if (tools['rect'] && currentTools === 'Rect') {
        tool = new tools['rect']();
    }
}

// The event handler for any changes made to the tool selector.
function ev_tool_change2() {
    if (tools['reading'] && currentTools === 'Read') {
        tool = new tools['reading']();
    }
}

// The event handler for any changes made to the tool selector.
function ev_tool_change3() {
    if (tools['dragging'] && currentTools === 'Drag') {
        tool = new tools['dragging']();
    }
}

// The event handler for any changes made to the tool selector.
function ev_tool_change4() {
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

function moveClick(event) {
    event.preventDefault();
    GeneralSetup('Move');
}

function appendClick(event) {
    event.preventDefault();
    GeneralSetup('Append');
}

$('.btn-group > .btn').click(function () {
    $('.btn-group > .btn').removeClass('active');
    $(this).addClass('active');
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


function GeneralSetup(process) {
    for (i = 0; i < shapes.length; i++) {
        if (shapes[i].f === Npages[currentPage - 1]) {
            if (shapes[i].Itype === 'field') {
                let getField = document.getElementById(shapes[i].imName);
                if (getField !== null) {
                    if (shapes[i].fieldType === 'Text') {
                        shapes[i].text = getField.value;
                    }
                    else if (shapes[i].fieldType === 'ComboBox') {
                        let optValues = getField.value;
                        for (x = 0; x < getField.options.length; x++) {
                            optValues = optValues + '^^^' + getField.options[x].value;
                        }
                        shapes[i].text = optValues;
                    }
                    else if (shapes[i].fieldType === 'CheckBox' || shapes[i].fieldType === 'Radio') {
                        shapes[i].text = getField.checked;
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