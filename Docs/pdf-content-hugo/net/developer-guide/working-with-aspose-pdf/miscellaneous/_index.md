---
title: Miscellaneous
type: docs
weight: 200
url: /net/miscellaneous/
---

## **Getting Product and Build Information**
Sometimes, developers need to find information about a component being used in their code. Aspose.PDF contains the [BuildVersionInfo](/pages/createpage.action?spaceKey=pdfnet&title=Aspose.PDF.BuildVersionInfo+Class&linkCreation=true&fromPageId=7117551) class which provides three static members: Product, FileVersion, AssemblyVersion. These members can be used to get information about the component. The following code snippet shows how to get the product and build information.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Miscellaneous-GetBuildInformation-GetBuildInformation.cs" >}}
## **Use API as Measurement Tool**
Aspose.PDF for .NET is PDF creation and manipulation API. However, recently we received a requirement to use this API to add measurement elements (like we do using the measurement tool in Adobe Acrobat) to a PDF document. Something similar to [measure the height, width, or area of objects](http://help.adobe.com/en_US/acrobat/X/standard/using/WS58a04a822e3e50102bd615109794195ff-7f9d.w.html#WS58a04a822e3e50102bd615109794195ff-7f91.w)

To accomplish this requirement, a class called Measure has been added to the Aspose.InteractiveFeatures.Annotations namespace. It describes the measure coordinate system. This class contains descriptions of measure units which are used to measure objects, data format, display options, recalculation factor etc. This information is stored for measure annotations, a feature available from Aspose.PDF for .NET 9.5 .0.

During the implementation of this feature, we did not notice how this information affects the display of measure objects in PDF page but this object is created when we create measure lines using Adobe Acrobat. Also one needs to read this data which is created by other application.

The measure object is created using the existing annotation types: LineAnnotation for linear measure and PolyLineAnnotation for area and perimeter measure. To accomplish the above stated requirement, you may consider using the following code snippets which can be used to create measure objects (distance line and perimeter/area line).

{{% alert color="primary" %}} 

The Measure property is added to the LineAnnotation and PolyLineAnnotation classes.

{{% /alert %}} 
### **Measure class members**
`  `constructor:
`    `public Measure(Annotation annotation)
#### **Measure class Properties:**
- ScaleRatio - A text string expressing the scale ratio of the drawing.
- XFormat - A number format array for measurement of change along the X-axis and, if Y is not present, along the Y-axis as well.
- YFormat - A number format array for measurement of change along the Y-axis.
- DistanceFormat - A number format array for measurement of distance in any direction.
- AreaFormat - A number format array for measurement of area.
- AngleFormat - A number format array for measurement of angles.
- SlopeFormat - A number format array for measurement of the slope of a line.
- Origin - Point that shall specify the origin of the measurement coordinate system in default user space coordinates.
- XYFactor - A factor that shall be used to convert the largest units along the y axis to the largest units along the x axis.
### **NumberFormat class**
The NumberFormat class has been added to the Measure class and represents the number format used for measures.

`  `constructor:
`    `public NumberFormat(Measure measure)
#### **NumberFormat class Properties**
- UnitLabel - A text string specifying a label for displaying the units.
- ConversionFactor - The conversion factor used to multiply a value in partial units of the previous number format array element to obtain a value in the units of this number format.
- FractionDisplayment - In what manner fractional values are displayed.
- Precision - If FractionDisplayment is set to ShowAsDecimal, this value is the precision of the fractional value. It shall be a multiple of 10. The default is 100.
- Denominator - If FractionDisplayment is set to ShowAsFraction, this value is the denominator of the fraction. The default value is 16.
- ForceDenominator - If FractionDisplayment is set to ShowAsFraction, this value determines whether or not the fraction may be reduced. If the value is true, the fraction may not be reduced.
- ThousandsSeparator - Text that shall be used between orders of thousands in display of numerical values. An empty string indicates that no text shall be added. Default is comma (,).
- FractionSeparator - Text that shall be used as the decimal position in displaying numerical values. An empty string indicates that the default shall be used. Default is period character (.).
- BeforeText - Text that shall be concatenated to the left of the label.
- AfterText - Text that shall be concatenated after the label.
### **FractionStyle enumeration**
The FractionStyle enumeration has been added to the NumberFormat class.
#### **FractionStyle Values**
- ShowAsDecimal - Show fractional values as decimal fraction.
- ShowAsFraction - Show fractional value as fraction.
- Round - Round fractional values to the nearest whole integer.
- Truncate - Truncate to achieve whole units.
### **NumberFormatList class**
The NumberFormatList class has been added to the Measure class and represents list of number formats.

`  `constructor
`    `public NumberFormatList(Measure measure)
#### **NumberFormatList Properties**
- Item(System.Int32) - Gets or sets number format in list by its index.
- Count - Count if items in the list.
#### **Methods**
- public void Add(NumberFormat value)
  `    `Adds number format to list.
- public void Insert(int index, NumberFormat value)
  `    `Inserts number format into list.
- public void RemoveAt(int index)
  `    `Removes number format from list.
### **Example Code**
The following example demonstrates how to use Measure with LineAnnotation.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Miscellaneous-UseMeasureWithLineAnnotation-UseMeasureWithLineAnnotation.cs" >}}

The following example demonstrates how to use Measure with PolylineAnnotation.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Miscellaneous-UseMeasureWithPolylineAnnotation-UseMeasureWithPolylineAnnotation.cs" >}}

The following code snippet demonstrates how to read Measure properties.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Miscellaneous-ReadMeasure-ReadMeasure.cs" >}}
