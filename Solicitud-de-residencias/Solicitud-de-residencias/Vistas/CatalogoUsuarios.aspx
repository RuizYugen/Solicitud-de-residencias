﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoUsuarios.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.CatalogoUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"  OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="usuario" HeaderText="usuario" SortExpression="usuario" />
                <asp:BoundField DataField="contrasena" HeaderText="contrasena" SortExpression="contrasena" />
                <asp:BoundField DataField="rol" HeaderText="rol" SortExpression="rol" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAll" TypeName="BackEnd.DAOS.UsuarioDAO" DataObjectTypeName="BackEnd.Modelos.Usuario" DeleteMethod="delete" UpdateMethod="update"></asp:ObjectDataSource>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Agregar Usuario" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
