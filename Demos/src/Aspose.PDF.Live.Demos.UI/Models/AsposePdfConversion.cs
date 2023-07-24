using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    ///<Summary>
    /// AsposePdfConversion class to convert PDF files to different formats
    ///</Summary>
    public class AsposePdfConversion : AsposePdfBase
    {

        public Response ConvertFile(DocumentInfo[] docs, string outputType, string sourceFolder)
        {

            if (docs == null)
            {
                return PasswordProtectedResponse;
            }

            if (docs.Length == 0 || docs.Length > MaximumUploadFiles)
            {
                return MaximumFileLimitsResponse;
            }

            SetDefaultOptions(docs, outputType);

            Opts.AppName = "Conversion";
            Opts.MethodName = "Convert";
            Opts.ZipFileName = docs.Length > 1 ? "Converted documents" : Path.GetFileNameWithoutExtension(docs[0].FileName);
            Opts.FolderName = sourceFolder;

            var saveOpt = GetSaveOptions(outputType.ToLower());

            return Process((inFilePath, outPath, zipOutFolder) =>
            {
                var tasks = docs.Select(doc => Task.Factory.StartNew(() => SaveDocument(doc, outPath, zipOutFolder, saveOpt))).ToArray();
                Task.WaitAll(tasks);
            });
        }

        ///<Summary>
        /// XfaConvert method
        ///</Summary>		
        public Response XfaConvert(DocumentInfo[] docs, string sourceFolder, string inputType)
        {

            var outputType = "pdf";
            if (docs == null)
            {
                return BadDocumentResponse;
            }

            if (docs.Length == 0 || docs.Length > MaximumUploadFiles)
            {
                return MaximumFileLimitsResponse;
            }

            SetDefaultOptions(docs, "");
            Opts.AppName = "Conversion";
            Opts.FolderName = sourceFolder;
            Opts.MethodName = "XfaConvert";
            Opts.ZipFileName = docs.Length > 1 ? "Converted documents" : Path.GetFileNameWithoutExtension(docs[0].FileName);

            var saveOpt = GetSaveOptions(outputType.ToLower());

            return Process((inFilePath, outPath, zipOutFolder) =>
            {
                var tasks = docs.Select(doc => Task.Factory.StartNew(() => SaveDocument(doc, outPath, zipOutFolder, saveOpt))).ToArray();
                Task.WaitAll(tasks);
            });
        }

    }

}

