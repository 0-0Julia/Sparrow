<%@ Page Title="Birds Posts" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="postpage.aspx.cs" Inherits="Birds_Guide.canary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
.body {
    background-color: #43240c;
    font-family: 'Simonetta', cursive;
    color: white;
    font-size: 16px;
    text-align:left;
}

h1 {
	font-size: 64px;
}

p {
	font-size: 1em;
	font-weight: 300;
	margin: 42px 0;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="body">
<article>
	<h1 class="main-title"><%=title %></h1>
    <div class="hero-image">
	<img src="<%=BaseImgPath %>" alt="" class="Post__image" style="overflow:hidden;width:100%;"/><br />
    </div>
    <br />
    <br />
    <h2>DESCRIPTION</h2>
            <div style="width:100%;">
                <%=description %><br />
            </div><br />
    	<h2>CARE</h2>
    <%if (FirstImgPath != "pictures/postPic/")//aka its not empty
            Response.Write("<img src='"+FirstImgPath+"' alt='' class='editorial-image-left'/>");
        %>
    <div style="width:100%;">
                <%=care %><br />
    </div>    <br />
    <br />
    	<h2>SYMPTOMS OF ILLNESS</h2>
    <%if (SecondImgPath != "pictures/postPic/")
            Response.Write("<img src='"+SecondImgPath+"' alt='' class='editorial-image-left'/>");
        %>    <div style="width:100%;">
                <%=illness %><br /><br />
    </div>	
        <h2>FUN FACTS</h2>
    <%if (ThirdImgPath != "pictures/postPic/")
            Response.Write("<img src='"+ThirdImgPath+"' alt='' class='editorial-image-left'/>");
        %>    <div style="width:100%;">
                <%=facts %>    <br />
    <br />
    </div>
    	<h2>HOW TO CHOOSE A HEALTHY <b><%=title %></b></h2>
    <%if (ForthImgPath != "pictures/postPic/")
            Response.Write("<img src='"+ForthImgPath+"' alt='' class='editorial-image-left'/>");
        %>    <div style="width:100%;">
            <%=choose %>
            <p class="main-title"><small>Uploaded At: <%=DateT %></small></p>
           
            <br /><br /><br /><br />
            <%=ed %>
            

</div>
</article> 
<div class="actionBox"> 
        <form class="form-inline" role="form" runat="server">
           <div class="formp"> <div class="form-group" style="width:40%;">

           <asp:TextBox ID="commcContent" runat="server" class="input" style="width:100%" type="text" placeholder="Write Something... " /><asp:button width="50px" runat="server" id="comment" onclick="Button1_Click" text="Add" />
                <%=mes%> 

              </div>
           </div>
        </form>
        <ul class="commentList">
            <asp:label id="box" runat="server" Visible="true"/>
        </ul>
        
    </div>
        </div>
</asp:Content>
