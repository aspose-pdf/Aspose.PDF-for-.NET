using Aspose.Pdf;
using Aspose.Pdf.Text;
using Mvc5.Helpers;
using Mvc5.SampleProject.Models;
using MVC5.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Mvc5.SampleProject.Controllers
{
    public class HomeController : PdfController
    {
        private const string reportTitle1 = "Report of tenant moving-in and payment";
        private const string reportTitle2 = "List of apartments";

        public ActionResult Index()
        {
            var tenants = GenerateListOfTenants();
            ViewBag.Title = "Home Page";
            return View(tenants);
        }

        private static List<Tenant> GenerateListOfTenants()
        {
            var tenants = new List<Tenant>(10);
            for (var i = 0; i < 10; i++)
            {
                tenants.Add(new Tenant
                {
                    FullName = $"Demo {i+1}",
                    Id = i+1,
                    LeaseEndDate = DateTime.Today,
                    MoveInDate = DateTime.Today,
                    RentalPropertyAddress = "Demo Address",
                    MonthlyPayment = 2000
                });
            }
            return tenants;
        }


        public ActionResult PrintIndex()
        {
            var pdfOptions = new Aspose.Pdf.HtmlLoadOptions
            {
                PageInfo = new Aspose.Pdf.PageInfo
                {
                    Margin = new Aspose.Pdf.MarginInfo(10, 10, 10, 10)
                }
            };

            var tenats = GenerateListOfTenants();
            ViewBag.Title = "Home Page";
            return PdfView("Index.pdf", pdfOptions, "Index", tenats);
        }
        public ActionResult TenantsToPDF()
        {
            var tenants = GenerateListOfTenants();

            // Create new a PDF document
            var document = new Document
            {
                PageInfo = new PageInfo { Margin = new MarginInfo(28, 28, 28, 42) }
            };

            var pdfPage = document.Pages.Add();

            // Initializes a new instance of the TextFragment for report's title 
            var textFragment = new TextFragment(reportTitle1);

            // Set text properties
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.FontStyle = FontStyles.Bold;

            // Initializes a new instance of the Table
            Table table = new Table
            {
                // Set column auto widths of the table
                ColumnWidths = "10 10 10 10 10 10",
                ColumnAdjustment = ColumnAdjustment.AutoFitToContent,
                // Set cell padding
                DefaultCellPadding = new MarginInfo(5, 5, 5, 5),
                // Set the table border color as Black
                Border = new BorderInfo(BorderSide.All, .5f, Color.Black),
                // Set the border for table cells as Black
                DefaultCellBorder = new BorderInfo(BorderSide.All, .2f, Color.Black),
            };

            table.DefaultCellTextState = new TextState("TimesNewRoman", 10);
            var paymentFormat = new TextState("TimesNewRoman", 10)
            {
                HorizontalAlignment = HorizontalAlignment.Right
            };
            table.SetColumnTextState(5, paymentFormat);
            table.ImportEntityList(tenants);

            //Repeat Header
            table.RepeatingRowsCount = 1;

            // Add text fragment object to first page of input document
            pdfPage.Paragraphs.Add(textFragment);
            // Add table object to first page of input document
            pdfPage.Paragraphs.Add(table);

            using (var streamOut = new MemoryStream())
            {
                document.Save(streamOut);
                return new FileContentResult(streamOut.ToArray(), "application/pdf")
                {
                    FileDownloadName = "tenants.pdf"
                };
            }
        }
        public ActionResult Apartments()
        {
            ViewData["Report"] = reportTitle2;
            var appartments = GererateListOfApartments()
                .GroupBy(apt => apt.Region, (key, group) =>
                new GroupViewModel<string, ApartmentView>
                {
                    Key = key,
                    Values = group.Select(g =>
                    new ApartmentView
                    { City = g.City, Address = g.Address, TotalArea = g.TotalArea }
                    )
                });
            return View(appartments);
        }
        public ActionResult ApartmentsToPDF()
        {
            ViewData["Report"] = reportTitle2;
            var appartments = GererateListOfApartments()
                .GroupBy(apt => apt.Region, (key, group) =>
                new GroupViewModel<string, ApartmentView>
                {
                    Key = key,
                    Values = group.Select(g =>
                       new ApartmentView
                       { City = g.City, Address = g.Address, TotalArea = g.TotalArea }
                    )
                });


            // Create new a PDF document
            var document = new Document
            {
                PageInfo = new PageInfo { Margin = new MarginInfo(28, 28, 28, 42) }
            };

            var pdfPage = document.Pages.Add();

            // Initializes a new instance of the TextFragment for report's title 
            var textFragment = new TextFragment(reportTitle2);

            // Set text properties
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.FontStyle = FontStyles.Bold;

            // Initializes a new instance of the Table
            Table table = new Table
            {
                // Set column auto widths of the table
                ColumnWidths = "10 10 10",
                ColumnAdjustment = ColumnAdjustment.AutoFitToContent,
                // Set cell padding
                DefaultCellPadding = new MarginInfo(5, 5, 5, 5),
                // Set the table border color as Black
                Border = new BorderInfo(BorderSide.All, .5f, Color.Black),
                // Set the border for table cells as Black
                DefaultCellBorder = new BorderInfo(BorderSide.All, .2f, Color.Black),
            };

            table.DefaultCellTextState = new TextState("TimesNewRoman", 10);
            table.Margin.Left = 40;
            //Repeat Header
            table.RepeatingRowsCount = 1;

            table.ImportGroupedData(appartments);

            // Add text fragment object to first page of input document
            pdfPage.Paragraphs.Add(textFragment);
            // Add table object to first page of input document
            pdfPage.Paragraphs.Add(table);


            using (var streamOut = new MemoryStream())
            {
                document.Save(streamOut);
                return new FileContentResult(streamOut.ToArray(), "application/pdf")
                {
                    FileDownloadName = "apartmnets.pdf"
                };
            }
        }

        private List<Apartment> GererateListOfApartments()
        {
            string[] regions = new[] { "East", "West", "North", "South" };
            var apartments = new List<Apartment>();
            for (int i = 1; i < 11; i++)
            {
                apartments.Add(new Apartment
                {
                    Id = i,
                    Region = regions[i % 4],
                    City = "New York City",
                    Address = $"{(i % 6)+1}th Line str.",
                    TotalArea = 2000
                });
            }
            return apartments;
        }

        public ActionResult About()
        {
            ViewData["Message"] = "This application demonstrate how to export data from EF model to table in PDF document using Aspose.PDF for .NET";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

}