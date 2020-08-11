---
title: Get Document Window and Page Display Properties in Python
type: docs
weight: 30
url: /java/get-document-window-and-page-display-properties-in-python/
---

To Get Document Window and Page Display Properties of Pdf document using **Aspose.PDF Java for Python**, simply invoke **GetDocumentWindow** class.

**Python Code**

{{< highlight java >}}

 doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'input1.pdf'

\# Get different document properties

\# Position of document's window - Default: false

print "CenterWindow :- " + str(doc.getCenterWindow())

\# Predominant reading order; determine the position of page

\# when displayed side by side - Default: L2R

print "Direction :- " + str(doc.getDirection())

\# Whether window's title bar should display document title.

\# If false, title bar displays PDF file name - Default: false

print "DisplayDocTitle :- " + str(doc.getDisplayDocTitle())

#Whether to resize the document's window to fit the size of

#first displayed page - Default: false

print "FitWindow :- " + str(doc.getFitWindow())

\# Whether to hide menu bar of the viewer application - Default: false

print "HideMenuBar :-" + str(doc.getHideMenubar())

\# Whether to hide tool bar of the viewer application - Default: false

print "HideToolBar :-" + str(doc.getHideToolBar())

\# Whether to hide UI elements like scroll bars

\# and leaving only the page contents displayed - Default: false

print "HideWindowUI :-" + str(doc.getHideWindowUI())

\# The document's page mode. How to display document on exiting full-screen mode.

print "NonFullScreenPageMode :-" + str(doc.getNonFullScreenPageMode())

\# The page layout i.e. single page, one column

print "PageLayout :-" + str(doc.getPageLayout())

#How the document should display when opened.

print "pageMode :-" + str(doc.getPageMode())


{{< /highlight >}}

**Download Running Code**

Download **Get Document Window and Page Display Properties (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/GetDocumentWindow/GetDocumentWindow.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/GetDocumentWindow/GetDocumentWindow.py)
