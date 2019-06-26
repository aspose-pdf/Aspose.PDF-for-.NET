using System.IO;
using System;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Annotations;
using System.Drawing;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles
{
    public class PDFToTIFFConversion
    {
        public static void Run()
        {
            // ExStart:PDFToTIFFConversion
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create PdfConverter object and bind input PDF file
            PdfConverter pdfConverter = new PdfConverter();
            pdfConverter.Resolution = new Aspose.Pdf.Devices.Resolution(300);
            pdfConverter.BindPdf(dataDir + "inFile.pdf");
            pdfConverter.DoConvert();
            // Create TiffSettings object and set ColorDepth
            TiffSettings tiffSettings = new TiffSettings();
            tiffSettings.Depth = ColorDepth.Format1bpp;
            // Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir + "PDFToTIFFConversion_out.tif", 300, 300, tiffSettings);
            pdfConverter.Close();
            // ExEnd:PDFToTIFFConversion                      
        }
        public static void NewApproach()
        {
            // ExStart:NewApproach
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_TechnicalArticles();

            // Create PdfConverter object and bind input PDF file
            PdfConverter pdfConverter = new PdfConverter();           
            pdfConverter.BindPdf(dataDir + "inFile.pdf");
            pdfConverter.DoConvert();

            // Create TiffSettings object and set CompressionType
            TiffSettings tiffSettings = new TiffSettings();            
            // Convert to TIFF image
            pdfConverter.SaveAsTIFF(dataDir + "PDFToTIFFConversion_out.tif", 300, 300, tiffSettings, new WinAPIIndexBitmapConverter());
            pdfConverter.Close();
            // ExEnd:NewApproach                      
        }
    }
    // ExStart:IIndexBitmapConverter
    public class WinAPIIndexBitmapConverter : IIndexBitmapConverter
    {
        public Bitmap Get1BppImage(Bitmap src)
        {
            return CopyToBpp(src, 1);
        }

        public Bitmap Get4BppImage(Bitmap src)
        {
            return CopyToBpp(src, 4);
        }

        public Bitmap Get8BppImage(Bitmap src)
        {
            return CopyToBpp(src, 8);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern int DeleteDC(IntPtr hdc);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hdcDst, int xDst, int yDst, int w, int h, IntPtr hdcSrc, int xSrc, int ySrc, int rop);
        static int SRCCOPY = 0x00CC0020;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO bmi, uint Usage, out IntPtr bits, IntPtr hSection, uint dwOffset);
        static uint BI_RGB = 0;
        static uint DIB_RGB_COLORS = 0;
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct BITMAPINFO
        {
            public uint biSize;
            public int biWidth, biHeight;
            public short biPlanes, biBitCount;
            public uint biCompression, biSizeImage;
            public int biXPelsPerMeter, biYPelsPerMeter;
            public uint biClrUsed, biClrImportant;
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 256)]
            public uint[] cols;
        }

        static uint MAKERGB(int r, int g, int b)
        {
            return ((uint)(b & 255)) | ((uint)((r & 255) << 8)) | ((uint)((g & 255) << 16));
        }

        ////////////
        /// <summary>
        /// Copies a bitmap into a 1bpp/8bpp bitmap of the same dimensions, fast
        /// </summary>
        /// <param name="b">original bitmap</param>
        /// <param name="bpp">1 or 8, target bpp</param>
        /// <returns>a 1bpp copy of the bitmap</returns>
        private Bitmap CopyToBpp(System.Drawing.Bitmap b, int bpp)
        {
            if (bpp != 1 && bpp != 8 && bpp != 4) throw new System.ArgumentException("1 or 4 or 8 ", "bpp");

            // Plan: built into Windows GDI is the ability to convert
            // Bitmaps from one format to another. Most of the time, this
            // Job is actually done by the graphics hardware accelerator card
            // And so is extremely fast. The rest of the time, the job is done by
            // Very fast native code.
            // We will call into this GDI functionality from C#. Our plan:
            // (1) Convert our Bitmap into a GDI hbitmap (ie. copy unmanaged->managed)
            // (2) Create a GDI monochrome hbitmap
            // (3) Use GDI "BitBlt" function to copy from hbitmap into monochrome (as above)
            // (4) Convert the monochrone hbitmap into a Bitmap (ie. copy unmanaged->managed)

            int w = b.Width, h = b.Height;
            IntPtr hbm = b.GetHbitmap(); // This is step (1)
            //
            // Step (2): create the monochrome bitmap.
            // "BITMAPINFO" is an interop-struct which we define below.
            // In GDI terms, it's a BITMAPHEADERINFO followed by an array of two RGBQUADs
            BITMAPINFO bmi = new BITMAPINFO();
            bmi.biSize = 40;  // The size of the BITMAPHEADERINFO struct
            bmi.biWidth = w;
            bmi.biHeight = h;
            bmi.biPlanes = 1; // "planes" are confusing. We always use just 1. Read MSDN for more info.
            bmi.biBitCount = (short)bpp; // Ie. 1bpp or 8bpp
            bmi.biCompression = BI_RGB; // Ie. the pixels in our RGBQUAD table are stored as RGBs, not palette indexes
            bmi.biSizeImage = (uint)(((w + 7) & 0xFFFFFFF8) * h / 8);
            bmi.biXPelsPerMeter = 1000000; // Not really important
            bmi.biYPelsPerMeter = 1000000; // Not really important
            // Now for the colour table.
            uint ncols = (uint)1 << bpp; // 2 colours for 1bpp; 256 colours for 8bpp
            bmi.biClrUsed = ncols;
            bmi.biClrImportant = ncols;
            bmi.cols = new uint[256]; // The structure always has fixed size 256, even if we end up using fewer colours
            if (bpp == 1)
            {
                bmi.cols[0] = MAKERGB(0, 0, 0); bmi.cols[1] = MAKERGB(255, 255, 255);
            }
            else if (bpp == 4)
            {
                // For 8bpp we've created an palette with just greyscale colours.
                // You can set up any palette you want here. Here are some possibilities:
                // Rainbow: 
                bmi.biClrUsed = 16;
                bmi.biClrImportant = 16;
                int[] colv = new int[16] { 8, 24, 38, 56, 72, 88, 104, 120, 136, 152, 168, 184, 210, 216, 232, 248 };
                //          
                for (int i = 0; i < 16; i++) bmi.cols[i] = MAKERGB(colv[i], colv[i], colv[i]);
            }
            else if (bpp == 8)
            {
                // For 8bpp we've created an palette with just greyscale colours.
                // You can set up any palette you want here. Here are some possibilities:
                // Rainbow:
                bmi.biClrUsed = 216; bmi.biClrImportant = 216; int[] colv = new int[6] { 0, 51, 102, 153, 204, 255 };
                for (int i = 0; i < 216; i++) bmi.cols[i] = MAKERGB(colv[i / 36], colv[(i / 6) % 6], colv[i % 6]);
                // Optimal: a difficult topic: http:// En.wikipedia.org/wiki/Color_quantization
            }


            // 
            // Now create the indexed bitmap "hbm0"
            IntPtr bits0; // Not used for our purposes. It returns a pointer to the raw bits that make up the bitmap.
            IntPtr hbm0 = CreateDIBSection(IntPtr.Zero, ref bmi, DIB_RGB_COLORS, out bits0, IntPtr.Zero, 0);
            //
            // Step (3): use GDI's BitBlt function to copy from original hbitmap into monocrhome bitmap
            // GDI programming is kind of confusing... nb. The GDI equivalent of "Graphics" is called a "DC".
            IntPtr sdc = GetDC(IntPtr.Zero);       // First we obtain the DC for the screen
            // Next, create a DC for the original hbitmap
            IntPtr hdc = CreateCompatibleDC(sdc); SelectObject(hdc, hbm);
            // And create a DC for the monochrome hbitmap
            IntPtr hdc0 = CreateCompatibleDC(sdc); SelectObject(hdc0, hbm0);
            // Now we can do the BitBlt:
            BitBlt(hdc0, 0, 0, w, h, hdc, 0, 0, SRCCOPY);
            // Step (4): convert this monochrome hbitmap back into a Bitmap:
            Bitmap b0 = System.Drawing.Image.FromHbitmap(hbm0);
            //
            // Finally some cleanup.
            DeleteDC(hdc);
            DeleteDC(hdc0);
            ReleaseDC(IntPtr.Zero, sdc);
            DeleteObject(hbm);
            DeleteObject(hbm0);
            //
            return b0;
        }
    }
    // ExEnd:IIndexBitmapConverter
}