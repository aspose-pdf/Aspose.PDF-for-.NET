using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Operators
{
    public class DrawXFormOnPage
    {
        public static void Run()
        {
            // ExStart:DrawXFormOnPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Operators();


            string imageFile = dataDir+ "aspose-logo.jpg";
            string inFile = dataDir + "DrawXFormOnPage.pdf";
            string outFile = dataDir + "blank-sample2_out.pdf";

            using (Document doc = new Document(inFile))
            {
                OperatorCollection pageContents = doc.Pages[1].Contents;

                // The sample demonstrates 
                // GSave/GRestore operators usage
                // ContatenateMatrix operator usage to position xForm
                // Do operator usage to draw xForm on page

                // Wrap existing contents with GSave/GRestore operators pair
                //        this is to get initial graphics state at the and of existing contents
                //        otherwise there might remain some undesirable transformations at the end of existing operators chain
                pageContents.Insert(1, new Aspose.Pdf.Operators.GSave());
                pageContents.Add(new Aspose.Pdf.Operators.GRestore());

                // Add save graphics state operator to properly clear graphics state after new commands
                pageContents.Add(new Aspose.Pdf.Operators.GSave());

                #region create xForm

                // Create xForm
                XForm form = XForm.CreateNewForm(doc.Pages[1], doc);
                doc.Pages[1].Resources.Forms.Add(form);
                form.Contents.Add(new Aspose.Pdf.Operators.GSave());
                // Define image width and heigh
                form.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(200, 0, 0, 200, 0, 0));
                // Load image into stream
                Stream imageStream = new FileStream(imageFile, FileMode.Open);
                // Add image to Images collection of the XForm Resources
                form.Resources.Images.Add(imageStream);
                XImage ximage = form.Resources.Images[form.Resources.Images.Count];
                // Using Do operator: this operator draws image
                form.Contents.Add(new Aspose.Pdf.Operators.Do(ximage.Name));
                form.Contents.Add(new Aspose.Pdf.Operators.GRestore());

                #endregion

                pageContents.Add(new Aspose.Pdf.Operators.GSave());
                // Place form to the x=100 y=500 coordinates
                pageContents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(1, 0, 0, 1, 100, 500));
                // Draw form with Do operator
                pageContents.Add(new Aspose.Pdf.Operators.Do(form.Name));
                pageContents.Add(new Aspose.Pdf.Operators.GRestore());

                pageContents.Add(new Aspose.Pdf.Operators.GSave());
                // Place form to the x=100 y=300 coordinates
                pageContents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(1, 0, 0, 1, 100, 300));
                // Draw form with Do operator
                pageContents.Add(new Aspose.Pdf.Operators.Do(form.Name));
                pageContents.Add(new Aspose.Pdf.Operators.GRestore());

                // Restore grahics state with GRestore after the GSave
                pageContents.Add(new Aspose.Pdf.Operators.GRestore());
                doc.Save(outFile);                
            }
            // ExEnd:DrawXFormOnPage
            
        }
    }
}