<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendPdfToBrowserForDownload.aspx.cs" Inherits="Examples.Web.SendPdfToBrowserForDownload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="btnGenerateDownload" Text="Generate and Download" OnClick="btnGenerateDownload_Click" />
        </div>
    </form>
</body>
</html>
