-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: optica
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `brand`
--

DROP TABLE IF EXISTS `brand`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `brand` (
  `idBrand` int(11) NOT NULL AUTO_INCREMENT,
  `nameBrand` varchar(45) DEFAULT NULL,
  `supplier_idSupplier` int(11) NOT NULL,
  PRIMARY KEY (`idBrand`),
  KEY `fk_Brand_supplier1_idx` (`supplier_idSupplier`),
  CONSTRAINT `fk_Brand_supplier1` FOREIGN KEY (`supplier_idSupplier`) REFERENCES `supplier` (`idSupplier`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brand`
--

LOCK TABLES `brand` WRITE;
/*!40000 ALTER TABLE `brand` DISABLE KEYS */;
INSERT INTO `brand` VALUES (1,'Custo',1),(2,'Armani',2),(3,'NewYork',1),(4,'Barcelona',2);
/*!40000 ALTER TABLE `brand` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `idCustomer` int(11) NOT NULL AUTO_INCREMENT,
  `nameCustomer` varchar(45) DEFAULT NULL,
  `streetCustomer` varchar(45) DEFAULT NULL,
  `housenbrCustomer` int(11) DEFAULT NULL,
  `floorCustomer` varchar(4) DEFAULT NULL,
  `doorCustomer` varchar(4) DEFAULT NULL,
  `cityCustomer` varchar(45) DEFAULT NULL,
  `pcCustomer` varchar(8) DEFAULT NULL,
  `countryCustomer` varchar(45) DEFAULT NULL,
  `phCustomer` varchar(15) DEFAULT NULL,
  `emailCustomer` varchar(45) DEFAULT NULL,
  `registerDateCustomer` date DEFAULT NULL,
  PRIMARY KEY (`idCustomer`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'luis','juliop',85,'ki','kil','lkj','gbn','mjkmnh','789j','uju778','2019-11-25'),(6,'wsde','df',63,'2','52','11452','2541','55','22','22s','2019-11-30'),(7,'maria','63',25,'114','552','663','552','111','44','55','2019-08-14');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `idEmployee` int(11) NOT NULL AUTO_INCREMENT,
  `nameEmployee` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idEmployee`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Anabel'),(2,'Marcelino'),(3,'Jose');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `glasses`
--

DROP TABLE IF EXISTS `glasses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `glasses` (
  `idGlasses` int(11) NOT NULL AUTO_INCREMENT,
  `Brand_idBrand` int(11) NOT NULL,
  `leftGradGlasses` varchar(45) DEFAULT NULL,
  `rightGradGlasses` varchar(45) DEFAULT NULL,
  `Mount_mountName` varchar(45) NOT NULL,
  `colorMountGlasses` varchar(45) DEFAULT NULL,
  `leftGlassColor` varchar(45) DEFAULT NULL,
  `rightGlassColor` varchar(45) DEFAULT NULL,
  `priceGlasses` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`idGlasses`),
  KEY `fk_Glasses_Mount1_idx` (`Mount_mountName`),
  KEY `fk_Glasses_Brand1_idx` (`Brand_idBrand`),
  CONSTRAINT `fk_Glasses_Brand1` FOREIGN KEY (`Brand_idBrand`) REFERENCES `brand` (`idBrand`),
  CONSTRAINT `fk_Glasses_Mount1` FOREIGN KEY (`Mount_mountName`) REFERENCES `mount` (`mountName`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `glasses`
--

LOCK TABLES `glasses` WRITE;
/*!40000 ALTER TABLE `glasses` DISABLE KEYS */;
INSERT INTO `glasses` VALUES (1,2,'12.25ñpol','415','Pasta','Azul','Verde','Amarillo',52.63),(2,1,'63','25','Metalica','Marino','Rojo','Pardo',51.36),(4,2,'41','41','pasta','41','41','41',41.00),(5,4,'7','7','metalica','uj','yh','yt',66.85),(6,4,'14','52','pasta','44','55','66',254.12);
/*!40000 ALTER TABLE `glasses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mount`
--

DROP TABLE IF EXISTS `mount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mount` (
  `mountName` varchar(45) NOT NULL,
  PRIMARY KEY (`mountName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mount`
--

LOCK TABLES `mount` WRITE;
/*!40000 ALTER TABLE `mount` DISABLE KEYS */;
INSERT INTO `mount` VALUES ('Flotante'),('Metalica'),('Pasta');
/*!40000 ALTER TABLE `mount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recommend`
--

DROP TABLE IF EXISTS `recommend`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recommend` (
  `customer_idNewCustomer` int(11) NOT NULL,
  `customer_idRecByCustomer` int(11) NOT NULL,
  PRIMARY KEY (`customer_idNewCustomer`,`customer_idRecByCustomer`),
  KEY `fk_recommend_customer_idx` (`customer_idNewCustomer`),
  KEY `fk_recommend_customer1_idx` (`customer_idRecByCustomer`),
  CONSTRAINT `fk_recommend_customer` FOREIGN KEY (`customer_idNewCustomer`) REFERENCES `customer` (`idCustomer`),
  CONSTRAINT `fk_recommend_customer1` FOREIGN KEY (`customer_idRecByCustomer`) REFERENCES `customer` (`idCustomer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recommend`
--

LOCK TABLES `recommend` WRITE;
/*!40000 ALTER TABLE `recommend` DISABLE KEYS */;
INSERT INTO `recommend` VALUES (1,6),(6,1),(6,7);
/*!40000 ALTER TABLE `recommend` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sale`
--

DROP TABLE IF EXISTS `sale`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sale` (
  `idSale` int(11) NOT NULL AUTO_INCREMENT,
  `dateSale` date DEFAULT NULL,
  `Glasses_idGlasses` int(11) NOT NULL,
  `Employee_idEmployee` int(11) NOT NULL,
  `customer_idCustomer` int(11) NOT NULL,
  PRIMARY KEY (`idSale`),
  UNIQUE KEY `Glasses_idGlasses_UNIQUE` (`Glasses_idGlasses`),
  KEY `fk_Sale_Glasses1_idx` (`Glasses_idGlasses`),
  KEY `fk_Sale_Employee1_idx` (`Employee_idEmployee`),
  KEY `fk_Sale_customer1_idx` (`customer_idCustomer`),
  CONSTRAINT `fk_Sale_Employee1` FOREIGN KEY (`Employee_idEmployee`) REFERENCES `employee` (`idEmployee`),
  CONSTRAINT `fk_Sale_Glasses1` FOREIGN KEY (`Glasses_idGlasses`) REFERENCES `glasses` (`idGlasses`),
  CONSTRAINT `fk_Sale_customer1` FOREIGN KEY (`customer_idCustomer`) REFERENCES `customer` (`idCustomer`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sale`
--

LOCK TABLES `sale` WRITE;
/*!40000 ALTER TABLE `sale` DISABLE KEYS */;
INSERT INTO `sale` VALUES (1,'2019-04-29',1,2,7),(2,'2018-05-15',2,1,6),(3,'2019-10-12',4,2,1),(4,'2019-01-25',5,1,7);
/*!40000 ALTER TABLE `sale` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `idSupplier` int(11) NOT NULL AUTO_INCREMENT,
  `nameSupplier` varchar(45) DEFAULT NULL,
  `streetSupplier` varchar(45) DEFAULT NULL,
  `housenbrSupplier` int(3) DEFAULT NULL,
  `floorSupplier` varchar(4) DEFAULT NULL,
  `doorSupplier` varchar(2) DEFAULT NULL,
  `citySupplier` varchar(45) DEFAULT NULL,
  `countrySupplier` varchar(45) DEFAULT NULL,
  `phSupplier` varchar(45) DEFAULT NULL,
  `faxSupplier` varchar(45) DEFAULT NULL,
  `vatSupplier` varchar(15) DEFAULT NULL,
  `pcSupplier` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`idSupplier`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Suministros Rull','La Cañada',63,'1','4','Barcelona','Spain','45218547','14521452','14523687p','14523'),(2,'Gafas La Mallola','Jueves',41,'7','5','Granada','Spain','41256363','254125','1452547','44552');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'optica'
--

--
-- Dumping routines for database 'optica'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-09-26 12:12:10
