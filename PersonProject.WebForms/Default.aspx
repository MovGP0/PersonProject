<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="PersonProject.WebForms.Default" %>
<%@ Import Namespace="PersonProject.Model" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>All Persons</h1>
    <a href="Create.aspx">Create new Person</a>
    
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        <HeaderTemplate>
            <table>
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>&nbsp;</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <%# Eval("FirstName") %>
                </td>
                <td>
                    <%# Eval("LastName") %>
                </td>
                <td>
                    <a href="Details.aspx?id=<%# Eval("Id") %>">Details</a>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
                </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:People %>" SelectCommand="SELECT * FROM [People]"></asp:SqlDataSource>

</asp:Content>
