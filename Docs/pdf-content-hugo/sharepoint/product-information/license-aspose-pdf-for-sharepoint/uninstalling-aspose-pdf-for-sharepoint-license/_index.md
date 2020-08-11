---
title: Uninstalling Aspose.Pdf for SharePoint License
type: docs
weight: 30
url: /sharepoint/uninstalling-aspose-pdf-for-sharepoint-license/
---

To uninstall Aspose.PDF for SharePoint license, please use the steps below from the server console.

\1. Retract the license solution from the farm:

stsadm.exe -o retractsolution -name Aspose.PDF.SharePoint.License.wsp -immediate

\2. Execute administrative timer jobs to complete the retraction immediately:

stsadm.exe -o execadmsvcjobs

\3. Wait for the retraction to complete. You can use Central Administration to check if the retraction completed under Central Administration -> Operations -> Solution Management

\4. Remove the solution from the SharePoint solution store:

stsadm.exe -o deletesolution -name Aspose.PDF.SharePoint.License.wsp
