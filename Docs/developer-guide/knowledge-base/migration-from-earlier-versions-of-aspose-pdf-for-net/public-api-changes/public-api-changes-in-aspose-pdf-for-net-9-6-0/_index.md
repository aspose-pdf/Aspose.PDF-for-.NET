---
title: Public API Changes in Aspose.Pdf for .NET 9.6.0
type: docs
weight: 50
url: /net/public-api-changes-in-aspose-pdf-for-net-9-6-0/
---

{{% alert color="primary" %}} 

These page lists public API changes that were introduced in [Aspose.PDF for .NET 9.6.0](http://www.aspose.com/community/files/51/.net-components/aspose.pdf-for-.net/entry570840.aspx). It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 
#### **Breaking change: Some untyped public API members has become typed**
##### **AppearanceDictionary class changes:**
Typed indexer was added into AppearanceDictionary class:

{{< highlight java >}}

 public XForm this[string key]

{{< /highlight >}}

Previous indexer version was marked as obsolete:

{{< highlight java >}}

 public XForm this[objectkey]

{{< /highlight >}}

Following typed methods were added into into AppearanceDictionary class:

{{< highlight java >}}

 void Add(System.String,Aspose.PDF.XForm)

bool ContainsKey(System.String)

bool Remove(System.String)

bool TryGetValue(System.String, out Aspose.PDF.XForm)

void Add(System.Collections.Generic.KeyValuePair<System.String,Aspose.PDF.XForm>)

bool Contains(System.Collections.Generic.KeyValuePair<System.String,Aspose.PDF.XForm>)

void CopyTo(System.Collections.Generic.KeyValuePair<string, XForm>[] array,System.Int32)

bool Remove(System.Collections.Generic.KeyValuePair<System.String,Aspose.PDF.XForm>)

{{< /highlight >}}

Following untyped methods were marked as obsolete:

{{< highlight java >}}

 void Add(Object key, Object value)

bool Contains(Object key)

void Remove(Object key)

{{< /highlight >}}
##### **InkAnnotation class changes:**
Typed constructor was added for InkAnnotation class:

{{< highlight java >}}

 public InkAnnotation(Page page, Rectangle rect, IList<Point[]> inkList)

{{< /highlight >}}

Untyped constructor was marked as obsolete:

{{< highlight java >}}

 public InkAnnotation(Page page, Rectangle rect, IList inkList)

{{< /highlight >}}

Return type was changed for InkList property:

{{< highlight java >}}

 public IList<Point[]> InkList

{{< /highlight >}}

Previous untyped property version was removed (becuse it is not possible to leave both properties - new and old with different return types)

{{< highlight java >}}

 public IList InkList

{{< /highlight >}}
##### **Other changes**
Typed Remove method was added into Aspose.PDF.Cells class:

{{< highlight java >}}

 Remove(Aspose.PDF.Cell)

{{< /highlight >}}

Untyped method version was marked as obsolete:

{{< highlight java >}}

 Remove(System.Object)

{{< /highlight >}}

RadiusForRoundCorner property was added into Aspose.PDF.Drawing.Rectangle class

Following code snippet shows how to use RadiusForRoundCorner property:

{{< highlight java >}}

 string outFile = "36624.pdf";

Document doc = new Document();

Page page = doc.Pages.Add();

Graph root = new Graph(100, 100);

Drawing.Rectangle rect = new Drawing.Rectangle(0, 0, 100, 100);

rect.GraphInfo.Color = Color.Blue;

rect.RadiusForRoundCorner = 10;

root.Shapes.Add(rect);

page.Paragraphs.Add(root);

doc.Save(outFile);

{{< /highlight >}}
##### **Left and Top properties were added into Aspose.PDF.Drawing.Graph class**
Following code snippet shows how to use Left, Top properties:

{{< highlight java >}}

 string outFile = "36625.pdf";

Document doc = new Document();

Page page = doc.Pages.Add();

Graph root = new Graph(100, 100);

root.Left = 300;

root.Top = 300;

Drawing.Rectangle rect = new Drawing.Rectangle(0, 0, 100, 100);

root.Shapes.Add(rect);

page.Paragraphs.Add(root);

doc.Save(outFile);

{{< /highlight >}}
##### **CalculateContentBBox method was added into Aspose.PDF.Page object**
Following code snippet shows how to trim whitespace from Pdf document:

{{< highlight java >}}

 Document document = new Document(inFile);

Page pdfPage = document.Pages[1];

Rectangle contentBBox = pdfPage.CalculateContentBBox();

document.Pages[1].CropBox = contentBBox;

document.Pages[1].MediaBox = contentBBox;

document.Save(outFile);

{{< /highlight >}}
##### **ResizeContents method that accepts Document object was added into PdfFileEditor class:**
{{< highlight java >}}

 ResizeContents(doc, parameters);

{{< /highlight >}}

Following code snippet shows how to use ResizeContents(doc, parameters) method:

{{< highlight java >}}

 //Create PdfFileEditor Object

PdfFileEditor fileEditor = new PdfFileEditor();

//Open PDF Document

Aspose.PDF.Document doc = new Aspose.PDF.Document(TestSettings.GetInputFile("PdfWithImages.pdf"));

//Specify Parameter to be used for resizing

PdfFileEditor.ContentsResizeParameters parameters = new PdfFileEditor.ContentsResizeParameters(

    //left margin = 10% of page width

PdfFileEditor.ContentsResizeValue.Percents(30),

    //new contents width calculated automatically as width - left margin - right margin (100% - 10% - 10% = 80%)

null,

    //right margin is 10% of page

PdfFileEditor.ContentsResizeValue.Percents(30),

    //top margin = 10% of height

PdfFileEditor.ContentsResizeValue.Percents(30),

    //new contents height is calculated automatically (similar to width)

null,

    //bottom margin is 10%

PdfFileEditor.ContentsResizeValue.Percents(30)

);

//Resize Page Contents

fileEditor.ResizeContents(doc, parameters);

//save document into new location.

doc.Save(TestSettings.GetOutputFile("37335.pdf"));

{{< /highlight >}}
##### **ExternalResourcesCredentials property was added into HtmlLoadOptions class**
Following code snippet shows how to pass credentials to request HTML and HTML resources during Html->Pdf conversion:

{{< highlight java >}}

 // Create a request for the URL.

WebRequest request = WebRequest.Create("http://mercy.signchart.com/Report/PrintBook.asp?ProjectGuid=6FB9DBB0-5484-4BA9-85CA-859BFDB2AB7C&WorkSpaceGuid=0DD6BDD8-6916-4C93-AD1E-DF921434F536");

// If required by the server, set the credentials.

request.Credentials = CredentialCache.DefaultCredentials;

// Get the response.

HttpWebResponse response = (HttpWebResponse)request.GetResponse();

// Get the stream containing content returned by the server.

Stream dataStream = response.GetResponseStream();

// Open the stream using a StreamReader for easy access.

StreamReader reader = new StreamReader(dataStream);

// Read the content.

string responseFromServer = reader.ReadToEnd();

reader.Close();

dataStream.Close();

response.Close();

MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(responseFromServer));

HtmlLoadOptions options = new HtmlLoadOptions("http://mercy.signchart.com/");

options.ExternalResourcesCredentials = CredentialCache.DefaultCredentials;

// use the new conversion engine

options.UseNewConversionEngine = true;

// load HTML file

Document pdfDocument = new Document(stream, options);

{{< /highlight >}}
##### **PartsEmbeddingModes enumeration was added into Aspose.PDF.HtmlSaveOptions class.**
The PartsEmbeddingModes enumeration includes following values:

**EmbedAllIntoHtml** 
Enforces embed all referenced files(Css,Images,Fonts) into generated HTML markup (i.e. into HTML itself)
This approach generates one HTML file, but total size of output
becames bigger(because Base64 encoding of binaries is in use) and not all browsers (especially legacy)
successfully process binaries embedded into HTML. But it allows get HTML that contains whole result, without any additional files.

**EmbedCssOnly** 
Enforces put apart all referenced files except CSS (Images and Fonts)
I.e. CSS will be embedded into result HTML , and all other referenced files(Images and Fonts)
will be processed as external parts
It generates HTML that is suitable for wide set of browsers

**NoEmbedding** 
Enforces put apart referenced files(Css,Images,Fonts)
This approach generates set of files, but total size of output
becomes smaller(because no Base64 encoding of binaries is in use)
Also such approach generates HTML that is suitable for wide set of browsers

Following code snippet demonstrates how to embed all resources into html:

{{< highlight java >}}

 Document doc = new Document(@"F:\ExternalTestsData\36608.pdf");

HtmlSaveOptions newOptions = new HtmlSaveOptions();

// this is usage of tested feature

newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml;

// this is just optimozation for IE and can be omitted 

newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;

newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;

newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;

//

string outHtmlFile = @"F:\ExternalTestsData\36340.html";

doc.Save(outHtmlFile, newOptions);

{{< /highlight >}}

Following code snippet demonstrates how to embed CSS into the html file:

{{< highlight java >}}

 Document doc = new Document(@"F:\ExternalTestsData\36608.pdf");

HtmlSaveOptions newOptions = new HtmlSaveOptions();

// this is usage of tested feature

newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedCssOnly;

// this is just optimozation for IE and can be omitted 

newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;

newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;

newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;

//

string outHtmlFile = @"F:\ExternalTestsData\36608.html";

doc.Save(outHtmlFile, newOptions);

{{< /highlight >}}
##### **GraphInfo property of Aspose.PDF.Drawing.Graph class is marked as obsolete.**
GraphInfo properties of Shape objects of Graph.Shapes collection should be used instead.

Following code snippet shows how to use GraphInfo properties of a Graph's Shape.

{{< highlight java >}}

 Document doc = new Document();

Helper.SetLicense();

//Create a section in the Pdf document

Page page = doc.Pages.Add();

//Create a graph in the section with Width=100 and Height=400

Graph graph1 = new Graph(50, 150);

//Add the graph object to paragraphs collection of the section

page.Paragraphs.Add(graph1);

float[] lineArr = new float[] {110, 10, 10, 10, 10, 110, 110, 110};

Line line = new Line(lineArr);

line.GraphInfo.LineWidth = 10;

//Set fill color of the circle using GraphInfo property of circle object

line.GraphInfo.FillColor = Color.Green;

//Enable the circle to be filled with the color specified above line

graph1.Shapes.Add(line);

Arc arc = new Arc(110, 60, 50, 90, -90);

graph1.Shapes.Add(arc);

arc.GraphInfo.Color = Color.Red;

arc.GraphInfo.FillColor = Color.Yellow;

arc.GraphInfo.LineWidth = 10;

//Enable the circle to be filled with the color specified above line

doc.Save(outFile);

Assert.IsTrue(GeneratorTests.IsEqual("21855", outFile));

{{< /highlight >}}
