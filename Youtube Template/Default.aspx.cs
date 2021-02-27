using System;
using System.Configuration;
using System.Data.SqlClient;

public partial class Youtube_Template_Default : System.Web.UI.Page
{
    SqlConnection con;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        con.Open();
    }
}