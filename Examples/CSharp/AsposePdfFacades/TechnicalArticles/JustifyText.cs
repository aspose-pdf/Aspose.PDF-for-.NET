using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class JustifyText
    {
        public static void Run()
        {
            // ExStart:JustifyText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            using (FileStream source = File.Open(dataDir + "Input1.pdf", FileMode.Open))
            {
                MemoryStream ms = new MemoryStream();

                // Create Form Object
                Aspose.Pdf.Facades.Form form = new Aspose.Pdf.Facades.Form();

                // Open Source File
                form.BindPdf(source);

                // Fill Text Field
                form.FillField("Text1", "Thank you for using Aspose");

                // Save the document in Memory Stream
                form.Save(ms);

                ms.Seek(0, SeekOrigin.Begin);

                FileStream dest = new FileStream(dataDir + "JustifyText_out.pdf", FileMode.Create);

                // Create formEditor Object
                FormEditor formEditor = new FormEditor();

                // Open PDF from memory stream
                formEditor.BindPdf(ms);

                // Set Text Alignment as Justified
                formEditor.Facade.Alignment = FormFieldFacade.AlignJustified;

                // Decorate form field.
                formEditor.DecorateField();

                // Save te resultant file.
                formEditor.Save(dest);

                // Close file stream
                dest.Close();
            }
            // ExEnd:JustifyText                      
        }
    }
}