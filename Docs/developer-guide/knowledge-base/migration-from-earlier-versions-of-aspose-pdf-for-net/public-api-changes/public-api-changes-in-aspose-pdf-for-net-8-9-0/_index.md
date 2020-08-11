---
title: Public API Changes in Aspose.Pdf for .NET 8.9.0
type: docs
weight: 10
url: /net/public-api-changes-in-aspose-pdf-for-net-8-9-0/
---

{{% alert color="primary" %}} 

These page lists public API changes that were introduced in Aspose.PDF for .NET 8.9.0. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in Aspose.PDF for Java which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.

{{% /alert %}} 

**CustomStrategyOfEmbeddedImagesSaving field added to SvgSaveOptions object**
{{% alert color="primary" %}} 
This field can contain saving strategy that must be used (if present) during conversion for customized handling of created referenced external images files (like embedded BMP or JPEG) embedded into saved SVG.

**ExplicitListOfSavedPages property added to HtmlSaveOptions object**

With this property users can explicitly define what pages of document should be converted.

**Rotation property added to ImagePlacement object**

With this property users can obtain rotation angle of the Image that is placed to a page contents.

**Save method added to ImagePlacement object**

With this method users can save image with corresponding transformations: scaling, rotation and resolution that are actually applied to the image on the page.

**SubsequentLinesIndent property added to LevelFormat object**

With this method users can set a subsequent lines indent in table of contents.
{{% /alert %}} 