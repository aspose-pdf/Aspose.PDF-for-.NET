using System.IO;
using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class ExtractBorder
    {
        public static void Run()
        {
            // ExStart:ExtractBorder
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            Document doc = new Document(dataDir + "input.pdf");
            
            Stack graphicsState = new Stack();
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap((int)doc.Pages[1].PageInfo.Width, (int)doc.Pages[1].PageInfo.Height);
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            // Default ctm matrix value is 1,0,0,1,0,0
            System.Drawing.Drawing2D.Matrix lastCTM = new System.Drawing.Drawing2D.Matrix(1, 0, 0, -1, 0, 0);
            // System.Drawing coordinate system is top left based, while pdf coordinate system is low left based, so we have to apply the inversion matrix
            System.Drawing.Drawing2D.Matrix inversionMatrix = new System.Drawing.Drawing2D.Matrix(1, 0, 0, -1, 0, (float)doc.Pages[1].PageInfo.Height);
            System.Drawing.PointF lastPoint = new System.Drawing.PointF(0, 0);
            System.Drawing.Color fillColor = System.Drawing.Color.FromArgb(0, 0, 0);
            System.Drawing.Color strokeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            using (System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bitmap))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                graphicsState.Push(new System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, 0, 0));

                // Process all the contents commands
                foreach (Operator op in doc.Pages[1].Contents)
                {
                    Aspose.Pdf.Operators.GSave opSaveState = op as Aspose.Pdf.Operators.GSave;
                    Aspose.Pdf.Operators.GRestore opRestoreState = op as Aspose.Pdf.Operators.GRestore;
                    Aspose.Pdf.Operators.ConcatenateMatrix opCtm = op as Aspose.Pdf.Operators.ConcatenateMatrix;
                    Aspose.Pdf.Operators.MoveTo opMoveTo = op as Aspose.Pdf.Operators.MoveTo;
                    Aspose.Pdf.Operators.LineTo opLineTo = op as Aspose.Pdf.Operators.LineTo;
                    Aspose.Pdf.Operators.Re opRe = op as Aspose.Pdf.Operators.Re;
                    Aspose.Pdf.Operators.EndPath opEndPath = op as Aspose.Pdf.Operators.EndPath;
                    Aspose.Pdf.Operators.Stroke opStroke = op as Aspose.Pdf.Operators.Stroke;
                    Aspose.Pdf.Operators.Fill opFill = op as Aspose.Pdf.Operators.Fill;
                    Aspose.Pdf.Operators.EOFill opEOFill = op as Aspose.Pdf.Operators.EOFill;
                    Aspose.Pdf.Operators.SetRGBColor opRGBFillColor = op as Aspose.Pdf.Operators.SetRGBColor;
                    Aspose.Pdf.Operators.SetRGBColorStroke opRGBStrokeColor = op as Aspose.Pdf.Operators.SetRGBColorStroke;

                    if (opSaveState != null)
                    {
                        // Save previous state and push current state to the top of the stack
                        graphicsState.Push(((System.Drawing.Drawing2D.Matrix)graphicsState.Peek()).Clone());
                        lastCTM = (System.Drawing.Drawing2D.Matrix)graphicsState.Peek();
                    }
                    else if (opRestoreState != null)
                    {
                        // Throw away current state and restore previous one
                        graphicsState.Pop();
                        lastCTM = (System.Drawing.Drawing2D.Matrix)graphicsState.Peek();
                    }
                    else if (opCtm != null)
                    {
                        System.Drawing.Drawing2D.Matrix cm = new System.Drawing.Drawing2D.Matrix(
                            (float)opCtm.Matrix.A,
                            (float)opCtm.Matrix.B,
                            (float)opCtm.Matrix.C,
                            (float)opCtm.Matrix.D,
                            (float)opCtm.Matrix.E,
                            (float)opCtm.Matrix.F);

                        // Multiply current matrix with the state matrix
                        ((System.Drawing.Drawing2D.Matrix)graphicsState.Peek()).Multiply(cm);
                        lastCTM = (System.Drawing.Drawing2D.Matrix)graphicsState.Peek();
                    }
                    else if (opMoveTo != null)
                    {
                        lastPoint = new System.Drawing.PointF((float)opMoveTo.X, (float)opMoveTo.Y);
                    }
                    else if (opLineTo != null)
                    {
                        System.Drawing.PointF linePoint = new System.Drawing.PointF((float)opLineTo.X, (float)opLineTo.Y);
                        graphicsPath.AddLine(lastPoint, linePoint);

                        lastPoint = linePoint;
                    }
                    else if (opRe != null)
                    {
                        System.Drawing.RectangleF re = new System.Drawing.RectangleF((float)opRe.X, (float)opRe.Y, (float)opRe.Width, (float)opRe.Height);
                        graphicsPath.AddRectangle(re);
                    }
                    else if (opEndPath != null)
                    {
                        graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
                    }
                    else if (opRGBFillColor != null)
                    {
                        fillColor = opRGBFillColor.getColor();
                    }
                    else if (opRGBStrokeColor != null)
                    {
                        strokeColor = opRGBStrokeColor.getColor();
                    }
                    else if (opStroke != null)
                    {
                        graphicsPath.Transform(lastCTM);
                        graphicsPath.Transform(inversionMatrix);
                        gr.DrawPath(new System.Drawing.Pen(strokeColor), graphicsPath);
                        graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
                    }
                    else if (opFill != null)
                    {
                        graphicsPath.FillMode = FillMode.Winding;
                        graphicsPath.Transform(lastCTM);
                        graphicsPath.Transform(inversionMatrix);
                        gr.FillPath(new System.Drawing.SolidBrush(fillColor), graphicsPath);
                        graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
                    }
                    else if (opEOFill != null)
                    {
                        graphicsPath.FillMode = FillMode.Alternate;
                        graphicsPath.Transform(lastCTM);
                        graphicsPath.Transform(inversionMatrix);
                        gr.FillPath(new System.Drawing.SolidBrush(fillColor), graphicsPath);
                        graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
                    }
                }
            }
            dataDir = dataDir + "ExtractBorder_out.png";
            bitmap.Save(dataDir, ImageFormat.Png);
            // ExEnd:ExtractBorder
            Console.WriteLine("\nBorder extracted successfully as image.\nFile saved at " + dataDir);
            
        }
    }
}