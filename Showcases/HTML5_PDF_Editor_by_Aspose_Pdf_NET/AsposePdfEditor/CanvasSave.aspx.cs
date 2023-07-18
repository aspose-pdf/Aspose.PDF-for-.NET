using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System.Drawing;
using Aspose.Pdf.Text;
using System.Net;
using Aspose.Pdf.Forms;

namespace AsposePdfEditor
{
    [ScriptService]
    public partial class CanvasSave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        public override void ProcessRequest(HttpContext context)
        {
            try
            {
                var path = context.Request.QueryString["Download"];
                if (path != null)
                {
                    context.Response.AddHeader("Content-disposition", "attachment; filename=" + path.Split('/')[1]);
                    context.Response.ContentType = "application/octet-stream";
                    context.Response.TransmitFile(Server.MapPath(path));
                    context.Response.End();
                }

                else
                {
                    //Capture File From Post
                    HttpPostedFile file = context.Request.Files["fileToUpload"];

                    if (context.Request.Form["Opp"] == "uploading")
                    {
                        //Or just save it locally
                        file.SaveAs(Server.MapPath("Convert/input.pdf"));

                        file.SaveAs(Server.MapPath("Convert/output.pdf"));

                        Startup();

                        context.Response.Write(ImageConverter());
                    }
                    else if (context.Request.Form["Opp"] == "appending")
                    {
                        string appPages = context.Request.Form["pages"];
                        string appRatios = context.Request.Form["ratios"];
                        string appHeights = context.Request.Form["heights"];

                        //Or just save it locally
                        file.SaveAs(Server.MapPath("Convert/append.pdf"));

                        context.Response.Write(AppendConverter(appPages, appRatios, appHeights));
                    }
                    else if (context.Request.Form["Opp"] == "addAttachment")
                    {

                        //Or just save it locally
                        if (file != null)
                        {
                            file.SaveAs(Server.MapPath("Attachments/" + file.FileName));
                            AddAttachments(Server.MapPath("Attachments/" + file.FileName), file.FileName);

                            context.Response.Write(file.FileName);
                        }
                    }
                    else
                    {

                        //Or just save it locally
                        file.SaveAs(Server.MapPath("Images/" + file.FileName));

                        context.Response.Write(file.FileName);
                    }
                }
            }
            catch (IndexOutOfRangeException exception)
            {

                if (exception.Message.Contains("evaluation"))
                {
                    context.Response.Write("Aspose.Pdf Evaluation version limitation. Only 4 elements of any collection are allowed. Please get a free temporary license to test the HTML5 PDF Editor without any limitations from http://www.aspose.com/corporate/purchase/temporary-license.aspx");
                }
                else
                {
                    context.Response.Write("An exception occurred during processing of your document. Please contact Aspose Support.");
                }

            }
            catch (Exception exp)
            {

                context.Response.Write("An exception occurred during processing of your document. Please contact Aspose Support.");
            }
        }


        [WebMethod()]
        public static string Download_Dropbox(string file_url, string process)
        {
            try
            {
                // Create a new WebClient instance.
                using (WebClient myWebClient = new WebClient())
                {
                    if (process == "upload")
                    {

                        // myStringWebResource = remoteUri + fileName;
                        // Download the Web resource and save it into the current filesystem folder.
                        myWebClient.DownloadFile(file_url, HttpContext.Current.Server.MapPath("Convert/input.pdf"));
                        myWebClient.DownloadFile(file_url, HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                        return ImageConverter();
                    }
                    else
                    {
                        string[] filename = file_url.Split('/');
                        string name = filename[filename.Length - 1];

                        // Download the Web resource and save it into the current filesystem folder.
                        myWebClient.DownloadFile(file_url, HttpContext.Current.Server.MapPath("Images/"+name));

                        return name;
                    }
                }
            }
            catch (Exception Exp)
            {
                return Exp.Message;
            }
        }

        [WebMethod()]
        public static string AddPage_Click(string lastpage)
        {
            try
            {
                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                //insert an empty page at the end of a PDF file
                doc.Pages.Add();

                doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                string height = "";

                int counter = GetHighestPage();
                counter = counter + 1;

                using (FileStream imageStream = new FileStream(HttpContext.Current.Server.MapPath("Input/image-1" + counter + ".png"), FileMode.Create))
                {
                    //Create Resolution object
                    Resolution resolution = new Resolution(300);
                    //create PNG device with specified attributes
                    PngDevice pngDevice = new PngDevice(resolution);
                    //Convert a particular page and save the image to stream
                    pngDevice.Process(doc.Pages[doc.Pages.Count], imageStream);
                    //Close stream
                    imageStream.Close();
                }
                string Aratio = "";
                System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("Input/image-1" + counter + ".png"));
                ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath("Input/image" + counter + ".png"), out height, out Aratio);
                image.Dispose();
                return "image" + counter + ".png";
            }
            catch (Exception Exp)
            {
                return Exp.Message;
            }
        }

       

        [WebMethod()]
        protected static void ScaleImage(System.Drawing.Image image, int maxWidth, int maxHeight, string path, out string height,out string Aratio)
        {
            var ratio = (double)maxWidth / image.Width;
            Aratio = ratio.ToString();
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            height = newHeight.ToString();
            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            Bitmap bmp = new Bitmap(newImage);
            bmp.Save(path);

        }


        [WebMethod()]
        public static void DeletePage_Click(string imageData, string imageName)
        {
            try
            {
                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                doc.Pages.Delete(Convert.ToInt32(imageData));

                doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                System.IO.File.Delete(HttpContext.Current.Server.MapPath("Input/" +imageName));
            }
            catch (Exception Exp)
            {
               // return Exp.Message;
            }
            
        }

        [WebMethod()]
        public static string[] MovePages(string moveFrom, string moveTo, string[] pageList)
        {
            try
            {
                int pageFrom = Convert.ToInt32(moveFrom);
                int pageTo = Convert.ToInt32(moveTo);
                List<string> str = pageList.ToList();

                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                Aspose.Pdf.Page page = doc.Pages[pageFrom];

                //insert an empty page at the end of a PDF file
                doc.Pages.Insert(pageTo + 1, page);

                if (pageFrom > pageTo)
                {
                    doc.Pages.Delete(pageFrom+1);
                    str.Insert(pageTo, pageList[pageFrom - 1]);
                    str.RemoveAt(pageFrom);
                }
                else
                {
                    doc.Pages.Delete(pageFrom);                    
                    str.Insert(pageTo, pageList[pageFrom - 1]);
                    str.RemoveAt(pageFrom-1);
                }

                doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                pageList = str.ToArray();

                
                                
            }
            catch (Exception Exp)
            {
                // return Exp.Message;
            }

            return pageList;

        }


        [WebMethod()]
        public static void UploadPic(List<shap> shapes , string filename, string aspectRatio)
        {
          
                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                //Create image stamp
                ImageStamp imageStamp = new ImageStamp(HttpContext.Current.Server.MapPath("test.png"));

                for (int i = 0; i < shapes.Count; i++)
                {
                    //create stamp
                    Aspose.Pdf.Facades.Stamp stamp = new Aspose.Pdf.Facades.Stamp();

                    float shapeX = (shapes[i].x * 72 / 150) / (float)Convert.ToDouble(shapes[i].ratio);
                    float shapeY = (shapes[i].y * 72 / 150) / (float)Convert.ToDouble(shapes[i].ratio);
                    float shapeW = (shapes[i].w * 72 / 150) / (float)Convert.ToDouble(shapes[i].ratio);
                    float shapeH = (shapes[i].h * 72 / 150) / (float)Convert.ToDouble(shapes[i].ratio);
                                                            
                    double yaxis = (float)(doc.Pages[shapes[i].p].Rect.URY - (shapeH + shapeY));

                    var isSpecial = true;//regexItem.IsMatch(shapes[i].imName);

                    if (shapes[i].Itype == "highlight" || shapes[i].Itype == "image")
                    {

                        imageStamp = shapes[i].Itype == "highlight" 
                            ? new ImageStamp(HttpContext.Current.Server.MapPath("test.png")) 
                            : new ImageStamp(HttpContext.Current.Server.MapPath("Images/"+shapes[i].imName));
                                                
                        imageStamp.Background = false;
                        imageStamp.XIndent = (float)(shapeX);
                        imageStamp.YIndent = (float)(yaxis);
                        imageStamp.Height = shapeH;
                        imageStamp.Width = shapeW;
                        
                        //Add stamp to particular page
                        doc.Pages[shapes[i].p].AddStamp(imageStamp);
                    }                   
                    else if(shapes[i].Itype == "text")
                    {

                        /*
                        // create TextBuilder for first page
                        TextBuilder tb = new TextBuilder(doc.Pages[shapes[i].p]);

                        // TextFragment with sample text
                        TextFragment fragment = new TextFragment(shapes[i].t);

                        // set the font for TextFragment
                        fragment.TextState.Font = FontRepository.FindFont(shapes[i].n);
                        fragment.TextState.FontSize = Convert.ToInt32(shapes[i].s);
                        if (shapes[i].wt == "bold")
                        {
                            fragment.TextState.FontStyle = FontStyles.Bold;
                        }

                        if (shapes[i].st == "italic")
                        {
                            fragment.TextState.FontStyle = FontStyles.Italic;
                        }

                        // set the formatting of text as Underline
                        // fragment.TextState.Underline = true;
                        fragment.TextState.ForegroundColor = GetColor(shapes[i].c);
                        // specify the position where TextFragment needs to be placed
                        fragment.Position = new Position((float)(shapeX), (float)(yaxis));

                       // fragment.Rectangle.Rotate((360 - (Convert.ToDouble(shapes[i].fieldType)) * 180 / Math.PI);

                        // append TextFragment to PDF file
                        tb.AppendText(fragment);
                        */
                        
                        //create text stamp
                        TextStamp textStamp = new TextStamp(shapes[i].t);
                        //set whether stamp is background
                       // textStamp.Background = true;
                        //set origin
                        textStamp.XIndent = (float)(shapeX); 
                        textStamp.YIndent = (float)(yaxis);
                        //rotate stamp
                        textStamp.RotateAngle = 360 - ((Convert.ToDouble(shapes[i].fieldType)) * 180 / Math.PI);
                        
                        //set text properties
                        textStamp.TextState.Font = FontRepository.FindFont(shapes[i].n);
                        textStamp.TextState.FontSize = Convert.ToInt32(shapes[i].s) * 0.75f;

                        if (shapes[i].wt == "bold")
                        {
                            textStamp.TextState.FontStyle = FontStyles.Bold;
                        }

                        if (shapes[i].st == "italic")
                        {
                            textStamp.TextState.FontStyle = FontStyles.Italic;
                        }
                        
                       
                        textStamp.TextState.ForegroundColor = GetColor(shapes[i].c);
                        //add stamp to particular page
                        doc.Pages[shapes[i].p].AddStamp(textStamp);

                    }
                    else if (shapes[i].Itype == "field" && isSpecial)
                    {
                        if (shapes[i].fieldType == "Text")
                        {
                            // Get a field
                            TextBoxField textBoxField = doc.Form.Fields[Convert.ToInt32(shapes[i].imName)] as TextBoxField;
                            // Modify field value
                            textBoxField.Value = shapes[i].t;
                        
                        }
                        else if (shapes[i].fieldType == "CheckBox")
                        {

                            // Get a field
                            CheckboxField checkBoxField = doc.Form.Fields[Convert.ToInt32(shapes[i].imName)] as CheckboxField;
                            if(shapes[i].t != "")
                            // Modify field value
                            checkBoxField.Checked = Convert.ToBoolean(shapes[i].t);
                        }
                        else if (shapes[i].fieldType == "Radio")
                        {
                            RadioButtonOptionField field = (RadioButtonOptionField)doc.Form.Fields[Convert.ToInt32(shapes[i].imName)];

                            RadioButtonField rbf = (RadioButtonField)field.Parent;
                            if (Convert.ToBoolean(shapes[i].t))
                            {
                                rbf.Selected = rbf.Options[field.OptionName].Index;

                            }
                            else
                            {
                                field.ActiveState = "Off";

                            }
                        }
                        else if (shapes[i].fieldType == "ComboBox")
                        {                            

                            // Get a field
                            ComboBoxField comboBoxField = doc.Form.Fields[Convert.ToInt32(shapes[i].imName)] as ComboBoxField;
                            var values = shapes[i].t.Split(new[]{"^^^"},StringSplitOptions.None)[0];

                            foreach (var item in comboBoxField.Options.Cast<Option>())
                            {
                                if (item.Value == values)
                                {

                                    comboBoxField.Selected = item.Index;
                                }
                            }
                        }
                    }

                }
            
                doc.Save(HttpContext.Current.Server.MapPath("Convert/Export.pdf"));
            
           
        }

        [WebMethod]
        public static string CreateNewFile()
        {
            Startup();

            Document doc = new Document();
            doc.Pages.Add();
            doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));


            return ImageConverter();
        }
        [WebMethod]
        public static string ImageConverter()
        {
                          
                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));
                
                
                string Aratio = "";
                string pages = "";
                string Ratios = "";
                string height = "";
                string Allheights = "";
                string fields = "";
                int TotalPages = 0;
                bool licensed = CheckLicense();

                if (licensed || doc.Pages.Count <= 4)
                    TotalPages = doc.Pages.Count;
                else
                    TotalPages = 4;

                for (int pageCount = 1; pageCount <= TotalPages; pageCount++)
                {
                    using (FileStream imageStream = new FileStream(HttpContext.Current.Server.MapPath("Input/image-1" + pageCount + ".png"), FileMode.Create))
                    {
                        //Create Resolution object
                       // Resolution resolution = new Resolution(150);
                        //create PNG device with specified attributes
                        PngDevice pngDevice = new PngDevice();
                        //Convert a particular page and save the image to stream
                        pngDevice.Process(doc.Pages[pageCount], imageStream);
                        //Close stream
                        imageStream.Close();

                        System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("Input/image-1" + pageCount + ".png"));



                        ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath("Input/image" + pageCount + ".png"), out height, out Aratio);

                        image.Dispose();

                        if(pageCount == 1)
                        fields = CheckFields(doc, pageCount, "image" + pageCount + ".png", fields, Convert.ToDouble(Aratio), licensed);

                        pages = pages + "," + "image" + pageCount + ".png";
                        Ratios = Ratios + "," + Aratio;
                        Allheights = Allheights + "," + height;
                        
                    }

                }

                Ratios = Ratios.Substring(1, Ratios.Length - 1);
                pages = pages.Substring(1, pages.Length -1);
                Allheights = Allheights.Substring(1, Allheights.Length -1);
                if (fields != "")
                {
                    fields = fields.Substring(3, fields.Length - 3);
                }
                return pages + "%#" + Ratios + "%#" + Allheights + "%#" + fields;
           
        }

        private static string CheckFields(Document doc, int pageCount, string filename, string fields, double ratio, bool licensed)
        {
            double marginLeft = doc.Pages[pageCount].PageInfo.Margin.Left;
            double marginTop = doc.Pages[pageCount].PageInfo.Margin.Top;
                       
            int fieldcounter = 0;
            
            Aspose.Pdf.Facades.Form pdfForm = new Aspose.Pdf.Facades.Form(doc);

            // Get values from all fields
            foreach (Field formField in doc.Form.Fields)
            {
                    

                    double lowerLeftY = (doc.Pages[pageCount].Rect.Height) - (formField.Rect.ToRect().Y + formField.Height);

                    double lowerLeftX = formField.Rect.ToRect().X;
                    var fieldType = formField.GetType().Name; //pdfForm.GetFieldType(formField.FullName);
                    var imValue = "";

                    if (fieldType.ToString() == "CheckboxField" || fieldType.ToString() == "ComboBoxField" || fieldType.ToString() == "RadioButtonOptionField" || fieldType.ToString() == "TextBoxField")
                    {
                        var value = formField.Value;

                        if (fieldType.ToString() == "TextBoxField")
                        {
                            fieldType = "Text";
                        }
                        if (fieldType.ToString() == "CheckboxField")
                        {
                            CheckboxField field = (CheckboxField)formField;
                            if (field.Parent != null) 
                            imValue = field.Parent.FullName;
                            fieldType = "CheckBox";
                            if (field.Checked)
                            {
                                value = "true";
                            }
                            else
                            {
                                value = "false";
                            }
                        }
                        if (fieldType.ToString() == "RadioButtonOptionField")
                        {
                            RadioButtonOptionField field = (RadioButtonOptionField)formField;
                            RadioButtonField rbf = (RadioButtonField)field.Parent;

                            fieldType = "Radio";
                            if (field.Parent != null)
                                imValue = field.Parent.FullName;
                            if ((rbf.Options[field.OptionName].Index == rbf.Selected))
                            {
                                value = "true";
                            }
                            else
                            {
                                value = "false";
                            }
                        }
                        if (fieldType.ToString() == "ComboBoxField")
                        {
                            ComboBoxField field = (ComboBoxField)formField;
                            string optValues = value;
                            fieldType = "ComboBox";
                            foreach (Option opt in field.Options)
                            {

                                optValues = optValues + "^^^" + opt.Value;

                            }
                            value = optValues;


                        }

                        bool isRequired = pdfForm.IsRequiredField(formField.FullName);
                        //fields += "$#$" + (lowerLeftX * 2.08) * ratio + "$#$" + (lowerLeftY * 2.08) * ratio + "$#$" + (formField.Width * 2.08) * ratio + "$#$" + (formField.Height * 2.08) * ratio + "$#$" + formField.PageIndex + "$#$" + "image" + formField.PageIndex + ".png" + "$#$" + value + "$#$" + formField.DefaultAppearance.FontName + "$#$" + formField.DefaultAppearance.FontSize + "$#$" + " " + "$#$" + " " + "$#$" + " " + "$#$" + ratio + "$#$" + " " + "$#$" + formField.FullName.Replace('/', '-') + "$#$" + fieldType;
                        fields += "$#$" + (lowerLeftX * 2.08) * ratio + "$#$" + (lowerLeftY * 2.08) * ratio + "$#$" + (formField.Width * 2.08) * ratio + "$#$" + (formField.Height * 2.08) * ratio + "$#$" + formField.PageIndex + "$#$" + "image" + formField.PageIndex + ".png" + "$#$" + value + "$#$" + formField.DefaultAppearance.FontName + "$#$" + formField.DefaultAppearance.FontSize + "$#$" + " " + "$#$" + " " + "$#$" + isRequired + "$#$" + ratio + "$#$" + imValue + "$#$" + fieldcounter + "$#$" + fieldType;
                    }
                    int length = fields.Length;
                    fieldcounter += 1;
                    if (!licensed && fieldcounter == 5)
                    {
                        break;
                    }
            }

            

            return fields;

        }

        [WebMethod]
        public static string AppendConverter(string appPages, string appRatios, string appHeights)
        {
           
                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));
                int totalCount = doc.Pages.Count;

                //open second document
                Document pdfDocument2 = new Document(HttpContext.Current.Server.MapPath("Convert/append.pdf"));

                //add pages of second document to the first
                doc.Pages.Add(pdfDocument2.Pages);
                               

                //save concatenated output file
                doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                string Aratio = "";
                string pages = "";
                string height = "";
                string Allheights = "";

                for (int pageCount = 1; pageCount <= doc.Pages.Count; pageCount++)
                {
                    if (pageCount > totalCount)
                    {
                        using (FileStream imageStream = new FileStream(HttpContext.Current.Server.MapPath("Input/image-1" + pageCount + ".png"), FileMode.Create))
                        {
                            //Create Resolution object
                            //Resolution resolution = new Resolution(300);
                            //create PNG device with specified attributes
                            PngDevice pngDevice = new PngDevice();
                            //Convert a particular page and save the image to stream
                            pngDevice.Process(doc.Pages[pageCount], imageStream);
                            //Close stream
                            imageStream.Close();

                            System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("Input/image-1" + pageCount + ".png"));



                            ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath("Input/image" + pageCount + ".png"), out height, out Aratio);

                            image.Dispose();

                            appPages = appPages + "," + "image" + pageCount + ".png";

                            appRatios = appRatios + "," + Aratio;

                            appHeights = appHeights + "," + height;
                        }
                    }                   

                }


                return appPages + "%#" + appRatios + "%#" + appHeights;
           
        }

        [WebMethod]
        public static string btnTextExport_Click(string fileType)
        {
          Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/Export.pdf"));

                switch (fileType)
                {
                    case "txt":

                        //create TextAbsorber object to extract text
                        TextAbsorber textAbsorber = new TextAbsorber();

                        //accept the absorber for all the pages
                        doc.Pages.Accept(textAbsorber);

                        //get the extracted text
                        string extractedText = textAbsorber.Text;

                        File.WriteAllText(HttpContext.Current.Server.MapPath("Convert/output.txt"), extractedText);
                        return "output.txt";
                    case "pdf":
                        return "Export.pdf";
                    case "docx":
                        doc.Save(HttpContext.Current.Server.MapPath("Convert/output.docx"), SaveFormat.DocX);
                        return "output.docx";
                    case "svg":
                        doc.Save(HttpContext.Current.Server.MapPath("Convert/output.svg"), SaveFormat.Svg);
                        return "output.svg";
                    case "xps":
                        doc.Save(HttpContext.Current.Server.MapPath("Convert/output.xps"), SaveFormat.Xps);
                        return "output.xps";
                    case "xls":
                        doc.Save(HttpContext.Current.Server.MapPath("Convert/output.xls"), SaveFormat.Excel);
                        return "output.xls";
                    case "html":
                        doc.Save(HttpContext.Current.Server.MapPath("Convert/output.html"), SaveFormat.Html);
                        return "output.html";
                    default:
                        return "";
                }
           

        }
             

        public static int GetHighestPage()
        {
            string[] files = Directory.GetFiles(HttpContext.Current.Server.MapPath("Input/"));
            int[] highPage = new int[files.Length];
            for (int i = 0; i < files.Length; i++)
                highPage[i] = Convert.ToInt32(Path.GetFileName(files[i]).Replace("image", "").Replace(".png", ""));


            return highPage.Max();
        }

        [WebMethod()]
        public static string SearchData(string searchText, string[] pageList)
        {
            string name = DateTime.Now.Millisecond.ToString();
            var downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("search/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }

            Directory.CreateDirectory(HttpContext.Current.Server.MapPath("search/" + name));

            Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                

                for (int i = 1; i <= doc.Pages.Count; i++)
                {
                    string filename = "Input/" + pageList[i-1];
                    filename = filename.Replace("image", "image-1");
                    Bitmap bmp = (Bitmap)Bitmap.FromFile(HttpContext.Current.Server.MapPath(filename));
                    using (System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp))
                    {
                        float scale = 150 / 72f;
                        gr.Transform = new System.Drawing.Drawing2D.Matrix(scale, 0, 0, -scale, 0, bmp.Height);


                        Aspose.Pdf.Page page = doc.Pages[i];
                        //create TextAbsorber object to find all words
                        TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber(searchText);
                        //   textFragmentAbsorber.TextSearchOptions.IsRegularExpressionUsed = true;
                        page.Accept(textFragmentAbsorber);
                        //get the extracted text fragments
                        TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

                        Brush brush = new SolidBrush(System.Drawing.Color.FromArgb(50, 255, 255, 0));
                        //loop through the fragments
                        foreach (TextFragment textFragment in textFragmentCollection)
                        {
                            //  if (i == 0)
                            {
                                gr.FillRectangle(
                                    //   gr.DrawRectangle(
                                brush,
                                (float)(textFragment.Position.XIndent),
                                (float)(textFragment.Position.YIndent),
                                (float)(textFragment.Rectangle.Width),
                                (float)(textFragment.Rectangle.Height));

                                for (int segNum = 1; segNum <= textFragment.Segments.Count; segNum++)
                                {
                                    TextSegment segment = textFragment.Segments[segNum];


                                    gr.DrawRectangle(
                                    Pens.Green,
                                    (float)segment.Rectangle.LLX,
                                    (float)segment.Rectangle.LLY,
                                    (float)segment.Rectangle.Width,
                                    (float)segment.Rectangle.Height);
                                }
                            }
                        }
                        gr.Dispose();
                    }

                    bmp.Save(HttpContext.Current.Server.MapPath(filename.Replace("image-1","image_search")), System.Drawing.Imaging.ImageFormat.Png);
                    bmp.Dispose();
                   
                    string height = "";
                    string Aratio = "";
                    System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath(filename.Replace("image-1", "image_search")));
                    ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath("search/" + name + "/" + pageList[i - 1]), out height, out Aratio);
                    image.Dispose();

                  //  System.IO.File.Copy(HttpContext.Current.Server.MapPath("Input/image_search" + i + ".png"), HttpContext.Current.Server.MapPath("Input/image" + i + ".png"));


                }

                return name;
        }

        public static string AddAttachments(string path, string filename)
        {
            // Open document
            using (Document pdfDocument = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf")))
            {
                // Setup new file to be added as attachment
                FileSpecification fileSpecification = new FileSpecification(path, filename);
                // Add attachment to document's attachment collection
                pdfDocument.EmbeddedFiles.Add(fileSpecification);
                // Save new output
                pdfDocument.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));
            }
            return "success";
        }

        [WebMethod()]
        public static string GetFileAttachments()
        {
            string outAttach = "";

            // Open document
            using (Document pdfDocument = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf")))
            {

                // Get embedded files collection
                EmbeddedFileCollection embeddedFiles = pdfDocument.EmbeddedFiles;

                // Loop through the collection to get all the attachments
                foreach (FileSpecification fileSpecification in embeddedFiles)
                {
                    string[] filename = fileSpecification.Name.Split('\\');

                    outAttach = outAttach + "," + filename[filename.Length - 1] + "," + fileSpecification.Description;

                    // Get the attachment and write to file or stream
                    byte[] fileContent = new byte[fileSpecification.Contents.Length];
                    fileSpecification.Contents.Read(fileContent, 0, fileContent.Length);
                    FileStream fileStream = new FileStream(HttpContext.Current.Server.MapPath("Attachments/" + filename[filename.Length - 1]), FileMode.Create);
                    fileStream.Write(fileContent, 0, fileContent.Length);
                    fileStream.Close();
                }
                if (outAttach.Length > 1)
                {

                    outAttach = outAttach.Substring(1);
                }
            }
                return outAttach;
        }

        [WebMethod()]
        public static string RemoveAttachments(string name)
        {

            // Open document
            using (Document pdfDocument = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf")))
            {

                // Delete all attachments
                pdfDocument.EmbeddedFiles.Delete(name);

                // Save updated file
                pdfDocument.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

            }
            return "success";
        }

        [WebMethod()]
        public static bool CheckLicense()
        {

            Document pdfDocument = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

            // Create TextAbsorber object to extract text
            TextAbsorber textAbsorber = new TextAbsorber();
            
            // Accept the absorber for all the pages
            pdfDocument.Pages[1].Accept(textAbsorber);
            
            // Get the extracted text
            String extractedText = textAbsorber.Text;
            
            return !extractedText.Contains("Evaluation Only. Created with Aspose.Pdf");
        }
        [WebMethod]
        public static string CreateSignature(string imageData)
        {

            var downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Images/Signature/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            Random random = new Random();
            int rand =  random.Next(1000000);
            string fileNameWitPath = HttpContext.Current.Server.MapPath("Images/Signature/sign"+rand+".png");
            using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    byte[] data = Convert.FromBase64String(imageData);
                    bw.Write(data);
                    bw.Close();
                }
            }

            return "Signature/sign" + rand + ".png";
        }
        [WebMethod()]
        public static string ReplaceText(string txtFind, string txtReplace, string[] pageList)
        {
            try
            {
                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                //create TextAbsorber object to find all instances of the input search phrase
                TextFragmentAbsorber textFragmentAbsorber =
                    new TextFragmentAbsorber("(?i)" + txtFind, new TextSearchOptions(true))
                    {
                        TextReplaceOptions =
                        {
                            ReplaceAdjustmentAction = TextReplaceOptions.ReplaceAdjustment.WholeWordsHyphenation
                        }
                    };


                //accept the absorber for all the pages
                doc.Pages.Accept(textFragmentAbsorber);

                //get the extracted text fragments
                TextFragmentCollection textFragmentCollection = textFragmentAbsorber.TextFragments;

                //loop through the fragments
                foreach (TextFragment textFragment in textFragmentCollection)
                {
                    //update text and other properties
                    textFragment.Text = txtReplace;
                }

                doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                var downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Input/"));

                foreach (FileInfo file in downloadedMessageInfo.GetFiles())
                {
                    file.Delete();
                }


                for (int pageCount = 1; pageCount <= doc.Pages.Count; pageCount++)
                {
                    string filename = "Input/" + pageList[pageCount - 1];
                    filename = filename.Replace("image", "image-1");

                    using (FileStream imageStream = new FileStream(HttpContext.Current.Server.MapPath(filename), FileMode.Create))
                    {
                        //Create Resolution object
                        Resolution resolution = new Resolution(300);
                        //create PNG device with specified attributes
                        PngDevice pngDevice = new PngDevice();
                        //Convert a particular page and save the image to stream
                        pngDevice.Process(doc.Pages[pageCount], imageStream);
                        //Close stream
                        imageStream.Close();

                        System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath(filename));

                        string height = "";
                        string Aratio = "";

                        ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath(filename.Replace("image-1", "image")), out height, out Aratio);

                        image.Dispose();

                    }

                }
            }
            catch (Exception exp)
            { 
                
            }
            return "success";
        }

        public static void Startup()
        {

            DirectoryInfo downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Input/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }

            downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Attachments/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }

            downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Images/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }

            downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("Images/Signature/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }

            downloadedMessageInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("search/"));

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        
        }
        public static Aspose.Pdf.Color GetColor(string color)
        { 
            switch(color)
            {
                case "red":
                    return Aspose.Pdf.Color.Red;
                case "black":
                    return Aspose.Pdf.Color.Black;
                case "green":
                    return Aspose.Pdf.Color.Green;
                case "white":
                    return Aspose.Pdf.Color.White;
                case "blue":
                    return Aspose.Pdf.Color.Blue;
                case "grey":
                    return Aspose.Pdf.Color.Gray;

                case "yellow":
                    return Aspose.Pdf.Color.Yellow;
                default:
                    return Aspose.Pdf.Color.Black;
            }
        }
    }

    public class shap
    {
        public float x { get; set; }
        public float y { get; set; }
        public float w { get; set; }
        public float h { get; set; }
        public int p { get; set; }
        public string f { get; set; }
        public string t { get; set; }
        public string n { get; set; }
        public string s { get; set; }
        public string c { get; set; }
        public string wt { get; set; }
        public string st { get; set; }
        public string ratio { get; set; }
        public object imfile { get; set; }
        public string imName { get; set; }
        public string Itype { get; set; }
        public string fieldType { get; set; }

    }

    


}