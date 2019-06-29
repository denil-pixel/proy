<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pais.aspx.cs" Inherits="da.pais" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table class="style1">
        <tr>
            <td class="auto-style1">
       <asp:DropDownList ID="Lista1" runat="server" OnSelectedIndexChanged="Lista1_SelectedIndexChanged" AutoPostBack="True" >
           <asp:ListItem>INGRESAR</asp:ListItem>
           <asp:ListItem>descarga(2)</asp:ListItem>
           
                      </asp:DropDownList>
                </td>
                <td class="style2">
               <asp:Image ID="imgMostrar" runat="server" style="margin-left: 0px" Height="93px" Width="70px" />
                    </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
