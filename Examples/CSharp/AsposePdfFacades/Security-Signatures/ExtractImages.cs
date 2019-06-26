using System.IO;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using Aspose.Pdf.Facades;
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class ExtractImages
    {
        public static void Run()
        {
            try
            {
                // ExStart:ExtractImages               
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();
                string input = dataDir + "DigitallySign.pdf";
                Document doc = new Document(input);
                using (PdfFileSignature signature = new PdfFileSignature(doc))
                {
                    if (signature.ContainsSignature())
                    {
                        foreach (string sigName in signature.GetSignNames())
                        {
                            string outFile = dataDir + "ExtractImages_out.jpg";
                            using (Stream imageStream = signature.ExtractImage(sigName))
                            {
                                if (imageStream != null)
                                {
                                    using (System.Drawing.Image image = Bitmap.FromStream(imageStream))
                                    {
                                        image.Save(outFile, ImageFormat.Jpeg);
                                    }
                                }
                            }
                        }
                    }
                }
                // ExEnd:ExtractImages
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }       
    }
}