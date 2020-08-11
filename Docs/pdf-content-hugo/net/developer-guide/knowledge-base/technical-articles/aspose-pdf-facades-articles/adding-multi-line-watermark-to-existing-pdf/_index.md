---
title: Adding multi line watermark to existing PDF
type: docs
weight: 70
url: /net/adding-multi-line-watermark-to-existing-pdf/
---

{{% alert color="primary" %}} 

A lot of users want to stamp their PDF documents with multi-line text. They usually try to use “\n” and “<BR>” but these types of characters are not supported by Aspose.Pdf.Facades namespace. So, to make it possible, we have added another method named [AddNewLineText()](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formattedtext/methods/addnewlinetext/index) in [FormattedText](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formattedtext) class of Aspose.Pdf.Facades namespace.

{{% /alert %}} 
## **Implementation**
Please refer to the following code chunk to add multi-line watermark in existing PDF.



**C#**

{{< highlight csharp >}}

 // Instantiate a stamp object

Stamp logoStamp = new Stamp();

// Instantiate an object of FormattedText class 

FormattedText formatText = new FormattedText("Hello World!", 

System.Drawing.Color.FromArgb(180, 0, 0), FontStyle.TimesItalic, EncodingType.Winansi, false, 50);

// Add another line for Stamp

formatText.AddNewLineText("Good Luck");

// BindLogo to PDF

logoStamp.BindLogo(formatText);



{{< /highlight >}}
