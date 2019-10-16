<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSolicitud.aspx.cs" Inherits="Solicitud_de_residencias.Vistas.FrmSolicitud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="panel-group">
    <img class="img-responsive" src="/Vistas/IMG/EncabezadoItsur.png" ;alter="Encabezado"/>
    <h1>Solicitud de Residencias</h1>
        <div>
            <p>Lugar: Uriangato Gto.</p>
            <p>Fecha:</p>
            <input type="date"/>
        </div>

        <div>
            <p>C. Miguel Cruz Pineda</p>
            <p> Jefe de la div de estudios profesionales</p>
        </div>

        <div>
            <p>AT'N: C. Miguel Cruz Pineda</p>
            <p>Coordinador de la carrera de Ing. En sistemas computacionales</p>
        </div>

        <div>
            <p>Nombre del proyecto: </p>
            <input type="text" />
        </div>
        
            <label class="radio-inline"><input type="radio" name="opcionProyect"/>Banco de proyectos</label>
       
        
            <label class="radio-inline"><input type="radio" name="opcionProyect"/>Propuesta propia</label>
        
            <label class="radio-inline"><input type="radio" name="opcionProyect"/>Trabajador</label>
       
    </div>
    </form>
</body>
</html>
