---
title: Gradiant Color Fill of Graph Object
type: docs
weight: 60
url: /java/gradiant-color-fill-of-graph-object/
---

{{% alert color="primary" %}} 

Aspose.PDF for Java supports the feature to add graph objects to PDF documents and sometimes it is required to fill graph objects with Gradient Color. To Fill graph objects with Gradient Color, We need to set setPatterColorSpace with gradientAxialShading object as following.

{{% /alert %}} 

The following code snippet shows how to add a Rectangle object that is filled with Gradient Color.

**Java**

{{< highlight java >}}

 //Create Document instance

Document doc = new Document();

//Add page to pages collection of PDF file

Page page = doc.getPages().add();

//Create Graph instance

com.aspose.pdf.drawing.Graph graph = new com.aspose.pdf.drawing.Graph(300, 300);

//Add graph object to paragraphs collection of page instance

page.getParagraphs().add(graph);

//Create Rectangle instance

com.aspose.pdf.drawing.Rectangle rect = new com.aspose.pdf.drawing.Rectangle(0, 0, 300, 300);

//Add rectangle object to shapes collection of Graph object

graph.getShapes().add(rect);

//Specify Gradient fill color for Graph object and fill

rect.getGraphInfo().setFillColor(new com.aspose.pdf.Color());

com.aspose.pdf.drawing.GradientAxialShading gradientAxialShading = new com.aspose.pdf.drawing.GradientAxialShading(com.aspose.pdf.Color.getRed(), com.aspose.pdf.Color.getBlue());

gradientAxialShading.setStart(new Point(0, 0));

gradientAxialShading.setEnd(new Point(300, 300));

rect.getGraphInfo().getFillColor().setPatternColorSpace(gradientAxialShading);

//Save PDF file

doc.save("GradientFill.pdf");

{{< /highlight >}}
