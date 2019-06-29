<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="enlazar.aspx.cs" Inherits="Paises.enlazar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        Paises
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="style1">
        <tr>
            <td class="style2">
       <asp:DropDownList ID="Lista1" runat="server" OnSelectedIndexChanged="Lista1_SelectedIndexChanged" AutoPostBack="True">
           <asp:ListItem>insertar</asp:ListItem>
           <asp:ListItem>lobo</asp:ListItem>
                      </asp:DropDownList>
                </td>
                <td class="style2">
                <asp:Image ID="imgMostrar" runat="server" style="background-clip" Width="473px" />

                    </td>
            </td class="style2">
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
