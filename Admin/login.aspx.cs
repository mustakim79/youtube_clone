using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_login : System.Web.UI.Page
{
    public SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        con.Open();
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {

        try
        {
            string qr = "SELECT * FROM admin WHERE name='" +name.Text.ToString() + "' AND password='" + password.Text.ToString() + "'";
            //Response.Write(qr);
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //lbl.Text = reader["email"].ToString() + " " + reader["password"].ToString();
                Session["admin"] = reader["name"].ToString();
                Response.Redirect("Default.aspx");
            }
            else
            {
                lbl.Text = "invalid";
            }
        }
        catch (Exception ee)
        {
            Response.Write(ee);
        }
    }
}