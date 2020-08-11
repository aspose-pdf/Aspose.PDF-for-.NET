---
title: Working with JavaScript
type: docs
weight: 140
url: /java/working-with-javascript/
---

## **Adding JavaScript (DOM)**
### **What is Acrobat JavaScript?**
Acrobat JavaScript is a language based on the core of JavaScript version 1.5 of ISO-16262, formerly known as ECMAScript, an object-oriented scripting language developed by Netscape Communications. JavaScript was created to offload Web page processing from a server onto a client in Web-based applications. Acrobat JavaScript implements extensions, in the form of new objects and their accompanying methods and properties, to the JavaScript language. These Acrobat-specific objects enable a developer to manage document security, communicate with a database, handle file attachments, manipulate a PDF file so that it behaves like an interactive, web-enabled form, and so on. Because the Acrobat-specific objects are added on top of core JavaScript, you still have access to its standard classes, including Math, String, Date, Array, and RegExp.
### **Acrobat JavaScript vs HTML (Web) JavaScript**
PDF documents have great versatility since they can be displayed both within the Acrobat software as well as in a Web browser. Therefore, it is important to be aware of the differences between Acrobat JavaScript and JavaScript used in a Web browser, also known as HTML JavaScript :

- Acrobat JavaScript does not have access to objects within an HTML page. Similarly, HTML JavaScript cannot access objects within a PDF file.
- HTML JavaScript is able to manipulate such objects as Windows. Acrobat JavaScript cannot access this particular object but it can manipulate PDF-specific objects.

You can add JavaScript at both the document and page levels with Aspose.PDF for Java. To add JavaScript:

1. Declare and instantiate a [JavascriptAction](https://apireference.aspose.com/java/pdf/com.aspose.pdf/JavascriptAction) object with the desired JavaScript statement as the constructor argument.
1. Assign the JavascriptAction object to the desired action of the PDF document or page.

The example below applies the OpenAction to a specific document.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-AddingJavaScriptDOM-AddingJavaScriptDOM.java" >}}
### **Add Formatting Code and Value Validation**
The following code snippet shows the steps to add formatting code and value validation using JavaScript.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-AddingJavaScriptDOM-AddFormattingCodeAndValueValidation.java" >}}
### **After Printing and Saving**
{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-NewDocumentObject-AddingJavaScriptDOM-AfterPrintingAndSaving.java" >}}
