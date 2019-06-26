using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class ChangeOrientation
    {
        public static void Run()
        {
            // ExStart:ChangeOrientation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            Document doc = new Document(dataDir + "input.pdf");
            foreach (Page page in doc.Pages)
            {
                
                Aspose.Pdf.Rectangle r = page.MediaBox;
                double newHeight = r.Width;
                double newWidth = r.Height;
                double newLLX = r.LLX;
                //  We must to move page upper in order to compensate changing page size
                // (lower edge of the page is 0,0 and information is usually placed from the
                //  Top of the page. That's why we move lover edge upper on difference between
                //  Old and new height.
                double newLLY = r.LLY + (r.Height - newHeight);
                page.MediaBox = new Aspose.Pdf.Rectangle(newLLX, newLLY, newLLX + newWidth, newLLY + newHeight);
                // Sometimes we also need to set CropBox (if it was set in original file)
                page.CropBox = new Aspose.Pdf.Rectangle(newLLX, newLLY, newLLX + newWidth, newLLY + newHeight);

                // Setting Rotation angle of page
                page.Rotate = Rotation.on90;
            }

            dataDir = dataDir + "ChangeOrientation_out.pdf";
            // Save output file
            doc.Save(dataDir);
            // ExEnd:ChangeOrientation
            System.Console.WriteLine("\nPage orientation changed successfully.\nFile saved at " + dataDir);
        }
        static private bool HasOnlyWhiteColor(Page
page)
        {

            foreach (Operator op
            in page.Contents)

                if (op is Aspose.Pdf.Operators.SetColorOperator)
                {

                    Aspose.Pdf.Operators.SetColorOperator
                    opSC = op as Aspose.Pdf.Operators.SetColorOperator;

                    System.Drawing.Color color = opSC.getColor();

                    if (color.R != 255 || color.G != 255 || color.B !=
                    255)

                        return false;

                }


            return true;

        }
        static private bool IsBlankPage(Page page)
        {
            if (page.Contents.Count == 0 && page.Annotations.Count == 0)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
    }
}