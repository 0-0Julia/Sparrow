<%@ Page Title="" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Birds_Guide.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JavaScript.js"></script>
    <script>
         function error()
         {
             alert("This access key is incorrect, insert enother value");
         }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <header>   
    <br /> 
        <h1>Managing Page</h1>
    <hr />
    <br />
    </header>
    <div style="text-align: center">
        <section>
        <table style="align-items:center; flex-wrap:wrap; font-size: 15px;">
          <tr><td colspan="8"></td></tr>
           <%=st %> 
                  </table>      
        <hr />
        <br />
        </section>
    </div>
</asp:Content>
