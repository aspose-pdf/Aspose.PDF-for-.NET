using System.Collections.ObjectModel;

namespace Aspose.Pdf.Translate.Model
{
    public class FileResponse
    {
        ///<Summary>
        /// Get or set Files
        ///</Summary>
        public Collection<string> Files { get; set; }

        ///<Summary>
        /// Get or set FileProcessingErrorCode
        ///</Summary>
        public int FileProcessingErrorCode { get; set; }

        /// <summary>
        /// Get count of files
        /// </summary>
        public int FileCount { get { return Files != null ? Files.Count : 0; } }

        ///<Summary>
        /// Get or set FileName
        ///</Summary>
        public string FileName { get; set; }

        ///<Summary>
        /// Get or set FolderName
        ///</Summary>
        public string FolderName { get; set; }
    }
}
