<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.AgregarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>       
    <title>Agregar Usuario</title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link href="CSS/cssAgregarUsuario.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="contenedor">
        <div class="form-group">
            <div style="text-align:center;">
                <div style="display:inline-block;">
                    <img class="style_prevu_kit" src="/Vistas/IMG/user.png" alt="Alternate Text" />
                </div>
            </div>                    
            <br />
        <asp:Label ID="Label1" runat="server" Text="Usuario" CssClass="et"></asp:Label>
        <br />
        <input id="txtUsuario" type="text" runat="server" class="form-control" required="required" autofocus="autofocus"/><br />
        <br />
        </div>
        <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="Contraseña" CssClass="et"></asp:Label>
        <br />
        <input id="txtContrasena" type="text" runat="server" class="form-control" required="required"/><br />
        <br />
        </div>
        <div class="form-group">
        <asp:Label ID="Label3" runat="server" Text="Rol" CssClass="et"></asp:Label>
        <br />
        <input id="txtRol" type="text" runat="server" class="form-control" placeholder="Alumno/Administrador" required="required"/><br />
        <br />
        </div>    
        <div style="text-align:center;width:100%">
            <div style="display:inline-block;width:100%">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" CssClass="boton"/><!--CssClass="btn btn-primary"-->
                </div>
        </div>
    </div>
    </form>
</body>
<%--</html>--%>
