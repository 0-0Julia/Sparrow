using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Birds_Guide
{
    public partial class AddUser : System.Web.UI.Page
    {
        public string message;
        public string username;
        public string email;
        public string phone;
        public string password;
        public string country;
        public string gender;
        public string ImgPath;
        protected void Page_Load(object sender, EventArgs e)
        {
           //if (Session["admin"] == null)
           //    Response.Redirect("HomePage.aspx");

            if (Request.Form["add"] != null)
            message = "";
            username = Request.Form["username"];
            email = Request.Form["email"];
            phone = Request.Form["phone"];
            password = Request.Form["password"];
            country = Request.Form["country"];
            gender = Request.Form["gender"];

            if (image.HasFile)
            {
               ;
                Console.WriteLine(Path.GetExtension(image.FileName));
                string filePath = Server.MapPath("pictures/profilePic/" + System.Guid.NewGuid() + Path.GetExtension(image.FileName));
                image.SaveAs(filePath);
                int getPos = filePath.LastIndexOf("\\");
                int len = filePath.Length;
                string getPath = filePath.Substring(getPos, len - getPos);
                ImgPath = getPath.Remove(0, 1);

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
            if (message == "")
                AddWorker();
        }
        private void AddWorker()
        {
            MyAdoHelper.Add(country, username, gender, password, email, phone, int.Parse(Request.Form["accesskey"]),ImgPath);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('the user was added- go to <a href=AdminPage.aspx>admin page?</a>');", true);

        }
    }
}