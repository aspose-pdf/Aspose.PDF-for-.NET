---
title: Licensing
type: docs
weight: 70
url: /java/licensing/
---

{{% alert color="primary" %}} 

Once you are happy with your evaluation of Aspose.PDF for Android via Java, [purchase a license](https://purchase.aspose.com/) at the Aspose website. Make yourself familiar with the different [license types](https://purchase.aspose.com/policies/license-types/) offered. If you have any questions, do not hesitate to [contact the Aspose sales team](https://company.aspose.com/contact).

Every Aspose license carries a one-year subscription for free upgrades to any new versions or fixes that come out during this time. Technical support is free and unlimited and provided both to licensed and evaluation users.

The license is a plain text XML file that contains details such as the product name, number of licensed developers, subscription expiry date and so on. The file is digitally signed, so do not modify the file: even adding an extra line break into the file will invalidate it.

You need to set a license before performing any operations with documents. Make sure you do this before creating a Document object. You are only required to set a license once per application or process.

{{% /alert %}} 
### **Loading the License file**
In Aspose.PDF for Android via Java, the license can be [embedded as a resource](https://docs.dynabic.com/display/pdfjava/When+to+Apply+a+License), or loaded from a stream:

1. Put the license file at any location on **/mnt/sdcard/**.
1. Create a stream that references file.
1. Pass the stream (containing the license file) into the SetLicense method.

**Java**

{{< highlight csharp >}}

 String dataDir = Environment.getExternalStorageDirectory().getPath() + "/";

// Create a stream object containing the license file

FileInputStream fstream = new FileInputStream(dataDir + "Aspose.PDF.Android.lic");

// Instantiate the License class

License license = new License();

//Set the license through the stream object

license.setLicense(fstream);


{{< /highlight >}}
#### **Applying a License from an Embedded Resource**
To access the license as a resource by name from an Android package file:

1. Add the license file as a resource to your application's **res/raw** folder.
   The license file should be visible in the **res/raw** folder.
1. Access/load the license from the resource with the following code sample.

**Java**

{{< highlight csharp >}}

 License license = new License();

InputStream inputStream = getResources().openRawResource(R.raw.license);

license.setLicense(inputStream);

{{< /highlight >}}
