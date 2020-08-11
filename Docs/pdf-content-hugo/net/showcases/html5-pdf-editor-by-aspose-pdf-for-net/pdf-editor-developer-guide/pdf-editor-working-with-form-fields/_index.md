---
title: PDF Editor - Working with Form Fields
type: docs
weight: 40
url: /net/pdf-editor-working-with-form-fields/
---

**Table of Contents**

- [Loading PDF File with Form Fields](#PDFEditor-WorkingwithFormFields-LoadingPDFFilewithFormFields) 
  - Editor.js
  - CanvasSave.aspx.cs
- [Highlighting Required Form Fields](#PDFEditor-WorkingwithFormFields-HighlightingRequiredFormFields) 
  - Editor.js
  - CanvasSave.aspx.cs
### **Loading PDF File with Form Fields**
Using Html5 PDF Editor, you can load and work with a PDF file containing form fields. Once the file with form fields is loaded in the editor, all the form fields are loaded for editing. In our next section, we will discuss the technical details behind this feature.

![todo:image_alt_text](pdf-editor-working-with-form-fields_1.png)

**How it works?**

**HTML - "Open From Computer" menu item is clicked on the page.**

When you click "Open From Computer" menu item, you can upload the input file containing the form fields using file upload dialog. After the file gets uploaded, "fileSelected" method is called in *Editor.js* file.

**jQuery - Send server request for ProcessRequest method**

File gets posted to the server and method "ProcessRequest" is called in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below. Based on the form parameter passed, the file to be uploaded is saved on the server, ImageConverter method, converts the uploaded file to images and "CheckFields" method is called which uses Aspose.PDF.InteractiveFeatures.Forms class to check for all the form fields and collect the information regarding the fields i.e. FieldType, Location etc. and return the field's collection back to ImageConverter method. ImageConverter method returns the control back to "fileSelected" method in *Editor.js*

**loading form fields on canvas**

See *Editor.js* tab below, manageFields method in *Editor.js* is used to generate all the fields on the canvas based on the information sent back from the server side. It draws HTML field controls using the type and location information from the server side to the canvas.
#### **Editor.js**
{{< highlight java >}}

 function manageFields() {

     for (i = 0; i < shapes.length; i++) {

        var shapeDiv = document.getElementById("div_" + shapes[i].imName + "");

        var shape = document.getElementById(shapes[i].imName);

        if (shape != null) {

            $('#' + shapes[i].imName + '').remove();

        }

        if (shapeDiv != null) {

            shapeDiv.parentNode.removeChild(shapeDiv);

        }

    }

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');


    for (i = 0; i < shapes.length; i++) {

        if (shapes[i].f == Npages[currentPage - 1]) {

            if (shapes[i].Itype == "field") {

                var rect = canvas.getBoundingClientRect();

                var fld = document.getElementById("div_" + shapes[i].imName + "");

                if (fld == null) {

                    var wrapper = document.createElement('div');


                    wrapper.style.left = (rect.left + parseInt(shapes[i].x) + 2) + "px";

                    wrapper.style.top = (rect.top + parseInt(shapes[i].y) + 2) + "px";

                    wrapper.style.width = parseInt(shapes[i].w - 2) + "px";

                    wrapper.style.height = parseInt(shapes[i].h - 2) + "px";

                    wrapper.id = "div_" + shapes[i].imName;

                    wrapper.style.zIndex = 50 + i;




                    if (shapes[i].fieldType == "Text") {

                        wrapper.className = 'info';

                        wrapper.setAttribute("display", 'block');

                        var textarea = document.createElement('textarea');

                        textarea.className = 'tbox';

                        textarea.value = shapes[i].t;

                        textarea.style.width = (parseInt(shapes[i].w) - 2) + "px";

                        textarea.style.height = (parseInt(shapes[i].h) - 2) + "px";

                        textarea.style.left = "0px";

                        textarea.style.top = "0px";

                        textarea.style.zIndex = 150 + i;

                        if (shapes[i].st == 'True') {

                            textarea.style.backgroundColor = '#FFE4E1';

                        }

                        textarea.id = shapes[i].imName;

                        wrapper.appendChild(textarea);

                    }

                    else if (shapes[i].fieldType == "CheckBox") {

                       wrapper.className = 'info';

                       wrapper.style.left = (rect.left + (parseInt(shapes[i].x))) + "px";

                       wrapper.style.top = (rect.top + (parseInt(shapes[i].y))) + "px";

                       wrapper.style.width = (parseInt(shapes[i].w) + 5) + "px";

                       wrapper.style.height = (parseInt(shapes[i].h) + 5) + "px";

                       if (shapes[i].st == 'True') {

                           wrapper.style.backgroundColor = '#FFE4E1';

                       }

                        var checkbox = document.createElement('input');

                        checkbox.type = "checkbox";

                        checkbox.name = shapes[i].imfile; //shapes[i].imName;

                        if (shapes[i].t == 'true') {

                            checkbox.checked = true;

                        }

                        else {

                            checkbox.checked = false;

                        }

                        checkbox.style.zIndex = 150 + i;

                        checkbox.id = shapes[i].imName;

                        wrapper.appendChild(checkbox);

                    }

                    else if (shapes[i].fieldType == "Radio") {


                        wrapper.className = 'Mine';

                        wrapper.style.left = (rect.left  + parseInt(shapes[i].x)) + "px";

                        wrapper.style.top = (rect.top - 1 + parseInt(shapes[i].y)) + "px";

                        wrapper.style.width = (parseInt(shapes[i].w) + 5) + "px";

                        wrapper.style.height = (parseInt(shapes[i].h) + 5) + "px";

                        if (shapes[i].st == 'True') {

                            wrapper.style.backgroundColor = '#FFE4E1';

                        }

                        var radio = document.createElement('input');

                        radio.type = "radio";

                        radio.id = shapes[i].imName;

                        radio.name = shapes[i].imfile;

                        if (shapes[i].t == 'true') {

                            radio.checked = true;

                        }

                        else {

                            radio.checked = false;

                        }

                        radio.style.zIndex = 150 + i;

                        radio.id = shapes[i].imName;

                        wrapper.appendChild(radio);


                    }

                    else if (shapes[i].fieldType == "ComboBox") {

                        wrapper.className = 'tbox';

                        var combo = document.createElement("select");

                        combo.id = shapes[i].imName;

                        combo.style.zIndex = 150 + i;

                        var values = shapes[i].t.split('^^^');

                        combo.className = 'tbox';

                        combo.style.width = (shapes[i].w - 2)+ 'px';

                        if (shapes[i].st == 'True') {

                            combo.style.backgroundColor = '#FFE4E1';

                        }

                        for (j = 1; j < values.length; j++) {

                            var option1 = document.createElement("option");

                            option1.value = values[j];

                            option1.innerHTML = values[j];

                            combo.appendChild(option1);

                        }

                        if (values[0] != '') {

                            var opts = combo.options.length;

                            for (var k = 0; k < opts; k++) {

                                if (combo.options[k].value == values[0]) {

                                    combo.options[k].selected = true;

                                    break;

                                }

                            }

                        }

                        wrapper.appendChild(combo);

                    }

                    document.body.appendChild(wrapper);

                }

            }

        }

    }

}

{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

 private static string CheckFields(Document doc, int pageCount, string filename, string fields, double ratio, bool licensed)

        {

            double marginLeft = doc.Pages[pageCount].PageInfo.Margin.Left;

            double marginTop = doc.Pages[pageCount].PageInfo.Margin.Top;

            int fieldcounter = 0;

            Aspose.PDF.Facades.Form pdfForm = new Aspose.PDF.Facades.Form(doc);

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

{{< /highlight >}}
### **Highlighting Required Form Fields**
Using Html5 PDF Editor, you can highlight the required form fields in the editor. Once the file with form fields is loaded in the editor, all the required form fields are highlighted for the users to assist in editing. In our next section, we will discuss the technical details behind this feature.

![todo:image_alt_text](pdf-editor-working-with-form-fields_2.png)

**How it works?**

**HTML - "Open From Computer" menu item is clicked on the page.**

When you click "Open From Computer" menu item, you can upload the input file containing the form fields using file upload dialog. After the file gets uploaded, "fileSelected" method is called in *Editor.js* file.

**jQuery - Send server request for ProcessRequest method**

File gets posted to the server and method "ProcessRequest" is called in *CanvasSave.aspx.cs* file.

**ASP.NET web method handles server requests**

See *Canvas.aspx.cs* tab below. Based on the form parameter passed, the file to be uploaded is saved on the server, ImageConverter method, converts the uploaded file to images and "CheckFields" method is called which uses Aspose.PDF.InteractiveFeatures.Forms class to check for all the form fields and collect the information regarding the fields i.e. FieldType, Location etc.. After getting the details of all the form fields, we get the information whether a form field is required form fields using Aspose.PDF.Facades.IsRequiredField method and return the field's collection back to ImageConverter method. ImageConverter method returns the control back to "fileSelected" method in *Editor.js*

**loading form fields on canvas**

See *Editor.js* tab below, manageFields method in *Editor.js* is used to generate all the fields on the canvas based on the information sent back from the server side. It draws HTML field controls using the type and location information from the server side to the canvas. If a certain field is required, it uses the div (named as wrapper) around the control and change the background color property of the div to show it as highlighted required field.
#### **Editor.js**
{{< highlight java >}}

 function manageFields() {

     for (i = 0; i < shapes.length; i++) {

        var shapeDiv = document.getElementById("div_" + shapes[i].imName + "");

        var shape = document.getElementById(shapes[i].imName);

        if (shape != null) {

            $('#' + shapes[i].imName + '').remove();

        }

        if (shapeDiv != null) {

            shapeDiv.parentNode.removeChild(shapeDiv);

        }

    }

    var canvas = document.getElementById('imageView');

    var context = canvas.getContext('2d');


    for (i = 0; i < shapes.length; i++) {

        if (shapes[i].f == Npages[currentPage - 1]) {

            if (shapes[i].Itype == "field") {

                var rect = canvas.getBoundingClientRect();

                var fld = document.getElementById("div_" + shapes[i].imName + "");

                if (fld == null) {

                    var wrapper = document.createElement('div');


                    wrapper.style.left = (rect.left + parseInt(shapes[i].x) + 2) + "px";

                    wrapper.style.top = (rect.top + parseInt(shapes[i].y) + 2) + "px";

                    wrapper.style.width = parseInt(shapes[i].w - 2) + "px";

                    wrapper.style.height = parseInt(shapes[i].h - 2) + "px";

                    wrapper.id = "div_" + shapes[i].imName;

                    wrapper.style.zIndex = 50 + i;




                    if (shapes[i].fieldType == "Text") {

                        wrapper.className = 'info';

                        wrapper.setAttribute("display", 'block');

                        var textarea = document.createElement('textarea');

                        textarea.className = 'tbox';

                        textarea.value = shapes[i].t;

                        textarea.style.width = (parseInt(shapes[i].w) - 2) + "px";

                        textarea.style.height = (parseInt(shapes[i].h) - 2) + "px";

                        textarea.style.left = "0px";

                        textarea.style.top = "0px";

                        textarea.style.zIndex = 150 + i;

                        if (shapes[i].st == 'True') {

                            textarea.style.backgroundColor = '#FFE4E1';

                        }

                        textarea.id = shapes[i].imName;

                        wrapper.appendChild(textarea);

                    }

                    else if (shapes[i].fieldType == "CheckBox") {

                       wrapper.className = 'info';

                       wrapper.style.left = (rect.left + (parseInt(shapes[i].x))) + "px";

                       wrapper.style.top = (rect.top + (parseInt(shapes[i].y))) + "px";

                       wrapper.style.width = (parseInt(shapes[i].w) + 5) + "px";

                       wrapper.style.height = (parseInt(shapes[i].h) + 5) + "px";

                       if (shapes[i].st == 'True') {

                           wrapper.style.backgroundColor = '#FFE4E1';

                       }

                        var checkbox = document.createElement('input');

                        checkbox.type = "checkbox";

                        checkbox.name = shapes[i].imfile; //shapes[i].imName;

                        if (shapes[i].t == 'true') {

                            checkbox.checked = true;

                        }

                        else {

                            checkbox.checked = false;

                        }

                        checkbox.style.zIndex = 150 + i;

                        checkbox.id = shapes[i].imName;

                        wrapper.appendChild(checkbox);

                    }

                    else if (shapes[i].fieldType == "Radio") {


                        wrapper.className = 'Mine';

                        wrapper.style.left = (rect.left  + parseInt(shapes[i].x)) + "px";

                        wrapper.style.top = (rect.top - 1 + parseInt(shapes[i].y)) + "px";

                        wrapper.style.width = (parseInt(shapes[i].w) + 5) + "px";

                        wrapper.style.height = (parseInt(shapes[i].h) + 5) + "px";

                        if (shapes[i].st == 'True') {

                            wrapper.style.backgroundColor = '#FFE4E1';

                        }

                        var radio = document.createElement('input');

                        radio.type = "radio";

                        radio.id = shapes[i].imName;

                        radio.name = shapes[i].imfile;

                        if (shapes[i].t == 'true') {

                            radio.checked = true;

                        }

                        else {

                            radio.checked = false;

                        }

                        radio.style.zIndex = 150 + i;

                        radio.id = shapes[i].imName;

                        wrapper.appendChild(radio);


                    }

                    else if (shapes[i].fieldType == "ComboBox") {

                        wrapper.className = 'tbox';

                        var combo = document.createElement("select");

                        combo.id = shapes[i].imName;

                        combo.style.zIndex = 150 + i;

                        var values = shapes[i].t.split('^^^');

                        combo.className = 'tbox';

                        combo.style.width = (shapes[i].w - 2)+ 'px';

                        if (shapes[i].st == 'True') {

                            combo.style.backgroundColor = '#FFE4E1';

                        }

                        for (j = 1; j < values.length; j++) {

                            var option1 = document.createElement("option");

                            option1.value = values[j];

                            option1.innerHTML = values[j];

                            combo.appendChild(option1);

                        }

                        if (values[0] != '') {

                            var opts = combo.options.length;

                            for (var k = 0; k < opts; k++) {

                                if (combo.options[k].value == values[0]) {

                                    combo.options[k].selected = true;

                                    break;

                                }

                            }

                        }

                        wrapper.appendChild(combo);

                    }

                    document.body.appendChild(wrapper);

                }

            }

        }

    }

}

{{< /highlight >}}
#### **CanvasSave.aspx.cs**
{{< highlight java >}}

 private static string CheckFields(Document doc, int pageCount, string filename, string fields, double ratio, bool licensed)

        {

            double marginLeft = doc.Pages[pageCount].PageInfo.Margin.Left;

            double marginTop = doc.Pages[pageCount].PageInfo.Margin.Top;

            int fieldcounter = 0;

            Aspose.PDF.Facades.Form pdfForm = new Aspose.PDF.Facades.Form(doc);

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

{{< /highlight >}}
