using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Birds_Guide
{
    
    public partial class SignIn : System.Web.UI.Page
    {
        DataTable dt;
        private string username, password;
        public string message = "";
        public string usernamefield;
        public string passwordfield;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
                Response.Redirect("HomePage.aspx");
            else 
            {
                HttpCookie cookies = Request.Cookies["cookies"];
                if (cookies != null)
                {
                    passwordfield = cookies["passwordC"];
                    usernamefield = cookies["usernameC"];
                }
            }          

            if (Request.Form["submit"] != null)
            {
                GetDataFromUser();
                GetDataTableFromDataBase();

                if (dt.Rows.Count ==0)
                    message = "wrong username or password, please try again";
                else
                {
                    Session["username"] = username;
                    
                    if(MyAdoHelper.IsAdmin((string)Session["username"]))
                         Session["admin"] = 1;
                    if (MyAdoHelper.IsWriter((string)Session["username"]))
                        Session["writer"] = 1;
                    Application.Lock();
                    if (Application["userCount"] == null)
                        Application["userCount"] = 0;
                    Application["userCount"] = (int)Application["userCount"] + 1;
                    Application.UnLock();
                    
                    HttpCookie cookies = new HttpCookie("cookies");
                    cookies["usernameC"] = username;
                    cookies["passwordC"] = password;
                    cookies.HttpOnly = true;
                    cookies.Secure = true;
                    Response.Cookies.Add(cookies);
                    Response.Redirect("HomePage.aspx");
                }
            }
        }
        private void GetDataFromUser()
        {
            username = Request.Form["Username"];
            password = Request.Form["Password"];
        }
        private void GetDataTableFromDataBase()
        {
            dt = MyAdoHelper.MatchUser(username, password);
            
        }
    }
}