---
title: Using early binding in CPP
type: docs
weight: 10
url: /net/using-early-binding-in-cpp/
---

##### **Prerequisites**

{{% alert color="primary" %}} 

Please register Aspose.PDF for .NET with COM Interop, kindly check the article named [Use Aspose.pdf for .NET via COM Interop](/pdf/net/use-aspose-pdf-for-net-via-com-interop/).

{{% /alert %}} 

##### **Sample**
{{% alert color="primary" %}} 

This is a simple C++ code sample to extract text from PDF files using COM Interop using early binding. Before running the sample pay attention that

- **#import** *typelib.tlb* makes C++ compiler generate 2 files: *typelib.tlh* and *typelib.tli*. By default, these files are generated only once, so you need to fully recompile the project in order to get new versions of them.
- often importing only one TLB file leads to a great number of compiler errors. There are two types of errors: unresolved dependencies and conflicting names. If you can't compile project open tlh file and look at the first lines which are commented. Here you'll probably see the section which starts from the line

{{< highlight java >}}

 // Cross-referenced type libraries:

{{< /highlight >}}

and has one or more **#import**'s. Just copy them into your code before importing the main type library and do it in the ***same*** order. Thus you'll bite the first type of problem. The next type of problem comes from the fact C++ environment has a big number of macros, predefined functions, etc., which can conflict with type library methods. For example, GetType has been already widely used in C++ but also Aspose.PDF has it. I found **rename** and **auto_rename** attributes of **#import** directive are very convenient to get rid of possible warnings and errors.

- sometimes classes in **uses** namespaces conflict with names in type library, so in such cases, full class name must be used instead of **using namespace**. For example, see how StringToBSTR is called in the code snippet below.

For details please look at [this](http://www.drdobbs.com/writing-com-clients-with-late-and-early/184403558) post.

**C++**

{{< highlight cpp >}}

 #include "stdafx.h"

#import "C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.Drawing.tlb"

#import "C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.tlb" auto_rename

#import "C:\Temp\Aspose.PDF.tlb" rename("GetType", "GetType_") auto_rename

using namespace System;

String ^earlyBinding(String ^file)

{

    String ^text;

    // create ComHelper

    Aspose_Pdf::_ComHelperPtr comHelperPtr;

    HRESULT hr = comHelperPtr.CreateInstance(__uuidof(Aspose_Pdf::ComHelper));

    if (FAILED(hr))

    {

        Console::WriteLine(L"Error occured");

    }

    else

    {

        // set license

	Aspose_Pdf::_LicensePtr licPtr;

	licPtr.CreateInstance(__uuidof(Aspose_Pdf::License));

	licPtr->SetLicense("C:\\Temp\\Aspose.PDF.lic");

	licPtr.Release();

	// get Document

	Aspose_Pdf::_DocumentPtr docPtr;

	docPtr = comHelperPtr->OpenFile((BSTR)System::Runtime::InteropServices::Marshal::StringToBSTR(file).ToPointer());

	comHelperPtr.Release();

	// create Absorber

	Aspose_Pdf::_TextAbsorberPtr absorberPtr;

	HRESULT hRes = absorberPtr.CreateInstance(__uuidof(Aspose_Pdf::TextAbsorber));

	// browse text

        docPtr->GetPages()->Accept_4(absorberPtr);

        // retrieve text

        BSTR extractedText = absorberPtr->GetText();

	text = gcnew String(extractedText);

	docPtr.Release();

	absorberPtr.Release();

    }

    return text;

}

int main(array<System::String ^> ^args)

{

    CoInitialize(NULL);

    if (args->Length != 1)

    {

        Console::WriteLine("Missing parameters\nUsage:testCOM <pdf file>");

	return 0;

    }

    String ^text = earlyBinding(args[0]);

    CoUninitialize();

    Console::WriteLine("Extracted text:");

    Console::WriteLine("---\n{0}", text != nullptr ? text->Trim() : "<empty>");

    Console::WriteLine("---");

    return 0;

}


{{< /highlight >}}


{{% /alert %}} 
