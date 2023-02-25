<%@ Page Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="Birds_Guide.Forum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Our Comunity Forum</title>
    <style>
        h2 span{
            font-size: 10px;
            color:gray;
        }

        container2{
            width:90%;
            background-color:rgb(60 60 60 / 0.85);
            align-items:center;
            height:80%;
        }

        question_content{
            color:dimgray;
            border-color:aliceblue;
            border-radius:5px;
            overflow:hidden;
            height:10%;

        }

        table{
            align-items:center;
            flex-wrap:wrap;
            font-size: 15px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div><header>Forum Questions</header>
            <table>
                <tbody>
               <tr class="container2">
                   <td>
                       <div><h2>Question Header <span> *publiched two days ago*</span></h2><i>Status</i>
                           <div class="question_content">
                              <p> 
                                  content.....
                              </p>
                              <div>comments counter</div>
                           </div>
                       </div>
                   </td>
                   <td>
                       <div><h2>how to not stress out a bird when cleaning its cage <span> *publiched two days ago*</span></h2><i>Answered</i>
                           <div style="overflow:hidden;">
                              <p class="question_content"> 
                                 i have a canary three years already but every time i clean his cage he gets pretty stressed so i was 
                                 searching what can i use so that he does not feels so stresed all the time.. any suggestions?
                              </p>
                              <div>this post has \\7 comments\\</div>
                           </div>
                       </div>
                   </td>
                    <td>
                       <div><h2><a href="Question_View.aspx?title=\\title">how to not stress out a bird when cleaning its cage </a><span> *publiched two days ago*</span></h2><i>Answered</i>
                           <div style="overflow:hidden;">
                              <p class="question_content"> 
                                 i have a canary three years already but every time i clean his cage he gets pretty stressed so i was 
                                 searching what can i use so that he does not feels so stresed all the time.. any suggestions?
                              </p>
                              <div>this post has \\1 comment\\</div>
                           </div>
                       </div>
                   </td>
               </tr>
                </tbody>
             </table>
        </div>
</asp:Content>
