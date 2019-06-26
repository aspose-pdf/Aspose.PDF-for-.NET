<%@ Page Title="" Language="C#" MasterPageFile="~/AsposePdfEditor.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AsposePdfEditor.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" src="https://www.dropbox.com/static/api/2/dropins.js" id="dropboxjs" data-app-key="a5nv6qw84rxabs6"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!-- Modal -->
<div class="modal" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" data-backdrop="static" data-keyboard="false"  aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
        <h4 class="modal-title" id="myModalLabel">File Upload Dialog</h4>
      </div>
      <div class="modal-body">
      
              <label for="fileToUpload">Select a File to Upload</label><br />
      <input type="file" name="fileToUpload" id="fileToUpload" onchange="fileSelected();" accept="application/pdf, image/png, image/jpg, image/jpeg, image/gif"/>
      
      </div>
      <div class="modal-footer">

      <div class="progress" >
  <div class="progress progress-striped active">
        <div class="progress-bar progress-bar-success" style="width:0%"></div>
    </div>
</div>
     

          <input id="hdnOpp" type="hidden" />
      </div>
    </div>
  </div>
</div>     

<div class="modal" id="moveModal"   tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true" data-backdrop="static" data-keyboard="false">
  <div class="modal-dialog modal-sm">
    <div class="modal-content">
     <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" onclick="moveModeClose();return false;"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
        <h4 class="modal-title" id="H1">Move Page After</h4>
      </div>
      <div class="modal-body">
      <label id="lblpagemove" for="txtMove">Enter Page Number</label><br />
      <input type="text" id="txtMove"/>
      </div>
      <div class="modal-footer">
      <button type="button" class="btn btn-default" id="btnMove" onclick="Move();" data-dismiss="modal">Move</button>
      <input id="hdnMove" type="hidden" />
    </div>
    </div>
  </div>
</div> 

<div class="modal" id="replaceModal"   tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-sm">
    <div class="modal-content">
     <div class="modal-header">        
        <h4 class="modal-title" id="H2">Replace Text</h4>
      </div>
      <div class="modal-body">
      <label id="Label1" for="txtFind">Find Text</label><br />
      <input type="text" id="txtFind"/><br />
      <label id="Label2" for="txtReplace">Replace With</label><br />
      <input type="text" id="txtReplace"/>
      </div>
      <div class="modal-footer">
      <button type="button" class="btn btn-default" id="btnReplace" onclick="ReplaceText();" data-dismiss="modal">Replace</button>
     
    </div>
    </div>
  </div>
</div> 

<div class="modal fade bs-example-modal-sm" tabindex="-1" id="loadingModal" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true" data-backdrop="static" data-keyboard="false" >
  <div class="modal-dialog modal-sm">
    <div class="modal-content"> 
      <img src="framely.gif" />
    </div>
  </div>
</div>

<!-- Attachments -->
<div class="modal" id="divAttach" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" data-backdrop="static" data-keyboard="false"  aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
        <h4 class="modal-title" id="H3">Attachments</h4>
      </div>
      <div class="modal-body">
      <table class="table table-bordered" id="tblAttach">
  <thead>
  <tr>
  <th>File Name</th>
  <th>File Description</th>
  <th>Download File</th>
  <th>Remove File</th>
  </tr>
  </thead>
</table>
      </div>
      <div class="modal-footer">
      </div>
    </div>
  </div>
</div>     

<div id='divSignature' class="panel panel-success" style='position:absolute;z-index:1030; visibility:hidden'>
<div class="modal-header">
<h4 class="modal-title" id="H4">Signature</h4>
</div>
<canvas id="signCanvas" width="350" height="150" style="z-index:1125;" ></canvas>
 <div class="modal-footer">
      <button type="button" class="btn btn-default" id="btnClear" onclick="clearSignature();">Clear</button>
      <button type="button" class="btn btn-default" id="btnSignDone" onclick="saveSignature();">Done</button>
      <button type="button" class="btn btn-default" id="btnSignClose" onclick="closeSignature();">Close</button>
      </div>
</div>


<nav class="navbar navbar-inverse" role="navigation">  
  <h3 style="color:White; text-align:center">HTML5 PDF Editor by Aspose for .NET</h3>
</nav>
<div class="well well-sm">

    <!-- Single button -->
<div class="btn-group">

  <button type="button" class="btn btn-primary btn-lg dropdown-toggle" data-toggle="dropdown" aria-expanded="false" >
    <span class=" glyphicon glyphicon-upload"></span>
  </button>
<ul class="dropdown-menu">  
  <li><a onclick="javascript:onNewFileClicked('upload')"> Create New File</a></li>
  <li><a class="open-myModal" data-toggle="modal" data-target="#myModal" data-id="uploading" data-placement="top" title="Upload File to Server">Open From Computer</a></li>
  <li><a onclick="javascript:onDropboxChooserClicked('upload')">Open From Dropbox</a></li>
  </ul>   
</div>

    <button onclick="javascript:generalSetup('Add');AddPage();$('#divDel').css('visibility', 'hidden');return false;" class="btn btn-default btn-lg" id="btnAddPage" data-toggle="tooltip" data-placement="top" title="Add Page" disabled=disabled>
    <span class="glyphicon glyphicon-plus"></span>
    </button>
     <button onclick="javascript:generalSetup('Delete');DeletePage();$('#divDel').css('visibility', 'hidden');return false;" class="btn btn-default btn-lg" id="btnDeletePage" data-toggle="tooltip" data-placement="top" title="Delete Page" disabled=disabled>
    <span class="glyphicon glyphicon-minus"></span>
    </button>
    <button class="open-moveModal btn btn-default btn-lg" data-toggle="modal" onclick="generalSetup('Move');" data-target="#moveModal" data-toggle="tooltip" id="btnMoving" data-id="moving" data-placement="top" title="Move Page" disabled=disabled>    
    <span class="glyphicon glyphicon-transfer"></span> 
    </button>

     <button class="open-myModal btn btn-default btn-lg" data-toggle="modal" data-target="#myModal" onclick="generalSetup('Append');" data-id="appending" id="btnAppending" data-placement="top" title="Append File" disabled=disabled>
     <span class="glyphicon glyphicon-plus-sign"></span>    
    </button>

    <button onclick="javascript:generalSetup('Save');UploadPic();return false;" class="btn btn-default btn-lg" id="btnSave" data-toggle="tooltip"  data-placement="top" title="Save Pdf File" disabled=disabled>
    <span class="glyphicon glyphicon-floppy-disk"></span>
    </button>
    <div class="btn-group">
  <button type="button" class="btn btn-default btn-lg" data-placement="top" title="Export File" data-toggle="dropdown" onclick="generalSetup('Export');" id="btnExporting" aria-expanded="false" disabled=disabled>
    <span class=" glyphicon glyphicon-export"></span>
  </button>
  <ul class="dropdown-menu" role="menu">
    <li><a onclick="javascript:SaveText('pdf');return false;"> As PDF File</a></li>
    <li><a onclick="javascript:SaveText('docx');return false;"> As Word File </a></li>  
    <li><a onclick="javascript:SaveText('xls');return false;"> As Excel File </a></li> 
    <li><a onclick="javascript:SaveText('txt');return false;"> As Text File </a></li> 
    <li><a onclick="javascript:SaveText('svg');return false;"> As SVG File </a></li> 
    <li><a onclick="javascript:SaveText('xps');return false;"> As XPS File </a></li> 
    <li><a onclick="javascript:SaveText('html');return false;"> As HTML File </a></li>   
  </ul>
</div>

    <button onclick="javascript:generalSetup('Previous');Previous();$('#divDel').css('visibility', 'hidden');return false;" class="btn btn-default btn-lg" data-toggle="tooltip" id="btnPrevious" data-placement="top" title="Previous Page" disabled=disabled>
    <span class="glyphicon glyphicon-circle-arrow-left"></span> 
    </button>
     <button  class="btn btn-default btn-lg" data-toggle="tooltip" data-placement="top" id="lblPages">Page 0 Of 0</button>
    <button onclick="javascript:generalSetup('Next');Next();$('#divDel').css('visibility', 'hidden');return false;" class="btn btn-default btn-lg" id="btnNext" data-toggle="tooltip" data-placement="top" title="Next Page" disabled=disabled>
     <span class="glyphicon glyphicon-circle-arrow-right"></span>    
    </button>


    <div class="btn-group">
  <button type="button" class="btn btn-default btn-lg dropdown-toggle" data-toggle="dropdown" aria-expanded="false" onclick="generalSetup('Search');" id="btnSearching" disabled=disabled>
    <span class=" glyphicon glyphicon-search"></span>
  </button>
  <ul class="dropdown-menu" role="menu">
    <li><a class="open-moveModal" data-toggle="modal" data-target="#moveModal" data-id="searching" data-placement="top" title="Search Text"> Search Text</a></li>
    <li><a class="open-replaceModal" data-toggle="modal" data-target="#replaceModal" data-id="replacing" data-placement="top" title="Replace Text"> Replace Text</a></li>
    <li><a onclick="javascript:ClearSearchClicked()"> Clear Search</a></li>    
  </ul>
</div>
    <div class="btn-group">
  <button type="button" class="btn btn-default btn-lg dropdown-toggle" data-toggle="dropdown" aria-expanded="false" onclick="generalSetup('Image');" id="btnImage" disabled=disabled>
    <span class="glyphicon glyphicon-picture"></span>
  </button>
  <ul class="dropdown-menu" role="menu">
    <li><a class="open-myModal" data-toggle="modal" data-target="#myModal" data-id="images" data-toggle="tooltip" data-placement="top" title="Insert Image"> From Computer</a></li>
    <li><a onclick="javascript:onDropboxChooserClicked('image')"> From Dropbox</a></li>    
  </ul>
</div>
      
    <div class="btn-group">
    <button id="btnRect" value="rect"  class="btn btn-default btn-lg" data-toggle="tooltip" data-placement="top" title="Highlight Mode" onclick="generalSetup('Rect');" disabled=disabled>
     <span class="glyphicon glyphicon-header"></span>  
    </button>

     <button id="btnRead" value="reading"  class="btn btn-default btn-lg" data-toggle="tooltip" data-placement="top" title="Read Mode" onclick="generalSetup('Read');" disabled=disabled>
     <span class="glyphicon glyphicon-hand-up"></span>  
    </button>

     <button id="btnDrag" value="dragging"  class="btn btn-default btn-lg" data-toggle="tooltip" data-placement="top" title="Drag Mode" onclick="generalSetup('Drag');" disabled=disabled>
     <span class="glyphicon glyphicon-move"></span>  
    </button>

     <button id="btnTexting" value="texting"  class="btn btn-default btn-lg" data-toggle="tooltip" data-placement="top" title="Text Mode" onclick="generalSetup('Text');" disabled=disabled> 
     <span class="glyphicon glyphicon-text-height"></span>  
    </button>
    </div>
      <div class="btn-group">
     <button id="btnAttachments" class="btn btn-default btn-lg dropdown-toggle" data-toggle="dropdown" aria-expanded="false"  title="Attachments" disabled=disabled> 
     <span class="glyphicon glyphicon-paperclip"></span>  
    </button>
    <ul class="dropdown-menu">  
  <li><a class="open-myModal" data-toggle="modal" data-target="#myModal" data-id="addAttachment" data-toggle="modal" data-placement="top" title="Add Attachment" >Add Attachment</a></li>
  <li><a data-id="attachment" data-toggle="modal" data-target="#divAttach" data-placement="top" title="View Attachments" onclick="generalSetup('Attach');">View Attachments</a></li>
  </ul>   
    

    <button id="btnSignature" value="signature"  class="btn btn-default btn-lg" data-toggle="tooltip"  data-placement="top" title="Signature" onclick="generalSetup('signature');" disabled=disabled> 
     <span class="glyphicon glyphicon-pencil"></span>  
    </button>

    </div>
</div>



    <div id="container">
       <canvas id="imageView" width="1138" height="760" style="z-index:5; background-color:GrayText;" >
      
        <p>Unfortunately, your browser is currently unsupported by our web
        application.  We are sorry for the inconvenience. Please use one of the
        supported browsers listed below, or draw the image you want using an offline tool.</p>    
        
       
      </canvas>

         </div>

<div class="modal bs-example-modal-sm" id="myColors" tabindex="-1"  aria-labelledby="mySmallModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-sm">
    <div class="modal-content">
     <div class="modal-body">      
      <button id="btnRed" style="border:'1px solid'; background-color:Red; height:22px; width:22px;" name="red" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Red"></button>
      <button id="btnBlack" style="border:'1px solid'; background-color:Black; height:22px; width:22px;" name="black" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Black"></button>
      <button id="btnWhite" style="border:'1px solid'; background-color:White; height:22px; width:22px;" name="white" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="White"> </button> 
      <button id="btnGreen" style="border:'1px solid'; background-color:Green; height:22px; width:22px;" name="green" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Green"></button>
      <button id="btnBlue" style="border:'1px solid'; background-color:Blue; height:22px; width:22px;" name="blue" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Blue"></button>
      <button id="btnGray" style="border:'1px solid'; background-color:Gray; height:22px; width:22px;" name="gray" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Gray"> </button> 
      <button id="btnYellow" style="border:'1px solid'; background-color:Yellow; height:22px; width:22px;" name="yellow" onclick="selectColor(this);" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Yellow"> </button> 
     
    </div>
    </div>
  </div>
</div> 

       <div id='textAreaPopUp' class="panel panel-success" style='position:absolute;z-index:1030; visibility:hidden'>
       <table id="txtTable" class="table table-condensed">
       <tr>
       <td>
       <select id='ddFont' class="dropdown" onchange="ddFontChange()">
         <option value="Arial" selected="selected">Arial</option>
         <option value="Times">Times New Roman</option>
         <option value="Verdana">Verdana</option>
         <option value="Tahoma">Tahoma</option>
       </select>
       <select id='ddSize' class="dropdown" onchange="ddSizeChange()">
       <option value="8" selected="selected">8px</option>
       <option value="9">9px</option>
       <option value="10">10px</option>
       <option value="12">12px</option>
       <option value="14">14px</option>
       <option value="16">16px</option>
       <option value="18">18px</option>
       <option value="24">24px</option>
       <option value="36">36px</option>
       <option value="48">48px</option>
       <option value="72">72px</option>

       </select>
        <button id="btnBold" value="Bold" onclick="makeBold();"  class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Bold">
     <span class="glyphicon glyphicon-bold"></span>  
    </button>

     <button id="btnItalic" value="Italic" onclick="makeItalic();" class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Italic">
     <span class="glyphicon glyphicon-italic"></span>  
    </button>

     <button id="btnUnderline" value="Underline"  class="btn btn-default btn-xs" data-toggle="button" data-placement="top" title="Underline">
     <span class="glyphicon glyphicon-text-width"></span>  
    </button>

     <button id="btnColor" value="Color" style="border:'1px solid';  background-color:Black; height:22px; width:22px;" data-toggle="modal" data-target="#myColors" class="btn btn-default"  data-placement="bottom" title="Color">
       
    </button>
       </td>
       </tr>
       <tr>
       <td>
       <textarea id='textareaTest' class="form-control" style='width:350px; height:50px;'></textarea>
       <%--<div id='textareaTest' contentEditable="true"></div>--%>
       </td>
       </tr>
       <tr>
       <td>
       <button type='button' value='save' id='saveText' onclick='saveTextFromArea();' class="btn btn-default"> 
       <span class="glyphicon glyphicon-ok-sign"></span>  
       </button>
       <button type='button' value='cancel' id='Button1' onclick='closeTextEditor();' class="btn btn-default"> 
       <span class="glyphicon glyphicon-remove-sign"></span>
        </button>
       </td>
       </tr>
       </table>
       </div>
       <div id="divDel" class="panel panel-success" style='position:absolute;z-index:30; visibility:hidden'>
       <button type='button' value='cancel' id='btnDel' onclick='DelShape();' class="btn btn-default"> 
       <span class="glyphicon glyphicon-remove-sign"></span>
        </button>
       </div>
  <script type="text/javascript" src="Editor.js">
  </script>
</asp:Content>
