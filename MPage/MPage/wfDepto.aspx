<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfDepto.aspx.cs" Inherits="MPage.wfDepto" %>

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
                <td><asp:Label ID="lDeptoo" runat="server">Departamento:</asp:Label></td>
                <td><asp:TextBox ID="tbDepto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lPais" runat="server" Text="Pais:"></asp:Label></td>
                <td><asp:DropDownList ID="ddlPais" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="bRegistrar" runat="server" Text="Registrar" OnClick="bRegistar_Click" /></td>
            </tr>
        </table>         
   
    </div>
    </form>
</body>
</html>
