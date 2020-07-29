<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaut.aspx.cs" Inherits="WebApp_Client.Defaut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="GetButton" Text="Get" Width="100px" OnClick="GetButton_Click"/>
            <asp:Button runat="server" ID="PostButton" Text="Post" Width="100px" OnClick="PostButton_Click"/>
            <asp:Button runat="server" ID="PutButton" Text="Put" Width="100px" OnClick="PutButton_Click"/>
        </div>
    </form>
</body>
</html>
