<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddPost.aspx.cs" Inherits="Birds_Guide.AddPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  runat="server" style="width:70%; align-content:center" class="form">
        <fieldset class="">

        <legend>Title:</legend><input required class="input" Id="title" name="title" maxlength="50"/><p id="messege" style="color:red" ></p>

            <label>Base Image:<asp:FileUpload Id="baseimg" runat="server"/></label>
          
            <label>category </label><select id="category" name="category">
                <option id="Home" value="Home">Home</option>
                <option id="Farm" value="Farm">Farm</option>
                <option id="Exotics" value="Exotics">Exotics</option>
                                    </select><br />
         <label>Description:</label>   
        <textarea Id="desc" name="desc" maxlength="4000" style="width: 406px; height: 142px;"></textarea><p style="color:red"     ></p><br />
                                                     
            
             <label>Care:<asp:FileUpload Id="first" runat="server"/></label>   
        <textarea required Id="care" name="care" maxlength="8000" style="width: 406px; height: 142px;"></textarea><p style="color:red"     ></p><br />
         

             <label>secon image:<asp:FileUpload Id="second" runat="server"/></label> <label>Illnesses:</label>   
        <textarea required Id="ill" name="ill" maxlength="4000" style="width: 406px; height: 142px;"></textarea><p style="color:red" ></p><br />
                                                    
                   
            <label>How to choose?<asp:FileUpload Id="third" runat="server"/></label>   
        <textarea required Id="choo" name="choo" maxlength="4000" style="width: 406px; height: 142px;"></textarea><p style="color:red" > </p><br />
                                                                                           
            <label>Fun Facts:<asp:FileUpload Id="forth" runat="server"/></label>   
        <textarea required Id="fact" name="fact" maxlength="4000" style="width: 406px; height: 142px;"></textarea><p style="color:red"></p><br />
        
        <asp:Button Id="post" runat="server" onclick="post_Click" Text="Upload the Post" />
   </fieldset> </form>
</asp:Content>

