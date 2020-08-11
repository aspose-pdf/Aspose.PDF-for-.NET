---
title: Tips to Simplify your Code
type: docs
weight: 90
url: /net/tips-to-simplify-your-code/
---

{{% alert color="primary" %}} 

We know that there are always many ways to write a code for doing the same thing. But, some techniques can reduce the code and efforts of developers so, this is the aim of this topic to provide some tips to developers to write the simplest code for performing some general tasks.

{{% /alert %}} 

## **Tip 1: Using Add() method**
{{% alert color="primary" %}} 

Some collection classes including Cells, Rows, Segments and Sections has an Add() method. This method is used to initialize a new instance of the class and add it to the collection.
{{% /alert %}} 


{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

 Aspose.PDF.Generator.Row row1 = new Aspose.PDF.Generator.Row(table1); 

table1.Rows.Add(row1); 



{{< /highlight >}}

{{% alert color="primary" %}} 

The same thing can be achieved by just one line of code shown below as a better approach.

{{% /alert %}} 

{{% /alert %}} 

{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

 Aspose.PDF.Generator.Row row1 = table1.Rows.Add(); 



{{< /highlight >}}
{{% /alert %}} 

## **Tip 2: Using Segment constructor**


{{% alert color="primary" %}} 
Normally, a Segment(Text) constructor is used to create a <span style="color:grey">Text Segment</span> that takes a <span style="color:grey">Text </span> <span style="color:grey">Paragraph</span> as a parameter and then it is added to the segments collection of the <span style="color:grey">Text Paragraph</span>.
After that developers have to set its content.
{{% /alert %}} 


{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

 Aspose.PDF.Generator.Segment segment2 = new Aspose.PDF.Generator.Segment(text2); 

text2.Segments.Add(segment2); 

segment2.Content = "cell2"; 



{{< /highlight >}}

{{% alert color="primary" %}} 

The better way is to add the Segment  to the segments collection of the Text Paragraph  and the content of the  Segmentshould be passed to its constructor directly.

{{% /alert %}} 
{{% /alert %}}

{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

 text2.Segments.Add(new Aspose.PDF.Generator.Segment("cell2")); 



{{< /highlight >}}
{{% /alert %}}

## **Tip 3: Using Add(string) of Cells class**

{{% alert color="primary" %}} 
Normally, a Cell object is created then added to Row and then content is added to it. It consumed many steps as shown below in the code snippet.
{{% /alert %}}


{{% alert color="primary" %}} 
**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Cell cell1 = new Aspose.PDF.Generator.Cell(row1); 

 row1.Cells.Add(cell1); 

 Aspose.PDF.Generator.Text text1 = new Aspose.PDF.Generator.Text(); 

 cell1.Paragraphs.Add(text1); 

 Aspose.PDF.Generator.Segment segment1 = new Aspose.PDF.Generator.Segment(text1); 

 text1.Segments.Add(segment1); 

 segment1.Content = "cell1"; 



{{< /highlight >}}

{{% alert color="primary" %}} 

The better way is to use Cells.Add(string) method to initialize a new instance of the Cell class that adds a string to the new Cell object and then add the Cell object to the Cells collection of the Row.

{{% /alert %}} 
{{% /alert %}}



{{% alert color="primary" %}} 

**Better Approach** 

**C#**

{{< highlight csharp >}}

 Cell cell1 = row1.Cells.Add("cell1"); 



{{< /highlight >}}

Moreover, 'Cells.Add(string, TextInfo) can also be used that takes cell information alongwith its text format settings.
{{% /alert %}}


## **Tip 4: Using Color constructor**


{{% alert color="primary" %}} 

The Color(byte) constructor is used to initialize a new instance of the Color class with gray colorspace. The Color(byte,byte,byte) is used to initialize a new instance of the Color class with RGB colorspace. The Color(byte,byte,byte,byte) is used to initialize a new instance of the Color class with CMYK colorspace. The Color(string) constructor is used to initialize a new instance of the Color class with RGB colorspace and specified color name.
{{% /alert %}}


{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Line l3 = new Aspose.PDF.Generator.Line(graph); 

 l3.GraphInfo.Color.ColorSpaceType = Aspose.PDF.Generator.ColorSpaceType.Cmyk; 

 l3.GraphInfo.Color.CmykColorSpace = new Aspose.PDF.Generator.CmykColorSpace(); 

 l3.GraphInfo.Color.CmykColorSpace.C = 0; 

 l3.GraphInfo.Color.CmykColorSpace.M = 128; 

 l3.GraphInfo.Color.CmykColorSpace.Y = 64; 

 l3.GraphInfo.Color.CmykColorSpace.K = 0; 


{{< /highlight >}}

{{% /alert %}}


{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  l3.GraphInfo.Color = new Color(0,128,64,0); 


{{< /highlight >}}
{{% /alert %}}


## **Tip 5: Using BorderInfo constructor**

{{% alert color="primary" %}} 
The BorderInfo(int) constructor is used to initialize a new instance of the BorderInfo class with specified border sides. For example, BorderInfo((int)(BorderSide.Left | BorderSide.Top)). The BorderInfo(int,float) constructor is used to initialize a new instance of the BorderInfo class with specified border sides and border width. The BorderInfo(int,float,Color) constructor is used to initialize a new instance of the BorderInfo class with specified border sides, border width and border color. The BorderInfo(int,GraphInfo) constructor is used to initialize a new instance of the BorderInfo class with specified border sides and border style. The BorderInfo(int,Color) is used to initialize a new instance of the BorderInfo class with specified border sides and border color.
{{% /alert %}}
 
 
{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.BorderInfo border2 = new Aspose.PDF.Generator.BorderInfo(); 

 Aspose.PDF.Generator.GraphInfo graphInfo1 = new Aspose.PDF.Generator.GraphInfo(); 

 graphInfo1.Color.ColorSpaceType = Aspose.PDF.Generator.ColorSpaceType.Rgb; 

 graphInfo1.Color.RgbColorSpace = System.Drawing.Color.Red; 

 border2.Left = border2.Right = border2.Bottom = border2.Top = graphInfo1; 

 cell2.Border = border2; 

{{< /highlight >}}
{{% /alert %}}
 
{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  cell2.Border = new BorderInfo((int)BorderSide.All,new Color("red"));  


{{< /highlight >}}
{{% /alert %}}
 

## **Tip 6: Using Line constructor**

{{% alert color="primary" %}} 
The Line(float[]) is used to initialize a new instance of the Line class with specified position array. The Line(Graph,float[]) is used to initialize a new instance of the  Line class with specified position array and inherit style information from specified Graph object.
{{% /alert %}}


{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Line l1 = new Aspose.PDF.Generator.Line(graph); 

 Aspose.PDF.Generator.PositionArray posArr = new Aspose.PDF.Generator.PositionArray(); 

 posArr.Length = 4; 

 posArr[0] = 100; 

 posArr[1] = 0; 

 posArr[2] = 300; 

 posArr[3] = 0; 

 l1.PositionArray = posArr; 



{{< /highlight >}}
{{% /alert %}}

{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  float[] posArr = new float[]{100,0,300,0}; 

 Aspose.PDF.Generator.Line l1 = new Aspose.PDF.Generator.Line (graph1,posArr); 

{{< /highlight >}}
{{% /alert %}}

## **Tip 7: Using Rectangle constructor**

{{% alert color="primary" %}} 
The Rectangle(float,float,float,float) constructor is used to initialize a new instance of the Rectangle class with specified position,width and height. The Rectangle(Graph,float,float,float,float) constructor is used to initialize a new instance of the Rectangle  class with specified position, width & height and inherit style information from specified Graph object.
{{% /alert %}}

{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Rectangle rectangle = new Aspose.PDF.Generator.Rectangle(graph); 

 rectangle.Left = 50; 

 rectangle.Bottom = 10; 

 rectangle.Width = 100; 

 rectangle.Height = 50; 

{{< /highlight >}}
{{% /alert %}}

{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Rectangle rectangle = new Aspose.PDF.Generator.Rectangle(graph,50,10,100,50);  

{{< /highlight >}}
{{% /alert %}}

## **Tip 8: Using Arc constructor**


{{% alert color="primary" %}} 
The Arc(float xPosition,float yPosition,float radius,float alpha,float beta) constructor is used to initialize a new instance of the Arc class with specified arc information. The Arc(Graph graph,float xPosition,float yPosition,float radius,float alpha,float beta) constructor is used to initialize a new instance of the Arc class with specified arc information with inherited style information from specified Graph object.
{{% /alert %}}

{{% alert color="primary" %}} 
**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Arc arc = new Aspose.PDF.Generator.Arc(graph); 

 arc.PositionX = 200; 

 arc.PositionY = 50; 

 arc.Radius = 30; 

 arc.Alpha = 30; 

 arc.Beta = 90; 

{{< /highlight >}}
{{% /alert %}}

{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Arc arc = new Aspose.PDF.Generator.Arc(graph,200,50,30,30,90); 

{{< /highlight >}}
{{% /alert %}}

## **Tip 9: Using Circle constructor**


{{% alert color="primary" %}} 
The Circle(float xPosition,float yPosition,float radius) constructor is used to initialize a new instance of the Circle class with specified circle information. The Circle(Graph graph,float xPosition,float yPosition,float radius) constructor initializes a new instance of the Circle class with specified circle information and inherits style information from specified Graph object.
{{% /alert %}}

{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

 Aspose.PDF.Generator.Circle circle = new Aspose.PDF.Generator.Circle(graph); 

circle.PositionX = 200; 

circle.PositionY = 50; 

circle.Radius = 30; 

{{< /highlight >}}
{{% /alert %}}


{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Circle circle = new Aspose.PDF.Generator.Circle(graph,200,50,30); 


{{< /highlight >}}
{{% /alert %}}

## **Tip 10: Using Curve constructor**

{{% alert color="primary" %}} 
The Curve(float[] positionArr) constructor is used to initialize a new instance of the Curve class with specified curve's position information. The Curve(Graph graph,float[] positionArr) constructor initializes a new instance of the Curve class with specified curve's position information and also inherits style information from specified Graph object.
{{% /alert %}}

{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Curve curve = new Aspose.PDF.Generator.Curve(graph); 

 curve.Position1X = 0; 

 curve.Position1Y = 0; 

 curve.Position2X = 200; 

 curve.Position2Y = 80; 

 curve.Position3X = 300; 

 curve.Position3Y = 40; 

 curve.Position4X = 350; 

 curve.Position4Y = 90; 



{{< /highlight >}}
{{% /alert %}}

{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  float[] posArr = new float[]{0,0,200,80,300,40,350,90}; 

 Aspose.PDF.Generator.Curve curve = new Aspose.PDF.Generator.Curve(graph,posArr); 


{{< /highlight >}}
{{% /alert %}}

## **Tip 11: Using Graph constructor**

{{% alert color="primary" %}} 

The Graph(float width,float height) constructor is used to initialize a new instance of the Curve class with specified curve's position information. The Graph(Section section,float width,float height) constructor initializes a new instance of the Curve class with specified curve's position information and inherit common property values from the specified Section object. The Graph(HeaderFooter hf,float width,float height) constructor initializes a new instance of the Curve class with specified curve's position information and inherits common property values from the specified HeaderFooter  object. 
{{% /alert %}}

{{% alert color="primary" %}} 

**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Graph graph = new Aspose.PDF.Generator.Graph(section); 

 graph.GraphHeight = 100; 

 graph.GraphWidth = 400; 



{{< /highlight >}}
{{% /alert %}}


{{% alert color="primary" %}} 
**Better Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Graph graph = new Aspose.PDF.Generator.Graph(section,100,400); 



{{< /highlight >}}
{{% /alert %}}



## **Tip 12: Using Text constructor**

{{% alert color="primary" %}} 

The Text(string content) constructor is used to initialize a new instance of the Text class with specified string as the content of it's first Segment. The Text(string content,TextInfo info) constructor is used to initialize a new instance of the Text class with specified text style and specified string as the content of it's first Segment. The Text(Section section,string content) constructor initializes a new instance of the Text  class with specified string as the content of it's first Segment and inherits text style information from the specified Section object. The Text(HeaderFooter hf,string content) initializes a new instance of the Text class with specified string as the content of it's first Segment and inherits text style information from specified HeaderFooter object.
{{% /alert %}}

{{% alert color="primary" %}} 
**General Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Text text1 = new Aspose.PDF.Generator.Text(section); 

 Aspose.PDF.Generator.Segment segment1 = new Aspose.PDF.Generator.Segment(text1); 

 text1.Segments.Add(segment1); 

 segment1.Content = "this is text content"; 



{{< /highlight >}}
{{% /alert %}}

{{% alert color="primary" %}} 

**Better Approach** 

**C#**

{{< highlight csharp >}}

  Aspose.PDF.Generator.Text text1 = new Aspose.PDF.Generator.Text(section,"this is text content"); 



{{< /highlight >}}
{{% /alert %}}

## **Tip 13: Using default cell format information**

{{% alert color="primary" %}} 

Table.DefaultCellBorder property is used to set the border information of all cells in the Table. Table.DefaultCellTextInfo is used to set the text information of all cells in the Table. Table.DefaultCellPadding is used to set the padding information of all cells in the Table. Table.ColumnWidths is used to set the width of all columns in the Table. Row.DefaultCellTextInfo is used to set text information of all cells in the Row. Table.SetColumnTextInfo() is used to set text information of all cells in the column.

{{% /alert %}}


{{% alert color="primary" %}} 

**General Approach** 




{{< highlight csharp >}}
	<Table>
      <Row> 
         <Cell FitWidth="70"> 
             <Border> 
                 <All Color="Black"></All> 
             </Border> 
             <Text MarginTop="1" MarginBottom="1"> 
                 <Segment>cell1</Segment> 
             </Text> 
         </Cell> 
         <Cell FitWidth="80"> 
             <Border> 
                 <Top Color="Black"></Top> 
                     <Right Color="Black"></Right> 
                     <Bottom Color="Black"></Bottom> 
             </Border> 
             <Text MarginTop="1" MarginBottom="1"> 
                    <Segment>cell2</Segment> 
             </Text> 
         </Cell> 
     </Row> 
 </Table> 
{{< /highlight >}}

{{% /alert %}}


{{% alert color="primary" %}} 

**Better Approach** 

{{< highlight csharp >}}
<Table ColumnWidths="70 80">
      <DefaultCellBorder> 
         <All Color="Black"></All> 
     </DefaultCellBorder> 
     <Row> 
         <Cell> 
             <Text MarginTop="1" MarginBottom="1"> 
                 <Segment>cell1</Segment> 
             </Text> 
         </Cell> 
         <Cell> 
             <Text MarginTop="1" MarginBottom="1"> 
                 <Segment>cell2</Segment> 
             </Text> 
         </Cell> 
     </Row> 
 </Table>
{{< /highlight >}}

{{% /alert %}}

