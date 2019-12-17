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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" CssClass="Grid">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="idSolicitud" HeaderText="ID Solicitud" SortExpression="idSolicitud" />
                <asp:BoundField DataField="noControl" HeaderText="No. Control" SortExpression="noControl" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                <asp:CheckBoxField DataField="estado" HeaderText="Estado" SortExpression="estado" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="BackEnd.Modelos.Solicitudes" SelectMethod="getAll" TypeName="BackEnd.DAOS.SolicitudesDAO" UpdateMethod="actualizar"></asp:ObjectDataSource>
    </div>
    </div>
    </div>
    </form>
</body>
</html>
