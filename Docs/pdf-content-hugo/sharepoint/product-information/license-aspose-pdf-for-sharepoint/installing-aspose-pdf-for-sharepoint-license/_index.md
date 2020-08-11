---
title: Installing Aspose.Pdf for SharePoint License
type: docs
weight: 10
url: /sharepoint/installing-aspose-pdf-for-sharepoint-license/
---

{{% alert color="primary" %}} 

Once you are happy with your evaluation, you can [purchase a license](http://www.aspose.com/purchase/default.aspx). Before purchasing make sure you understand and agree to the license subscription terms.

{{% /alert %}} 

The license will be emailed to you after the order has been paid. The license is a .zip archive containing a regular SharePoint solution package.

This archive contains:

- Aspose.PDF.SharePoint.License.wsp

SharePoint solution package file. Aspose.PDF for SharePoint License is packaged as a SharePoint solution to facilitate deployment/retraction across the server farm.

- readme.txt

License installation instructions. License installation is performed from the server console via stsadm.exe. The steps required to install the license are given below.

**Note:** The paths are omitted for clarity. You may need to add the actual path to stsadm.exe and/or solution file when executing them.

\1. Run stsadm to add the solution to the SharePoint solution store:

stsadm.exe -o addsolution -filename Aspose.PDF.SharePoint.License.wsp

\2. Deploy the solution to all servers in the farm:

stsadm.exe -o deploysolution -name Aspose.PDF.SharePoint.License.wsp -immediate -force

\3. Execute administrative timer jobs to complete the deployment immediately.

stsadm.exe -o execadmsvcjobs

**Note:** You will receive a warning when running deployment step if Windows SharePoint Services Administration service is not started. Stsadm.exe relies on this service and Windows SharePoint Timer Service to replicate solution data across the farm. If these services are not running on your server farm, you may need to deploy the license at each server.
