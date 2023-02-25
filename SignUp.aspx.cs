using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Birds_Guide
{
    public partial class SignUp : System.Web.UI.Page
    {
        public string message;
        private string fileName;
        private string filePath;
        private string getPath;
        private string pathToStore;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null) //checks user
                Response.Redirect("Homepage.aspx");

            if (Request.Form["submit"] != null)
            {
                message = "";
                string username = Request.Form["username"];
                string email = Request.Form["email"];
                string phone = Request.Form["phone"];
                string password = Request.Form["password"];
                string country = Request.Form["country"];
                string gender = Request.Form["gender"];

                if (image.HasFile)
                {
                    fileName = Path.GetExtension(image.FileName);
                    Console.WriteLine(fileName);
                    filePath = Server.MapPath("pictures/profilePic/" + System.Guid.NewGuid() + fileName);
                    image.SaveAs(filePath);
                    int getPos = filePath.LastIndexOf("\\");
                    int len = filePath.Length;
                    getPath = filePath.Substring(getPos, len - getPos);
                    pathToStore = getPath.Remove(0, 1);
                    
                }

                if (MyAdoHelper.IsExist("FldUsername", username))
                    message = "*A user with the same username already exists*";
                
                if (MyAdoHelper.IsExist("FldEmail", email))//check email existense
                {
                    if (message != "")
                        message += "\n*A user connected to the same email already exist, <a href='SignIn.aspx'><div class='btn fontsize'>sign in?</a>*";
                    else
                        message = "*A user connected to the same email already exist, <a href='SignIn.aspx' class='underline-animation'>sign in?</a>*";
                }
                if(message=="")
                {
                    MyAdoHelper.Add(country, username,gender,password,email,phone,1, pathToStore);
                    Session["username"] = username;
                    Application.Lock();
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
    }
}
