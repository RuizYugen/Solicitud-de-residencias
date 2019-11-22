<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmExportarExcel.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmExportarExcel" %>

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
        <asp:Button ID="btnExportarExcel" runat="server" OnClick="btnExportarExcel_Click" Text="Exportar A Excel" CssClass="btn-success" />
        <hr />
        <asp:GridView ID="dgvSolicitudes" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="Grid">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan" />
                <asp:BoundField DataField="Cons" HeaderText="Cons" SortExpression="Cons" />
                <asp:BoundField DataField="NoControl" HeaderText="NoControl" SortExpression="NoControl" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />  
                <asp:BoundField DataField="AsesorInterno" HeaderText="Asesor Interno" SortExpression="AsesorInterno" />
                <asp:BoundField DataField="Proyecto" HeaderText="Proyecto" SortExpression="Proyecto" />
                <asp:BoundField DataField="Asesorexterno" HeaderText="Asesor Externo" SortExpression="Asesorexterno" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />
                <asp:BoundField DataField="TelefonoEmpresa" HeaderText="Telefono Empresa" SortExpression="TelefonoEmpresa" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />                                             
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAll" TypeName="BackEnd.DAOS.ExportarExcelDao"></asp:ObjectDataSource>
    </div>
        </div>
        </div>
    </form>
</body>
</html>
