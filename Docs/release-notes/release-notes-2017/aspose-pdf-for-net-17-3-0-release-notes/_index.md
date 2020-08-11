---
title: Aspose.PDF for .NET 17.3.0 Release Notes
type: docs
weight: 100
url: /net/aspose-pdf-for-net-17-3-0-release-notes/
---

### **Improvements and Changes**

|**Key**|**Summary**|**Category**|
| :- | :- | :- |
|PDFNET-38548|Support feature to calculate Table Cell width|New Feature|
|PDFNET-40994|Find table width|New Feature|
|PDFNET-39606|Movie is not embedded inside PDF file|New Feature|
|PDFNET-41491|PDF to PDF/A-2u - Support this conversion format|New Feature|
|PDFNET-42230|Setting Footnote Text color|Enhancement|
|PDFNET-41905|Support of TextState in HtmlFragment|Enhancement|
|PDFNET-41665|When color PDF is converted to grayscale, the text stays in color <br> while the picture is black-white|Bug|
|PDFNET-41664|When PDF is converted to TIFF, the output file has black boxes|Bug|
|PDFNET-42078|When PDF converted to PDF_A_1B, the first page is missing a picture|Bug|
|PDFNET-38406|PDF to PDFA1b: compliance failure due to CMYK error|Bug|
|PDFNET-41041|PDF to PDF/A - white image background overlaps background image|Bug|
|PDFNET-41256|PCL to PDF: incorrect output is generated|Bug|
|PDFNET-41281|Incorrect ColorType information is being returned|Bug|
|PDFNET-42030|Pdf file is not compilant with PDF/A-1a format (transparency and missing objects)|Bug|
|PDFNET-41693|PDF to PDF/A - Conversion process takes too much time|Bug|
|PDFNET-41694|PDF to PDF/A - Resultant file is too large|Bug|
|PDFNET-36341|Page color is being detected BlackandWhite instead RGB|Bug|
|PDFNET-39257|RgbToDeviceGrayConversionStrategy convert RGB to black and white instead grayscale|Bug|
|PDFNET-42146|Hyperlink is not working in FloatingBox|Bug|
|PDFNET-41987|Character's size issue when rendering pdf into html|Bug|
|PDFNET-42024|Line Spacing Increased on Multiline Textbox|Bug|
|PDFNET-41684|Latest Aspose.PDF don't show correct ImagePlacement.Rotation|Bug|
|PDFNET-41125|PDF to PDF/A - Missing contents and formatting issues|Bug|
|PDFNET-41349|PDF to DOCX: TOC alignment issue|Bug|
|PDFNET-42091|When PDF is converted to PDF_A_1B, output file is still PDF|Bug|
|PDFNET-42085|When PDF is converted to PDF_A_1B, output file is still classic PDF|Bug|
|PDFNET-42122|Conversion Pdf to Pdfa - output not compliant|Bug|
|PDFNET-41371|When PDF is converted to HTML, produced HTML looks bad and some letters are stretched|Bug|
|PDFNET-39289|PDF to JPEG - Some symbols look like different in resultant file|Bug|
|PDFNET-41995|Additional characters (curly braces) when converting XPS to PDF|Bug|
|PDFNET-38566|PDF to HTML - Color filling isn't displayed for some objects|Bug|
|PDFNET-39740|XFA form is not being converted to Standard Acro Form|Bug|
|PDFNET-42113|PDF to DOCX - Resultant text appears to be in Russian|Bug|
|PDFNET-42283|PDF to PDF/A - Resultant file gets corrupted|Bug|
## **Public API Changes**
Method Aspose.PDF.Annotations.AnnotationSelector.Visit  (Aspose.PDF.Annotations.RichMediaAnnotation)
Method Aspose.PDF.Annotations.AnnotationSelector.Visit  (Aspose.PDF.Annotations.PDF3DAnnotation)
Enumeration member Aspose.PDF.Annotations.AnnotationType.PDF3D  
Enumeration type Aspose.PDF.Annotations.LightingSchemeType  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Artwork  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.None  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.White  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Day  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Night  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Hard  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Primary  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Blue  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Red  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Cube  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.CAD  
Enumeration member Aspose.PDF.Annotations.LightingSchemeType.Headlamp  
Enumeration type Aspose.PDF.Annotations.PDF3DActivation  
Aspose.PDF.Annotations.PDF3DActivation.activeWhenOpen  
Enumeration member Aspose.PDF.Annotations.PDF3DActivation.activeWhenVisible  
EnumerationmemberAspose.PDF.Annotations.PDF3DActivation.activatedUserOrScriptAction  
#### **Class Aspose.PDF.Annotations.PDF3DAnnotation**
Method Aspose.PDF.Annotations.PDF3DAnnotation.Constructor    (Aspose.PDF.Page,Aspose.PDF.Rectangle,Aspose.PDF.Annotations.PDF3DArtwork)    
Method Aspose.PDF.Annotations.PDF3DAnnotation.Constructor    (Aspose.PDF.Page,Aspose.PDF.Rectangle,Aspose.PDF.Annotations.PDF3DArtwork,Aspose.PDF.Annotations.PDF3DActivation)    
Property Aspose.PDF.Annotations.PDF3DAnnotation.Pdf3DArtwork      
Property Aspose.PDF.Annotations.PDF3DAnnotation.LightingScheme      
Property Aspose.PDF.Annotations.PDF3DAnnotation.Content      
Property Aspose.PDF.Annotations.PDF3DAnnotation.RenderMode      
Property Aspose.PDF.Annotations.PDF3DAnnotation.ViewArray      
Property Aspose.PDF.Annotations.PDF3DAnnotation.AnnotationType      
Method Aspose.PDF.Annotations.PDF3DAnnotation.SetDefaultViewIndex(System.Int32)      
Method Aspose.PDF.Annotations.PDF3DAnnotation.Accept      (Aspose.PDF.Annotations.AnnotationSelector)        
Method Aspose.PDF.Annotations.PDF3DAnnotation.SetImagePreview(System.String)        
Method Aspose.PDF.Annotations.PDF3DAnnotation.SetImagePreview(System.IO.Stream)  
Method Aspose.PDF.Annotations.PDF3DAnnotation.ClearImagePreview  
Method Aspose.PDF.Annotations.PDF3DAnnotation.GetImagePreview  
#### **Class Aspose.PDF.Annotations.PDF3DArtwork**
Method Aspose.PDF.Annotations.PDF3DArtwork.Constructor  (Aspose.PDF.Document,Aspose.PDF.Annotations.PDF3DContent,Aspose.PDF.Annotations.  PDF3DLightingScheme,Aspose.PDF.Annotations.PDF3DRenderMode)  
Method Aspose.PDF.Annotations.PDF3DArtwork.Constructor  (Aspose.PDF.Document,Aspose.PDF.Annotations.PDF3DContent)  
Property Aspose.PDF.Annotations.PDF3DArtwork.LightingScheme  
Property Aspose.PDF.Annotations.PDF3DArtwork.RenderMode  
Property Aspose.PDF.Annotations.PDF3DArtwork.ViewArray    
Method Aspose.PDF.Annotations.PDF3DArtwork.GetViewsList  
Method Aspose.PDF.Annotations.PDF3DArtwork.GetViewsArray  
#### **Class Aspose.PDF.Annotations.PDF3DContent**
Method Aspose.PDF.Annotations.PDF3DContent.Constructor    
Method Aspose.PDF.Annotations.PDF3DContent.Constructor(System.String)      
Property Aspose.PDF.Annotations.PDF3DContent.Extension      
MethodAspose.PDF.Annotations.PDF3DContent.Load(System.String)  
MethodAspose.PDF.Annotations.PDF3DContent.LoadAsPRC(System.String)    
Method Aspose.PDF.Annotations.PDF3DContent.LoadAsU3D(System.String)    
Method Aspose.PDF.Annotations.PDF3DContent.LoadAsPRC(System.IO.Stream)    
Method Aspose.PDF.Annotations.PDF3DContent.LoadAsU3D(System.IO.Stream)    
Method Aspose.PDF.Annotations.PDF3DContent.LoadAsPRC(System.Byte[])    
Method Aspose.PDF.Annotations.PDF3DContent.LoadAsU3D(System.Byte[])    
Method Aspose.PDF.Annotations.PDF3DContent.SaveToFile(System.String)    
Method Aspose.PDF.Annotations.PDF3DContent.GetAsStream    
Method Aspose.PDF.Annotations.PDF3DContent.GetAsByteArray    
#### **Class Aspose.PDF.Annotations.PDF3DCrossSection**
Method Aspose.PDF.Annotations.PDF3DCrossSection.Constructor(Aspose.PDF.Document)  
Property Aspose.PDF.Annotations.PDF3DCrossSection.Center  
Property Aspose.PDF.Annotations.PDF3DCrossSection.CuttingPlaneOpacity  
Property Aspose.PDF.Annotations.PDF3DCrossSection.CuttingPlaneOrientation  
Property Aspose.PDF.Annotations.PDF3DCrossSection.CuttingPlaneColor  
Property Aspose.PDF.Annotations.PDF3DCrossSection.CuttingPlanesIntersectionColor  
Property Aspose.PDF.Annotations.PDF3DCrossSection.Visibility  
#### **Class Aspose.PDF.Annotations.PDF3DCrossSectionArray**
MethodAspose.PDF.Annotations.PDF3DCrossSectionArray.Constructor(Aspose.PDF.Document)    
PropertyAspose.PDF.Annotations.PDF3DCrossSectionArray.Count    
PropertyAspose.PDF.Annotations.PDF3DCrossSectionArray.Item(System.Int32)    
MethodAspose.PDF.Annotations.PDF3DCrossSectionArray.Add(Aspose.PDF.Annotations.PDF3DCrossSection)    
MethodAspose.PDF.Annotations.PDF3DCrossSectionArray.RemoveAt(System.Int32)    
MethodAspose.PDF.Annotations.PDF3DCrossSectionArray.RemoveAll    
#### **Class Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation**
Method Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation.Constructor  
Method Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation.Constructor  (System.Double?,System.Double?,System.Double?)  
Property Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation.AngleX  
Property Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation.AngleY  
Property Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation.AngleZ  
Method Aspose.PDF.Annotations.PDF3DCuttingPlaneOrientation.ToString  
Enumeration type Aspose.PDF.Annotations.PDF3DLightingScheme  
MethodAspose.PDF.Annotations.PDF3DLightingScheme.Constructor(Aspose.PDF.Annotations.LightingSchemeType)  
Method Aspose.PDF.Annotations.PDF3DLightingScheme.Constructor(System.String)  
Property Aspose.PDF.Annotations.PDF3DLightingScheme.Type  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Artwork  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.None  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.White  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Day  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Night  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Hard  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Primary  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Blue  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Red  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Cube  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.CAD  
Enumeration member Aspose.PDF.Annotations.PDF3DLightingScheme.Headlamp  
Enumeration type Aspose.PDF.Annotations.PDF3DRenderMode  
Method Aspose.PDF.Annotations.PDF3DRenderMode.Constructor  (Aspose.PDF.Annotations.RenderModeType)  
Method Aspose.PDF.Annotations.PDF3DRenderMode.Constructor(System.String)  
Property Aspose.PDF.Annotations.PDF3DRenderMode.Type  
Method Aspose.PDF.Annotations.PDF3DRenderMode.GetAuxiliaryColour  
Method Aspose.PDF.Annotations.PDF3DRenderMode.SetAuxiliaryColour(Aspose.PDF.Color)  
Method Aspose.PDF.Annotations.PDF3DRenderMode.GetFaceColor  
Method Aspose.PDF.Annotations.PDF3DRenderMode.SetFaceColor(Aspose.PDF.Color)  
Method Aspose.PDF.Annotations.PDF3DRenderMode.GetOpacity  
Method Aspose.PDF.Annotations.PDF3DRenderMode.SetOpacity(System.Double)  
Method Aspose.PDF.Annotations.PDF3DRenderMode.SetCreaseValue(System.Double)  
Method Aspose.PDF.Annotations.PDF3DRenderMode.GetCreaseValue  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.Solid  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.SolidWireframe  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.Transparent  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.TransparentWareFrame  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.BoundingBox  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.TransparentBoundingBox  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.TransparentBoundingBoxOutline  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.Wireframe  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.ShadedWireframe  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.Vertices  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.ShadedVertices  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.Illustration  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.SolidOutline  
Enumeration member Aspose.PDF.Annotations.PDF3DRenderMode.ShadedIllustration  
#### **Class Aspose.PDF.Annotations.PDF3DStream**
MethodAspose.PDF.Annotations.PDF3DStream.Constructor(Aspose.PDF.Document,Aspose.PDF.Annotations.PDF3DArtwork)    
Property Aspose.PDF.Annotations.PDF3DStream.Content    
#### **Class Aspose.PDF.Annotations.PDF3DView**
MethodAspose.PDF.Annotations.PDF3DView.Constructor(Aspose.PDF.Document,Aspose.PDF.Matrix3D,System.Double,System.String)  
MethodAspose.PDF.Annotations.PDF3DView.Constructor(Aspose.PDF.Document,Aspose.PDF.Annotations.PDF3DView,System.String)  
Property Aspose.PDF.Annotations.PDF3DView.LightingScheme  
Property Aspose.PDF.Annotations.PDF3DView.RenderMode  
Property Aspose.PDF.Annotations.PDF3DView.CrossSectionsArray  
Property Aspose.PDF.Annotations.PDF3DView.ViewName  
Property Aspose.PDF.Annotations.PDF3DView.CameraPosition  
Property Aspose.PDF.Annotations.PDF3DView.CameraOrbit  
Property Aspose.PDF.Annotations.PDF3DView.BackGroundColor  
#### **Class Aspose.PDF.Annotations.PDF3DViewArray**
Property Aspose.PDF.Annotations.PDF3DViewArray.Count
Property Aspose.PDF.Annotations.PDF3DViewArray.Item(System.Int32)
Method Aspose.PDF.Annotations.PDF3DViewArray.Add(Aspose.PDF.Annotations.PDF3DView)
Method Aspose.PDF.Annotations.PDF3DViewArray.RemoveAt(System.Int32)
Method Aspose.PDF.Annotations.PDF3DViewArray.RemoveAll
Enumeration type Aspose.PDF.Annotations.RenderModeType
Enumeration member Aspose.PDF.Annotations.RenderModeType.Solid
Enumeration member Aspose.PDF.Annotations.RenderModeType.SolidWireframe
Enumeration member Aspose.PDF.Annotations.RenderModeType.Transparent
Enumeration member Aspose.PDF.Annotations.RenderModeType.TransparentWareFrame
Enumeration member Aspose.PDF.Annotations.RenderModeType.BoundingBox
Enumeration member Aspose.PDF.Annotations.RenderModeType.TransparentBoundingBox
Enumeration member Aspose.PDF.Annotations.RenderModeType.TransparentBoundingBoxOutline
Enumeration member Aspose.PDF.Annotations.RenderModeType.Wireframe
Enumeration member Aspose.PDF.Annotations.RenderModeType.ShadedWireframe
Enumeration member Aspose.PDF.Annotations.RenderModeType.Vertices
Enumeration member Aspose.PDF.Annotations.RenderModeType.ShadedVertices
Enumeration member Aspose.PDF.Annotations.RenderModeType.Illustration
Enumeration member Aspose.PDF.Annotations.RenderModeType.SolidOutline
Enumeration member Aspose.PDF.Annotations.RenderModeType.ShadedIllustration
#### **Class Aspose.PDF.Annotations.RichMediaAnnotation**
MethodAspose.PDF.Annotations.RichMediaAnnotation.Constructor(Aspose.PDF.Page,Aspose.PDF.Rectangle)
Property Aspose.PDF.Annotations.RichMediaAnnotation.AnnotationType
Property Aspose.PDF.Annotations.RichMediaAnnotation.CustomPlayer
Property Aspose.PDF.Annotations.RichMediaAnnotation.CustomFlashVariables
Property Aspose.PDF.Annotations.RichMediaAnnotation.Content
Property Aspose.PDF.Annotations.RichMediaAnnotation.Type
Property Aspose.PDF.Annotations.RichMediaAnnotation.ActivateOn
Method Aspose.PDF.Annotations.RichMediaAnnotation.Accept(Aspose.PDF.Annotations.AnnotationSelector)
Method Aspose.PDF.Annotations.RichMediaAnnotation.AddCustomData(System.String,System.IO.Stream)
Method Aspose.PDF.Annotations.RichMediaAnnotation.SetContent(System.String,System.IO.Stream)
Method Aspose.PDF.Annotations.RichMediaAnnotation.SetPoster(System.IO.Stream)
Method Aspose.PDF.Annotations.RichMediaAnnotation.Update
Enumeration type Aspose.PDF.Annotations.RichMediaAnnotation.ActivationEvent
Enumeration member Aspose.PDF.Annotations.RichMediaAnnotation.ActivationEvent.Click
Enumeration member Aspose.PDF.Annotations.RichMediaAnnotation.ActivationEvent.PageOpen
Enumeration member Aspose.PDF.Annotations.RichMediaAnnotation.ActivationEvent.PageVisible
Enumeration type Aspose.PDF.Annotations.RichMediaAnnotation.ContentType
Enumeration member Aspose.PDF.Annotations.RichMediaAnnotation.ContentType.Audio
Enumeration member Aspose.PDF.Annotations.RichMediaAnnotation.ContentType.Video
Enumeration member Aspose.PDF.Annotations.RichMediaAnnotation.ContentType.Unknown
Enumeration member Aspose.PDF.BlendMode.Compatible
Property Aspose.PDF.Cell.Width
Property Aspose.PDF.Forms.Form.IgnoreNeedsRendering
Property Aspose.PDF.HtmlFragment.TextState
Property Aspose.PDF.Matrix.Elements
#### **Class Aspose.PDF.Matrix3D**
Method Aspose.PDF.Matrix3D.Constructor
Method Aspose.PDF.Matrix3D.Constructor(System.Double[])
Method Aspose.PDF.Matrix3D.Constructor(Aspose.PDF.Matrix3D)
Method Aspose.PDF.Matrix3D.Constructor(System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double,System.Double)
Property Aspose.PDF.Matrix3D.A
Property Aspose.PDF.Matrix3D.B
Property Aspose.PDF.Matrix3D.C
Property Aspose.PDF.Matrix3D.D
Property Aspose.PDF.Matrix3D.E
Property Aspose.PDF.Matrix3D.F
Property Aspose.PDF.Matrix3D.G
Property Aspose.PDF.Matrix3D.H
Property Aspose.PDF.Matrix3D.I
Property Aspose.PDF.Matrix3D.Tx
Property Aspose.PDF.Matrix3D.Ty
Property Aspose.PDF.Matrix3D.Tz
Method Aspose.PDF.Matrix3D.ToString
Method Aspose.PDF.Matrix3D.Equals(System.Object)
Method Aspose.PDF.Matrix3D.GetAngle(Aspose.PDF.Rotation)
Method Aspose.PDF.Matrix3D.Add(Aspose.PDF.Matrix3D)
Method Aspose.PDF.Matrix3D.GetHashCode
Property Aspose.PDF.Note.TextState
#### **Class Aspose.PDF.Point3D**
Method Aspose.PDF.Point3D.Constructor  (System.Double,System.Double,System.Double)  
Property Aspose.PDF.Point3D.X  
Property Aspose.PDF.Point3D.Y  
Property Aspose.PDF.Point3D.Z  
Property Aspose.PDF.Point3D.Trivial  
Method Aspose.PDF.Rectangle.NearEquals(Aspose.PDF.Rectangle,System.Double)  
Property Aspose.PDF.RenderingOptions.UseFontHinting  
Method Aspose.PDF.Table.GetWidth  
