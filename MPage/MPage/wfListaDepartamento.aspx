﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfListaDepartamento.aspx.cs" Inherits="MPage.wfListaDepartamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gvDepto" runat="server">
        <Columns>
            <asp:HyperLinkField DataTextField="id" DataNavigateUrlFormatString="wfUpdsDepto.aspx?id={0}" DataNavigateUrlFields="id" />
        </Columns>
    </asp:GridView>
    </div>
    </form>
</body>
</html>
