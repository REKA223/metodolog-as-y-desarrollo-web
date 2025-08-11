<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio C.aspx.cs" Inherits="CLASE_1.Ejercicio_C" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio C - Inventario</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Seleccioná un producto</h3>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="220px" />
            <p>
                Cantidad:
        <asp:TextBox ID="txtCantidad" runat="server" Width="80px" Text="1" />
            </p>
            <asp:Button ID="btnEnviar" runat="server" Text="Calcular"
                OnClick="btnEnviar_Click" />
            <hr />
            <p>Precio unitario:
                <asp:Label ID="lblPrecio" runat="server" /></p>
            <p>Total:
                <asp:Label ID="lblTotal" runat="server" /></p>
        </div>
    </form>
</body>
</html>
