using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;


namespace Birds_Guide
{
    public partial class canary : System.Web.UI.Page
    {
        public string ed="";
        public static int replytocomm = -1;
        public string mes;
        static DataTable Post;
        static DataTable Content;
        static DataTable Img;
        public string title;
        public string Author;
        public string DateT;
        public string description;
        public string care;
        public string illness;
        public string choose;
        public string facts;
        public string BaseImgPath;
        public string FirstImgPath;
        public string SecondImgPath;
        public string ThirdImgPath;
        public string ForthImgPath;
        public string edit = "";
        public int id;
        public string comments;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["title"] != null && Request.QueryString["i"] != null)
            {
                title = Request.QueryString["title"];
                id = int.Parse(Request.QueryString["i"]);
                GetData(title);
            }
            else
                Response.Redirect("HomePage.aspx");
            if (Session["username"] == null)
            {
                mes = "<a class='underline-animation' href='SignUp.aspx'>Sign up</a> for free and join our community today! already have an account? <a class='underline-animation' href='SignIn.aspx'>Sign in here</a>";
                commcContent.Visible=false;
                comment.Visible = false;
                box.Visible = true;
            }
            printComments(MyAdoHelper.ExecuteComments(id));
            if(Session["admin"]!=null || (string)Session["username"] == MyAdoHelper.GetUsernameById((int)MyAdoHelper.ExecuteBirdsListByName(title).Rows[0]["Author_Id"]))
            {
                ed= String.Format("<a ID='editb' name='editb' role='button' href='{0}'>Edit..<i class='fa-solid fa-pencil'></i></a><form id='delP' method='POST'><input type='hidden' value='{1}'/><button  name='delete' id='delete' type='submit'> Delete <i class='fa-regular fa-trash-can'></i></button></form>", "EditPost.aspx?title=" + title, title);
            }

            if (Request.Form["editb"] != null)
                Response.Redirect("EditPost.aspx?title=" + title);
            if (Request.Form["delete"] != null)
            {
                MyAdoHelper.DeletePost(title);
            }

            //comment delete and reply listeners
            if (Request.Form["SubmitReply"] != null)
            {
                replytocomm = int.Parse(Request.Form["IdTo"]);
                commcContent.Attributes.Add("placeholder", "Replying to @"+MyAdoHelper.GetUsernameById(int.Parse(Request.Form["IdTo"]))+"...");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Replying to'"+ int.Parse(Request.Form["IdTo"]) + ");", true);

            }

            if (Request.Form["del"] != null)
            {
                MyAdoHelper.DeleteComm(int.Parse(Request.Form["del2"])); 
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Comment deleted successfuly');", true);
                Response.Redirect("postpage.aspx?title=" + title+"&i="+id);
            }
        }
        private void GetData(string name)
        {
            Post = MyAdoHelper.ExecuteBirdsListByName(name);
            Content = MyAdoHelper.ExecuteBirdsContent(name);
            Img = MyAdoHelper.ExecuteBirdsImg(name);
            int id = (int)Post.Rows[0]["Author_Id"];
            Author = MyAdoHelper.GetUsernameById(id);
            ExecuteInfo();
        }
        private void ExecuteInfo()
        {
            description = (string)Content.Rows[0]["DescriptionT"];
            care = (string)Content.Rows[0]["CareT"];
            illness = (string)Content.Rows[0]["IllnessT"];
            choose = (string)Content.Rows[0]["ChooseT"];
            facts = (string)Content.Rows[0]["Fact"];
            Author = "Author: " + Author;
            DateT = "Release Date: " + Post.Rows[0]["DateT"].ToString() + "<br/>";
            BaseImgPath = "pictures/postPic/" + (string)Img.Rows[0]["BaseImg"];
            FirstImgPath  ="pictures/postPic/"+ (string)Img.Rows[0]["FirstImg"];
            SecondImgPath ="pictures/postPic/"+ (string)Img.Rows[0]["SecondImg"];
            ThirdImgPath = "pictures/postPic/"+ (string)Img.Rows[0]["ThirdImg"];
            ForthImgPath = "pictures/postPic/"+ (string)Img.Rows[0]["ForthImg"];
        }
        protected void printComments(DataTable dt)
        {
            DataTable userDT;
            if (dt.Rows.Count != 0)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((int)dt.Rows[i]["ReplyTo"] == -1)
                    {
                        userDT = MyAdoHelper.ExecuteUsersTblById((int)dt.Rows[i]["User_Id"]);
                        string path = Convert.ToString(userDT.Rows[0]["ProfilePath"]);
                        if(path=="")
                            path= "default.png";
                        if (Session["username"] == null)
                            box.Text += "<li><div class='commenterImage'> <img id='img' src='pictures/profilePic/" + path + "' /></div><b>" + userDT.Rows[0]["Username"] + ":</b><div class='commentText'><p> " + dt.Rows[i]["Content"] + "</p> <span class='date sub-text'>on " + dt.Rows[i]["datefld"] + "</span></div></li>";
                        else
                        {
                            if (Session["admin"] != null || (string)Session["username"]== (string)userDT.Rows[0]["Username"])
                                box.Text += "<li><div class='commenterImage'> <img id='img' src='pictures/profilePic/" + path + "' /></div><b>" + userDT.Rows[0]["Username"] + ":</b><div class='commentText'><p> " + dt.Rows[i]["Content"] + "</p> <span class='date sub-text'>on " + dt.Rows[i]["datefld"] + "</span> <form action='' method='POST'><input type='hidden' name='IdTo' value='" + dt.Rows[i]["Id"] + "'/><button type='submit' name='SubmitReply'>Reply</button></form><form method='POST'><input type='hidden' name='del2' value='" + dt.Rows[i]["Id"] + "'/><button type='submit' name='del'><i class='fa-regular fa-trash-can'></i></button></form></div></li>";
                            else                                                                                                                                                                                                                                                                                                                                                                                                                       
                                box.Text += "<li><div class='commenterImage'> <img id='img' src='pictures/profilePic/" + path + "' /></div><b>" + userDT.Rows[0]["Username"] + ":</b><div class='commentText'><p> " + dt.Rows[i]["Content"] + "</p> <span class='date sub-text'>on " + dt.Rows[i]["datefld"] + "</span> <form action='' method='POST'><input type='hidden' name='IdTo' value='" + dt.Rows[i]["Id"] + "'/><button type='submit' name='SubmitReply'>Reply</button></form></div></li>";

                        }

                        printreplies(dt, i);
                    }
                }
        }
        protected void printreplies(DataTable dt, int i)
        {
            DataTable userDT;
            DataTable userDTR;

            for (int pos = i + 1; pos < dt.Rows.Count; pos++)
            {
                if ((int)dt.Rows[pos]["ReplyTo"] == (int)dt.Rows[i]["Id"])
                {
                    userDTR = MyAdoHelper.ExecuteUsersTblById((int)dt.Rows[pos]["User_Id"]);
                    userDT = MyAdoHelper.ExecuteUsersTblById((int)dt.Rows[i]["User_Id"]);

                    string path = Convert.ToString(MyAdoHelper.ExecuteUsersTblById((int)dt.Rows[pos]["User_Id"]).Rows[0]["ProfilePath"]);
                    if (path == "")
                        path = "default.png";
                    if (Session["username"]==null)
                        box.Text += "<li><div class='commenterImage'> <img name='img' src='pictures/profilePic/" + path + "' /></div><b>" + userDTR.Rows[i]["Username"] + "</b>:<div class='commentText'><p><a>@" + userDT.Rows[0]["Username"] + "</a>, " + dt.Rows[pos]["Content"] + "</p> <span class='date sub-text'>on " + dt.Rows[pos]["datefld"] + "</span> </div></li>";
                    else
                    {
                        if (Session["admin"] != null || (string)Session["username"] == (string)userDT.Rows[0]["Username"])
                            box.Text += "<li><div class='commenterImage'> <img name='img' src='pictures/profilePic/" + path + "' /></div><b>" + userDTR.Rows[i]["Username"] + "</b>:<div class='commentText'><p><a>@" + userDT.Rows[0]["Username"] + "</a>, " + dt.Rows[pos]["Content"] + "</p> <span class='date sub-text'>on " + dt.Rows[pos]["datefld"] + "</span> <form action='' method='POST'><input type='hidden' name='IdTo' value='" + dt.Rows[i]["Id"] + "'/><button type='submit' class'btn' name='SubmitReply'>Reply</button></form><Form method='POST'><input type='hidden' name='del2' value='" + dt.Rows[i]["Id"]+"'/><button type='submit' name='del'><i class='fa-regular fa-trash-can'></i></button></form></div></li>";
                        else                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
                            box.Text += "<li><div class='commenterImage'> <img name='img' src='pictures/profilePic/" + path + "' /></div><b>" + userDTR.Rows[0]["Username"] + "</b>:<div class='commentText'><p><a>@" + userDT.Rows[0]["Username"] + "</a>, " + dt.Rows[pos]["Content"] + "</p> <span class='date sub-text'>on " + dt.Rows[pos]["datefld"] + "</span> <form action='' method='POST'><input type='hidden' name='IdTo' value='" + dt.Rows[i]["Id"] + "'/><button type='submit' class'btn' name='SubmitReply'>Reply</button></form></div></li>";
                    }
                    printreplies(dt, pos);
                }
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)//!
        {
            Console.WriteLine((string)Session["username"]);
            int UserId =  (int)MyAdoHelper.ExecuteUser((string)Session["username"]).Rows[0]["Id"];
            MyAdoHelper.InsertComm(replytocomm,id, UserId, commcContent.Text,false);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Comment saved successfuly');", true);
            box.Text = "";
            printComments(MyAdoHelper.ExecuteComments(id));
            commcContent.Text = "";
        }
    }
}