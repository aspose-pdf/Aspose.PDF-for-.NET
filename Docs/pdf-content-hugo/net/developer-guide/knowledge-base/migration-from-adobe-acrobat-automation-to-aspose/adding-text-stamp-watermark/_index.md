---
title: Adding Text Stamp Watermark
type: docs
weight: 10
url: /net/adding-text-stamp-watermark/
---

{{% alert color="primary" %}} 

In this article, we’ll explain how to add Text Stamp / Watermark using both Adobe Acrobat Automation and [Aspose.PDF for .NET](/pdf/net/home-html/). 

{{% /alert %}} 
##### **Implementation details**
Both Adobe Acrobat Automation and [Aspose.PDF for .NET](/pdf/net/home-html/) allows you to add Text Stamp / Watermark to PDF fi les programmatically. However, [Aspose.PDF for .NET](/pdf/net/home-html/) is quite easy to use as compared to Adobe Acrobat Automation. In the below example we will add a text stamp / watermark to a PDF file using both Adobe Acrobat Automation and Aspose.PDF for .NET and you can see the difference of ease in both the products. 
##### **Adobe Acrobat Automation**
The following code snippet shows you how to add a text stamp / watermark to a PDF file using Adobe Acrobat Automation. 

**C#**

{{< highlight csharp >}}

 // Create an AVDoc object

AcroAVDoc gAVDoc = new AcroAVDoc();

gAVDoc.Open("D:/Ap Data/Source_Files/Test.pdf","");

CAcroPDDoc pdDoc =  (CAcroPDDoc)gAVDoc.GetPDDoc();

//Acquire the Acrobat JavaScript Object interface from the PDDoc object

Object jsObj = pdDoc.GetJSObject();                          

Type T = jsObj.GetType();

//get current time and make a string from it

System.DateTime currentTime = System.DateTime.Now;

// make a color object

Object colorObj = T.InvokeMember(

        "color",

        BindingFlags.GetProperty |

        BindingFlags.Public |

        BindingFlags.Instance,

        null, jsObj, null);

Type colorType = colorObj.GetType();

Object blueColorObj = colorType.InvokeMember(

        "blue",

        BindingFlags.GetProperty |

        BindingFlags.Public |

        BindingFlags.Instance,

        null, colorObj, null);

// Add a text watermark.     

object[] addTextWatermarkParam = { currentTime.ToShortTimeString(), 1, "Helvetica", 100, blueColorObj, 0, 0, true, true, true, 0, 3, 20, -45, false, 1.0, false, 0, 0.7 };

T.InvokeMember(

        "addWatermarkFromText",

        BindingFlags.InvokeMethod |

        BindingFlags.Public |

        BindingFlags.Instance,

        null, jsObj, addTextWatermarkParam);

{{< /highlight >}}
##### **Aspose.PDF for .NET**
The following code snippet shows you how to add a text stamp / watermark to a PDF file using [PdfFileStamp](/pages/createpage.action?spaceKey=pdfnet&title=PdfFileStamp+Class&linkCreation=true&fromPageId=7118248) class of [Aspose.PDF.Facades namespace](/pages/createpage.action?spaceKey=pdfnet&title=Aspose.PDF.Facades+namespace&linkCreation=true&fromPageId=7118248) present in [Aspose.PDF for .NET](/pdf/net/home-html/) component. 

**C#**

{{< highlight csharp >}}

  //open document

PdfFileStamp fileStamp = new PdfFileStamp(@"D:\Source_Files\test.pdf", @"D:\Source_Files\output.pdf");

//create stamp

Aspose.PDF.Facades.Stamp stamp = new Aspose.PDF.Facades.Stamp();

//get current time and make a string from it

System.DateTime currentTime = System.DateTime.Now;

stamp.BindLogo(new FormattedText(currentTime.ToShortTimeString(), Color.Blue, Color.White, Aspose.PDF.Facades.FontStyle.Helvetica, EncodingType.Winansi, true, 100));

//Set Origion

stamp.SetOrigin(100, 600);

//Set as Background 

stamp.IsBackground = true;

//Set Opacity

stamp.Opacity = .7F;

//add stamp to PDF file

fileStamp.AddStamp(stamp);

//save updated PDF file

fileStamp.Close(); 

{{< /highlight >}}
