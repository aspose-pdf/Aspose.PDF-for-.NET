---
title: Manipulate tables in existing PDF
type: docs
weight: 30
url: /java/manipulate-tables-in-existing-pdf/
---

{{% alert color="primary" %}} 

One of the earliest features supported by Aspose.PDF for Java is its capabilities of [Working with Tables](http://www.aspose.com/docs/display/pdfjava/Working+with+Tables+\(DOM\)) and it provides great support for adding tables in PDF files being generated from scratch or any existing PDF files. You also get the capability to dynamically create tables and place them inside PDF file. Starting [Aspose.PDF for Java 10.6.0](http://www.aspose.com/community/files/72/java-components/aspose.pdf-for-java/entry649204.aspx), a new feature of searching and parsing simple tables that already exist in PDF document has been provided. A new class named **com.aspose.pdf.TableAbsorber** provides these capabilities. The usage of TableAbsorber is very much similar to existing TextFragmentAbsorber class.

{{% /alert %}} 

The following code snippet shows the steps to update contents in particular table cell.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-tables-ManipulateTablesInExistingPDF-.java" >}}
#### **Future Enhancements**
Features related to this functionality which still need to be implemented.

- One of the customers has requested to fetch the data based on the blocks of table or borders (as given in the diagram) and colors as well.
- Currently TableAbsorber cannot recognize table cell background color now. However we expect to make this improvement in this future and a separate ticket is already created in our issue tracking system.
- Another customer wants to get contents of column in the table. Currently TableAbsorber cannot recognize table without borders, but conversion to XLS works well in such cases. However conversion to XLS is a workaround. An enhancement ticket has been logged to improve TableAbsorber for working with such table types.
- A Customer wants to update table in existing PDF dynamically. Including deleting / insertion of rows. This request is a bit difficult to implement and current implementation of TableAbsorber cannot fulfill such requirements.
- If you have a requirement of looking for text property in [Cells](https://apireference.aspose.com/java/pdf/com.aspose.pdf/Cells) or [BaseParagraph](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BaseParagraph) types, (such types are designed for adding new contents on the page), you must cast [BaseParagraph](https://apireference.aspose.com/java/pdf/com.aspose.pdf/BaseParagraph) to one of the inherited types. For example next code must help:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Tables-ManipulateTablesInExistingPDF-FutureEnhancements.java" >}}
