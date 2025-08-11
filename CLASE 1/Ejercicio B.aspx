<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio B.aspx.cs" Inherits="CLASE_1.Ejercicio_B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ejercicio B - Escribir XML</title>
</head>
<body bgcolor="aqua">
    <form id="form1" runat="server">
        <div>
            <strong><span style="font-size: 20px;">ESCRIBIR DATOS EN UN DOCUMENTO XML</span></strong>
            <hr width="100%" noshade="noshade" size="3" />
            <p>
                <asp:Label ID="lblNombre" runat="server" Font-Bold="true" Text="Nombre:" />
                &nbsp;
            <asp:TextBox ID="txtNombre" runat="server" Width="200px" />
            </p>
            <p>
                <asp:Label ID="lblApellidos" runat="server" Font-Bold="true" Text="Apellidos:" />
                &nbsp;
            <asp:TextBox ID="txtApellidos" runat="server" Width="200px" />
            </p>
            <p>
                <asp:Label ID="lblDireccion" runat="server" Font-Bold="true" Text="Dirección:" />
                &nbsp;
            <asp:TextBox ID="txtDireccion" runat="server" Width="300px" />
            </p>
            <p>
                <asp:Button ID="btnCrear" runat="server" Text="Crear Documento" Font-Bold="true" Font-Italic="true" OnClick="EscribirXML_Click" />
            </p>
        </div>
    </form>
</body>
</html>
