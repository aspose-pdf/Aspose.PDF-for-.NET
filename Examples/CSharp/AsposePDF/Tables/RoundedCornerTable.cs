using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class RoundedCornerTable
    {
        public static void Run()
        {
            // ExStart:RoundedCornerTable
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();
            Aspose.Pdf.Table tab1 = new Aspose.Pdf.Table();

            GraphInfo graph = new GraphInfo();
            graph.Color = Aspose.Pdf.Color.Red;
            // Create a blank BorderInfo object
            BorderInfo bInfo = new BorderInfo(BorderSide.All, graph);
            // Set the border a rounder border where radius of round is 15
            bInfo.RoundedBorderRadius = 15;
            // Set the table Corner style as Round.
            tab1.CornerStyle = Aspose.Pdf.BorderCornerStyle.Round;
            // Set the table border information
            tab1.Border = bInfo;
            // ExEnd:RoundedCornerTable
                     
        }
    }
}