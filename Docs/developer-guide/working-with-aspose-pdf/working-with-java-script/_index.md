---
title: Working with JavaScript
type: docs
weight: 60
url: /net/working-with-javascript/
---

## **Adding JavaScript (DOM)**
### **What is Acrobat JavaScript?**
Acrobat JavaScript is a language based on the core of JavaScript version 1.5 of ISO-16262, formerly known as ECMAScript, an object-oriented scripting language developed by Netscape Communications. JavaScript was created to offload Web page processing from a server onto a client in Web-based applications. Acrobat JavaScript implements extensions, in the form of new objects and their accompanying methods and properties, to the JavaScript language. These Acrobat-specific objects enable a developer to manage document security, communicate with a database, handle file attachments, manipulate a PDF file so that it behaves like an interactive, web-enabled form, and so on. Because the Acrobat-specific objects are added on top of core JavaScript, you still have access to its standard classes, including Math, String, Date, Array, and RegExp.
### **Acrobat JavaScript vs HTML (Web) JavaScript**
PDF documents have great versatility since they can be displayed both within the Acrobat software as well as a Web browser. Therefore, it is important to be aware of the differences between Acrobat JavaScript and JavaScript used in a Web browser, also known as HTML JavaScript :

- Acrobat JavaScript does not have access to objects within an HTML page. Similarly, HTML JavaScript cannot access objects within a PDF file.
- HTML JavaScript is able to manipulate such objects as Window. Acrobat JavaScript cannot access this particular object but it can manipulate PDF-specific objects.

You can add JavaScript at both the document and page levels using [Aspose.PDF for .NET](/pdf/net/). To add JavaScript:
### **Adding JavaScript to Document or Page Action**
1. Declare and instantiate a JavascriptAction object with desired JavaScript statement as the constructor argument.
1. Assign the JavascriptAction object to the desired action of the PDF document or page.

The example below applies the OpenAction to a specific document.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-AddJavaScriptToPage-AddJavaScriptToPage.cs" >}}
### **Adding/Removing JavaScript to Document Level**
A new property named JavaScript is added in Document class which has JavaScript collection type and provides access to JavaScript scenarios by its key. This property is used to add Document level JavaScript. The JavaScript collection has the following properties and methods:

- string this(string key)– Gets or sets JavaScript by its name
- IList Keys – provides a list of existing keys in JavaScript collection
- bool Remove(string key) – removes JavaScript by its key.

{{< gist "aspose-pdf" "7e1330795d76012fcb04248bb81d45b3" "Examples-CSharp-AsposePDF-Working-Document-AddRemoveJavascriptToDoc-AddRemoveJavascriptToDoc.cs" >}}