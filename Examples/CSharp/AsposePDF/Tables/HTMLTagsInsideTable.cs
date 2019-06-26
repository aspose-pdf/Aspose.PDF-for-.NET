using System.Data;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Tables
{
    public class HTMLTagsInsideTable
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Tables();

            DataTable dt = new DataTable("Employee");
            dt.Columns.Add("data", System.Type.GetType("System.String"));

            DataRow dr = dt.NewRow();
            dr[0] = "<li>Department of Emergency Medicine: 3400 Spruce Street Ground Silverstein Bldg Philadelphia PA 19104-4206</li>";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "<li>Penn Observation Medicine Service: 3400 Spruce Street Ground Floor Donner Philadelphia PA 19104-4206</li>";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "<li>UPHS/Presbyterian - Dept. of Emergency Medicine: 51 N. 39th Street . Philadelphia PA 19104-2640</li>";
            dt.Rows.Add(dr);

            Document doc = new Document();
            doc.Pages.Add();
            // Initializes a new instance of the Table
            Aspose.Pdf.Table tableProvider = new Aspose.Pdf.Table();
            //Set column widths of the table
            tableProvider.ColumnWidths = "400 50 ";
            // Set the table border color as LightGray
            tableProvider.Border = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.5F, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            // Set the border for table cells
            tableProvider.DefaultCellBorder = new Aspose.Pdf.BorderInfo(Aspose.Pdf.BorderSide.All, 0.5F, Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray));
            Aspose.Pdf.MarginInfo margin = new Aspose.Pdf.MarginInfo();
            margin.Top = 2.5F;
            margin.Left = 2.5F;
            margin.Bottom = 1.0F;
            tableProvider.DefaultCellPadding = margin;

            tableProvider.ImportDataTable(dt, false, 0, 0, 3, 1, true);

            doc.Pages[1].Paragraphs.Add(tableProvider);
            doc.Save(dataDir + "HTMLInsideTableCell_out.pdf");
            // ExEnd:1
        }
    }
}
