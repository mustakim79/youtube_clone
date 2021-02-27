using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

public partial class Admin_Default : System.Web.UI.Page
{
    public SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {

        con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        con.Open();

    }

    protected void bnt_Click(object sender, EventArgs e)
    {
        if (file.HasFile)
        {
            /*String file_name = file.FileName.ToString();
            String path = Server.MapPath("~/Admin/upload/") + file_name;
            file.PostedFile.SaveAs(path);
            /*string icategory = "INSERT INTO video_detail (video_path,title,description,user_id,cat_id,video_duration,date_time) VALUES(@file,@title,@description)";
            SqlCommand cmd = new SqlCommand(icategory, con);
            cmd.Parameters.AddWithValue("@file", path);
            cmd.Parameters.AddWithValue("@title", title.Text);
            cmd.Parameters.AddWithValue("@description", description.Text);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                lbl.Text = "Data inserted";

            }*/
            lbl.Text = f_VideoDuration("upload/Wildlife - Copy.wmv");

        }
    }
    public string f_VideoDuration(String path)
    {

        try
        {
            //            string sInputVideo = Page.MapPath(path);
            string sInputVideo = path;
            string sPath = " -i " + sInputVideo;

            Process ffmepg = new Process();
            ffmepg.StartInfo.FileName = (Server.MapPath("ffmpeg.exe"));
            ffmepg.StartInfo.UseShellExecute = false;
            ffmepg.StartInfo.RedirectStandardOutput = true;
            ffmepg.StartInfo.RedirectStandardError = true;
            ffmepg.StartInfo.CreateNoWindow = true;
            ffmepg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ffmepg.StartInfo.Arguments = sPath;
            ffmepg.EnableRaisingEvents = true;
            ffmepg.Start();
            string sDuration = ffmepg.StandardError.ReadToEnd().ToString();
            ffmepg.Close();
            ffmepg.Dispose();

            sDuration = sDuration.Remove(0, sDuration.LastIndexOf("Duration: ") + 10);
            sDuration = sDuration.Substring(0, sDuration.IndexOf(","));
            return sDuration;
        }
        catch (Exception ex)
        {
            Response.Write(ex);
            throw (ex);
        }
    }
}