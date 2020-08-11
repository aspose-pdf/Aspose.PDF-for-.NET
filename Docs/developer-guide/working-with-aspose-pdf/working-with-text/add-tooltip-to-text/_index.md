---
title: Add Tooltip to Text
type: docs
weight: 30
url: /net/add-tooltip-to-text/
---

## **Add Tooltip to Searched Text by adding Invisible Button**
It is often required to add some details for a phrase or specific word as a tooltip in the PDF document so that it can popup when the user hovers the mouse cursor over the text. Aspose.PDF for .NET provides this feature to create tooltips by adding an invisible button over the searched text. The following code snippet will show you the way to achieve this functionality:

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-AddTooltipToText-1.cs" >}}

{{% alert color="primary" %}} 

Concerning to the length of the tooltip, the tooltip text is contained in the PDF document as PDF string type, outside of the content stream. There is no effective restriction on such strings in PDF files (See PDF Reference Appendix C.). However, a conforming reader (e.g. Adobe Acrobat) running on a particular processor and in a particular operating environment does have such a limit. Please refer to your PDF reader application documentation.

{{% /alert %}} 
## **Create a Hidden Text Block and Show it on Mouse Over**
In Aspose.PDF, a feature to hide actions is implemented by which it is possible to show/hide text box field (or any other type of annotation) on mouse enter/exit over some invisible button. For this purpose, Aspose.Pdf.Annotations.HideAction Class is used to assign the action of hide/show to the text block. Please use the following code snippet to Show/Hide a Text Block on Mouse Enter/Exit.

Please also take into account that PDF actions in the documents work fine in the conforming readers (e.g. Adobe Reader) but no warranties for other PDF readers (e.g. web browser plugins). We have provided a brief investigation and found:

- All implementations of the hide action in PDF documents work fine in Internet Explorer v.11.0.
- All implementations of the hide action also work in Opera v.12.14, but we spot some response delay at the first opening of the document.
- Only implementation using HideAction constructor accepting field name works if Google Chrome v.61.0 browses the document; Please use corresponding constructors if browsing in the Google Chrome is significant:

**C#**

{{< highlight csharp >}}

 buttonField.Actions.OnEnter = new HideAction(floatingField.FullName, false);

buttonField.Actions.OnExit = new HideAction(floatingField.FullName);

{{< /highlight >}}

Any implementation of the hide action in PDF documents doesn't work if Mozilla Firefox v.47.0 browses the document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Text-HiddenTextBlock-1.cs" >}}
