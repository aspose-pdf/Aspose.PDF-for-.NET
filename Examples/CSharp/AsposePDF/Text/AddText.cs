using System;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Text
{
    public class AddText
    {
        public static void Run()
        {
            // ExStart:AddText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            // Get particular page
            Page pdfPage = (Page)pdfDocument.Pages[1];

            // Create text fragment
            TextFragment textFragment = new TextFragment("main text");
            textFragment.Position = new Position(100, 600);

            // Set text properties
            textFragment.TextState.FontSize = 12;
            textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.LightGray);
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Red);

            // Create TextBuilder object
            TextBuilder textBuilder = new TextBuilder(pdfPage);

            // Append the text fragment to the PDF page
            textBuilder.AppendText(textFragment);
            
            dataDir = dataDir + "AddText_out.pdf";

            // Save resulting PDF document.
            pdfDocument.Save(dataDir);
            // ExEnd:AddText
            Console.WriteLine("\nText added successfully.\nFile saved at " + dataDir);

            AddUnderlineText();
            AddingBorderAroundAddedText();
            AddTextUsingTextParagraph();
            AddHyperlinkToTextSegment();
            OTFFont();
            AddStrikeOutText();
        }
        public static void AddUnderlineText()
        {
            // ExStart:AddUnderlineText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            // Create documentation object
            Document pdfDocument = new Document();
            // Add age page to PDF document
            pdfDocument.Pages.Add();
            // Create TextBuilder for first page
            TextBuilder tb = new TextBuilder(pdfDocument.Pages[1]);
            // TextFragment with sample text
            TextFragment fragment = new TextFragment("Test message");
            // Set the font for TextFragment
            fragment.TextState.Font = FontRepository.FindFont("Arial");
            fragment.TextState.FontSize = 10;
            // Set the formatting of text as Underline
            fragment.TextState.Underline = true;
            // Specify the position where TextFragment needs to be placed
            fragment.Position = new Position(10, 800);
            // Append TextFragment to PDF file
            tb.AppendText(fragment);

            dataDir = dataDir + "AddUnderlineText_out.pdf";

            // Save resulting PDF document.
            pdfDocument.Save(dataDir);
            // ExEnd:AddUnderlineText
            Console.WriteLine("\nUnderline text added successfully.\nFile saved at " + dataDir); 
        }
        public static void AddingBorderAroundAddedText()
        {
            // ExStart:AddingBorderAroundAddedText
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();

            PdfContentEditor editor = new PdfContentEditor();
            editor.BindPdf(dataDir + "input.pdf");
            LineInfo lineInfo = new LineInfo();
            lineInfo.LineWidth = 2;
            lineInfo.VerticeCoordinate = new float[] { 0, 0, 100, 100, 50, 100 };
            lineInfo.Visibility = true;
            editor.CreatePolygon(lineInfo, 1, new System.Drawing.Rectangle(0, 0, 0, 0), "");

            dataDir = dataDir + "AddingBorderAroundAddedText_out.pdf";

            // Save resulting PDF document.
            editor.Save(dataDir);
            // ExEnd:AddingBorderAroundAddedText
            Console.WriteLine("\nBorder around text added successfully.\nFile saved at " + dataDir);
        }
        public static void LoadingFontFromStream()
        {
            // ExStart:LoadingFontFromStream
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            string fontFile = "";

            // Load input PDF file
            Document doc = new Document( dataDir + "input.pdf");
            // Create text builder object for first page of document
            TextBuilder textBuilder = new TextBuilder(doc.Pages[1]);
            // Create text fragment with sample string
            TextFragment textFragment = new TextFragment("Hello world");

            if (fontFile != "")
            {
                // Load the TrueType font into stream object
                using (FileStream fontStream = File.OpenRead(fontFile))
                {
                    // Set the font name for text string
                    textFragment.TextState.Font = FontRepository.OpenFont(fontStream, FontTypes.TTF);
                    // Specify the position for Text Fragment
                    textFragment.Position = new Position(10, 10);
                    // Add the text to TextBuilder so that it can be placed over the PDF file
                    textBuilder.AppendText(textFragment);
                }

                dataDir = dataDir + "LoadingFontFromStream_out.pdf";

                // Save resulting PDF document.
                doc.Save(dataDir);
            }
            // ExEnd:LoadingFontFromStream
            Console.WriteLine("\nFont from stream loaded successfully.\nFile saved at " + dataDir);
        }
        public static void AddTextUsingTextParagraph()
        {
            // ExStart:AddTextUsingTextParagraph
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Open document
            Document doc = new Document();
            // Add page to pages collection of Document object
            Page page = doc.Pages.Add();
            TextBuilder builder = new TextBuilder(page);
            // Create text paragraph
            TextParagraph paragraph = new TextParagraph();
            // Set subsequent lines indent
            paragraph.SubsequentLinesIndent = 20;
            // Specify the location to add TextParagraph
            paragraph.Rectangle = new Aspose.Pdf.Rectangle(100, 300, 200, 700);
            // Specify word wraping mode
            paragraph.FormattingOptions.WrapMode = TextFormattingOptions.WordWrapMode.ByWords;
            // Create text fragment
            TextFragment fragment1 = new TextFragment("the quick brown fox jumps over the lazy dog");
            fragment1.TextState.Font = FontRepository.FindFont("Times New Roman");
            fragment1.TextState.FontSize = 12;
            // Add fragment to paragraph
            paragraph.AppendLine(fragment1);
            // Add paragraph
            builder.AppendParagraph(paragraph);

            dataDir = dataDir + "AddTextUsingTextParagraph_out.pdf";

            // Save resulting PDF document.
            doc.Save(dataDir);
            
            // ExEnd:AddTextUsingTextParagraph
            Console.WriteLine("\nText using text paragraph added successfully.\nFile saved at " + dataDir);
        }
        public static void AddHyperlinkToTextSegment()
        {
            // ExStart:AddHyperlinkToTextSegment
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create document instance
            Document doc = new Document();
            // Add page to pages collection of PDF file
            Page page1 = doc.Pages.Add();
            // Create TextFragment instance
            TextFragment tf = new TextFragment("Sample Text Fragment");
            // Set horizontal alignment for TextFragment
            tf.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Right;
            // Create a textsegment with sample text
            TextSegment segment = new TextSegment(" ... Text Segment 1...");
            // Add segment to segments collection of TextFragment
            tf.Segments.Add(segment);
            // Create a new TextSegment 
            segment = new TextSegment("Link to Google");
            // Add segment to segments collection of TextFragment
            tf.Segments.Add(segment);
            // Set hyperlink for TextSegment
            segment.Hyperlink = new Aspose.Pdf.WebHyperlink("www.google.com");
            // Set forground color for text segment
            segment.TextState.ForegroundColor = Aspose.Pdf.Color.Blue;
            // Set text formatting as italic
            segment.TextState.FontStyle = FontStyles.Italic;
            // Create another TextSegment object
            segment = new TextSegment("TextSegment without hyperlink");
            // Add segment to segments collection of TextFragment
            tf.Segments.Add(segment);
            // Add TextFragment to paragraphs collection of page object
            page1.Paragraphs.Add(tf);

            dataDir = dataDir + "AddHyperlinkToTextSegment_out.pdf";

            // Save resulting PDF document.
            doc.Save(dataDir);

            // ExEnd:AddHyperlinkToTextSegment
            Console.WriteLine("\nHyperlink to text segment added successfully.\nFile saved at " + dataDir);
        }

        public static void OTFFont()
        {
            // ExStart:OTFFont
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
            // Create new document instance
            Document pdfDocument = new Document();
            // Add page to pages collection of PDF file
            Aspose.Pdf.Page page = pdfDocument.Pages.Add();
            // Create TextFragment instnace with sample text
            TextFragment fragment = new TextFragment("Sample Text in OTF font");
            // Find font inside system font directory
            // Fragment.TextState.Font = FontRepository.FindFont("HelveticaNeueLT Pro 45 Lt");
            // Or you can even specify the path of OTF font in system directory
            fragment.TextState.Font = FontRepository.OpenFont(dataDir + "space age.otf");
            // Specify to emend font inside PDF file, so that its displayed properly,
            // Even if specific font is not installed/present over target machine
            fragment.TextState.Font.IsEmbedded = true;
            // Add TextFragment to paragraphs collection of Page instance
            page.Paragraphs.Add(fragment);

            dataDir = dataDir + "OTFFont_out.pdf";

            // Save resulting PDF document.
            pdfDocument.Save(dataDir);

            // ExEnd:OTFFont
            Console.WriteLine("\nOTF font used successfully.\nFile saved at " + dataDir);
        }

        public static void AddNewLineFeed()
        {
            try
            {
                // ExStart:AddNewLineFeed
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
                Aspose.Pdf.Document pdfApplicationDoc = new Aspose.Pdf.Document();
                Aspose.Pdf.Page applicationFirstPage = (Aspose.Pdf.Page)pdfApplicationDoc.Pages.Add();

                // Initialize new TextFragment with text containing required newline markers
                Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment("Applicant Name: " + Environment.NewLine + " Joe Smoe");

                // Set text fragment properties if necessary
                textFragment.TextState.FontSize = 12;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman");
                textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Red;

                // Create TextParagraph object
                TextParagraph par = new TextParagraph();

                // Add new TextFragment to paragraph
                par.AppendLine(textFragment);

                // Set paragraph position
                par.Position = new Aspose.Pdf.Text.Position(100, 600);

                // Create TextBuilder object
                TextBuilder textBuilder = new TextBuilder(applicationFirstPage);
                // Add the TextParagraph using TextBuilder
                textBuilder.AppendParagraph(par);


                dataDir = dataDir + "AddNewLineFeed_out.pdf";

                // Save resulting PDF document.
                pdfApplicationDoc.Save(dataDir);
                // ExEnd:AddNewLineFeed
                Console.WriteLine("\nNew line feed added successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddStrikeOutText()
        {
            try
            {
                // ExStart:AddStrikeOutText
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_Text();
                // Open document
                Document pdfDocument = new Document();
                // Get particular page
                Page pdfPage = (Page)pdfDocument.Pages.Add();

                // Create text fragment
                TextFragment textFragment = new TextFragment("main text");
                textFragment.Position = new Position(100, 600);

                // Set text properties
                textFragment.TextState.FontSize = 12;
                textFragment.TextState.Font = FontRepository.FindFont("TimesNewRoman");
                textFragment.TextState.BackgroundColor = Aspose.Pdf.Color.LightGray;
                textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.Red;
                // Set StrikeOut property
                textFragment.TextState.StrikeOut = true;
                // Mark text as Bold
                textFragment.TextState.FontStyle = FontStyles.Bold;

                // Create TextBuilder object
                TextBuilder textBuilder = new TextBuilder(pdfPage);
                // Append the text fragment to the PDF page
                textBuilder.AppendText(textFragment);


                dataDir = dataDir + "AddStrikeOutText_out.pdf";

                // Save resulting PDF document.
                pdfDocument.Save(dataDir);
                // ExEnd:AddStrikeOutText
                Console.WriteLine("\nStrikeOut text added successfully.\nFile saved at " + dataDir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}