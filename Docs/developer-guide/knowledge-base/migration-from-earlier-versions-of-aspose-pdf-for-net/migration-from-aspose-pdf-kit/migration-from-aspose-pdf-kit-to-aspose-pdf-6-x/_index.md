---
title: Migration from Aspose.Pdf.Kit to Aspose.Pdf 6.x
type: docs
weight: 10
url: /net/migration-from-aspose-pdf-kit-to-aspose-pdf-6-x/
---

{{% alert color="primary" %}} 

The legacy Aspose.PDF.Kit for .NET provided the features to manipulate existing PDF files. Now that the old Aspose.PDF for .NET and Aspose.PDF.Kit for .NET are merged into a single [Aspose.PDF for .NET](/pdf/net/) product, the Aspose.PDF.Kit for .NET classes have been moved under Aspose.PDF.Facades namespace. 

{{% /alert %}} 
#### **Support for Legacy code**
If you want to use the legacy code developed with Aspose.PDF.Kit for .NET, you only need to import  Aspose.PDF.Facades namespace and your code will be working fine. We need to make some changes in the code while using classes present under Aspose.PDF.Facades namespace. These details are explained in [Changes Required when Migrating from Aspose.PDF.Kit](/pdf/net/changes-required-when-migrating-from-aspose-pdf-kit/). 

The following code snippet shows you how to run your existing Aspose.PDF.Kit code with new Aspose.PDF. 

**C#**

{{< highlight csharp >}}

 //use new Facades namespace to access legacy classes

using Aspose.PDF.Facades;

namespace Aspose.PDF.FacadesSample

{

    class Program

    {

        static void Main(string[] args)

        {

            //set license

            //Note: License class is under Aspose.PDF namespace

            Aspose.PDF.License license = new Aspose.PDF.License();

            license.SetLicense("Aspose.Total.lic");

            //Note: PdfExtractor class is under Aspose.PDF.Facades

            //bind input PDF file

            PdfExtractor pdfExtractor = new PdfExtractor();

            pdfExtractor.BindPdf("input.pdf");

            //extract all the text

            pdfExtractor.ExtractText();

            //get extracted text in file or stream

            pdfExtractor.GetText("output.pdf");

        }

    }

}



{{< /highlight >}}
