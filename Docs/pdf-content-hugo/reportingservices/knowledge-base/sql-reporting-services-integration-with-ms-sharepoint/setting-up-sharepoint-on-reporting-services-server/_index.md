---
title: Setting up SharePoint on Reporting Services Server
type: docs
weight: 30
url: /reportingservices/setting-up-sharepoint-on-reporting-services-server/
---

{{% alert color="primary" %}} 

Now we need to perform similar steps as we did for the SharePoint WFE. First thing is to go through the Prereq uisites install and once it is done, startup the SharePoint setup.

{{% /alert %}} 

For the setup I choose Server Farm and a complete install to match my SharePoint Box, as I do not want a standalone install for SharePoint.
##### **SharePoint Configuration In the SharePoint Configuration Wizard, we want to connect to an existing farm. ![todo:image_alt_text](setting-up-sharepoint-on-reporting-services-server_1.png) Image1:- SharePoint configuration wizard We will then point it to the SharePoint_Config database that our farm is using. If you don't know where this is, you can find out through Central Admin through System Settings -> Manager Servers in this farm. ![todo:image_alt_text](setting-up-sharepoint-on-reporting-services-server_2.png) Image2:- Specify database configuration settings ![todo:image_alt_text](setting-up-sharepoint-on-reporting-services-server_3.png) Image3:- SharePoint configuration wizard Once the wizard is done, that is all we need to do on the Report Server Box for now. Going back to the ReportServer URL, we will see another error, but that is because we have not configured it through Central Administrator. ![todo:image_alt_text](setting-up-sharepoint-on-reporting-services-server_4.png) Image4:- Report server error**
