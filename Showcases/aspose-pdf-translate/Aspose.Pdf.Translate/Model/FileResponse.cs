﻿namespace Aspose.Pdf.Translate.Model
{
    public class FileResponse
    {
        ///<Summary>
        /// Get or set FolderName
        ///</Summary>
        public string FolderName { get; set; }

        ///<Summary>
        /// Get or set Files
        ///</Summary>
        public List<string> Files { get; set; }

        ///<Summary>
        /// Get or set FileProcessingErrorCode
        ///</Summary>
        public int FileProcessingErrorCode { get; set; }

        /// <summary>
        /// Status Code, 200 = Ok, 204 = Processing, 500 = error
        /// </summary>
        public int StatusCode { get; set; }
    }
}
