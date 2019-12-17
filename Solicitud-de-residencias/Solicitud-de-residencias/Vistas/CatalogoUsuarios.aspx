﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoUsuarios.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.CatalogoUsuarios" MasterPageFile="~/Vistas/MasterPage.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>       
    <title>Catálogo de Usuarios</title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link href="CSS/cssCatalogoUsuarios.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="contenedor">
    <div style="text-align:center;"class="form-group">
    <div style="display:inline-block;">
        <asp:Label Text="Catálogo de usuarios" runat="server" CssClass="et"/>
        <asp:GridView ID="GridView1" runat="server" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" CssClass="Grid" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1"  OnRowDeleted="GridView1_RowDeleted" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
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
        <div style="text-align:center;">
           
        
        <asp:Button ID="Button1" runat="server" Text="Agregar Usuario" OnClick="Button1_Click" CssClass="boton"/>
            <asp:Button Text="Ver solicitudes"  CssClass="boton" runat ="server" OnClick="Unnamed1_Click" />
            <asp:Button Text="Exportar a Excel"  CssClass="boton" runat ="server" OnClick="Unnamed3_Click" />
        </div>
    </div>
    </div>
        </div>
    
</asp:Content>