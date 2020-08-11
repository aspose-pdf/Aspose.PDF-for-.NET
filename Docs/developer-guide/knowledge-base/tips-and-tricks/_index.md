---
title: Tips and Tricks
type: docs
weight: 60
url: /net/tips-and-tricks/
---

{{% alert color="primary" %}} 

This section contains information related to some tips and tricks that can be helpful when using Aspose.PDF for .NET

{{% /alert %}} 
## **Thread Access**
Access to a single document from several threads is not supported by our product. However, a document must be accessed only from a single thread.
## **Page Height and Points**
The page height and width properties use points as the basic unit, where 1 inch = 72 points and 1 cm = 1/2.54 inch = 0.3937 inch = 28.3 points.
## **Converting Points to Pixels**
The conversion from point to pixel depends on an image's DPI (dots per inch) property. For example, if an image's DPI is 96 (96 pixels for each inch), and it is 100 points high, its height in pixels is (100 / 72) * 96 = 133.3. The general formula is: pixels = ( points / 72 ) * DPI.
## **BaselinePosition & Position**
**BaselinePosition** - Gets text position for text, represented with TextFragment object. The YIndent of the Position structure represents baseline coordinate of the text fragment. The meaning of baseline in this case is the same to [Baseline (typography)](http://en.wikipedia.org/wiki/Baseline_\(typography\)).

**Position** - Gets or sets text position for text, represented with TextFragment" object. The YIndent of the Position structure represents [descent line](http://en.wikipedia.org/wiki/Descender) coordinate of the text fragment.

Therefore the difference between textFragment.Position.YIndent and textFragment.BaselinePosition.YIndent will be present and must be equal to font descent (see Font Descriptors issue of reference) represented in units of text coordinate system.

Position is a "default property" for working with text fragments / segments. However you can use BaselinePosition property as per your requirements.
## **Document Conversion**
The following simple code allows you to quickly convert PdfXML, Xsl-FO, HTML and SVG files into PDF format. This single method automatically detects the format of input file and renders the output in PDF format.

{{< highlight java >}}

 // Instantiate PDF object

Pdf pdf = new Pdf();

// Bind the source HTML file for conversion

pdf.ParseToPdf("c:/pdftest/sample.html");

// Save the output PDF document

pdf.Save("c:/pdftest/HTMLoutput.pdf");

{{< /highlight >}}
## **PDF Printing**
When printing PDF files that contain text and you want the contents to appear as text instead of vector graphics, please try using the following code.

- If the document does not contain embedded fonts, it is possible to embed system fonts into the document being printed:

{{< highlight java >}}

 PdfViewer pdfViewer = new PdfViewer();

// Render all system fonts with native system approach (embed the fonts to output documents)

pdfViewer.RenderingOptions.SystemFontsNativeRendering = true;

...

pdfViewer.PrintDocumentWithSettings(...);

{{< /highlight >}}



- For documents that have embedded fonts, the quality also can be improved and fonts are embedded to the document. We have introduced a feature that allows to substitute embedded fonts with system fonts. To substitute the same named fonts please use following code snippet:

{{< highlight java >}}

 // Substitute all embedded fonts with system fonts that names are equal

FontRepository.Substitutions.Add(new SystemFontsSubstitution(SubstitutionFontCategories.TheSameNamedEmbeddedFonts));

PdfViewer pdfViewer = new PdfViewer();

// Render all system fonts with native system approach (embed the fonts to output documents)

pdfViewer.RenderingOptions.SystemFontsNativeRendering = true;

...

pdfViewer.PrintDocumentWithSettings(...);

{{< /highlight >}}
## **Reading XFA Fields**
If the source PDF file contains XFA form fields, the following code snippet can be used to read them as we cannot be read them with Aspose.PDF.InteractiveFeatures.Forms.Field.

{{< highlight java >}}

 Aspose.PDF.Document d = new Aspose.PDF.Document("c:/pdftest/input.pdf");

{

foreach (string field in d.Form.XFA.FieldNames)

{ Console.WriteLine(field); }

}

{{< /highlight >}}
## **Get the Page Number Associated with a Bookmark**
If a source PDF file contains bookmarks and you need to get the information regarding their destination page number, then try using the Aspose.PDF.Facades.Bookmark class' PageNumber property.

{{< highlight java >}}

 string strDocDir = @"C:\pdftest\";

string strDocName = "Input_Bookmarked.pdf";

string strFilePath = strDocDir + strDocName;

// Create PdfBookmarkEditor

PdfBookmarkEditor bookmarkEditor = new PdfBookmarkEditor();

// Open PDF file

bookmarkEditor.BindPdf(strFilePath);

// Extract bookmarks

Aspose.PDF.Facades.Bookmarks bookmarks = bookmarkEditor.ExtractBookmarks();

foreach (Aspose.PDF.Facades.Bookmark bookmark in bookmarks)

{

    string strLevelSeprator = string.Empty;

    for (int i = 1; i < bookmark.Level; i++)

    {

        strLevelSeprator += "----";

    }

    Console.WriteLine("{0}Title: {1}", strLevelSeprator, bookmark.Title);

    Console.WriteLine("{0}Page Number: {1}", strLevelSeprator, bookmark.PageNumber);

    Console.WriteLine("{0}Page Action: {1}", strLevelSeprator, bookmark.Action);

}

{{< /highlight >}}
## **Adding Bookmarks**
The code snippet specified below is an appropriate manner of adding bookmarks in PDF file.

{{< highlight java >}}

  Document doc = new Document("input.pdf");

OutlineItemCollection bookmark = new OutlineItemCollection(doc.Outlines);

bookmark.Title = "bookmark1";

// Bookmark.Action = new GoToAction(1); <-- use next line instead of this one.

bookmark.Action = new GoToAction(doc.Pages[1]);

doc.Outlines.Add(bookmark);

doc.Save("Output_Bookmarked.pdf");

{{< /highlight >}}
## **Use TrueType font during HTML to PDF conversion**
If the source HTML contains a TrueType font and you need the font to appear in the output PDF, use the following code line before saving the PDF file.

{{< highlight java >}}

 // Use the style from TextInfo

text1.UseTextInfoStyle = true;

{{< /highlight >}}
## **Get the Zoom factor of PDF file**
In order to get the Zoom factor/value of PDF file, please try using the following code snippet.

{{< highlight java >}}

 // Instantaite new Document object

Document doc = new Document("Zoomed_pdf.pdf");

// Create GoToAction object

GoToAction action = doc.OpenAction as GoToAction;

// Get the Zoom factor of PDF file

Console.WriteLine((action.Destination as XYZExplicitDestination).Zoom); // Document zoom value;

{{< /highlight >}}

Please note that before you try to get the zoom value of PDF file, ensure that zoom factor is assigned to PDF file, else an exception will be generated.

You try using the following code snippet to add zoom factor for PDF file.

{{< highlight java >}}

 double zoom = 5;

Document doc = new Document("input.pdf");

GoToAction action = new GoToAction();

action.Destination = new XYZExplicitDestination(doc, 0, 0, 0, zoom);

doc.OpenAction = action;

doc.Save("Zoomed_pdf.pdf");

{{< /highlight >}}
