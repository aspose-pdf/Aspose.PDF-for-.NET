---
title: PDF Editor - Working with Files
type: docs
weight: 10
url: /net/pdf-editor-working-with-files/
---

**Table of Contents**

- [Create New PDF Files](#PDFEditor-WorkingwithFiles-CreateNewPDFFiles) 
  - Editor.js
  - CanvasSave.aspx.cs
- [Exporting PDF to Different File Formats](#PDFEditor-WorkingwithFiles-ExportingPDFtoDifferentFileFormats) 
  - Editor.js
  - CanvasSave.aspx.cs
- [Appending or Merging PDF Files](#PDFEditor-WorkingwithFiles-AppendingorMergingPDFFiles) 
  - Editor.js
  - CanvasSave.aspx.cs
- [Upload Local PDF File](#PDFEditor-WorkingwithFiles-UploadLocalPDFFile) 
  - Editor.js
  - CanvasSave.aspx.cs
### **Create New PDF Files**
Besides editing existing PDF documents, Html5 PDF Editor also supports creating new PDF files from scratch which you can do by using **Create New File** option from the menu bar. Using this feature, you may create a blank PDF in editor, add some text/images to it and save it in any desired format. In our next section, we will discuss the technical details behind this feature.

**How it works?**

**HTML - "Create New File" menu item is clicked on the page**

When you click "Create New File" menu item, onNewFileClicked method is called in *Editor.js* file.

**jQuery - Send Ajax request to server for CreateNewFile method.**

See *Editor.js* tab below for source code of onNewFileClicked method, it calls CreateNewFile method in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below with source code of CreateNewFile method. It clears any existing data regarding previously loaded file using ResetData method.

**New PDF file creation using Aspose.PDF for .NET**

After clearing the data using ResetData method, CreateNewFile method creates a new PDF file using Document class of Aspose.PDF for .NET.
As you can see in the below tab, the Document object is generating a file with one empty page. After the file is generated on the server, the file is converted to image using ImageConverter method to be loaded on canvas.

**Loading the resultant file to canvas.**

After file gets converted to image on server side, the control is returned back to onNewFileClicked method in *Editor.js*. onNewFileClicked method resets all the client side collections and load the generated image file to canvas using resetData method.
#### **Editor.js**
{{< highlight java >}}

 function onNewFileClicked() {

    // Server side call to create new file

    $.ajax({

        type: 'POST',

        url: 'CanvasSave.aspx/CreateNewFile',

        data: '{ }',

        contentType: 'application/json; charset=utf-8',

        dataType: 'json',

        success: function (data, textStatus, jqXHR) {

            dataLoad = data.d;

            resetData();

        },

        //call on ajax call failure

        error: function (xhr, textStatus, error) {

            alert("Error: " + xhr.responseJSON.Message);

        }

    });

}

{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

 public static string CreateNewFile()

{

       //Reset data for any previously loaded file

       ResetData();

       //Create new PDF document object

       Document doc = new Document();

       //Add an Empty page to PDF file

       doc.Pages.Add();

       //Save PDF file on Server

       doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

       //Convert the newly created file to image and return

       return ImageConverter();

}

{{< /highlight >}}
### **Exporting PDF to Different File Formats**
Html5 PDF Editor supports exporting PDF file to different file formats which you can do by using **Export File** option from the menu bar. Using this feature, you can export the PDF file to your desired format. In our next section, we will discuss the technical details behind this feature.

**How it works?**

**HTML - "Export File" menu item is clicked on the page.**

When you click "Export File" menu item, you can choose the export format from the list. After selecting the export format, "ExportFile" method is called in *Editor.js* file.

**jQuery - Send Ajax server request for method btnFileExport_Click method**

See *Editor.js* tab below for source code of "ExportFile" method. It send a request to server method btnFileExport_Click with file format parameter in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below. Based on the file format parameter passed to btnFileExport_Click, the PDF file is converted using Save method of Aspose.PDF Document object.

**Export file to Download on Client Browser**

After the file is generated on the server, the control is returned back to ExportFile method in *Editor.js* from where the file is sent to the browser for user to download using ExportToBrowser method.
#### **Editor.js**
{{< highlight java >}}

 function ExportFile(fileType) {

    $('#loadingModal').modal('show');

    // Sending the image data to Server

    $.ajax({

        type: 'POST',

        url: 'CanvasSave.aspx/btnFileExport_Click',

        data: '{ "fileType" : "' + fileType + '" }',

        contentType: 'application/json; charset=utf-8',

        dataType: 'json',

        success: function (data, textStatus, jqXHR) { ExportToBrowser('Convert/' + data.d); $('#loadingModal').modal('hide'); },

        //call on ajax call failure

        error: function (xhr, textStatus, error) {

            $('#loadingModal').modal('hide');

            //called on ajax call success

            alert("Error: " + xhr.responseJSON.Message);

        }

    });

}

//Method to send the file to browser for download

function SendToBrowser(fileType) {

    // Create an IFRAME.

    var iframe = document.createElement("iframe");

    // Point the IFRAME to GenerateFile

    iframe.src = "CanvasSave.aspx?Download=" +fileType;

    // This makes the IFRAME invisible to the user.

    iframe.style.display = "none";

    // Add the IFRAME to the page.  This will trigger a request to GenerateFile now.

    document.body.appendChild(iframe);

}


{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

 public static string btnFileExport_Click(string fileType)

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

                System.IO.File.WriteAllText(HttpContext.Current.Server.MapPath("Convert/output.txt"), extractedText);

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


{{< /highlight >}}
### **Appending or Merging PDF Files**
Html5 PDF Editor supports appending or merging of PDF files which you can do by using **Append File** option from the menu bar. Using this feature, you can append the PDF file to your input file. In our next section, we will discuss the technical details behind this feature.

**How it works?**

**HTML - "Append File" menu item is clicked on the page.**

When you click "Append File" menu item, you can upload the file using file upload dialog. After the file gets uploaded, "fileSelected" method is called in *Editor.js* file.

**jQuery - Send server request for ProcessRequest method**

See *Editor.js* tab below for source code of "fileSelected" method. File gets posted to the server and method "ProcessRequest" is called in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below. Based on the form parameter passed, the file to be appended is saved on the server and "AppendFile" method is called. AppendFile method, append the uploaded file using Aspose.PDF for .NET, convert the resultant file to image and return the control back to "fileSelected" method in *Editor.js*

**Update the canvas content after appending the file**

After the file is generated on the server, the control is returned back to "fileSeleceted" method in *Editor.js* which update the contents of the editor.
#### **Editor.js**
{{< highlight java >}}

 function fileSelected() {

    //Get Uploaded file

    var fd = new FormData();

    fd.append("fileToUpload", document.getElementById('fileToUpload').files[0]);

    fd.append("Opp", $("#hdnOpp").val());

    //Send values using form object if appending

    if ($("#hdnOpp").val() == "appending") {

        fd.append("pages", Npages);

        fd.append("ratios", aRatio);

        fd.append("heights", heights);

    }

    //Post the request to server

    var xhr = new XMLHttpRequest();

    xhr.open("POST", "CanvasSave.aspx");

    xhr.onload = function () {

    };

    xhr.upload.onprogress = function (event) {

        if (event.lengthComputable) {

            var complete = (event.loaded / event.total * 99 | 0);

            $(".progress-bar").width('60%');

        }

    }


    xhr.onreadystatechange = function () {

        if (xhr.readyState == 4) {

            data = (xhr.responseText);

            dataLoad = data;

            if (data.indexOf("Evaluation") == -1) {

                //If Appending

                if ($("#hdnOpp").val() == "appending") {

                    First();

                }

                //If Uploading

                else if ($("#hdnOpp").val() == "uploading") {

                    resetCanvasOnLoading();


                }

                //If Adding Attachment

                else if ($("#hdnOpp").val() == "addAttachment") {

                    GetAttachments();

                }

                //If uploading Image

                else {

                    InsertImages(data, 50, 50);

                    }

            }

            else {

                //Evaluation alert

                alert(data);

            }

            //Reset the contents of the form

            resetForm();

        }

    }

    xhr.send(fd);

}


{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

 public void ProcessRequest(HttpContext context)

        {

            try

            {

                //If Download file

                if (context.Request.QueryString["Download"] != null)

                {

                    context.Response.AddHeader("Content-disposition", "attachment; filename=" + context.Request.QueryString["Download"].Split('/')[1].ToString());

                    context.Response.ContentType = "application/octet-stream";

                    context.Response.TransmitFile(Server.MapPath(context.Request.QueryString["Download"].ToString()));

                    context.Response.End();

                }

                else

                {

                    //Capture File From Post

                    HttpPostedFile file = context.Request.Files["fileToUpload"];

                    //If uploading file

                    if (context.Request.Form["Opp"] == "uploading")

                    {

                        //Or just save it locally

                        file.SaveAs(Server.MapPath("Convert/input.pdf"));

                        file.SaveAs(Server.MapPath("Convert/output.pdf"));

                        ResetData();

                        context.Response.Write(ImageConverter());

                    }

                    //If Appending file

                    else if (context.Request.Form["Opp"] == "appending")

                    {

                        string appPages = context.Request.Form["pages"];

                        string appRatios = context.Request.Form["ratios"];

                        string appHeights = context.Request.Form["heights"];

                        //just save it locally

                        file.SaveAs(Server.MapPath("Convert/append.pdf"));

                        //Append the file

                        context.Response.Write(AppendConverter(appPages, appRatios, appHeights));

                    }

                    //If adding attachment

                    else if (context.Request.Form["Opp"] == "addAttachment")

                    {

                        //Or just save it locally

                        file.SaveAs(Server.MapPath("Attachments/" + file.FileName));

                        AddAttachments(Server.MapPath("Attachments/" + file.FileName), file.FileName);

                        context.Response.Write(file.FileName);

                    }

                    //If uploading image

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

                    context.Response.Write("Aspose.PDF Evaluation version limitation. Only 4 elements of any collection are allowed. Please get a free temporary license to test the HTML5 PDF Editor without any limitations from http://www.aspose.com/corporate/purchase/temporary-license.aspx");

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

                string height = "";

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

                            //Convert the file to image

                            System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("Input/image-1" + pageCount + ".png"));

                            //Scale the images

                            ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath("Input/image" + pageCount + ".png"), out height, out Aratio);

                            //Dispose Image object

                            image.Dispose();

                            appPages = appPages + "," + "image" + pageCount + ".png";

                            appRatios = appRatios + "," + Aratio;

                            appHeights = appHeights + "," + height;

                        }

                    }

                }


                return appPages + "%#" + appRatios + "%#" + appHeights;

        }


{{< /highlight >}}
### **Upload Local PDF File**
Html5 PDF Editor supports uploading PDF file from local machine using **Open From Computer** option from the menu bar. Using this feature, you can open an existing PDF file and perform editing on your PDF file. In our next section, we will discuss the technical details behind this feature. 

**How it works?**

**HTML - "Open From Computer" menu item is clicked on the page.**

When you click "Open From Computer" menu item, you can upload the input file using file upload dialog. After the file gets uploaded, "fileSelected" method is called in *Editor.js* file.

**jQuery - Send server request for ProcessRequest method**

See *Editor.js* tab below for source code of "fileSelected" method. File gets posted to the server and method "ProcessRequest" is called in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below. Based on the form parameter passed, the file to be uploaded is saved on the server, resets the data using "ResetData" method and "ImageConverter" method is called. ImageConverter method, converts the uploaded file to images using Aspose.PDF for .NET and return the control back to "fileSelected" method in *Editor.js*

**Update the canvas content after uploading the file**

After the file is generated on the server, the control is returned back to "fileSeleceted" method in *Editor.js* which update the contents of the editor i.e. resets the canvas, load the newly uploaded file.
#### **Editor.js**
{{< highlight java >}}

 function fileSelected() {

    //Get Uploaded file

    var fd = new FormData();

    fd.append("fileToUpload", document.getElementById('fileToUpload').files[0]);

    fd.append("Opp", $("#hdnOpp").val());

    //Send values using form object if appending

    if ($("#hdnOpp").val() == "appending") {

        fd.append("pages", Npages);

        fd.append("ratios", aRatio);

        fd.append("heights", heights);

    }

    //Post the request to server

    var xhr = new XMLHttpRequest();

    xhr.open("POST", "CanvasSave.aspx");

    xhr.onload = function () {

    };

    xhr.upload.onprogress = function (event) {

        if (event.lengthComputable) {

            var complete = (event.loaded / event.total * 99 | 0);

            $(".progress-bar").width('60%');

        }

    }


    xhr.onreadystatechange = function () {

        if (xhr.readyState == 4) {

            data = (xhr.responseText);

            dataLoad = data;

            if (data.indexOf("Evaluation") == -1) {

                //If Appending

                if ($("#hdnOpp").val() == "appending") {

                    First();

                }

                //If Uploading

                else if ($("#hdnOpp").val() == "uploading") {

                    resetCanvasOnLoading();


                }

                //If Adding Attachment

                else if ($("#hdnOpp").val() == "addAttachment") {

                    GetAttachments();

                }

                //If uploading Image

                else {

                    InsertImages(data, 50, 50);

                    }

            }

            else {

                //Evaluation alert

                alert(data);

            }

            //Reset the contents of the form

            resetForm();

        }

    }

    xhr.send(fd);

}


{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

 public void ProcessRequest(HttpContext context)

        {

            try

            {

                //If Download file

                if (context.Request.QueryString["Download"] != null)

                {

                    context.Response.AddHeader("Content-disposition", "attachment; filename=" + context.Request.QueryString["Download"].Split('/')[1].ToString());

                    context.Response.ContentType = "application/octet-stream";

                    context.Response.TransmitFile(Server.MapPath(context.Request.QueryString["Download"].ToString()));

                    context.Response.End();

                }

                else

                {

                    //Capture File From Post

                    HttpPostedFile file = context.Request.Files["fileToUpload"];

                    //If uploading file

                    if (context.Request.Form["Opp"] == "uploading")

                    {

                        //Or just save it locally

                        file.SaveAs(Server.MapPath("Convert/input.pdf"));

                        file.SaveAs(Server.MapPath("Convert/output.pdf"));

                        ResetData();

                        context.Response.Write(ImageConverter());

                    }

                    //If Appending file

                    else if (context.Request.Form["Opp"] == "appending")

                    {

                        string appPages = context.Request.Form["pages"];

                        string appRatios = context.Request.Form["ratios"];

                        string appHeights = context.Request.Form["heights"];

                        //just save it locally

                        file.SaveAs(Server.MapPath("Convert/append.pdf"));

                        //Append the file

                        context.Response.Write(AppendConverter(appPages, appRatios, appHeights));

                    }

                    //If adding attachment

                    else if (context.Request.Form["Opp"] == "addAttachment")

                    {

                        //Or just save it locally

                        file.SaveAs(Server.MapPath("Attachments/" + file.FileName));

                        AddAttachments(Server.MapPath("Attachments/" + file.FileName), file.FileName);

                        context.Response.Write(file.FileName);

                    }

                    //If uploading image

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

                    context.Response.Write("Aspose.PDF Evaluation version limitation. Only 4 elements of any collection are allowed. Please get a free temporary license to test the HTML5 PDF Editor without any limitations from http://www.aspose.com/corporate/purchase/temporary-license.aspx");

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

public static string ImageConverter()

        {

                //Open the uploaded PDF file

                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                string Aratio = "";

                string pages = "";

                string Ratios = "";

                string height = "";

                string Allheights = "";

                string fields = "";

                int TotalPages = 0;

                bool licensed = CheckLicense();

                //Check for License

                if (licensed || (!licensed && doc.Pages.Count <= 4))

                    TotalPages = doc.Pages.Count;

                else

                    TotalPages = 4;

                //Convert file to images

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

                        //Scale Image

                        ScaleImage(image, 1138, 760, HttpContext.Current.Server.MapPath("Input/image" + pageCount + ".png"), out height, out Aratio);

                        //Dispose Image

                        image.Dispose();

                        //Check for Form Fields

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

{{< /highlight >}}
