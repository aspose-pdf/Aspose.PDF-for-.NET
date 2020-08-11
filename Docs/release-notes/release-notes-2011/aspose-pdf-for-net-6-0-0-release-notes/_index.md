---
title: Aspose.Pdf for .NET 6.0.0 Release Notes
type: docs
weight: 50
url: /net/aspose-pdf-for-net-6-0-0-release-notes/
---

{{% alert color="primary" %}} 

This page contains release notes for [Aspose.PDF for .NET 6.0.0](http://www.aspose.com/downloads/pdf/net/new-releases/aspose.pdf-for-.net-6.0.0/)

{{% /alert %}} 

This is the first version of merged Aspose.PDF for .NET. In this version, we have combined Aspose.PDF for .NET and Aspose.PDF.Kit for .NET. Now, you can get the features to create and edit PDF files in a single component. In addition to that, we have also introduced a DOM API to manipulate the PDF files.This merged version contains three parts: old Aspose.PDF for .NET as Aspose.PDF.Generator namespace, old Aspose.PDF.Kit for .NET as Aspose.PDF.Facades namespace, and the new DOM API. The complete details about the features available through these three parts can be found on the following pages:In order to get started quickly, you need to go to the Programmer's Guide section of each part of the component, which contain working examples:New Features 

We have also introduced a few completely new features as well, which were not present in the older versions.* Validate PDF files for PDF/A-1a and PDF/A-1b compliance 

- Convert PDF files to PDF/A-1a and PDF/A-1b compliant files
- Convert PDF files to Linearized PDF file
  Limitations 
- Linearization is not fully supported yet, so the linearized documents might have invalid structure for some documents. This feature will be completely supported in September 2011 release.
- PdfViewer and PdfConverter do not support transparency groups, shading objects, and JPXDecode Images at the moment. This means, if the PDF file used transparency groups or shading objects, the colors will be invalid; and if the PDF file used JPXDecode images, those images will be omitted on conversion. These features will be supported in the next release due early August 2011.
