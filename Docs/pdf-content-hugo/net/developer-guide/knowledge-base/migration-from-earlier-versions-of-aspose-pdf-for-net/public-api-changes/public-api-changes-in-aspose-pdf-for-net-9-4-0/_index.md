---
title: Public API Changes in Aspose.Pdf for .NET 9.4.0
type: docs
weight: 40
url: /net/public-api-changes-in-aspose-pdf-for-net-9-4-0/
---

{{% alert color="primary" %}} 

These page lists public API changes that were introduced in Aspose.PDF for .NET 9.4.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
##### **Pages Property of PdfPageEditor**
PdfPageEditor.Pages property was renamed to ProcessPages.
The change was required to avoid names conflicts in COM.
##### **Public API changes**
PdfPageEditor class now contains ProcessPages property instead of Pages
##### **Usecase**
Following code snippet shows the property usage (sets zoom coefficient for page #1 of the document):

{{< highlight java >}}

 PdfPageEditor editor = new PdfPageEditor();

editor.BindPdf(TestSettings.GetInputFile("input.pdf"));

editor.Zoom = 0.5f;

editor.ProcessPages = new int[] { 1 };

string outFile = TestSettings.GetOutputFile("output.pdf");

editor.Save(outFile);

{{< /highlight >}}
##### **RValue property of RichTextBoxField**
RichTextBoxField.RValue property was renamed to RichTextValue.
The change was required to avoid names conflicts in COM.
##### **Public API changes**
RichTextBoxField class now contains RichTextValue property instead of RValue
##### **Usecase**
Following code snippet shows a sample where the renamed field was used:

{{< highlight java >}}

 Document doc = new Document("input.pdf");

RichTextBoxField rt = new RichTextBoxField(doc.Pages[1], new Rectangle(50, 600, 250, 650));

rt.PartialName = "rt";

doc.Form.Add(rt);

doc.Save(TestSettings.GetOutputFile("34834.pdf"));

Document doc1 = new Document(TestSettings.GetOutputFile("34834.pdf"));

(doc1.Form["rt"] as RichTextBoxField).RichTextValue = "<p>This is my <b>paragraph</b></p>";

doc1.Save("output.pdf");

{{< /highlight >}}
#### **Miscellaneous**
- **FontAbsorber** class was added to Aspose.PDF.Text namespace to extract fonts independently.
  The FontAbsorber class contains Visit(Aspose.PDF.Document) method that performs fonts search over the document
  Fonts collection is present in the FontAbsorber class. The collection contains fonts search result.
- **Save** method was added into **Font** class:
  Save(System.IO.Stream)
- **MemoryFontSource** class was added into Aspose.PDF.Text namespace
  the class provides a way to define font in a byte array with constructor: MemoryFontSource(System.Byte[])
- **FileFontSource** class was added into Aspose.PDF.Text namespace
  the class provides a way to define font as a file with constructor: FileFontSource(System.String)
- **FontSources** collection was added into Aspose.PDF.HtmlSaveOptions class
  The collection may be used to pass there previously pre-saved fonts via FontAbsorber
