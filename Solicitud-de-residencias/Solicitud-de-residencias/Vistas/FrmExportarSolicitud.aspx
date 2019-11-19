<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmExportarSolicitud.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmExportarSolicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link rel="stylesheet" href="CSS/Solicitud2.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel-group">
    <img class="img-responsive" src="/Vistas/IMG/EncabezadoItsur.png" ;alt="Encabezado"/>
   
    <div class="container-fluid">
        <p  class="encabezado">INSTITUTO TECNOLOGICO SUPERIOR DEL SUR DE GUANAJUATO</p>
    <p class="encabezado">DIVISION DE ESTUDIOS PROFESIONALES</p>
    <p class="encabezado">RESIDENCIAS PROFESIONALES</p>
        <p class="encabezado">SOLICITUD DE RESIDENCIAS PROFESIONALES</p>
    </div>
    
        <br />
       
        <div>
            <label class="left">Lugar: Uriangato Gto.</label>
            <!-- <label id="fecha">Fecha: <input type="date"  id="fechaCale" runat="server"/></label> -->
            <label id="fecha"> fecha: <asp:TextBox ID="fechaCale2" runat="server" Text='<%# Bind("DateofBirth") %>' TextMode="Date"></asp:TextBox> </label>
        </div>
      
        <br />
        <div id="coDatos" >
            <div class="textoIzquierda">
             <label runat="server" id="txtCoordinador">C. Miguel Cruz Pineda </label>
                <br />
                <label >Jefe de la div de estudios profesionales</label>
            
            </div>
            
            
            <div class="textoDerecha">
                <label >AT'N: C. Miguel Cruz Pineda </label>
                <br />
                <label>Coordinador de la carrera de Ing. En sistemas computacionales</label>
            </div>
            
        
        </div>

        
        <br />
        <br />
        <div class="form-group, etiquetaText">
            <label for="txtnombreProyecto" class="texto25">NOMBRE DEL PROYECTO: </label>
            <input class="form-control"  id="txtnombreProyecto" type="text" runat="server" required="required"/>
        </div>
        <br />
        <br />
       
        <div>
            <label class="texto15">OPCION ELEGIDA:   </label>
           <label  class="radio-inline"><input type="radio" name="opcionProyect" id="rbBanco2" value="Banco de proyectos"  runat="server"/>Banco de proyectos</label>
       
       
            <label class="radio-inline"><input type="radio" name="opcionProyect" id="rbpropia2" value="Propuesta propia" runat="server" />Propuesta propia</label>
        
            <label class="radio-inline"><input type="radio" name="opcionProyect" id="rbtrabajador2" value="Trabajador" runat="server" />Trabajador</label>
            
        </div>
        
        <br />
        <div class="periodoNum">
         <div class="form-group, etiquetaText, periodo">
           <label for="periodo" class="texto75">PERIODO PROYECTADO:</label>  
             <input class="form-control"  id="periodo" type="text" runat="server" required="required" />
         </div> 
               <div class="form-group, etiquetaText, numR">
                    <label for="periodo" class="texto75">Número de residentes:</label>  
                    <input class="form-control"  id="numResidentes" type="number" runat="server" required="required" />
               </div> 
        </div>
        
        <br />  
        <br />
            <label>Datos de la empresa:</label>   
        <br />
        
              <div class="form-group, etiquetaText">
            <label for="nombreProyecto" class="texto10">Nombre: </label>
            <input class="form-control"  id="nombreEmpresa" type="text" runat="server" required="required" />
        </div>
        <br />
         <br />
            
        <div class="divRFC">
               <div class="divGiro">
            <div>
            <label class="texto15">Giro, Ramo:   </label>
             
                 <label  class="radio-inline"><input type="radio" name="giro" id="rbIndus" value="Industrial" runat="server" />Industrial</label>
       
        
                <label class="radio-inline"><input type="radio" name="giro" id="rbServ" value="Servicios" runat="server"/>Servicios</label>
        
                <label class="radio-inline"><input type="radio" name="giro" id="rbotroG" value="Otro" runat="server"/>Otro</label>
               
              

        </div>
        <br />
        <div>
             <label class="texto15">Sector:   </label>
              
            <label  class="radio-inline"><input type="radio" name="sector" id="rbPublico" value="Publico"  runat="server"/>Público</label>
       
        
            <label class="radio-inline"><input type="radio" name="sector" id="rbPrivado" value="privado" runat="server"/>Privado</label>
        
           
        </div>

        </div>
              
        <div class="divNumRFC">
             <label>R.F.C. </label><input class="form-control" type="text" id="txtRfc" runat="server" required="required"/>
        </div>
        </div>
             <div class="form-group, etiquetaText">
            <label for="nombreProyecto" class="texto10">Domicilio: </label>
            <input class="form-control"  id="domicilioEmp" type="text" runat="server" required="required" />
        </div>
            <br />
            <br />
        <div class="colonia">
            <div class="form-group, etiquetaText">
                <label for="colonia" class="texto30">Colonia: </label>
                <input class="form-control"  id="colonia" type="text" runat="server" required="required" />
            </div>
            <div class="form-group, etiquetaText">
                <label for="cp" class="texto">C.P: </label>
                <input class="form-control"  id="cp" type="text" runat="server" required="required" />
            </div>
            <div class="form-group, etiquetaText">
                <label for="fax" class="texto">Fax: </label>
                <input class="form-control"  id="fax" type="text" runat="server" required="required"/>
            </div>
        </div>
        <br />
        <div class="ciudadTel">
            
                <div class="form-group, etiquetaText">
                    <label for="ciudadEmp" class="texto20">Ciudad: </label>
                    <input class="form-control"  id="ciudadEmp" type="text" runat="server" required="required"/>
                </div>
             
                <div class="form-group, etiquetaText">
                    <label for="telefonoEmp" class="texto25">Teléfono (no celular): </label>
                    <input class="form-control"  id="telefonoEmp" type="text" runat="server" required="required" />
                </div>
             
            
        </div>
        <br />
         <div class="form-group, etiquetaText">
                    <label for="mision" class="texto10">Mision de la empresa: </label>
                    <textarea class="form-control" rows="5"  id="mision"  runat="server" required="required"></textarea>
                </div>
        <br />
        <br />
        <div class="titular">
             <div class="form-group, etiquetaText">
                    <label for="titular" class="texto25">Nombre del Titular de la empresa: </label>
                    <input class="form-control"  id="titular" type="text" runat="server" required="required"/>
                </div>
             
                <div class="form-group, etiquetaText">
                    <label for="puestoTit" class="texto15">Puesto: </label>
                    <input class="form-control"  id="puestoTit" type="text" runat="server" required="required"/>
                </div>
        </div>
        <br />
        <div class="titular">
             <div class="form-group, etiquetaText">
                    <label for="titular" class="texto25">Nombre del Asesor Externo: </label>
                    <input class="form-control"  id="asesor" type="text" runat="server" required="required"/>
                </div>
             
                <div class="form-group, etiquetaText">
                    <label for="puestoTit" class="texto15">Puesto: </label>
                    <input class="form-control"  id="puestoAse" type="text" runat="server" required="required"/>
                </div>
        </div>
        <br />
        <div class="titular">
             <div class="form-group, etiquetaText">
                    <label for="acuerdo" class="texto75">Nombre de la persona que firmará el acuerdo de trabajo. Alumno-Escuela-Empresa: </label>
                    <input class="form-control"  id="acuerdo" type="text" runat="server" required="required"/>
                </div>
             
                <div class="form-group, etiquetaText">
                    <label for="puestoTit" class="texto15">Puesto: </label>
                    <input class="form-control"  id="puestoAcue" type="text" runat="server" required="required"/>
                </div>
        </div>
        <br />
        <label>Datos del residente:</label>
         <div class="form-group, etiquetaText">
            <label for="nombreAlumno" class="texto10">Nombre: </label>
            <input class="form-control"  id="nombreAlumno" type="text" runat="server" required="required"/>
        <br />
             <br />
             <br />
        </div>
        <div class="ciudadTel">
            
                <div class="form-group, etiquetaText">
                    <label for="carrera" class="texto20">Carrera: </label>
                    <input class="form-control"  id="carrera" type="text" runat="server" required="required"/>
                </div>
             
                <div class="form-group, etiquetaText">
                    <label for="noControl" class="texto25">No. de control: </label>
                    <input class="form-control"  id="noControl" type="text" runat="server" required="required"/>
                </div>
            
        </div>
     
        <br />
        <div class="form-group, etiquetaText">
            <label for="nombreProyecto" class="texto10">Domicilio: </label>
            <input class="form-control"  id="domicilioAlu" type="text" runat="server" required="required"/>
        </div>
        <br />
        <br />
         <div class="emailSeguro">
             <div class="divEmail">
                 <div class="form-group, etiquetaText">
                    <label for="email" class="texto30">E-mail: </label>
                    <input class="form-control"  id="email" type="email" runat="server" required="required"/>
                  </div>
             </div>
             <div class="seguroNum">
                 <label class="texto25">Para Seguridad Social acudir:   </label>
            <label  class="radio-inline"><input type="radio" name="seguroOp" id="rbImss" value="IMSS" runat="server"/>IMSS</label>
       
        
            <label class="radio-inline"><input type="radio" name="seguroOp" id="rbIssste" value="ISSSTE" runat="server"/>ISSSTE</label>
        
            <label class="radio-inline"><input type="radio" name="seguroOp" id="rbOtrosS" value="OTRO" runat="server"/>Otros</label>
                 <br />
                  <div class="form-group, etiquetaText">
                    <label for="email" class="texto25">No. : </label>
                    <input class="form-control"  id="noSeguro" type="text" runat="server" required="required"/>
                  </div>
             </div>
            
        </div>
        <br />
                <div class="ciudadTel">
            
                <div class="form-group, etiquetaText">
                    <label for="ciudadEmp" class="texto20">Ciudad: </label>
                    <input class="form-control"  id="ciudadAlu" type="text" runat="server" required="required"/>
                </div>
             
                <div class="form-group, etiquetaText">
                    <label for="telefonoEmp" class="texto25">Teléfono (no celular): </label>
                    <input class="form-control"  id="teleAlu" type="text" runat="server" required="required"/>
                </div>
             
            
        </div>
       <br />
        <br />
        <br />
        <br />
        <div class="firma">
            <label>Firma del alumno(a)</label>
        </div>
        <br />
        <br />
        </div>
    </form>
</body>
</html>
