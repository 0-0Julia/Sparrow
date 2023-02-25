using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public class MyAdoHelper{

	public MyAdoHelper(){}

    public static SqlConnection ConnectToDb()
    {
        string path = HttpContext.Current.Server.MapPath("App_Data/Database1.mdf");

        string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + path + "; Integrated Security = True";
        SqlConnection conn = new SqlConnection(connString);
        return conn;
    }

    public static void UpdateUsersTbl(string password, string prevname, string country, string username, string gender, string email, string phone)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec UserInfoUpdate '"+prevname+"','" + country+"','" +username+ "','" +phone+ "','"+email+ "','"+ gender + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static void Profile(int id, string img)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec ProfileUpdate '" + img + "','" + id + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static void UpdateAdmin( int id, string email, string phone, int accesskey)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec AdminUpdates '" + email + "','" + phone + "','" + accesskey + "','" + id + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static void Add(string country, string username, string gender, string password, string email, string phone, int accesskey, string ImgPath)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec AddUser '" + country + "','" + username + "','" + password + "','" + phone + "','" + email + "','" + gender + "','" + accesskey + "','" + ImgPath + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static void Delete(string username)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec DeleteUser '" + username + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    
    public static bool IsExist(string column, string str) 
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec IsExistCheck '" + column+"','"+str+"'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        if (dt.Rows.Count == 0)
            return false;
        return true;
    }
    public static bool IsAdmin(string username)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec IfAdmin '"+ username + "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        if (dt.Rows.Count == 0)
            return false;
        return true;
    }
    public static bool IsWriter(string username)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec IfWriter '" + username + "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        if (dt.Rows.Count == 0)
            return false;
        return true;
    }
    public static bool PostExist(string PostName)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec postSearch '" + PostName + "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        if (dt.Rows.Count == 0)
            return false;
        return true;
    }
    public static DataTable ExecuteUsersTbl()
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteUsersTbl",conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteUser(string name)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteUserByName '" + name + "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecutePost(string name)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecutePostByName '"+name+"'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static void AddPost(string name, string des, string care, string ill, string choo, string fact, string baseimg, string fimg, string simg, string timg, string foimg,int id, string category)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec AddPost '" + name + "','" + des + "','" + care + "','" + ill + "','" + choo + "','" + fact+"','"+ baseimg +  "','" + fimg + "','" + simg + "','" + timg + "','" + foimg + "','" + id + "','" + category + "','" + DateTime.Now+ "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static DataTable ExecuteUsersTblById(int id)//////////
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("select * from UserTb where Id=" + id, conn);
        SqlDataAdapter tableAdapter = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteComments(int id)/////////////
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("select * from Comments where Post_Or_forum_id='" + id+"'", conn);
        SqlDataAdapter tableAdapter = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteBirdsContent(string name)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteBirdsContent '"+name+"'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteBirdsImg(string name)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteBirdsImg '" + name + "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteAllBirdsImg()
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteAllBirdsImg", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static void InsertComm(int IdReply, int Post_id, int userId, string content, bool T_forum_F_Post) ///////
    { 
        SqlConnection conn = ConnectToDb();
        conn.Open();

        SqlCommand com = new SqlCommand("",conn);
        com.CommandText="INSERT INTO Comments(ReplyTo, Post_Or_forum_id, User_Id, datefld,Content,TypeOfPost) VALUES (@ReplyTo, @Post_Or_forum_id, @User_Id, @datefld,@Content,@TypeOfPost)";
        com.Parameters.AddWithValue("@ReplyTo", IdReply);
        com.Parameters.AddWithValue("@Post_Or_forum_id", Post_id);
        com.Parameters.AddWithValue("@User_Id", userId);
        com.Parameters.AddWithValue("@datefld", DateTime.Now);
        com.Parameters.AddWithValue("@Content", content);
        com.Parameters.AddWithValue("@TypeOfPost", T_forum_F_Post);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static DataTable ExecuteBirdsList(string category)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteBirdsList '" + category + "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteAllBirdsList()
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec ExecuteAllBirdsList", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteBirdsListByName(string name)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter= new SqlDataAdapter("exec ExecuteBirdsListByName '" + name + "'", conn);        
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static DataTable ExecuteDataTable_oneClue(string column, string str)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec IsExistCheck '" + column + "','" + str +  "'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }

    public static DataTable MatchUser(string name, string password)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec CheckUserExistense '" + name+"','" +password+"'", conn);
        SqlDataAdapter tableAdapter = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }
    public static String GetUsernameById(int id)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter("exec GetUserById '" + id +"'", conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return (string)dt.Rows[0]["Username"];
    }
    public static void UpdatePost(string name, string des, string care, string ill, string choo, string fact, string baseimg, string fimg, string simg, string timg, string foimg)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec UpdatePost '" + name + "','" + des + "','" + care + "','" + ill + "','" + choo + "','" + fact + "','" + baseimg + "','" + fimg + "','" + simg + "','" + timg + "','" + foimg + "','" + DateTime.Now + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static void DeletePost(string name) {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec DeleteArticle '" + name + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }
    public static void DeleteComm(int id) {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand("exec DeleteComm '" + id + "'", conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }


}
