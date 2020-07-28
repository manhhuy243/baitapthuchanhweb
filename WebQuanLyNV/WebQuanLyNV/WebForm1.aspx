<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebQuanLyNV.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Login</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="Style_Login/images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="Style_Login/css/util.css">
    <link rel="stylesheet" type="text/css" href="Style_Login/css/main.css">
    <!--===============================================================================================-->

    <body>

        <div class="limiter">
            <div class="container-login100">
                <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-50">
                    <form id="form1" runat="server">
                        <span class="login100-form-title p-b-33">Account Login
                        </span>

                        <div class="wrap-input100 validate-input" data-validate="so dien thoai ko chinh xac">
                            <asp:TextBox ID="TxtEmail" class="input100" type="text" placeholder="email" runat="server"></asp:TextBox>
                            <span class="focus-input100-1"></span><span class="focus-input100-2"></span>

                        </div>


                        <div class="wrap-input100 rs1 validate-input" data-validate="Password is require">
                            <asp:TextBox ID="TextPass" class="input100" type="password" placeholder="Password" runat="server"></asp:TextBox>
                            <span class="focus-input100-1"></span>
                            <span class="focus-input100-2"></span>
                        </div>
                        <div class="container-login100-form-btn m-t-20">
                            <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <asp:Button class="login100-form-btn" runat="server" Text="Login" id="Buttom_Login" type="buttom" OnClick="Buttom_Login_Click" />
                    </form>
                </div>
            </div>

        </div>

        <!--===============================================================================================-->
        <script src="Style_Login/vendor/jquery/jquery-3.2.1.min.js"></script>
        <!--===============================================================================================-->
        <script src="Style_Login/vendor/animsition/js/animsition.min.js"></script>
        <!--===============================================================================================-->
        <script src="Style_Login/vendor/bootstrap/js/popper.js"></script>
        <script src="Style_Login/vendor/bootstrap/js/bootstrap.min.js"></script>
        <!--===============================================================================================-->
        <script src="Style_Login/vendor/select2/select2.min.js"></script>
        <!--===============================================================================================-->
        <script src="Style_Login/vendor/daterangepicker/moment.min.js"></script>
        <script src="Style_Login/vendor/daterangepicker/daterangepicker.js"></script>
        <!--===============================================================================================-->
        <script src="Style_Login/vendor/countdowntime/countdowntime.js"></script>
        <!--===============================================================================================-->
        <script src="Style_Login/js/main.js"></script>

    </body>
</html>
