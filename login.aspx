<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Login V11</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/fonts/Linearicons-Free-v1.0.0/icon-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="public/css/util.css">
    <link rel="stylesheet" type="text/css" href="public/css/main.css">
    <!--===============================================================================================-->
</head>
<body>

    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100 p-l-50 p-r-50 p-t-77 p-b-30">
                <form class="login100-form validate-form" runat="server">
                    <span class="login100-form-title p-b-55">Login
                    </span>

                    <div class="wrap-input100 validate-input m-b-16" data-validate="Valid email is required: ex@abc.xyz">
                        <asp:TextBox class="input100" type="text" name="email" ID="email" placeholder="Email" runat="server" />
                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <span class="lnr lnr-envelope"></span>
                        </span>
                    </div>

                    <div class="wrap-input100 validate-input m-b-16" data-validate="Password is required">
                        <asp:TextBox runat="server" class="input100" type="password" name="pass" ID="password" placeholder="Password" />
                        <span class="focus-input100"></span>
                        <span class="symbol-input100">
                            <span class="lnr lnr-lock"></span>
                        </span>
                    </div>

                    <div class="contact100-form-checkbox m-l-4">
                        <asp:TextBox class="input-checkbox100" ID="ckb1" type="checkbox" runat="server" name="remember-me" />
                        <label class="label-checkbox100" for="ckb1">
                            Remember me
                        </label>
                    </div>

                    <div class="container-login100-form-btn p-t-25">
                        <asp:Button class="login100-form-btn" ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click"></asp:Button>
                    </div>

                    <div class="text-center w-full p-t-42 p-b-22">
                        <span class="txt1">Or login with
                        </span>
                    </div>

                    <a href="#" class="btn-face m-b-10">
                        <i class="fa fa-facebook-official"></i>
                        Facebook
                    </a>

                    <a href="#" class="btn-google m-b-10">
                        <img src="public/images/icons/icon-google.png" alt="GOOGLE">
                        Google
                    </a>

                    <div class="text-center w-full p-t-115">
                        <span class="txt1">Not a member?<asp:Label runat="server" ID="lbl"></asp:Label>
                        </span>

                        <a class="txt1 bo1 hov1" href="#">Sign up now							
                        </a>
                    </div>
                </form>
            </div>
        </div>
    </div>




    <!--===============================================================================================-->
    <script src="public/vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="public/vendor/bootstrap/js/popper.js"></script>
    <script src="public/vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="public/vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="public/js/main.js"></script>

</body>
</html>
