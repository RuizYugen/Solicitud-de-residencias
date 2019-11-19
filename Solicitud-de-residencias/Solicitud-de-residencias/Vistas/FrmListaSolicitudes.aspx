<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmListaSolicitudes.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmListaSolicitudes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Marcar como terminado</title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link href="CSS/cssCatalogoUsuarios.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="contenedor">
    <div style="text-align:center;"class="form-group">
    <div style="display:inline-block;">

    <asp:Label Text="Lista de Solicitudes" runat="server" class="et"/>
    <asp:GridView ID="GridView1" runat="server" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" CssClass="Grid" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" >
            <Columns>
                <asp:BoundField DataField="idSolicitud" HeaderText="Identificador" SortExpression="idSolicitud" />
                <asp:BoundField DataField="noControl" HeaderText="Numero Control" SortExpression="noControl" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
                <asp:CommandField ShowEditButton="True"/>
            </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAll" TypeName="BackEnd.DAOS.SolicitudesDAO" DataObjectTypeName="BackEnd.Modelos.Solicitudes"  UpdateMethod="actualizar"></asp:ObjectDataSource>
    </div>
    </div>
    </div>
    </form>
</body>
</html>
