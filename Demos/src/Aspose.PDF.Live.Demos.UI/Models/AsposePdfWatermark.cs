using System;
using System.IO;
using Aspose.Pdf.Live.Demos.UI.Models;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
//using Image = Aspose.CAD.Image;
using System.Drawing.Imaging;
using System.Drawing;
using System.Diagnostics;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposePdfWatermark class to add or remove watermarks from PDF file
	///</Summary>
	public class AsposePdfWatermark : AsposePdfBase
	{
		private Response ProcessTask(string fileName, string folderName, string outFileExtension, bool createZip,  bool checkNumberofPages, ActionDelegate action)
		{
			License.SetAsposePdfLicense();
			return  Process(this.GetType().Name, fileName, folderName, outFileExtension, createZip, checkNumberofPages, (new StackTrace()).GetFrame(5).GetMethod().Name, action);
		}
         
	    private static Bitmap MakeGrayscale3(Bitmap original)
	    {
	        //create a blank bitmap the same size as original
	        Bitmap newBitmap = new Bitmap(original.Width, original.Height);

	        //get a graphics object from the new image
	        Graphics g = Graphics.FromImage(newBitmap);

	        //create the grayscale ColorMatrix
	        ColorMatrix colorMatrix = new ColorMatrix(
	            new float[][]
	            {
	                new float[] {.3f, .3f, .3f, 0, 0},
	                new float[] {.59f, .59f, .59f, 0, 0},
	                new float[] {.11f, .11f, .11f, 0, 0},
	                new float[] {0, 0, 0, 1, 0},
	                new float[] {0, 0, 0, 0, 1}
	            });

	        //create some image attributes
	        ImageAttributes attributes = new ImageAttributes();

	        //set the color matrix attribute
	        attributes.SetColorMatrix(colorMatrix);

	        //draw the original image on the new image
	        //using the grayscale color matrix
	        g.DrawImage(original, new System.Drawing.Rectangle(0, 0, original.Width, original.Height),
	            0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

	        //dispose the Graphics object
	        g.Dispose();
	        return newBitmap;
	    }
		///<Summary>
		/// AddImageStamp method to add image stamp
		///</Summary>
		
		public Response AddImageStamp(string fileName, string folderName, string watermarkImage, string imageFolderName, 
            string outputType, string watermarkImageColor="", double imageAngle = 0, double imageZoom = 100)
		{
			return  ProcessTask(fileName, folderName, "." + outputType, false,  false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				string imageSourceFolder = Config.Configuration.WorkingDirectory + imageFolderName;
				watermarkImage = imageSourceFolder + "/" + watermarkImage;

				// Open document
				Document pdfDocument = new Document(inFilePath);

			    // Create image stamp
			    ImageStamp imageStamp = null;
			    if (watermarkImageColor.ToLower().Contains("gray"))
			    {
			        System.Drawing.Bitmap bmp = MakeGrayscale3(new Bitmap(watermarkImage));
                    var memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Jpeg);
                    imageStamp = new ImageStamp(memory);
			    }
			    else
			    {
			        imageStamp = new ImageStamp(watermarkImage);
                }
                imageStamp.Background = true;
                //				imageStamp.XIndent = 100;
                //			imageStamp.YIndent = 100;
			    imageStamp.HorizontalAlignment = HorizontalAlignment.Center;
			    imageStamp.VerticalAlignment = VerticalAlignment.Center;

                //imageStamp.Height = 300;
				//imageStamp.Width = 300;
			    double _imageZoom = Convert.ToDouble(imageZoom);
			    imageStamp.Zoom = (_imageZoom/100.0f);
				//imageStamp.Rotate = Rotation.on270;
			    imageStamp.RotateAngle = imageAngle;
				imageStamp.Opacity = 0.5;


				// Add Image stamp to all pages
				foreach (Pdf.Page page in pdfDocument.Pages)
				{
					page.AddStamp(imageStamp);
				}

				// Save the document in PDF format.
				pdfDocument.Save(outPath, GetSaveFormat(outputType));
			});
		}

	    private FormattedText getFormattedText(string watermarkText)
	    {
	        FormattedText fmtText = new FormattedText();
            var lines = watermarkText.Split(new string[] { "\r\n","\r","\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                fmtText.AddNewLineText(line);
            }
            return fmtText;
	    }
		///<Summary>
		/// AddTextStamp method to add text stamp
		///</Summary>
	
		public Response AddTextStamp(string fileName, string folderName, string watermarkText,  string outputType, string watermarkColor, 
                                                                                        string fontFamily=@"Arial", float fontSize = 14.0f, string fontStyle=null, double textAngle = 45 ){
			return  ProcessTask(fileName, folderName, "." + outputType, false,  false, delegate (string inFilePath, string outPath, string zipOutFolder)
			{
				// Open document
				Document pdfDocument = new Document(inFilePath);

				// Create text stamp
				TextStamp textStamp = new TextStamp(getFormattedText(watermarkText));
				// Set whether stamp is background
				textStamp.Background = true;

			    textStamp.HorizontalAlignment = HorizontalAlignment.Center;
			    textStamp.VerticalAlignment = VerticalAlignment.Center;
			    textStamp.TextAlignment = HorizontalAlignment.Center;

                // Set origin
                //textStamp.XIndent = 100;
                //textStamp.YIndent = 100;
                // Rotate stamp
                //textStamp.Rotate = Rotation.on90;
                textStamp.RotateAngle = textAngle;
				// Set text properties
				textStamp.TextState.Font = FontRepository.FindFont(fontFamily);
				textStamp.TextState.FontSize = fontSize;
			    switch (fontStyle)
			    {
			        case "Bold":
			            {
			            textStamp.TextState.FontStyle = FontStyles.Bold;
                        }
			            break;
                    case "Italic":
                    {
                        textStamp.TextState.FontStyle = FontStyles.Italic;
                    }
                        break;
                    case "Regular":
			        case null:
			        {
			            textStamp.TextState.FontStyle = FontStyles.Regular;
			        }
			            break;


                }

				if (watermarkColor != "")
				{
					if (!watermarkColor.StartsWith("#"))
					{
						watermarkColor = "#" + watermarkColor;
					}

					textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.ColorTranslator.FromHtml(watermarkColor));
				}
				else
				{

					textStamp.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Aqua);
				}

				// Add Text stamp to all pages
				foreach (Pdf.Page page in pdfDocument.Pages)
				{
					page.AddStamp(textStamp);
				}

				// Save the document in PDF format.
				pdfDocument.Save(outPath, GetSaveFormat(outputType));
			});
		}
		private static SaveFormat GetSaveFormat(string outputType)
		{
			switch (outputType)
			{
				case "pdf":
					return SaveFormat.Pdf;
				case "doc":
					return SaveFormat.Doc;
				case "docx":
					return SaveFormat.DocX;
				case "pptx":
					return SaveFormat.Pptx;
				case "tex":
					return SaveFormat.TeX;
				case "xls":
					return SaveFormat.Excel;
				case "xlsx":
					return SaveFormat.Excel;
				case "epub":
					return SaveFormat.Epub;
			}
			return SaveFormat.Pdf;
		}

	}
}
