<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><asp:Label ID="lUsuario" runat="server">Usuaio</asp:Label></td>
            <td><asp:TextBox ID="tbUsuario" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lClave" runat="server" Text="Clave"></asp:Label></td>
            <td><asp:TextBox ID="tbClave" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button ID="blogin" runat="server" Text="Entrar" OnClick="bloginClik" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
