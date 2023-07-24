using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    /// <summary>
    ///AsposePdfAnnotation class to add or remove annotations from PDF file
    /// </summary>
    public class AsposePdfAnnotation : AsposePdfBase
    {
        ///<Summary>
        /// Remove annotations method
        ///</Summary>

        public Response Remove(DocumentInfo[] docs, string sourceFolder)
        {

            if (docs == null)
            {
                return BadDocumentResponse;
            }

            if (docs.Length == 0 || docs.Length > MaximumUploadFiles)
            {
                return MaximumFileLimitsResponse;
            }

            SetDefaultOptions(docs, "");
            Opts.AppName = "Annotation";
            Opts.FolderName = sourceFolder;
            Opts.MethodName = "Remove";
            Opts.ZipFileName = docs.Length > 1 ? "Removed Annotations" : Path.GetFileNameWithoutExtension(docs[0].FileName);
            Opts.CreateZip = false;

            return Process((inFilePath, outPath, zipOutFolder) =>
            {
                var tasks = docs.Select(x => Task.Factory.StartNew(() => RemoveAnnotations(x, outPath, zipOutFolder))).ToArray();
                Task.WaitAll(tasks);
            });
        }

        private void RemoveAnnotations(DocumentInfo documentInfo, string outPath, string zipOutFolder)
        {
            // Open document
            Document pdfDocument = new Document(documentInfo.FileName);

            foreach (Pdf.Page page in pdfDocument.Pages)
            {
                // Delete particular annotation
                page.Annotations.Delete();
            }

            // Save the document in PDF format.
            pdfDocument.Save(outPath);
        }




    }
}
