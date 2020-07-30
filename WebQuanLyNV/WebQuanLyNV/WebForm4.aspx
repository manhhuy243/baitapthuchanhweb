<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebQuanLyNV.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="20pt" Height="50px" Text="thong tin email da chon : "></asp:Label>
    
        <asp:Label ID="lblEmail" runat="server" Font-Size="20pt" Height="50px"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ten nhan vien: "></asp:Label>
        <br />
        <asp:TextBox ID="txtTen" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="mat khau"></asp:Label>
        <br />
        <asp:TextBox ID="txtMatKhau" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="so dien thoai"></asp:Label>
        <br />
        <asp:TextBox ID="txtSDT" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="nam sinh"></asp:Label>
        <br />
        <asp:TextBox ID="txtNgaySinh" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLuu" runat="server" OnClick="btnLuu_Click" Text="luu" />
        <asp:Button ID="btnHuy" runat="server" OnClick="btnHuy_Click" Text="huy" />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
