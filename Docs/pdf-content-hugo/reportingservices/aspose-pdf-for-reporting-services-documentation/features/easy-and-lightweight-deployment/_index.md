---
title: Easy and Lightweight Deployment
type: docs
weight: 40
url: /reportingservices/easy-and-lightweight-deployment/
---

{{% alert color="primary" %}} 

Aspose.PDF for Reporting Services is a custom [rendering extension](http://msdn2.microsoft.com/en-us/library/ms154606.aspx) for Microsoft SQL Server 2000 / 2005 / 2008 / 2012 / 2016 Reporting Services. Aspose.PDF for Reporting Services is provided as a single MSI installer that can install on the computers running one of the following:

- Microsoft SQL Server 2000 Reporting Services
- Microsoft SQL Server 2005 Reporting Services
- Microsoft SQL Server 2008 Reporting Services
- Microsoft SQL Server 2012 Reporting Services
- Microsoft SQL Server 2016 Reporting Services

{{% /alert %}} 

Aspose.PDF for Reporting Services is easy to deploy and manage, as it is comprised of only one .NET assembly Aspose.PDF.ReportingServices.dll, written completely in C#, CLS compliant and containing only safe managed code. You need to have .NET Framework 2.0 or 3.5 installed on the server.

- Aspose Pdf for Reporting Services2000/2005 needs .NET Framework 2.0
- Aspose Pdf for Reporting Services2008 needs .NET Framework 3.5

The **Aspose.PDF.ReportingServices.dll** must be copied to the ReportServer\bin directory and the configuration file must be updated so Reporting Services is aware of the new rendering extension. These steps are performed by the Aspose.PDF for Reporting Services installer, but you could also perform them manually as described further in this documentation.
