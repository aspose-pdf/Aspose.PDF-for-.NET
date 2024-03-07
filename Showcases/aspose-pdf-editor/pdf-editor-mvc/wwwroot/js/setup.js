let apiBaseUrl = '/api/';
let documentId = '';
let ratio = 1;
let canvasHeight = 760;
let canvasWidth = 2000;
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

// This object holds the implementation of each drawing tool.
var tools = {};
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

if (window.addEventListener) {
    window.addEventListener('load', function () {
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

            GetDocumentInfo();

            $('#sidePanel').hide();
            $('#btnAnnotate').on('click', function () {
                // Adjust the column classes on the main content area
                if ($('#mainContent').hasClass('col-md-9')) {
                    $('#mainContent').removeClass('col-md-9').addClass('col-md-12');
                    $('#sidePanel').hide();
                    document.body.style.zoom = "100%";

                    document.getElementById('btnAddPage').disabled = false;
                    document.getElementById('btnDeletePage').disabled = false;
                    document.getElementById('btnMoving').disabled = false;
                    document.getElementById('btnAppending').disabled = false;
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

                } else {
                    $('#mainContent').removeClass('col-md-12').addClass('col-md-9');
                    $('#sidePanel').show();
                    document.body.style.zoom = "80%";

                    document.getElementById('btnAddPage').disabled = false;
                    document.getElementById('btnDeletePage').disabled = true;
                    document.getElementById('btnMoving').disabled = true;
                    document.getElementById('btnAppending').disabled = true;
                    document.getElementById('btnPrevious').disabled = true;
                    document.getElementById('btnNext').disabled = true;
                    document.getElementById('btnSearching').disabled = true;
                    document.getElementById('btnImage').disabled = true;
                    document.getElementById('btnRect').disabled = true;
                    document.getElementById('btnRead').disabled = true;
                    document.getElementById('btnDrag').disabled = true;
                    document.getElementById('btnTexting').disabled = true;
                    document.getElementById('btnAttachments').disabled = true;
                    document.getElementById('btnSignature').disabled = true;
                }
            });
        }

        init();

    }, false);
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
    document.getElementById('btnAnnotate').disabled = false;
}

function wait(ms) {
    var deferred = jQuery.Deferred();
    var intervalId = setInterval(function () {
        clearInterval(intervalId);
        deferred.resolve();
    }, 100);
    return deferred.promise();
}