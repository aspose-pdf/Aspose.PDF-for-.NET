---
title: Aspose.Pdf for Java 17.3.0 Release Notes
type: docs
weight: 100
url: /java/aspose-pdf-for-java-17-3-0-release-notes/
---

### **Features and Improvements**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFJAVA-36477|PDF Merge Gives NullPointerException|Exception|
|PDFJAVA-36486|Exception thrown when using Pdf Digital signature|Exception|
|PDFJAVA-36557|Annotation import throws exception An element with the same key already exists in the dictionary|Exception|
|PDFJAVA-36167|ImportXml throw internal exception|Exception|
|PDFJAVA-33814|PDF to JPG: text missing in output image|Bug|
|PDFJAVA-34551|Form filled information changes after merge|Bug|
|PDFJAVA-34584|PDF to PDF/A-1B: document is not compliant|Bug|
|PDFJAVA-34746|PDF to PDFA1b: compliance failure due to CMYK error|Bug|
|PDFJAVA-34888|PDF to DOCX - Exception during conversion|Bug|
|PDFJAVA-34900|PCL to PDF: incorrect output is generated|Bug|
|PDFJAVA-34990|PDF to PNG conversion results into a blurred image|Bug|
|PDFJAVA-35021|Unable to convert XFA form to Standard AcroForm|Bug|
|PDFJAVA-35022|Unable to convert XFA form to Standard AcroForm|Bug|
|PDFJAVA-35097|Unable to validate PDF/A_1b compliance of document|Bug|
|PDFJAVA-35460|Latex to PDF: rendering is incorrect|Bug|
|PDFJAVA-35726|Incorrect color information is being retrieved for TextFragment|Bug|
|PDFJAVA-35823|PDF to PDF/A - Contents get garbled and file is not PDF/A compliant|Bug|
|PDFJAVA-35824|PDF to PDF/A - Contents get truncated in resultant file|Bug|
|PDFJAVA-35825|PDF to PDF/A - Page contents are messed up|Bug|
|PDFJAVA-36000|PDF to PNG: some images are missing on resultant image|Bug|
|PDFJAVA-36002|PDF to PDF/A - Resultant file is not compliant|Bug|
|PDFJAVA-36057|PDF to DOCX: Russian text is being added in resultant DOCX|Bug|
|PDFJAVA-36320|Regression: 16.10.0 generates invalid PDFA document|Bug|
|PDFJAVA-36442|When PDF is saved as DOCX, some additional new lines are added.|Bug|
|PDFJAVA-36446|TIFF to PDF: corrupt PDF is being generated|Bug|
|PDFJAVA-36468|TextFragmentCollection breaks Iterable interface|Bug|
|PDFJAVA-36560|PdfFileSignature does not retain image given width|Bug|
|PDFJAVA-36406|Hyperlink is not working in PDF file|Bug|
|PDFJAVA-35331|XFA form is not being converted to Standard Acro Form.|Bug|
### **Public API Changes in Aspose.PDF for Java 17.3.0**


**Added APIs:**

method: "com.aspose.pdf.AnnotationSelector.visit(RichMediaAnnotation)"

method: "com.aspose.pdf.AnnotationSelector.visit(PDF3DAnnotation)"

field: "com.aspose.pdf.AnnotationType.PDF3D"

class: "**com.aspose.pdf.ApsUsingConverter.ImportResourceLoader**"

method: "com.aspose.pdf.ApsUsingConverter.ImportResourceLoader.ImportResourceLoader()"

field: "com.aspose.pdf.BlendMode.Compatible"

method: "com.aspose.pdf.Cell.getWidth"

method: "com.aspose.pdf.Form.getIgnoreNeedsRendering"

method: "com.aspose.pdf.Form.setIgnoreNeedsRendering(boolean)"

method: "com.aspose.pdf.HtmlFragment.getTextState"

method: "com.aspose.pdf.HtmlFragment.setTextState(TextState)"

class: **"com.aspose.pdf.LightingSchemeType"**

field: "com.aspose.pdf.LightingSchemeType.Artwork"

field: "com.aspose.pdf.LightingSchemeType.None"

field: "com.aspose.pdf.LightingSchemeType.White"

field: "com.aspose.pdf.LightingSchemeType.Day"

field: "com.aspose.pdf.LightingSchemeType.Night"

field: "com.aspose.pdf.LightingSchemeType.Hard"

field: "com.aspose.pdf.LightingSchemeType.Primary"

field: "com.aspose.pdf.LightingSchemeType.Blue"

field: "com.aspose.pdf.LightingSchemeType.Red"

field: "com.aspose.pdf.LightingSchemeType.Cube"

field: "com.aspose.pdf.LightingSchemeType.CAD"

field: "com.aspose.pdf.LightingSchemeType.Headlamp"

method: "com.aspose.pdf.Matrix.getElements"

class: "**com.aspose.pdf.Matrix3D**"

method: "com.aspose.pdf.Matrix3D.getA"

method: "com.aspose.pdf.Matrix3D.setA(double)"

method: "com.aspose.pdf.Matrix3D.getB"

method: "com.aspose.pdf.Matrix3D.setB(double)"

method: "com.aspose.pdf.Matrix3D.getC"

method: "com.aspose.pdf.Matrix3D.setC(double)"

method: "com.aspose.pdf.Matrix3D.getD"

method: "com.aspose.pdf.Matrix3D.setD(double)"

method: "com.aspose.pdf.Matrix3D.getE"

method: "com.aspose.pdf.Matrix3D.setE(double)"

method: "com.aspose.pdf.Matrix3D.getF"

method: "com.aspose.pdf.Matrix3D.setF(double)"

method: "com.aspose.pdf.Matrix3D.getG"

method: "com.aspose.pdf.Matrix3D.setG(double)"

method: "com.aspose.pdf.Matrix3D.getH"

method: "com.aspose.pdf.Matrix3D.setH(double)"

method: "com.aspose.pdf.Matrix3D.getI"

method: "com.aspose.pdf.Matrix3D.setI(double)"

method: "com.aspose.pdf.Matrix3D.getTx"

method: "com.aspose.pdf.Matrix3D.setTx(double)"

method: "com.aspose.pdf.Matrix3D.getTy"

method: "com.aspose.pdf.Matrix3D.setTy(double)"

method: "com.aspose.pdf.Matrix3D.getTz"

method: "com.aspose.pdf.Matrix3D.setTz(double)"

method: "com.aspose.pdf.Matrix3D.toString"

method: "com.aspose.pdf.Matrix3D.equals(Object)"

method: "com.aspose.pdf.Matrix3D.getAngle(int)"

method: "com.aspose.pdf.Matrix3D.add(Matrix3D)"

method: "com.aspose.pdf.Matrix3D.hashCode"

method: "com.aspose.pdf.Matrix3D.Matrix3D"

method: "com.aspose.pdf.Matrix3D.Matrix3D(double[])"

method: "com.aspose.pdf.Matrix3D.Matrix3D(Matrix3D)"

method: "com.aspose.pdf.Matrix3D.Matrix3D(double,double,double,double,double,double,double,double,double,double,double,double)"

method: "com.aspose.pdf.Note.getTextState"

method: "com.aspose.pdf.Note.setTextState(TextState)"

class: "**com.aspose.pdf.PDF3DActivation**"

field: "com.aspose.pdf.PDF3DActivation.activeWhenOpen"

field: "com.aspose.pdf.PDF3DActivation.activeWhenVisible"

field: "com.aspose.pdf.PDF3DActivation.activatedUserOrScriptAction"

class: "**com.aspose.pdf.PDF3DAnnotation**"

method: "com.aspose.pdf.PDF3DAnnotation.getPdf3DArtwork"

method: "com.aspose.pdf.PDF3DAnnotation.getLightingScheme"

method: "com.aspose.pdf.PDF3DAnnotation.getContent"

method: "com.aspose.pdf.PDF3DAnnotation.setContent(PDF3DContent)"

method: "com.aspose.pdf.PDF3DAnnotation.getRenderMode"

method: "com.aspose.pdf.PDF3DAnnotation.setDefaultViewIndex(int)"

method: "com.aspose.pdf.PDF3DAnnotation.getViewArray"

method: "com.aspose.pdf.PDF3DAnnotation.getAnnotationType"

method: "com.aspose.pdf.PDF3DAnnotation.accept(AnnotationSelector)"

method: "com.aspose.pdf.PDF3DAnnotation.setImagePreview(String)"

method: "com.aspose.pdf.PDF3DAnnotation.setImagePreview(InputStream)"

method: "com.aspose.pdf.PDF3DAnnotation.clearImagePreview"

method: "com.aspose.pdf.PDF3DAnnotation.getImagePreview"

method: "com.aspose.pdf.PDF3DAnnotation.PDF3DAnnotation(Page,Rectangle,PDF3DArtwork)"

method: "com.aspose.pdf.PDF3DAnnotation.PDF3DAnnotation(Page,Rectangle,PDF3DArtwork,int)"

class: "**com.aspose.pdf.PDF3DArtwork**"

method: "com.aspose.pdf.PDF3DArtwork.getLightingScheme"

method: "com.aspose.pdf.PDF3DArtwork.setLightingScheme(PDF3DLightingScheme)"

method: "com.aspose.pdf.PDF3DArtwork.getRenderMode"

method: "com.aspose.pdf.PDF3DArtwork.setRenderMode(PDF3DRenderMode)"

method: "com.aspose.pdf.PDF3DArtwork.getViewArray"

method: "com.aspose.pdf.PDF3DArtwork.getViewsList"

method: "com.aspose.pdf.PDF3DArtwork.getViewsArray"

method: "com.aspose.pdf.PDF3DArtwork.PDF3DArtwork(Document,PDF3DContent,PDF3DLightingScheme,PDF3DRenderMode)"

method: "com.aspose.pdf.PDF3DArtwork.PDF3DArtwork(Document,PDF3DContent)"

class: **"com.aspose.pdf.PDF3DContent":**

method: "com.aspose.pdf.PDF3DContent.getExtension"

method: "com.aspose.pdf.PDF3DContent.load(String)"

method: "com.aspose.pdf.PDF3DContent.loadAsPRC(String)"

method: "com.aspose.pdf.PDF3DContent.loadAsU3D(String)"

method: "com.aspose.pdf.PDF3DContent.loadAsPRC(InputStream)"

method: "com.aspose.pdf.PDF3DContent.loadAsU3D(InputStream)"

method: "com.aspose.pdf.PDF3DContent.loadAsPRC(byte[])"

method: "com.aspose.pdf.PDF3DContent.loadAsU3D(byte[])"

method: "com.aspose.pdf.PDF3DContent.saveToFile(String)"

method: "com.aspose.pdf.PDF3DContent.getAsStream"

method: "com.aspose.pdf.PDF3DContent.getAsByteArray"

method: "com.aspose.pdf.PDF3DContent.PDF3DContent"

method: "com.aspose.pdf.PDF3DContent.PDF3DContent(String)"

class: "**com.aspose.pdf.PDF3DCrossSection**"

method: "com.aspose.pdf.PDF3DCrossSection.getCenter"

method: "com.aspose.pdf.PDF3DCrossSection.setCenter(Point3D)"

method: "com.aspose.pdf.PDF3DCrossSection.getCuttingPlaneOpacity"

method: "com.aspose.pdf.PDF3DCrossSection.setCuttingPlaneOpacity(double)"

method: "com.aspose.pdf.PDF3DCrossSection.getCuttingPlaneOrientation"

method: "com.aspose.pdf.PDF3DCrossSection.setCuttingPlaneOrientation(PDF3DCuttingPlaneOrientation)"

method: "com.aspose.pdf.PDF3DCrossSection.getCuttingPlaneColor"

method: "com.aspose.pdf.PDF3DCrossSection.setCuttingPlaneColor(Color)"

method: "com.aspose.pdf.PDF3DCrossSection.getCuttingPlanesIntersectionColor"

method: "com.aspose.pdf.PDF3DCrossSection.setCuttingPlanesIntersectionColor(Color)"

method: "com.aspose.pdf.PDF3DCrossSection.getVisibility"

method: "com.aspose.pdf.PDF3DCrossSection.setVisibility(boolean)"

method: "com.aspose.pdf.PDF3DCrossSection.PDF3DCrossSection(Document)"

class: "**com.aspose.pdf.PDF3DCrossSectionArray**"

method: "com.aspose.pdf.PDF3DCrossSectionArray.getCount"

method: "com.aspose.pdf.PDF3DCrossSectionArray.add(PDF3DCrossSection)"

method: "com.aspose.pdf.PDF3DCrossSectionArray.removeAt(int)"

method: "com.aspose.pdf.PDF3DCrossSectionArray.removeAll"

method: "com.aspose.pdf.PDF3DCrossSectionArray.get_Item(int)"

method: "com.aspose.pdf.PDF3DCrossSectionArray.set_Item(int,PDF3DCrossSection)"

method: "com.aspose.pdf.PDF3DCrossSectionArray.PDF3DCrossSectionArray(IDocument)"

class: "**com.aspose.pdf.PDF3DCuttingPlaneOrientation**"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.getAngleX"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.setAngleX(Double)"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.getAngleY"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.setAngleY(Double)"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.getAngleZ"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.setAngleZ(Double)"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.toString"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.PDF3DCuttingPlaneOrientation"

method: "com.aspose.pdf.PDF3DCuttingPlaneOrientation.PDF3DCuttingPlaneOrientation(Double,Double,Double)"

class: "**com.aspose.pdf.PDF3DLightingScheme**"

method: "com.aspose.pdf.PDF3DLightingScheme.getType"

method: "com.aspose.pdf.PDF3DLightingScheme.PDF3DLightingScheme(int)"

method: "com.aspose.pdf.PDF3DLightingScheme.PDF3DLightingScheme(String)"

field: "com.aspose.pdf.PDF3DLightingScheme.Artwork"

field: "com.aspose.pdf.PDF3DLightingScheme.None"

field: "com.aspose.pdf.PDF3DLightingScheme.White"

field: "com.aspose.pdf.PDF3DLightingScheme.Day"

field: "com.aspose.pdf.PDF3DLightingScheme.Night"

field: "com.aspose.pdf.PDF3DLightingScheme.Hard"

field: "com.aspose.pdf.PDF3DLightingScheme.Primary"

field: "com.aspose.pdf.PDF3DLightingScheme.Blue"

field: "com.aspose.pdf.PDF3DLightingScheme.Red"

field: "com.aspose.pdf.PDF3DLightingScheme.Cube"

field: "com.aspose.pdf.PDF3DLightingScheme.CAD"

field: "com.aspose.pdf.PDF3DLightingScheme.Headlamp"

class: **"com.aspose.pdf.PDF3DRenderMode"**

method: "com.aspose.pdf.PDF3DRenderMode.getAuxiliaryColour"

method: "com.aspose.pdf.PDF3DRenderMode.setAuxiliaryColour(Color)"

method: "com.aspose.pdf.PDF3DRenderMode.getFaceColor"

method: "com.aspose.pdf.PDF3DRenderMode.setFaceColor(Color)"

method: "com.aspose.pdf.PDF3DRenderMode.getOpacity"

method: "com.aspose.pdf.PDF3DRenderMode.setOpacity(double)"

method: "com.aspose.pdf.PDF3DRenderMode.setCreaseValue(double)"

method: "com.aspose.pdf.PDF3DRenderMode.getCreaseValue"

method: "com.aspose.pdf.PDF3DRenderMode.getType"

method: "com.aspose.pdf.PDF3DRenderMode.PDF3DRenderMode(int)"

method: "com.aspose.pdf.PDF3DRenderMode.PDF3DRenderMode(String)"

field: "com.aspose.pdf.PDF3DRenderMode.Solid"

field: "com.aspose.pdf.PDF3DRenderMode.SolidWireframe"

field: "com.aspose.pdf.PDF3DRenderMode.Transparent"

field: "com.aspose.pdf.PDF3DRenderMode.TransparentWareFrame"

field: "com.aspose.pdf.PDF3DRenderMode.BoundingBox"

field: "com.aspose.pdf.PDF3DRenderMode.TransparentBoundingBox"

field: "com.aspose.pdf.PDF3DRenderMode.TransparentBoundingBoxOutline"

field: "com.aspose.pdf.PDF3DRenderMode.Wireframe"

field: "com.aspose.pdf.PDF3DRenderMode.ShadedWireframe"

field: "com.aspose.pdf.PDF3DRenderMode.Vertices"

field: "com.aspose.pdf.PDF3DRenderMode.ShadedVertices"

field: "com.aspose.pdf.PDF3DRenderMode.Illustration"

field: "com.aspose.pdf.PDF3DRenderMode.SolidOutline"

field: "com.aspose.pdf.PDF3DRenderMode.ShadedIllustration"

class: "**com.aspose.pdf.PDF3DStream**"

method: "com.aspose.pdf.PDF3DStream.getContent"

method: "com.aspose.pdf.PDF3DStream.setContent(PDF3DContent)"

method: "com.aspose.pdf.PDF3DStream.PDF3DStream(IDocument,PDF3DArtwork)"

class: "**com.aspose.pdf.PDF3DView**"

method: "com.aspose.pdf.PDF3DView.getLightingScheme"

method: "com.aspose.pdf.PDF3DView.setLightingScheme(PDF3DLightingScheme)"

method: "com.aspose.pdf.PDF3DView.getRenderMode"

method: "com.aspose.pdf.PDF3DView.setRenderMode(PDF3DRenderMode)"

method: "com.aspose.pdf.PDF3DView.getCrossSectionsArray"

method: "com.aspose.pdf.PDF3DView.getViewName"

method: "com.aspose.pdf.PDF3DView.setViewName(String)"

method: "com.aspose.pdf.PDF3DView.getCameraPosition"

method: "com.aspose.pdf.PDF3DView.setCameraPosition(Matrix3D)"

method: "com.aspose.pdf.PDF3DView.getCameraOrbit"

method: "com.aspose.pdf.PDF3DView.setCameraOrbit(double)"

method: "com.aspose.pdf.PDF3DView.getBackGroundColor"

method: "com.aspose.pdf.PDF3DView.setBackGroundColor(Color)"

method: "com.aspose.pdf.PDF3DView.PDF3DView(IDocument,Matrix3D,double,String)"

method: "com.aspose.pdf.PDF3DView.PDF3DView(IDocument,PDF3DView,String)"

class: "**com.aspose.pdf.PDF3DViewArray**"

method: "com.aspose.pdf.PDF3DViewArray.getCount"

method: "com.aspose.pdf.PDF3DViewArray.add(PDF3DView)"

method: "com.aspose.pdf.PDF3DViewArray.removeAt(int)"

method: "com.aspose.pdf.PDF3DViewArray.removeAll"

method: "com.aspose.pdf.PDF3DViewArray.get_Item(int)"

method: "com.aspose.pdf.PDF3DViewArray.set_Item(int,PDF3DView)"

method: "com.aspose.pdf.PdfFormatConversionOptions.getNonSpecificationCases"

class: "**com.aspose.pdf.Point3D**"

method: "com.aspose.pdf.Point3D.getX"

method: "com.aspose.pdf.Point3D.setX(double)"

method: "com.aspose.pdf.Point3D.getY"

method: "com.aspose.pdf.Point3D.setY(double)"

method: "com.aspose.pdf.Point3D.getZ"

method: "com.aspose.pdf.Point3D.setZ(double)"

method: "com.aspose.pdf.Point3D.getTrivial"

method: "com.aspose.pdf.Point3D.Point3D(double,double,double)"

class: "**com.aspose.pdf.printing.DuplexKind**"

method: "com.aspose.pdf.printing.DuplexKind.toString(int)"

method: "com.aspose.pdf.printing.DuplexKind.getNames"

field: "com.aspose.pdf.printing.DuplexKind.Default"

field: "com.aspose.pdf.printing.DuplexKind.Horizontal"

field: "com.aspose.pdf.printing.DuplexKind.Simplex"

field: "com.aspose.pdf.printing.DuplexKind.Vertical"

method: "com.aspose.pdf.Rectangle.nearEquals(Rectangle,double)"

method: "com.aspose.pdf.RenderingOptions.getUseFontHinting"

method: "com.aspose.pdf.RenderingOptions.setUseFontHinting(boolean)"

class: "**com.aspose.pdf.RenderModeType**"

field: "com.aspose.pdf.RenderModeType.Solid"

field: "com.aspose.pdf.RenderModeType.SolidWireframe"

field: "com.aspose.pdf.RenderModeType.Transparent"

field: "com.aspose.pdf.RenderModeType.TransparentWareFrame"

field: "com.aspose.pdf.RenderModeType.BoundingBox"

field: "com.aspose.pdf.RenderModeType.TransparentBoundingBox"

field: "com.aspose.pdf.RenderModeType.TransparentBoundingBoxOutline"

field: "com.aspose.pdf.RenderModeType.Wireframe"

field: "com.aspose.pdf.RenderModeType.ShadedWireframe"

field: "com.aspose.pdf.RenderModeType.Vertices"

field: "com.aspose.pdf.RenderModeType.ShadedVertices"

field: "com.aspose.pdf.RenderModeType.Illustration"

field: "com.aspose.pdf.RenderModeType.SolidOutline"

field: "com.aspose.pdf.RenderModeType.ShadedIllustration"

class: "**com.aspose.pdf.RichMediaAnnotation**"

method: "com.aspose.pdf.RichMediaAnnotation.getAnnotationType"

method: "com.aspose.pdf.RichMediaAnnotation.accept(AnnotationSelector)"

method: "com.aspose.pdf.RichMediaAnnotation.getCustomPlayer"

method: "com.aspose.pdf.RichMediaAnnotation.setCustomPlayer(InputStream)"

method: "com.aspose.pdf.RichMediaAnnotation.getCustomFlashVariables"

method: "com.aspose.pdf.RichMediaAnnotation.setCustomFlashVariables(String)"

method: "com.aspose.pdf.RichMediaAnnotation.addCustomData(String,InputStream)"

method: "com.aspose.pdf.RichMediaAnnotation.setContent(String,InputStream)"

method: "com.aspose.pdf.RichMediaAnnotation.getContent_Rename_Namesake"

method: "com.aspose.pdf.RichMediaAnnotation.getType"

method: "com.aspose.pdf.RichMediaAnnotation.setType(int)"

method: "com.aspose.pdf.RichMediaAnnotation.getActivateOn"

method: "com.aspose.pdf.RichMediaAnnotation.setActivateOn(int)"

method: "com.aspose.pdf.RichMediaAnnotation.setPoster(InputStream)"

method: "com.aspose.pdf.RichMediaAnnotation.update"

method: "com.aspose.pdf.RichMediaAnnotation.RichMediaAnnotation(Page,Rectangle)"

class: "**com.aspose.pdf.RichMediaAnnotation.ContentType**"

field: "com.aspose.pdf.RichMediaAnnotation.ContentType.Audio"

field: "com.aspose.pdf.RichMediaAnnotation.ContentType.Video"

field: "com.aspose.pdf.RichMediaAnnotation.ContentType.Unknown"

class: "**com.aspose.pdf.RichMediaAnnotation.ActivationEvent**"

field: "com.aspose.pdf.RichMediaAnnotation.ActivationEvent.Click"

field: "com.aspose.pdf.RichMediaAnnotation.ActivationEvent.PageOpen"

field: "com.aspose.pdf.RichMediaAnnotation.ActivationEvent.PageVisible"

method: "com.aspose.pdf.Table.getWidth_"

method: "com.aspose.pdf.UnifiedSaveOptions.isExtractOcrSublayerOnly"

method: "com.aspose.pdf.UnifiedSaveOptions.setExtractOcrSublayerOnly(boolean)"

**Removed internal classes from public API:**

class: "com.aspose.pdf.text.languages.LanguageTransformation"

class: "com.aspose.pdf.text.languages.RTLTransformation"

**Changed** **public API:**

method: "com.aspose.pdf.OperatorCollection.replace(Iterable)" -> method: "com.aspose.pdf.OperatorCollection.replace(Iterable<Operator>)"

method: "com.aspose.pdf.OperatorCollection.insert(int,Iterable)" -> method: "com.aspose.pdf.OperatorCollection.insert(int,Iterable<Operator>)"

method: "com.aspose.pdf.OperatorCollection.add(Iterable)" -> method: "com.aspose.pdf.OperatorCollection.add(Iterable<Operator>)"



[Add Labels](https://saltov.dynabic.com/wiki/display/PDFJAVA/Public+API+Changes+for+version+17.2.0 "Add Labels ( Type 'l' )")


