<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="s.aspx.cs" Inherits="WebApplication3.s" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr><th>Area</th><td><input type="text" id="tArea" runat="server" /></td></tr>
         
            <tr><th>Lado</th><td><input type="text" id="tLado" runat="server" /></td></tr>
       <asp:Label ID="label" runat="server" Text="Area"></asp:Label>
           
        </table>

    </div>
    </form>
</body>
</html>
