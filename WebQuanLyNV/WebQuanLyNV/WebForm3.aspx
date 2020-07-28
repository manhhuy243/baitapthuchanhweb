<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebQuanLyNV.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataGrid CssClass="Grid" ID="grNV" runat="server" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"></asp:DataGrid>
        
    </div>
        <div>
            <asp:Button runat="server" ID="btnCreate" Text="tao tai khoan"/>
            <asp:Button ID="btnDeleted" runat="server"  Text="Xoa" />
        </div>
    </form>
</body>
</html>
