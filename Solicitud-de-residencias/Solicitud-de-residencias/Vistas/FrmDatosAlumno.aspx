<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmDatosAlumno.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmDatosAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link href="CSS/cssCatalogoUsuarios.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="background-color:#F8F9FA" >
    <form id="form1" runat="server">
        <div class="container">
             <header>
                <div class="col-12">
                <nav class="navbar fixed-top navbar-dark bg-primary">
                    <a class="navbar-brand" href="#">
                       <h4>SOLICITUD DE RESIDENCIAS</h4>
                    </a>
                </nav>               
            </div>
            </header>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <main style="background-color: white" class="col-12  shadow p-3 mb-5 bg-white rounded">
                 <form class="needs-validation" novalidate="">
                     <div class="row">
                            <div class="col-md-4 mb-3">
                                <label for="txtNoControl">No. Control</label>
                                <asp:TextBox class="form-control" ID="txtNoControl" runat="server" required="*"></asp:TextBox>
                                <div class="invalid-feedback">Valid last name is required.</div>
                            </div>

                            <div class="col-md-8 mb-3">
                                <label for="txtNombre">Nombre</label>
                                <asp:TextBox ID="txtNombre" runat="server" class="form-control" required="*"></asp:TextBox>
                                <div class="invalid-feedback">Valid last name is required.</div>
                            </div>
                        </div>

                         
                       <div class="row">
                            <div class="col-md-4">
                                <label for="TextBox1">Apellido Paterno</label>
                                <asp:TextBox ID="txtApellidoPaterno" runat="server" class="form-control" required="*"></asp:TextBox>
                              
                            </div>

                            <div class="col-md-4">
                                <label for="ApeM">Apellido Materno</label>
                                <asp:TextBox ID="txtApellidoMaterno" runat="server" class="form-control" required="*"></asp:TextBox>
                               
                            </div>

                            <div class="col-md-4">
                                <label for="Carrera">Carrera</label>
                                <asp:DropDownList ID="txtCarrera" runat="server" class="custom-select d-block w-100" required="*"></asp:DropDownList>

                            </div>
                         </div>
                         

                         <div class="row">
                             <div class="col-md-8 mb-3">
                                    <label for="txtEmail">Email</label>
                                     <asp:TextBox ID="txtEmail" runat="server" type="email"  class="form-control" required="*"></asp:TextBox>
                              </div>

                              <div class="col-md-4 mb-3">
                                     <label for="txtTelefono">Telefono</label>
                                         <asp:TextBox ID="txtTelefono" runat="server" ValidateRequestMode="Inherit" class="form-control" required="*" type="text" pattern="^[9|8|7|6]\d{8}$"></asp:TextBox>
                              </div>
                         </div>



                      <div class="row">
                             <div class="col-md-5 mb-2">
                                    <label for="txtDomicilio" >Domicilio</label>
                                     <asp:TextBox ID="txtDomicilio" runat="server" class="form-control" required="*" ></asp:TextBox>    
                              </div>

                              <div class="col-md-4 mb-2">
                                     <label for="txtCiudad">Ciudad</label>
                                        <asp:TextBox ID="txtCiudad" runat="server" class="form-control" required="*"></asp:TextBox>
                              </div>

                           <div class="col-md-3 mb-2">
                                     <label for="txtServicioSalud">Servicio de salud</label>
                                          <asp:DropDownList ID="txtServicioSalud" runat="server" class="custom-select d-block w-100" required="*"></asp:DropDownList>                                      
                              </div>

                         </div>


                       <div class="row">
                             <div class="col-md-8 mb-3">
                                    <label for="txtNoServicioSalud">Numero de servicio de salud</label>
                                     <asp:TextBox ID="txtNoServicioSalud" runat="server" class="form-control" required="*"  type="number" maxlength="15"></asp:TextBox>
                                   
                              </div>

                              <div class="col-md-4 mb-3">
                                     <label for="txtAsesorInterno">Asesor Interno</label>
                                        <asp:TextBox ID="txtAsesorInterno" runat="server" class="form-control" required="*"></asp:TextBox>
                                         <div class="invalid-feedback">Campo requerido.</div>
                              </div>
                         </div>

                     <br />
                     <br />

                     <div class="row">
                         <div class="col-4">
                            <asp:Button  class="btn btn-lg btn-primary btn-block"  ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                         </div>
                         <div class="col-4">
                            <asp:Button class="btn btn-lg btn-primary btn-block"  ID="btnSolicitud" runat="server" Text="Solicitud" OnClick="btnSolicitud_Click" />

                         </div>
                         <div class="col-4">
                             <asp:Button class="btn btn-lg btn-primary btn-block"  ID="btnImprimir" runat="server" Text="Imprimir Solicitud" OnClick="btnImprimir_Click" />
                         </div>
                     </div>
                     <br />
                     <br />
                 </form>
           </main>

            <footer>

            </footer>          

        </div>
    </form>
</body>
</html>
