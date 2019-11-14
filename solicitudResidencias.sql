create database solicitudResidencias;
use solicitudResidencias;

show tables;

create table usuario(
usuario varchar(50) primary key,
contrasena varchar(50) default "itsur123",
rol enum('Alumno','Administrador','Coordinador') not null
);
create table alumno
(
noControl varchar(9) primary key,
usuario varchar(50) not null,
nombre varchar(50) not null,
apellidoPaterno varchar (30) not null,
apellidoMaterno varchar(30) not null,
carrera enum('Ing. En Sistemas Computacionales','Ing. Electrónica', 'Ing. Informática','Ing. En Gestión Empresarial', 
'Ing. Industrial', 'Ing. En Sistemas Automotrices','Ing. Ambiental') not null,
email varchar(100) not null,
telefono varchar(10) null,
domicilio varchar(100),
ciudad varchar(50) not null,
servicioSalud enum("IMSS","ISSSTE","OTRO") not null,
numeroServicioSalud varchar(30)not null,
constraint foreign key(usuario) references usuario(usuario)
);

create table detallesSolicitud(
idSolicitud int primary key auto_increment,
noControl varchar(9) not null,
lugar varchar(100) not null,
fecha date not null,
coordinadorCarrera varchar(100) not null,
/*jefeDivEstudiosProf varchar(100) not null,*/
nombreProyecto varchar(200) not null,
opcionElegida enum('Banco de proyectos','Propuesta propia','Trabajador') not null,
periodo varchar(50) not null,/*duda ver que informacion va en periodo*/
numeroResidentes int not null,
nombreEmpresa varchar(100) not null,
/*giro varchar(60) not null,*/
giro enum("Industrial","Servicios","Otro")not null,
sector enum("Publico","privado")not null,
/*sector varchar(60) not null,*/
rfc varchar(16) not null,
domicilioEmpresa varchar(100) not null,
coloniaEmpresa varchar(50) not null,
cpEmpresa varchar(10) not null,
faxEmpresa varchar(15) not null,
ciudadEmpresa varchar(50) not null,
telefonoEmpresa varchar(10) not null,
misionEmpresa varchar(200) not null,
nombreTitularEmpresa varchar(100) not null,
puestoTitularEmpresa varchar(100) not null,
nombreAsesorExterno varchar(100) not null,
puestoAsesorExterno varchar(100) not null,
nombreAcuerdoTrabajo varchar(100) not null,
puestoAcuerdoTrabajo varchar(100) not null,
nombreResidente varchar(100) not null,
estado boolean default true,
/*carrera varchar(90) not null,
/*noControl varchar(9) not null,*/
/*domicilioResidente varchar(100) not null,
emailResidente varchar(100) not null,
seguridadSocialResidente varchar(30) not null,
numSeguroSocial varchar(15) not null,
ciudadResidente varchar(50) not null,
telefonoResidente varchar(10) not null,*/
foreign key(noControl) references alumno(noControl)
);