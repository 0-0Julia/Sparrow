<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="Birds_Guide.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form  runat="server" style="width:70%; align-items:center" class="form">
        <fieldset class="">

        <legend><%=title %></legend>
          
         <label>Description:<asp:FileUpload Id="baseimg" runat="server" /></label>   
        <textarea Id="desc" name="desc" maxlength="4000" style="width: 100%; height: 142px;"><%=des%></textarea><p style="color:red"></p>
                                                     
            
             <label>Care:<asp:FileUpload Id="first" runat="server"/></label>   
        <textarea required Id="care" name="care" maxlength="8000" style="width: 100%; height: 142px;"><%=care %></textarea><p style="color:red"     ></p>
         

             <label>Illnesses:<asp:FileUpload Id="second" runat="server"/></label>   
        <textarea required Id="ill" name="ill" maxlength="4000" style="width: 100%; height: 142px;"><%=ill %></textarea><p style="color:red" ></p>
                                                    
                   
            <label>How to choose?<asp:FileUpload Id="third" runat="server"/></label>   
        <textarea required Id="choo" name="choo" maxlength="4000" style="width: 100%; height: 142px;"><%=cho %></textarea><p style="color:red" > </p>
        
                                                                                           
            <label>Fun Facts:<asp:FileUpload Id="forth" runat="server"/></label>   
        <textarea required Id="fact" name="fact" maxlength="4000" style="width: 100%; height: 142px;"><%=fact %></textarea><p style="color:red"></p>
        
        <asp:Button Id="post" runat="server" onclick="post_Click" Text="Upload the Post" />
   </fieldset> </form>
</asp:Content>
