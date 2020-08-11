---
title: Add, Delete and Get Annotation
type: docs
weight: 20
url: /net/add-delete-and-get-annotation/
---

## **Add Annotation in existing PDF file**
Annotations are contained by the [Annotations](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/) collection of a particular Page. This collection contains the annotations for that individual page only; every page has its own Annotations collection.

To add an annotation to a particular page, add it to that page's Annotations collection with the [Add](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection/methods/add) method.

1. First, create an annotation that you want to add to the PDF.
1. Then open the input PDF.
1. Add the annotation to the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's Annotations collection.

The following code snippet shows you how to add an annotation in a PDF page.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-AddAnnotation-AddAnnotation.cs" >}}
### **Invisible Annotation**
Sometimes, it is necessary to create a watermark that isn't visible in the document when viewing it but should be visible when the document is printed. Use annotation flags for this purpose. The following code snippet shows how.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-InvisibleAnnotation-InvisibleAnnotation.cs" >}}
### **Adding InkAnnotation**
The [InkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/inkannotation) represents freehand scribble composed of one or more disjoint points. Please try using the following code snippet to add InkAnnotation in PDF document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-AddlnkAnnotation-AddlnkAnnotation.cs" >}}
#### **Set Line width of InkAnnotation**
The width of [InkAnnottion](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/inkannotation) can be changed using LineInfo and Border objects.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-lnkAnnotationLineWidth-lnkAnnotationLineWidth.cs" >}}
### **Adding WatermarkAnnotation**
You can add Watermark Text using [WaterarkAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/watermarkannotation) at a specific position of the PDF page. The opacity of Watermark can also be controlled by using opacity property. Please check the following code snippet to add WatermarkAnnotation.

**C#**

{{< highlight csharp >}}

 //Load a Document

Aspose.PDF.Document doc = new Aspose.PDF.Document("source.pdf");

//Load Page object to add Annotation

Page page = doc.Pages[1];

//Create Annotation

WatermarkAnnotation wa = new WatermarkAnnotation(page, new Aspose.PDF.Rectangle(100, 500, 400, 600));

//Add annotaiton into Annotation collection of Page

page.Annotations.Add(wa);

//Create TextState for Font settings

Aspose.PDF.Text.TextState ts = new Aspose.PDF.Text.TextState();

ts.ForegroundColor = Aspose.PDF.Color.Blue;

ts.Font = FontRepository.FindFont("Times New Roman");

ts.FontSize = 32;

//Set opacity level of Annotaiton Text

wa.Opacity = 0.5;

//Add Text in Annotation

wa.SetTextAndState(new string[] { "HELLO", "Line 1", "Line 2" }, ts);

//Save the Docuemnt

doc.Save("Output.pdf");

{{< /highlight >}}
### **Adding RichMediaAnnotation**
When you need to add an external video link in PDF document, you can use [MovieAnnotaiton](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/movieannotation). However, when there is a requirement to embed media inside PDF document, you need to use [RichMediaAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/richmediaannotation). This annotation allows to embed media file within PDF document and set video/audio player, implemented as flash application. Due to license restriction, we can not include third-party flash scripts in our product, so you should provide your script for playing video or audio. You should provide a flash application code. For example, you can use videoplayer.swf and audioplayer.swf which are distributed with Adobe Acrobat and may be found in Multimedia Skins/Players subfolder in Acrobat folder. Another choice is using StrobeMediaPLayback.swf player or any other video player implemented in flash.

The following methods/properties of RichMediaAnnotation class can be used.



- Stream CustomPlayer { set; }: Allows setting player used to play video.
- string CustomFlashVariables { set; }: Allows to set variables that are passed to flash application. This line is set of "key=value" pairs which are separated with '&';
- void AddCustomData(strig name, Stream data):  Add additional data for the player. For example source=video.mp4&autoPlay=true&scale=100
- ActivationEvent ActivateOn { get; set}:  Event activates player; possible values are Click, PageOpen, PageVisible
- void SetContent(Stream stream, string name): Set video/audio data to be played
- void Update():  Create a data structure of the annotation. This method should be called last
- void SetPoster(Stream): Set poster of the video i.e. picture shown when the player is not active


#### **Embed Video File**
Embedding video file can be achieved using the following sample code.

**C#**

{{< highlight csharp >}}

 string myDir = "C:/Temp/";



Aspose.PDF.Document doc = new Aspose.PDF.Document();

Page page = doc.Pages.Add();

RichMediaAnnotation rma = new RichMediaAnnotation(page, new Aspose.PDF.Rectangle(100,500, 300, 600));

//here we should specify stream containing code of the video player

rma.CustomPlayer = new FileStream(@"C:\Adobe\Acrobat 11.0\Acrobat\MultimediaSkins\Players\Videoplayer.swf",FileMode.Open,FileAccess.Read);

//give name to video data. This data will be embedded into document with this name and referenced from flash variables by this name. 

//videoName should not contain path to the file; this is rather "key" to access data inside of the PDF document

string videoName = "VideoTutorial.mp4";

//also we use skin for video player

string skinName = "SkinOverAllNoFullNoCaption.swf";

//compose flash variables line for player. please note that different players may have different format of the flash variables line. Refer to documentation for your player.

rma.CustomFlashVariables = String.Format("source={0}&skin={1}", "VideoTutorial.mp4", skinName);

//add skin code. 

rma.AddCustomData(skinName,new FileStream(@"C:\Program Files (x86)\Adobe\Acrobat 11.0\Acrobat\Multimedia Skins\SkinOverAllNoFullNoCaption.swf",FileMode.Open, FileAccess.Read));

//set poster for video

rma.SetPoster(new FileStream(myDir + "barcode.jpg",FileMode.Open, FileAccess.Read));

Stream fs = new FileStream(myDir + videoName, FileMode.Open, FileAccess.Read);

//set video content

rma.SetContent(videoName, fs);

//set type of the content (video)

rma.Type = RichMediaAnnotation.ContentType.Video;

//active player by click

rma.ActivateOn = RichMediaAnnotation.ActivationEvent.Click;

//update annotation data. This method should be called after all assignments/setup. This method initializes data structure of the annotation and embeds required data. 

rma.Update();

//add annotation on the page.

page.Annotations.Add(rma);

doc.Save(myDir + "Output.pdf");

{{< /highlight >}}
#### **Embed Audio File**
Embedding audio files can be achieved using the following sample code.

**C#**

{{< highlight csharp >}}

 Aspose.PDF.Document

doc = new Aspose.PDF.Document();

Page page = doc.Pages.Add();

//give name to audio data. This data will be embedded into document with this name and referenced from flash variables by this name. 

string audioName = "test_cbr.mp3";

RichMediaAnnotation rma = new RichMediaAnnotation(page, new Aspose.PDF.Rectangle(100,650, 300, 670));

Stream fs = new FileStream(myDir+audioName, FileMode.Open, FileAccess.Read);

//here we should specify stream containing code of the audio player

rma.CustomPlayer = new FileStream(@"C:\Program Files (x86)\Adobe\Acrobat 11.0\Acrobat\MultimediaSkins\Players\Audioplayer.swf", FileMode.Open,

FileAccess.Read);

//compose flash variables line for player. please note that different players may have different format of the flash variables line. Refer to documentation for your player.

rma.CustomFlashVariables = String.Format("source={0}", "test_cbr.mp3");

//active player on page open event

rma.ActivateOn = RichMediaAnnotation.ActivationEvent.PageOpen;

//set audio content

rma.SetContent(audioName, fs);

//set type of the content (audio)

rma.Type = RichMediaAnnotation.ContentType.Audio;

//update annotation data. This method should be called after all assignments/setup. This method initializes data structure of the annotation and embeds required data. 

rma.Update();

//add annotation on the page.

page.Annotations.Add(rma);

doc.Save(myDir+"39606-2.pdf");

{{< /highlight >}}


## **Add SWF File Annotation to PDF Document**
Annotations in a PDF document are contained in a [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's Annotations collection. This collection contains all annotations for that individual page only: every page has its own Annotations collection. To add an annotation to a particular page, add it to that page's Annotations collection using the Add method. Use the [ScreenAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/screenannotation) class in the Aspose.PDF.InteractiveFeatures.Annotations namespace to include SWF files as annotations in a PDF document instead.

ScreenAnnotation takes three arguments:

1. The page you are adding the annotation to,
1. A **Rectangle** object which defines the area in the PDF where the annotation will be displayed, and
1. The path to the SWF multimedia file.

To add an SWF file as an annotation:

1. First, create an instance of ScreenAnnotation.
1. Then add it to the page's Annotations collection using the Add method.

The following code snippet shows you how to add SWF annotation in a PDF page.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-AddSwfFileAsAnnotation-AddSwfFileAsAnnotation.cs" >}}
## **Delete All Annotations from a Page of a PDF File**
A [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object’s [AnnotationCollection](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection contains all the annotations for that particular page. To delete all the annotations from a page, call the Delete method of the [AnnotationCollectoin](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection.

The following code snippet shows you how to delete all the annotations from a particular page.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-DeleteAllAnnotationsFromPage-DeleteAllAnnotationsFromPage.cs" >}}
## **Delete a Particular Annotation from the PDF File**
{{% alert color="primary" %}} 

You can check the quality of Aspose.PDF and get the results online at this link:

[products.aspose.app/pdf/annotation](https://products.aspose.app/pdf/annotation) {{% /alert %}} 

Aspose.PDF allows you to remove a particular Annotation from PDF file. This topic explains how.

To delete a particular annotation from a PDF, call the [AnnotationCollection](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection's Delete method. This collection belongs to the [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object. The **Delete** method requires the index of the annotation you want to delete. Then, save the updated PDF file. The following code snippet shows how to delete a particular annotation.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-DeleteParticularAnnotation-DeleteParticularAnnotation.cs" >}}
## **Get All Annotations from the Page of a PDF Document**
Aspose.PDF allows you to get annotations from an entire document, or from a given page. To get all annotations from the page in a PDF document, loop through the [AnnotationCollection](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection of desired page resources. The following code snippet shows you how to get all the annotations of a page.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-GetAllAnnotationsFromPage-GetAllAnnotationsFromPage.cs" >}}

Please note that to get all annotations from the whole PDF, you have to loop through the document's PageCollection Class collection before navigating through the AnnotationCollection class collection. You can get each annotation of the collection in a base annotation type called MarkupAnnotation Class and then show its properties.
## **Get Particular Annotation from a PDF File**
Annotations are associated with individual pages and stored in a [Page](https://apireference.aspose.com/net/pdf/aspose.pdf/page) object's [AnnotationCOllection](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotationcollection) collection. To get a particular annotation, specify its index. This returns an [Annotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/annotation) object which needs to be cast to a particular annotation type, for example [TextAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/textannotation). The following code snippet shows how to get a particular annotation and its properties.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Annotations-GetParticularAnnotation-GetParticularAnnotation.cs" >}}
## **Get Resource of Annotation**
Aspose.PDF allows you to get a resource of annotation from an entire document, or from a given page. The following code snippet shows you how to get the resource of annotation as FileSpecification object of input PDF file.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Annotations-GetResourceOfAnnotation-GetResourceOfAnnotation.cs" >}}
