<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebQuanLyNV.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style_LoadNV/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView CssClass="Grid" ID="grNV" runat="server" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" ></asp:GridView>
        </div>
    </form>
</body>
</html>
