using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Globalization;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Config;
using Aspose.Pdf.Live.Demos.UI.Helpers;
using System.Net;
using System.Web.UI.WebControls;

namespace Aspose.Pdf.Live.Demos.UI
{
	public partial class AddWatermarkPdf : BasePage
	{

	    public bool isTextStamp;

		public void SetButtonText(string[] longNames)
		{
			litToDropdownTitle.Text = "";
			litToDropdownItem.Text = "";

			if (longNames.Length > 0)
			{
				litToDropdownTitle.Text = longNames[0];
				hdnToValue.Value = longNames[0].ToLower();
			}

			for (int i = 0; i < longNames.Length; i++)
			{
				litToDropdownItem.Text += "<a onclick=\"AssignBtnToText(this)\" class=\"dropdown-item\">" + longNames[i] + "</a>";
			}
		}
		
		protected void Page_Load(object sender, EventArgs e)
		{			
			rfvWatermark.ErrorMessage = Resources["WatermarkTextMessage"];
			
			if (!IsPostBack)
			{

				
               
                    hdnWatermarkType.Value = Resources["AddTextStampURL"];
               
			
			    hdnAsposeProductName.Value = "pdf";

				

				lblWatermarkSuccessMessage.InnerText = Resources["WatermarkAddedSuccessMessage"];
				aPerformAnotherOperation.Text = string.Format(Resources["AddWatermkinAnotherFile"], Resources["WatermarkAddText"]);
			    btnBack.Text = Resources["BackButton"];

			    BtnSettingsTextStampView.Text = Resources["TextStampButton"];
			    BtnSettingsImageStampView.Text = Resources["ImageStampButton"];

                btnAddWatermark.Text = string.Format(Resources["btnAddWatermark"], Resources["WatermarkAddText"]);
				h2WatermarkFeature2.InnerText = string.Format(Resources["WatermarkFeature2"], Resources["WatermarkAddText"]);

				// Set page settings based on from and top selection
				PageSettings();
				liProductFeature3.InnerText = string.Format(Resources["SupportedDocuments"], hdnAllowedFileTypes.Value.ToUpper());
				txtWatermark.Attributes.Add("placeholder", Resources["AddWatermarkTextPlaceholder"]);
				//pickcolor.Attributes.Add("placeholder", Resources["WatermarkPickColor"]);

			    ImageColor.Items[0].Text = Resources["GrayscaledLabel"];
			    ImageColor.Items[1].Text = Resources["ColoredLabel"];

               
				rfvFile.ErrorMessage = Resources["SelectorDropFileMessage"];

				string validToFileExtensions = Resources["pdfWatermarkSaveAsOptions"].ToUpper();
				ViewState["ValidSaveAsOptions"] = validToFileExtensions;
				string[] saveAsOptions = validToFileExtensions.Replace(" ", "").Split(',');

				SetButtonText(saveAsOptions);

				

			}

		}
		
		private void SetFileTypeAllowedExtensions()
		{
		    string product = "pdf";

			string validationExpression = Resources[product + "ValidationExpression"].Replace("|.eps", "");

			string validFileExtensions = GetValidFileExtensions(validationExpression);

			imgProductImage.Src = "~/img/aspose-" + product + "-app.png";


			ValidateFileType.ValidationExpression = @"(.*?)(" + validationExpression + "|" + validationExpression.ToUpper() + ")$";
			ValidateFileType.ErrorMessage = Resources["InvalidFileExtension"] + " " + validFileExtensions;			
			aPoweredBy.InnerText = Resources["Aspose" + TitleCase(product)];
			aPoweredBy.HRef = "https://products.aspose.com/" + product.ToLower();
			hdnAllowedFileTypes.Value = validFileExtensions;
		}		
		
		private void PageSettings()
		{
			SiteMaster mySiteMaster = Master as SiteMaster;
			string productName = hdnAsposeProductName.Value;
			SetFileTypeAllowedExtensions();

			hAsposeProductTitle.InnerText = Resources["Aspose" + TitleCase(productName)];
			hAsposeProductTitle.InnerText = hAsposeProductTitle.InnerText + " " + Resources["Watermarkh4"];
			pFastEasyDesc.InnerText = Resources["AddWatermarkFeature1Description"];

			
			if ((hdnWatermarkType.Value == Resources["AddTextStampURL"]) && (productName == "pdf"))
			{
				hPageTitle.InnerHtml = Resources["AddTextStamptoPDFSubPageTitle2"];

				h2FastEasyHeading.InnerText = string.Format(Resources["WatermarkFeature1"], Resources["AddTextStamptoPDFPageTitle2"]);

				hFeatureTitle.InnerText = Resources["AddTextStamptoPDFPageTitle2"];

			}			
			else
			{
				Response.Redirect("~/errorpage");
			}

			Page.Title = "Add stamp in PDF document";
			Page.MetaDescription = "We guide you how to add watermark to PDF document in few steps: choose a PDF document, choose a watermark image, push &quot;Add Image Stamp&quot; button.";
		}
		
		protected void btnAddWatermark_Click(object sender, EventArgs e)
		{
            if (StampType.Value.Contains("text"))
                Page.Validate("settingsTextStamp");
            else
                Page.Validate("settingsImageStamp");

            if (Page.IsValid)
			{				
				pMessage.Attributes.Remove("class");
				pMessage.InnerHtml = "";

				

				// Check if File is available.
				if ( !string.IsNullOrEmpty(FilePath.Value) && Convert.ToDouble(FileLength.Value) > 0)
				{
					hdnDownloadFileName.Value = hdnDownloadFileURL.Value = "";
					string fn = FilePath.Value;					
					try
					{
						 

					    var imageFile = "";
					    var imageFolderName = "";

					    if (StampType.Value.Contains("image"))
					    {

					        if (FileUploadImage.PostedFile != null && FileUploadImage.PostedFile.ContentLength > 0)
					        {
					            
					            try
					            {
									var files = UploadFiles(FileUploadImage);
									if (files != null && files.Count == 1)
									{
										
											imageFile = files[0].FileName; 
											imageFolderName = files[0].FolderId;

									}
					            }
					            catch (Exception ex)
					            {
					                pMessage.Visible = true;
					                pMessage.InnerHtml = "Error: " + ex.Message;
					                pMessage.Attributes.Add("class", "alert alert-danger");
					            }
					        }


                        }




                        {
							
							Response response = null;
							AsposePdfWatermark _asposePdfWatermark = new AsposePdfWatermark();

                            if (StampType.Value.Contains("text"))
                            {
								response = _asposePdfWatermark.AddTextStamp(FilePath.Value, FolderId.Value, txtWatermark.Value,
									hdnToValue.Value.ToLower(), pickcolor.Value.Replace("#", ""), fontFamily.SelectedValue, float.Parse( fontSize.Text), fontStyle.SelectedValue, double.Parse( textAngle.Text));

								
                            }
                            else
                            {
								response = _asposePdfWatermark.AddImageStamp(FilePath.Value, FolderId.Value, imageFile,
									imageFolderName, hdnToValue.Value.ToLower(), ImageColor.SelectedValue, double.Parse(ImageAngle.Text), double.Parse(ZoomFactor.Text));
								
                            }                
							

							if (response.StatusCode == 200)
							{
								//string url = HttpUtility.UrlEncode("FileName=" + response.FileName + "&Time=" + DateTime.Now.ToString());
								string url = Configuration.FileDownloadLink + "?fileName=" + HttpUtility.UrlEncode(response.FileName) ;
								if (response.FolderName != "")
								{
									url += "&folderName=" + response.FolderName;
								}
								litDownloadNow.Text = "<a target=\"_blank\" href=\"" + url + "\" class=\"btn btn-success btn-lg\">" + Resources["DownLoadNow"] + " <i class=\"fa fa-download\"></i></a>";
								hdnDownloadFileName.Value = response.FileName;
								hdnDownloadFileURL.Value = url;
							    PageViewId.ActiveViewIndex = 2;
                                //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "ShowfileSendEmail()", true);

							}
							else
							{
								pMessage.Visible = true;
								pMessage.InnerHtml = response.Status;
								pMessage.Attributes.Add("class", "alert alert-danger");
							}
						}
					}
					catch (Exception ex)
					{
						pMessage.Visible = true;
						pMessage.InnerHtml = "Error: " + ex.Message;
						pMessage.Attributes.Add("class", "alert alert-danger");
					}
				}
				else
				{
					pMessage.Visible = true;
					pMessage.InnerHtml = Resources["FileSelectMessage"];
					pMessage.Attributes.Add("class", "alert alert-danger");
				}
			}
		}

	    private HttpPostedFile postedFile = null;

	    protected void btnNextSettings_Click(object sender, EventArgs e)
	    {
	        var sender1 = (sender as Button).ID;

	        if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.ContentLength > 0)
	        {
	            hdnDownloadFileName.Value = hdnDownloadFileURL.Value = "";
	           
	            try
	            {
					var files = UploadFiles(FileUpload1);
					if (files != null && files.Count == 1)
					{
					
	                    FilePath.Value = files[0].FileName;
	                    FolderId.Value = files[0].FolderId;
	                    FileLength.Value = files[0].FileLength.ToString();
	                }
	            }
	            catch (Exception ex)
	            {
	                pMessage.Visible = true;
	                pMessage.InnerHtml = "Error: " + ex.Message;
	                pMessage.Attributes.Add("class", "alert alert-danger");
	            }
	        }
	        else
	        {
	            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "hideProgress()", true);
                return;
	        }


            if (sender1.Contains("Text"))
	        {
	            isTextStamp = true;
	            StampType.Value = "text";
                PageViewId.ActiveViewIndex = 1;
	            postedFile = FileUpload1.PostedFile;
	        }
            else if (sender1.Contains("Image"))
	        {
	            isTextStamp = false;
	            PageViewId.ActiveViewIndex = 1;
	            StampType.Value = "image";
	            postedFile = FileUpload1.PostedFile;
            }
            else
	        {
	            PageViewId.ActiveViewIndex = 0;
            }

	    }

	    protected void btnBack_Click(object sender, EventArgs e)
	    {
	        PageViewId.ActiveViewIndex = 0;
        }

	    protected void PageViewId_OnActiveViewChanged(object sender, EventArgs e)
	    {
        }

	    protected void aPerformAnotherOperation_OnClick(object sender, EventArgs e)
	    {
	        PageViewId.ActiveViewIndex = 0;
        }
	}
}
