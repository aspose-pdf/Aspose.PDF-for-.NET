---
title: Creating a Wrapper Assembly
type: docs
weight: 80
url: /net/creating-a-wrapper-assembly/
---

{{% alert color="primary" %}} 

If you need to use many of Aspose.PDF for .NET classes, methods and properties, consider creating a wrapper assembly (using C# or any other .NET programming language). Wrapper assemblies help to avoid using Aspose.PDF for .NET directly from unmanaged code.

A good approach is to develop a .NET assembly that references Aspose.PDF for .NET and does all the work with it, and only exposes a minimal set of classes and methods to unmanaged code. Your application then should work just with your wrapper library.

Reducing the number of classes and methods that you need to invoke via COM Interop simplifies the project. Using .NET classes via COM Interop often requires advanced skills.

{{% /alert %}} 
#### **Aspose.PDF for .NET Wrapper**
**C#**

{{< highlight csharp >}}

 using System;

using System.Runtime.InteropServices;

namespace PdfText

{

    [Guid("FC969AC9-6591-46FB-A4AB-DB12A776F3BF")]

    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

    public interface IPetriever

    {

        [DispId(1)]

        void SetLicense(string file);

        [DispId(2)]

        string GetText(string file);

    }

    [Guid("3D59100F-3CC5-463D-B509-58FA0520B436")]

    [ClassInterface(ClassInterfaceType.None)]

    [ComSourceInterfaces(typeof(IPetriever))]

    public class Petriever : IPetriever

    {

        public void SetLicense(string file)

        {

            License lic = new License();

            lic.SetLicense(file);

        }

        public string GetText(string file)

        {

            // open document

            Document doc = new Document(file);

            // create TextAbsorber object to extract text

            TextAbsorber absorber = new TextAbsorber();

            // accept the absorber for all document's pages

            doc.Pages.Accept(absorber);

            // get the extracted text

            string text = absorber.Text;

            return text;

        }

    }

}

{{< /highlight >}}
