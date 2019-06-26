using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Pages
{
    public class ImageAsBackground
    {
        public static void Run()
        {
            // ExStart:ImageAsBackground
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Pages();

            // Create a new Document object
            Document doc = new Document();

            // Add a new page to document object
            Page page = doc.Pages.Add();

            // Create Background Artifact object
            BackgroundArtifact background = new BackgroundArtifact();

            // Specify the image for backgroundartifact object
            background.BackgroundImage = File.OpenRead(dataDir + "aspose-total-for-net.jpg");

            // Add backgroundartifact to artifacts collection of page
            page.Artifacts.Add(background);

            dataDir = dataDir + "ImageAsBackground_out.pdf";
            // Save the document
            doc.Save(dataDir);
            // ExEnd:ImageAsBackground
            System.Console.WriteLine("\nImage as page background added successfully.\nFile saved at " + dataDir);
        }
    }
}