<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Admin/admin_header_footer.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <% if (Session["admin"] != null)
       { %>
    <div class="container-fluid">
        <!--<asp:Label runat="server" ID="lbl"></asp:Label>
        <asp:FileUpload runat="server" ID="file" CssClass="form-control" required="required" />
        <asp:TextBox runat="server" ID="title" CssClass="m-3 form-control" placeholder="Tite" required="required"></asp:TextBox>
        <asp:TextBox runat="server" ID="description" CssClass="m-3 form-control" placeholder="Description" required="required"></asp:TextBox>
        <asp:Button runat="server" ID="bnt" Class="btn btn-primary" Text="Upload" OnClick="bnt_Click" />-->
    </div>

    <% }
       else
       {
           Response.Redirect("login.aspx");
       } %>
</asp:Content>

