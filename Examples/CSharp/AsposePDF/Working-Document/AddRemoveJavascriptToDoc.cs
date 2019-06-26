using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;
using System.Collections;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class AddRemoveJavascriptToDoc
    {
        public static void Run()
        {
            // ExStart:AddRemoveJavascriptToDoc
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Document doc = new Document();
            doc.Pages.Add();
            doc.JavaScript["func1"] = "function func1() { hello(); }";
            doc.JavaScript["func2"] = "function func2() { hello(); }";
            doc.Save(dataDir + "AddJavascript.pdf");

            // Remove Document level JavaScript
            Document doc1 = new Document(dataDir + "AddJavascript.pdf");
            IList keys = (System.Collections.IList)doc1.JavaScript.Keys;
            Console.WriteLine("=============================== ");
            foreach (string key in keys)
            {
                Console.WriteLine(key + " ==> " + doc1.JavaScript[key]);
            }

            doc1.JavaScript.Remove("func1");
            Console.WriteLine("Key 'func1' removed ");
            Console.WriteLine("=============================== ");
            // ExEnd:AddRemoveJavascriptToDoc
            Console.WriteLine("\nJavascript added/removed successfully to a document.");
        }
    }
}