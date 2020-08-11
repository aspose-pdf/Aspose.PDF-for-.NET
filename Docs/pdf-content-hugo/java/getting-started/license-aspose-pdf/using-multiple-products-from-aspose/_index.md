---
title: Using Multiple Products from Aspose
type: docs
weight: 20
url: /java/using-multiple-products-from-aspose/
---

If you use multiple Aspose products in your application, for example Aspose.PDF and Aspose.Words, here are a few useful tips.

- **Set the License for each Aspose Product Separately.** Even if you have a single license file for all components, for example 'Aspose.Total.lic', you still need to call **License.SetLicense** separately for each Aspose product you are using in your application.
- **Use Fully Qualified License Class Name.** Each Aspose product has a **License** class in its namespace. For example, Aspose.PDF has **com.aspose.pdf.License** and Aspose.Words has **com.aspose.words.License** class. Using the fully qualified class name allows you to avoid any confusion about which license is applied to which product.



{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-pdf-QuickStart-UsingMultipleProducts-1.java" >}}
