1. show error
2. dialogs style
+3. alert -> message
+4. tblAttach View Attachments
+5. close dialogs
6. The process cannot access the file '/home/hitesh/Documents/w/aspose-pdf-editor/aspose-pdf-editor/temp/25b7834e-5708-4542-98fc-7b3d855e22ce/document.pdf' because it is being used by another process.
. 
1.add attachment:  System.UnauthorizedAccessException
  HResult=0x80070005
  Message=Access to the path 'c:\temp\91f2823b-5d6e-4daf-90c0-af127cfd747e' is denied.
  Source=System.Private.CoreLib
  StackTrace:
   at Microsoft.Win32.SafeHandles.SafeFileHandle.CreateFile(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options)
   at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
   at System.IO.Strategies.OSFileStreamStrategy..ctor(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
   at System.IO.File.OpenWrite(String path)
   at Aspose.PDF.Editor.Services.StorageService.<Upload>d__6.MoveNext() in C:\Users\epiro\Documents\w\Aspose.PDF-for-.NET\Showcases\aspose-pdf-editor\pdf-editor-mvc\Services\StorageService.cs:line 38

at Aspose.PDF.Editor.Controllers.AsposePdfEditorController.StorageUpload(String url, Stream s) in /home/hitesh/Documents/w/aspose-pdf-editor/aspose-pdf-editor/Controllers/AsposePdfEditorController.cs:line 73
+7. add text
+8. plus page is empty
9. search working only on first page
+10. namespace line
11. remove TODO
12. Upload API => DocumentService
13. UploadPic => PrimitiveService
14. makeItalic all buttons ?
+15. remove try catch
16. ScaleImage => ImageService
+17. ViewModelBase
+18. camel case props
+19. organization  "2066, Australia"; ?
+20. AdditionalRequestData ?
+21. drop params EditPdf(string FileName, string FolderName, string CallbackURL)
22. readme
23. license limitation message
24. move constans to configuration
25. System.Exception: No suitable system fonts found
26. split view model, model
+27. System.Resources.MissingManifestResourceException: Could not find the resource "Aspose.PDF.Editor.AppResources.Editor.PdfEditorResources.resources" among the resources "pdf_editor_mvc.AppResources.Editor.PdfEditorResources.resources" embedded in the assembly "pdf-editor-mvc", nor among the resources in any satellite assemblies for the specified culture. Perhaps the resources were embedded with an incorrect name.
+28. .net 7.0 libs
29. Privacy page
30. Upload => uploading, appending, addAttachment
31. url = documentFileName
+32. page loading hang on secons save
+33. ajax done
+34. GetAttachments is empty
+35. [ApiController]
36. FileExists => GetThumbnails
37. UploadPic => AddPrimitives
38. GetPageImage => GtThumbnail
39. GetPageImage read page or multiple?
40. delete all pages, add page -> 1 page
41. export = download
42. folder = documentId
+43. clear console
45. add text dialog buttons
46. ubdefined docx
47. append pdf no description internal server error
48. ad image to page not supported images
49. text also visible on second page
50. view attachments => download
51. remove attachment
52. No Document scroll on mobile
53. add link to docs https://github.com/aspose-pdf/Aspose.PDF-for-.NET/tree/master/Showcases