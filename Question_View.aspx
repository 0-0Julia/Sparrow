<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Question_View.aspx.cs" Inherits="Birds_Guide.Question_View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>how to not stress out a bird when cleaning its cage?<span> *publiched two days ago*</span></h1>
    
    <div><h2>Question Header <span> *publiched two days ago*</span></h2><i>Status</i>
        <div class="question_content">
           <p> 
              i have a canary three years already but every time i clean his cage he gets pretty stressed so i was 
              searching what can i use so that he does not feels so stresed all the time.. any suggestions?
              what i was doing for the last three years is making him go to the other-smaller cage, clean the main cage and return him back to his cage.
              but he's not used for handes or trained so i just have to tap the back of a cage so he will go through the opening straight to the second cage
              without me touching him and still i feel like this method is bringing him stress;
           </p>
        </div> <i>Answered</i>
    <form runat="server">
        butten
    </form>
    </div>
    <div class="actionBox"> 
        <form class="form-inline" role="form" runat="server">
           <div class="formp"> <div class="form-group" style="width:40%;">

           <asp:TextBox ID="commcContent" runat="server" class="input" style="width:100%" type="text" placeholder="Write Something... " /><asp:button width="50px" runat="server" id="comment" onclick="Button1_Click" text="Add" />
               *comments*

              </div>
           </div>
        </form>
        <ul class="commentList">
            <asp:label id="box" runat="server" Visible="true"/>
        </ul>
        
    </div>              
</asp:Content>
