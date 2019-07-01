namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Working_With_XML_XSLT
{
    public class HelloWorldPDFUsingXmlAndXslt
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            //Create pdf document
            Aspose.Pdf.Document pdf = new Aspose.Pdf.Document();
            //Bind XML and XSLT files to the document
            pdf.BindXml(dataDir + "\\HelloWorld.xml", dataDir + "\\HelloWorld.xslt");
            //Save the document
            pdf.Save(dataDir + "HelloWorldPDFUsingXmlAndXslt.pdf");
            // ExEnd:1
        }
    }
}
