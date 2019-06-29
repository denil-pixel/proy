<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfUpDepto.aspx.cs" Inherits="MPage.wfUpDepto" %>

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
                <td><asp:Label ID="lDepto" runat="server">Departamento:</asp:Label></td>
                <td><asp:TextBox ID="tbDepto" runat="server"></asp:TextBox></td>
                  <asp:HiddenField ID="hfCod" runat="server" />

            </tr>
            <tr>
                <td><asp:Label ID="lPais" runat="server" Text="Pais:"></asp:Label></td>
                <td><asp:DropDownList ID="ddlPais" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="bActualizar" runat="server" Text="Modificar" OnClick="bActualizarar_Click" /></td>
            </tr>
        </table>   
    
    </div>
    </form>
</body>
</html>
