---
title: Aspose.PDF for .NET 6.6.0 Release Notes
type: docs
weight: 100
url: /net/aspose-pdf-for-net-6-6-0-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 6.6.0](http://www.aspose.com/downloads/pdf/net/new-releases/aspose.pdf-for-.net-6.6.0/)

{{% /alert %}} 

We are pleased to share the new version of Aspose.PDF for .NET with following improvements.New Features

- PDFNEWNET-10208 PDF to PDF/A conversion
- PDFNEWNET-18912 Allow to create PDF Portfolio
- PDFNEWNET-22544 CGM to PDF conversion
- PDFNEWNET-26321 PDF to PDF/A-1a Conversion
- PDFNEWNET-30134 Allow to save the PDF to TIFF in A4 format instead of letter
  Enhancements
- PDFNEWNET-30957 Implement collections
- PDFNEWNET-32157 Support documents that contains broken cross-reference tables
- PDFNEWNET-32223 Conversion of PDF pages to Images is slow
- PDFNEWNET-32339 Extract images with initial bit depth instead of using 32 bit RGB always
- PDFNEWNET-32486 Implement support streams without Length property specified
- PDFNEWNET-29274 Size difference in output generated with 2 approaches
- PDFNEWNET-26709 Performance Investigation - DoConvert stucks at page number 4
- PDFNEWNET-32512 Investigate Web Content Accessibility Guidelines 1.0
- PDFNEWNET-31746 Facades.Form disposes the source stream on Save() call
- PDFNEWNET-32526 Investigate the increase in file size after replacing the image
## **Exceptions**
- PDFNEWNET-29890 ArgumentException when converting HTML file into PDF
- PDFNEWNET-30637 NullReferenceException while converitng HTML to PDF
- PDFNEWNET-30791 NullReferenceException is being generated when converting PCL files into PDF
- PDFNEWNET-30930 OutOfMemoryException when concatenating two large PDF documents
- PDFNEWNET-31025 ArgumentException when converting PDF file into DOC format
- PDFNEWNET-31693 Object Reference Exception in HTML2PDF conversion
- PDFNEWNET-32014 PDF to Tiff conversion throws Null reference exception
- PDFNEWNET-32123 UnHandled exception during PDF to Image conversion
- PDFNEWNET-32137 Exception while converting PDF to TIFF
- PDFNEWNET-32311 Object Not Found Exception
- PDFNEWNET-32521 Exception on PdfFileEditor.Concatenate method
- PDFNEWNET-32828 PCL2PDF conversion: System.ArgumentNullException was unhandled
- PDFNEWNET-32825 HTML2PDF conversion exception: System.ArgumentNullException: Key cannot be null
- PDFNEWNET-32742 Exception "Unable to cast object of type ...." in TiffDevice.Process() method
- PDFNEWNET-32844 ContentEditor.DeleteStampById method gives System.ArgumentNullReference Exception
- PDFNEWNET-32900 Exception "User password can't be same as owner password"
- PDFNEWNET-32931 Exception: Pdf document has not been provided yet or it was closed after changing document security properties
- PDFNEWNET-33013 Thread Safety Issue
- PDFNEWNET-32400 When we try to add the solicitation number to the right side of the header, a 'corrupt content' exception is thrown
- PDFNEWNET-32677 Value cannot be null.Parameter name: key
  Bugs
- PDFNEWNET-18331 The logo on the converted images is inverted
- PDFNEWNET-27304 CopyOuterField fails
- PDFNEWNET-29188 If IsHtmlTagSupported is set to True, only first Segment is being displayed
- PDFNEWNET-29459 Inset image on the converted PNG image shows background
- PDFNEWNET-29470 PdfConverter produces image of low quality
- PDFNEWNET-29587 Image is not being added to TextBoxField
- PDFNEWNET-29671 Bottom table border is being displayed twice
- PDFNEWNET-29766 Printed output is rotated 180 degrees
- PDFNEWNET-30167 Converting HTML to PDF (Value is null or empty error)
- PDFNEWNET-30191 Resultant PNG generated from PDF is not correct
- PDFNEWNET-30555 Text is corrupted on the images produced from the PDF file
- PDFNEWNET-30598 islandscape set to true issue with tables
- PDFNEWNET-30782 Fonts are not properly being detected in PDF document
- PDFNEWNET-30929 Large PDF documents are not being concatenated
- PDFNEWNET-30954 Multiline watermark is not being added to pdf
- PDFNEWNET-31314 Content missing on converting PDF to images
- PDFNEWNET-31366 Text is missing when converting PDF to images
- PDFNEWNET-31536 Table borders are bolder in resultant PDF when converted from HTML
- PDFNEWNET-31736 output is automatically rotated when printing PDF file to XPS
- PDFNEWNET-31744 PdfConverter dropping or mis-placing elements
- PDFNEWNET-31831 Empty document when Printed to XPS (v6.4.0)
- PDFNEWNET-31925 Highlight Annotations rendering oddly when converting Pdf Document to PNG Images
- PDFNEWNET-31968 HTML to PDF issue rendering unordered list to match HTML
- PDFNEWNET-31992 Blank Pages, misplaced contents while printing the PDF (6.4.2)
- PDFNEWNET-32038 Thai text get lost and scrambbled when converting PDF pages as images (PNG adn JPG format)
- PDFNEWNET-32120 Tables containing HTML Lists (OL/UL)
- PDFNEWNET-32129 TextFragmentAbsorber multithreading (Item has already been added. Key in dictionary: ' ' Key being added: ' '.)
- PDFNEWNET-32130 Files getting corrupt while using multi-threading
- PDFNEWNET-32145 Convert Image is Blank
- PDFNEWNET-32149 Attachments are not being added during PDF generation process
- PDFNEWNET-32173 Problem with converting html-Table
- PDFNEWNET-32196 Fill Text Fields in PDF Form
- PDFNEWNET-32213 Problem while creating Hyperlink inside PDF file
- PDFNEWNET-32217 HTML to PDF conversion results are not correct
- PDFNEWNET-32299 Table on subsequent pages is displaying on top of Page header
- PDFNEWNET-32313 Empty page Tiff while converting PDF to TIFF (Aspose.PDF for .NET v6.4.2)
- PDFNEWNET-32316 File is not properly converting to Tiff Image
- PDFNEWNET-32386 PDF rendered to image has some incorrect text
- PDFNEWNET-32387 HTML text is always beig displayed as center aligned
- PDFNEWNET-32397 Dummy bookmark adding after concatenation
- PDFNEWNET-32398 Headers (section title on the left of header) is NOT written when the orientaion of the page is Landscape
- PDFNEWNET-32423 Graph hides header in a generated PDF
- PDFNEWNET-32481 illegal charaters in path
- PDFNEWNET-32511 Unable to add metadata to PDF converted from PPT/PPTX
- PDFNEWNET-32522 Bad password!: v5.5.0.0 when Securing PDF file
- PDFNEWNET-32560 PDF to Jpeg or Tiff Conversion issue (v6.4.2)
- PDFNEWNET-32564 Error while converting PDF file to TIFF format
- PDFNEWNET-32565 File is Damaged aspose.pdf 6.4.2
- PDFNEWNET-32678 Pdf to Tiff Image is not fine
- PDFNEWNET-32679 Form FIelds are not returning properly (Adobe LifeCycle)
- PDFNEWNET-32728 Text with courier new font and size 7 is not displaying properly in generted PDF
- PDFNEWNET-32739 PDF to Tiff conversion. File with unreadable text / characters
- PDFNEWNET-32826 Conversion problem from PDF to PDF/A-1A
- PDFNEWNET-32908 Operator Q and Operator q issue with VB.NET
- PDFNEWNET-32914 Printing PDF is taking too much time and quality is low too
- PDFNEWNET-32988 Concatenate PDF files Issue
- PDFNEWNET-33014 PdfViewer.PrintDocumentWithSettings printing is not as per the template PDF file
- PDFNEWNET-30089 Text.TextWidth property is giving value -1
- PDFNEWNET-30225 PDF file size increases 40 times after clean the page number
- PDFNEWNET-32674 PDF Concatenate Issue
