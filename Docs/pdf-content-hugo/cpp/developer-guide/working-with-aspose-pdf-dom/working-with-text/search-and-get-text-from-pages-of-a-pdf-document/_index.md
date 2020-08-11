---
title: Search and Get Text from Pages of a PDF Document
type: docs
weight: 20
url: /cpp/search-and-get-text-from-pages-of-a-pdf-document/
---

## **Search a Particular Text and Change its Style**
In order to search a particular text in a PDF document, Aspose.PDF for C++ offers **TextFragmentAbsorber** class, which allows you to find text, matching a particular phrase, from all the pages of a PDF document as well as from a single page. In order to search text, you need to call the **Accept** method of **Pages** collection or a **Page** object. The **Accept** method takes **TextFragmentAbsorber** object as parameter, which returns a collection of **TextFragment** objects. You can then access the Text and change its style (e.g font, background color, etc.). Following code snippet shows you how to create **TextFragmentAbsorber** object to find all occurrences of particular text and change its style.



{{< gist "aspose-pdf" "e5fb9ddf5bd6460bb13d47fe5a83d86d" "Examples-PdfCPP-Text-FindText-FindText.cpp" >}}
