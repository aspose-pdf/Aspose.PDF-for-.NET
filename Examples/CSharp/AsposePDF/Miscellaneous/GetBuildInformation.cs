using System.IO;
using System;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Miscellaneous
{
    public class GetBuildInformation
    {
        public static void Run()
        {
            // ExStart:GetBuildInformation
            // Get version information
            Console.WriteLine("Product : {0}", BuildVersionInfo.Product);
            Console.WriteLine("File Version : {0}", BuildVersionInfo.FileVersion);
            Console.WriteLine("Assembly Version : {0}", BuildVersionInfo.AssemblyVersion);	
            // ExEnd:GetBuildInformation
        }
    }
}