using Aspose.Pdf.Annotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    public class AsposePdfParser : AsposePdfBase
    {
        ///<Summary>
        /// Parse method
        ///</Summary>	    
        public Response Parse(DocumentInfo[] docs, string sourceFolder)
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
            Opts.AppName = "Parser";
            Opts.FolderName = sourceFolder;
            Opts.MethodName = "Parse";
            Opts.ZipFileName = docs.Length > 1 ? "Parser" : Path.GetFileNameWithoutExtension(docs[0].FileName);
            Opts.OutputType = ".txt";
            Opts.CreateZip = true;

            return Process((inFilePath, outPath, zipOutFolder) =>
            {
                var tasks = docs.Select(x => Task.Factory.StartNew(() => ParseDocument(x, zipOutFolder))).ToArray();
                Task.WaitAll(tasks);
            });
        }

        private void ParseDocument(DocumentInfo documentInfo, string zipOutFolder)
        {
            var doc = new Document(documentInfo.FileName);
            // Extract text
            var pdfExtractor = new Pdf.Facades.PdfExtractor(doc);
            pdfExtractor.ExtractText();
            pdfExtractor.GetText(zipOutFolder + "\\" + Path.GetFileNameWithoutExtension(documentInfo.FileName) + ".txt");

            // Extract images
            pdfExtractor.ExtractImage();
            System.IO.Directory.CreateDirectory(zipOutFolder + "\\images\\");
            var imageFileNameTemplate = System.IO.Path.GetFileNameWithoutExtension(documentInfo.FileName);
            var imageCounter = 0;
            while (pdfExtractor.HasNextImage())
            {
                var imageFileName = zipOutFolder + "\\images\\" + imageFileNameTemplate + (++imageCounter).ToString("D8") + ".png";
                pdfExtractor.GetNextImage(imageFileName,
                    System.Drawing.Imaging.ImageFormat.Png);
            }

            // Extract attachments
            pdfExtractor.ExtractAttachment();
            System.IO.Directory.CreateDirectory(zipOutFolder + "\\attachments\\");
            pdfExtractor.GetAttachment(string.Format("{0}\\attachments", zipOutFolder));

            // Extract Annotations 
            var pdfAnnotationEditor = new Pdf.Facades.PdfAnnotationEditor(doc);
            var annotType = new[] { AnnotationType.FreeText, AnnotationType.Highlight, AnnotationType.Ink };
            var stream = System.IO.File.OpenWrite(string.Format("{0}\\annotation.xdf", zipOutFolder));
            pdfAnnotationEditor.ExportAnnotationsXfdf(stream, 1, doc.Pages.Count, annotType);
            stream.Close();

            // Export bookmarks
            var bookmarkEditor = new Pdf.Facades.PdfBookmarkEditor(doc);
            bookmarkEditor.ExportBookmarksToXML(string.Format("{0}\\bookmarks.xml", zipOutFolder));

            // Export form data
            var form = new Aspose.Pdf.Facades.Form(doc);
            stream = System.IO.File.OpenWrite(string.Format("{0}\\formdata.xdf", zipOutFolder));
            form.ExportFdf(stream);
            stream.Close();
        }
    }
}
