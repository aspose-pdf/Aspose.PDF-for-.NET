using Aspose.Pdf;

namespace Aspose.PDF.Editor.Services
{
    public static class LicenseProvider
    {
        private const string LicenseEnvVariable = "ASPOSE_PDF_LICENSE";

        public static void SetLicense()
        {
            var base64 = Environment.GetEnvironmentVariable(LicenseEnvVariable);
            if (base64 != null)
            {
                var ms = new MemoryStream(System.Convert.FromBase64String(base64));
                new License().SetLicense(ms);
            }
        }
    }
}
