namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document
{
    public class HelloWorldPDFUsingXmlAndXslt
    {
        public static void Run()
        {
            // ExStart:HelloWorldPDFUsingXmlAndXslt
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            //Create pdf document
            Aspose.Pdf.Document pdf = new Aspose.Pdf.Document();
            //Bind XML and XSLT files to the document
            try
            {
                pdf.BindXml(dataDir + "\\HelloWorld.xml", dataDir + "\\HelloWorld.xslt");
            }
            catch (System.Exception)
            {

                throw;
            }
            
            //Save the document
             pdf.Save(dataDir + "HelloWorldUsingXmlAndXslt.pdf");
            // ExEnd:HelloWorldPDFUsingXmlAndXslt
         }
    }
}
