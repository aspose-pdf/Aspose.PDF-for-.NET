---
title: Convert PDF file to other Formats
type: docs
weight: 70
url: /net/convert-pdf-file-to-other-formats/
---
## **Convert PDF file to other Formats**

### **Convert PDF File to PDF-A**
Aspose.PDF allows you to convert a PDF file to a PDF/A compliant PDF file. Before doing so, the file must be validated. This topic explains how.

{{% alert color="primary" %}} 

Please note we follow Adobe Preflight for validating PDF/A conformance. All tools on the market have their own "representation" of PDF/A conformance. Please check this article on [PDF/A validation tools](http://wiki.opf-labs.org/display/SPR/PDFA+Validation+tools+give+different+results) for reference. We chose Adobe products for verifying how Aspose.PDF produces PDF files because Adobe is at the center of everything connected to PDF.

{{% /alert %}} 

Convert the file using the [Document](https://apireference.aspose.com/net/pdf/aspose.pdf/document) class [Convert](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/convert) method. Before converting the PDF to PDF/A compliant file, validate the PDF using the [Validate](https://apireference.aspose.com/net/pdf/aspose.pdf/document/methods/validate) method. The validation result is stored in an XML file and then this result is also passed to the [Convert](http://www.aspose.com/api/net/pdf/aspose.pdf/document/methods/convert/index) method. You can also specify the action for the elements which cannot be converted using the [ConvertErrorAction](https://apireference.aspose.com/net/pdf/aspose.pdf/converterroraction) enumeration.
### **Convert PDF file to PDF/A-1b**
The following code snippet shows how to convert PDF files to PDF/A-1b compliant PDF.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToPDFA-PDFToPDFA.cs" >}}

To perform validation only, use the following line of code:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-ValidatePDFABStandard-ValidatePDFABStandard.cs" >}}
### **Convert PDF file to PDF/A-3b**
Aspose.PDF for .NET also supports the feature to convert a PDF file to PDF/A-3b format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToPDFA3b-PDFToPDFA3b.cs" >}}
### **Convert PDF file to PDF/A-2u**
Aspose.PDF for .NET also supports the feature to convert a PDF file to PDF/A-2u format.

**C#**

{{< highlight csharp >}}

 string inFile = "input.pdf";

string outFile = "output.pdf";

Aspose.PDF.Document doc = new Aspose.PDF.Document(inFile);

doc.Convert(new MemoryStream(), PdfFormat.PDF_A_2U, ConvertErrorAction.Delete);

doc.Save(outFile);

{{< /highlight >}}
### **Convert PDF file to PDF/A-3u**
Aspose.PDF for .NET also supports the feature to convert a PDF file to PDF/A-3u format.

**C#**

{{< highlight csharp >}}

 string inFile = "input.pdf";

string outFile = "output.pdf";

Aspose.PDF.Document doc = new Aspose.PDF.Document(inFile);

doc.Convert(new MemoryStream(), PdfFormat.PDF_A_3U, ConvertErrorAction.Delete);

doc.Save(outFile);

{{< /highlight >}}
### **Add Attachment to PDF/A file**
In case you have a requirement to attach files to PDF/A compliance format, then we recommend using **PDF_A_3A** value from **Aspose.PDF.PdfFormat** enumeration, as according to [this post in Adobe community](https://forums.adobe.com/thread/868219), PDF/A_3a is the format that provides the feature to attach any file format as an attachment to PDF/A compliant file.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-AddAttachmentToPDFA-AddAttachmentToPDFA.cs" >}}
### **Replace missing fonts with alternative fonts**
As per PDFA standards, fonts should be embedded in PDFA document. However, if the fonts are not embedded in the source document or exist on the machine then PDFA fails the validation. In this case, we have a requirement to substituent missing fonts with some alternative fonts from the machine. We can substitute missing fonts using the SimpleFontSubsituation method as following during PDF to PDFA conversion.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-ReplaceMissingFonts-ReplaceMissingFonts.cs" >}}
## **Convert PDF to TeX Format**
The LaTeX file format is a text file format with markup in the LaTeX 2ε derivative of the TeX family of languages and LaTeX is a derived format of the TeX system.

To convert PDF files to TeX, Aspose.PDF has the class [LaTeXSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/latexsaveoptions) which provides the property OutDirectoryPath for saving temporary images during the conversion process.

The following code snippet shows the process of converting PDF files into the TEX format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToTeX-PDFToTeX.cs" >}}
## **Convert PDF to EPUB Format in C#**
EPUB (short for electronic publication) is a free and open e-book standard from the International Digital Publishing Forum (IDPF). Files have the extension .epub.
EPUB is designed for reflowable content, meaning that an EPUB reader can optimize text for a particular display device. EPUB also supports fixed-layout content. The format is intended as a single format that publishers and conversion houses can use in-house, as well as for distribution and sale. It supersedes the Open eBook standard.

Aspose.PDF for .NET also supports the feature to convert PDF documents to EPUB format. Aspose.PDF for .NET has a class named EpubSaveOptions which can be used as the second argument to Document.Save(..) method, to generate an EPUB file. Please try using the following code snippet to accomplish this requirement.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToEPUB-PDFToEPUB.cs" >}}
## **Convert PDF to XPS Format**
The XPS file type is primarily associated with the XML Paper Specification by Microsoft Corporation. The XML Paper Specification (XPS), formerly codenamed Metro and subsuming the Next Generation Print Path (NGPP) marketing concept, is Microsoft's initiative to integrate document creation and viewing into the Windows operating system.

To convert PDF files to XPS, Aspose.PDF has the class [XpsSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/xpssaveoptions) that is used as the second argument to the Document.Save(..) constructor to generate the XPS file. The following code snippet shows the process of converting PDF file into XPS format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToXPS-PDFToXPS.cs" >}}

.
## **Convert PDF to Word DOC**
Convert PDF file to DOC format with ease and full control. Aspose.PDF for .NET is flexible and supports a wide variety of conversions. Converting pages from PDF documents to images, for example, is a very popular feature.

A conversion that many of our customers have requested is PDF to DOC: converting a PDF file to a Microsoft Word document. Customers want this because PDF files cannot easily be edited, whereas Word documents can. Some companies want their users to be able to manipulate text, tables, and images in files that started as PDFs.

Keeping alive the tradition of making things simple and understandable, Aspose.PDF for .NET lets you transform a source PDF file into a DOC file with two lines of code. To accomplish this feature, we have introduced an enumeration named SaveFormat and its value .Doc lets you save the source file to Microsoft Word format.

The following code snippet shows the process of converting PDF files into DOC.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToDOC-PDFToDOC.cs" >}}
### **Using the DocSaveOptions Class**
The [DocSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/docsaveoptions) class provides numerous properties that improve the process of converting PDF files to DOC format. Among these properties, Mode enables you to specify the recognition mode for PDF content. You can specify any value from the RecognitionMode enumeration for this property. Each of these values has specific benefits and limitations:

- Textbox mode is fast and good for preserving the original look of the PDF file, but the editability of the resulting document could be limited. Every visually grouped block of text in the original PDF is converted into a textbox in the output document. This achieves a maximal resemblance to the original so the output document looks good, but it consists entirely of textboxes and it could make editing in Microsoft Word quite hard.
- Flow is full recognition mode, where the engine performs grouping and multi-level analysis to restore the original document as per the author's intent while producing an easily editable document. The limitation is that the output document might look different from the original.
- The RelativeHorizontalProximity property can be used to control the relative proximity between textual elements and means that distance is normed by the font size. Larger fonts may have bigger distances between syllables and still be looked at as a single whole. It is specified as a percentage of the font size, for example, 1 = 100%. This means that two characters of 12pt that are placed 12 pt apart are proximal.
- RecognitionBullets is used to switch on the recognition of bullets during conversion.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToDOC-SaveUsingSaveOptions.cs" >}}
## **Convert PDF to Word DOCX in C#**
Aspose.PDF for .NET API lets you read and convert PDF documents to [DOCX](https://wiki.fileformat.com/word-processing/docx/) using C# and any .NET language. Docx is a well-known format for Microsoft Word documents whose structure was changed from plain binary to a combination of XML and binary files. Docx files can be opened with Word 2007 and lateral versions but not with the earlier versions of MS Word which support DOC file extensions.  

The [DocSaveOptions](https://apireference.aspose.com/net/pdf/aspose.pdf/docsaveoptions) class has a property named Format which provides the capability to specify the format of the resultant document, that is, DOC or DOCX. In order to convert a PDF file to DOCX format, please pass the Docx value from the DocSaveOptions.DocFormat enumeration. Please take a look over the following code snippet which provides the capability to convert PDF file to DOCX format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToDOC-ConvertToDOCX.cs" >}}
## **Convert PDF to SVG Format**
Scalable Vector Graphics (SVG) is a family of specifications of an XML-based file format for two-dimensional vector graphics, both static and dynamic (interactive or animated). The SVG specification is an open standard that has been under development by the World Wide Web Consortium (W3C) since 1999.

SVG images and their behaviors are defined in XML text files. This means that they can be searched, indexed, scripted and if required, compressed. As XML files, SVG images can be created and edited with any text editor, but it is often more convenient to create them with drawing programs such as Inkscape.

Aspose.PDF for .NET supports the feature to convert SVG image to PDF format and also offers the capability to convert PDF files to SVG format. To accomplish this requirement, the SvgSaveOptions class has been introduced into the Aspose.PDF namespace. Instantiate an object of SvgSaveOptions and pass it as a second argument to the Document.Save(..) method.

The following code snippet shows the steps for converting a PDF file to SVG format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToSVG-PDFToSVG.cs" >}}
## **Convert PDF to XML**
With Aspose.PDF for .NET, it is possible to convert PDF documents to XML. 
### **Schema**
The schema is extended with the ability to use external fonts. Furthermore, when converting PDF files to XML, images are represented as separate files in the same directory as the output XML is created. Fonts are represented as TrueType fonts and the corresponding files (**filename_fontN.ttf**) are created along with the output XML.

XML is formed in accordance with the DTD schema specified below:

**XML**

{{< highlight csharp >}}

 <xs:schema attributeFormDefault="unqualified" elementFormDefault="qualified" xmlns:xs="http://www.w3.org/2001/XMLSchema">

  <xs:element name="pdf2xml">

    <xs:complexType>

      <xs:sequence>

        <xs:element type="xs:string" name="title"/>

        <xs:element name="page" maxOccurs="unbounded" minOccurs="0">

          <xs:complexType>

            <xs:sequence>

              <xs:element name="font" maxOccurs="unbounded" minOccurs="0">

                <xs:complexType>

                  <xs:sequence>

                    <xs:element name="text" maxOccurs="unbounded" minOccurs="0">

                      <xs:complexType>

                        <xs:simpleContent>

                          <xs:extension base="xs:string">

                            <xs:attribute type="xs:float" name="x" use="optional"/>

                            <xs:attribute type="xs:float" name="y" use="optional"/>

                            <xs:attribute type="xs:float" name="width" use="optional"/>

                            <xs:attribute type="xs:float" name="height" use="optional"/>

                          </xs:extension>

                        </xs:simpleContent>

                      </xs:complexType>

                    </xs:element>

                    <xs:element name="img" minOccurs="0">

                      <xs:complexType>

                        <xs:simpleContent>

                          <xs:extension base="xs:string">

                            <xs:attribute type="xs:float" name="x" use="optional"/>

                            <xs:attribute type="xs:float" name="y" use="optional"/>

                            <xs:attribute type="xs:float" name="width" use="optional"/>

                            <xs:attribute type="xs:float" name="height" use="optional"/>

                            <xs:attribute type="xs:string" name="src" use="optional"/>

                          </xs:extension>

                        </xs:simpleContent>

                      </xs:complexType>

                    </xs:element>

                  </xs:sequence>

                  <xs:attribute type="xs:float" name="size" use="optional"/>

                  <xs:attribute type="xs:string" name="face" use="optional"/>

                  <xs:attribute type="xs:string" name="src" use="optional"/>

                  <xs:attribute type="xs:string" name="color" use="optional"/>

                  <xs:attribute type="xs:boolean" name="italic" use="optional"/>

                  <xs:attribute type="xs:boolean" name="bold" use="optional"/>

                </xs:complexType>

              </xs:element>

            </xs:sequence>

            <xs:attribute type="xs:short" name="width" use="optional"/>

            <xs:attribute type="xs:short" name="height" use="optional"/>

          </xs:complexType>

        </xs:element>

      </xs:sequence>

      <xs:attribute type="xs:byte" name="pages"/>

    </xs:complexType>

  </xs:element>

</xs:schema>

{{< /highlight >}}

The following code snippet shows the process of converting a PDF file to XML (MobiXML) format.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFToXML-PDFToXML.cs" >}}
{{% alert color="primary" %}} 

Once the PDF file is converted to XML format, we need to verify that either the conversion is correctly performed or not. In order to cater this requirement, we have created a utility to convert XML contents to XPS format. Please find attached the **AsposeMobiXmlToXpsConverter.zip** archive which contains **AsposeMobiXmlToXpsConverter.exe** utility to convert MobiXML file to XPS format. The resultant **.xps** file can be viewed with any XPS-viewer to ensure that MobiXML files generated with Aspose.PDF for .NET are correct. In attached .zip package, you can find a file *start.bat* which contains the path for AsposeMobiXmlToXpsConverter.exe utility and the path of input XML, which is provided as an argument to this utility.

In case the source PDF contains images, they are represented as separate files (filename_picN.jpg|png) in the directory where output xml is created. Also the fonts are represented as True Type fonts and corresponding files (filename_fontN.ttf) are created along the output XML. Where N is order number (1, 2, ...).
{{% /alert %}} 

## **Convert PDF-A file to PDF**
Aspose.PDF for .NET provides the feature to transform PDF files to PDF/A compliant format and similarly, it also offers the feature to convert PDF/A file to PDF format.

{{% alert color="primary" %}} 

Please note we follow Adobe Preflight for validating PDF/A conformance. All tools on the market have their own "representation" of PDF/A conformance. Please check this article on [PDF/A validation tools](http://wiki.opf-labs.org/display/SPR/PDFA+Validation+tools+give+different+results) for reference. We chose Adobe products for verifying how Aspose.PDF produces PDF files because Adobe is at the center of everything connected to PDF.

{{% /alert %}} 

In order to perform the conversion, the PDF compliance information is removed from the input/source file using RemovePdfaCompliance(..) method of the Document object.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-DocumentConversion-PDFAToPDF-PDFAToPDF.cs" >}}
