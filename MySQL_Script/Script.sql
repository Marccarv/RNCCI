CREATE DATABASE  IF NOT EXISTS `trabalho_isc` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `trabalho_isc`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: trabalho_isc
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `material`
--

DROP TABLE IF EXISTS `material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material` (
  `material_id` int NOT NULL AUTO_INCREMENT,
  `material_name` varchar(20) NOT NULL,
  `material_amount` int NOT NULL,
  PRIMARY KEY (`material_id`),
  UNIQUE KEY `material_name` (`material_name`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
INSERT INTO `material` VALUES (1,'Luvas',1200),(2,'Máscaras',2500),(3,'Toucas',1520),(4,'Óculos de Proteção',500),(5,'Batas Cirúrgicas',3000),(6,'Proteção de Calçado',1800),(7,'Desinfetante de Mãos',5000),(8,'Sapatos Hospitalar',98),(9,'Avental Descartável',2000),(10,'Viseira',190);
/*!40000 ALTER TABLE `material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materialrequest`
--

DROP TABLE IF EXISTS `materialrequest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materialrequest` (
  `materialrequest_id` int NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(30) NOT NULL,
  `material_id` int NOT NULL,
  `material_amount` int NOT NULL,
  PRIMARY KEY (`materialrequest_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materialrequest`
--

LOCK TABLES `materialrequest` WRITE;
/*!40000 ALTER TABLE `materialrequest` DISABLE KEYS */;
INSERT INTO `materialrequest` VALUES (1,'IPP Famalicão',1,100),(2,'ULDM Braga',2,200),(3,'UC Póvoa de Lanhoso',1,156),(4,'IPP Famalicão',2,200),(5,'IPP Lisboa',2,120),(6,'UMDR Porto',2,80),(7,'ULDM Lisboa',1,40),(8,'UMDR Braga',2,89),(9,'IPP Famalicão',10,10),(10,'ULDM Lisboa',1,50),(11,'UC Porto',8,2);
/*!40000 ALTER TABLE `materialrequest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `patient_un` varchar(15) NOT NULL,
  `name` varchar(150) NOT NULL,
  `birthday` varchar(25) NOT NULL,
  `unit_name` varchar(40) NOT NULL,
  `contact` varchar(15) NOT NULL,
  `address` varchar(200) NOT NULL,
  `register_date` varchar(25) NOT NULL,
  PRIMARY KEY (`patient_id`,`patient_un`),
  UNIQUE KEY `patient_un` (`patient_un`),
  UNIQUE KEY `contact` (`contact`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'20131','Marco Carvalho','29-05-2001 17:45:10','IPP Braga','97868786','Rua de Cima','29-02-2019 17:45:10'),(2,'60821','Juliana Novais','06-01-2001 17:45:10','IPP Famalicão','965845214','Rua de Baixo','29-02-2019 17:45:10'),(3,'92639','André Monteiro','29-02-2001 17:45:10','IPP Famalicão','923584621','Rua de Meio','29-02-2019 17:45:10'),(4,'84525','Custódia Amorim','14-02-1914 17:45:10','IPP Lisboa','921874514','Rua do Centro','29-02-2019 17:45:10'),(5,'45266','Leticia Fernandes','5-02-2001 17:45:10','IPP Lisboa','912584574','Rua do Centro','29-02-2019 17:45:10'),(6,'76487','Nadine Costa','12-10-2014 17:45:10','ULDM Póvoa de Lanhoso ','941258751','Rua de Baixo','29-02-2019 17:45:10'),(7,'44249','Bruno Falcão','25-12-1980 17:45:10','ULDM Braga','996585415','Rua de Cima','29-02-2019 17:45:10'),(8,'82686','Joaquim Freitas','29-02-1968 17:45:10','ULDM Braga','985124858','Rua do Meio','29-02-2019 17:45:10'),(9,'17744','Manuel Monteiro','13-08-1970 17:45:10','ULDM Braga','914859621','Rua do Centro','29-02-2019 17:45:10'),(10,'52192','Paulo Costa','29-06-1989 17:45:10','ULDM Lisboa','908514751','Rua de Cima','29-02-2019 17:45:10'),(11,'44242','Esmeralda Cardoso','15-10-1942 17:45:10','ULDM Lisboa','979685471','Rua de Baixo','29-02-2019 17:45:10'),(12,'66341','Ana Carolina','28-06-1995 17:45:10','UC Póvoa de Lanhoso','962545123','Rua do Meio','29-02-2019 17:45:10'),(13,'11056','Maria Silva','22-05-2005 17:45:10','UC Póvoa de Lanhoso','931547851','Rua de Baixo','29-02-2019 17:45:10'),(14,'37951','António Filipe','12-07-1980 17:45:10','UC Famalicão','924574581','Rua de Cima','29-02-2019 17:45:10'),(15,'38616','Julieta Vieira','05-02-1925 17:45:10','UC Porto','919578523','Rua do Centro','29-02-2019 17:45:10'),(16,'95378','André Silva','30-05-1952 17:45:10','UC Porto','925145858','Rua de Baixo','29-02-2019 17:45:10'),(17,'82739','Bruno Antunes','18-10-2000 17:45:10','UC Porto','972524488','Rua do Meio','29-02-2019 17:45:10'),(18,'74717','Renata Vieira','23-12-2008 17:45:10','UMDR Braga','962578524','Rua de Cima','29-02-2019 17:45:10'),(19,'54759','Mariana Novais','23-11-2001 17:45:10','UMDR Braga','945251785','Rua de Baixo','29-02-2019 17:45:10'),(20,'86208','Beatriz Silva','31-08-1972 17:45:10','UMDR Braga','978515112','Rua do Meio','29-02-2019 17:45:10'),(21,'97617','Marco Daniel','09-09-1961 17:45:10','UMDR Braga','912245415','Rua do Centro','29-02-2019 17:45:10'),(22,'82978','Augusto Lima','11-05-1958 17:45:10','UMDR Famalicão','925648521','Rua de Baixo','29-02-2019 17:45:10'),(23,'78540','Afonso Fernandes','27-4-2010 17:45:10','UMDR Famalicão','985947524','Rua de Cima','29-02-2019 17:45:10'),(24,'92848','José Antunes','20-4-1985 17:45:10','UMDR Porto','932578515','Rua do meio','29-02-2019 17:45:10'),(26,'74358','Cristiano Ronaldo','02/02/1994 12:22:44','IPP Lisboa','977777777','Marques de Pombal','06/01/2022 12:22:44'),(27,'34673','Bruno de Carvalho','28/12/1998 12:25:42','ULDM Braga','915467854','Big Brother','06/01/2022 12:25:42'),(28,'30634','António Melo','23/07/1959 23:08:17','ULDM Póvoa de Lanhoso','962987561','Rua da Esquerda','09/01/2022 23:08:17');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `team`
--

DROP TABLE IF EXISTS `team`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `team` (
  `team_id` int NOT NULL AUTO_INCREMENT,
  `zone` varchar(20) DEFAULT NULL,
  `unit_name` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`team_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team`
--

LOCK TABLES `team` WRITE;
/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team` VALUES (1,'BRAGA','IPP Braga'),(2,'BRAGA','ULDM Braga'),(3,'BRAGA','UMDR Braga'),(4,'FAMALICAO','IPP Famalicão'),(5,'FAMALICAO','UC Famalicão'),(6,'FAMALICAO','UMDR Famalicão'),(7,'LISBOA','IPP Lisboa'),(8,'LISBOA','ULDM Lisboa'),(9,'PORTO','UC Porto'),(10,'PORTO','UMDR Porto'),(11,'POVOA DE LANHOSO','UC Póvoa de Lanhoso'),(12,'POVOA DE LANHOSO','ULDM Póvoa de Lanhoso');
/*!40000 ALTER TABLE `team` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unit`
--

DROP TABLE IF EXISTS `unit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unit` (
  `unit_id` int NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(30) DEFAULT NULL,
  `zone` varchar(20) DEFAULT NULL,
  `beds_number` int DEFAULT NULL,
  PRIMARY KEY (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unit`
--

LOCK TABLES `unit` WRITE;
/*!40000 ALTER TABLE `unit` DISABLE KEYS */;
INSERT INTO `unit` VALUES (1,'IPP Braga','BRAGA',2),(2,'ULDM Braga','BRAGA',1),(3,'UMDR Braga','BRAGA',3),(4,'IPP Famalicão','FAMALICAO',2),(5,'UC Famalicão','FAMALICAO',2),(6,'UMDR Famalicão','FAMALICAO',1),(7,'IPP Lisboa','LISBOA',4),(8,'ULDM Lisboa','LISBOA',3),(9,'UC Porto','PORTO',1),(10,'UC Porto','PORTO',2),(11,'UC Póvoa de Lanhoso','POVOA DE LANHOSO',2),(12,'ULDM Póvoa de Lanhoso','POVOA DE LANHOSO',1);
/*!40000 ALTER TABLE `unit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `vehicle_id` int NOT NULL AUTO_INCREMENT,
  `vehicle_brand` varchar(20) NOT NULL,
  `plate` varchar(15) NOT NULL,
  `vehicle_type` varchar(100) NOT NULL,
  `zone` varchar(30) NOT NULL,
  PRIMARY KEY (`vehicle_id`,`plate`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (1,'Mercedes','34-TT-56','Ambulância de Transporte de Doentes','FAMALICAO'),(2,'FIAT','GH-56-78','Helicóptero','FAMALICAO'),(3,'Renault','HG-89-24','Ambulancia de Emergência','POVOA DE LANHOSO'),(4,'MAN','54-89-HH','Ambulância de Transporte de Doentes','POVOA DE LANHOSO'),(5,'Mercedes','17-AA-56','Helicóptero','BRAGA'),(6,'Mercedes','78-BJ-56','Ambulancia de Emergência','PORTO'),(7,'Renault','45-HG-28','Ambulancia de Cuidados Intensivos','PORTO'),(8,'FIAT','BN-56-87','Ambulancia de Emergência','LISBOA'),(9,'Mercedes','37-FV-12','Helicóptero','LISBOA');
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiclerequest`
--

DROP TABLE IF EXISTS `vehiclerequest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehiclerequest` (
  `vehiclerequest_id` int NOT NULL AUTO_INCREMENT,
  `team_id` varchar(15) NOT NULL,
  `plate` varchar(15) NOT NULL,
  `request_time` varchar(25) NOT NULL,
  `zone` varchar(30) NOT NULL,
  PRIMARY KEY (`vehiclerequest_id`,`team_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiclerequest`
--

LOCK TABLES `vehiclerequest` WRITE;
/*!40000 ALTER TABLE `vehiclerequest` DISABLE KEYS */;
INSERT INTO `vehiclerequest` VALUES (1,'1','45-HG-28','14/10/1999 14:45:10','PORTO'),(2,'2','17-AA-56','20/04/2010 17:45:10','BRAGA'),(3,'5','34-TT-56','06/01/2022 22:58:53','FAMALICAO'),(4,'1','17-AA-56','09/01/2022 19:55:24','BRAGA'),(5,'4','GH-56-78','09/01/2022 23:10:40','FAMALICAO');
/*!40000 ALTER TABLE `vehiclerequest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visitor`
--

DROP TABLE IF EXISTS `visitor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `visitor` (
  `visitor_id` int NOT NULL AUTO_INCREMENT,
  `patient_un` varchar(40) NOT NULL,
  `time_in` varchar(25) NOT NULL,
  `time_out` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`visitor_id`,`patient_un`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visitor`
--

LOCK TABLES `visitor` WRITE;
/*!40000 ALTER TABLE `visitor` DISABLE KEYS */;
INSERT INTO `visitor` VALUES (1,'86208','14/10/1999 14:45:10','29/05/2001 20:33:48'),(2,'54759','14/10/1999 14:45:10','29/05/2001 20:33:48'),(3,'74717','06/01/2022 12:51:19','13/01/2022 12:52:25'),(4,'','',''),(5,'','',''),(6,'60821','07/01/2022 00:40:00','07/01/2022 00:40:38'),(7,'30634','09/01/2022 23:12:32','09/01/2022 23:13:38');
/*!40000 ALTER TABLE `visitor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'trabalho_isc'
--

--
-- Dumping routines for database 'trabalho_isc'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-01-09 23:29:48
