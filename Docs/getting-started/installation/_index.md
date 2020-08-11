---
title: Installation
type: docs
weight: 50
url: /net/installation/
---

## **Evaluate Aspose.PDF for .NET**
You can easily download Aspose.PDF for .Net for evaluation. The evaluation download is the same as the purchased download. The evaluation version simply becomes licensed when you add a few lines of code to [apply the license](/pdf/net/licensing/#licensing-loadingalicensefromastreamobjecthttps-//docs-asposeptyltd-com/display/pdfnet/licensing).

The evaluation version of Aspose.PDF (without a license specified) provides full product functionality, but it has two limitations: it inserts an evaluation watermark, and only four elements of any collection can be viewed/edited.

{{% alert color="primary" %}} 

If you want to test Aspose.PDF for .NET without the evaluation version limitations, you can also request a 30-day Temporary License. Please refer to [How to get a Temporary License?](https://purchase.aspose.com/temporary-license)

{{% /alert %}} 
## **Installing Aspose.PDF for .NET through NuGet**
NuGet is a free, open source developer-focused package management system for the .NET platform intent on simplifying the process of incorporating third party libraries into a .NET application during development. It is a Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects that use the .NET Framework. A library or tool can easily be shared with other developers by creating a NuGet package and storing it inside a NuGet repository. When you install the package, NuGet copies files to your solution and automatically makes the necessary changes, such as adding references and changing your app.config or web.config files. If you decide to remove the library, NuGet removes files and reverses whatever changes it made to your project so that no clutter is left.
### **Referencing Aspose.PDF for .NET**
Taking benefit of this wonderful feature, we have bundled [Aspose.PDF for .NET](https://www.nuget.org/packages/Aspose.PDF) libraries into a NuGet package and uploaded it into a NuGet repository. With this option, you benefit from using Aspose.PDF for .NET without installing this component on your system. NuGet runs in Visual Studio 2010 and higher version(s), Visual Web Developer 2010, and Windows Phone Developer Tools 7.1. In our tests, we have tested it with Visual Studio 2015 Ultimate.

To get started:

1. Open your solution or project in Visual Studio.
1. Add NuGet Package Manager as a Visual Studio extension:
   1. Select the **Tools** menu followed by **Extension Manager**.
   1. Select **Online Gallery** to get a complete list of packages available online.
   1. Select **NuGet Package Manager**.
   1. Click **Download**.
   1. Once the package Manager is installed, restart Visual Studio to bring the changes into effect. 
      When NuGet Package Manager is installed, you can find, install, remove, and update packages from the **Manage NuGet Packages** window, or by using PowerShell command-line commands in the **Package Manager Console** dedicated Visual Studio window. You can find both options if you select the **Tools** followed by **Library Package Manager**.
### **Install Package using Package Manager Console**
To reference the component using the package manager console:

1. Open your .NET application in Visual Studio.
1. On the **Tools** menu, select **Library Package Manager** and then **Package Manager Console**.
1. Type the command “Install-Package Aspose.PDF” to install the latest full release, or type the command “Install-Package Aspose.PDF -prerelease” to install the latest release including hot fixes.
1. Press **Enter**.
### **Update package using Package Manager Console**
If you have already referenced the component through NuGet, follow these steps to update the reference to the latest version:

1. Open you .NET application in Visual Studio.
1. From the **Tools** menu, select **Library Package Manager**, followed by **Package Manager Console** to open the Package Manager console.
1. Type the command “Update-Package Aspose.PDF” to reference the latest full release, or type the command “Update-Package Aspose.PDF -prerelease” to install latest release including hot fixes.
1. Press **Enter**.
### **Install Package using the Package Manager GUI**
Follow these steps to reference the component using the package manager GUI:

1. Open you .NET application in Visual Studio.
1. From the **Tools** menu, select **Library Package Manager** and **Manage NuGet Packages** from the **Solution** option. 
   You can also get a similar option from the Solution Explorer:
   1. Right-click the project name.
   1. Select **Manage NuGet Packages**.
1. Select **online** from the left menu.
1. Type **Aspose.PDF** into the search box to find Aspose.PDF for .NET.
1. Click **Install/Update** next to the latest version of Aspose.PDF for .NET.
## **Manually download Aspose.PDF for .NET from NuGet**
You can download the DLL of Aspose.PDF for .NET from NuGet without using Package Manager Console or Package Manger GUI. Simply browse to [this package link](https://www.nuget.org/packages/Aspose.PDF/) and then click on Manual Download link as shown in the screenshot below. Once you download it, change the file extension from .nupkg to .zip and extract it using any ZIP manager.



![todo:image_alt_text](installation_1.png)
## **Working with .NET Core DLLs in Non-Windows Environment**
As Aspose.PDF for .NET provides .NET Standard 2.0 (.NET Core 2.0) support, so it can be used in Core Applications running in Linux like operating systems. We are constantly working over improving the .NET Core support in our API. However, there are some following operations which we recommend our customers to perform, in order to get better results while using features of Aspose.PDF for .NET:

Please install:

1. libgdiplus package
1. package with Microsoft compatible fonts: ttf-mscorefonts-installer. (e.g. *sudo apt-get install ttf-mscorefonts-installer*)

These fonts should be placed in "/usr/share/fonts/truetype/msttcorefonts" directory as Aspose.PDF for .NET scans this folder on Linux like operating systems. In case operating system has other default folder/directory for fonts, you should use following line of code before performing any operation using Aspose.PDF.

{{< highlight csharp >}}

  Aspose.Pdf.Text.FontRepository.Sources.Add(new FolderFontSource("<user's path to ms fonts>"));

{{< /highlight >}}
