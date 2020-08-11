---
title: Using Aspose.Pdf for .NET with Coldfusion
type: docs
weight: 30
url: /net/using-aspose-pdf-for-net-with-coldfusion/
---

{{% alert color="primary" %}} 

In this article, we will explain how to use Aspose.PDF for .NET with Coldfusion. It’ll help you understand the details of Aspose.PDF for .Net and Coldfusion integration. With the help of a simple example, I’ll show you the process of incorporating the functionality of Aspose.PDF for .Net into your Coldfusion applications. 

{{% /alert %}} 
## **Background**
Aspose.PDF for .NET is a component which also provides the capability to edit and manipulate existing PDF files. Aspose provides this component both for .Net and Java, which can be used in your .Net and Java applications respectively, by simply accessing the API of the component. However, the method to integrate Aspose.PDF for .Net with Coldfusion is little bit different. This article will explore it in detail. 
## **Prerequisite**
In order to be able to run the Aspose.PDF for .Net with Coldfusion, you’ll need IIS, .Net 2.0, and Coldfusion. I have tested the component using IIS 5, .Net 2.0, and Colfusion 8. There are two more things which you need to make sure while installing Coldfusion. First, you have to specify which site(s) under IIS will be running Coldfusion. Secondly, you’ll have to select ‘.Net Integration Services’ from the Coldfusion installer. The .Net Integration Services let you access .Net component assembly in Coldfusion applications; in this case the component will be Aspose.PDF for .NET. 
## **Explanation**
First of all, you h ave to copy the DLL (Aspose.PDF .dll) to a location from where you’ll be accessing it for later use; this will be set as a path and assigned to assembly attribute of cfobject tag as shown below: 

**<cfobject type = ".NET" name = "fileinfo" class = "Aspose.PDF.Facades.PdfFileInfo"**

{{< highlight csharp >}}

 assembly = "C:/Aspose/Net/Assembly/Aspose.PDF.dll">



{{< /highlight >}}

The attribute class in the above tag points to Aspose.PDF. Facades class, which in this case is PdfFileInfo. The name attribute is the instance name of the class and will be used later in the code to access class methods or properties. Type attribute specifies the type of the component - in our case it is .Net. 

One important point which you’ll have to keep in mind while using the .Net component in Coldfusion is that, when you get or set any property of the class object, you have to follow a specific structure. To set a property you’ll use syntax like Set_propertyname, and to get a property value you’ll use Get_propertyname. 

For example 

Set a property value: 
<cfset FilePath = ExpandPath("guide.pdf")> 

Get a property value: 
<cfoutput>#fileinfo.Get_title()#</cfoutput> 

A basic but complete example to help you understand the process of using Aspose.PDF for .NET in Coldfusion is given below. 

**Coldfusion**

{{< highlight csharp >}}

 <h3><u>Let us show PDF file info</u></h3><br/>

<!--- create an instance of PdfFileInfo class --->

<cfobject type = ".NET" name = "fileinfo" class = "Aspose.PDF.Facades.PdfFileInfo" 

assembly = "C:/Aspose/Net/Assembly/Aspose.PDF.dll">

<!--- get pdf file path --->

<cfset FilePath = ExpandPath("guide.pdf")>

<!--- assign pdf file path to the class object by setting its inputfile property--->

<cfset fileinfo.Set_inputfile(FilePath)>

<!--- Show file info --->

<cfoutput><b>Title:</b>#fileinfo.Get_title()#</cfoutput><br/>

<cfoutput><b>Subject:</b>#fileinfo.Get_subject()#</cfoutput><br/>

<cfoutput><b>Author:</b>#fileinfo.Get_author()#</cfoutput><br/>

<cfoutput><b>Creator:</b>#fileinfo.Get_Creator()#</cfoutput><br/>



{{< /highlight >}}
## **Conclusion**
In this article, we have seen that if we follow some basic rules of Coldfusion and .Net integration, we can incorporate a lot of functionality and flexibility related to PDF document manipulation, using Aspose.PDF for .NET in our Coldfusion applications. 
