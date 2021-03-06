using System;
using System.Configuration;
using System.Data.SqlClient;

public partial class Admin_login : System.Web.UI.Page
{
    public SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        con.Open();
        //        Session["msg"] = null;
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {

        try
        {
            string qr = "SELECT * FROM admin WHERE name='" + name.Text.ToString() + "' AND password='" + password.Text.ToString() + "'";
            //Response.Write(qr);
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //lbl.Text = reader["email"].ToString() + " " + reader["password"].ToString();
                Session["admin"] = reader["name"].ToString();
                Session["img"] = reader["img"].ToString();
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["msg"] = "Invalid Password and Username";
            }
        }
        catch (Exception ee)
        {
            Response.Write(ee);
        }
    }
}