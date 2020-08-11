---
title: Generate Thumbnail Images from PDF Documents
type: docs
weight: 40
url: /net/generate-thumbnail-images-from-pdf-documents/
---

{{% alert color="primary" %}} 

The Adobe Acrobat SDK is a set of tools that help you develop software that interacts with Acrobat technology. The SDK contains header files, type libraries, simple utilities, sample code, and documentation.

Using the Acrobat SDK, you can develop software that integrates with Acrobat and Adobe Reader in several ways:

- **JavaScript** — Write scripts, either in an individual PDF document or externally, to extend the functionality of Acrobat or Adobe Reader.
- **Plug-ins** — Create plug-ins that are dynamically linked to and extend the functionality of Acrobat or Adobe Reader.
- **Interapplication communication** — Write a separate application process that uses interapplication communication (IAC) to control Acrobat functionality. DDE and OLE are supported on Microsoft® Windows®, and Apple events/AppleScript on Mac OS®. IAC is not available on UNIX®.

Aspose.PDF for .NET provides a lot of the same functionality, freeing you from dependence on Adobe Acrobat Automation. This article shows how to generate thumbnail images from PDF documents using first the [Acrobat SDK](/pdf/net/generate-thumbnail-images-from-pdf-documents-html/) and then [Aspose.PDF](/pdf/net/generate-thumbnail-images-from-pdf-documents-html/).

{{% /alert %}} 
### **Developing Application using Acrobat Interapplication communication API**
Think of the Acrobat API as having two distinct layers that use Acrobat Interapplication Communication (IAC) objects:

- The Acrobat application (AV) layer. The AV layer lets you control how the document is viewed. For example, the view of a document object resides in the layer associated with Acrobat.
- The portable document (PD) layer. The PD layer provides access to the information within a document, such as a page. From the PD layer you can perform basic manipulations of PDF documents, such as deleting, moving, or replacing pages, as well as changing annotation attributes. You can also print PDF pages, select text, access manipulated text, and create or delete thumbnails.

As our intent is to convert PDF pages into thumbnail images, so we are focusing more over IAC. The IAC API contains objects such as PDDoc, PDPage, PDAnnot, and others, which enable the user to deal with the portable document (PD) layer. The following code sample scans a folder and converts PDF pages into thumbnail images. With using the Acrobat SDK, we could also read the PDF metadata and retrieve the number of pages in the document.
#### **Acrobat Approach**
In order to generate the thumbnail images for each document, we have used the Adobe Acrobat 7.0 SDK and the Microsoft .NET 2.0 Framework.

The [Acrobat SDK](http://www.adobe.com/devnet/acrobat.html) combined with the full version of Adobe Acrobat exposes a COM library of objects (sadly the free Adobe Reader does not expose the COM interfaces) that can be used to manipulate and access PDF information. Using these COM objects via COM Interop, load the PDF document, get the first page and render that page to the clipboard. Then, with the .NET Framework, copy this to a bitmap, scale and combine the image and save the result as a GIF or PNG file.

Once Adobe Acrobat is installed, use regedit.exe and look under HKEY_CLASSES_ROOT for entry entry called AcroExch.PDDoc.

**The registry showing the AcroExch.PDDDoc entry** 

![todo:image_alt_text](generate-thumbnail-images-from-pdf-documents_1.png)

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-CreateThumbnailImagesUsingAdobe-CreateThumbnailImagesUsingAdobe.cs" >}}
### **Aspose.PDF for .NET Approach**
Aspose.PDF for .NET provides extensive support for dealing with PDF documents. It also supports the capability to convert the pages of PDF documents to a variety of image formats. The functionality described above can easily be achieved using Aspose.PDF for .NET.

Aspose.PDF has distinct benefits:

- You don't need to have Adobe Acrobat installed on your system to work with PDF files.
- Using Aspose.PDF for .NET is simple and easy to understand as compared to Acrobat Automation.

If we need to convert PDF pages into JPEGs, the [Aspose.PDF.Devices](https://docs-qa.aspose.com/display/pdftemp/Aspose.Pdf.Devices+namespace) namespace provides a class named JpegDevice for rendering PDF pages into JPEG images. Please take a look over the following code snippet.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Images-CreateThumbnailImages-CreateThumbnailImages.cs" >}}

- Thank you to CodeProject for [Generate Thumbnail Image from PDF document](http://www.codeproject.com/Articles/5887/Generate-Thumbnail-Images-from-PDF-Documents).
- Thank you to Acrobat for the [Acrobat SDK reference](http://livedocs.adobe.com/acrobat_sdk/10/Acrobat10_HTMLHelp/wwhelp/wwhimpl/js/html/wwhelp.htm?&accessible=true).
