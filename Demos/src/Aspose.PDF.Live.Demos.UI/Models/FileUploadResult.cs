namespace Aspose.Pdf.Live.Demos.UI.Models
{
    public class FileUploadResult
    {
        public string LocalFilePath { get; set; }
        public string FileName { get; set; }
        public string FolderId { get; set; }
        public long FileLength { get; set; }

        public override string ToString()
        {

            return $"{200}|{FileName}|{FolderId}";
        }

    }

    public class FileUploadResponse
    {
        public string LocalFilePath { get; set; }
        public string FileName { get; set; }
        public string FolderId { get; set; }
        public long FileLength { get; set; }



    }
}
