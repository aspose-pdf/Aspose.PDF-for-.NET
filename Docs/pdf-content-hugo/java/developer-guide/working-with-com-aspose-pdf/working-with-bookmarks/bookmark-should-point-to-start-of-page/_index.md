---
title: Bookmark Should Point to Start of page
type: docs
weight: 50
url: /java/bookmark-should-point-to-start-of-page/
---

{{% alert color="primary" %}} 

Aspose.PDF for Java supports the feature to add, update or delete bookmarks in PDF files. This API also supports the feature to edit the destination property for existing bookmarks and set it to the start of the page.

{{% /alert %}} 

The following code snippet shows the steps to edit the destination of a bookmark to the start of the page.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-BookmarkShouldPointToStartOfPage-BookmarkShouldPointToStartOfPage.java" >}}


### **Set Destination while Creating PDF**
This API also offers the feature to set the destination page number and specific position on the page when creating new PDF document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-BookmarkShouldPointToStartOfPage-SetDestinationWhileCreatingPDF.java" >}}


### **Setting ViewerPreferences**
You can also set specific [ViewerPreference](https://apireference.aspose.com/java/pdf/com.aspose.pdf.facades/ViewerPreference) in the following manner.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-bookmarks-BookmarkShouldPointToStartOfPage-SettingViewerPreferences.java" >}}
### **Destination Syntax from Adobe Portable Document Format Version 1.3**
**page /XYZ left top zoom** 
Display the page designated by page, with the coordinates (left, top) positioned at the upper-left corner of the window and the contents of the page magnified by the factor zoom. A null value for any of the parameters left, top, or zoom specifies that the current value of that parameter shall be retained unchanged. A zoom value of 0 has the same meaning as a null value.

**page /Fit** 
Display the page designated by page, with its contents magnified just enough to fit the entire page within the window both horizontally and vertically. If the required horizontal and vertical magnification factors are different, use the smaller of the two, centering the page within the window in the other dimension.

**page /FitH top** 
Display the page designated by page, with the vertical coordinate top positioned at the top edge of the window and the contents of the page magnified just enough to fit the entire width of the page within the window. A null value for top specifies that the current value of that parameter shall be retained unchanged.

**page /FitV left** 
Display the page designated by page, with the horizontal coordinate left positioned at the left edge of the window and the contents of the page magnified just enough to fit the entire height of the page within the window. A null value for left specifies that the current value of that parameter shall be retained unchanged.

**page /FitR left bottom right top** 
Display the page designated by page, with its contents magnified just enough to fit the rectangle specified by the coordinates left, bottom, right, and top entirely within the window both horizontally and vertically. If the required horizontal and vertical magnification factors are different, use the smaller of the two, centering the rectangle within the window in the other dimension.

**page /FitB** 
(PDF 1.1) Display the page designated by page, with its contents magnified just enough to fit its bounding box entirely within the window both horizontally and vertically. If the required horizontal and vertical magnification factors are different, use the smaller of the two, centering the bounding box within the window in the other dimension.

**page /FitBH top** 
(PDF 1.1) Display the page designated by page, with the vertical coordinate top positioned at the top edge of the window and the contents of the page magnified just enough to fit the entire width of its bounding box within the window. A null value for top specifies that the current value of that parameter shall be retained unchanged.

**page /FitBV left** 
(PDF 1.1) Display the page designated by page, with the horizontal coordinate left positioned at the left edge of the window and the contents of the page magnified just enough to fit the entire height of its bounding box within the window. A null value for left specifies that the current value of that parameter shall be retained unchanged.
