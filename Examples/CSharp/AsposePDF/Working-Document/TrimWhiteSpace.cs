using System.IO;
using System;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Devices;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments
{
    public class TrimWhiteSpace
    {
        public static void Run()
        {
            // ExStart:TrimWhiteSpace
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();

            // Load an existing PDF files
            Document doc = new Document(dataDir + "input.pdf");

            // Render the page to image with 72 DPI
            PngDevice device = new PngDevice(new Resolution(72));

            using (MemoryStream imageStr = new MemoryStream())
            {
                device.Process(doc.Pages[1], imageStr);
                Bitmap bmp = (Bitmap)Bitmap.FromStream(imageStr);

                System.Drawing.Imaging.BitmapData imageBitmapData = null;

                // Determine white areas
                try
                {
                    imageBitmapData = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                                            System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

                    Aspose.Pdf.Rectangle prevCropBox = doc.Pages[1].CropBox;

                    int toHeight = bmp.Height;
                    int toWidth = bmp.Width;

                    int? leftNonWhite = null;
                    int? rightNonWhite = null;
                    int? topNonWhite = null;
                    int? bottomNonWhite = null;

                    for (int y = 0; y < toHeight; y++)
                    {
                        byte[] imageRowBytes = new byte[imageBitmapData.Stride];

                        // Copy the row data to byte array
                        if (IntPtr.Size == 4)
                            System.Runtime.InteropServices.Marshal.Copy(new IntPtr(imageBitmapData.Scan0.ToInt32() + y * imageBitmapData.Stride), imageRowBytes, 0, imageBitmapData.Stride);
                        else
                            System.Runtime.InteropServices.Marshal.Copy(new IntPtr(imageBitmapData.Scan0.ToInt64() + y * imageBitmapData.Stride), imageRowBytes, 0, imageBitmapData.Stride);


                        int? leftNonWhite_row = null;
                        int? rightNonWhite_row = null;

                        for (int x = 0; x < toWidth; x++)
                        {
                            if (imageRowBytes[x * 4] != 255
                                || imageRowBytes[x * 4 + 1] != 255
                                || imageRowBytes[x * 4 + 2] != 255)
                            {
                                if (leftNonWhite_row == null)
                                    leftNonWhite_row = x;

                                rightNonWhite_row = x;
                            }
                        }

                        if (leftNonWhite_row != null || rightNonWhite_row != null)
                        {
                            if (topNonWhite == null)
                                topNonWhite = y;

                            bottomNonWhite = y;
                        }

                        if (leftNonWhite_row != null
                            && (leftNonWhite == null || leftNonWhite > leftNonWhite_row))
                        {
                            leftNonWhite = leftNonWhite_row;
                        }
                        if (rightNonWhite_row != null
                            && (rightNonWhite == null || rightNonWhite < rightNonWhite_row))
                        {
                            rightNonWhite = rightNonWhite_row;
                        }
                    }

                    leftNonWhite = leftNonWhite ?? 0;
                    rightNonWhite = rightNonWhite ?? toWidth;
                    topNonWhite = topNonWhite ?? 0;
                    bottomNonWhite = bottomNonWhite ?? toHeight;

                    // Set crop box with correction to previous crop box
                    doc.Pages[1].CropBox =
                        new Aspose.Pdf.Rectangle(
                            leftNonWhite.Value + prevCropBox.LLX,
                            (toHeight + prevCropBox.LLY) - bottomNonWhite.Value,
                            rightNonWhite.Value + doc.Pages[1].CropBox.LLX,
                            (toHeight + prevCropBox.LLY) - topNonWhite.Value
                            );
                }
                finally
                {
                    if (imageBitmapData != null)
                        bmp.UnlockBits(imageBitmapData);
                }
            }
            dataDir = dataDir + "TrimWhiteSpace_out.pdf";
            // Save the updated document
            doc.Save(dataDir);
            // ExEnd:TrimWhiteSpace
            Console.WriteLine("\nWhite-space trimmed successfully around a page.\nFile saved at " + dataDir);
        }
    }
}