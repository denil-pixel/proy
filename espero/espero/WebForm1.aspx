<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="espero.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="ddlFrutas">
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlFrutas" runat="server">
            <asp:ListItem Value="1">Manzana</asp:ListItem>
            <asp:ListItem Value="25">Pera</asp:ListItem>
            <asp:ListItem Value="3">xsx</asp:ListItem>
            <asp:ListItem Value="20">Guayaba</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnPrueba" runat="server" OnClick="btnPrueba_Click" Text="Prueba" />
        <asp:Label ID="lblSeleccionado" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblIndice" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblValor" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
