using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class AddJavaScriptToPage
    {
        public static void Run()
        {
            // ExStart:AddJavaScriptToPage
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Load an existing PDF files
            Document doc = new Document(dataDir + "input.pdf");

            // Adding JavaScript at Document Level
            // Instantiate JavascriptAction with desried JavaScript statement
            JavascriptAction javaScript = new JavascriptAction("this.print({bUI:true,bSilent:false,bShrinkToFit:true});");

            // Assign JavascriptAction object to desired action of Document
            doc.OpenAction = javaScript;

            // Adding JavaScript at Page Level
            doc.Pages[2].Actions.OnOpen = new JavascriptAction("app.alert('page 1 opened')");
            doc.Pages[2].Actions.OnClose = new JavascriptAction("app.alert('page 1 closed')");

            dataDir = dataDir + "JavaScript-Added_out.pdf";
            // Save PDF Document
            doc.Save(dataDir);
            // ExEnd:AddJavaScriptToPage
            Console.WriteLine("\nJavascript added successfully to a page.\nFile saved at " + dataDir);
        }
    }
}