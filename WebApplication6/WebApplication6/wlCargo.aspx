<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wlCargo.aspx.cs" Inherits="WebApplication6.wlCargo" %>

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
  <td><asp:Label ID="lCargo" runat="server" Text="Cargo"></asp:Label></td>
            <td><asp:TextBox ID="tbCargo" runat="server" ></asp:TextBox></td>
    
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="bRegistar" runat="server" Text="Registar" OnClick="bRegClik" style="height: 26px" /></td>
            <asp:Label ID="lMensaje" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
           
    
        </table>
        
    
    </div>
    </form>
</body>
</html>
