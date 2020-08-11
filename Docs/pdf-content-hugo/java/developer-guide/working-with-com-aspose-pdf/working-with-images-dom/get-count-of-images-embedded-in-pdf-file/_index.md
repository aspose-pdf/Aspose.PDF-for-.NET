---
title: Get count of Images Embedded in PDF File
type: docs
weight: 90
url: /java/get-count-of-images-embedded-in-pdf-file/
---

{{% alert color="primary" %}} 

Images are stored in each page's [Resources](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Resources) collection's Images collection. In order to get the total count of images in PDF file, we need to first get the count of images in each page and then sum the count of images count from individual page. The following code also shows the steps to get image's name, without extracting it from the document. The extracted names will be same as provided when they were added to the PDF.

{{% /alert %}} 

The following code snippet shows how to get names of images embedded inside PDF file.

**Java**

{{< highlight java >}}

 // Load source PDF file

Document pdfDocument = new Document("c:/input.pdf");

// create a variable to maintain total images count

int Total_Images=0;

// Iterate through each page of PDF document

 for (int pagecount = 1; pagecount <= pdfDocument.getPages().size(); pagecount++) {

	 // create a variable to track count of images in each page

	 int Images_per_page=0;

	 // Get the all images names from specific page of PDF file

	 for (int i = 0; i < pdfDocument.getPages().get_Item(pagecount).getResources().getImages().size(); i++) {

		 // Print the names of image file over console

		 System.out.println(pdfDocument.getPages().get_Item(pagecount).getResources().getImages().getNames()[i]);

		 // increase the count keeping track of images in each page

		 Images_per_page = Images_per_page+1;	

   }

   // update the count of total images in PDF file

   Total_Images = Total_Images+Images_per_page;

 }  

 // print total images count in PDF file

 System.out.print("Total number of images = "+ Total_Images);

{{< /highlight >}}
