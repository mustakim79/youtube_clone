using System;
using System.Configuration;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
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
            string qr = "SELECT * FROM users WHERE email='" + email.Text.ToString() + "' AND user_password='" + password.Text.ToString() + "'";
            //Response.Write(qr);
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //lbl.Text = reader["email"].ToString() + " " + reader["password"].ToString();
                Session["user"] = reader["name"].ToString();
                Response.Write("Login successfully");
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