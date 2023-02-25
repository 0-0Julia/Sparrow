using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Birds_Guide
{
    public partial class Log_out : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("HomePage.aspx");
            Session.Abandon();

            Application.Lock();
            Application["userCount"] = (int)Application["userCount"] - 1;
            Application.UnLock();
            HttpCookie cookies = Request.Cookies["cookies"];
            cookies.Expires = DateTime.Now.AddMinutes(-10);
            Response.Redirect("HomePage.aspx");            
        }
        
    }
}