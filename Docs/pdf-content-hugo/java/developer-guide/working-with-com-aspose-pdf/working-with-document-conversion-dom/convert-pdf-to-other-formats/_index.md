---
title: Convert PDF to other Formats
type: docs
weight: 30
url: /java/convert-pdf-to-other-formats/
---

## **Convert PDF to PDF-A format**
Aspose.PDF allows you to convert a PDF file to a PDF/A compliant PDF file. Before doing so, the file must be validated. This article explains how.

Please note we follow Adobe Preflight for validating PDF/A conformance. All tools on the market have their own "representation" of PDF/A conformance. Please check this article on [PDF/A validation tools](http://wiki.opf-labs.org/display/SPR/PDFA+Validation+tools+give+different+results) for reference. We chose Adobe products for verifying how Aspose.PDF produces PDF files because Adobe is at the center of everything connected to PDF.

Convert the file using the Document class' convert method.

Before converting the PDF to a PDF/A compliant file, validate the PDF using the validate method. The validation result is stored in an XML file and then this result is also passed to the convert method. You can also specify the action for the elements which can not be converted using the ConvertErrorAction enumeration.
### **PDF to PDF/A_1b Conversion**
The following code snippet shows how to convert PDF files to PDF/A-1b compliant PDF.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToPDFAFormat-PDFToPDFA1bConversion.java" >}}
### **PDF to PDF/A_3b Conversion**
From [Aspose.PDF for Java 9.3.0](https://downloads.aspose.com/pdf/java), the API also supports converting PDF files to PDF/A_3b format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-docconversion-ConvertPDFToPDFAFormat-PDFToPDFA3bConversion.java" >}}
### **PDF to PDF/A_3a Conversion**
From [Aspose.PDF for Java 10.6.0](https://downloads.aspose.com/pdf/java), the API also supports converting PDF files to PDF/A_3a format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToPDFAFormat-PDFToPDFA3aConversion.java" >}}
### **PDF to PDF/A_2a Conversion**
Starting release of [Aspose.PDF for Java 10.2.0](https://downloads.aspose.com/pdf/java), the API offers the feature to convert PDF files to PDF/A3 format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToPDFAFormat-PDFToPDFA2aConversion.java" >}}
### **PDF to PDF/A_3U Conversion**
Starting release of Aspose.PDF for Java 17.2.0, the API offers the feature to convert PDF files to PDF/A_3U format.

**Java**

{{< highlight java >}}

 Document doc = new Document("inFile.pdf"); 

PdfFormatConversionOptions opts = new PdfFormatConversionOptions("outLog.txt", PdfFormat.PDF_A_3U, ConvertErrorAction.Delete);

doc.convert(opts);

doc.save("outFile.pdf");

{{< /highlight >}}


### **Create PDF/A-3 and attach XML file**
Aspose.PDF for Java offers the feature to convert PDF files to PDF/A format and it also supports the capabilities of adding files as an attachment to PDF document. In case you have a requirement to attach files to PDF/A compliance format, then we recommend using PDF_A_3A value from com.aspose.pdf.PdfFormat enumeration, as according to [this post in Adobe community](https://forums.adobe.com/thread/868219), PDF/A_3a is the format that provides the feature to attach any file format as an attachment to PDF/A compliant file. However, once the file is attached, you should convert it into Pdf-3a format again, in order to fix metadata. Please take a look over the following code snippet.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToPDFAFormat-CreatePDFA3AndAttachXMLFile.java" >}}
## **Convert PDF to EPUB format**
{{% alert color="primary" %}} 

EPUB (short for electronic publication) is a free and open e-book standard from the International Digital Publishing Forum (IDPF). Files have the extension .epub.EPUB is designed for reflowable content, meaning that an EPUB reader can optimize text for a particular display device. EPUB also supports fixed-layout content. The format is intended as a single format that publishers and conversion houses can use in-house, as well as for distribution and sale. It supersedes the Open eBook standard.

{{% /alert %}} 

Aspose.PDF for Java supports the feature to convert PDF documents to EPUB format. Aspose.PDF for Java has a class named [EpubSaveOptions](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/EpubSaveOptions) which can be used as the second argument to the [Document](http://www.aspose.com/api/java/pdf/com.aspose.pdf/classes/Document).save(..) method, to generate an EPUB file. Please try using the following code snippet to accomplish this requirement.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToEPUBFormat-.java" >}}
## **Convert PDF to SVG format**
Scalable Vector Graphics (SVG) is a family of specifications of an XML-based file format for two-dimensional vector graphics, both static and dynamic (interactive or animated). The SVG specification is an open standard that has been under development by the World Wide Web Consortium (W3C) since 1999.

SVG images and their behaviors are defined in XML text files. This means that they can be searched, indexed, scripted and if required, compressed. As XML files, SVG images can be created and edited with any text editor, but it is often more convenient to create them with drawing programs such as Inkscape.

Aspose.PDF for Java supports the feature to convert PDF file to SVG format. To accomplish this requirement, the [SvgSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/SvgSaveOptions) class has been introduced into the com.aspose.pdf package. Instantiate an object of [SvgSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/SvgSaveOptions) and pass it as a second argument to the [Document](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Document).save(..) method.

The following code snippet shows the steps for converting a PDF file to SVG format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToSVGFormat-.java" >}}
## **Convert PDF to XML format**
Aspose.PDF for Java offers the feature to transform XML file to PDF format and also the feature to convert PDF documents to XML. The XML schema corresponds to the ebook MobiXML standard.
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
### **PDF to XML Conversion**
The following code snippet shows the process of converting a PDF file to an XML (MobiXML) format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFToXML-.java" >}}

Once the PDF file is converted to XML format, we need to verify that either the conversion is correctly performed or not. In order to cater to this requirement, you need to convert the MobiXML file to XPS format. The resultant **.xps** file can be viewed with any XPS-viewer to ensure that MobiXML files generated with Aspose.PDF for Java are correct.

In case the source PDF contains images, they are represented as separate files (filename_picN.jpg|png) in the directory where output XML is created. Also, the fonts are represented as True Type fonts and corresponding files (filename_fontN.ttf) are created along the output XML. Where N is order number (1, 2, ...).
## **Convert PDF to XPS format**
{{% alert color="primary" %}} 

The XPS file type is primarily associated with the XML Paper Specification by Microsoft Corporation. The XML Paper Specification (XPS), formerly codenamed Metro and subsuming the Next Generation Print Path (NGPP) marketing concept, is Microsoft's initiative to integrate document creation and viewing into the Windows operating system.

{{% /alert %}} 

To convert PDF files to XPS, Aspose.PDF has the class [XpsSaveOptions](https://apireference.aspose.com/java/pdf/com.aspose.pdf/XpsSaveOptions) class that is used as the second argument to the Document.save(..) constructor to generate the XPS file. The following code snippet shows the process of converting PDF files into XPS format.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-docconversion-ConvertPDFFileIntoXPSFormat-.java" >}}
### **Keep Text Selectable in Output XPS**
The XpsSaveOptions class also provides the ability to control the text selection in output XPS. The SaveTransparentTexts property can be set in order to achieve this as shown in the following code sample.



{{< gist "aspose-com-gists" "282750bc23ba43d2659ba38470239283" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdfExamples-DocumentConversion-ConvertPDFFileIntoXPSFormat-KeepingTextSelectableInConvertedXPS.java" >}}
## **Convert PDF to EMF format**
Using EmfDevice class we can convert a PDF file to EMF format. The following code snippet shows the process of converting a PDF file to an EMF format.
