using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class GetSVGDimensions
    {
        public static void Run()
        {
            // ExStart:GetSVGDimensions
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
            
            var loadopt = new SvgLoadOptions();
            loadopt.AdjustPageSize = true;
            var svgDoc = new Document(dataDir + "GetSVGDimensions.svg", loadopt);
            svgDoc.Pages[1].PageInfo.Margin.Top = 0;
            svgDoc.Pages[1].PageInfo.Margin.Left = 0;
            svgDoc.Pages[1].PageInfo.Margin.Bottom = 0;
            svgDoc.Pages[1].PageInfo.Margin.Right = 0;
            svgDoc.Save(dataDir + "GetSVGDimensions_out.pdf");
            // ExEnd:GetSVGDimensions
        }
    }
}