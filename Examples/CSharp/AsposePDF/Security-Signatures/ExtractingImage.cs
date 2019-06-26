using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Forms;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures
{
    public class ExtractingImage
    {
        public static void Run()
        {
            // ExStart:ExtractingImage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_SecuritySignatures();

            string input = dataDir+ @"ExtractingImage.pdf";
            using (Document pdfDocument = new Document(input))
            {
                foreach (Field field in pdfDocument.Form)
                {
                    SignatureField sf = field as SignatureField;
                    if (sf != null)
                    {
                        string outFile = dataDir+ @"output_out.jpg";
                        using (Stream imageStream = sf.ExtractImage())
                        {
                            if (imageStream != null)
                            {
                                using (System.Drawing.Image image = Bitmap.FromStream(imageStream))
                                {
                                    image.Save(outFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                                }
                            }
                        }
                    }
                }
            }
            // ExEnd:ExtractingImage
            
        }
    }
}