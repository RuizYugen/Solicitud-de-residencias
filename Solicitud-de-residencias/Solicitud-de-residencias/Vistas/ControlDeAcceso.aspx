<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlDeAcceso.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.ControlDeAcceso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
    </style>
     <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../scripts/jquery-3.0.0.min.js"></script>
    <script src="../scripts/popper.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
     <!--Nota: Si la referencia de bootstrap que estan arriba no funcionan usa las de abajo (Solo funcionan con internet) -->
          
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>
    
</head>
<body>
     <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager2" runat="server">
            <Services>
                <asp:ServiceReference Path="~/servicios/swRegistro.asmx" />
            </Services>
        </asp:ScriptManager>
       <header>
            <div class="col-12">
                <nav class="navbar fixed-top navbar-dark bg-primary">
                    <a class="navbar-brand" href="#">
                           <!-- <img src="IMG/logo_itsur_p.gif" width="50" height="50" class="d-inline-block align-top" alt=""/>-->
                       
                    </a>
                </nav>               
            </div>  
       </header>
         <br />
         <br />
         <br />
       <main>
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
                                <img src="IMG/IconoInicio.png" />
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
       </main>
       <footer class="page-footer">
           

       </footer>
    </form>
</body>
</html>
