using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Birds_Guide
{

    public partial class AddPost : System.Web.UI.Page
    {
        public int author_id;
        public string des;
        public string care;
        public string ill;
        public string cho;
        public string fact;
        public string baseimgPath;
        public string firstimgPath;
        public string secondimgPath;
        public string thirdimgPath;
        public string forthimgPath;
        public string category;
        public string title;
        static DataTable userD;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null && Session["writer"] == null)
                Response.Redirect("Homepage.aspx");
        }

        protected void post_Click(object sender, EventArgs e)
        {
            userD = MyAdoHelper.ExecuteUser((string)Session["username"]);
            author_id = (int)MyAdoHelper.ExecuteUser((string)Session["username"]).Rows[0]["Id"];
            des = Request.Form["desc"];
            ill = Request.Form["ill"];
            fact = Request.Form["fact"];
            cho = Request.Form["choo"];
            care = Request.Form["care"];
            category= Request.Form["category"];
            title= Request.Form["title"];
            if (baseimg.HasFile)
            {
                string basefilePath = Server.MapPath("pictures/postPic/" + System.Guid.NewGuid() + Path.GetExtension(baseimg.FileName));
                baseimg.SaveAs(basefilePath);
                baseimgPath = basefilePath.Substring(basefilePath.LastIndexOf("\\"), basefilePath.Length - basefilePath.LastIndexOf("\\")).Remove(0, 1);
            }
                
            if (first.HasFile)
            {
                string filePath = Server.MapPath("pictures/postPic/" + System.Guid.NewGuid() + Path.GetExtension(first.FileName));
                first.SaveAs(filePath);
                int getPos = filePath.LastIndexOf("\\");
                int len = filePath.Length;
                firstimgPath = filePath.Substring(getPos, len - getPos).Remove(0, 1);
            }
            if (second.HasFile)
            {
                string filePath = Server.MapPath("pictures/postPic/" + System.Guid.NewGuid() + Path.GetExtension(second.FileName));
                first.SaveAs(filePath);
                int getPos = filePath.LastIndexOf("\\");
                int len = filePath.Length;
                secondimgPath = filePath.Substring(getPos, len - getPos).Remove(0, 1);
            }
            if (third.HasFile)
            {
                string filePath = Server.MapPath("pictures/postPic/" + System.Guid.NewGuid() + Path.GetExtension(third.FileName));
                third.SaveAs(filePath);
                int getPos = filePath.LastIndexOf("\\");
                int len = filePath.Length;
                thirdimgPath = filePath.Substring(getPos, len - getPos).Remove(0, 1);
            }
            if (forth.HasFile)
            {
                string filePath = Server.MapPath("pictures/postPic/" + System.Guid.NewGuid() + Path.GetExtension(forth.FileName));
                forth.SaveAs(filePath);
                int getPos = filePath.LastIndexOf("\\");
                int len = filePath.Length;
                forthimgPath = filePath.Substring(getPos, len - getPos).Remove(0, 1);
            }
            MyAdoHelper.AddPost(title, des, care, ill, cho, fact, baseimgPath, firstimgPath, secondimgPath, thirdimgPath, forthimgPath, author_id, category);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Post was added successfuly');", true);
            Response.Redirect("HomePage.aspx");
        }
    }
}