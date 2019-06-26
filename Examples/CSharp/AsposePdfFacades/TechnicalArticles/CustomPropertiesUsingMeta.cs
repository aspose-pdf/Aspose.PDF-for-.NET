using System.IO;
using System;
using System.Collections;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class CustomPropertiesUsingMeta
    {
        public static void Run()
        {
            // ExStart:CustomPropertiesUsingMeta
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create instance of PdfFileInfo object
            Aspose.Pdf.Facades.PdfFileInfo fInfo = new Aspose.Pdf.Facades.PdfFileInfo(dataDir + "inFile1.pdf");

            // Retrieve all existing custom attributes
            System.Collections.Hashtable hTable =  new Hashtable(fInfo.Header);

            IDictionaryEnumerator enumerator = hTable.GetEnumerator();
            while (enumerator.MoveNext())
            {
            string output = enumerator.Key.ToString() + " " + enumerator.Value;
            }

            // Set new customer attribute as meta info
            fInfo.SetMetaInfo("CustomAttribute", "test value");

            // Get custom attribute from meta info by specifying attribute/property name
            string value = fInfo.GetMetaInfo("CustomAttribute");
            // ExEnd:CustomPropertiesUsingMeta                      
        }
    }
}