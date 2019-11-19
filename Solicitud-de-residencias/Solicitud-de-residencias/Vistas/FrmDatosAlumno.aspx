<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDatosAlumno.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmDatosAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link href="CSS/cssCatalogoUsuarios.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="contenedor">
    <div style="text-align:center;"class="form-group">
    <div style="display:inline-block;">
        <h1>Datos del Alumno</h1>
        <br />
        <asp:Label ID="Label1" runat="server" Text="No. Control"></asp:Label>
        <br />
        <asp:TextBox ID="txtNoControl" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Apellido Paterno"></asp:Label>
        <br />
        <asp:TextBox ID="txtApellidoPaterno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Apellido Materno"></asp:Label>
        <br />
        <asp:TextBox ID="txtApellidoMaterno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Carrera"></asp:Label>
        <br />
        <asp:DropDownList ID="txtCarrera" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Telefono"></asp:Label>
        <br />
        <asp:TextBox ID="txtTelefono" runat="server" ValidateRequestMode="Inherit"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Domicilio"></asp:Label>
        <br />
        <asp:TextBox ID="txtDomicilio" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Ciudad"></asp:Label>
        <br />
        <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Servicio de salud"></asp:Label>
        <br />
        <asp:DropDownList ID="txtServicioSalud" runat="server"></asp:DropDownList>       
        <br />
        <asp:Label ID="Label11" runat="server" Text="No. Servicio de salud"></asp:Label>
        <br />
        <asp:TextBox ID="txtNoServicioSalud" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Text="Asesor interno"></asp:Label>
        <br />
        <asp:TextBox ID="txtAsesorInterno" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <br />
        <br />
        <asp:Button ID="btnSolicitud" runat="server" Text="Solicitud" OnClick="btnSolicitud_Click" />
        <br />
        <br />
        <asp:Button ID="btnImprimir" runat="server" Text="Imprimir Solicitud" OnClick="btnImprimir_Click" />
    </div>
        </div>
        </div>
    </form>
</body>
</html>
