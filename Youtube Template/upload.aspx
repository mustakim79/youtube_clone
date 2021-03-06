<%@ Page Language="C#" AutoEventWireup="true" CodeFile="upload.aspx.cs" Inherits="Youtube_Template_upload" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!--#include file="links.html"-->
</head>
<body>
    <!--#include file="header.html"-->
    <form id="form1" runat="server">
        <div class="upload">
            <div class="container">
                <asp:Label runat="server" ID="lbl" Visible="false" CssClass="form-control"></asp:Label>
                <h1>Helo</h1>
                <asp:FileUpload runat="server" ID="file" class="form-control" required="required" />
                <asp:TextBox runat="server" ID="txt_title" placeholder="Enter Title" required="required" class="form-control my-3"></asp:TextBox>
                <asp:TextBox runat="server" ID="txt_desc" placeholder="Enter Description" required="required" class="form-control my-3"></asp:TextBox>
                <asp:DropDownList runat="server" ID="ddl" class="form-control my-3" required="required">
                    <asp:ListItem Value="">Select value </asp:ListItem>
                </asp:DropDownList>
                <asp:Button runat="server" ID="btn_submit" OnClick="btn_submit_Click" class="btn btn-primary float-left" Text="submit" />
            </div>
        </div>
    </form>

    <!--#include file="footer.html"-->
</body>
</html>
