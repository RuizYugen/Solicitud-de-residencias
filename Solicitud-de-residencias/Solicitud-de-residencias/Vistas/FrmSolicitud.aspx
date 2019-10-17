<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSolicitud.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmSolicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link rel="stylesheet" href="CSS/Solicitud.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel-group">
    <img class="img-responsive" src="/Vistas/IMG/EncabezadoItsur.png" ;alter="Encabezado"/>
   
    <div class="container-fluid">
        <p  class="encabezado">INSTITUTO TECNOLOGICO SUPERIOR DEL SUR DE GUANAJUATO</p>
    <p class="encabezado">DIVISION DE ESTUDIOS PROFESIONALES</p>
    <p class="encabezado">RESIDENCIAS PROFESIONALES</p>
        <p class="encabezado">SOLICITUD DE RESIDENCIAS PROFESIONALES</p>
    </div>
    
        <br />
       
        <div>
            <label class="left">Lugar: Uriangato Gto.</label>
            <label id="fecha">Fecha: <input type="date"/></label>
        </div>
      
        <br />
        <div id="coDatos" >
            <div class="textoIzquierda">
             <label>C. Miguel Cruz Pineda </label>
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
            <label for="nombreProyecto" class="texto25">NOMBRE DEL PROYECTO: </label>
            <input class="form-control"  id="nombreProyecto" type="text" runat="server" />
        </div>
        <br />
        <br />
        <div>
            <label class="texto15">OPCION ELEGIDA:   </label>
            <label  class="radio-inline"><input type="radio" name="opcionProyect" checked="checked"/>Banco de proyectos</label>
       
        
            <label class="radio-inline"><input type="radio" name="opcionProyect"/>Propuesta propia</label>
        
            <label class="radio-inline"><input type="radio" name="opcionProyect"/>Trabajador</label>
        </div>
        <br />
         <div class="form-group, etiquetaText">
           <label for="periodo" class="texto25">PERIODO PROYECTADO:</label>  
             <input class="form-control"  id="periodo" type="text" runat="server" />
         </div>   
       
    </div>
    </form>
</body>
</html>
