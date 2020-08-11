---
title: Public API Changes in Aspose.Pdf for .NET 9.0.0
type: docs
weight: 30
url: /net/public-api-changes-in-aspose-pdf-for-net-9-0-0/
---

{{% alert color="primary" %}} 

These page lists public API changes that were introduced in Aspose.PDF for .NET 9.0.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
#### **UseNewConversionEngine**
The HtmlLoadOptions.**UseNewConversionEngine** property is true by default. In case you need to use older conversion technique, then please try using the following code snippet to turn off the new conversion engine and convert HTML into Pdf with old engine:

{{< highlight java >}}

 HtmlLoadOptions options = new HtmlLoadOptions();

options.UseNewConversionEngine = false;

Document pdfDocument = new Document(stream, options);

pdfDocument.Save(outFile);

{{< /highlight >}}
#### **CssSavingInfo.HtmlPageNumber is renamed to CssSavingInfo.CssNumber**
Instances of HtmlSaveOptions.CssSavingInfo are usually used in custom implementations of HtmlSaveOptions.CssSavingStrategy when it's necessary to implement custom saving of CSSes generated during PDF to HTML conversion. It contains parameter(s) and content of saved CSS.

In versions prior to 9.0.0, CssSavingInfo.HtmlPageNumber was used in public API. It was introduced when amount of saved CSSes and amount of HTML pages was always equal. Now inner logic of converter has been changed : it's possible that amount of HTML pages not equal to amount of saved CSS files, and for some inner reasons this parameter can contain only number of CSS, not number of parent HTML page, so it has been be renamed to CssSavingInfo.CssNumber.

In essence it's just informational parameter that can be used in customer's code to get ordinal of currently saved CSS-file.
**Public API changes** 
CssSavingInfo.**HtmlPageNumber** is renamed to CssSavingInfo.**CssNumber**.
#### **Miscellaneous**
- **ExtractImage** method is introduced into SignatureField class
- **ExtractImage** method is introduced into PdfFileSignature class
- **ExtractCertificate** method is introduced into SignatureField class
- **ExtractCertificate** method is introduced into PdfFileSignature class
- **CopyOutlines** property has been added into PdfFileEditor class.
- HtmlSaveOptions.**CssClassNamesPrefix** field has been introduced.
- Methods **ExportBookmarksToXML** and **ImportBookmarksWithXML** with Stream arguments are implemented in PdfBookmarkEditor class.
- **MhtLoadOptions** class was introduced.
- LoadFormat enumeration now contains **MHT** value.
