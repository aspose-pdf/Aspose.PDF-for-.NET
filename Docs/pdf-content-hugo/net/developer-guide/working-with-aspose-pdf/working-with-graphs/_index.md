---
title: Working with Graphs
type: docs
weight: 120
url: /net/working-with-graphs/
---

## **What is Graph**
Adding graphs to PDF documents is a very common task for developers while working with Adobe Acrobat Writer or other PDF processing applications. There are many types of graphs that can be used in PDF applications.

[Aspose.PDF for .NET](/pdf/net/home-html/) also supports adding graphs to PDF documents. For this purpose, the Graph class is provided. Graph is a paragraph level element and it can be added to the Paragraphs collection in a Page instance. A Graph instance contains a collection of Shapes.

The following types of shapes are supported by the Graph class:

- Arc
- Circle
- Curve
- Line
- Rectangle
- Ellipse
## **Create Filled Rectangle Object**
Aspose.PDF for .NET supports the feature to add graph objects (for example graph, line, rectangle etc.) to PDF documents. It also offers the feature to fill rectangle object with a certain color.

The following code snippet shows how to add a Rectangle object that is filled with color.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-CreateFilledRectangle-CreateFilledRectangle.cs" >}}
## **Add text inside Graph Object**
Aspose.PDF for .NET supports to add text inside the Graph Object. Text property of Graph Object provides option to set text of the Graph Object. The following code snippet shows how to add text inside a Rectangle object.

**C#**

{{< highlight java >}}

 // Open document

string outFile = "Graph.pdf";

Aspose.PDF.Document pdfDoc = new Aspose.PDF.Document();

Aspose.PDF.Page pdfPage = pdfDoc.Pages.Add();

Aspose.PDF.Drawing.Graph graph = new Aspose.PDF.Drawing.Graph(500, 100);

pdfPage.Paragraphs.Add(graph);

//Add rectangle with text

Aspose.PDF.Drawing.Rectangle rect = new Aspose.PDF.Drawing.Rectangle(0, 30, 50, 40);

rect.GraphInfo.LineWidth = 1f;

rect.GraphInfo.Color = Aspose.PDF.Color.Black;

rect.Text = new TextFragment("Rectangle");

graph.Shapes.Add(rect);

pdfDoc.Save(outFile);

{{< /highlight >}}
## **Add line object to PDF**
Aspose.PDF for .NET supports to get the leverage to add Line object where you can also specify the dash pattern, color and other formatting for Line element. The following code snippet shows how to add a Rectangle object that is filled with color.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-AddLineObject-AddLineObject.cs" >}}
### **DashLengthInBlack and DashLengthInWhite properties for Line object**
The legacy Aspose.PDF.Generator provides the feature to set DashLengthInBlack and DashLengthInWhite properties where dash pattern for line object can be defined. Similar features can be accomplished while using DOM approach.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-DashLength-DashLength.cs" >}}
## **Drawing Line across the page**
Aspose.PDF for .NET supports line object to draw a cross starting from Left-Bottom to Right-Upper corner and Left-Top corner to Bottom-Right corner. Please take a look over following code snippet to accomplish this requirement.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-DrawingLine-DrawingLine.cs" >}}
## **Create Rectangle with Alpha color channel**
Aspose.PDF for .NET supports to fill rectangle object with a certain color. A rectangle object can also have Alpha color channel to give transparent appearance. The following code snippet shows how to add a **Rectangle** object with Alpha color channel.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-CreateRectangleWithAlphaColor-CreateRectangleWithAlphaColor.cs" >}}
## **How to add drawing with transparent Color**
While creating drawing objects such as Rectangle, Circle, Eclipse etc, we provide color information for border as well as fill color information. In order to have transparent fill impression, the **FromArgb(..)** method of Aspose.PDF.Color object can be used. 
Please take a look over following code snippet which demonstrates the feature to fill rectangle object with transparent color. Please try using following code snippet to accomplish this requirement.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-AddDrawing-AddDrawing.cs" >}}
## **Controlling Z-Order of Rectangle**
When adding more than one instance of same object inside PDF file, we can control their rendering by specifying the Z-Order. Z-Order is also used when we need to render objects on top of each other. The following code snippet shows the steps to render Rectangle objects on top of each other.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-ControlRectangleZOrder-ControlRectangleZOrder.cs" >}}

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Graphs-ControlRectangleZOrder-AddRectangle.cs" >}}
## **Add Drawing with Gradient Fill**
Aspose.PDF for .NET supports the ability to create a pure PDF document that has a single gradient transitioning from one Spot/Process color to another Spot/Process color. This is illustrated in the following code sample.

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Graphs-AddDrawingWithGradientFill-AddDrawingWithGradientFill.cs" >}}
