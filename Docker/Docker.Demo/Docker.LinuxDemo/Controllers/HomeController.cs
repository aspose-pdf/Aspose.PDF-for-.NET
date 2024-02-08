using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using Docker.LinuxDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Docker.LinuxDemo.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IWebHostEnvironment appEnvironment) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Generate()
        {
            const string fileType = "application/pdf";
            const string fileName = "sample.pdf";
            FontRepository.Sources.Add(new FolderFontSource(Path.Combine(_appEnvironment.WebRootPath, "fonts")));
            var memoryStream = new MemoryStream();

            _logger.LogInformation("PDF Generation: Start ");
            // Initialize document object
            var document = new Document();
            // Add page
            var page = document.Pages.Add();

            // Add image
            var imageFileName = Path.Combine(_appEnvironment.WebRootPath, "images", "logo.png");
            page.AddImage(imageFileName, new Rectangle(20, 730, 120, 830));

            // Add Header
            var header = new TextFragment("New ferry routes in Fall 2020");
            header.TextState.Font = FontRepository.FindFont("Roboto");
            header.TextState.FontSize = 24;
            header.HorizontalAlignment = HorizontalAlignment.Center;
            header.Position = new Position(130, 720);
            page.Paragraphs.Add(header);

            // Add description
            var descriptionText = "Visitors must buy tickets online and tickets are limited to 5,000 per day. Ferry service is operating at half capacity and on a reduced schedule. Expect lineups.";
            var description = new TextFragment(descriptionText);
            description.TextState.Font = FontRepository.FindFont("Helvetica");
            description.TextState.FontSize = 14;
            description.HorizontalAlignment = HorizontalAlignment.Left;
            page.Paragraphs.Add(description);


            // Add table
            var table = new Table
            {
                ColumnWidths = "200",
                Border = new BorderInfo(BorderSide.Box, 1f, Color.Black),
                DefaultCellBorder = new BorderInfo(BorderSide.Box, 0.5f, Color.Gray),
                DefaultCellPadding = new MarginInfo(4.5, 4.5, 4.5, 4.5),
                Margin =
                {
                    Top = 10,
                    Bottom = 10
                },
                DefaultCellTextState =
                {
                    Font =  FontRepository.FindFont("Helvetica")
                }
            };

            var headerRow = table.Rows.Add();
            headerRow.Cells.Add("Departs City");
            headerRow.Cells.Add("Departs Island");
            foreach (Cell headerRowCell in headerRow.Cells)
            {
                headerRowCell.BackgroundColor = Color.LightGray;
                headerRowCell.DefaultCellTextState.ForegroundColor = Color.FromRgb(0.1, 0.1, 0.1);
            }

            var time = new TimeSpan(6, 0, 0);
            var incTime = new TimeSpan(0, 30, 0);
            for (int i = 0; i < 10; i++)
            {
                var dataRow = table.Rows.Add();
                dataRow.Cells.Add(time.ToString(@"hh\:mm"));
                time = time.Add(incTime);
                dataRow.Cells.Add(time.ToString(@"hh\:mm"));
            }

            page.Paragraphs.Add(table);

            document.Save(memoryStream);
            _logger.LogInformation("PDF Generation: Finish");
            return File(memoryStream, fileType, fileName);
        }
        public FileStreamResult Convert(string id)
        {
            return id switch
            {
                "xps-to-pdf" => ConvertXpsToPdf(),
                "pdf-to-jpeg" => ConvertPdfToJpeg(),
                _ => throw new NotImplementedException(),
            };
        }

        private FileStreamResult ConvertPdfToJpeg()
        {
            const string fileType = "image/jpeg";
            const string fileName = "sample.jpeg";

            var memoryStream = new MemoryStream();
            var pdfFileName = Path.Combine(_appEnvironment.WebRootPath, "samples", "samples-new.pdf");

            var document = new Document(pdfFileName);
            var resolution = new Resolution(300);
            var renderer = new JpegDevice(resolution, 90);
            renderer.Process(document.Pages[1], memoryStream);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return File(memoryStream, fileType, fileName);
        }

        private FileStreamResult ConvertXpsToPdf()
        {
            const string fileType = "application/pdf";
            const string fileName = "sample.pdf";

            var memoryStream = new MemoryStream();
            var xpsFileName = Path.Combine(_appEnvironment.WebRootPath, "samples", "samples-new.oxps");

            var document = new Document(xpsFileName, new XpsLoadOptions());
            document.Save(memoryStream);

            return File(memoryStream, fileType, fileName);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
