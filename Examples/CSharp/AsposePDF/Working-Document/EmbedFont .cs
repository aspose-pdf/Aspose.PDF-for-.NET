using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class EmbedFont 
    {
        public static void Run()
        {
            // ExStart:EmbedFont 
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Load an existing PDF files
            Document doc = new Document(dataDir + "input.pdf");

            // Iterate through all the pages
            foreach (Page page in doc.Pages)
            {
                if (page.Resources.Fonts != null)
                {
                    foreach (Aspose.Pdf.Text.Font pageFont in page.Resources.Fonts)
                    {
                        // Check if font is already embedded
                        if (!pageFont.IsEmbedded)
                            pageFont.IsEmbedded = true;
                    }
                }

                // Check for the Form objects
                foreach (XForm form in page.Resources.Forms)
                {
                    if (form.Resources.Fonts != null)
                    {
                        foreach (Aspose.Pdf.Text.Font formFont in form.Resources.Fonts)
                        {
                            // Check if the font is embedded
                            if (!formFont.IsEmbedded)
                                formFont.IsEmbedded = true;
                        }
                    }
                }
            }
            dataDir = dataDir + "EmbedFont_out.pdf";
            // Save PDF Document
            doc.Save(dataDir);
            // ExEnd:EmbedFont 
            Console.WriteLine("\nFont embedded successfully in a PDF file.\nFile saved at " + dataDir);
        }
    }
}