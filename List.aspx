<%@ Page Title="Our List Of Birds" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Birds_Guide.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="containerL">
			<h2 class="collection-title">Our List Of Birds <small>Only Quality Content</small></h2>
           <%=st %>
    </div>
</asp:Content>
