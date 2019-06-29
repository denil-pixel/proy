<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="de.aspx.cs" Inherits="pais.de" %>

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
                     <td><asp:Label ID="paises" runat="server" Text="Pais">Pais</asp:Label></td> 
                     <td><asp:DropDownList ID="nacion" runat="server" OnSelectedIndexChanged="Page_Load" AutoPostBack="true"> 
                             <asp:ListItem Value="1" Text="Bolivia"></asp:ListItem>
                             <asp:ListItem Value="2" Text="Venezuela"></asp:ListItem>
                             <asp:ListItem Value="3" Text="Brasil"></asp:ListItem>
                             <asp:ListItem Value="4" Text="Ecuador"></asp:ListItem>
                             <asp:ListItem Value="5" Text="Argentina"></asp:ListItem>
                          
                         
                     </asp:DropDownList></td>
                </tr>
                <tr>
                     <td><asp:Label ID="Departamento" runat="server" Text="Departamento/Nacciones">Departamento/Naciones</asp:Label></td> 
                     <td><asp:DropDownList ID="den" runat="server" OnSelectedIndexChanged="Page_Load" AutoPostBack="true"></asp:DropDownList></td>
                </tr>
                 <tr>
                     <td colspan="2"><asp:Button ID="Regis" runat="server" Text="Registrar" OnClick="Page_Load"/></td>
                 </tr>    
            </table>
    </div>
    </form>
</body>
</html>
