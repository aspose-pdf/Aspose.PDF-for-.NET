---
title: Migrating your code to Aspose.PDF for Java 2.5.0
type: docs
weight: 10
url: /java/migrating-your-code-to-aspose-pdf-for-java-2-5-0/
---

{{% alert color="primary" %}} 

In this article we have tried highlighting some of the areas from an existing code of Aspose.PDF for Java to make it compatible with the latest release version. 

{{% /alert %}} 
##### **Details**
With the release of Aspose.PDF for Java 2.5.0, there have been lots of changes in the API structure and class es construction. M ost of the class member’s names are updated, some existing class members are removed and also few more methods and properties are added to existing classes. Just to give you a brief of changes, we a re going to have a look over the following simple code , based over Aspose.PDF for Java versions published earlier to 2.5.0. 

In this simple code, we will add a hyperlink and link to the page within the same PDF document. 



**Java**

{{< highlight csharp >}}



import com.aspose.pdf.elements.*;



com.aspose.pdf.License lic = new com.aspose.pdf.License();

try {

lic.setLicense(new FileInputStream(new File("Aspose.Total.Java.lic")));

    } catch (Exception e)

{

System.out.println(e.getMessage());

}



//Instantiate a Pdf object by calling its empty constructor

Pdf pdf1 = new Pdf();

//Create a section in the Pdf object

Section sec1 = pdf1.getSections().add();

//Create text paragraph with the reference of a section

Text text1 = new Text(sec1); 

//Add the text paragraph in the paragraphs collection of the section

sec1.getParagraphs().add(text1); 

//Add a text segment in the text paragraph

Segment segment1 = text1.getSegments().add("this is a local link"); 

//Set the text in the text segment to be underlined

segment1.getTextInfo().setUnderLine(true); 



//Set the link type of the text segment to Local

//Assign the id of the desired paragraph as a target id for the text segment

segment1.setHyperLink(new HyperLinkToLocalPdf("product1")); 

//Create a text paragraph to be linked with the text segment

Text text3 = new Text(sec1,"product 1 info ..."); 

//Add the text paragraph to paragraphs collection of the section

sec1.getParagraphs().add(text3); 

//Set this paragraph to be the first so that it can be displayed in a separate

//page in the document

text3.setFirstParagraph(true); 

//Set the id of this text segment to "product1" 

text3.setID("product1"); 



// save the PDF file

FileOutputStream out = new FileOutputStream(new File("UpdateOfCode_Test.pdf"));

pdf1.save(out);



{{< /highlight >}}

When using the versions earlier to Aspose.PDF for Java 2.5.0, the code can successfully be executed and a resultant PDF document containing a hyperlink towards a page within the same document , can be generated. But, when the same code is compiled with 2.5.0 , you will notice number of errors because , there ha ve been change s in the class members and also some of the methods in classes have been removed . Now let ’ s start with the modification of code for version 2.5.0 

Use **import aspose.pdf.**;* instead of  **import com.aspose.pdf.elements.**;* to include the package. 

For license initialization, please update your existing code from  



**com.aspose.pdf.License lic = new com.aspose.pdf.License();**

{{< highlight csharp >}}

 try

{

lic.setLicense(new FileInputStream(new File("Aspose.Total.Java.lic")));

}



{{< /highlight >}}

to  



**aspose.pdf.License lic = new aspose.pdf.License();**

{{< highlight csharp >}}

 try

{

lic.setLicense(new FileInputStream(new File("Aspose.Total.Java.lic")));

}



{{< /highlight >}}

**TextInfo** does not contain a method **setUnderLine(...)** anymore. Please try using **TextInfo.setIsUnderline(...)** ** instead **.** 

The class named  **HyperLinkToLocalPdf** has been removed. So please update your any existing code like 



**//Set the link type of the text segment to Local**

{{< highlight csharp >}}

 //Assign the id of the desired paragraph as a target id for the text segment

segment1.setHyperLink(new HyperLinkToLocalPdf("product1")); 



{{< /highlight >}}

to 



**segment1.getHyperlink().setLinkType(HyperlinkType.Local);**

{{< highlight csharp >}}

 segment1.getHyperlink().setTargetID("product1");



{{< /highlight >}}

The method name **setFirstParagraph** is removed from Text class . So in order to display the text segment in new page, you need to create a new Section object and add the text object to the newly created section. As b y default every section is displayed over new page, so there is no need for calling a method like   **sec2.setIsNewPage(** **true** **);** 
##### **Updated Save method**
The save method in Pdf class which used to take FileOutputStream object as an argument, has been removed. In new version, you can use either of the following overloaded method s of save. 

- save(BasicStream stream) 
- save(java.lang.String pdfFile) 
- save(java.lang.String fileName, SaveType saveType, aspose.pdf.HttpResponse response) 

After making all above specified changes, when using Aspose.PDF for Java 2.5.0 , the code will be compiled and executed without showing any error message s. The complete update d code snippet is specified below. 

**Java**

{{< highlight csharp >}}

 import aspose.pdf.*;



aspose.pdf.License lic = new aspose.pdf.License();

try {

lic.setLicense(new FileInputStream(new File("Aspose.Total.Java.lic")));

    } catch (Exception e) 

{

System.out.println(e.getMessage());

}



try {

//Instantiate a Pdf object by calling its empty constructor

Pdf pdf1 = new Pdf();

//Create a section in the Pdf object

Section sec1 = pdf1.getSections().add();

//Create text paragraph with the reference of a section

Text text1 = new Text(sec1); 

//Add the text paragraph in the paragraphs collection of the section

sec1.getParagraphs().add(text1); 

//Add a text segment in the text paragraph

Segment segment1 = text1.getSegments().add("this is a local link"); 

//Set the text in the text segment to be underlined

segment1.getTextInfo().setIsUnderline(true); 



//Set the link type of the text segment to Local

//Assign the id of the desired paragraph as a target id for the text segment

segment1.getHyperlink().setLinkType(HyperlinkType.Local);

segment1.getHyperlink().setTargetID("product1");

// add a new section which will hold the text object with ID "Product 1"

Section sec2 = pdf1.getSections().add();

//Create a text paragraph to be linked with the text segment

Text text3 = new Text(sec1,"product 1 info ..."); 

//Add the text paragraph to paragraphs collection of the section

sec2.getParagraphs().add(text3); 

//Set the id of this text segment to "product1" 

text3.setID("product1");



// save the PDF file

pdf1.save("UpdateOfCode_Test.pdf");



     }catch(Exception e)

{

System.out.println(e.getMessage());

}



{{< /highlight >}}
##### **Conclusion**
In above topic we have explained some of the classes and methods that have been changed in new release. For a complete list of all the classes and their members, please visit [Aspose.PDF for Java API Reference](http://www.aspose.com/documentation/java-components/aspose.pdf-for-java/aspose.pdf-for-java-api-reference.html)

{{% alert color="primary" %}} 

To learn more about Aspose and its products, please click here <http://www.aspose.com/>

{{% /alert %}}
