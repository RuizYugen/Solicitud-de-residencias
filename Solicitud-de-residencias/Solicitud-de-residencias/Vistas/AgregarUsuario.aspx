<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.AgregarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        <br />
        <input id="txtUsuario" type="text" runat="server"/><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <br />
        <input id="txtContrasena" type="text" runat="server"/><br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Rol"></asp:Label>
        <br />
        <input id="txtRol" type="text" runat="server"/><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" />
    
    </div>
    </form>
</body>
</html>
