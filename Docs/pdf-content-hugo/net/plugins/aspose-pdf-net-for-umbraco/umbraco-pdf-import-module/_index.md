---
title: Umbraco PDF Import Module
type: docs
weight: 10
url: /net/umbraco-pdf-import-module/
---

## **Introduction**
Aspose.PDF for .NET is a PDF document creation and manipulation component that enables your .NET applications to read, write and manipulate existing PDF documents without using Adobe Acrobat. It also allows you to create forms and manage form fields embedded in a PDF document.

Aspose.PDF for .NET is affordable and offers an incredible wealth of features including PDF compression options; table creation and manipulation; support for graph objects; extensive hyperlink functionality; extended security controls; custom font handling; integration with data sources; add or remove bookmarks; create table of contents; add, update, delete attachments and annotations; import or export PDF form data; add, replace or remove text and images; split, concatenate, extract or inset pages; transform pages to image; print PDF documents and much more
### **Module Features**
Umbraco PDF Import is an open source add-on from [Aspose](http://www.aspose.com/) that allow developers to get/read contents of any PDF document without requiring any other software. This add-on demonstrates the powerful import feature provided by [Aspose.PDF](http://www.aspose.com/pdf-component-suite.aspx). It adds a simple file browser control and **Import from PDF** button on the page where the add-on is added. When clicking on the button, the document contents are fetched from the file and displayed on the screen immediately.

![todo:image_alt_text](http://www.aspose.com/blogs/wp-content/uploads/2015/02/Aspose-.NET-PDF-Import-for-Sitefinity.png)
## **System Requirements and Supported Platforms**
### **System Requirements**
In order to setup Aspose .NET Pdf Import for Umbraco module you need to have the following requirements met:

- Umbraco 6.0 +

Please feel free to contact us if you wish to install this module on other versions of Umbraco.
### **Supported Platforms**
The module is supported on all versions of

- Umbraco running on ASP.NET 4.0
## **Downloading**
You can download Aspose .NET Pdf Import for Umbraco from one of the following locations

- [CodePlex ](https://asposeumbraco.codeplex.com/releases)
- [Github ](https://github.com/asposemarketplace/Aspose_for_Umbraco/releases)
- [Sourceforge ](https://sourceforge.net/projects/asposeumbraco/files/)
- [Bitbucket ](https://bitbucket.org/asposemarketplace/aspose-for-umbraco/downloads)
- [Umbraco ](https://our.umbraco.org/projects/developer-tools/import-from-pdf-using-aspose-pdf)
## **Installing**
Once downloaded, please follow these steps to install this package into your Umbraco website:

1. Log in to the Umbraco **Developer** section, for example <http://www.myblog.com/umbraco/>
1. From the tree, expand the **Packages** folder.
   From here there are two ways to install a package: select **Install local package** or browse the **Umbraco Package Respository.**
1. If you install **local package**, do not unzip the package but load the zip into Umbraco.
1. Follow the instructions on screen.

**Note:** You may get a ‘Maximum request length exceeded’ error when installing. You can easily fix this issue by updating the ‘maxRequestLength’ value in your Umbraco web.config file.

{{< highlight java >}}

  <httpRuntime requestValidationMode="2.0" enableVersionHeader="false" maxRequestLength="25000" />

{{< /highlight >}}
## **Using**
After you have installed the macro it is really simple to start using it on your website:

1. Make sure you are logged in to the Umbraco **Developer** section, for example <http://www.myblog.com/umbraco/>
1. Click **Settings** in the list of sections at the bottom left of the screen.
1. Expand the **Templates** node and select the template that you want to add macro to, for example Blog post.
1. Select the position in the selected template where you want to the button.
1. Click **Insert Macro** on the top ribbon.
1. From **Choose a macro**, select the installed macro and click **OK**.

You have successfully added the template. A button titled **Import from Pdf** now appears on all pages created using this template. Anyone can simply click the button and import the contents of a PDF document.
## **Video Demo**
Please check [the video](https://www.youtube.com/watch?v=zmZTJ86B25E) below to see the module in action.
## **Support, Extend and Contribute**
### **Support**
From the very first days of Aspose, we knew that just giving our customers good products would not be enough. We also needed to deliver good service. We are developers ourselves and understand how frustrating it is when a technical issue or a quirk in the software stops you from doing what you need to do. We're here to solve problems, not create them.

This is why we offer free support. Anyone who uses our product, whether they have bought them or are using an evaluation, deserves our full attention and respect.

You can log any issues or suggestions related to Aspose.PDF .NET for Umbraco Modules using any of the following platforms

- [CodePlex ](https://asposeumbraco.codeplex.com/workitem/list/basic)
- [Github ](https://github.com/asposemarketplace/Aspose_for_Umbraco/issues)
- [Sourceforge ](https://sourceforge.net/p/asposeumbraco/tickets/?source=navbar)
- [Bitbucket ](https://bitbucket.org/asposemarketplace/aspose-for-umbraco/issues?status=new&status=open)

**Import from Pdf**

- [Microsoft Developer Network - Q and A ](https://code.msdn.microsoft.com/Umbraco-Import-from-Pdf-d4659bc8/view/Discussions#content)
### **Extend and Contribute**
Aspose .NET PDF Import for Umbraco is open source and its source code is available on the major social coding websites listed below. Developers are encouraged to download the source code and extend the functionality as per their own requirements.
#### **Source Code**
You can get the latest source code from one of the following locations

- [CodePlex ](https://asposeumbraco.codeplex.com/SourceControl/latest)
- [Github ](https://github.com/asposemarketplace/Aspose_for_Umbraco)
- [Sourceforge ](https://sourceforge.net/p/asposeumbraco/code/ci/master/tree/)
- [Bitbucket ](https://bitbucket.org/asposemarketplace/aspose-for-umbraco/src)
#### **How to configure the source code**
You need to have the following installed in order to open and extend the source code

- Visual Studio 2010 or higher

Please follow these simple steps to get started

1. Download/Clone the source code.
1. Open Visual Studio 2010 and Choose **File** > **Open Project**
1. Browse to the latest source code that you have downloaded and open **Aspose.Import from PDF.sln**
