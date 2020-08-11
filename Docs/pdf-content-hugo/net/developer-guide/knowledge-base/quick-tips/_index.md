---
title: Quick Tips
type: docs
weight: 80
url: /net/quick-tips/
---

{{% alert color="primary" %}} 

The following section describes some quick tips related to Aspose.PDF for .NET.

{{% /alert %}} 
## **Using API in SSIS Script Task**
When using Aspose.PDF for .NET in SSIS Script Task, in your solution, you need to force DLL in cache for script Task of SSIS

{{< highlight java >}}

 .\gacutil -i "C:\Program Files (x86)\Aspose\Aspose.PDF for .NET\\bin\net4.0\Aspose.PDF.dll"

{{< /highlight >}}
