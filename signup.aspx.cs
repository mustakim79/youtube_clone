using System;
using System.Configuration;
using System.Data.SqlClient;
public partial class signup : System.Web.UI.Page
{
    public SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        con.Open();
    }
    protected void btn_signup_Click(object sender, EventArgs e)
    {
        string email, name, password;
        email = user_email.Text.ToString();
        name = user_name.Text.ToString();
        password = user_password.Text.ToString();

        //Intent inten = getIntent();
        string qr = "INSERT INTO users (name,email,user_password) output INSERTED.Id VALUES('" + name + "','" + email + "','" + password + "')";
        SqlCommand cmd = new SqlCommand(qr, con);
        int res = (int)cmd.ExecuteScalar();
        if (Convert.ToBoolean(res))
        {
            Response.Redirect("login.aspx.cs");
        }
        else
        {
            Response.Write("error");
        }

        /*string qr = "INSERT INTO users (name,email,user_password) VALUES('" + name + "','" + email + "','" + password + "')";
        SqlCommand cmd = new SqlCommand(qr, con);
        int res = (int)cmd.ExecuteNonQuery();*/

    }
}