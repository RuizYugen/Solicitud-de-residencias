<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlDeAcceso.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.ControlDeAcceso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../scripts/jquery-3.0.0.min.js"></script>
    <script src="../scripts/popper.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
</head>
<body>
     <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager2" runat="server">
            <Services>
                <asp:ServiceReference Path="~/servicios/swRegistro.asmx" />
            </Services>
        </asp:ScriptManager>
    
       
        <div class="modal fade" id="contraseniaIncorrecta">
            <div class="modal-dialog">
                <div class="modal-content">
                                       
                    <div class="modal-header">
                        <h4 class="modal-title">Contraseña o usuario incorrecto</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    
                    <div class="modal-body">
                        <h5>Si has olvidado tu contraseña o usuario, contacta con el administrador</h5>
                    </div>
                                        
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-12">
                <h1></h1>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3"></div>
            <div class="col-sm-8 .justify-content-center">
                <div class="modal-dialog text-center">
                    <div class="col-sm-8 ">
                        <div class="modal-content">
                            <div class="col-12">
                                <br />
                                <img src="../Recursos/IconoInicio.png" />
                            </div>
                            <div class="col-12">
                                <br />
                                <div class="form-group">
                                    <asp:TextBox ID="Usuario_name" class="form-control" placeholder="Usuario" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" TextMode="Password" ID="Contrasena_n" placeholder="Contraseña" runat="server"></asp:TextBox>
                                </div>
                                <br />
                                <div class="form-group">
                                    <asp:Button class="btn btn-lg btn-primary btn-block" ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                                </div>
                                <div class="form-group text-left">
                                    <br />
                                    <a href="#" data-toggle="modal" data-target="#VentanaM"></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
