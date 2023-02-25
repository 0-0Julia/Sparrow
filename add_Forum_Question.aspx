<%@ Page Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="add_Forum_Question.aspx.cs" Inherits="Birds_Guide.add_Forum_Question" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Our Comunity Forum</title>
    <style>

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id="form1">
        <label>Title:
            <input type="text" Id="Title" name="Title"  placeholder="insert your question..." required="required" maxlength="100"/>
        </label>
        <label>Content:
        <textarea required Id="Content" name="Content" placeholder="Describe your question in more detail..." maxlength="7000" style="width: 406px; height: 142px;"></textarea><p style="color:red" ></p><br />
        </label>
        <asp:Button runat="server" ID="submit" Text="Upload The Question"/>
    </form>
</asp:Content>
