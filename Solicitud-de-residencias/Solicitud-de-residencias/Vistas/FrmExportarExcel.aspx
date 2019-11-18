<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmExportarExcel.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmExportarExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnExportarExcel" runat="server" OnClick="btnExportarExcel_Click" Text="Exportar A Excel" />
        <asp:GridView ID="dgvSolicitudes" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Plan" HeaderText="Plan" SortExpression="Plan" />
                <asp:BoundField DataField="Cons" HeaderText="Cons" SortExpression="Cons" />
                <asp:BoundField DataField="NoControl" HeaderText="NoControl" SortExpression="NoControl" />
                <asp:BoundField DataField="AsesorInterno" HeaderText="AsesorInterno" SortExpression="AsesorInterno" />
                <asp:BoundField DataField="Asesorexterno" HeaderText="Asesorexterno" SortExpression="Asesorexterno" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />
                <asp:BoundField DataField="TelefonoEmpresa" HeaderText="TelefonoEmpresa" SortExpression="TelefonoEmpresa" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAll" TypeName="BackEnd.DAOS.ExportarExcelDao"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
