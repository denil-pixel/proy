<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vfUsuarios.aspx.cs" Inherits="WebApplication6.vfUsuarios" %>

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
            <td><asp:Label ID="lNombre" runat="server">Nombre</asp:Label></td>
            <td><asp:TextBox ID="tbNombre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lUsuario" runat="server" Text="Usuario"></asp:Label></td>
            <td><asp:TextBox ID="tbUsuario" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
                 <td><asp:Label ID="lClave" runat="server" Text="Clave"></asp:Label></td>
            <td><asp:TextBox ID="tbCave" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
        <tr>
            <td><asp:Label ID="lCargo" runat="server" Text="Cargo"></asp:Label></td>
            <td><asp:DropDownList ID="ddlCargo" runat="server"></asp:DropDownList></td>

                   </tr>
            <tr>
                <
            </tr>
        <tr>
            <td colspan="2"><asp:Button ID="bRegistrar" runat="server" Text="Registrar" OnClick="bRegistarClik" /></td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
