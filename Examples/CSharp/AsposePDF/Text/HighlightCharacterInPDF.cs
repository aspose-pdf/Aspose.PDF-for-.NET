using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using System;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class HighlightCharacterInPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:HighlightCharacterInPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

                int resolution = 150;

                Aspose.Pdf.Document pdfDocument = new Aspose.Pdf.Document(dataDir + "input.pdf");

                using (MemoryStream ms = new MemoryStream())
                {
                    PdfConverter conv = new PdfConverter(pdfDocument);
                    conv.Resolution = new Resolution(resolution, resolution);
                    conv.GetNextImage(ms, System.Drawing.Imaging.ImageFormat.Png);

                    Bitmap bmp = (Bitmap)Bitmap.FromStream(ms);

                    using (System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp))
                    {
                        float scale = resolution / 72f;
                        gr.Transform = new System.Drawing.Drawing2D.Matrix(scale, 0, 0, -scale, 0, bmp.Height);

                        for (int i = 0; i < pdfDocument.Pages.Count; i++)
                        {
                            Page page = pdfDocument.Pages[1];
                            // Create TextAbsorber object to find all words
                            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(@"[\S]+");
                            textFragmentAbsorber.TextSearchOptions.IsRegularExpressionUsed = true;
                            page.Accept(textFragmentAbsorber);
                            // Get the extracted text fragments
                            TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;
                            // Loop through the fragments
                            foreach (TextFragment textFragment in textFragmentCollection)
                            {
                                if (i == 0)
                                {
                                    gr.DrawRectangle(
                                    Pens.Yellow,
                                    (float)textFragment.Position.XIndent,
                                    (float)textFragment.Position.YIndent,
                                    (float)textFragment.Rectangle.Width,
                                    (float)textFragment.Rectangle.Height);

                                    for (int segNum = 1; segNum <= textFragment.Segments.Count; segNum++)
                                    {
                                        TextSegment segment = textFragment.Segments[segNum];

                                        for (int charNum = 1; charNum <= segment.Characters.Count; charNum++)
                                        {
                                            CharInfo characterInfo = segment.Characters[charNum];

                                            Aspose.Pdf.Rectangle rect = page.GetPageRect(true);
                                            Console.WriteLine("TextFragment = " + textFragment.Text + "    Page URY = " + rect.URY +
                                                              "   TextFragment URY = " + textFragment.Rectangle.URY);

                                            gr.DrawRectangle(
                                            Pens.Black,
                                            (float)characterInfo.Rectangle.LLX,
                                            (float)characterInfo.Rectangle.LLY,
                                            (float)characterInfo.Rectangle.Width,
                                            (float)characterInfo.Rectangle.Height);
                                        }

                                        gr.DrawRectangle(
                                        Pens.Green,
                                        (float)segment.Rectangle.LLX,
                                        (float)segment.Rectangle.LLY,
                                        (float)segment.Rectangle.Width,
                                        (float)segment.Rectangle.Height);
                                    }
                                }
                            }
                        }
                    }
                    dataDir = dataDir + "HighlightCharacterInPDF_out.png";
                    bmp.Save(dataDir, System.Drawing.Imaging.ImageFormat.Png);
                }
                // ExEnd:HighlightCharacterInPDF            
                Console.WriteLine("\nCharacters highlighted successfully in pdf document.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}