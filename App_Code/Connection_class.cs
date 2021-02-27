
/// <summary>
/// Summary description for Connection_class
/// </summary>
using System.Configuration;
using System.Data.SqlClient;
public class Connection_class
{
    public Connection_class()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static SqlConnection getCon()
    {

        string str = ConfigurationManager.ConnectionStrings["sqlcon2"].ConnectionString;
        //string str = ConfigurationManager.ConnectionStrings["sqlcon2"].ConnectionString;
        SqlConnection con = new SqlConnection(str);
        con.Open();
        return con;
    }
}