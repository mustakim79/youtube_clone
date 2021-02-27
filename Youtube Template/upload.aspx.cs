using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Youtube_Template_upload : System.Web.UI.Page
{
    SqlConnection con;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        con.Open();
        if (!IsPostBack)
        {
            getdata();
        }
    }
    public void upload_file()
    {
        string msg = "";
        string sqr = "SELECT * FROM video_detail WHERE video_name='" + file.FileName + "'";
        SqlCommand scmd = new SqlCommand(sqr, con);
        SqlDataReader rd = scmd.ExecuteReader();
        if (!rd.Read())
        {
            rd.Close(); // <- too easy to forget
            rd.Dispose(); // <- too easy to forget
            if (file.HasFile)
            {
                //lbl.Text=file_name;
                string file_name = file.FileName;
                String path = Server.MapPath("~/upload/") + file_name;
                file.SaveAs(path);
                string qr = "INSERT INTO video_detail (video_name,title,description,user_id,cat_id,date_time) VALUES(@file,@title,@description,@user,@cat_id,@dt)";
                SqlCommand cmd = new SqlCommand(qr, con);
                cmd.Parameters.AddWithValue("@file", file_name);
                cmd.Parameters.AddWithValue("@title", txt_title.Text);
                cmd.Parameters.AddWithValue("@user", 1);
                cmd.Parameters.AddWithValue("@description", txt_desc.Text);
                cmd.Parameters.AddWithValue("@cat_id", ddl.SelectedValue);
                cmd.Parameters.AddWithValue("@dt", DateTime.Now);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    msg = "Added Successfully";
                    Response.Redirect("upload.aspx");
                }
                else
                {
                    msg = "File is not uploaded";
                }


            }
            else
            {
                msg = "File is not selected";
            }
        }
        else
        {
            msg = "This file is already exist";
        }
        lbl.Text = msg;
        lbl.Visible = true;
        con.Close();

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        upload_file();
    }
    public void getdata()
    {
        string qr = "SELECT * FROM video_category";
        SqlCommand cmd = new SqlCommand(qr, con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        ddl.DataSource = dt;
        ddl.DataBind();
        ddl.DataTextField = "category_name";
        ddl.DataValueField = "cat_id";
        ddl.DataBind();
    }
}