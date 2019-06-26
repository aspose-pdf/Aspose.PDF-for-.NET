using System.Collections.Generic;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class AddLayers
    {
        public static void Run()
        {
            // ExStart:AddLayers
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            Document doc = new Document();
            Page page = doc.Pages.Add();
            Layer layer = new Layer("oc1", "Red Line");
            layer.Contents.Add(new Aspose.Pdf.Operators.SetRGBColorStroke(1, 0, 0));
            layer.Contents.Add(new Aspose.Pdf.Operators.MoveTo(500, 700));
            layer.Contents.Add(new Aspose.Pdf.Operators.LineTo(400, 700));
            layer.Contents.Add(new Aspose.Pdf.Operators.Stroke());
            page.Layers = new  List<Layer>();
            page.Layers.Add(layer);
            layer = new Layer("oc2", "Green Line");
            layer.Contents.Add(new Aspose.Pdf.Operators.SetRGBColorStroke(0, 1, 0));
            layer.Contents.Add(new Aspose.Pdf.Operators.MoveTo(500, 750));
            layer.Contents.Add(new Aspose.Pdf.Operators.LineTo(400, 750));
            layer.Contents.Add(new Aspose.Pdf.Operators.Stroke());
            page.Layers.Add(layer);
            layer = new Layer("oc3", "Blue Line");
            layer.Contents.Add(new Aspose.Pdf.Operators.SetRGBColorStroke(0, 0, 1));
            layer.Contents.Add(new Aspose.Pdf.Operators.MoveTo(500, 800));
            layer.Contents.Add(new Aspose.Pdf.Operators.LineTo(400, 800));
            layer.Contents.Add(new Aspose.Pdf.Operators.Stroke());
            page.Layers.Add(layer);
            dataDir = dataDir + "AddLayers_out.pdf";
            doc.Save(dataDir);
            // ExEnd:AddLayers
            Console.WriteLine("\nLayers added successfully to PDF file.\nFile saved at " + dataDir);
        }
    }
}