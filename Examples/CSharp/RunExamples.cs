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
using Aspose.Pdf.Examples.CSharp.AsposePDF.Working_With_XML_XSLT;

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

            #region Annotations
            //// =====================================================   
            // AddAnnotation.Run();
            // AddlnkAnnotation.Run();
            // AddSwfFileAsAnnotation.Run();
            // DeleteAllAnnotationsFromPage.Run();
            // DeleteParticularAnnotation.Run();
            // ExtractHighlightedText.Run();
            // GetAllAnnotationsFromPage.Run();
            // GetParticularAnnotation.Run();
            // GetResourceOfAnnotation.Run();
            // InvisibleAnnotation.Run();
            // LnkAnnotationLineWidth.Run();
            // SetCalloutProperty.Run();
            // SetCalloutProperty.SetCalloutPropertyXFDF();
            // SetFreeTextAnnotationFormatting.Run();
            // StrikeOutWords.Run();
            #endregion

            #region Attachments
            //// Attachments
            //// =====================================================   
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Attachments.AddAttachment.Run();
            // DisableFilesCompression.Run();
            // GetAlltheAttachments.Run();
            // GetAttachmentInfo.Run();
            // GetIndividualAttachment.Run();
            #endregion

            #region Bookmarks
            //// =====================================================   
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.AddBookmark.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.AddChildBookmark.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.DeleteAllBookmarks.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Bookmarks.DeleteParticularBookmark.Run();
            // ExpandBookmarks.Run();
            // GetBookmarks.Run();
            // GetChildBookmarks.Run();
            // InheritZoom.Run();
            // UpdateBookmarks.Run();
            // UpdateChildBookmarks.Run();
            #endregion

            #region  Document Conversion
            // ===================================================== 
            // AddAttachmentToPDFA.Run();
            // CGMToPDF.Run();
            // EPUBToPDF.Run();
            // GetSVGDimensions.Run();
            // HTMLToPDF.RenderContentToSamePage();
            // HTMLToPDF.RenderHTMLwithSVGData();
            // HTMLToPDF.Run();
            // MarkdownToPDF.Run();
            // MHTToPDF.Run();
            // PageOrientationAccordingImageDimensions.Run();
            // PCLToPDF.PCLstream();
            // PCLToPDF.Run();
            // PDFAToPDF.Run();
            // PDFToDOC.Run();
            // PDFToEPUB.Run();
            // PDFToHTML.CreatingHtmlWithFullContentWidth();
            //PDFToHTML.CenterAlignText();
            // PDFToHTML.ExcludeFontResources();
            // PDFToHTML.LayersRendering();
            // PDFToHTML.Run();
            // PDFToPDFA.Run();
            // PDFToPDFA3b.Run();
            // PDFToPNGFontHinting.Run();
            // PDFToPPT.PDFtoPPTXWithSlidesAsImages();
            // PDFToPPT.Run();
            // PDFToSVG.Run();
            // PDFToTeX.Run();
            // PDFToXLS.PDFtoXLSX();
            // PDFToXLS.Run();
            // PDFToXML.Run();
            // PDFToXPS.Run();
            // PostscriptToPDF.Run();
            // RemoveHyperlinksAfterConvertingFromHtml.Run();
            // SetDefaultFontName.Run();
            // SVGToPDF.Run();
            // TextToPDF.Run();
            // TIFFtoPDFPerformanceImprovement.Run();
            // XMLToPDF.Run();
            // XMLToPDFSetImagePath.Run();
            #endregion

            #region Forms
            //// =====================================================   
            // AddTooltipToField.Run();
            // ArabicTextFilling.Run();
            // ComboBox.Run();
            // DeleteFormField.Run();  
            // DetermineRequiredField.Run();
            // DynamicXFAToAcroForm.Run();
            // FillFormField.Run();
            // FillXFAFields.Run();
            // FlattenForms.Run();
            // FormFieldFont14.Run();
            // GetFieldsFromRegion.Run();
            // GetValueFromField.Run();
            // GetValueFromField.Run(); 
            // GetXFAProperties.Run();
            // GroupedCheckBoxes.Run();
            // HorizontallyAndVerticallyRadioButtons.Run();
            // ModifyFormField.Run();   
            // MoveFormField.Run();
            // RadioButtonWithOptions.Run();
            // RetrieveFormFieldInTabOrder.Run();
            // SelectRadioButton.Run();
            // SetFieldLimit.Run();
            // SetJavaScript.Run();
            // SetRadioButtonCaption.Run();
            // TextBox.Run();
            #endregion

            #region Graphs
            //// =====================================================   
            // AddDrawing.Run();
            // AddDrawingWithGradientFill.Run();
            // AddLineObject.Run();
            // ControlRectangleZOrder.Run();
            // CreateFilledRectangle.Run();
            // CreateRectangleWithAlphaColor.Run();
            // DashLength.Run();
            // DrawingLine.Run();
            #endregion

            #region Headings
            //// =====================================================   
            // ApplyNumberStyle.Run();
            #endregion

            #region Images
            //// Images
            //// =====================================================   
            // AllPagesToTIFF.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Images.ExtractImages.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Images.ReplaceImage.Run();
            // AsposePDF.Images.AddImage.AddDicomImage();
            // BradleyAlgorithm.Run();
            // CGMImageToPDF.Run();
            // ConvertAllPagesToEMF.Run();
            // ConvertAllPagesToPNG.Run();
            // ConvertImageStreamtoPDF.Run();
            // ConvertPageRegionToDOM.Run();
            // ConvertToBMP.Run();
            // DeleteImages.Run();
            // FastShrinkImages.Run();
            // IdentifyImages.Run();
            // ImageToPDF.Run();
            // LargeCGMImageToPDF.Run();
            // PagesToImages.Run();
            // PageToEMF.Run();
            // PageToTIFF.Run();
            // ResizeImages.Run();
            // SetImageSize.Run();
            // ShrinkImages.Run();
            // StoreImageInXImageCollection.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Images.AddImage.Run();
            #endregion

            #region Links-Actions
            //// =====================================================   
            // AddHyperlink.Run();
            // CreateApplicationLink.Run();
            // CreateDocumentLink.Run();
            // CreateLocalHyperlink.Run();
            // ExtractLinks.Run();
            // GetHyperlinkDestinations.Run();
            // GetHyperlinkText.Run();
            // RemoveOpenAction.Run();
            // SetDestinationLink.Run();
            // SpecifyPageWhenViewing.Run();
            // UpdateLinks.Run();
            // UpdateLinkTextColor.Run();
            #endregion

            #region Miscellaneous
            //// =====================================================   
            // GetBuildInformation.Run();
            // UseMeasureWithLineAnnotation.Run();
            // UseMeasureWithPolylineAnnotation.Run();
            #endregion

            #region Operators
            //// =====================================================   
            // DrawXFormOnPage.Run();
            // PDFOperators.Run();
            // RemoveGraphicsObjects.Run();
            #endregion

            #region Pages
            //// Pages
            //// =====================================================   
            // ChangeOrientation.Run();
            // ConcatenatePdfFiles.Run();
            // DeleteParticularPage.Run();
            // DeterminePageColor.Run(); 
            // GetDimensions.Run();
            // GetNumberofPages.Run();
            // GetPageCount.Run();
            // GetParticularPage.Run();
            // GetProperties.Run();
            // ImageAsBackground.Run();
            // InsertEmptyPage.Run();
            // InsertEmptyPageAtEnd.Run();
            // SplitToPages.Run();
            // UpdateDimensions.Run();
            // ZoomToPageContents.Run();
            #endregion

            #region Security -Signatures
            //// =====================================================   
            // ChangePassword.Run();
            // Decrypt.Run();
            // DetermineCorrectPassword.Run();
            // Encrypt.Run();
            // ExtractingImage.Run();
            // IsPasswordProtected.Run();
            // SetPrivileges.Run();
            // SignWithSmartCardUsingPdfFileSignature.Run();
            // SignWithSmartCardUsingSignatureField.Run();
            #endregion

            #region Stamps-Watermarks
            //// Stamps-Watermarks
            //// =====================================================   
            // AddDateTimeStamp.Run();
            // AddImageStamp.AddImageStampAsBackgroundInFloatingBox();
            // AddImageStamp.Run();
            // AddingDifferentHeaders.Run();
            // AddPDFPageStamp.Run();
            // AddTextStamp.Run();
            // DefineAlignment.Run();
            // FillStrokeText.Run();
            // ImageandPageNumberinHeaderFootersection.Run();
            // ImageandPageNumberinHeaderFootersectionInline.Run();
            // ImageInFooter.Run();    
            // ImageinHeader.Run();
            // PageNumberinHeaderFooterUsingFloatingBox.Run();
            // PageNumberStamps.Run();
            // TableInHeaderFooterSection.Run();
            // TextinFooter.Run();
            // TextinHeader.Run();
            #endregion

            #region Tables
            //// =====================================================  
            // AddImageinATableCell.Run();
            // AddRepeatingColumn.Run();
            // AddSVGObject.Run();
            // AddTable.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Tables.IntegrateWithDatabase.Run();
            // AutoFitToWindow.Run();  
            // DetermineTableBreak.Run();
            // ExportExcelWorksheetDataToTable.Run();
            // ExtractBorder.Run();
            // GetTableWidth.Run();
            // HTMLTagsInsideTable.Run();
            // InsertPageBreak.Run();
            // MarginsOrPadding.Run();
            // RemoveMultipleTables.Run();
            // RemoveTable.Run();
            // RenderTable.Run();
            // ReplaceTable.Run();
            // SetBorder.Run();
            // TextAlignmentForTableRowContent.Run();
            #endregion

            #region TechnicalArticles
            //// =====================================================            
            // CreatePDFPortfolio.Run();
            // ExtractFilesFromPortfolio.Run();
            // RemoveFilesFromPortfolio.Run();
            #endregion

            #region Text
            //// Text
            //// =====================================================            
            // AddHTMLOrderedListIntoDocuments.Run();
            // AddHTMLUsingDOM.HTMLfragmentRectangle();
            // AddHTMLUsingDOM.Run();
            // AddHTMLUsingDOMAndOverwrite.Run();
            // AddSubsequentLinesIndent.Run();
            // AddTextBorder.Run();
            // AddTooltipToText.Run();
            // AddTransparentText.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Text.AddText.Run();
            // AsposePDF.Text.CustomTabStops.Run();
            // CreateMultiColumnPdf.Run();
            // EmbedStandardType1Fonts.Run();
            // ExtractColumnsText.Run();
            // ExtractParagraphs.Run();
            // ExtractParagraphsByDrawingBorder.Run();
            // ExtractTextUsingTextDevice.Run();
            // FootAndEndNotes.Run();
            // HiddenTextBlock.Run();
            // HighlightCharacterInPDF.Run();
            // PlacingTextAroundImage.Run();
            // RearrangeContentsUsingTextReplacement.Run();
            // RenderingReplaceableSymbols.Run();
            // ReplaceableSymbolsInHeaderFooter.Run();
            // ReplaceFirstOccurrence.Run();
            // ReplaceFonts.Run();
            // ReplaceTextAll.Run();
            // ReplaceTextonRegularExpression.Run();
            // SearchAndGetTextAll.Run();
            // SearchAndGetTextPage.Run();
            // SearchRegularExpression.Run();
            // SearchTextAndAddHyperlink.Run();
            // SearchTextAndDrawRectangle.Run();
            // SearchTextSegmentsPage.Run();
            // SearchTextWithDotNetRegex.Run();
            // SetHTMLStringFormatting.Run();
            // SpecifyCharacterSpacing.Run();
            // SpecifyLineSpacing.Run();
            // TextAndImageAsParagraph.Run();
            // UseLatexScript.Run();
            // UseLatexScript2.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.Text.ExtractTextPage.Run();

            #endregion

            #region Working-Document
            //// =====================================================   
            // AddJavaScriptToPage.Run();
            // AddLayers.Run();
            // AddRemoveJavascriptToDoc.Run();
            // AddTOC.Run();
            // AllowResusePageContent.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.EmbedFont.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetFileInfo.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetXMPMetadata.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.GetZoomFactor.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetFileInfo.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetXMPMetadata.Run();
            // Aspose.Pdf.Examples.CSharp.AsposePDF.WorkingDocuments.SetZoomFactor.Run();
            // ConvertFromRGBToGrayscale.Run();
            // CreateMultilayerPDFFirstApproach.Run();
            // CreateMultilayerPDFSecondApproach.Run();
            // CreatePDFA1WithAsposePdf.Run();
            // CreateThumbnailImages.Run();
            // EmbedFontsUsingSubsetStrategy.Run();
            // EmbedFontWhileDocCreation.Run();
            // FlattenAnnotation.Run();
            // GetAllFonts.Run();
            // GetDocumentWindow.Run();
            // GetWarningsForFontSubstitution.Run();
            // HelloWorldPDFUsingXmlAndXslt.Run();
            // HidePageNumbersInTOC.Run();
            // LinkDuplicateStreams.Run();
            // OptimizeDocument.Run();
            // OptimizeFileSize.Run();
            // RemoveUnusedObjects.Run();
            // RemoveUnusedStreams.Run();
            // SetDefaultFont.Run();
            // SetDocumentWindow.Run();
            // SetExpiryDate.Run();
            // SetPresetPropertiesForPrintDialog.Run();
            // SetPresetPropertiesForPrintDialog.SetPrintDlgPropertiesUsingPdfContentEditor();
            // ShrinkDocuments.Run();
            // TrimWhiteSpace.Run();
            // UnembedFonts.Run();
            // ValidatePDFAStandard.Run();
            // ValidatePDFUAstandard.Run();
            #endregion

            #region Working-with-Tagged PDFs
            //// ===================================================== 
            // AccessChildrenElements.Run();
            // AddStructureElementIntoElement.Run();
            // CreateNoteStructureElement.Run();
            // CreatePDFwithTaggedImage.Run();
            // CreatePDFwithTaggedText.Run();
            // CreateStructureElements.Run();
            // CreateStructureElementsTree.Run();
            // CreateTableElement.Run();
            // CustomTagName.Run();
            // IllustrationStructureElements.Run();
            // InlineStructureElements.Run();
            // LinkStructureElements.Run();
            // RootStructure.Run();
            // SetupLanguageAndTitle.Run();
            // StructureElementsProperties.Run();
            // StyleTableCell.Run()
            // StyleTableElement.Run();
            // StyleTableRow.Run();
            // StyleTextStructure.Run();
            // TaggedPDFContent.Run();
            // TagImageInExistingPDF.Run();
            // TextBlockStructureElements.Run();
            // TextStructureElements.Run();
            // ValidatePDF.Run();
            #endregion

            #region XML And XLST
            //// =====================================================   
            //BreakfastMenuUsingXmlAndXslt.Run();
            //HelloWorldPDFUsingXmlAndXslt.Run();
            #endregion

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