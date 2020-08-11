---
title: Aspose.PDF for .NET 9.6.0 Release Notes
type: docs
weight: 30
url: /net/aspose-pdf-for-net-9-6-0-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 9.6.0](http://www.aspose.com/downloads/pdf/net/new-releases/aspose.pdf-for-.net-9.6.0/)

{{% /alert %}} 

We are pleased to share a new version of Aspose.PDF for .NET with following improvements. 
## **New Features**
PDFNEWNET-36115 Change page orientation from Portrait to landscapePDFNEWNET-36340 Create single HTML file output with embedded resoruces 

PDFNEWNET-36608 PDF to HTML - embed CSS inside HTML 

PDFNEWNET-37337 Retrieve RadioHoriz property for RadioButton field 
## **Enhancements**
PDFNEWNET-29860 After replacing the text, the contents of the PDF should be re-arrangedPDFNEWNET-34143 Resultant DOC file generated from PDF is very large in size 

PDFNEWNET-36625 Missing properties of Graph object in Aspose.PDF.Drawing.Graph 

PDFNEWNET-36626 Aspose.PDF.Drawing.Graph Properties 

PDFNEWNET-36629 Missing properties in GraphInfo class in new Generator 

PDFNEWNET-36884 Increase performance while trimming whitespace from PDF 

PDFNEWNET-37335 Scale PDF contents of whole PDF 
## **Exceptions**
PDFNEWNET-34202 XPS to PDF Convertion IssuePDFNEWNET-34488 Exception during PDF to Image conversion 

PDFNEWNET-36172 Loading a large PDF file throwing StackOverflowException 

PDFNEWNET-36557 Exception while extracting text from PDF file 

PDFNEWNET-37156 StackOverflowException when using IsContainSignature() method 

PDFNEWNET-37250 HTML to PDF - NullReference Exception while converting HTML to PDF 

PDFNEWNET-37299 NullPointerException - When converting PDF files to JPG 
## **Bugs**
PDFNEWNET-29077 Text is not wraping to next lines when line becomes too long when replacing textPDFNEWNET-29224 Text not rearranged after ReplaceText 

PDFNEWNET-32600 Issue in converting pdf to tiff (v6.5) 

PDFNEWNET-33173 Convert HTML to PDF issue 

PDFNEWNET-34079 Text is appearing in top of table borders when converting PDF file to DOC 

PDFNEWNET-34400 Parentheses are inverted (Hebrew PDF to HTML conversion) 

PDFNEWNET-34675 Pdf to Word conversion: Top margin from table border is gone 

PDFNEWNET-35110 Difference in rendering XLS-FO to Pdf in 3.6.0 and 7.8.0 

PDFNEWNET-35744 Html to Pdf - Issue with nested blockquotes 

PDFNEWNET-35777 HTML to PDF: CSS white-space:nowrap property is not being honored 

PDFNEWNET-35884 Field values are lost when converting XFA form to Standard form 

PDFNEWNET-35910 HTML to PDF - Some tags are not being recognized 

PDFNEWNET-36071 XSL-FO to PDF - Footnotes are not appearing correctly 

PDFNEWNET-36314 XSLFO to PDF - Image does not appear in resultant file 

PDFNEWNET-36461 PDF table rows overlap each other if table goes over a page 

PDFNEWNET-36504 Hyperlinks Creation Issue over TextFragment 

PDFNEWNET-36522 TextReplace - subsequent TextFragments are not auto adjusting their position 

PDFNEWNET-36564 Links are not detected if it is in table or header in a PDF file 

PDFNEWNET-36697 PNG converted from PDF is being cropped 

PDFNEWNET-36784 PDF to PNG - Gray background appearing behind clock in PDF 

PDFNEWNET-36825 ParseToPdf(..) method should support multibyte characters 

PDFNEWNET-36827 HTML to PDF conversion doesn't honor strike out text 

PDFNEWNET-36835 Adding a watermark takes too much time 

PDFNEWNET-36913 PDF to TIFF: First page is being rendered as black square 

PDFNEWNET-37021 Memory leak when using Aspose.PDF for .NET on SharePoint 2010 

PDFNEWNET-37044 PdfViewer - Table is printing black 

PDFNEWNET-37065 RTL text is not appearing properly when setting IsHtmlTagSupported as True 

PDFNEWNET-37074 Large files creation issue 

PDFNEWNET-37076 Aspose.PDF for .NET dlls (2.0, 3.5,4.0) does not work with Projects with .Net Framework 3.5 as target framework 

PDFNEWNET-37107 multiline Read-Only TextBoxField is not appearing properly 

PDFNEWNET-37124 Resultant file is corrupted/blank when performing font substitution 

PDFNEWNET-37126 Adding background image to PDF without license implementation results a blank document 

PDFNEWNET-37176 PDF to TIF - resultant image contains large black rectangle 

PDFNEWNET-37192 PDF to TIFF - Icon is appearing as black 

PDFNEWNET-37221 Facades fills form with tiny fonts 

PDFNEWNET-37222 PDF to HTML: font rendering issue 

PDFNEWNET-37241 Value from Aspose.PDF.Color.FromRgb does not work with a Color property of an annotation 

PDFNEWNET-37271 PDF to PDF/A: Background color of first page turns to dark blue 

PDFNEWNET-37274 Incorrect bookmarks is being returned 

PDFNEWNET-37298 PDF to PDFA1b conversion loses the text 

PDFNEWNET-37300 HTML to PDF - Text background is not appearing properly 

PDFNEWNET-37323 Page level PageInfo settings are ignored if it is set at document level 

PDFNEWNET-37325 Compressing the PDF file removes images from file 

PDFNEWNET-37330 Hyperlinks breaking in stamped PDF 

PDFNEWNET-37339 Image is not being filled in PDF form 

PDFNEWNET-37345 Svg font is not properly embedded 

PDFNEWNET-37356 Issue in paragraph margins in page footer 

PDFNEWNET-37360 Image to PDF - resultant PDF dimensions are not similar to input image 

PDFNEWNET-37366 PDF to Excel - Values are not properly appearing in resultant file 

PDFNEWNET-37369 PDF to JPEG conversion using JpegDevice. UnderlineAnnotation is missing 
## **Public API and Backwards Incompatible Changes**
Breaking change: Some untyped public API members has become typed 

AppearanceDictionary class changes: 

Typed indexer was added into AppearanceDictionary class:public XForm this[string key](/pages/createpage.action?spaceKey=pdfnet&title=string+key&linkCreation=true&fromPageId=7120531) 
Previous indexer version was marked as obsolete:public XForm this[objectkey](/pages/createpage.action?spaceKey=pdfnet&title=objectkey&linkCreation=true&fromPageId=7120531) 
Following typed methods were added into into AppearanceDictionary class:void Add(System.String,Aspose.PDF.XForm)bool ContainsKey(System.String)bool Remove(System.String)bool TryGetValue(System.String, out Aspose.PDF.XForm)void Add(System.Collections.Generic.KeyValuePair<System.String,Aspose.PDF.XForm>)bool Contains(System.Collections.Generic.KeyValuePair<System.String,Aspose.PDF.XForm>)void CopyTo(System.Collections.Generic.KeyValuePair<string, XForm>[] array,System.Int32)bool Remove(System.Collections.Generic.KeyValuePair<System.String,Aspose.PDF.XForm>)Following untyped methods were marked as obsolete:void Add(Object key, Object value)bool Contains(Object key)void Remove(Object key)InkAnnotation class changes: 

Typed constructor was added for InkAnnotation class:public InkAnnotation(Page page, Rectangle rect, IList<Point[]> inkList) 
Untyped constructor was marked as obsolete:public InkAnnotation(Page page, Rectangle rect, IList inkList) 
Return type was changed for InkList property:public IList<Point[]> InkList 
Previous untyped property version was removed (becuse it is not possible to leave both properties - new and old with different return types)public IList InkList 
Other changes 

Typed Remove method was added into Aspose.PDF.Cells class:Remove(Aspose.PDF.Cell) 
Untyped method version was marked as obsolete:Remove(System.Object) 
RadiusForRoundCorner property was added into Aspose.PDF.Drawing.Rectangle classFollowing code snippet shows how to use RadiusForRoundCorner property:string outFile = "36624.pdf";Document doc = new Document();Page page = doc.Pages.Add();Graph root = new Graph(100, 100);Drawing.Rectangle rect = new Drawing.Rectangle(0, 0, 100, 100);rect.GraphInfo.Color = Color.Blue;rect.RadiusForRoundCorner = 10;root.Shapes.Add(rect);page.Paragraphs.Add(root);doc.Save(outFile);Left and Top properties were added into Aspose.PDF.Drawing.Graph class 

Following code snippet shows how to use Left, Top properties:string outFile = "36625.pdf";Document doc = new Document();Page page = doc.Pages.Add();Graph root = new Graph(100, 100);root.Left = 300;root.Top = 300;Drawing.Rectangle rect = new Drawing.Rectangle(0, 0, 100, 100);root.Shapes.Add(rect);page.Paragraphs.Add(root);doc.Save(outFile);CalculateContentBBox method was added into Aspose.PDF.Page object 

Following code snippet shows how to trim whitespace from Pdf document:Document document = new Document(inFile);Page pdfPage = document.Pages[1](/pages/createpage.action?spaceKey=pdfnet&title=1&linkCreation=true&fromPageId=7120531);Rectangle contentBBox = pdfPage.CalculateContentBBox();document.Pages[1](/pages/createpage.action?spaceKey=pdfnet&title=1&linkCreation=true&fromPageId=7120531).CropBox = contentBBox;document.Pages[1](/pages/createpage.action?spaceKey=pdfnet&title=1&linkCreation=true&fromPageId=7120531).MediaBox = contentBBox;document.Save(outFile);ResizeContents method that accepts Document object was added into PdfFileEditor class: 

ResizeContents(doc, parameters); 
Following code snippet shows how to use ResizeContents(doc, parameters) method://Create PdfFileEditor ObjectPdfFileEditor fileEditor = new PdfFileEditor();//Open PDF DocumentAspose.PDF.Document doc = new Aspose.PDF.Document(TestSettings.GetInputFile("PdfWithImages.pdf"));//Specify Parameter to be used for resizingPdfFileEditor.ContentsResizeParameters parameters = new PdfFileEditor.ContentsResizeParameters(    //left margin = 10% of page widthPdfFileEditor.ContentsResizeValue.Percents(30),    //new contents width calculated automatically as width - left margin - right margin (100% - 10% - 10% = 80%)null,    //right margin is 10% of pagePdfFileEditor.ContentsResizeValue.Percents(30),    //top margin = 10% of heightPdfFileEditor.ContentsResizeValue.Percents(30),    //new contents height is calculated automatically (similar to width)null,    //bottom margin is 10%PdfFileEditor.ContentsResizeValue.Percents(30));//Resize Page ContentsfileEditor.ResizeContents(doc, parameters);//save document into new location.doc.Save(TestSettings.GetOutputFile("37335.pdf"));ExternalResourcesCredentials property was added into HtmlLoadOptions class 

Following code snippet shows how to pass credentials to request HTML and HTML resources during Html->Pdf conversion:// Create a request for the URL.WebRequest request = WebRequest.Create("http://mercy.signchart.com/Report/PrintBook.asp?ProjectGuid=6FB9DBB0-5484-4BA9-85CA-859BFDB2AB7C&WorkSpaceGuid=0DD6BDD8-6916-4C93-AD1E-DF921434F536");// If required by the server, set the credentials.request.Credentials = CredentialCache.DefaultCredentials;// Get the response.HttpWebResponse response = (HttpWebResponse)request.GetResponse();// Get the stream containing content returned by the server.Stream dataStream = response.GetResponseStream();// Open the stream using a StreamReader for easy access.StreamReader reader = new StreamReader(dataStream);// Read the content.string responseFromServer = reader.ReadToEnd();reader.Close();dataStream.Close();response.Close();MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(responseFromServer));HtmlLoadOptions options = new HtmlLoadOptions("http://mercy.signchart.com/");options.ExternalResourcesCredentials = CredentialCache.DefaultCredentials;// use the new conversion engineoptions.UseNewConversionEngine = true;// load HTML fileDocument pdfDocument = new Document(stream, options);PartsEmbeddingModes enumeration was added into Aspose.PDF.HtmlSaveOptions class. 

The PartsEmbeddingModes enumeration includes following values:EmbedAllIntoHtml 
Enforces embed all referenced files(Css,Images,Fonts) into generated HTML markup (i.e. into HTML itself)This approach generates one HTML file, but total size of outputbecames bigger(because Base64 encoding of binaries is in use) and not all browsers (especially legacy)successfully process binaries embedded into HTML. But it allows get HTML that contains whole result, without any additional files.EmbedCssOnly 
Enforces put apart all referenced files except CSS (Images and Fonts)I.e. CSS will be embedded into result HTML , and all other referenced files(Images and Fonts)will be processed as external partsIt generates HTML that is sutable for wide set of browsersNoEmbedding 
Enforces put apart referenced files(Css,Images,Fonts)This approach generates set of files, but total size of outputbecames smaller(because no Base64 encoding of binaries is in use)Also such approach generates HTML that is sutable for wide set of browsersFollowing code snippet demonstrates how to embed all resources into html:Document doc = new Document(@"F:\ExternalTestsData\36608.pdf");HtmlSaveOptions newOptions = new HtmlSaveOptions();// this is usage of tested featurenewOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml;// this is just optimozation for IE and can be omitted newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;//string outHtmlFile = @"F:\ExternalTestsData\36340.html";doc.Save(outHtmlFile, newOptions);Following code snippet demonstrates how to embed CSS into the html file:Document doc = new Document(@"F:\ExternalTestsData\36608.pdf");HtmlSaveOptions newOptions = new HtmlSaveOptions();// this is usage of tested featurenewOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedCssOnly;// this is just optimozation for IE and can be omitted newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;//string outHtmlFile = @"F:\ExternalTestsData\36608.html";doc.Save(outHtmlFile, newOptions);GraphInfo property of Aspose.PDF.Drawing.Graph class is marked as obsolete. 

GraphInfo properties of Shape objects of Graph.Shapes collection should be used instead.Following code snippet shows how to use GraphInfo properties of a Graph's Shape.Document doc = new Document();Helper.SetLicense();//Create a section in the Pdf documentPage page = doc.Pages.Add();//Create a graph in the section with Width=100 and Height=400Graph graph1 = new Graph(50, 150);//Add the graph object to paragraphs collection of the sectionpage.Paragraphs.Add(graph1);float[] lineArr = new float[] 

Unknown macro: {110, 10, 10, 10, 10, 110, 110, 110}

;Line line = new Line(lineArr);line.GraphInfo.LineWidth = 10;//Set fill color of the circle using GraphInfo property of circle objectline.GraphInfo.FillColor = Color.Green;//Enable the circle to be filled with the color specified above linegraph1.Shapes.Add(line);Arc arc = new Arc(110, 60, 50, 90, -90);graph1.Shapes.Add(arc);arc.GraphInfo.Color = Color.Red;arc.GraphInfo.FillColor = Color.Yellow;arc.GraphInfo.LineWidth = 10;//Enable the circle to be filled with the color specified above linedoc.Save(outFile);Assert.IsTrue(GeneratorTests.IsEqual("21855", outFile));
