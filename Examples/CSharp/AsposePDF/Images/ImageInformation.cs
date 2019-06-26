using System.IO;
using Aspose.Pdf;
using System;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Images
{
    public class ImageInformation
    {
        public static void Run()
        {
            // ExStart:ImageInformation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Images();

            // Load the source PDF file
            Document doc = new Document(dataDir+ "ImageInformation.pdf");

            // Define the default resolution for image
            int defaultResolution = 72;
            System.Collections.Stack graphicsState = new System.Collections.Stack();
            // Define array list object which will hold image names
            System.Collections.ArrayList imageNames = new System.Collections.ArrayList(doc.Pages[1].Resources.Images.Names);
            // Insert an object to stack
            graphicsState.Push(new System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, 0, 0));

            // Get all the operators on first page of document
            foreach (Operator op in doc.Pages[1].Contents)
            {
                // Use GSave/GRestore operators to revert the transformations back to previously set
                Aspose.Pdf.Operators.GSave opSaveState = op as Aspose.Pdf.Operators.GSave;
                Aspose.Pdf.Operators.GRestore opRestoreState = op as Aspose.Pdf.Operators.GRestore;
                // Instantiate ConcatenateMatrix object as it defines current transformation matrix.
                Aspose.Pdf.Operators.ConcatenateMatrix opCtm = op as Aspose.Pdf.Operators.ConcatenateMatrix;
                // Create Do operator which draws objects from resources. It draws Form objects and Image objects
                Aspose.Pdf.Operators.Do opDo = op as Aspose.Pdf.Operators.Do;

                if (opSaveState != null)
                {
                    // Save previous state and push current state to the top of the stack
                    graphicsState.Push(((System.Drawing.Drawing2D.Matrix)graphicsState.Peek()).Clone());
                }
                else if (opRestoreState != null)
                {
                    // Throw away current state and restore previous one
                    graphicsState.Pop();
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

                    continue;
                }
                else if (opDo != null)
                {
                    // In case this is an image drawing operator
                    if (imageNames.Contains(opDo.Name))
                    {
                        System.Drawing.Drawing2D.Matrix lastCTM = (System.Drawing.Drawing2D.Matrix)graphicsState.Peek();
                        // Create XImage object to hold images of first pdf page
                        XImage image = doc.Pages[1].Resources.Images[opDo.Name];

                        // Get image dimensions
                        double scaledWidth = Math.Sqrt(Math.Pow(lastCTM.Elements[0], 2) + Math.Pow(lastCTM.Elements[1], 2));
                        double scaledHeight = Math.Sqrt(Math.Pow(lastCTM.Elements[2], 2) + Math.Pow(lastCTM.Elements[3], 2));
                        // Get Height and Width information of image
                        double originalWidth = image.Width;
                        double originalHeight = image.Height;

                        // Compute resolution based on above information
                        double resHorizontal = originalWidth * defaultResolution / scaledWidth;
                        double resVertical = originalHeight * defaultResolution / scaledHeight;

                        // Display Dimension and Resolution information of each image
                        Console.Out.WriteLine(
                                string.Format(dataDir + "image {0} ({1:.##}:{2:.##}): res {3:.##} x {4:.##}",
                                             opDo.Name, scaledWidth, scaledHeight, resHorizontal,
                                             resVertical));
                    }
                }
            }
            // ExEnd:ImageInformation
            
        }
    }
}