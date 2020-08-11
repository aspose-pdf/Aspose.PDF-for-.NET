---
title: Convert PDF-A to PDF
type: docs
weight: 40
url: /net/convert-pdf-a-to-pdf/
---

Aspose.PDF for .NET provides the feature to transform PDF files to PDF/A compliant format and similarly, it also offers the feature to convert PDF/A file to PDF format.

{{% alert color="primary" %}} 

Please note we follow Adobe Preflight for validating PDF/A conformance. All tools on the market have their own "representation" of PDF/A conformance. Please check this article on [PDF/A validation tools](http://wiki.opf-labs.org/display/SPR/PDFA+Validation+tools+give+different+results) for reference. We chose Adobe products for verifying how Aspose.PDF produces PDF files because Adobe is at the center of everything connected to PDF.

{{% /alert %}} 
## **Convert PDF-A to PDF**
In order to perform the conversion, the PDF compliance information is removed from input/source file using RemovePdfaCompliance(..) method of Document object.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFAToPDF-PDFAToPDF.cs" >}}
