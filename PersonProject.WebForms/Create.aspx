<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="PersonProject.WebForms.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="container">

        <div class="row">
            <asp:Label ID="FirstNameLabel" runat="server" Text="First Name" CssClass="col-md-4"></asp:Label>
            <asp:TextBox ID="FirstNameTextBox" runat="server" CssClass="col-md-8"></asp:TextBox>
            <asp:RequiredFieldValidator ID="FirstNameRequiredValidator" runat="server" ControlToValidate="FirstNameTextBox"
                ErrorMessage="First Name is required!" CssClass="col-md-12 has-error" Display="Dynamic"></asp:RequiredFieldValidator>
            
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="FirstNameTextBox"
                ErrorMessage="First Name must have at least 2 characters." ValidationExpression=".{2}.*"  CssClass="col-md-12 has-error" Display="Dynamic"></asp:RegularExpressionValidator>
            
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorMax255" runat="server" ControlToValidate="FirstNameTextBox"
                ErrorMessage="First Name must have less than 256 characters." ValidationExpression=".{0,255}"  CssClass="col-md-12 has-error" Display="Dynamic"></asp:RegularExpressionValidator>

        </div>

        <div class="row">
            <asp:Label ID="LastNameLabel" runat="server" Text="LastName" CssClass="col-md-4"></asp:Label>
            <asp:TextBox ID="LastNameTextBox" runat="server" CssClass="col-md-8"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="LastNameValidator" runat="server" ControlToValidate="LastNameTextBox"
                ErrorMessage="Last Name is required!" CssClass="col-md-12 has-error" Display="Dynamic"></asp:RequiredFieldValidator>
            
            <asp:RegularExpressionValidator ID="LastNameMinTwoCharactersValidator" runat="server" ControlToValidate="LastNameTextBox"
                ErrorMessage="Last Name must have at least 2 characters." ValidationExpression=".{2}.*" CssClass="col-md-12" Display="Dynamic"></asp:RegularExpressionValidator>
            
            <asp:RegularExpressionValidator ID="LastNameMax255CharactersValidator" runat="server" ControlToValidate="LastNameTextBox"
                ErrorMessage="Last Name must have less than 256 characters." ValidationExpression=".{0,255}" CssClass="col-md-12 has-error" Display="Dynamic"></asp:RegularExpressionValidator>

    </div>
    <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
    <a href="Default.aspx">Back</a>
</asp:Content>
