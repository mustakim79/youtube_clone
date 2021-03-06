using System;

public partial class Admin_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null && Session["img"] != null)
        {
            Session["admin"] = null;
            Session["img"] = null;
        }
        Response.Redirect("login.aspx");
    }
}