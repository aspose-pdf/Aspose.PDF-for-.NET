---
title: Adding JavaScript in Python
type: docs
weight: 10
url: /java/adding-javascript-in-python/
---

To append Add Javascript using Aspose.PDF Java in Python, simply invoke the AddJavascript() method of Document class.

**Python Code**

{{< highlight java >}}



doc= self.Document()

pdf = self.Document()

pdf=self.dataDir + 'Template.pdf'

javaScript = self.JavascriptAction("this.print({bUI:true,bSilent:false,bShrinkToFit:true});");

doc.setOpenAction(javaScript)

js=self.JavascriptAction("app.alert('page 2 is opened')")

\# Adding JavaScript at Page Level

doc.getPages.get_Item(2)

doc.getActions().setOnOpen(js())

doc.getPages().get_Item(2).getActions().setOnClose(self.JavascriptAction("app.alert('page 2 is closed')"))

\# Save PDF Document

doc.save(self.dataDir + "JavaScript-Added.pdf")

print "Added JavaScript Successfully, please check the output file."

{{< /highlight >}}

**Download Running Code**

Download **Add Javascript (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/blob/master/Plugins/Aspose_Pdf_Java_for_Python/test/WorkingWithDocumentObject/AddJavascript/AddJavascript.py)
- [CodePlex](http://asposepdfjavapython.codeplex.com/SourceControl/latest#test/WorkingWithDocumentObject/AddJavascript/AddJavascript.py)
