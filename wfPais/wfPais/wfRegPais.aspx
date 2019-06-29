<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfRegPais.aspx.cs" Inherits="wfPais.wfRegPais" %>

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
                <td><asp:Label ID="lPais" runat="server" >Pais</asp:Label></td>
                <td><asp:TextBox ID="tbPais" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="bRegistrar" runat="server" Text="Registar" OnClick="bRegistrar_Click"</td>
                <asp:Label ID="lMsg" runat="server" ForeColor="Red"></asp:Label>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
