---
title: PDF Editor - Working with Pages
type: docs
weight: 20
url: /net/pdf-editor-working-with-pages/
---

### **Adding Page in PDF File**
Using Html5 PDF Editor, you can add new pages in PDF files using **Add Page** option from the menu bar. Using this feature, you may add a blank page to your PDF file. In our next section, we will discuss the technical details behind this feature.

**How it works?**

**HTML - "Add Page" menu item is clicked on the page**

When you click "Add Page" menu item, "AddPage" method is called in *Editor.js* file.

**jQuery - Send Ajax request to server for AddPage_Click method.**

See *Editor.js* tab below for source code of AddPage method, it calls AddPage_Click method in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below with source code of AddPage_Click method. It adds a new empty page in PDF file using Aspose.PDF.Document class. After adding the page to PDF file, it converts the page to image to be displayed in the editor.The control is then returned back to *Editor.js* file which updates the page numbering in AddPage method.
#### **Editor.js**
{{< highlight java >}}

 function AddPage() {


    $('#loadingModal').modal('show');

    // Sending the image data to Server

    $.ajax({

        type: 'POST',

        url: 'CanvasSave.aspx/AddPage_Click',

        data: '{ "lastpage" : "' + Npages[Npages.length - 1] + '" }',

        contentType: 'application/json; charset=utf-8',

        dataType: 'json',

        success: function (data, textStatus, jqXHR) {

            Npages.push(data.d);

            document.getElementById('lblPages').innerHTML = 'Page ' + currentPage + '  Of ' + Npages.length;

            $('#loadingModal').modal('hide');

        },

        //call on ajax call failure

        error: function (xhr, textStatus, error) {

            $('#loadingModal').modal('hide');

            //called on ajax call success

            alert("Error: " + xhr.responseJSON.Message);

        }

    });

}

{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

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

                    PngDevice pngDevice = new PngDevice();

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


{{< /highlight >}}
### **Deleting Page from PDF File**
Using Html5 PDF Editor, you can delete a page from PDF files using **Delete Page** option from the menu bar. In our next section, we will discuss the technical details behind this feature.

**How it works?**

**HTML - "Delete Page" menu item is clicked on the page**

When you click "Delete Page" menu item, DeletePage method is called in *Editor.js* file.

**jQuery - Send Ajax request to server for DeletePage_Click method.**

See *Editor.js* tab below for source code of DeletePage method, it calls DeletePage_Click method in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below with source code of DeletePage_Click method. It deletes the selected page from PDF file using Delete method of Aspose.PDF.Document.Page collection.

**Updating editing content**

After deleting the page from PDF file, the control is then returned back to DeletePage method in *Editor.js* file which updates the page numbering, remove any collections associated with the deleted page using updateIndexesDelete method.
#### **Editor.js**
{{< highlight java >}}

 function DeletePage() {

    $('#loadingModal').modal('show');

    var deleteData = JSON.stringify({ 'imageData': currentPage, 'imageName': Npages[currentPage-1] });

    // Sending the image data to Server

    return $.ajax({

        type: 'POST',

        url: 'CanvasSave.aspx/DeletePage_Click',

        data: deleteData,

        contentType: 'application/json; charset=utf-8',

        dataType: 'json',

        success: function (data, textStatus, jqXHR) {

            updateIndexesDelete();

            $('#loadingModal').modal('hide');

        },

        //call on ajax call failure

        error: function (xhr, textStatus, error) {

            $('#loadingModal').modal('hide');

            //called on ajax call success

            alert("Error: " + xhr.responseJSON.Message);

        }

    });

}

{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

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

    }

}

{{< /highlight >}}
### **Move Pages in PDF File**
Using Html5 PDF Editor, you can move pages in PDF files using **Move Page** option from the menu bar. Once you press the **Move Page** menu item, you are presented with an input dialog to specify the selected page's new location. In our next section, we will discuss the technical details behind this feature.

**How it works?**

**HTML - "Move Page" menu item is clicked on the page**

When you click "Move Page" menu item, input dialog is shown to get the new location of the selected page. After providing the page number and pressing "Move" button, "Move" method is called in *Editor.js* file.

**jQuery - Send Ajax request to server for MovePages method.**

See *Editor.js* tab below for source code of Move method, which calls MovePage method and it passes the details like move from, move to, pages list to MovePages method in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below with source code of MovePages method. It uses Aspose.PDF.Document.Pages collection to move the pages.

**Updating editing content**

After moving the page, the control is then returned back to MovePage method in *Editor.js* file which updates the page indexes and information related to different collections in the editor using MoveUpdate method.
#### **Editor.js**
{{< highlight java >}}

 function Move() {

    //Check if sent request is for moving the page

    if ($("#hdnMove").val() == "moving") {

        MovePage();

    }

    else {

        PerformSearch();

    }

}

function MovePage() {

    //Get the value of the new location of the page

    var moveTo = $("#txtMove").val();

    movedata = JSON.stringify({ 'moveFrom': currentPage, 'moveTo': moveTo, 'pageList': Npages });

        $('#loadingModal').modal('show');

        // Sending the data to Server

        $.ajax({

            type: 'POST',

            url: 'CanvasSave.aspx/MovePages',

            data: movedata,

            contentType: 'application/json; charset=utf-8',

            dataType: 'json',

            success: function (data, textStatus, jqXHR) {

                Npages = data.d;

                MoveUpdate();

                $('#loadingModal').modal('hide');

            },

            //call on ajax call failure

            error: function (xhr, textStatus, error) {

                $('#loadingModal').modal('hide');

                //called on ajax call success

                alert("Error: " + xhr.responseJSON.Message);

            }

        });


    }

{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

         [WebMethod()]

        public static string[] MovePages(string moveFrom, string moveTo, string[] pageList)

        {

            try

            {

                //Get page information from sending method

                int pageFrom = Convert.ToInt32(moveFrom);

                int pageTo = Convert.ToInt32(moveTo);

                List<string> str = pageList.ToList();

                //Open document

                Document doc = new Document(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                Aspose.PDF.Page page = doc.Pages[pageFrom];

                //insert page at new location in PDF file

                doc.Pages.Insert(pageTo + 1, page);

                //Update page indexes for the other pages

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

                //Save the document

                doc.Save(HttpContext.Current.Server.MapPath("Convert/output.pdf"));

                //Create new list of pages

                pageList = str.ToArray();



            }

            catch (Exception Exp)

            {

                // return Exp.Message;

            }

            //return list of pages

            return pageList;

        }

{{< /highlight >}}
