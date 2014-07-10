<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="PersonProject.WebForms.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="row">
        <asp:Label ID="FirstNameLabel" runat="server" Text="First Name" CssClass="col-md-4"></asp:Label>
        <asp:TextBox ID="FirstNameTextBox" runat="server" CssClass="col-md-8" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="row">
        <asp:Label ID="LastNameLabel" runat="server" Text="LastName" CssClass="col-md-4"></asp:Label>
        <asp:TextBox ID="LastNameTextBox" runat="server" CssClass="col-md-8" ReadOnly="true"></asp:TextBox>
        </div>
    </div>
    <a href="Default.aspx">Back</a>
</asp:Content>