---
title: Create Accessible PDF Files
type: docs
weight: 10
url: /java/create-accessible-pdf-files/
---

{{% alert color="primary" %}} 

Aspose.PDF provides functionality to create PDF documents which are compatible with PDF/UA Standard (also known as "Section 508" or "WCAG Standard") and also to check compatibility with these standards. These standards describe requirements for document contents to make it more friendly and useful for people with disabilities and also for users with highly limited devices. When you make your PDF documents accessible or create Tagged PDFs, it means adding tags, bookmarks, alt text, and other information that makes the files readable and navigable to users who are visually or mobility impaired. Using Aspose.PDF, it is now achievable to create valid, accessible PDF documents. Following section shows how to add tagged content to create Tagged PDF.

{{% /alert %}} 
## **Create Tagged PDF**
A PDF file can contain many things including text, graphics, bookmarks, links and other elements of content that take part in making complete electronic document. Additionally, PDF documents may also include "structure" which is term for a set of instructions that define the logic of binding the content together. This structure is expressed via "tags" which are meant to be generated to make PDF document compliant with Section 508. Aspose.PDF provides the capability to create accessible or tagged content while creating a PDF document.
### **Create PDF Document with Tagged Text**
In order to create PDF Document with Tagged Text, Aspose.PDF offers **TaggedPdfTextElement** Class to serve the purpose. Following code snippet shows how to create a PDF document with Tagged Text:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-CreatePDFwithTaggedText.java" >}}
### **Create PDF Document with Tagged Image**
Aspose.PDF provides **TaggedPdfFigureElement** Class to create Tagged Image inside PDF document as demonstrated in below code example:

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-CreatePDFwithTaggedImage.java" >}}
