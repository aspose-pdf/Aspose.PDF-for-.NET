---
title: PHP via COM Interop
type: docs
weight: 50
url: /net/php-via-com-interop/
---

##### ***Prerequisites***

{{% alert color="primary" %}} 
Configure your PHP to work with COM. See <http://www.php.net/manual/en/ref.com.php>. For more information, please check the article named [Use Aspose.pdf for .NET via COM Interop](/pdf/net/use-aspose-pdf-for-net-via-com-interop/)

{{% /alert %}} 
##### ***Hello World!***

{{% alert color="primary" %}} 
This is a simple application that shows you how to create a new PDF file and add text to the PDF file using [Aspose.PDF for .NET](/pdf/net/) in PHP via COM Interop.

{{% /alert %}} 

**PHP**

{{< highlight csharp >}}

 <?php

echo "<h2>Calling Aspose.PDF for .NET from PHP using COM Interoperatibility</h2>";

echo "<h3>PDF to Excel Conversion</h3>";

//set license

$lic = new COM("Aspose.PDF.License");

$lic->SetLicense("C:/temp/Aspose.Total.lic");

//Load Pdf Document

$input="C:/temp/HelloWorld.pdf";

$helper = new COM("Aspose.PDF.ComHelper");

$pdf = $helper->OpenFile($input);

// Save the PDF document  to desired file format by passing  SaveFormat enum value for the format in this case we pass 9 for excel.

$output = "C:/temp/test_php.xls";

$pdf->Save_4($output,9);

?>



{{< /highlight >}}
