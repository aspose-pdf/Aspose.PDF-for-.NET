---
title: Add text inside Graph Object
type: docs
weight: 70
url: /java/add-text-inside-graph-object/
---

Aspose.PDF for Java supports to add text inside the Graph Object. Text property of Graph Object provides option to set text of the Graph Object. The following code snippet shows how to add text inside a Rectangle object.

**Java**

{{< highlight java >}}

 //Open document

String outFile = "Graph.pdf";

com.aspose.pdf.Document pdfDoc = new

com.aspose.pdf.Document();

com.aspose.pdf.Page pdfPage =

pdfDoc.getPages().add();

com.aspose.pdf.drawing.Graph graph = new

com.aspose.pdf.drawing.Graph(500, 100);

pdfPage.getParagraphs().add(graph);

//1st rectangle

com.aspose.pdf.drawing.Rectangle rect

= new

com.aspose.pdf.drawing.Rectangle(0, 30, 50, 40);

rect.getGraphInfo().setLineWidth(1f);

rect.getGraphInfo().setColor(com.aspose.pdf.Color.getBlack());

rect.setText(new TextFragment("Rectangle"));

graph.getShapes().add(rect);

pdfDoc.save(outFile); 

{{< /highlight >}}
