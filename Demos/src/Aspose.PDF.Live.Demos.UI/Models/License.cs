using System;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    ///<Summary>
    /// License class to set apose products license
    ///</Summary>
    public static class License
    {
        private static string _licenseFileName = "Aspose.Total.Product.Family";


        ///<Summary>
        /// SetAsposePdfLicense method to Aspose.Words License
        ///</Summary>
        public static void SetAsposePdfLicense()
        {
            try
            {
                Aspose.Pdf.License pdfLic = new Aspose.Pdf.License();
                pdfLic.SetLicense(_licenseFileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
