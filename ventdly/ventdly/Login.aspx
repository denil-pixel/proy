<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ventdly.Login" %>

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
            <td>User Name</td>
            <td><input type="text" id="txtUsername" /></td>

        </tr>
        <tr>
        <td><asp:Label ID="lblPssword" runat="server" Text="Password:"></asp:Label></td>
        <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" > </asp:TextBox> 
            <asp:RequiredFieldValidator ID="chkPassword" runat="server" ErrorMessage="tiene que introducir contraseña" ControlToValidate="txtPassword" Display="Dynamic"></asp:RequiredFieldValidator></td>
    </tr>
        <tr>
            <td></td>
            <td><asp:Button  CssClass="boton_formulario" ID="btnLogin" runat="server" text="LOGIN" Width="86px"></asp:Button></td>

        </tr>
    </table>
       

        
    </div>
    </form>
</body>
    
</html>
