using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PDFToXLS
    {
        public static void Run()
        {
            // ExStart:PDFToXLS
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // Instantiate ExcelSave Option object
            Aspose.Pdf.ExcelSaveOptions excelsave = new ExcelSaveOptions();

            // Save the output in XLS format
            pdfDocument.Save("PDFToXLS_out.xls", excelsave);
            // ExEnd:PDFToXLS
        }

        public static void PDFtoXLSX()
        {
            // ExStart:PDFToXLSX
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // Instantiate ExcelSave Option object
            Aspose.Pdf.ExcelSaveOptions excelsave = new ExcelSaveOptions();
            excelsave.Format = ExcelSaveOptions.ExcelFormat.XLSX;

            // Save the output in XLS format
            pdfDocument.Save("PDFToXLSX_out.xlsx", excelsave);
            // ExEnd:PDFToXLSX
        }

        public static void ControlColumn()
        {            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // ExStart:ControlColumn
            // Instantiate ExcelSave Option object
            Aspose.Pdf.ExcelSaveOptions excelsave = new ExcelSaveOptions();
            excelsave.InsertBlankColumnAtFirst = false;
            // ExEnd:ControlColumn

            // Save the output in XLS format
            pdfDocument.Save("PDFToXLSControlColumn_out.xls", excelsave);            
        }
        public static void ExportAllPagesToSingle()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

            // Load PDF document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // ExStart:ExportAllPagesToSingle
            // Instantiate ExcelSave Option object
            Aspose.Pdf.ExcelSaveOptions excelsave = new ExcelSaveOptions();
            // Set this property to true
            excelsave.MinimizeTheNumberOfWorksheets = true;
            // ExEnd:ExportAllPagesToSingle

            // Save the output in XLS format
            pdfDocument.Save("PDFToXLSExportAllPagesToSingle_out.xls", excelsave);
        }
    }
}