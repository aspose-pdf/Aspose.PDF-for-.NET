using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat
{
    public class SetOutputFileDimensions
    {
        public static void Run()
        {
            try
            {
                // ExStart:SetOutputFileDimensions
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat();

                // Select desirable page size
                float newPageWidth = 400f;
                float newPageHeight = 400f;

                // Tune PdfPageEditor class 
                Aspose.Pdf.Facades.PdfPageEditor pdfEditor = new Aspose.Pdf.Facades.PdfPageEditor();
                // Bind source PDF file
                pdfEditor.BindPdf(dataDir + "input.pdf");
                // Set the page dimensions 
                pdfEditor.PageSize = new Aspose.Pdf.PageSize(newPageWidth, newPageHeight);
                // Set vertical alignment for page as center aligned
                pdfEditor.VerticalAlignmentType = Aspose.Pdf.VerticalAlignment.Center;
                // Set Horizontal alignment for page as center aligned
                pdfEditor.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;

                // This scales page content to fit width,
                // Comment it out or set Zoom to 1.0F if You don't want to scale
                // Content and only want to change page's size (i.e. crop it)
                float zoom = Math.Min((float)newPageWidth / (float)pdfEditor.Document.Pages[1].Rect.Width,
                                    (float)newPageHeight / (float)pdfEditor.Document.Pages[1].Rect.Height);
                pdfEditor.Zoom = zoom;// (float)595;

                // Create stream object to hold file with updated dimensions
                MemoryStream output = new MemoryStream();
                // Save file to stream object
                pdfEditor.Save(output);

                // Then reload scaled document and save it to HTML
                Document exportDoc = new Document(output);
                HtmlSaveOptions htmlOptions = new HtmlSaveOptions();
                // This code shows page boreder in result - sometimes it comes in handy to see borders
                SaveOptions.BorderPartStyle borderStyle = new SaveOptions.BorderPartStyle();
                borderStyle.LineType = SaveOptions.HtmlBorderLineType.Dotted;
                borderStyle.Color = System.Drawing.Color.Gray;
                htmlOptions.PageBorderIfAny = new SaveOptions.BorderInfo(borderStyle);

                // Conversion to HTML itself
                exportDoc.Save(dataDir + "SetOutputFileDimensions_out.html", htmlOptions);
                // Close the stream object
                output.Close();
                // ExEnd:SetOutputFileDimensions
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}