---
title: Adding RichMediaAnnotation
type: docs
weight: 20
url: /java/adding-richmediaannotation/
---

1 [Adding RichMediaAnnotation](#AddingRichMediaAnnotation-AddingRichMediaAnnotation) 

1.1 [Embed Video File](#AddingRichMediaAnnotation-EmbedVideoFile)
## **Adding RichMediaAnnotation**
{{% alert color="primary" %}} 

When we have a requirement to add an external video link in PDF document, we can use MovieAnnotaiton. However when there is a requirement to embed media inside the PDF document, we need to use RichMediaAnnotation. This annotation allows to embed media file within the PDF document and sets video/audio player, implemented as flash application. Due to license restrictions, we can not include third-party flash scripts in our product, so you need to provide your script for playing videos or audios. You should provide flash application code. For example, you can use videoplayer.swf and audioplayer.swf which are distributed with Adobe Acrobat and may be found in Multimedia Skins/Players sub-folder in Acrobat folder. Another option is using StrobeMediaPLayback.swf player or any other videoplayer implemented in flash.

The following methods/properties of RichMediaAnnotation class can be used.

- setCustomPlayer(..): Allows to set player used to play video. 
- setCustomFlashVariables(..): Allows to set variables which are passed to flash application. This line is set of "key=value" pairs
- addCustomData(..):  Add additional data for player. For example source=video.mp4&autoPlay=true&scale=100
- ActivationEvent setActivateOn(..):  Event activates player; possible values are Click, PageOpen, PageVisible
- setContent(Stream stream, string name): Set video/audio data to be played
- void Update():  Create data structure of the annotation. This method should be called last 
- void setPoster(Stream): Set poster of the video i.e. picture shown when player is not active
### **Embed Video File**
**Java**

{{< highlight java >}}

 // instantiate Document instance

Document doc = new Document();

// add page to pages collection of Document object

Page page = doc.getPages().add();



// create RichMediaAnnotation object

RichMediaAnnotation rma = new RichMediaAnnotation(page, new Rectangle(100,500, 300, 600));



//here we should specify stream containing code of the video player

InputStream is = new FileInputStream(myDir+"Videoplayer.swf");

rma.setCustomPlayer(is);



// Give name to video data. This data will be embedded into document 

// with this name and referenced from flash variables by this name. 

// videoName should not contain path to the file; this is rather "key" 

// to access data inside of the PDF document

String videoName = "VideoTutorial.mp4";



//also we use skin for video player

String skinName = "SkinOverAllNoFullNoCaption.swf";



//compose flash variables line for player. please note that different players may 

// have different format of the flash variables line. Refer to documentation for your player.

rma.setCustomFlashVariables(String.format("source=%s&skin=%s", "VideoTutorial.mp4", skinName));



//add skin code. 

InputStream is2 = new FileInputStream(myDir+"SkinOverAllNoFullNoCaption.swf");

rma.addCustomData(skinName,is2);



//set poster for video

InputStream is3 = new FileInputStream(myDir+"barcode.jpg");

rma.setPoster(is3);



InputStream fs = new FileInputStream(myDir + videoName);

//set video content

rma.setContent(videoName, fs);



//set type of the content (video)

rma.setType(RichMediaAnnotation.ContentType.Video);



//active player by click

rma.setActivateOn(RichMediaAnnotation.ActivationEvent.Click);



//update annotation data. This method should be called after all assignments/setup. 

// This method initializes data structure of the annotation and embeds required data. 

rma.update();



//add annotation on the page.

page.getAnnotations().add(rma);



doc.save(myDir + "Output"+version+"2.pdf");

try

{

    if (is!=null)

        is.close();

    if (is2!=null)

        is2.close();

    if (is3!=null)

        is3.close();

    if (fs!=null)

        fs.close();

} catch (Exception e)

{

    // TODO: handle exception

}

{{< /highlight >}}

{{% /alert %}}
