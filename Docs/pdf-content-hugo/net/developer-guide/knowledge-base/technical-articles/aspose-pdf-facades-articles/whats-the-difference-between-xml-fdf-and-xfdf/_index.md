---
title: Whats the Difference Between XML, FDF and XFDF
type: docs
weight: 20
url: /net/whats-the-difference-between-xml-fdf-and-xfdf/
---

{{% alert color="primary" %}} 

We mixed many different terms like FDF, XML and XFDF. All these terms are related to each other somehow. This article explores these concepts and their relationship to each other.

{{% /alert %}} 
## **Unravelling Forms**
Aspose.PDF for .NET is used to manipulate PDF documents standardized by Adobe. And PDF documents contain interactive forms called AcroForms. These interactive forms have a number of form fields, like combo, text box, and radio button. Adobe's interactive forms, and form fields, work in the same way as an HTML form and its form fields.

It is possible to store the values of form fields in a separate file: an FDF (Forms Data Format) file. This contains the values of the form fields in key/pair fashion. FDF files are still used for this purpose. But Adobe also provides an XML encoded type of FDF called XFDF. An XFDF file stores the values of the form fields in a hierarchical manner using XML tags.

With Aspose.PDF developers can not only export the values of PDF form fields to an FDF or XFDF file but also to an XML file. All these files use different syntax to save PDF form field values. The example below explains the differences.

Let's assume that there are some PDF form fields whose values need to be presented in FDF, XML and XFDF forms. These assumed form fields with their field names and values are shown below:

|**Field Name**|**Field Value**|
| :- | :- |
|Company|Aspose.com|
|Address.1|Sydney, Australia|
|Address.2|Additional Address Line|
Let's see how to represent these values in [FDF](/pdf/net/whats-the-difference-between-xml-2c-fdf-and-xfdf-html/), [XML](/pdf/net/whats-the-difference-between-xml-2c-fdf-and-xfdf-html/) and [XFDF](/pdf/net/whats-the-difference-between-xml-2c-fdf-and-xfdf-html/) formats.
### **Using FDF**
As we know that FDF file store data in Key/Pair fashion where /T represents a Key, /V represents the Value and data in parenthesis () represents the content of either a Key or a Value. For example, /T(Company) means Company is the field key and /V(Aspose.com) is meant for a field value.

/T(Company) /V(Aspose.com) 
/T(Address.1) /V( Sydney , Australia ) 
/T(Address.2) /V(Additional Address Line)
### **Using XML**
Developers can represent each PDF form field in the form of a field tag, <field>. Each field tag has an attribute, name showing the field name and a sub tag, <value> represeting the field value as shown below:

**XML**

{{< highlight csharp >}}

 <?xml version="1.0" ?>

 <fields>

  <field name="Company">

    <value>Aspose.com</value>

  </field>

  <field name="Address.1">

    <value>Sydney, Australia</value>

  </field>

  <field name="Address.2">

    <value>Additional Address Line</value>

  </field>

 </fields>



{{< /highlight >}}
### **Using XFDF**
The representation of above data in XFDF form is similar to XML form except with few differences. In XFDF files, we add their XML Namespace, which is <http://ns.adpbe.com/xfdf/> and their is an additional tag, <f> that is used to point towards the PDF document containing these PDF form fields. Like XML, XFDF also contains fields in the form of field tags, <field> as shown below:

**XML**

{{< highlight csharp >}}

 <?xml version="1.0" encoding="UTF-8"?>

<xfdf xmlns="http://ns.adobe.com/xfdf/" xml:space="preserve">    

   <f href="CompanyForm.pdf"/>  

   <fields>

      <field name="Company">

         <value>Aspose.com</value>

      </field>

      <field name="Address">

         <field name="1">

            <value>Sydney, Australia</value>

         </field>

         <field name="2">

            <value>Additional Address Line</value>

         </field>

      </field>

   </fields>

 </xfdf>



{{< /highlight >}}
### **Identifying form fields names**
Aspose.PDF for .NET provides the capability to create, edit and fill already created PDF forms. It contains [Form](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form) class, which has the function named [FillField](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form/methods/fillfield/index) , and it takes two parameters i.e. Field name that needs to be filled, and the field value. So in-order to fill the form fields, you must be aware of the exact form field name. 
We often come across the scenario in which we need to fill the form which is created in some tool i.e. Adobe Designer, and we are not sure about the form fields names. To accomplish our requirement, we need to read the names of all the PDF form fields. [Form](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form) class provides the property named [FieldsNames](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/form/properties/fieldnames) which returns all the fields’ names and returns null if PDF have no field. But this property will return all the PDF form field’s names and we won’t be sure, which name corresponds to which field over the form.

As a solution to this problem, we would require the appearance attributes of each field. [Form](http://www.aspose.com/documentation/file-format-components/aspose.pdf.kit-for-.net-and-java/aspose.pdf.kit.form.html) class has a function named GetFieldFacade which returns attributes, including location, color, border style, font, list item and so on. To save these values we will be using [FormFieldFacade](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formfieldfacade) class, which is used to record visual attributes of the fields. Once we have these attributes we can add a text field beneath every field which would be displaying the field name. Here a question arises how we would determine the location where to add the text field? Solution to this problem is Box property in [FormFieldFacade](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formfieldfacade) class, which holds the field’s location. We would save these values to an array of rectangle type and use these values to identify the position where to add the new text fields. 
In Aspose.Pdf.Facades namespace, we have a class named [FormEditor](http://www.aspose.com/api/net/pdf/aspose.pdf.facades/formeditor) which provides the capability to manipulate PDF form. Open a PDF form add a text field beneath every existing form field and save the PDF form with new name.



{{< gist "aspose-pdf" "4a12f0ebd453e7f0d552ed6658ed3253" "Examples-CSharp-AsposePdfFacades-TechnicalArticles-DifferenceBetweenFile-DifferenceBetweenFile.cs" >}}
