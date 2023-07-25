# Aspose.PDF for .NET Live Demos

Aspose.PDF for .NET Live Demos Source Code.
The Live Demos are examples of how to build [Aspose Free Pdf Apps](https://products.aspose.app/pdf/family) using Aspose.Pdf library

These Demos include rich features of Aspose.Pdf library:

* Editor
* Viewer
* Signature
* Annotation
* Metadata
* Comparison
* Conversion
* Merger
* Parser
* Redaction
* Search
* Splitter
* Unlock
* Xfa

 
# How to run
 
 1. Clone the repository
 2. Open the solution file in the latest version of Microsoft Visual Studio.
 3. Build the solution
 4. Run and Debug available applications that you can find on the default page.

# How to publish on IIS

 1. Clone the repository
 2. Open the solution file in the latest version of Microsoft Visual Studio.
 3. Navigate to the Publish tab from the Solution dropdown menu.
 4. Publish to a local folder or to a remote host.
 5. Set up the website directory in the IIS Management Console.

# Troubleshooting

## IIS Express can not start Demos locally.

IIS Express 10.0 is  [available](https://www.microsoft.com/en-us/download/details.aspx?id=48264) on the Microsoft website.

## How to install Local IIS

Run Powershell as administrator and enable Windows Features for LocalIIS with the following commands:

> Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServerRole
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServer
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-CommonHttpFeatures
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpErrors
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpRedirect
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ApplicationDevelopment
> Enable-WindowsOptionalFeature -Online -FeatureName NetFx4Extended-ASPNET45
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-NetFxExtensibility45
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-HealthAndDiagnostics
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpLogging
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-LoggingLibraries
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-RequestMonitor
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpTracing
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-Security
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-RequestFiltering
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-Performance
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebServerManagementTools
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-IIS6ManagementCompatibility
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-Metabase
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ManagementConsole
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-BasicAuthentication
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-WindowsAuthentication
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-StaticContent
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-DefaultDocument
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-WebSockets
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ApplicationInit
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ISAPIExtensions
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ISAPIFilter
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-HttpCompressionStatic
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ASP
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ServerSideIncludes
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-NETExtensibility48
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ASPNET45
> Enable-WindowsOptionalFeature -Online -FeatureName IIS-ASPNET48


## Debug on IIS Express not started

The error message is 'Could not find a part of the path Aspose.PDF-for-.NET\Demos\src\Aspose.PDF.Live.Demos.UI\roslyn\csc.exe'

The latest version of Visual Studio may not know how to do Edit and Continue in .NET Froamework 4.8. 
To disable this checkbox in the project on the Web properties tab.

