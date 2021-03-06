<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Form-v2 by Colorlib</title>
    <!-- Mobile Specific Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <!-- Font-->
    <link rel="stylesheet" type="text/css" href="public/signup_css/roboto-font.css">
    <link rel="stylesheet" type="text/css" href="public/signup_fonts/line-awesome/public/signup_css/line-awesome.min.css">
    <!-- Jquery -->
    <link rel="stylesheet" href="https://jqueryvalidation.org/files/demo/site-demos.css">
    <!-- Main Style Css -->
    <link rel="stylesheet" href="public/signup_css/style.css" />
</head>
<body class="form-v2">
    <div class="page-content">
        <div class="form-v2-content">
            <div class="form-left">
                <img src="public/signup_images/form-v2.jpg" alt="form">
                <div class="text-1">
                    <p>Bring Your Music Along<span>try Unlimited</span></p>
                </div>
                <div class="text-2">
                    <p><span>$9.99</span>/ Month</p>
                </div>
            </div>
            <form class="form-detail" action="#" method="post" id="myform" runat="server">
                <h2>Registration Form</h2>
                <div class="form-row">
                    <label for="full-name">Full Name:</label>
                    <asp:TextBox type="text" name="full_name" ID="user_name" class="input-text" placeholder="ex: Lindsey Wilson" runat="server" />
                </div>
                <div class="form-row">
                    <label for="your_email">Your Email:</label>
                    <asp:TextBox type="text" name="your_email" ID="user_email" class="input-text" required="required" pattern="[^@]+@[^@]+.[a-zA-Z]{2,6}" runat="server" />
                </div>
                <div class="form-row">
                    <label for="password">Password:</label>
                    <asp:TextBox type="password" name="password" ID="user_password" class="input-text" required="required" runat="server" />
                </div>
                <div class="form-row">
                    <label for="comfirm-password">Confirm Password:</label>
                    <asp:TextBox type="password" name="confirm_password" ID="confirm_password" class="input-text" required="required" runat="server" />
                </div>
                <!--<div class="form-checkbox">
                    <label class="container">
                        <p>By signing up, you agree to the <a href="#" class="text">Play Term of Service</a></p>
                        <input type="checkbox" name="agree" id="agree">
                        <span class="checkmark"></span>
                    </label>
                </div>-->
                <div class="form-row-last">
                    <asp:Button ID="btn_signup" name="register" class="register" Text="Register" runat="server" OnClick="btn_signup_Click" />
                </div>
            </form>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-1.11.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/jquery.validation/1.16.0/jquery.validate.min.js"></script>
    <script src="https://cdn.jsdelivr.net/jquery.validation/1.16.0/additional-methods.min.js"></script>
    <script>
        // just for the demos, avoids form submit
        /*jQuery.validator.setDefaults({
            debug: true,
            success: function (label) {
                label.attr('id', 'valid');
            },
        });
        $("#myform").validate({
            rules: {
                password: "required",
                confirm_password: {
                    equalTo: "#password"
                }
            },
            messages: {
                user_name: {
                    required: "Please provide an username"
                },
                user_email: {
                    required: "Please provide an email"
                },
                user_password: {
                    required: "Please provide a password"
                },
                confirm_password: {
                    required: "Please provide a password",
                    equalTo: "Wrong Password"
                }
            }
        });*/
    </script>
</body>
</html>
