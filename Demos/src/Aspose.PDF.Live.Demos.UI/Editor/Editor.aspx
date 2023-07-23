<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="Aspose.Pdf.Live.Demos.UI.Editor" %>

<%@ Register Src="~/Editor/EditorControl.ascx" TagPrefix="aspose" TagName="editor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .btn-group > .btn:first-child {
            background: #ebebeb;
            border: 1px solid #ccc;
            padding: 10px 16px;
            font-size: 16px !important;
            color: #757575;
            border-radius: 1px !important;
            text-align: left;
            min-width: 16px !important;
            box-shadow: 0 6px 1px -5px #666;
        }

        #container {
            position: relative;
        }

        #imageView {
            border: 1px solid #000;
        }

        #imageTemp {
            position: absolute;
            top: 1px;
            left: 1px;
        }

        .info {
            position: absolute;
            background-color: White;
            border-style: none;
            resize: none;
            vertical-align: top;
            text-align: center;
        }

        .tbox {
            position: absolute;
            background-color: white;
            border-style: none;
            resize: none;
        }

        .Mine {
            position: absolute;
            background-color: white;
            border-style: none;
            resize: none;
            vertical-align: top;
            text-align: center;
        }

        .modal-admin {
            width: 400px;
            margin-left: 100px;
        }

        .modal-content {
            width: 800px;
        }
        .modal-header {
            padding: 40px;
        }
        .progress {
            margin-top: 0;
        }
        h4 {
            color: black!important;
        }

        input[type=radio] {
        }

        input[type=checkbox] {
        }
    </style>
    <div class="container-fluid asposetools">
        <div class="container">
            <div class="row">
                <div class="col-md-12 pt-5 pb-5">
                    <h1 runat="server" id="ProductTitle"></h1>
                    <h2 runat="server" id="ProductTitleSub"></h2>
                    <div class="form">
                        <aspose:editor runat="server" ID="Editor1" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-12 pt-5 app-product-section tl">
            <div class="container">
                <div class="col-md-3 pull-right">
                    <img src="dummy.img" runat="server" id="ProductImage" />
                </div>
                <div class="col-md-9 pull-left">
                    <h3 runat="server" id="AsposeProductTitle"></h3>
                    <ul>
                        <li>Supported Documents: PDF</li>
                        <li>Save edited document to desired format: PDF, HTML and others </li>
                       
                    </ul>
                </div>
            </div>
        </div>
        <!-- Extension Description Box -->
        <div class="col-md-12 pull-left d-flex d-wrap bg-gray appfeaturesectionlist" id="dvExtensionDescription" visible="false" runat="server">

            <div class="col-md-6 cardbox tc col-md-offset-3 b6">
                <h3 id="hExtension1"><em class="icofile"><b><% = ViewState["Extension1"] %></b></em><span><% = ViewState["Extension1Name"]  %></span></h3>
                <p id="hExtension1Description" runat="server"></p>
            </div>



        </div>

        <!-- HowTo Section -->
        <div class="col-md-12 tl bg-darkgray howtolist" id="dvHowToSection" visible="true" runat="server">
            <div class="container tl dflex">

                <div class="col-md-4 howtosectiongfx">
                    <img src="../img/howto.png"></div>
                <div class="howtosection col-md-8">
                    <div><i class="fa fa-question-circle "></i>
                        <h2 style="color: black"><b><%= string.Format(Resources["HowtoEditorTitle"], ViewState["Extension1"], AsposeProductTitle.InnerText) %></b></h2>
                        <ul>
                            <li><%= string.Format(Resources["HowtoEditorFeature1"], ViewState["Extension1"]) %></li>
                            <li><%= Resources["HowtoEditorFeature2"] %></li>
                            <li><%= string.Format(Resources["HowtoEditorFeature3"],ViewState["Extension1"]) %></li>
                            <li><%= string.Format(Resources["HowtoEditorFeature4"],ViewState["Extension1"]) %></li>
                            <li><%= string.Format(Resources["HowtoEditorFeature5"],ViewState["Extension1"]) %></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>


    </div>
    <script>
        apiBaseUrl = '<%= AsposeEditorApi%>';
    </script>
</asp:Content>
