<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin_header_footer.master" AutoEventWireup="true" CodeFile="manage_category.aspx.cs" Inherits="Admin_manage_category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <% if (Session["admin"] != null)
       { %>
    <div class="container-fluid">
        <h2>Category</h2>
    </div>

    <% }
       else
       {
           Response.Redirect("login.aspx");
       } %>
</asp:Content>

