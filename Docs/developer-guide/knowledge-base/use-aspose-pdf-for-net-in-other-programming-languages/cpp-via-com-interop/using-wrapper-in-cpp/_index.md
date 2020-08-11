---
title: Using wrapper in CPP
type: docs
weight: 30
url: /net/using-wrapper-in-cpp/
---

##### **Prerequisites**


{{% alert color="primary" %}}

Please register Aspose.PDF for .NET with COM Interop, kindly check the article named [Use Aspose.pdf for .NET via COM Interop](/pdf/net/use-aspose-pdf-for-net-via-com-interop/).

{{% /alert %}}

{{% alert color="primary" %}}

We will use a [wrapper](http://www.aspose.com/docs/display/pdfnet/Creating+a+Wrapper+Assembly) to retrieve text from PDF documents.

**C++**

{{< highlight cpp >}}

 #include "stdafx.h"

#import "C:\Temp\PdfText.tlb"

using namespace System;

String^ wrapper(String^ file)

{

    String^ text;

    // create ComHelper

    PdfText::IPetrieverPtr retrieverPtr;

    HRESULT hr = retrieverPtr.CreateInstance(__uuidof(PdfText::Petriever));

    if (FAILED(hr))

    {

        Console::WriteLine(L"Error occured");

    }

    else

    {

        // set license

	retrieverPtr->SetLicense("C:\\Temp\\Aspose.PDF.lic");

	// retrieve text

        BSTR extractedText = retrieverPtr->GetText((BSTR)System::Runtime::InteropServices::Marshal::StringToBSTR(file).ToPointer());

	text = gcnew String(extractedText);

	retrieverPtr.Release();

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

    String ^text = wrapper(args[0]);

    CoUninitialize();

    Console::WriteLine("Extracted text:");

    Console::WriteLine("---\n{0}", text != nullptr ? text->Trim() : "<empty>");

    Console::WriteLine("---");

    return 0;

}

{{< /highlight >}}



{{% /alert %}}
