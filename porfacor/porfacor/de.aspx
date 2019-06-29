<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="de.aspx.cs" Inherits="porfacor.de" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="ddlFrut" runat="server">
            <asp:ListItem Value="9">Bolivia</asp:ListItem>
            <asp:ListItem Value="24">Perú</asp:ListItem>
            <asp:ListItem Value="32">Chile</asp:ListItem>
            <asp:ListItem Value="17">Paraguay </asp:ListItem>
               <asp:ListItem Value="20">Mexico </asp:ListItem>
               <asp:ListItem Value="22">Guatemala </asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="BtnPruevas" runat="server" OnClick="BtnPruevas_Click" Text="Prueva" />
        <p>
            <asp:Label ID="lblSeleccionado" runat="server" Text="PAIS"></asp:Label>
        </p>
  
        
            <asp:Label ID="lblValor" runat="server" Text="DEPARTAMENTO/ESTADOS"></asp:Label>
        </p>
    </form>
</body>
</html>
