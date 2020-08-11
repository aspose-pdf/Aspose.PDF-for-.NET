---
title: Force Table Rendering on New Page
type: docs
weight: 20
url: /java/force-table-rendering-on-new-page/
---

{{% alert color="primary" %}} 

The com.aspose.pdf.[Table](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table) class provides makes it possible to create/render tables in PDF documents. A similar feature is also supported by the aspose.pdf.[Table](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Table) class but we encourage our customers to try using the latest Document Object Model (DOM) of the com.aspose.pdf package, because all the new features and issue resolution is being performed in new DOM. However, the legacy Aspose.PDF for Java (the aspose.pdf package) has a method [isInNewPage(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BaseParagraph#isInNewPage--) in the paragraph class, so that the paragraph is rendered on a new page. For backward compatibility, the [isInNewPage(..)](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BaseParagraph#isInNewPage--) method has been added to the [BaseParagraph](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BaseParagraph) class.

{{% /alert %}} 

The following code snippets show the steps to create a table and force it to render on new page.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-tables-ForceTableRenderingOnNewPage-.java" >}}



