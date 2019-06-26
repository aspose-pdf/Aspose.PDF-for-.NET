using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks;
using Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion;
using Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.PDFToHTMLFormat;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Forms;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Images;
using Aspose.Pdf.Examples.CSharp.AsposePDF.LinksActions;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Operators;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Pages;
using Aspose.Pdf.Examples.CSharp.AsposePDF.SecuritySignatures;
using Aspose.Pdf.Examples.CSharp.AsposePDF.StampsWatermarks;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Tables;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Text;
using Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Working_Document;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Miscellaneous;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Graphs;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Headings;
using Aspose.Pdf.Examples.CSharp.AsposePDF.TechnicalArticles;
using Aspose.Pdf.Examples.CSharp.AsposePDF.QuickStart;

using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Annotations;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Attachments;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Bookmarks;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Forms;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Images;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.StampsWatermarks;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Text;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.WorkingDocument;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.LinksActions;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.Append;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ConcatenateDocuments;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.DeletePages;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ExtractPages;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.InsertPages;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeBooklet;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.MakeNUp;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.SplitPages;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Pages.ManipulatePageProperties;
using Aspose.Pdf.Examples.CSharp.AsposePDFFacades.TechnicalArticles;
using Aspose.Pdf.Examples.CSharp.AsposePDF.Working_with_TaggedPDFs;
using Aspose.Pdf.Examples.CSharp.AsposePdfFacades.Security_Signatures;

namespace Aspose.Pdf.Examples.CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");
            // Uncomment the one you want to try out

            // =====================================================
            // =====================================================
            // Aspose.Pdf 
            // =====================================================
            // =====================================================

            //// QuickStart
            //// =====================================================   
            // HelloWorld.Run();
            // LoadLicenseFromFile.Run();
            // LoadLicenseFromStreamObject.Run();
            // SetLicenseUsingEmbeddedResource.Run();

            //// Text
            //// =====================================================            
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Text.ExtractTextPage.Run();
            // ReplaceTextAll.Run();           
            // SearchAndGetTextAll.Run();
            // SearchAndGetTextPage.Run();
            // SearchRegularExpression.Run();
            // ReplaceTextonRegularExpression.Run();
            // ReplaceFirstOccurrence.Run();
            // SearchTextSegmentsPage.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Text.AddText.Run();
            // ExtractTextUsingTextDevice.Run();
            // ReplaceFonts.Run();
            // HighlightCharacterInPDF.Run();
            // AddHTMLUsingDOM.Run();
            // AddHTMLUsingDOM.HTMLfragmentRectangle();
            // AddHTMLOrderedListIntoDocuments.Run();
            // SetHTMLStringFormatting.Run();
            // AddHTMLUsingDOMAndOverwrite.Run();
            // RearrangeContentsUsingTextReplacement.Run();
            // FootAndEndNotes.Run();
            // SearchTextAndAddHyperlink.Run();
            // TextAndImageAsParagraph.Run();
            // ExtractColumnsText.Run();
            // SpecifyCharacterSpacing.Run();
            // CreateMultiColumnPdf.Run();
            // AsposePDF.Text.CustomTabStops.Run();
            // RenderingReplaceableSymbols.Run();
            // ReplaceableSymbolsInHeaderFooter.Run();
            // AddTransparentText.Run();
            // SearchTextAndDrawRectangle.Run();
            // PlacingTextAroundImage.Run();
            // AddTooltipToText.Run();
            // HiddenTextBlock.Run();
            // SpecifyLineSpacing.Run();
            // EmbedStandardType1Fonts.Run();
            // UseLatexScript.Run();
            // UseLatexScript2.Run();
            // ExtractParagraphs.Run();
            // ExtractParagraphsByDrawingBorder.Run();
            // AddTextBorder.Run();
            // AddSubsequentLinesIndent.Run();
            // DetermineLineBreak.Run();
            // RemoveAllText.Run();
            // RemoveAllTextFromPDF.Run();
            // AddTextWithShadingColors.Run();
            // MulticolumnParagraphs.Run();

            //// Images
            //// =====================================================   
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Images.AddImage.Run();   
            // DeleteImages.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Images.ExtractImages.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Images.ReplaceImage.Run();
            // PagesToImages.Run();
            // ConvertAllPagesToPNG.Run();
            // PageToTIFF.Run();
            // AllPagesToTIFF.Run();
            // BradleyAlgorithm.Run();
            // ConvertAllPagesToEMF.Run();
            // PageToEMF.Run();
            // CGMImageToPDF.Run();
            // LargeCGMImageToPDF.Run();
            // ImageToPDF.Run();
            // ConvertToBMP.Run();
            // IdentifyImages.Run();
            // ConvertPageRegionToDOM.Run();
            // ConvertImageStreamtoPDF.Run();
            // SetImageSize.Run();
            // ShrinkImages.Run();
            // FastShrinkImages.Run();
            // ResizeImages.Run();

            //// Stamps-Watermarks
            //// =====================================================   
            // AddTextStamp.Run();
            // AddImageStamp.Run();
            // AddPDFPageStamp.Run();
            // PageNumberStamps.Run();
            // TextinHeader.Run();
            // TextinFooter.Run();
            // ImageinHeader.Run();
            // ImageInFooter.Run();    
            // AddingDifferentHeaders.Run();
            // DefineAlignment.Run();
            // AddDateTimeStamp.Run();
            // ImageandPageNumberinHeaderFootersection.Run();
            // ImageandPageNumberinHeaderFootersectionInline.Run();
            // PageNumberinHeaderFooterUsingFloatingBox.Run();
            // TableInHeaderFooterSection.Run();
            // FillStrokeText.Run();

            //// Attachments
            //// =====================================================   
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments.AddAttachment.Run();
            // GetAlltheAttachments.Run();
            // GetIndividualAttachment.Run();
            // GetAttachmentInfo.Run();
            // DisableFilesCompression.Run();

            //// Pages
            //// =====================================================   
            // GetNumberofPages.Run();
            // GetPageCount.Run();
            // GetProperties.Run();
            // ConcatenatePdfFiles.Run();
            // InsertEmptyPage.Run();
            // InsertEmptyPageAtEnd.Run();
            // SplitToPages.Run();
            // GetParticularPage.Run();
            // DeleteParticularPage.Run();
            // UpdateDimensions.Run();
            // GetDimensions.Run();
            // ImageAsBackground.Run();
            // DeterminePageColor.Run(); 
            // ChangeOrientation.Run();
            // ZoomToPageContents.Run();

            //// Working-Document
            //// =====================================================   
            // SetDocumentWindow.Run();
            // GetDocumentWindow.Run();
            // ValidatePDFAStandard.Run();
            // ValidatePDFUAstandard.Run();
            // OptimizeDocument.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetFileInfo.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetFileInfo.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetXMPMetadata.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetXMPMetadata.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetZoomFactor.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetZoomFactor.Run();
            // AddTOC.Run();
            // OptimizeFileSize.Run();
            // TrimWhiteSpace.Run();
            // AddJavaScriptToPage.Run();
            // AddRemoveJavascriptToDoc.Run();
            // AddLayers.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.EmbedFont.Run();
            // EmbedFontWhileDocCreation.Run();
            // EmbedFontsUsingSubsetStrategy.Run();
            // ConvertFromRGBToGrayscale.Run();
            // SetExpiryDate.Run();
            // CreateMultilayerPDFFirstApproach.Run();
            // CreateMultilayerPDFSecondApproach.Run();
            // CreatePDFA1WithAsposePdf.Run();
            // HidePageNumbersInTOC.Run();
            // SetDefaultFont.Run();
            // GetAllFonts.Run();
            // ShrinkDocuments.Run();
            // RemoveUnusedObjects.Run();
            // RemoveUnusedStreams.Run();
            // LinkDuplicateStreams.Run();
            // AllowResusePageContent.Run();
            // UnembedFonts.Run();
            // FlattenAnnotation.Run();
            // CreateThumbnailImages.Run();
            // HelloWorldPDFUsingXmlAndXslt.Run();

            //// Working-with-Tagged PDFs
            //// ===================================================== 
            // CreatePDFwithTaggedText.Run();
            // CreatePDFwithTaggedImage.Run();
            // TaggedPDFContent.Run();
            // CreateStructureElements.Run();
            // RootStructure.Run();
            // CreateStructureElementsTree.Run();
            // StructureElementsProperties.Run();
            // AccessChildrenElements.Run();
            // TextStructureElements.Run();
            // TextBlockStructureElements.Run();
            // InlineStructureElements.Run();
            // CustomTagName.Run();
            // StyleTextStructure.Run();
            // IllustrationStructureElements.Run();
            // LinkStructureElements.Run();
            // AddStructureElementIntoElement.Run();
            // TagImageInExistingPDF.Run();
            // CreateNoteStructureElement.Run();

            //// Bookmarks
            //// =====================================================   
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.AddBookmark.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.AddChildBookmark.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.DeleteAllBookmarks.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.DeleteParticularBookmark.Run();
            // GetBookmarks.Run();
            // GetChildBookmarks.Run();
            // UpdateBookmarks.Run();
            // UpdateChildBookmarks.Run();
            // InheritZoom.Run();
            // ExpandBookmarks.Run();

            //// Annotations
            //// =====================================================   
            // AddAnnotation.Run();
            // InvisibleAnnotation.Run();
            // AddlnkAnnotation.Run();
            // LnkAnnotationLineWidth.Run();
            // GetParticularAnnotation.Run();
            // GetAllAnnotationsFromPage.Run();
            // DeleteParticularAnnotation.Run();
            // DeleteAllAnnotationsFromPage.Run();
            // AddSwfFileAsAnnotation.Run();
            // SetFreeTextAnnotationFormatting.Run();
            // StrikeOutWords.Run();
            // ExtractHighlightedText.Run();
            // GetResourceOfAnnotation.Run();

            //// Forms
            //// =====================================================   
            // TextBox.Run();
            // RadioButtonWithOptions.Run();
            // ComboBox.Run();
            // DeleteFormField.Run();  
            // ModifyFormField.Run();   
            // FillFormField.Run();
            // ArabicTextFilling.Run();
            // SelectRadioButton.Run();
            // GetValueFromField.Run();
            // GetValueFromField.Run(); 
            // SetFieldLimit.Run();
            // MoveFormField.Run();
            // AddTooltipToField.Run();
            // GetFieldsFromRegion.Run();
            // FormFieldFont14.Run();
            // DynamicXFAToAcroForm.Run();
            // FillXFAFields.Run();
            // GetXFAProperties.Run();
            // DetermineRequiredField.Run();
            // SetJavaScript.Run();
            // HorizontallyAndVerticallyRadioButtons.Run();
            // GroupedCheckBoxes.Run();
            // SetRadioButtonCaption.Run();
            // FlattenForms.Run();

            //// TechnicalArticles
            //// =====================================================            
            // CreatePDFPortfolio.Run();
            // ExtractFilesFromPortfolio.Run();
            // RemoveFilesFromPortfolio.Run();

            //// Links-Actions
            //// =====================================================   
            // CreateApplicationLink.Run();
            // CreateDocumentLink.Run();
            // RemoveOpenAction.Run();
            // ExtractLinks.Run();
            // AddHyperlink.Run();
            // UpdateLinks.Run();
            // SetDestinationLink.Run();
            // UpdateLinkTextColor.Run();
            // SpecifyPageWhenViewing.Run();
            // GetHyperlinkDestinations.Run();
            // GetHyperlinkText.Run();
            // CreateLocalHyperlink.Run();

            //// Security-Signatures
            //// =====================================================   
            // Encrypt.Run();
            // Decrypt.Run();
            // ChangePassword.Run();
            // IsPasswordProtected.Run();
            // DetermineCorrectPassword.Run();
            // ExtractingImage.Run();
            // SetPrivileges.Run();
            // SignWithSmartCardUsingSignatureField.Run();
            // SignWithSmartCardUsingPdfFileSignature.Run();

            //// Operators
            //// =====================================================   
            // DrawXFormOnPage.Run();
            // PDFOperators.Run();
            // RemoveGraphicsObjects.Run();

            //// Miscellaneous
            //// =====================================================   
            // GetBuildInformation.Run();
            // UseMeasureWithLineAnnotation.Run();
            // UseMeasureWithPolylineAnnotation.Run();

            //// Tables
            //// =====================================================  
            // AddImageinATableCell.Run();
            // AddTable.Run();
            // AutoFitToWindow.Run();  
            // MarginsOrPadding.Run();
            // SetBorder.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Tables.IntegrateWithDatabase.Run();
            // RenderTable.Run();
            // AddSVGObject.Run();
            // ExtractBorder.Run();
            // InsertPageBreak.Run();
            // DetermineTableBreak.Run();
            // ExportExcelWorksheetDataToTable.Run();
            // AddRepeatingColumn.Run();
            // HTMLTagsInsideTable.Run();
            // RemoveTable.Run();
            // RemoveMultipleTables.Run();
            // ReplaceTable.Run();
            // GetTableWidth.Run();

            //// Graphs
            //// =====================================================   
            // CreateFilledRectangle.Run();
            // AddLineObject.Run();
            // DashLength.Run();
            // DrawingLine.Run();
            // CreateRectangleWithAlphaColor.Run();
            // AddDrawing.Run();
            // ControlRectangleZOrder.Run();

            //// Headings
            //// =====================================================   
            // ApplyNumberStyle.Run();

            //  DocumentConversion
            // =====================================================   
            // PDFToPDFA.Run();
            // PDFToPDFA3b.Run();
            // AddAttachmentToPDFA.Run();
            // PDFToDOC.Run();
            // PDFToTeX.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion.SVGToPDF.Run();
            // RemoveHyperlinksAfterConvertingFromHtml.Run();
            // PageOrientationAccordingImageDimensions.Run();
            // TIFFtoPDFPerformanceImprovement.Run();
            // GetSVGDimensions.Run();
            // EPUBToPDF.Run();
            // PDFToEPUB.Run();
            // PDFToXPS.Run();
            // PDFToXLS.Run();
            // PDFToXLS.PDFtoXLSX();
            // PDFToSVG.Run();
            // PDFToXML.Run();
            // MHTToPDF.Run();
            // TextToPDF.Run();
            // CGMToPDF.Run();
            // PDFToPPT.Run();
            // PDFAToPDF.Run();
            // XMLToPDF.Run();
            // PDFToPNGFontHinting.Run();
            // PostscriptToPDF.Run();
            // XMLToPDFSetImagePath.Run();
            // PCLToPDF.Run();
            // PCLToPDF.PCLstream();
            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        public static String GetDataDir_AsposePdf_TechnicalArticles()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Technical-Articles/");
        }
        public static String GetDataDir_AsposePdfFacades_TechnicalArticles()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Technical-Articles/");
        }
        public static String GetDataDir_AsposePdf_DocumentConversion_PDFToHTMLFormat()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/DocumentConversion/PDFToHTMLFormat/");
        }
        public static String GetDataDir_AsposePdf_Annotations()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Annotations/");
        }
        public static String GetDataDir_AsposePdf_Graphs()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Graphs/");
        }
        public static String GetDataDir_AsposePdf_Headings()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Headings/");
        }
        public static String GetDataDir_AsposePdf_Miscellaneous()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Miscellaneous/");
        }
        public static String GetDataDir_AsposePdf_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Attachments/");
        }
        public static String GetDataDir_AsposePdf_Bookmarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Bookmarks/");
        }
        public static String GetDataDir_AsposePdf_DocumentConversion()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/DocumentConversion/");
        }
        public static String GetDataDir_AsposePdf_Forms()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Forms/");
        }
        public static String GetDataDir_AsposePdf_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Images/");
        }
        public static String GetDataDir_AsposePdf_LinksActions()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Links-Actions/");
        }
        public static String GetDataDir_AsposePdf_Operators()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Operators/");
        }
        public static String GetDataDir_AsposePdf_Pages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Pages/");
        }
        public static String GetDataDir_AsposePdf_SecuritySignatures()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Security-Signatures/");
        }
        public static String GetDataDir_AsposePdf_QuickStart()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/QuickStart/");
        }
        public static String GetDataDir_AsposePdf_StampsWatermarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Stamps-Watermarks/");
        }
        public static String GetDataDir_AsposePdf_Tables()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Tables/");
        }
        public static String GetDataDir_AsposePdf_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Text/");
        }
        public static String GetDataDir_AsposePdf_WorkingDocuments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePDF/Working-Document/");
        }
        public static String GetDataDir_AsposePdfFacades_SecuritySignatures()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Security-Signatures/");
        }
        public static String GetDataDir_AsposePdfFacades_Annotations()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Annotations/");
        }
        public static String GetDataDir_AsposePdfFacades_Attachments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Attachments/");
        }
        public static String GetDataDir_AsposePdfFacades_Bookmarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Bookmarks/");
        }
        public static String GetDataDir_AsposePdfFacades_LinksActions()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Links-Actions/");
        }           
        public static String GetDataDir_AsposePdfFacades_Forms()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Forms/");
        }
        public static String GetDataDir_AsposePdfFacades_Images()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Images/");
        }        
        public static String GetDataDir_AsposePdfFacades_StampsWatermarks()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Stamps-Watermarks/");
        }
        public static String GetDataDir_AsposePdfFacades_Printing()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Printing/");
        }
        public static String GetDataDir_AsposePdfFacades_Text()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Text/");
        }
        public static String GetDataDir_AsposePdfFacades_WorkingDocuments()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Working-Document/");
        }
        public static String GetDataDir_AsposePdfFacades_Pages()
        {
            return Path.GetFullPath(GetDataDir_Data() + "AsposePdfFacades/Pages/");
        }        
        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }   
    }
}