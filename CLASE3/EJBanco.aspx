<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJBanco.aspx.cs" Inherits="CLASE3.EJBanco" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
                      "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BANCO</title>
</head>
<body>
    <form id="form1" runat="server">
       <p><strong>XPathDocument</strong></p>
        <hr width="100%" size="1" />
        <p><em>Cuentas en Barcelona</em></p>
        <asp:ListBox ID="ListBox1" runat="server" Width="137px" Rows="2" />
        <p>
            <asp:Button ID="Button1" runat="server" Text="Actualizar Cuentas" Font-Bold="true" OnClick="Button1_Click" />
        </p>
        <hr width="100%" size="1" />
    </form>
</body>
</html>
