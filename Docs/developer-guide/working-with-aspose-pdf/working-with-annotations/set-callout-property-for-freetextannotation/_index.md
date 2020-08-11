---
title: Set Callout Property for FreeTextAnnotation
type: docs
weight: 30
url: /net/set-callout-property-for-freetextannotation/
---

{{% alert color="primary" %}} 

This feature is supported by version 19.6 or greater.

{{% /alert %}} 
## **Set Callout Property for FreeTextAnnotation**
For a more flexible configuration of annotation in the PDF document, Aspose.PDF for .NET provides [Callout](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation/properties/callout) property of [FreeTextAnnotation](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation) class which allows specifying Array of point of callout line. The following code snippet show, how to use this functionality:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Annotations-SetCalloutProperty-1.cs" >}}
## **Set Callout Property for XFDF File**
If you use import from XFDF file please use **callout-line** name instead just [Callout](https://apireference.aspose.com/net/pdf/aspose.pdf.annotations/freetextannotation/properties/callout)**.** The following code snippet shows, how to use this functionality:

{{< gist "aspose-com-gists" "63473b1ba28e09e229cfbf4430eabd8a" "Examples-CSharp-AsposePDF-Annotations-SetCalloutProperty-SetCalloutPropertyXFDF.cs" >}}

The following method is being used to CreateXfdf:

{{< highlight java >}}

 /// <summary>

/// Create XFDF

/// </summary>

/// <param name="pXfdf"></param>

static void CreateXfdf(ref StringBuilder pXfdf)

{

    pXfdf.Append("<freetext");

    pXfdf.Append(" page=\"0\"");

    pXfdf.Append(" rect=\"422.25,645.75,583.5,702.75\"");

    pXfdf.Append(" intent=\"FreeTextCallout\"");

    pXfdf.Append(" callout-line=\"428.25,651.75,462.75,681.375,474,681.375\"");

    pXfdf.Append(" tail=\"OpenArrow\"");

    pXfdf.AppendLine(">");

    pXfdf.Append("<contents-richtext><body ");

    pXfdf.Append(" style=\"font-size:10.0pt;text-align:left;color:#FF0000;font-weight:normal;font-style:normal;font-family:Helvetica;font-stretch:normal\">");

    pXfdf.Append("<p dir=\"ltr\">This is a sample</p>");

    pXfdf.Append("</body></contents-richtext>");

    pXfdf.AppendLine("<defaultappearance>/Helv 12 Tf 1 0 0 rg</defaultappearance>");

    pXfdf.AppendLine("</freetext>");

}

{{< /highlight >}}
