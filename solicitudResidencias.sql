CREATE DATABASE  IF NOT EXISTS `solicitudresidencias` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `solicitudresidencias`;
-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: solicitudresidencias
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `alumno` (
  `noControl` varchar(9) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidoPaterno` varchar(30) NOT NULL,
  `apellidoMaterno` varchar(30) NOT NULL,
  `carrera` enum('Ing. En Sistemas Computacionales','Ing. Electrónica','Ing. Informática','Ing. En Gestión Empresarial','Ing. Industrial','Ing. En Sistemas Automotrices','Ing. Ambiental') NOT NULL,
  `email` varchar(100) NOT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `domicilio` varchar(100) DEFAULT NULL,
  `ciudad` varchar(50) NOT NULL,
  `servicioSalud` enum('IMSS','ISSSTE','OTRO') NOT NULL,
  `numeroServicioSalud` varchar(30) NOT NULL,
  `asesorInterno` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`noControl`),
  UNIQUE KEY `usuario` (`usuario`),
  CONSTRAINT `alumno_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
INSERT INTO `alumno` VALUES ('s15120040','ruiz','jesus','Ruiz','sanchez','Ing. En Sistemas Computacionales','ruiz@fjfj.com','4456789865','Benito Juarez','sdsddsds','IMSS','12345k','Efren Vega');
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallessolicitud`
--

DROP TABLE IF EXISTS `detallessolicitud`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detallessolicitud` (
  `idSolicitud` int(11) NOT NULL AUTO_INCREMENT,
  `noControl` varchar(9) DEFAULT NULL,
  `lugar` varchar(100) NOT NULL,
  `fecha` date NOT NULL,
  `coordinadorCarrera` varchar(100) NOT NULL,
  `nombreProyecto` varchar(200) NOT NULL,
  `opcionElegida` enum('Banco de proyectos','Propuesta propia','Trabajador') NOT NULL,
  `periodo` varchar(50) NOT NULL,
  `numeroResidentes` int(11) NOT NULL,
  `nombreEmpresa` varchar(100) NOT NULL,
  `giro` enum('Industrial','Servicios','Otro') NOT NULL,
  `sector` enum('Publico','privado') NOT NULL,
  `rfc` varchar(16) NOT NULL,
  `domicilioEmpresa` varchar(100) NOT NULL,
  `coloniaEmpresa` varchar(50) NOT NULL,
  `cpEmpresa` varchar(10) NOT NULL,
  `faxEmpresa` varchar(15) NOT NULL,
  `ciudadEmpresa` varchar(50) NOT NULL,
  `telefonoEmpresa` varchar(10) NOT NULL,
  `misionEmpresa` varchar(200) NOT NULL,
  `nombreTitularEmpresa` varchar(100) NOT NULL,
  `puestoTitularEmpresa` varchar(100) NOT NULL,
  `nombreAsesorExterno` varchar(100) NOT NULL,
  `puestoAsesorExterno` varchar(100) NOT NULL,
  `nombreAcuerdoTrabajo` varchar(100) NOT NULL,
  `puestoAcuerdoTrabajo` varchar(100) NOT NULL,
  `nombreResidente` varchar(100) NOT NULL,
  `estado` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`idSolicitud`),
  UNIQUE KEY `noControl` (`noControl`),
  CONSTRAINT `detallessolicitud_ibfk_1` FOREIGN KEY (`noControl`) REFERENCES `alumno` (`nocontrol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallessolicitud`
--

LOCK TABLES `detallessolicitud` WRITE;
/*!40000 ALTER TABLE `detallessolicitud` DISABLE KEYS */;
INSERT INTO `detallessolicitud` VALUES (1,'s15120040','Uriangato Gto.','2019-11-19','C. Miguel Cruz Pineda ','gfdghjnkjhgfdghjkh','Banco de proyectos','ftghbnbhvgvhbnmkjhg',1,'jhgfdgbnmjhgfd','Industrial','privado','nbvgfds','mkjhgfdsdfghj','mnhgfhbnm,njhgffghjk','34434','mnbvfdsfgh','njhgfdesdfgh','1234567890','nbgfdsadvbnm,nhgfds','njhgfdsfvbnm','nb mnm','hbbjbjb','jnj','jnjnj','mnm','jesus Ruiz sanchez',1);
/*!40000 ALTER TABLE `detallessolicitud` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuario` (
  `usuario` varchar(50) NOT NULL,
  `contrasena` varchar(50) DEFAULT 'itsur123',
  `rol` enum('Alumno','Administrador','Coordinador') NOT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('CHORI','1234','Alumno'),('root','root','Coordinador'),('ruiz','ruiz','Alumno');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-19 18:24:15
