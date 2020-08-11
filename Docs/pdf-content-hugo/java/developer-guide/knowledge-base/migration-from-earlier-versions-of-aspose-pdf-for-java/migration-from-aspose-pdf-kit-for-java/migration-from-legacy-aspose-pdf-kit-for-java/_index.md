---
title: Migration from legacy Aspose.Pdf.Kit for Java
type: docs
weight: 10
url: /java/migration-from-legacy-aspose-pdf-kit-for-java/
---

{{% alert color="primary" %}} 

The current Aspose.PDF.Kit for Java component provided the features to manipulate existing PDF files. However sometimes sooner, this component will be discontinued as separate product because we have ported all its classes and enumerations under **com.aspose.pdf.facades** package of new autoported release of Aspose.PDF for Java (4.x.x). Now this single autoported release provides the capabilities to create as well as manipulate existing PDF files.

{{% /alert %}} 
#### **Support for Legacy code**
During the whole migration activity, we have definitely considered the impact of this activity over existing customers and we have tried our level best to minimize this impact as much as possible. Furthermore, we have also focused on making the new autoported release as backward compatible so that the code base of existing customers requires minimal changes. Even though the new autoported release provides Document Object Model (DOM) under com.aspose.pdf package to create as well as manipulate existing PDF files, but still if you would like to continue using your legacy code developed with Aspose.PDF.Kit for Java, you only need to import **com.aspose.pdf.facades** package and your code should work (*except for updating explicit class references*). 

The following code snippet shows you how to run your existing Aspose.PDF.Kit for Java code with new autoported Aspose.PDF for Java.

**Java**

{{< highlight csharp >}}

 import com.aspose.pdf.facades.*;

public class template {

    public static void main(String[] args) {

        try{

            // load existing PDf file

            com.aspose.pdf.facades.PdfFileInfo fileInfo = new com.aspose.pdf.facades.PdfFileInfo("input.pdf");

            System.out.println("TITLE: " + fileInfo.getTitle());

            System.out.println("AUTHOR:" + fileInfo.getAuthor());

            System.out.println("CREATIONDATE:" + fileInfo.getCreationDate());

            System.out.println("CREATOR:" + fileInfo.getCreator());

            System.out.println("KeyWORDS:" + fileInfo.getKeywords());

            System.out.println("MODDATE:" + fileInfo.getModDate());

           }

	catch(Exception ex)

	{System.out.println(ex);}

	}

}

{{< /highlight >}}
#### **using ReplaceTextStrategy class**
In order to migrate code for ReplaceTextStrategy class, the **setScope(..)** method has been updated to **setReplaceScope(..)**. Please take a look over following code snippet.

**Java**

{{< highlight csharp >}}

 // instantiate PdfContentEditor object

com.aspose.pdf.facades.PdfContentEditor editor = new com.aspose.pdf.facades.PdfContentEditor();

// bind source PDF file

editor.bindPdf("input.pdf");

// create replace text strategy

com.aspose.pdf.facades.ReplaceTextStrategy strategy = new com.aspose.pdf.facades.ReplaceTextStrategy();

// set the alignment for text replace

strategy.setAlignment(com.aspose.pdf.facades.AlignmentType.Left);

// scope for text replace

strategy.setReplaceScope(com.aspose.pdf.facades.ReplaceTextStrategy.Scope.REPLACE_ALL);

// set the replace strategy

editor.setReplaceTextStrategy(strategy);

editor.replaceText("test","replaced");

// save updated file

editor.save("TxtReplaceTest.pdf");

{{< /highlight >}}
