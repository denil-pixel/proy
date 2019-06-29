<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actividad.aspx.cs" Inherits="examen.Actividad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CREAR</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table >
        
            <tr>
                <td><asp:Label ID="lCriterio" runat="server">Criterio</asp:Label></td>
        
                <td><asp:TextBox ID="tbCriterio" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lDescripcion" runat="server">Valor</asp:Label></td>
                <td><asp:TextBox ID="tbValor" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lPuntaje" runat="server">Puntaje</asp:Label></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="bRegistrar" runat="server" Text="Modificar" OnClick="bRegistrar_Click"/></td>
            </tr>
            </table>
    </div>
    </form>
</body>
</html>
