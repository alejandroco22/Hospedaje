CREATE DATABASE  IF NOT EXISTS `hospedajealdia` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */;
USE `hospedajealdia`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: hospedajealdia
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.29-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rol` (
  `idRol` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `nombreRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idReunionRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idSedeRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idBitacoraRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`idRol`),
  KEY `idReunionRol` (`idReunionRol`),
  KEY `idSedeRol` (`idSedeRol`),
  KEY `idBitacoraRol` (`idBitacoraRol`),
  CONSTRAINT `rol_ibfk_1` FOREIGN KEY (`idSedeRol`) REFERENCES `sede` (`idSede`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `rol_ibfk_2` FOREIGN KEY (`idBitacoraRol`) REFERENCES `bitacora` (`idBitacora`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `rol_ibfk_3` FOREIGN KEY (`idReunionRol`) REFERENCES `reunion` (`idReunion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-07 19:55:18
