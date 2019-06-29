<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginWC.aspx.cs" Inherits="WebApplication2.loginWC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table border ="1";
            <tr><th><asp:lavel  ID="lUsuario" runat="server" Text ="Usuario "></asp:lavel>/></th>
                <td><asp:TextBox ID="tUsuario" runat="server"><</asp:TextBox></td></tr>
           <tr><th><asp:Label ID="lClave" runat ="server" Text="Contraseña"></asp:Label></th>
               <td><asp:TextBox ID="tbClave" runat="server"></asp:TextBox></td></tr>
           <tr><td colspan="2"><asp:Button runat="server" ID="bIngresar" Text="Entrar" /></td></tr>
    </table>
           </div>
    </form>
</body>
</html>
