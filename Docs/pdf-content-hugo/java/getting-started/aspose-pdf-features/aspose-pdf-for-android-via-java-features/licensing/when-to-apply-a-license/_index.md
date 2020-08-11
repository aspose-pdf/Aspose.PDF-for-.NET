---
title: When to Apply a License
type: docs
weight: 10
url: /java/when-to-apply-a-license/
---

{{% alert color="primary" %}} 

Follow these simple rules:

- The license only needs to be set once per application domain.
- You need to set the license before using any other Aspose.PDF classes.

Calling License.SetLicense multiple times is not harmful, but wastes processor time.

If you are developing a class library, call License.SetLicense from a static constructor that uses Aspose.PDF. The static constructor execute before an instance of your class is created, making sure Aspose.PDF license is applied properly. 

{{% /alert %}}
