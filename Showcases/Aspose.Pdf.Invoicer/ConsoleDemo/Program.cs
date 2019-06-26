using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.PDF.Invoicer;

namespace ConsoleDemo
{
    class Program
    {
        static void Main()
        {
            var productItems = new List<ProductItem> {
                new ProductItem ("1", "Chocolate with Milk", 166.66M, 20),
                new ProductItem ("2", "Chocolate with Nuts", 166.66M, 20),
                new ProductItem ("3", "Chocolate with Pepper", 166.66M, 20)
            };
            var subTotal = productItems.Sum(i => i.Total);
            var invoice = new Invoice
            {
                ForegroundColor = "#0000CC",
                BackgroundColor = "#FFFFFF",
                Number = "ABC-123",
                PaymentPeriod = 15,
                Logo = new LogoImage(@"C:\aspose\company-logo-design.png", 160, 120),
                BillFrom = new List<string> { "Eastern Chocolate Factory", "Eastern Chocolate House", "44 Shirley Ave.", "West Chicago", "IL 60185" },
                BillTo = new List<string> { "Eastern Chocolate Cafe", "Eastern Chocolate House", "44 Shirley Ave.", "West Chicago", "IL 60185" },
                Items = productItems,
                Totals = new List<TotalRow>
                {
                    new TotalRow("Sub Total", subTotal),
                    new TotalRow("VAT @ 20%", subTotal*0.2M),
                    new TotalRow("Total", subTotal*1.2M)
                },
                Details = new List<string> {
                    "Terms & Conditions",
                    $"Payment is due within 15 days",
                    string.Empty,
                    "If you have any questions concerning this invoice, contact our sales department at sales@east-chocolate.factory",
                     string.Empty,
                    "Thank you for your business."
                },
                Footer = "https://www.facebook.com/AsposePDF/"
            };


            var fileStream = new FileStream("C:\\tmp\\d2.pdf", FileMode.OpenOrCreate);
            invoice.Save(fileStream);
            fileStream.Close();
            System.Diagnostics.Process.Start("cmd.exe", "/c start C:\\tmp\\d2.pdf");
        }
    }
}