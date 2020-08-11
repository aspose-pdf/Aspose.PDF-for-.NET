---
title: Working with PDF printing - Facades
type: docs
weight: 120
url: /net/working-with-pdf-printing-facades/
---

## **Printing PDF File to Default Printer using Printer and Page Settings**
The [PdfViewer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfviewer) class allows you to print a PDF file to the default printer. You need to create a PdfViewer object and open the PDF using the BindPdf method. To specify different print settings, use the PageSettings and PrinterSettings classes. Finally, call the PrintDocumentWithSettings method to print the PDF to the default printer. The following code snippet shows how to print PDF to the default printer with printer and page Settings.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintToDefaultPrinter-PrintToDefaultPrinter.cs" >}}

In order to display a print dialog, try using the following code snippet:

{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintToDefaultPrinter-PrintDialog.cs" >}}
## **Printing PDF to an XPS Printer (Facades)**
You can print a PDF file to an XPS printer, or some other soft printer for that matter, using the [PdfViewer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfviewer) class. In order to do that, create an object of the PdfViewer class and open the PDF file using the BindPdf method. You can set different print settings using the PrinterSettings and PageSettings classes. You also need to set the PrinterName property to the XPS or other soft printer you have installed.

Finally, use PrintDocumentWithSettings method to print the PDF to XPS or other soft printer. The following code snippet shows you how to print the PDF file to an XPS printer.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintoXPSPrinter-PrintoXPSPrinter.cs" >}}

When printing a PDF files that contains text and you want the contents to appear as text instead of vector graphics, please try using the following code snippets.
### **Fonts not Embedded**
If the document does not contain embedded fonts, it is possible to embed system fonts into the document at the point of printing.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintoXPSPrinter-FontsNotEmbedded.cs" >}}
### **Fonts Embedded**
For documents that have embedded fonts, the quality can be improved and fonts are embedded to the document. Aspose.PDF has a feature that allows you to substitute embedded fonts with system fonts.
## **Printing PDF to an XPS File and Hiding Print Dialog**
A PDF file can be printed to an XPS file, without showing any print dialog, using the [PdfViewer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfviewer) class. In order to do that, create an object of the PdfViewer class and open the PDF file using the BindPdf method.

You can set different print settings using the PrinterSettings and [PageSettings classes. You also need to set the PrinterName property to point to the XPS printer.

Additionally, because you want to to print the PDF to an XPS file and hide the print dialog, set the PrintFileName and PrintToFile properties of the PrinterSettings class. Also set the PrintPageDialog property to false. Finally, use the PrintDocumentWithSettings method to print the PDF to XPS or another soft printer.

The following code snippet shows you how to print the PDF file to an XPS file.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintoXPSPrinter-HideDialgo.cs" >}}
## **Printing Color PDF to XPS File as Grayscale**
A color PDF document can be printed to an XPS printer as grayscale, using [PdfViewer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfviewer). In order to achieve that you need to use the property PdfViewer.PrintAsGrayscale and set it to *true*. Following code snippet demonstrates the implementation of PdfViewer.PrintAsGrayscale Property.



**C#**

{{< highlight java >}}

 string dataDir = RunExamples.GetDataDir_AsposePdfFacades_Printing();

using (Facades.PdfViewer viewer = new Facades.PdfViewer())

{

 string outputFile = dataDir + @"TestXPS_Out.xps";

 viewer.BindPdf(dataDir + "TestDoc_Colored.pdf");

 viewer.PrintPageDialog = false;

 viewer.PrintAsGrayscale = true;

 System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();

 System.Drawing.Printing.PageSettings pgs = new System.Drawing.Printing.PageSettings();

 ps.PrinterName = "Microsoft Print to PDF";

 ps.PrintFileName = outputFile;

 ps.PrintToFile = true;

 pgs.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);

 ps.DefaultPageSettings.PaperSize = pgs.PaperSize;

 viewer.PrintDocumentWithSettings(pgs, ps);

}

{{< /highlight >}}
## **PDF to PostScript conversion**
The [PdfViewer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfviewer) class provides the capability to print PDF documents and with the help of this class, we can also convert PDF files to PostScript format. To convert a PDF file into PostScript, first install any PS printer and just print to file with the help of PdfViewer. You may follow the instructions specified by [the University of Hawaii](http://www.hawaii.edu/askus/637) on how to install PS printer. The following code snippet shows you how to print and convert a PDF to PostScript format.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PdfToPostScript-PdfToPostScript.cs" >}}
## **Checking Print Job Status**
A PDF file can be printed to a physical printer as well as to the Microsoft XPS Document Writer, without showing a print dialog, using the [PdfViewer](https://apireference.aspose.com/net/pdf/aspose.pdf.facades/pdfviewer) class. When printing large PDF files, the process might take a long time so the user might not be certain whether the printing process completed or encountered an issue. To determine the status of a printing job, use the PrintStatus property. The following code snippet shows you how to print the PDF file to an XPS file and get the printing status.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-CheckPrintJobStatus-CheckPrintJobStatus.cs" >}}
### **Get/Set Print Job Owner name**
Recently we received a requirement to get/set the print job Owner name (the actual user who pressed print button on web page). This information is required when printing the PDF file. In order to accomplish this requirement, you can use the property named PrinterJobName:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-CheckPrintJobStatus-GetSetPrintOwnerName.cs" >}}

{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-CheckPrintJobStatus-GetCurrentUserCredentials.cs" >}}


**Using Impersonation**

Another approach of getting Print Job owner name is to use impersonation (running printing routines in another user context) or user may change owner name directly by using [SetJob routine](http://msdn.microsoft.com/en-us/library/dd162978%28VS.85%29.aspx).

Please note that there is no possibility to set owner value using Aspose.PDF printing API by security considerations. The property PrinterJobName may be used to set document name column value in spooler print application. Code snippet shared above just shows how the user can join user name into document name column (for example using syntax UserName\documentName). But the setting of Owner columns can be implemented in following ways directly by user:

\1) Impersonation. As owner column value contains the value of user who runs the printing code, there is a way to invoke Aspose.PDF printing API inside another user context. For example please take a look on solution described [here](http://www.codeproject.com/Articles/10090/A-small-C-Class-for-impersonating-a-User). Using this class the user can reach a goal:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-CheckPrintJobStatus-UsingImpersonation.cs" >}}



\2) Using Spooler API and [SetJob routine](http://msdn.microsoft.com/en-us/library/dd162978%28VS.85%29.aspx)

{{% alert color="primary" %}} 

The following links can be useful to get user credentials:

- [ASP.NET Web Application Security](http://msdn.microsoft.com/en-us/library/330a99hc%28v=vs.100%29.aspx)
- [What is Windows Identity Foundation?](http://msdn.microsoft.com/en-us/library/ee748475.aspx)
- [Authentication and Authorization with Windows Accounts in ASP.NET](https://www.simple-talk.com/dotnet/asp.net/authentication-and-authorization-with-windows-accounts-in-asp.net/)

{{% /alert %}} 
## **Printing pages in Simplex and Duplex mode**
In a particular printing job, the pages of PDF document can either be printed in Duplex or in Simplex mode but you cannot print some pages as simplex and some pages as duplex within a single print job. However in order to accomplish the requirement, different page ranges and *PrintingJobSettings * object can be used. The following code snippet shows how to print some pages of PDF file in Simplex and some pages in Duplex mode.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintPages-PrintingJobSettings.cs" >}}

{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintPages-PrintPages.cs" >}}
## **Printing Different Page Range to Different Paper Sourcetrays**
We were asked to support printing different pages to different page trays within a printing job. The user must be able to send a document to a printer and be sure that there are no other print jobs in between pages. The document must be printed as one. To print a different page range to different paper source trays, use the PdfViewer.PdfQueryPageSettings event handler. The following code snippet shows how to print even and odd page numbers to different sources:



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintPageRange-PrintPageRange.cs" >}}

{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-Printing-PrintPageRange-PdfvOnPdfQueryPageSettings.cs" >}}
