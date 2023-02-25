using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Sparrow
{
    public partial class Foundation : System.Web.UI.MasterPage
    {
        public int usercount;
        public string Home = "";
        public string Aviary = "";
        public string Exotic = "";
        static DataTable dt;
        static DataTable userdt;
        public int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.UnLock();
            if (Application["userCount"] == null)
                Application["userCount"] = 0;
            usercount = (int)Application["userCount"];
            Application.Lock();
            if (Session["username"] != null)
                userdt = MyAdoHelper.ExecuteUser((string)Session["username"]);
            dt = MyAdoHelper.ExecuteBirdsList("Home");
            if (dt.Rows.Count >= 5)
                Home = GetInfo("Home");
            else
                Home = Regular();
            dt = MyAdoHelper.ExecuteBirdsList("Farm");
            if (dt.Rows.Count >= 5)
                Aviary = GetInfo("Farm");
            else
                Aviary = Regular();
            dt = MyAdoHelper.ExecuteBirdsList("Exotic");
            if (dt.Rows.Count >= 5)
                Exotic = GetInfo("Exotic");
            else
                Exotic = Regular();

        }
        private static string Regular() { return "<br /><div class='navcontent'> <div><a class='underline-animation'>category</a><br /><a class='underline-animation'>category</a><br /><a class='underline-animation'>category</a></div><div><a class='underline-animation'>category</a><br /><a class='underline-animation'>category</a><br /><a href = 'List.aspx' class='underline-animation'>-Read More-</a></div></div><br />"; }
        private static string GetInfo(string name)
        {
            string st = "<br/><div class='navcontent'><div>";
            int i = 0;
            for (; i < 3; i++)
            {
                st += "<a href='postpage.aspx?title=" + (string)dt.Rows[i]["BirdName"] + "&i=" + dt.Rows[i]["Id"] + "' class='underline-animation'>" + (string)dt.Rows[i]["BirdName"] + "</a><br/>";
            }
            st += "</div><div>";
            for (i = 3; i < 5; i++)
            {
                st += "<a href='postpage.aspx?title=" + (string)dt.Rows[i]["BirdName"] + "&i=" + dt.Rows[i]["Id"] + "' class='underline-animation'>" + (string)dt.Rows[i]["BirdName"] + "</a><br />";
            }
            st += "<a href='BirdList.aspx' class='underline-animation'>-Read More-</a></div></div><br />";
            return st;
        }
    }
}