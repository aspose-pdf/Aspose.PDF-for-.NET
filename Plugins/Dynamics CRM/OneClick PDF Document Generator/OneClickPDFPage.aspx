<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OneClickPDFPage.aspx.cs" Inherits="OneClick_PDF_Document_Generator.OneClickPDFPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>OneClick PDF Document Generator Page</title>
    <link href="AsposeStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="Main">
            <h2>Aspose .NET OneClick PDF Document Generator
            </h2>
            <div class="Label">Select Template and Generate Document</div>
            <br />
            <asp:Label ID="LBL_Message" runat="server" Text="" ForeColor="Red"></asp:Label>
            <div class="Width100">
                <table>

                    <tr>
                        <th class="Label Width30">Template
                        </th>
                        <td class="Value">
                            <asp:DropDownList ID="DDL_Templates" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th class="Label Width30">Action
                        </th>
                        <td class="Value">
                            <asp:DropDownList ID="DDL_Action" runat="server">
                                <asp:ListItem Text="Download"></asp:ListItem>
                                <asp:ListItem Text="Attach to Note"></asp:ListItem>
                                <%--<asp:ListItem Text="Attach to Email"></asp:ListItem>--%>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <th class="Label Width30">Generated File Name
                        </th>
                        <td class="Value">
                            <asp:TextBox ID="TXT_FileName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="footer">
            <div class="buttons-left">
            </div>
            <div class="buttons-right">
                <asp:Button ID="BTN_Generate" runat="server" Text="Generate" CssClass="footerbutton" OnClick="BTN_Generate_Click" />
                <button class="footerbutton" type="button" onclick="window.close();">
                    Cancel
                </button>
            </div>
        </div>
    </form>
</body>
</html>
