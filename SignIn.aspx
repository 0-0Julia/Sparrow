<%@ Page  Title="Pets guide | Sign in" Language="C#" MasterPageFile="Site1.Master"  AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Birds_Guide.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> 
    <script src="JavaScript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header>
        <h1>SIGN IN</h1>
    </header>

    <div class="containerS">
     <fieldset>
            <legend>SIGN IN:</legend>
           <form class="form" runat="server">
             <%=message %>
                <label>Username:</label>
                    <input class="input" type="text" id="username" name="username" onchange="inputusername()"/>
                            <p id="UsernameP" class="pStyle"></p> 
               <label>Password:</label>
                        <input class="input" type="password" id="password" name="password" onchange="inputpassword()"/>
                               <p  id="PassP" class="pStyle""></p> 
              
              <br />  <label>
               show password<input type="checkbox" onclick="passwordTransform()"> 
             </label>
                <label style="color:snow">
                    <input class="btn add" type="submit" id="submit" name="submit" value="Sign In" onclick="return click()"/>
                </label>
                               <a href="SignUp.aspx" class="underline-animation" style="text-align:center;">doesn't have an account yet?</a><br />
               </form>
        </fieldset>  
     </div> 
</asp:Content>
