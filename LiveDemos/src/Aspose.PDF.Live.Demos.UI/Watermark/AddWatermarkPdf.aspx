<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" Async="true" CodeBehind="AddWatermarkPdf.aspx.cs" Inherits=" Aspose.Pdf.Live.Demos.UI.AddWatermarkPdf" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <!-- Aspose.Tools UI Template Starts Here -->
            <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>--%>
            <div class="container-fluid asposetools pb5">
                <div class="container">
                    <div class="row">

                        <div class="col-md-12 pt-5 pb-5">
							<a href="/default" class="btn btn-success btn-lg">Home</a>
                            <asp:HiddenField ID="hdnWatermarkType" runat="server" />
                            <asp:HiddenField ID="hdnAsposeProductName" runat="server" />

                            <h1 runat="server" id="hFeatureTitle"></h1>
                            <h4 runat="server" id="hPageTitle"></h4>
                            <div class="form">
                                                    <asp:HiddenField ID="hdnDownloadFileURL" runat="server" Value="" />
                                                    <asp:HiddenField runat="server" ID="hdnToValue" ClientIDMode="Static" Value="" />
                                                    <asp:HiddenField runat="server" ID="HiddenField1" ClientIDMode="Static" Value="" />

                                <asp:MultiView runat="server" ActiveViewIndex="0" ID="PageViewId" OnActiveViewChanged="PageViewId_OnActiveViewChanged">
                                    <asp:View runat="server" ID="uploadFileView">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        
                                        <div class="uploadfile">

                                            <div class="filedropdown">
                                                <div class="filedrop">
                                                    <label class="dz-message needsclick"><% = Resources["DropOrUploadFile"] %></label>
         <%--                                           <asp:FileUpload type="file" name="FileUpload1" id="FileUpload1" runat="server" class="uploadfileinput uploadfileinputtxt" />--%>

													<input type="file" name="FileUpload1" id="FileUpload1" runat="server" class="uploadfileinput uploadfileinputtxt" />
                                                    <br />

                                                    <asp:RequiredFieldValidator ID="rfvFile" SetFocusOnError="true" ValidationGroup="uploadFile" runat="server"
                                                        ErrorMessage="*" ControlToValidate="FileUpload1" Display="Dynamic"
                                                        ForeColor="Red"></asp:RequiredFieldValidator>

                                                    <asp:RegularExpressionValidator SetFocusOnError="true" ValidationGroup="uploadFile" ID="ValidateFileType"
                                                        ControlToValidate="FileUpload1" runat="server" ForeColor="Red"
                                                        Display="Dynamic" />


                                                    <asp:HiddenField ID="hdnAllowedFileTypes" runat="server" Value="" />
                                                    <asp:HiddenField ID="hdnDownloadFileName" runat="server" Value="" />
                                                    <asp:HiddenField ID="hdnFileName" ClientIDMode="Static" runat="server" Value="" />

                                                    <div class="fileupload fileuploadtxt">
                                                        <span class="filename"><a onclick='removefile()'>
                                                            <label for="uploadfileinput" class="custom-file-upload"></label>
                                                            <i class="fa fa-times"></i></a></span>
                                                    </div>
                                                </div>

                                                <div>
                                                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                                                        <ProgressTemplate>
                                                            <div style="padding-top: 20px;">
                                                                <img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
                                                            </div>
                                                        </ProgressTemplate>
                                                    </asp:UpdateProgress>
                                                </div>

                                                <p runat="server" id="pMessage" visible="false" style="width: 65%; position: relative; color: red; margin: 50px auto 30px;">
                                                </p>

                                            </div>

                                        </div>

                                        <div class="convertbtn">
                                            <asp:Button class="btn btn-success btn-lg" ID="BtnSettingsTextStampView" ValidationGroup="uploadFile" runat="server" OnClick="btnNextSettings_Click" Text="Text Stamp" OnClientClick="showProgress();" />

                                        </div>

                                        <div class="convertbtn">
                                            <asp:Button class="btn btn-success btn-lg" ID="BtnSettingsImageStampView" ValidationGroup="uploadFile" runat="server" OnClick="btnNextSettings_Click" Text="Image Stamp" OnClientClick="showProgress();"/>

                                        </div>
                                        
                                        
<script type="text/javascript">
    function showProgress() {
        var isValid = Page_ClientValidate("uploadFile");
        if (isValid)
            document.getElementById("<%= UpdateProgress1.ClientID %>").style.display = "block";
        else {
            return false;
        }
    }

    function hideProgress() {
            document.getElementById("<%= UpdateProgress1.ClientID %>").style.display = "none";
    }

</script>

                                        </ContentTemplate>
                                        <Triggers>
                                           <asp:PostBackTrigger ControlID="BtnSettingsTextStampView" />
                                            <asp:PostBackTrigger ControlID="BtnSettingsImageStampView" />
                                           
                                        </Triggers>
                                    </asp:UpdatePanel>


                                    </asp:View>

                                    <asp:View runat="server" ID="SettingsTextStampView">
                                        
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>

                                        <asp:HiddenField ID="StampType" runat="server" />
                                        <asp:HiddenField runat="server" ID="FolderId" />
                                        <asp:HiddenField runat="server" ID="FilePath" />
                                        <asp:HiddenField runat="server" ID="FileLength"/>
                                        <% if (isTextStamp)
                                            { %>
                                        <div id="textstampdiv">
                                            <div class="watermark" style="margin-bottom: 0px;" id="dvAddWatermark" runat="server">
                                                <textarea id="txtWatermark" runat="server" class="form-control" aria-describedby="basic-addon2"></textarea>
                                                <br />
                                                <asp:RequiredFieldValidator ID="rfvWatermark" EnableClientScript="true" runat="server"
                                                    ControlToValidate="txtWatermark" Display="Dynamic"
                                                    ValidationGroup="settingsTextStamp"></asp:RequiredFieldValidator>


                                            </div>
                                            <div class="colorpicker" id="dvPickColor" runat="server">
                                                <div class="form-inline">
                                                    <div class="color-wrapper">
                                                        <input type="text" name="custom_color" placeholder="#99FF66" value="#99FF66" clientidmode="Static" id="pickcolor" class="call-picker" runat="server" />
                                                        <div class="color-holder call-picker"></div>
                                                        <div class="color-picker" id="color-picker" style="display: none"></div>
                                                        &nbsp;
					 <asp:DropDownList CssClass="form-control" ID="fontFamily" runat="server">
                         <asp:ListItem Selected="True" Value="Arial"> Arial </asp:ListItem>
                         <asp:ListItem Value="Times New Roman">Times New Roman</asp:ListItem>
                         <asp:ListItem Value="Courier">Courier</asp:ListItem>
                         <asp:ListItem Value="Verdana">Verdana</asp:ListItem>
                         <asp:ListItem Value="Helvetica">Helvetica</asp:ListItem>
                         <asp:ListItem Value="Georgia">Georgia</asp:ListItem>
                         <asp:ListItem Value="Comic Sans MS">Comic Sans MS</asp:ListItem>
                         <asp:ListItem Value="Trebuchet MS">Trebuchet MS</asp:ListItem>
                         <asp:ListItem Value="Calibri">Calibri</asp:ListItem>
                     </asp:DropDownList>
                                                        &nbsp;
						<asp:DropDownList CssClass="form-control" ID="fontStyle" runat="server">
                            <asp:ListItem Selected="True" Value="Regular">Regular</asp:ListItem>
                            <asp:ListItem Value="Bold">Bold</asp:ListItem>
                            <asp:ListItem Value="Italic">Italic</asp:ListItem>
                        </asp:DropDownList>
                                                        &nbsp;
                        <asp:TextBox runat="server" ID="fontSize" class="form-control" CssClass="form-control" TextMode="Number" min="8">14</asp:TextBox>
                                                    </div>
                                                    <div class="form-inline">
                                                        <div class="color-wrapper">
                                                            <p style="display:inline-block"><%=Resources["RotateAngleLabel"] %>&nbsp;(-360&deg;&nbsp;..&nbsp;360&deg;)</p>
                                                            &nbsp;
				                <asp:TextBox runat="server" ID="textAngle" CssClass="form-control" TextMode="Number" min="-360" max="360">0</asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                        <% }
                                            else
                                            { %>
                                        <div id="imagestampdiv">
                                            <div class="filedropdown">
                                                <div class="filedrop">
                                                    <label class="dz-message needsclick"><% = Resources["DropOrUploadImageFile"] %></label>
                                                    <input type="file" name="FileUploadImage" id="FileUploadImage" runat="server" class="uploadfileinput uploadfileinputimage" />
                                                    <br />

                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorImage" SetFocusOnError="true" ValidationGroup="settingsImageStamp" runat="server"
                                                        ErrorMessage="*" ControlToValidate="FileUploadImage" Display="Dynamic"
                                                        ForeColor="Red"></asp:RequiredFieldValidator>

                                                    <asp:HiddenField ID="hdnAllowedImageTypes" runat="server" Value="JPG,JPEG,PNG,BMP" />
                                                    <asp:HiddenField ID="hdnDownloadImageName" runat="server" Value="" />
                                                    <asp:HiddenField ID="hdnImageName" ClientIDMode="Static" runat="server" Value="" />

                                                    <div class="fileupload fileuploadimage">
                                                        <span class="filename"><a onclick='removefileimage()'>
                                                            <label for="uploadfileinput" class="custom-file-upload"></label>
                                                            <i class="fa fa-times"></i></a></span>
                                                    </div>
                                                </div>

                                                <p runat="server" id="p1" visible="false" style="width: 65%; position: relative; color: red; margin: 50px auto 30px;">
                                                </p>

                                            </div>

                                            <div class="colorpicker" id="Div2" runat="server">
                                                <div class="form-inline">
                                                    <div class="color-wrapper">
                                                        <asp:DropDownList runat="server" id="ImageColor" CssClass="form-control">
                                                            <asp:ListItem Selected="True" Value="GrayScaled">1</asp:ListItem>
                                                            <asp:ListItem Value="Colored">2</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>
                                                    <div class="color-wrapper">
                                                        <p style="display: inline-block;"><%=Resources["ZoomFactorLabel"] %>&nbsp; (&#37;)</p>
                                                        &nbsp;
                                                        <asp:TextBox runat="server" ID="ZoomFactor" CssClass="form-control" TextMode="Number" min="0" max="400">100</asp:TextBox>
                                                    </div>
                                                    <div class="form-inline">
                                                        <div class="color-wrapper">
                                                            <p style="display: inline-block;"><%=Resources["RotateAngleLabel"] %>&nbsp; (-360&deg;&nbsp;..&nbsp;360&deg;)</p>
                                                            &nbsp;
				                <asp:TextBox runat="server" ID="ImageAngle" CssClass="form-control" TextMode="Number" min="-360" max="360">0</asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                        <% } %>
                                        
                                        <div>
                                            <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
                                                <ProgressTemplate>
                                                    <div style="padding-top: 20px;">
                                                        <img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
                                                    </div>
                                                </ProgressTemplate>
                                            </asp:UpdateProgress>
                                        </div>

                                        

                                        <div class="saveas">
                                            <br />
                                            <em><%=Resources["SaveAs"]%></em>
                                            <div class="btn-group saveformat">
                                                <input type="hidden" id="Hidden1" ClientIDMode="Static"  runat="server" />
                                                <button type="button" class="btn btn-danger dropdown-toggle dropdown-toggle-split" clientidmode="Static" id="btnTo" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                    <asp:Literal ID="litToDropdownTitle" runat="server"></asp:Literal>
                                                </button>
                                                <div class="dropdown-menu" aria-labelledby="dropdownMenuLink">
                                                    <asp:Literal ID="litToDropdownItem" runat="server"></asp:Literal>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="convertbtn">
                                            <asp:Button class="btn btn-success btn-lg" ID="btnAddWatermark" runat="server" OnClick="btnAddWatermark_Click" OnClientClick="showProgress();" />

                                        </div>
                                        
                                        <div class="form-inline">
                                            <br/> <br/>
                                        <asp:LinkButton class="label" ID="btnBack" runat="server" OnClick="btnBack_Click" Style="font-size:20px" />
                                            </div>
    <script type="text/javascript">
        function showProgress() {
            if (Page_IsValid)
                document.getElementById("<%= UpdateProgress2.ClientID %>").style.display = "block";
        }

        function hideProgress() {
            document.getElementById("<%= UpdateProgress2.ClientID %>").style.display = "none";
        }

    </script>

                                        </ContentTemplate>
                                        <Triggers>
                                            <asp:PostBackTrigger ControlID="btnAddWatermark" />
                                            <asp:PostBackTrigger ControlID="btnBack" />
                                        </Triggers>
                                    </asp:UpdatePanel>

                                    </asp:View>


                                    <asp:View runat="server" ID="sendMailView">
                                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        
                                        <div class="filesendemail">
                                            <div class="filesuccess">
                                                <label class="dz-message needsclick" id="lblWatermarkSuccessMessage" runat="server"></label>
                                                <span class="downloadbtn convertbtn">
                                                    <asp:Literal ID="litDownloadNow" runat="server"></asp:Literal></span>

                                                <div class="clearfix">&nbsp;</div>


                                                <asp:LinkButton OnClick="aPerformAnotherOperation_OnClick" runat="server" ID="aPerformAnotherOperation" class="btn btn-link refresh-c"><i class="fa-refresh fa "></i></asp:LinkButton>
                                            </div>
                                            

                                           
                                            
                                           

                                            <div>

                                                <asp:UpdateProgress ID="UpdateProgress3" runat="server" AssociatedUpdatePanelID="UpdatePanel3">
                                                    <ProgressTemplate>
                                                        <div style="padding-top: 20px;">
                                                            <img height="59px" width="59px" alt="Please wait..." src="../../img/loader.gif" />
                                                        </div>
                                                    </ProgressTemplate>
                                                </asp:UpdateProgress>
                                            </div>
                                        </div>
    <script type="text/javascript">
        function showProgress() {
            if (Page_IsValid)
                document.getElementById("<%= UpdateProgress3.ClientID %>").style.display = "block";
        }

        function hideProgress() {
            document.getElementById("<%= UpdateProgress3.ClientID %>").style.display = "none";
        }

    </script>
                                   
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:PostBackTrigger ControlID="aPerformAnotherOperation" />

                                    </Triggers>
                                    </asp:UpdatePanel>
                                        </asp:View>

                                </asp:MultiView>

                            </div>
                        </div>
                    </div>
                </div>
            </div>


    <div class="col-md-12 pt-5 app-product-section  tl" id="dvAppProductSection" runat="server">
        <div class="container">
            <div class="col-md-3 pull-right">
                <img runat="server" id="imgProductImage" />
            </div>

            <div class="col-md-9 pull-left">
                <h3 runat="server" id="hAsposeProductTitle"></h3>
                <ul>
                    <li runat="server" id="liProductFeature3"></li>
                    <li><%= " " + Resources["SaveAs"] + ": " + ViewState["ValidSaveAsOptions"].ToString().Replace(",", ", ")%></li>
                </ul>
            </div>

        </div>
    </div>
	<!-- Extension Description Box -->
        <div class="col-md-12 pull-left d-flex d-wrap bg-gray appfeaturesectionlist" id="dvExtensionDescription" visible="false" runat="server">
        
       <div class="col-md-6 cardbox tc col-md-offset-3 b6"><h3 id="hExtension1"><em class="icofile" ><b><% = ViewState["Extension1"] %></b></em><span ><% = ViewState["Extension1Name"]  %></span></h3><p id="hExtension1Description" runat="server"></p></div>
        
       

        </div>

<!-- HowTo Section -->
        <div class="col-md-12 tl bg-darkgray howtolist"  id="dvHowToSection" visible="false" runat="server"><div class="container tl dflex">
        
            <div class="col-md-4 howtosectiongfx"><img src="https://products.aspose.app/img/howto.png"  ></div><div class="howtosection col-md-8"><div><h4><i class="fa fa-question-circle "></i> <b><%= string.Format(Resources["HowtoWatermarkTitle"], ViewState["Extension1"], hAsposeProductTitle.InnerText) %></b></h4><ul>
				<li><%= string.Format(Resources["HowtoWatermarkFeature1"], ViewState["Extension1"], ViewState["Extension1"]) %></li>
				<li><%= string.Format(Resources["HowtoWatermarkFeature2"], ViewState["Extension1"].ToString()) %></li>
				<li><%= string.Format(Resources["HowtoWatermarkFeature3"], ViewState["Extension1"].ToString()) %></li>
				<li><%= string.Format(Resources["HowtoWatermarkFeature4"], ViewState["Extension1"].ToString()) %></li>
				 </ul></div></div></div></div>
    <div class="col-md-12 pt-5 app-features-section">
        <div class="container tc pt-5">
            <div class="col-md-4">
                <div class="imgcircle fasteasy">
                    <img src="../../img/fast-easy.png" />
                </div>
                <h4 id="h2FastEasyHeading" runat="server"></h4>
                <p id="pFastEasyDesc" runat="server"></p>
            </div>

            <div class="col-md-4">
                <div class="imgcircle anywhere">
                    <img src="../../img/anywhere.png" />
                </div>
                <h4 id="h2WatermarkFeature2" runat="server"></h4>
                <p><%= Resources["Feature2Description"] %>.</p>
            </div>

            <div class="col-md-4">
                <div class="imgcircle quality">
                    <img src="../../img/quality.png" />
                </div>
                <h4><%= Resources["WatermarkFeature3"] %></h4>
                <p><%= Resources["PoweredBy"] %> <a runat="server" target="_blank" id="aPoweredBy"></a><%= Resources["Feature3Description"] %>.</p>
            </div>
        </div>
    </div>

    <script type="text/javascript">  

        $('.fileupload').hide();
        //   $('.filesendemail').hide();

        $('.uploadfileinputtxt').change(function () {
            var file = $('.uploadfileinputtxt')[0].files[0].name;
            var ext = file.split('.').pop();

            if (document.getElementById('<%=hdnAllowedFileTypes.ClientID %>').value.includes(ext.toUpperCase())) {

                document.getElementById('hdnFileName').value = file;
                $('.fileuploadtxt label').text(file);
                $('.fileuploadtxt').show();
                //    $('.filesendemail').hide();
                document.getElementById('hdnToValue').value = ext.toUpperCase();

            }

        });


        $('.uploadfileinputimage').change(function () {
            var file = $('.uploadfileinputimage')[0].files[0].name;
            var ext = file.split('.').pop();

            if (document.getElementById('<%=hdnAllowedImageTypes.ClientID %>').value.includes(ext.toUpperCase())) {
                document.getElementById('hdnImageName').value = file;
                $('.fileuploadimage label').text(file);
                $('.fileuploadimage').show();
            }

        });


        function AssignBtnToText(obj) {
            var t = $(obj).text();
            document.getElementById('btnTo').innerHTML = t;
            document.getElementById('hdnToValue').value = t;
        }

        function ShowfileSendEmail() {

            //   $('.filesendemail').show();
            $('.filedropdown').hide();
            $('.fileformatsico').hide();
            document.getElementById('btnTo').innerHTML = document.getElementById('hdnToValue').value;

        }
        function removefile() {

            $('.fileuploadtxt').hide();
            $('.uploadfileinputtxt').show();
        }
        function removefileimage() {

            $('.fileuploadimage').hide();
            $('.uploadfileinputimage').show();
        }

    </script>


  
     <link rel="stylesheet" href="https://products.aspose.app/css/colorpicker.css" type="text/css" />
    <script src="https://products.aspose.app/js/colorpicker.js"></script>

</asp:Content>
