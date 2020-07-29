<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="lab_01.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <br />
    <asp:TextBox ID="textBox" runat="server"></asp:TextBox>
    <asp:Button ID="button" runat="server" Text="Click" OnClick="button_Click"/><br />
    <asp:Label ID="viewStateLabel" runat="server"></asp:Label><br /><br />
    <asp:Label ID="label" runat="server"></asp:Label><br /><br /><br />    
    <asp:Label ID="form_events" runat="server"></asp:Label><br />
    <asp:CheckBox runat="server" ID="checkbox" OnCheckedChanged="checkbox_CheckedChanged" AutoPostBack="true" /><br />
    <asp:Label ID="checkbox_label" runat="server"></asp:Label>
    
    <hr />
</asp:Content>
    