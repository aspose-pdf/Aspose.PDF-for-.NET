![Nuget](https://img.shields.io/nuget/v/Aspose.Pdf) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Pdf) ![GitHub](https://img.shields.io/github/license/aspose-pdf/Aspose.Pdf-for-.NET)
# .NET API to Process & Manipulate PDF Files

Integrate PDF creation, processing, manipulation & conversion features into your own .NET applications without needing Adobe Acrobat®. 

[Aspose.PDF for .NET](https://products.aspose.com/pdf/net) allows to work with PDF documents, pages, text, images, attachments, fonts, bookmarks, annotations, forms, operators, stamps, watermarks, links, security, signatures, and printing.
<p align="center">

  <a title="Download complete Aspose.PDF for .NET source code" href="https://github.com/aspose-pdf/Aspose.PDF-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](Demos)  | Source code for the live demos hosted at https://products.aspose.app/pdf/family.
[Docker](Docker)  | Source code of examples based on Docker-containers.
[Examples](Examples)  | A collection of .NET examples that help you learn the product features.
[Showcases](Showcases)  | Standalone ready-to-use applications that demonstrate some specific use cases.
[Plugins](Plugins)  | Visual Studio plugins of Aspose.PDF for .NET.


## PDF Processing via .NET

- [Generate PDF documents](https://docs.aspose.com/pdf/net/create-document/) on the fly through the API or via XML templates.
- Supports 14 core, Type 1, TruType, Type 3, CJK & Unicode fonts.
- [Extract text](https://docs.aspose.com/pdf/net/extract-text-from-pdf/) from PDF pages or search for particular text segment using regular expressions.
- Add or extract text & images to & from PDF documents.
- [Concatenate](https://docs.aspose.com/pdf/net/concatenate-pdf-files/) or split PDF files.
- Linearization of PDF documents for web optimization.
- Validation support for PDF/A-1a, PDF/A-1b & PDF/A-2a.
- Manage [PDF tables](https://docs.aspose.com/pdf/net/working-with-tables/) & [graphs](https://docs.aspose.com/pdf/net/working-with-graphs/) using easy to understand object model.
- Convert PDF documents to Office, web, image & PS formats with highest visual fidelity.
- Manipulate PDF files to manage bookmarks, hyperlinks, watermarks, attachments & annotation.
- Encrypt or decrypt PDF documents as well as set document privileges or modify passwords.
- Manage PDF forms to add, delete, move, flatten or decorate form fields. Developers may also import or export XML, FDF or XFDF data.
- Digitally sign PDF documents or remove signatures. Also, verify if PDF is signed and signature is valid.
- Print PDF documents to physical or virtual printers with or without print dialog.
- Set document viewer preferences as well as manipulate document information & XMP metadata.

## Read & Write PDF & Other Formats

**Fixed Layout:** PDF, PDF/A, PDF/UA, XPS\
**Books:** EPUB\
**Web:** HTML, MHTML\
**Other:** TEX, CGM, XSLFO, XML, PCL, SVG

## Save PDF Documents As

**Microsoft Office:** DOC, DOCX, XLS, XLSX, PPTX\
**Images:** JPEG, PNG, BMP, TIFF, EMF\
**Other:** MobiXML, XML

## Read Formats

**PostScript:** PS

## Platform Independence

Aspose.PDF for .NET can be used to build applications for Windows, Mac OS X x64 as well as for Linux x64. Developers may also code in PHP, VBScript, Delphi & C++ programming languages while using Aspose.PDF for .NET via COM Interop.

## Getting Started with Aspose.PDF for .NET

Are you ready to give Aspose.PDF for .NET a try? Simply execute `Install-Package Aspose.PDF` from Package Manager Console in Visual Studio to fetch the NuGet package. If you already have Aspose.PDF for .NET and want to upgrade the version, please execute `Update-Package Aspose.PDF` to get the latest version.

## Create a PDF Document from Scratch

```csharp
// initialize document object
Document document = new Document();
// add a page
Page page = document.Pages.Add();
// add text to the new page
page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));
// save PDF document
document.Save(dir + "output.pdf");
```

## Save PDF as Office & HTML Formats

One of the most popular feature of Aspose.PDF for .NET is to convert PDF documents to other formats without needing to understand the underlying structure of the resultant format.

Give the following snippet a try with your own samples:

```csharp
// load the file to be converted
var pfile = new Aspose.Pdf.Document(dir + "template.pdf");
// save in different formats
pfile.Save(dir + "output.docx", Aspose.Pdf.SaveFormat.DocX);
pfile.Save(dir + "output.pptx", Aspose.Pdf.SaveFormat.Pptx);
pfile.Save(dir + "output.html", Aspose.Pdf.SaveFormat.Html);
```

# Create an issue User Guidelines

## Be Specific

- Use clear, concise titles that immediately convey the problem.
- Provide detailed steps to reproduce the issue.
- Include relevant environment details (OS, version, browser, etc.).
- Attach screenshots or screen recordings when applicable.
- Don't create issues with titles like "Something is broken".
- Prevent generic, non-descriptive language.
- Attach sample source/output files when issue is file specific.

## Checklist
- [ ] Search existing issues to prevent duplicates.
- [ ] Gather all relevant information.
- [ ] Determine appropriate labels.
- [ ] Identify impacted components.

[Home](https://www.aspose.com/) | [Product Page](https://products.aspose.com/pdf/net) | [Docs](https://docs.aspose.com/pdf/net/) | [Demos](https://products.aspose.app/pdf/family) | [API Reference](https://apireference.aspose.com/pdf/net) | [Examples](https://github.com/aspose-pdf/Aspose.Pdf-for-.NET) | [Blog](https://blog.aspose.com/category/pdf/) | [Search](https://search.aspose.com/) | [Free Support](https://forum.aspose.com/c/pdf) |  [Temporary License](https://purchase.aspose.com/temporary-license)
