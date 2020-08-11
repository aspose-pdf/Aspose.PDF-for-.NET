---
title: Quick Tips
type: docs
weight: 50
url: /java/quick-tips/
---

{{% alert color="primary" %}} 

This page contains some quick tips related to Aspose.PDF for Java API

{{% /alert %}} 
#### **Add JavaScript to PDF**
The following code snippet can be used to set/add JavaScript to PDF file.

{{< highlight java >}}

 String path = "D:\\";

String fileOut = path + "JavaScript.pdf";

IDocument document = null;

try

{

    document = new Document();

    document.getPages().add();

    document.getPages().add();

    //Adding JavaScript at Document Level

    //Instantiate JavascriptAction with desried JavaScript statement

    JavascriptAction javaScript = new JavascriptAction("this.print({bUI:true,bSilent:false,bShrinkToFit:true});");

    //Assigne JavascriptAction object to desired action of Document

    document.setOpenAction(javaScript);

    document.setOpenAction(new JavascriptAction("app.alert('Hello PDF')"));

    //Adding JavaScript at Page Level

    document.getActions().setBeforeClosing(new JavascriptAction("app.alert('document is closing')"));

    document.getPages().get_Item(1).getActions().setOnOpen(new JavascriptAction("app.alert('page 1 is opened')"));

    document.getPages().get_Item(2).getActions().setOnOpen(new JavascriptAction("app.alert('page 2 is opened')"));

    document.getPages().get_Item(2).getActions().setOnClose(new JavascriptAction("app.alert('page 2 is closed')"));

    document.save(fileOut);

}

finally { if (document != null) document.dispose(); document = null; }

{{< /highlight >}}

**Some more examples**

{{< highlight java >}}

 // after printing

document.getActions().setAfterPrinting(new JavascriptAction("app.alert('File was printed')"));

// after saving

document.getActions().setAfterSaving(new JavascriptAction("app.alert('File was Saved')"));

{{< /highlight >}}
#### **Free utilized Memory**
If you have completed the work with Aspose.PDF for Java and wants to clear the memory from different static instances,
to make the maximum memory for other processes, you should execute following code line:

{{< highlight java >}}

 com.aspose.pdf.MemoryCleaner.clear();

{{< /highlight >}}
#### **Load PDF from ByteArrayInputStream**
The following code snippet shows the steps to laod PDF file into ByteArray and then instantiate Document object with ByteArrayInputStream.

{{< highlight java >}}

 // source PDF file 

java.io.File file = new java.io.File("c:/pdftest/result.pdf");

java.io.FileInputStream fis = new java.io.FileInputStream(file);

//System.out.println(file.exists() + "!!");

//InputStream in = resource.openStream();

java.io.ByteArrayOutputStream bos = new java.io.ByteArrayOutputStream();

byte[] buf = new byte[1024];

try {

    for (int readNum; (readNum = fis.read(buf)) != -1;) {

        bos.write(buf, 0, readNum); //no doubt here is 0

        //Writes len bytes from the specified byte array starting at offset off to this byte array output stream.

        System.out.println("read " + readNum + " bytes,");

    }

} catch (java.io.IOException ex) {



}

byte[] bytes = bos.toByteArray();

// instantiate Document Object with ByteArrayInputStream while passing byte array as argument

com.aspose.pdf.Document doc = new 	com.aspose.pdf.Document(new java.io.ByteArrayInputStream(bytes));

// get the page count of PDF file

 System.out.println(doc.getPages().size());

{{< /highlight >}}
#### **Save PDF to ByteArrayOutputStream**
The following code snippet shows the steps to save resultant PDF file into ByteArrayOutputStream.

{{< highlight java >}}

 com.aspose.pdf.Document pdfDocument = new 	com.aspose.pdf.Document("source.pdf");

java.io.InputStream is = null;

java.io.ByteArrayOutputStream os = new java.io.ByteArrayOutputStream();

try{

pdfDocument.save(os,com.aspose.pdf.SaveFormat.Doc);

System.out.println(os.size());

is = new java.io.ByteArrayInputStream(os.toByteArray());

            os.close();

            os.flush();

pdfDocument.close();

}catch (Throwable e) {}

{{< /highlight >}}
