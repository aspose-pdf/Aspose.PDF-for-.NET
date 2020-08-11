---
title: Filling Form Field
type: docs
weight: 20
url: /net/filling-form-field/
---

{{% alert color="primary" %}} 

Filling form fields programmatically is a common task when manipulating PDF files. [Adobe Acrobat Automation](/pdf/net/filling-form-field/) and [Aspose.PDF for .NET](/pdf/net/) both provide this functionality, as this article shows. It is easy to use Aspose.PDF for .NET for the same task and you achieve your goal with fewer lines of code.

{{% /alert %}} 
### **Implementation details**
In this example, we have a PDF file with a text field labelled **Name**. We want to fill that field with the value “John Doe”. Using Acrobat Automation, you’ll have to get the list of all the field names and navigate through the list to find the required field. Once the field is found in the list, you can set the new value. However, the Aspose.PDF.Facades namespace gives you all this functionality with the simple FillField method. This method takes two arguments, the field name and field value, and fills the value into the specified field.
### **Adobe Acrobat Automation**
The following code snippet shows you how to fill a PDF form field using Adobe Acrobat Automation.

**C#**

{{< highlight csharp >}}

 String FORM_NAME = Application.StartupPath + "\\..\\..\\..\\..\\..\\TestFiles\\input.pdf";

// Initialize Acrobat by cretaing App object.

CAcroApp acroApp = new AcroAppClass();

// Show Acrobat Viewer

acroApp.Show();

// Create an AVDoc object

CAcroAVDoc avDoc = new AcroAVDocClass();

// Open the pdf

if(!avDoc.Open (FORM_NAME, ""))

{

string szMsg = "Cannot open" + FORM_NAME + ".\n";

Console.WriteLine(szMsg);

return;

}

// Create a IAFormApp object, so that we can access the form fields in

// the open document

IAFormApp formApp = new AFormAppClass();

// Get the IFields object associated with the form

IFields myFields = (IFields)formApp.Fields;

// Get the IEnumerator object for myFields

IEnumerator myEnumerator = myFields.GetEnumerator();

bool bFound = false;

// Fill the "Name" field with value "John Doe"

while(myEnumerator.MoveNext())

{

// Get the IField object

IField myField = (IField)myEnumerator.Current;

// If the field is "Name", set it's value to "John Doe"

if(myField.Name == "Name")

{

  bFound = true;

  myField.Value = "John Doe";

  break;

        }

}

if(bFound)

Console.WriteLine("Sucessfully changed the \"Name\" field value to \"John Doe\".");

else

Console.WriteLine("Failed to locate the \"Name\" field in the form.");

{{< /highlight >}}
### **Aspose.PDF for .NET**
The following code snippet shows you how to fill a PDF form field using [Aspose.PDF for .NET](/pdf/net/).

**C#**

{{< highlight csharp >}}

 //Create Form object and open PDF file

Aspose.PDF.Facades.Form pdfForm = new Aspose.PDF.Facades.Form("input.pdf", "output.pdf");

//Set the value of the particular field

pdfForm.FillField("Name", "John Doe");

//Save the output PDF file

pdfForm.Save();



{{< /highlight >}}
