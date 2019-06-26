<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Examples.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
		<h1>Welcome to the Aspose.Pdf for .NET Web Examples!</h1>
    </div>

    <table class="table">
        <thead class="thead-light">
            <tr>
                <th scope="col">#</th>
                <th scope="col">Article Name</th>
                <th scope="col">Link to Example</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope="row">1</th>
                <td>Send PDF to Browser for Download</td>
                <td><a href="SendPdfToBrowserForDownload.aspx">Example link.</a></td>
            </tr>
        </tbody>
    </table>
</asp:Content>
