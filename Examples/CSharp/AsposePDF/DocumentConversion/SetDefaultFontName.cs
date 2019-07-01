using Aspose.Pdf.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class SetDefaultFontName
    {
        /// <summary>
        /// This feature is supported by version 19.6 or greater
        /// </summary>
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            using (Document pdfDocument = new Document(dataDir + "input.pdf"))
            {
                using (FileStream imageStream = new FileStream(dataDir + "SetDefaultFontName.png", FileMode.Create))
                {
                    Resolution resolution = new Resolution(300);
                    PngDevice pngDevice = new PngDevice(resolution);
                    RenderingOptions ro = new RenderingOptions();
                    ro.DefaultFontName = "Arial";
                    pngDevice.RenderingOptions = ro;
                    pngDevice.Process(pdfDocument.Pages[1], imageStream);
                }
            }
            // ExEnd:1

        }

    }
}
