<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Default.aspx.cs" Inherits="Aspose.Pdf.GridViewExport.Website.Default" %>

<%@ Register TagPrefix="aspose" Namespace="Aspose.Pdf.GridViewExport" Assembly="Aspose.Pdf.GridViewExport" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .myClass
        {
            clear: both;
        }
        
        .myClass input
        {
            float: right;
        }
    </style>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="http://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="http://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->
    <script type="text/javascript" src="http://netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <aspose:ExportGridViewToPdf Width="800px" ID="ExportGridViewToPdf1" ExportButtonText="Export to Pdf"
            CssClass="table table-hover table-bordered" ExportButtonCssClass="myClass"
            ExportInLandscape="true" ExportOutputPathOnServer="c:\\temp" ExportFileHeading="<h1>Example Report</h1>"
            OnPageIndexChanging="ExportGridViewToPdf1_PageIndexChanging" PageSize="5" AllowPaging="True"
            LicenseFilePath="c:\inetpub\Aspose.Total.lic" runat="server" CellPadding="4"
            ForeColor="#333333" GridLines="Both">
        </aspose:ExportGridViewToPdf>
    </div>
    </form>
</body>
</html>
