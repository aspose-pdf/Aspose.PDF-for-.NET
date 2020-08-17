---
title: Convert PDF Pages to Images and Recognize Barcodes
type: docs
weight: 10
url: /net/convert-pdf-pages-to-images-and-recognize-barcodes/
---

{{% alert color="primary" %}}

PDF documents usually comprise text, images, tables, attachments, graphs, annotations and other objects. Some of our customers need to embed barcodes in documents and then identify barcodes in the PDF file. The following article explains how to transform the pages in a PDF file to images and identifying barcodes in the images with Aspose.Barcode for .NET.

{{% /alert %}}
### **Converting Pages to Images and Recognizing Barcodes**

{{% alert color="primary" %}}


Aspose.PDF for .NET is very powerful product for managing PDF documents. It makes it easy to convert pages in PDF documents to images. Aspose.BarCode for .NET is an equally powerful product for generating and recognizing barcodes.

The class PdfConverter under the Aspose.PDF.Facades namespace supports converting PDF pages to various image formats. The PngDevice under the Aspose.PDF.Devices namespace supports converting PDF pages to PNG files. Either of these classes can be used to transform pages of PDF file into images.

When the pages have been converted to an image format, we can use Aspose.BarCode for .NET to identify barcodes inside them. The code samples below show how to convert pages using either  PdfConverter or PngDevice.

{{% /alert %}}

#### **Using Aspose.PDF.Facades**

{{% alert color="primary" %}}

The PdfConverter class contains a method named GetNextImage which generates the an image from the current PDF page. To specify the output image format, this method accepts an argument from the System.Drawing.Imaging.ImageFormat enumeration.

Aspose.Barcode contains a namespace, BarCodeRecognition, which contains the BarCodeReader class. The BarCodeReader class lets you read, determine, and identify barcodes from image files.

For the purposes of this example, first convert a page in a PDF file into an image with Aspose.PDF.Facades.PdfConverter. Then use the Aspose.BarCodeRecognition.BarCodeReader class to recognize the barcode in the image.


{{% /alert %}}

##### **Programming Samples**
**C#**

{{< highlight csharp >}}

 //Create a PdfConverter object

PdfConverter converter = new PdfConverter();

//Bind the input PDF file

converter.BindPdf("Source.pdf");

// Specify the start page to be processed

converter.StartPage = 1;

// Specify the end page for processing

converter.EndPage = 1;

// Create a Resolution object to specify the resolution of resultant image

converter.Resolution = new Aspose.PDF.Devices.Resolution(300);

//Initialize the convertion process

converter.DoConvert();

// Create a MemoryStream object to hold the resultant image

MemoryStream imageStream = new MemoryStream();

//Check if pages exist and then convert to image one by one

while (converter.HasNextImage())

{

    // Save the image in the given image Format

    converter.GetNextImage(imageStream, System.Drawing.Imaging.ImageFormat.Png);

    // Set the stream position to the beginning of the stream

    imageStream.Position = 0;

    // Instantiate a BarCodeReader object

    Aspose.BarCodeRecognition.BarCodeReader barcodeReader = new Aspose.BarCodeRecognition.BarCodeReader(imageStream, Aspose.BarCodeRecognition.BarCodeReadType.Code39Extended);

    // String txtResult.Text = "";

    while (barcodeReader.Read())

    {

        // Get the barcode text from the barcode image

        string code = barcodeReader.GetCodeText();

        // Write the barcode text to Console output

        Console.WriteLine("BARCODE : " + code);

    }

    // Close the BarCodeReader object to release the image file

    barcodeReader.Close();

}

// Close the PdfConverter instance and release the resources

converter.Close();

// Close the stream holding the image object

imageStream.Close();

{{< /highlight >}}

{{% alert color="primary" %}}

In above code snippets the output image is saved to a MemoryStream object. The image can also be saved to disk. To do so, replace the MemorStream object with a string object that represents the file path to the PdfConverter class' GetNextImage method.

{{% /alert %}}

{anchor:devices]
#### **Using the PngDevice Class**
In the Aspose.PDF.Devices, is the PngDevice. This class lets you convert pages in PDF documents to PNG images.

For the purpose of this example, load the source PDF file into the Document] cument's pages into PNG images. When the images have been created, use the BarCodeReader class under the Aspose.BarCodeRecognition to identify and read barcodes in the images.

{{% alert color="primary" %}}

The code samples given here traverses through the pages of the PDF document and tries to identify barcodes on each page.

{{% /alert %}}
##### **Programming Samples**
**C#**

{{< highlight csharp >}}

 //Open the PDF document

Aspose.PDF.Document pdfDocument = new Aspose.PDF.Document("source.pdf");

// Traverse through the individual pages of the PDF file

for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)

{

    using (MemoryStream imageStream = new MemoryStream())

    {

        //Create a Resolution object

        Aspose.PDF.Devices.Resolution resolution = new Aspose.PDF.Devices.Resolution(300);

        // Instantiate a PngDevice object while passing a Resolution object as an argument to its constructor

        Aspose.PDF.Devices.PngDevice pngDevice = new Aspose.PDF.Devices.PngDevice(resolution);

        //Convert a particular page and save the image to stream

        pngDevice.Process(pdfDocument.Pages[pageCount], imageStream);

        // Set the stream position to the beginning of Stream

        imageStream.Position = 0;

        // Instantiate a BarCodeReader object

        Aspose.BarCodeRecognition.BarCodeReader barcodeReader = new Aspose.BarCodeRecognition.BarCodeReader(imageStream, Aspose.BarCodeRecognition.BarCodeReadType.Code39Extended);

        // String txtResult.Text = "";

        while (barcodeReader.Read())

        {

            // Get the barcode text from the barcode image

            string code = barcodeReader.GetCodeText();

            // Write the barcode text to Console output

            Console.WriteLine("BARCODE : " + code);

        }

       // Close the BarCodeReader object to release the image file

       barcodeReader.Close();

    }

}

{{< /highlight >}}



{{% alert color="primary" %}}

For further information on topics covered in this article, please go to:

- Convert PDF Pages to Different Image Formats (Facades)
- Convert all PDF pages to PNG Images
- [Read Barcodes](https://docs.aspose.com/barcode/net/read-barcodes/)


{{% /alert %}}
