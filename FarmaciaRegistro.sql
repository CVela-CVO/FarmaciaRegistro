-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: registrofarmacia
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.24-MariaDB

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
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentos` (
  `id_departamento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_depto` varchar(25) NOT NULL,
  PRIMARY KEY (`id_departamento`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'Alta\r\nVerapaz'),(2,'Baja Verapaz'),(3,'Chimaltenago'),(4,'Chiquimula'),(5,'Guatemala'),(6,'El Progreso'),(7,'Escuintla'),(8,'Huehuetenango'),(9,'Izabal'),(10,'Jalapa'),(11,'Jutiapa'),(12,'Petén'),(13,'Quetzaltenango'),(14,'Quiché'),(15,'Retalhuleu'),(16,'Sacatepequez'),(17,'San Marcos'),(18,'Santa Rosa'),(19,'Sololá'),(20,'Suchitepequez'),(21,'Totonicapán'),(22,'Zacapa');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedidos`
--

DROP TABLE IF EXISTS `detalle_pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedidos` (
  `id_detalle` int(11) NOT NULL AUTO_INCREMENT,
  `id_pedido` int(11) NOT NULL,
  `id_medicamento` int(11) NOT NULL,
  `medicamento_cantidad` int(12) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `fk_pedido` (`id_pedido`),
  KEY `fk_medicapedido` (`id_medicamento`),
  CONSTRAINT `detalle_pedidos_ibfk_1` FOREIGN KEY (`id_pedido`) REFERENCES `pedidos` (`id_pedido`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `detalle_pedidos_ibfk_2` FOREIGN KEY (`id_medicamento`) REFERENCES `medicamento` (`id_medicamento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedidos`
--

LOCK TABLES `detalle_pedidos` WRITE;
/*!40000 ALTER TABLE `detalle_pedidos` DISABLE KEYS */;
INSERT INTO `detalle_pedidos` VALUES (8,13,44,2),(9,13,37,5),(10,13,31,1),(11,13,67,2),(12,13,29,1),(13,13,53,1),(14,13,43,2),(15,14,70,4),(16,14,68,2),(17,14,42,4),(18,14,45,1),(19,14,62,2),(20,15,71,4),(21,15,78,2),(22,15,32,1),(23,15,34,5),(24,15,76,5),(25,15,61,2),(26,15,73,4),(27,15,72,1),(28,15,35,1),(29,16,48,5),(30,16,41,6),(31,16,58,2),(32,16,63,3),(33,16,73,3),(35,18,57,2),(36,18,34,5),(37,18,70,6),(38,18,73,1),(39,18,44,2),(40,18,53,1),(41,19,64,2),(42,19,52,1),(43,19,41,2),(44,20,46,8);
/*!40000 ALTER TABLE `detalle_pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `distribuidoras`
--

DROP TABLE IF EXISTS `distribuidoras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `distribuidoras` (
  `id_distribuidora` int(11) NOT NULL AUTO_INCREMENT,
  `name_distribuidora` varchar(100) NOT NULL,
  `id_departamento` int(11) NOT NULL,
  `dir_distribuidora` varchar(1000) NOT NULL,
  `num_distribuidora` varchar(100) NOT NULL,
  PRIMARY KEY (`id_distribuidora`),
  KEY `fk_departamento` (`id_departamento`),
  CONSTRAINT `distribuidoras_ibfk_1` FOREIGN KEY (`id_departamento`) REFERENCES `departamentos` (`id_departamento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `distribuidoras`
--

LOCK TABLES `distribuidoras` WRITE;
/*!40000 ALTER TABLE `distribuidoras` DISABLE KEYS */;
INSERT INTO `distribuidoras` VALUES (5,'PharMar',15,'Ciudad Calle 4 Zona 1','12345689'),(6,'Fayco',5,'5 Av 16 - 54 Zona 14','23633325'),(7,'Lanquetin',5,'10 Avenida 4-58 Zona 1','23849194'),(8,'Drycom',5,'a. Calle 17-19, Zona 15 Vista Hermosa I, COL. el Maestro 2','35652616'),(9,'Loralva S.A.',5,'1 Calle 0-15 Zona 1','66860300'),(10,'Droguería Pisa De Guatemala S.A',5,'5 Calle 1-02 Zona 13','23024500'),(11,'Centro Distribuidor, S.A.',5,'Ruta 4, 6-32 zona 4, Edificio Granat Of. 604','23795300'),(12,'Industria Farmaceutica, S.A. / Infasa',5,'Carretera Roosevelt Km 15.5 0-80 Zona 2 Mixco','24115454'),(13,'Surtiquimicos',5,'15 Avenida 9-68 Zona 11 Colonia Carabanchel','24448555'),(14,'Distribuidora Independiente Tlc Total Life Changes',5,'Agua Brana, barrio Las Casitas, frente al vivero municipal','37246091'),(15,'Repremedh',5,'Oficina Central: 13 Calle 0-73Z. 1 Of #4','22207807'),(16,'Quimicos Finos S.A.',5,'18 Avenida A 0-27 Zona 15 Colonia Vista Hermosa II Apartamento 2','23656420'),(17,'Kron Cientifica E Industrial',5,'Residenciales San Gaspar No 13, Santa Rosita San Gaspar 2, Zona 16','23653913'),(18,'Chemsol, S.A.',5,'Calzada Atanasio Tzul 22-00 Cortijo Ll Anexo Bodega 506','23213301'),(19,'Farmacias Cerca S.A.',5,'Cl 12 0-85 Z 9 Plaza Lorenzo L 2','23314346'),(20,'Laboratorio Y Drogueria Qualipharm S.A.',5,'4 Avenida 19-33 Zona 14','24144242'),(21,'Medivac',5,'9 Cl 17 - 71 Z 14','23215858'),(22,'Global Farma S.A.',5,'Boulevard Vista Hermosa 8-300 Zona 10','23090909'),(23,'G N C',5,'11 Cl 6 - 74 Zona 10','24221300'),(24,'Farmacias Galeno',5,'3 Calle 17-01 Zona 8 Mixco San Cristobal','24795514'),(25,'Laboratorios Lamfer',5,'Km.16.5 Carr. a San Juan Sacatépequez, Complejo Industrial Mixco','24209090'),(26,'Unipharm De El Salvador S.A. De C.V.',5,'3 Avenida 13-78 Zona 10 Torre Citibank en Intercontinental Plaza Nivel 12','24227575'),(27,'Leterago S.A.',5,'2 Calle 23-80 Zona 15 Vista Hermosa II Edificio Avante Nivel 10','22383920'),(28,'Farmaclinicas S.A.',5,'31 AV B 1-65 Z-11 COL UTATLAN II','24393867'),(29,'Asta Medica Centroamericana',5,'13 Av A 2-95 Zona 2','22506221'),(30,'Camdifarm',5,'Km 22.5 Carretera A El Salvador Av. Bouganvillias N. 13 Granja Buenos Aires Zona 0','66352032'),(31,'Disfarmacos',5,'5 Cl 34-30 Z 11','24393453'),(32,'Distrazelsa',5,'7A. Av 7-71 Zona 8 Mixco','24268888'),(33,'Distribuidora Comercial Albatros',5,'13 Cl 15-24 Zona 13','24405504'),(34,'Johnson & Johnson Guatemala',5,'26 Av 5-90 Zona 11','23266405'),(35,'Pfizer Corporation Suc.Guatemala',5,'Boulevard Los Proceres 24-69 Zona 10','23843400'),(36,'Distribuidora Medico Comercial Dimeco',5,'Manz 41 Casa 10 Zona 11 de Mixco, COL. la Loma de Minerva Misco','24839461'),(37,'Distribuidora R.M.',5,'10 Av 6-78. Zona 11 -Roosevelt','52055813');
/*!40000 ALTER TABLE `distribuidoras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marca` (
  `id_marca` int(11) NOT NULL AUTO_INCREMENT,
  `name_marca` varchar(100) NOT NULL,
  `id_paises` int(11) NOT NULL,
  `ico_marca` varchar(1000) NOT NULL,
  PRIMARY KEY (`id_marca`),
  KEY `fk_paises` (`id_paises`),
  CONSTRAINT `marca_ibfk_1` FOREIGN KEY (`id_paises`) REFERENCES `paises` (`id_pais`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (10,'Merck',75,'Merck.jpg'),(11,'Pfzier',75,'pfizer-logo.jpg'),(12,'Novartis',208,'Novartis-Logo-e1493651169912.jpg'),(13,'Sanofi-Aventis',166,'sanofi.png'),(14,'Roche',208,'Roche-Logo.jpg'),(15,'GlaxoSmithKline',112,'gsk.jpg'),(16,'AstraZeneca',162,'AstraZeneca-Logo.png'),(17,'Johnson & Johnson',75,'Johnson__and__Johnson-FB.jpg'),(18,'Lilly',75,'Lilly-Logo.jpg'),(19,'Abbott Labs',75,'abbot.png'),(20,'Bristol-Myers Squibb',75,'bristol-myers-squibb.jpg'),(21,'Wyeth',75,'wyeth.png'),(23,'Tylenol',52,'tylenol-1-logo-png-transparent.png'),(24,'B&B',94,'byb.png'),(25,'Lancasco',94,'Lancasco.png'),(26,'Bayer',94,'bayer.png'),(27,'Altian Pharma',94,'Altian.jpg'),(28,'Bonin',94,'logo bonin es guatemalteco-03.png'),(29,'Cheminter',94,'1519867098264.jpg'),(30,'Donovan Werke',94,'logo-dw.jpg'),(31,'Eurofarma',94,'channels4_profile.jpg'),(32,'Fargel',94,'fargel.jpg'),(33,'FarKot',94,'picture.jpg'),(34,'Farmacaps',94,'Farmacaps.jpg'),(35,'Farmamedica',94,'fmedica.png'),(36,'Globalfarma',94,'50a229a8adf2aac50859e6b4ccf6e01f.png'),(37,'Infasa',94,'indasd.png'),(38,'Intecfa',94,'Yo-soy-INTECFA.jpg'),(39,'INNOVA',94,'1618870359024.jpg'),(40,'Lafco',94,'lafco.png'),(41,'Lamfer',94,'1641926582733.jpg'),(42,'Phara',94,'pghara.jpg'),(43,'Wellco',94,'Logo-Wellco-Corporation-S.A.png'),(44,'Colgate',52,'Colgate-Logo-2004.jpg'),(45,'Dove',52,'Dove-Logo-1.jpg'),(46,'Equate',33,'9.jpg'),(47,'Menarini',94,'1648243705638.jpg');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicamento`
--

DROP TABLE IF EXISTS `medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medicamento` (
  `id_medicamento` int(11) NOT NULL AUTO_INCREMENT,
  `name_medicamento` varchar(100) NOT NULL,
  `id_marca` int(11) NOT NULL,
  `fechacad_medicamento` date NOT NULL,
  `obs_medicamento` varchar(1000) NOT NULL,
  `id_distribuidora` int(11) NOT NULL,
  `precio_medicamento` varchar(100) NOT NULL,
  `costo_medicamento` varchar(100) NOT NULL,
  `medica_existencias` varchar(4) NOT NULL,
  `img_medicamento` varchar(1000) NOT NULL,
  PRIMARY KEY (`id_medicamento`),
  KEY `fk_marca` (`id_marca`),
  KEY `fk-distribuidora` (`id_distribuidora`),
  CONSTRAINT `medicamento_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `medicamento_ibfk_2` FOREIGN KEY (`id_distribuidora`) REFERENCES `distribuidoras` (`id_distribuidora`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicamento`
--

LOCK TABLES `medicamento` WRITE;
/*!40000 ALTER TABLE `medicamento` DISABLE KEYS */;
INSERT INTO `medicamento` VALUES (29,'Anemidox',10,'2026-02-27','Tratamiento preventivo de la anemia por déficit de Hierro, Ácido Fólico y Vitamina B12',5,'84.09','115.2','11','anemidox-x-30-caps-merckconsumo.jpg'),(31,'TYLENOL® Extra Strength Caplets (Comprimidos)',23,'2026-10-15','ara el alivio del dolor de cabeza, del dolor muscular y de la fiebre en adultos, con 500 mg de acetaminofén',11,'85.5','85.5','14','microsoftteams-image_17_1.png'),(32,'Enantyum Menari',47,'2027-03-25','25 Mg 10 Comprimidos',16,'45','45','13','enantyum.jpg'),(33,'Pasta Dental Colgate Máxima Protección',44,'2026-12-23','Anticaries 150 ml',10,'28.5','745','40','psddsds.PNG'),(34,'Toalla Equate Facial Sensitive',46,'2027-02-18','40 Unidades',19,'22','145','35','jjh.jpg'),(35,'Tensinor',25,'2027-02-18','Valsartan + Hidroclorotiazida',5,'51.55','451','65','tensinor.png'),(36,'ACETAMINOFEN',25,'2027-05-04','120 ML(LANCASCO)',7,'24.54','825','20','Acetaminofen.jpg'),(37,'RABANO YODADO',25,'2026-04-20','Con Hierro',7,'28.90','720','5','Acetaminofen.jpg'),(38,'TYLENOL INFANTIL',23,'2026-04-20','Sabor a cereza 120 ML',11,'105.19','315','3','P005309.jpg'),(39,'Mesigyna',26,'2026-02-09','Ampolla 1 Ml Una Caja',11,'125.5','780','6','mesi.jpg'),(40,'Afrin',26,'2025-05-29','15Ml Spray Nasal',8,'66.5','115','20','P002614.jpg'),(41,'Tabcin Noche',26,'2026-02-25','Liquid Gel Caja X 30 Sobres',6,'4','115','48','P025142.jpg'),(42,'Alka Seltzer Efervescentes',26,'2025-11-27','Caja X 60 Tabletas',6,'1.4','784','71','P001667.jpg'),(43,'Aleve 220 Mg',26,'2026-11-25','36 Tabletas',6,'15.6','456','80','P006066.jpg'),(44,'Alka Ad',26,'2025-07-22','Caja X 60 Tabletas',6,'52.1','456','81','Alka-AD-.png'),(45,'Alka Gastric',26,'2025-07-22','X 36 Tabletas Masticables',6,'5.8','450','54','GetProductImage.jpg'),(46,'Lacteol Forte',25,'2026-02-25','Polvo Caja X 30 Sobres - Precio Indicado Por Sobre',10,'16','781','48','Lacteol-fort-30-sobres-1000x1000-1.jpg'),(47,'LAFCOXOL',40,'2024-02-13','Medicamento Etico 120 ML',13,'30.95','825.66','53','si.png'),(48,'CREMA LASSAR ',40,'2024-02-13','120 GRAMOS Medicamento Generico',13,'16.07','845.2','37','lafmk.png'),(49,'SECNIDAZOL',40,'2025-10-14','500 MG * 4 TABLETAS Medicamento Generico',13,'43.33','722','20','sezcandinol.png'),(50,'LASSAR CREMA 550 GRAMOS',40,'2024-12-10','Medicamento Generico',13,'39.21','426.2','31','lol.png'),(51,'VYTORIN 10/40 MG',10,'2029-06-07','28 COMPRIMIDOS - CAJA',5,'995.5','1231.5','5','1003389.jpg'),(52,'INVANZ 1 GRAMO IV/IM',10,'2030-01-23','POLVO - UNIDAD Requiere receta médica',5,'868.10','8256.2','4','1003369.jpg'),(53,'ZETIA 10MG',10,'2030-01-23','30 TABLETAS- CAJA',5,'790.31','4253.2','2','1003369.jpg'),(54,'PROPECIA 1 MG',10,'2028-03-20','28 TAB - CAJA',5,'933.70','5246.3','6','1003369.jpg'),(55,'ZYPREXA',18,'2027-07-21','10 MG * 14 TAB - CAJA',18,'1062.5','3520.1','3','1002912.jpg'),(56,'OSTIVAN SOLUCION INYECTABLE',30,'2027-07-21','1 AMPOLLA - UNIDAD',12,'851.40','3526.2','8','1012076.jpg'),(57,'VIRIDON 5MG',30,'2027-12-22',' X 30 TABLETAS - CAJA',12,'609','2506.3','7','1016141.jpg'),(58,'LAKIT 120 MG',30,'2027-04-21','X 30 + 15 TABLETAS - CAJA',12,'571.20','4231.2','5','1016376.jpg'),(59,'SITAVAN M 50MG/1000MG',30,'2027-09-22','X 60+30 COMPRIMIDOS - CAJA',12,'507.20','1425.3','3','1016181.jpg'),(60,'CASODEX 50 MG',16,'2028-09-12','28 COMPRIMIDOS - CAJA',12,'4007.65','4007.65','1','1000635.jpg'),(61,'DESITIN CREMA',17,'2027-10-06','CON ALOE Y VITAMINA E * 113 GR - UNIDAD',22,'179.95','825.3','5','1007845.jpg'),(62,'LUBRIDERM UV',17,'2027-10-06','400 ML - UNIDAD',22,'97.20','7556.2','22','1006588.jpg'),(63,'LISTERINE TOTAL CARE',17,'2027-04-19','500 ML - UNIDAD',22,'82.05','7215.2','38','1005195.jpg'),(64,'BENADRYL 25MG',17,'2027-06-10','24 TABLETAS - CAJA',22,'95.40','4201.30','58','1011108.jpg'),(65,'DRAMAMINE 50MG',17,'2028-01-12','24 TABLETAS - CAJA',22,'93.76','4052.3','81','1005476.jpg'),(66,'TALCO JOHNSON ORIGINAL',17,'2028-01-12','600 GR - UNIDAD',22,'89.10','1024.2','61','1002488.jpg'),(67,'SHAMPOO JOHNSON CABELLO CLARO',17,'2028-01-12','400 ML MANZANILLA - UNIDAD',22,'80.55','410.2','14','1002479.jpg'),(68,'LISTERINE COOL MINT',17,'2027-03-23','500 ML - UNIDAD',22,'71.36','720.1','48','1003844.jpg'),(69,'LISTERINE ZERO',17,'2028-01-11','500 ML (MENTA SUAVE) - UNIDAD',22,'71.36','4012','70','1009180.jpg'),(70,'VISINA COLIRIO',17,'2027-08-09','15ML - UNIDAD',22,'53.55','741.2','2','1003883.jpg'),(71,'ACEITE JOHNSON ORIGINAL',17,'2028-02-23','200 ML - UNIDAD',22,'51.80','812','96','1002457.jpg'),(72,'LISTERINE CUIDADO TOTAL MENTA',17,'2028-02-23','250ML - UNIDAD',22,'51.84','620','11','1005195.jpg'),(73,'TALCO JOHNSON ANTES DE DORMIR',17,'2028-02-23','200 GR - UNIDAD',22,'51.80','410','0','1006585.jpg'),(74,'HILO DENTAL JOHNSON REACH MENTA',17,'2027-10-12','50 MT - UNIDAD',15,'47.30','9800','94','3000295.jpg'),(75,'HILO DENTAL JOHNSON REACH REGULAR',17,'2028-04-12','50 MT - UNIDAD',15,'47.30','450','10','3000582.jpg'),(76,'HISOPOS JOHNSON',17,'2028-11-15','CAJITA 150 UNIDADES - UNIDAD',15,'37.76','810.5','41','3000297.jpg'),(77,'LUBRIDERM CON AROMA',17,'2025-11-11','120 ML - UNIDAD',15,'41.85','712.6','7','1008417.jpg'),(78,'BAÑO LIQUIDO RECIEN NACIDO',17,'2026-06-17','200 ML - UNIDAD',15,'47.75','800','14','3004517.jpg');
/*!40000 ALTER TABLE `medicamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paises`
--

DROP TABLE IF EXISTS `paises`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paises` (
  `id_pais` int(11) NOT NULL AUTO_INCREMENT,
  `iso_pais` char(2) DEFAULT NULL,
  `nombre` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id_pais`)
) ENGINE=InnoDB AUTO_INCREMENT=241 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paises`
--

LOCK TABLES `paises` WRITE;
/*!40000 ALTER TABLE `paises` DISABLE KEYS */;
INSERT INTO `paises` VALUES (1,'AF','Afganistán'),(2,'AX','Islas Gland'),(3,'AL','Albania'),(4,'DE','Alemania'),(5,'AD','Andorra'),(6,'AO','Angola'),(7,'AI','Anguilla'),(8,'AQ','Antártida'),(9,'AG','Antigua y Barbuda'),(10,'AN','Antillas Holandesas'),(11,'SA','Arabia Saudí'),(12,'DZ','Argelia'),(13,'AR','Argentina'),(14,'AM','Armenia'),(15,'AW','Aruba'),(16,'AU','Australia'),(17,'AT','Austria'),(18,'AZ','Azerbaiyán'),(19,'BS','Bahamas'),(20,'BH','Bahréin'),(21,'BD','Bangladesh'),(22,'BB','Barbados'),(23,'BY','Bielorrusia'),(24,'BE','Bélgica'),(25,'BZ','Belice'),(26,'BJ','Benin'),(27,'BM','Bermudas'),(28,'BT','Bhután'),(29,'BO','Bolivia'),(30,'BA','Bosnia y Herzegovina'),(31,'BW','Botsuana'),(32,'BV','Isla Bouvet'),(33,'BR','Brasil'),(34,'BN','Brunéi'),(35,'BG','Bulgaria'),(36,'BF','Burkina Faso'),(37,'BI','Burundi'),(38,'CV','Cabo Verde'),(39,'KY','Islas Caimán'),(40,'KH','Camboya'),(41,'CM','Camerún'),(42,'CA','Canadá'),(43,'CF','República Centroafricana'),(44,'TD','Chad'),(45,'CZ','República Checa'),(46,'CL','Chile'),(47,'CN','China'),(48,'CY','Chipre'),(49,'CX','Isla de Navidad'),(50,'VA','Ciudad del Vaticano'),(51,'CC','Islas Cocos'),(52,'CO','Colombia'),(53,'KM','Comoras'),(54,'CD','República Democrática del Congo'),(55,'CG','Congo'),(56,'CK','Islas Cook'),(57,'KP','Corea del Norte'),(58,'KR','Corea del Sur'),(59,'CI','Costa de Marfil'),(60,'CR','Costa Rica'),(61,'HR','Croacia'),(62,'CU','Cuba'),(63,'DK','Dinamarca'),(64,'DM','Dominica'),(65,'DO','República Dominicana'),(66,'EC','Ecuador'),(67,'EG','Egipto'),(68,'SV','El Salvador'),(69,'AE','Emiratos Árabes Unidos'),(70,'ER','Eritrea'),(71,'SK','Eslovaquia'),(72,'SI','Eslovenia'),(73,'ES','España'),(74,'UM','Islas ultramarinas de Estados Unidos'),(75,'US','Estados Unidos'),(76,'EE','Estonia'),(77,'ET','Etiopía'),(78,'FO','Islas Feroe'),(79,'PH','Filipinas'),(80,'FI','Finlandia'),(81,'FJ','Fiyi'),(82,'FR','Francia'),(83,'GA','Gabón'),(84,'GM','Gambia'),(85,'GE','Georgia'),(86,'GS','Islas Georgias del Sur y Sandwich del Sur'),(87,'GH','Ghana'),(88,'GI','Gibraltar'),(89,'GD','Granada'),(90,'GR','Grecia'),(91,'GL','Groenlandia'),(92,'GP','Guadalupe'),(93,'GU','Guam'),(94,'GT','Guatemala'),(95,'GF','Guayana Francesa'),(96,'GN','Guinea'),(97,'GQ','Guinea Ecuatorial'),(98,'GW','Guinea-Bissau'),(99,'GY','Guyana'),(100,'HT','Haití'),(101,'HM','Islas Heard y McDonald'),(102,'HN','Honduras'),(103,'HK','Hong Kong'),(104,'HU','Hungría'),(105,'IN','India'),(106,'ID','Indonesia'),(107,'IR','Irán'),(108,'IQ','Iraq'),(109,'IE','Irlanda'),(110,'IS','Islandia'),(111,'IL','Israel'),(112,'IT','Italia'),(113,'JM','Jamaica'),(114,'JP','Japón'),(115,'JO','Jordania'),(116,'KZ','Kazajstán'),(117,'KE','Kenia'),(118,'KG','Kirguistán'),(119,'KI','Kiribati'),(120,'KW','Kuwait'),(121,'LA','Laos'),(122,'LS','Lesotho'),(123,'LV','Letonia'),(124,'LB','Líbano'),(125,'LR','Liberia'),(126,'LY','Libia'),(127,'LI','Liechtenstein'),(128,'LT','Lituania'),(129,'LU','Luxemburgo'),(130,'MO','Macao'),(131,'MK','ARY Macedonia'),(132,'MG','Madagascar'),(133,'MY','Malasia'),(134,'MW','Malawi'),(135,'MV','Maldivas'),(136,'ML','Malí'),(137,'MT','Malta'),(138,'FK','Islas Malvinas'),(139,'MP','Islas Marianas del Norte'),(140,'MA','Marruecos'),(141,'MH','Islas Marshall'),(142,'MQ','Martinica'),(143,'MU','Mauricio'),(144,'MR','Mauritania'),(145,'YT','Mayotte'),(146,'MX','México'),(147,'FM','Micronesia'),(148,'MD','Moldavia'),(149,'MC','Mónaco'),(150,'MN','Mongolia'),(151,'MS','Montserrat'),(152,'MZ','Mozambique'),(153,'MM','Myanmar'),(154,'NA','Namibia'),(155,'NR','Nauru'),(156,'NP','Nepal'),(157,'NI','Nicaragua'),(158,'NE','Níger'),(159,'NG','Nigeria'),(160,'NU','Niue'),(161,'NF','Isla Norfolk'),(162,'NO','Noruega'),(163,'NC','Nueva Caledonia'),(164,'NZ','Nueva Zelanda'),(165,'OM','Omán'),(166,'NL','Países Bajos'),(167,'PK','Pakistán'),(168,'PW','Palau'),(169,'PS','Palestina'),(170,'PA','Panamá'),(171,'PG','Papúa Nueva Guinea'),(172,'PY','Paraguay'),(173,'PE','Perú'),(174,'PN','Islas Pitcairn'),(175,'PF','Polinesia Francesa'),(176,'PL','Polonia'),(177,'PT','Portugal'),(178,'PR','Puerto Rico'),(179,'QA','Qatar'),(180,'GB','Reino Unido'),(181,'RE','Reunión'),(182,'RW','Ruanda'),(183,'RO','Rumania'),(184,'RU','Rusia'),(185,'EH','Sahara Occidental'),(186,'SB','Islas Salomón'),(187,'WS','Samoa'),(188,'AS','Samoa Americana'),(189,'KN','San Cristóbal y Nevis'),(190,'SM','San Marino'),(191,'PM','San Pedro y Miquelón'),(192,'VC','San Vicente y las Granadinas'),(193,'SH','Santa Helena'),(194,'LC','Santa Lucía'),(195,'ST','Santo Tomé y Príncipe'),(196,'SN','Senegal'),(197,'CS','Serbia y Montenegro'),(198,'SC','Seychelles'),(199,'SL','Sierra Leona'),(200,'SG','Singapur'),(201,'SY','Siria'),(202,'SO','Somalia'),(203,'LK','Sri Lanka'),(204,'SZ','Suazilandia'),(205,'ZA','Sudáfrica'),(206,'SD','Sudán'),(207,'SE','Suecia'),(208,'CH','Suiza'),(209,'SR','Surinam'),(210,'SJ','Svalbard y Jan Mayen'),(211,'TH','Tailandia'),(212,'TW','Taiwán'),(213,'TZ','Tanzania'),(214,'TJ','Tayikistán'),(215,'IO','Territorio Británico del Océano Índico'),(216,'TF','Territorios Australes Franceses'),(217,'TL','Timor Oriental'),(218,'TG','Togo'),(219,'TK','Tokelau'),(220,'TO','Tonga'),(221,'TT','Trinidad y Tobago'),(222,'TN','Túnez'),(223,'TC','Islas Turcas y Caicos'),(224,'TM','Turkmenistán'),(225,'TR','Turquía'),(226,'TV','Tuvalu'),(227,'UA','Ucrania'),(228,'UG','Uganda'),(229,'UY','Uruguay'),(230,'UZ','Uzbekistán'),(231,'VU','Vanuatu'),(232,'VE','Venezuela'),(233,'VN','Vietnam'),(234,'VG','Islas Vírgenes Británicas'),(235,'VI','Islas Vírgenes de los Estados Unidos'),(236,'WF','Wallis y Futuna'),(237,'YE','Yemen'),(238,'DJ','Yibuti'),(239,'ZM','Zambia'),(240,'ZW','Zimbabue');
/*!40000 ALTER TABLE `paises` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedidos` (
  `id_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `name_cliente` varchar(100) NOT NULL,
  `nit_cliente` varchar(8) NOT NULL,
  `num_cliente` varchar(8) NOT NULL,
  `dir_cliente` varchar(80) NOT NULL,
  `fecha_pedido` date NOT NULL,
  `id_user` int(11) NOT NULL,
  `serie_pedido` varchar(100) NOT NULL,
  `total_pedido` varchar(17) NOT NULL,
  PRIMARY KEY (`id_pedido`),
  UNIQUE KEY `id_pedido` (`id_pedido`),
  KEY `fk_user` (`id_user`),
  CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `usuarios` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (13,'Enrique Maldonado','47841913','45873245','Quetzaltenango, Zona 3 12-890','2022-09-26',9,'H6637HD','244.608'),(14,'Consumidor Final','Ninguno','Ninguno','Ninguno','2022-09-26',9,'BIS732','1088.64'),(15,'Ana María Hernandez','76879684','46851685','Quetzaltenango, Zona 1 13-17','2022-09-26',9,'H78AGBAI','519.624'),(16,'Gabriela María Cifuentes','14651687','34274287','Ciudad de Quetzaltenango, Zona 1 73-12','2022-09-26',10,'SA98H','870.24'),(18,'Jorge Mario Estrada Gonsalez','85873490','85168746','Quetzaltenango, Zona 3, 19 Calle 12-77','2022-09-26',10,'H7YFERH','5310.8832'),(19,'Carlos Josué Herrera','67238962','34323454','Quetzaltenango, Zona 9 Calle 2 43-7','2022-09-26',10,'B7FD9I3','26.88'),(20,'Consumidor Final','Ninguno','Ninguno','Ninguno','2022-09-26',10,'BD8SB','143.36');
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `userpass` varchar(100) NOT NULL,
  `usertype` varchar(100) NOT NULL,
  `nombre_user` varchar(100) NOT NULL,
  `CUI_usuario` varchar(100) NOT NULL,
  `num_usuario` varchar(20) NOT NULL,
  `puesto_usuario` varchar(100) NOT NULL,
  `correo_usuario` varchar(100) NOT NULL,
  `img_usuario` varchar(1000) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (8,'pacabrera2005','ew2pPB/C6DEEE2vpa/6EXg==','Administrador','Pablo Andres Cabrera Arguello','151235152021','21356862','Encargado de Sistemas','pacabreraarguello2005@elvallecolegio.edu.gt','C:\\xampp\\htdocs\\php_bethesda\\ImgFarmacia\\Empleados\\pabloxd.jpg'),(9,'cevela2004','ItciuniKXiBhR6VZNJeahA==','Administrador','Carlos Eduardo Vela Alvarado','85986266641','35378433','Encargado de Sistemas','cevelaalvarado2004@elvallecolegio.edu.gt','C:\\Users\\gameg\\Desktop\\tarea\\ff84738f-6d94-4a8e-a744-0b58a0a91fa3.jpg'),(10,'hesanchez1992','UAG8oSrUvaP5vFdaP5ChzQ==','Vendedor','Hugo Eduardo Ramirez Sanchez','7892333','8855691','Vendedor','hesanchez@gmail.com','C:\\xampp\\htdocs\\php_bethesda\\ImgFarmacia\\Empleados\\peinado-hacia-atraxxs-hombre4-300x300.jpg');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'registrofarmacia'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-27 18:47:16
