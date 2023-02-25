using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Birds_Guide
{
    public partial class List : System.Web.UI.Page
    {
        public string st;
        static DataTable img;
        static DataTable content;
        protected void Page_Load(object sender, EventArgs e)
        {
            img = MyAdoHelper.ExecuteAllBirdsImg();
            ListLoad();
        }
        protected void ListLoad()
        {
            for (int i = 0; i < img.Rows.Count; i++)
            {
                st += "<div class='collections'>";
                st += "<div class='collection-item-outer'>";
				st += "<div class='collection-item'>";
                st += "<img src = 'pictures/postPic"+img.Rows[i]["BaseImg"]+"' alt='an image of "+img.Rows[i]["BirdName"]+"' />";
                st += "<div class='collection-text'>";
				st += "<h3>"+img.Rows[i]["BirdName"]+"</h3>";
                content = MyAdoHelper.ExecuteBirdsContent((string)img.Rows[0]["BirdName"]);
                st += "<p class='List_p'>"+content.Rows[0]["DescriptionT"]+"</p>";
                st += "<button> Read More...</button></div></div></div></div>";
            }
        }
    }
}