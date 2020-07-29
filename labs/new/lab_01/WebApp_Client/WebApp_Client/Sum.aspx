<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="WebApp_Client.Sum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="http://localhost:8078/sum.kvo">
        <div>
            <input name="x" type="number"/>
            <input name="y" type="number" />
            <button type="submit"></button>
        </div>
    </form>
</body>
</html>
