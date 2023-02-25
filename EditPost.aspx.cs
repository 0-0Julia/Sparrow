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
    public partial class EditPost : System.Web.UI.Page
    {
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
        public static string title;
        static DataTable img;
        static DataTable content;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["title"] != null)
            {
                title = Request.QueryString["title"];
            }
            else
                Response.Redirect("HomePage.aspx");

            int id = (int)MyAdoHelper.ExecuteBirdsListByName(title).Rows[0]["Author_Id"];
            if (Session["admin"] == null && (string)Session["username"] != MyAdoHelper.GetUsernameById(id))
                Response.Redirect("Homepage.aspx");
            content = MyAdoHelper.ExecuteBirdsContent(title);
            img = MyAdoHelper.ExecuteBirdsImg(title);
            des = (string)content.Rows[0]["DescriptionT"];
            ill = (string)content.Rows[0]["IllnessT"];
            fact =(string)content.Rows[0]["Fact"];
            cho  =(string)content.Rows[0]["ChooseT"];
            care =(string)content.Rows[0]["CareT"];
            title=(string)content.Rows[0]["BirdName"];
            baseimgPath =(string)img.Rows[0]["BaseImg"];
            firstimgPath = (string)img.Rows[0]["FirstImg"];
            secondimgPath = (string)img.Rows[0]["SecondImg"];
            thirdimgPath = (string)img.Rows[0]["ThirdImg"];
            forthimgPath = (string)img.Rows[0]["ForthImg"];

        }
        protected void post_Click(object sender, EventArgs e)
        {
            des = Request.Form["desc"];
            ill = Request.Form["ill"];
            fact = Request.Form["fact"];
            cho = Request.Form["choo"];
            care = Request.Form["care"];
            title = Request.Form["title"];

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
            MyAdoHelper.UpdatePost(title, des, care, ill, cho, fact, baseimgPath, firstimgPath, secondimgPath, thirdimgPath, forthimgPath);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Post was Edited successfuly');", true);
            Response.Redirect("HomePage.aspx");
        }
    }
}