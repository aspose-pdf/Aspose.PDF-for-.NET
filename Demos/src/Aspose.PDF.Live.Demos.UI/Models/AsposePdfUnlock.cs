using Aspose.Pdf.Live.Demos.UI.Models.Common;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Pdf.Live.Demos.UI.Models
{
    ///<Summary>
    /// AsposePdfUnlock class to remove password in documents
    ///</Summary>
    public class AsposePdfUnlock : AsposePdfBase
    {

        public Response Unlock(InputFiles files, string passw, string folderName)
        {
            if (files.Count == 0 || files.Count > MaximumUploadFiles)
            {
                return MaximumFileLimitsResponse;
            }

            SetDefaultOptions(files, "");
            Opts.AppName = "Unlock";
            Opts.MethodName = "Unlock";
            Opts.ZipFileName = "Unlocked documents";
            Opts.FolderName = folderName;

            var lck = new object();
            var catchedException = false;
            var strError = new StringBuilder();
            var docs = new DocumentInfo[files.Count];
            for (var i = 0; i < files.Count; i++)
            {
                docs[i] = new DocumentInfo();
                try
                {
                    docs[i].PdfDocument = new Document(files[i].FullFileName, passw);
                    docs[i].PdfDocument.Decrypt();
                }
                catch (InvalidPasswordException ex)
                {
                    lock (lck)
                    {
                        strError.Append($"File \"{Path.GetFileName(files[i].FullFileName)}\" - {ex.Message}");
                        catchedException = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    lock (lck)
                    {
                        catchedException = true;
                    }
                }
            }

            if (!catchedException)
            {
                return Process((inFilePath, outPath, zipOutFolder) =>
                {
                    var tasks = docs.Select(doc => Task.Factory.StartNew(() =>
                    {
                        SaveDocument(doc, outPath, zipOutFolder,
                            new SaveFormatType()
                            {
                                SaveOptions = new PdfSaveOptions(),
                                SaveType = SaveType.pdf
                            });
                    })).ToArray();
                    Task.WaitAll(tasks);
                });
            }

            return new Response
            {
                Status = strError.Length > 0 ? strError.ToString() : "Exception during processing",
                StatusCode = 500
            };
        }
    }
}
