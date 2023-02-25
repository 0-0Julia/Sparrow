using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace Birds_Guide
{
    public partial class update_profile : System.Web.UI.Page
    {
        DataTable dt;

        public string username;
        public string message = "";
        public string email;
        public string phone;
        public string country;
        public string gender;
        public string password;
        public string prevname;
        public string Imgpath;

        private string prevEmail;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["username"] == null) //checks user
                Response.Redirect("Homepage.aspx");
            prevname = (string)Session["username"];
            DataFromUser();

            if (Request.Form["Update"] != null)
            {
                newDataFromUser();
                if (!CheckUsername() && !CheckEmail())
                {
                    MyAdoHelper.UpdateUsersTbl(password, prevname, country, username, gender, email, phone);
                    Session["username"] = username;
                    HttpCookie cookies = Request.Cookies["cookies"];
                    cookies["usernameC"] = username;
                    cookies["passwordC"] = password;
                    DataFromUser();
                }
            }
            if(Request.Form["Delete"] != null && Session["admin"] != null)
               DeleteAcc();
        }
        private void DataFromUser()
        {
            dt = MyAdoHelper.ExecuteDataTable_oneClue("Username", (string)Session["username"]);
            username = (string)dt.Rows[0]["Username"];
            password = (string)dt.Rows[0]["FldPassword"];
            phone = (string)dt.Rows[0]["Phone"];
            gender = (string)dt.Rows[0]["Gender"];
            country = (string)dt.Rows[0]["Country"];
            prevEmail = (string)dt.Rows[0]["Email"];
            email = (string)dt.Rows[0]["Email"];
            if (dt.Rows[0]["ProfilePath"] != null)
                Imgpath = (string)dt.Rows[0]["ProfilePath"];
            else
                Imgpath = "default.png";
        }
        private void newDataFromUser()
        {
            password = Request.Form["password"];
            username = Request.Form["username"];
            phone = Request.Form["phone"];
            gender = Request.Form["gender"];
            country = Request.Form["country"];
            email = Request.Form["email"];
            if (image.HasFile)
            {
                string filePath = Server.MapPath("pictures/profilePic/" + System.Guid.NewGuid() + Path.GetExtension(image.FileName));
                image.SaveAs(filePath);
                int getPos = filePath.LastIndexOf("\\");
                int len = filePath.Length;
                Imgpath = filePath.Substring(getPos, len - getPos).Remove(0, 1);
                MyAdoHelper.Profile((int)dt.Rows[0]["Id"], Imgpath);
            }
        }

        private bool CheckUsername()//check username existence
        {
            if (Request.Form["username"] == (string)Session["username"])
                return true;
            if (MyAdoHelper.IsExist("Username", Request.Form["username"]))
            {
                message = "*A user with the same username already exists*";
                return true;
            }
            return false;
        }
        private bool CheckEmail()//check if the email already exists
        {
            if (MyAdoHelper.IsExist("Email", Request.Form["email"]))//check email existense
            {
                if (email != prevEmail)
                {
                    if (message != "")
                        message += "\n*A user connected to the same email already exist*";
                    else
                        message = "*A user connected to the same email already exist*";

                    return true;
                }
            }
            
            return false;
        }
        private void DeleteAcc()//delet a user and all of the info behind him
        {
            MyAdoHelper.Delete((string)Session["username"]);
            Session.Abandon();
            
            Application.Lock();
            Application["userCount"] = (int)Application["userCount"] - 1;
            Application.UnLock();
            HttpCookie cookies = Request.Cookies["cookies"];
            cookies.Expires = DateTime.Now.AddMinutes(-10);
            Response.Redirect("Homepage.aspx");
        }
    }
}