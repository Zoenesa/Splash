-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: localhost    Database: db_apps
-- ------------------------------------------------------
-- Server version	5.6.31-log

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
-- Table structure for table `bast`
--

DROP TABLE IF EXISTS `bast`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bast` (
  `NOBAST` varchar(255) NOT NULL DEFAULT '',
  `Tanggal` varchar(255) DEFAULT NULL,
  `NamaPelanggan` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`NOBAST`),
  UNIQUE KEY `NOBAST` (`NOBAST`),
  KEY `Tanggal` (`Tanggal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bast`
--

LOCK TABLES `bast` WRITE;
/*!40000 ALTER TABLE `bast` DISABLE KEYS */;
INSERT INTO `bast` VALUES ('121','27/07/2016','PT. A','17/08/2016','17/08/2016'),('122','27/07/2016','PT. B','18/08/2016','18/08/2016'),('123','27/07/2016','PT. C','19/08/2016','19/08/2016');
/*!40000 ALTER TABLE `bast` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `companyprofile`
--

DROP TABLE IF EXISTS `companyprofile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `companyprofile` (
  `NamaPerusahaan` varchar(255) NOT NULL DEFAULT '',
  `NPWP` varchar(255) DEFAULT NULL,
  `AlamatKantor` varchar(255) DEFAULT NULL,
  `Provinsi` varchar(255) DEFAULT NULL,
  `Kabupaten` varchar(255) DEFAULT NULL,
  `Kecamatan` varchar(255) DEFAULT NULL,
  `Kelurahan` varchar(255) DEFAULT NULL,
  `KodePos` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `NoTelpon` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`NamaPerusahaan`),
  FULLTEXT KEY `NamaPerusahaan` (`NamaPerusahaan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `companyprofile`
--

LOCK TABLES `companyprofile` WRITE;
/*!40000 ALTER TABLE `companyprofile` DISABLE KEYS */;
INSERT INTO `companyprofile` VALUES ('PT. SENTOSA INDORAYA PERKASA','313430084451000','Jalan Tigaraksa - Cisoka, Perum Triraksa Village 1 Blok A No.01','Banten','Tangerang','Tigaraksa','Tigaraksa','15720','pt.sentosaindorayaperkasa@yahoo.com','021-5996415','Admin','20/08/2016','Admin','20/08/2016');
/*!40000 ALTER TABLE `companyprofile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `data_customer`
--

DROP TABLE IF EXISTS `data_customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `data_customer` (
  `ID` int(11) DEFAULT NULL,
  `Cust_Name` varchar(255) DEFAULT NULL,
  `Cust_Address` varchar(255) DEFAULT NULL,
  `Cust_Phone` varchar(255) DEFAULT NULL,
  `Cust_Mail` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` date DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `data_customer`
--

LOCK TABLES `data_customer` WRITE;
/*!40000 ALTER TABLE `data_customer` DISABLE KEYS */;
INSERT INTO `data_customer` VALUES (1,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B23','021-594009448','pt.mup.developer@gmail.com',NULL,NULL,NULL,'2016-08-19');
/*!40000 ALTER TABLE `data_customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `data_proyek`
--

DROP TABLE IF EXISTS `data_proyek`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `data_proyek` (
  `ID_Proyek` int(11) DEFAULT NULL,
  `Nama_Proyek` varchar(255) DEFAULT NULL,
  `Lokasi_Proyek` varchar(255) DEFAULT NULL,
  `Owner_Proyek` varchar(255) DEFAULT NULL,
  `Main_Contractor` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `data_proyek`
--

LOCK TABLES `data_proyek` WRITE;
/*!40000 ALTER TABLE `data_proyek` DISABLE KEYS */;
INSERT INTO `data_proyek` VALUES (1,'BAJA RINGAN TRIRAKSA VILLAGE','PERUMAHAN TRIRAKSA VILLAGE','PT. MITRA USAHA PERKASA','PT. MITRA USAHA PERKASA',NULL,'17/08/2016',NULL,'17/08/2016'),(2,'BAJA RINGAN TRIRAKSA VILLAGE 2','PERUMAHAN TRIRAKSA VILLAGE 2','PT. MITRA USAHA PERKASA','PT. MITRA USAHA PERKASA',NULL,'18/08/2016',NULL,'18/08/2016'),(3,'BAJA RINGAN PARAMOUNT SERPONG','CLUSTER VIRGINIA','PARAMOUNT ENTERPRISE INDONESIA','PT. SRIARTAMA SUKSES',NULL,'19/08/2016',NULL,'19/08/2016'),(4,'BAJA RINGAN PARAMOUNT SERPONG','CLUSTER ARCADIA','PARAMOUNT ENTERPRISE INDONESIA','PT. SERUNI HARUM MAS',NULL,'19/08/2016',NULL,'19/08/2016');
/*!40000 ALTER TABLE `data_proyek` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `databast`
--

DROP TABLE IF EXISTS `databast`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `databast` (
  `RecordNo` int(11) NOT NULL DEFAULT '0',
  `NoBAST` varchar(255) DEFAULT NULL,
  `TanggalBAST` date DEFAULT NULL,
  `NamaPelanggan` varchar(255) DEFAULT NULL,
  `DeskripsiBAST` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` date DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` date DEFAULT NULL,
  PRIMARY KEY (`RecordNo`),
  KEY `NoBAST` (`NoBAST`,`NamaPelanggan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `databast`
--

LOCK TABLES `databast` WRITE;
/*!40000 ALTER TABLE `databast` DISABLE KEYS */;
/*!40000 ALTER TABLE `databast` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `datatemp`
--

DROP TABLE IF EXISTS `datatemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `datatemp` (
  `ID` int(11) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datatemp`
--

LOCK TABLES `datatemp` WRITE;
/*!40000 ALTER TABLE `datatemp` DISABLE KEYS */;
INSERT INTO `datatemp` VALUES (1,'Aplikasi Data Proyek','database');
/*!40000 ALTER TABLE `datatemp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoicedata`
--

DROP TABLE IF EXISTS `invoicedata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoicedata` (
  `RecordNo` int(11) NOT NULL AUTO_INCREMENT,
  `InvoiceNo` longtext,
  `InvoiceDate` date DEFAULT NULL,
  `InvoiceType` int(1) DEFAULT NULL,
  `InvoiceClient` longtext,
  `InvoiceClientAddress` longtext,
  `InvoiceWorkOrderSPK` longtext,
  `InvoiceLisence` longtext,
  `InvoiceProgress` double DEFAULT NULL,
  `InvoiceTerm` double DEFAULT NULL,
  `InvoiceItemsRecords` varchar(255) DEFAULT NULL,
  `InvoiceTotalItems` double DEFAULT NULL,
  `InvoicePaymentsRecord` double DEFAULT NULL,
  `InvoiceAfterTermyn` double DEFAULT NULL,
  `InvoiceTaxPrice` double DEFAULT NULL,
  `InvoiceTerbilang` longtext,
  `IndexProject` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`RecordNo`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoicedata`
--

LOCK TABLES `invoicedata` WRITE;
/*!40000 ALTER TABLE `invoicedata` DISABLE KEYS */;
INSERT INTO `invoicedata` VALUES (3,'0004/SIP.INV/IV/2016','2016-04-07',1,'PT. SRIARTAMA SUKSES','Jl. Boulevard Raya-Ruko The Green Court C No.15 RT05/14 Cengkareng Timur Telp. 021-22523187,88,89 Fax. 021-22520925 Jakarta 11730','11/Y.16/SS/XI/2015','014/BAST-SIP/II/2016',100,95,'2',51471240,0,48897678,4889767.8,'Lima puluh satu juta empat ratus tujuh puluh satu ribu dua ratus empat puluh','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(4,'0005/SIP.INV-J/IV/2016','2016-04-07',2,'PT. SRIARTAMA SUKSES','Jl. Boulevard Raya-Ruko The Green Court C No.15 RT05/14 Cengkareng Timur Telp. 021-22523187,88,89 Fax. 021-22520925 Jakarta 11730','11/Y.16/SS/XI/2015','014/BAST-SIP/II/2016',100,95,'2',5550820,0,5273279,527327.9,'Lima juta delapan ratus ribu enam ratus enam rupiah sembilan puluh sen','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA','AGUNGJAWATA','12/05/2016','AGUNGJAWATA','12/05/2016'),(5,'0006/SIP.INV/IV/2016','2016-04-07',1,'PT. HUNIPERSADA CITRANUSA','Jl. Griya Agung No. 59, Griya Ini Sentosa, Sunter Agung Podomoro, Jakarta 14350, Telp. 021-6404222','PS-VRNV-022/HPC/XII/2015','016/BAST-SIP/II/2016',100,100,'4',63631680,0,63631680,6363168,'Enam puluh sembilan juta sembilan ratus sembilan puluh empat ribu delapan ratus empat puluh delapan rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA','AGUNGJAWATA','12/05/2016','AGUNGJAWATA','12/05/2016'),(6,'0007/SIP.INV-J/IV/2016','2016-04-07',2,'PT. HUNIPERSADA CITRANUSA','Jl. Griya Agung No. 59, Griya Ini Sentosa, Sunter Agung Podomoro, Jakarta 14350, Telp. 021-6404222','PS-VRNV-022-J/HPC/XII/15','016/BAST-SIP/II/2016',100,100,'4',6862240,0,6862240,686224,'Tujuh juta lima ratus empat puluh delapan ribu empat ratus enam puluh empat rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(7,'0008/SIP.INV/IV/2016','2016-04-07',1,'PT. SERUNI HARUMMAS','Jl. PLUIT MAS IV Blok D No. 5A Jakarta Utara Telp. 021-6619358','950/SHM/PO/XI/15','016/BAST-SIP/II/2016',100,100,'2',51471240,0,51471240,5147124,'Lima puluh enam juta enam ratus delapan belas ribu tiga ratus enam puluh empat rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(8,'0009/SIP.INV-J/IV/2016','2016-04-07',2,'PT. SERUNI HARUMMAS','Jl. PLUIT MAS IV Blok D No. 5A Jakarta Utara Telp. 021-6619358','950/SHM/PO/XI/15','016/BAST-SIP/II/2016',100,100,'2',5550820,0,5550820,555082,'Enam juta seratus lima ribu sembilan ratus dua rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(9,'0010/SIP.INV/V/2016','2016-05-13',1,'PT. SURYA PRATAMA','Jl. Kartini IV No. 15A,Sawah Besar - Jakarta Pusat Telp. 021-6241860 Fax. 021-6252153','6413/Arcadia Paramount/JKT/IX/15','020/BAST-SIP/II/2016',100,95,'6',123614040,0,117433338,11743334,'Seratus tiga juta lima ratus tiga belas ribu delapan ratus dua belas rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(10,'0010/SIP.INV-J/V/2016','2016-05-13',2,'PT. SURYA PRATAMA','Jl. Kartini IV No. 15A,Sawah Besar - Jakarta Pusat Telp. 021-6241860 Fax. 021-6252153','6413/Arcadia Paramount/JKT/IX/15','020/BAST-SIP/II/2016',100,95,'6',20915390,0,19869620.5,1986962.05,'Dua puluh satu juta delapan ratus lima puluh enam ribu lima ratus delapan puluh dua rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(11,'0013/SIP.INV/V/2016','2016-05-13',1,'PT. IKABANGUN ARTISTIKA','Taman Alfa Indah Blok C2/16, Joglo Jakarta Barat Telp. 021-5843270 Fax. 021-5843270','139/ClusterArcadia-Paramount/1A/I/2016','026/BAST-SIP/II/2016',100,90,'6',108524460,0,97672014,9767201.4,'Seratus tiga belas juta empat ratus delapan ribu enam puluh rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(12,'0013/SIP.INV-J/V/2016','2016-05-13',2,'PT. IKABANGUN ARTISTIKA','Taman Alfa Indah Blok C2/16, Joglo Jakarta Barat Telp. 021-5843270 Fax. 021-5843270','139/Cluster Arcadia-Paramount/1A/I/2016','026/BAST-SIP/II/2016',100,90,'6',18219560,0,16397604,1639760.4,'Delapan belas juta tiga puluh tujuh ribu tiga ratus enam puluh empat rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(13,'0015/SIP.INV/V/2016','2016-05-13',1,'PT. GANDA WISESA MAKMUR','Jl. Surya Utama Raya Blok V No. 29 Sunrise Garden Jakarta Barat Telp. 021-5808702 Fax. 021-5607149','01/GM/SIP/11/2015','022/BAST-SIP/II/2016',100,95,'6',121668360,0,115584942,11558494.2,'Seratus dua puluh tujuh juta seratus empat puluh tiga ribu empat ratus tiga puluh enam rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(14,'0015/SIP.INV-J/V/2016','2016-05-13',2,'PT. GANDA WISESA MAKMUR','Jl. Surya Utama Raya Blok V No. 29 Sunrise Garden Jakarta Barat Telp. 021-5808702 Fax. 021-5607149','01/GM/SIP/11/2015','022/BAST-SIP/II/2016',100,95,'6',20635960,0,19604162,1960416.2,'Dua puluh satu juta lima ratus enam puluh empat ribu lima ratus tujuh puluh delapan rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(15,'0016/SIP.INV/IV/2016','2016-04-19',1,'PT. BANGUN PRIMA SENTOSA','Taman Semanan Blok C No. 29 Semanan, email : bpsjkt@gmail.com','/rangka atap/arcadia village/I/2016','024/BAST-SIP/III/2016',100,90,'4',57796260,0,52016634,5201663.4,'Lima puluh tujuh juta tujuh ratus sembilan puluh enam ribu dua ratus enam puluh rupiah','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(16,'0016/SIP.INV-J/IV/2016','2016-04-19',2,'PT. BANGUN PRIMA SENTOSA','Taman Semanan Blok C No. 29 Semanan, email : bpsjkt@gmail.com','/rangka atap/arcadia village/I/2016','024/BAST-SIP/III/2016',100,90,'4',6232930,0,5609637,560963.7,'Enam juta dua ratus tiga puluh dua ribu sembilan ratus tiga puluh rupiah','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','13/05/2016','AGUNGJAWATA','13/05/2016'),(17,'0017/SIP.INV/V/2016','2016-05-13',1,'PT. GRIYARONA ANDALAN PRATAMA','Komp. Pert. Kebon Jeruk Permai Blok C/18, Jakarta Barat Telp/Fax. 021-5491193','100/GAP-ARCADIA/I/2016','025//BAST-SIP/II/2016',100,100,'6',121668360,0,121668360,12166836,'Seratus dua puluh satu rupiah enam puluh tujuh sen','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(18,'0017/SIP.INV-J/V/2016','2016-05-13',2,'PT. GRIYARONA ANDALAN PRATAMA','Komp. Pert. Kebon Jeruk Permai Blok C/18, Jakarta Barat Telp/Fax. 021-5491193','100/GAP-ARCADIA/I/2016','025/BAST-SIP/II/2016',100,100,'6',20635960,0,20635960,2063596,'Dua puluh dua juta enam ratus sembilan puluh sembilan ribu lima ratus lima puluh enam rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ARCADIA','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(19,'0023/SIP.INV/V/2016','2016-05-17',1,'PT. LAUTAN GRAHA MAS','RUKO GOLDEN BOULEVARD BLOK O NO. 8 BSD - SERPONG','00329/PR-ATL17/4/2016','028/BAST-SIP/V/2016',100,95,'2',129412290,0,122941675.5,12294167.55,'Seratus dua puluh dua rupiah sembilan puluh empat sen','BAJA RINGAN PARAMOUNT;CLUSTER ATLANTA','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(20,'0030/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','C1/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',55095300,0,55095300,5509530,'Lima puluh lima juta sembilan puluh lima ribu tiga ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(21,'0031/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','C2/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',42403100,0,42403100,4240310,'Empat puluh dua juta empat ratus tiga ribu seratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(22,'0032/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','C3/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',118666800,0,118666800,11866680,'Seratus delapan belas juta enam ratus enam puluh enam ribu delapan ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(23,'0033/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','C4/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',93238200,0,93238200,9323820,'Sembilan puluh tiga juta dua ratus tiga puluh delapan ribu dua ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(24,'0034/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','C5/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',101714400,0,101714400,10171440,'Seratus satu juta tujuh ratus empat belas ribu empat ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(25,'0035/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','C6/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',59333400,0,59333400,5933340,'Lima puluh sembilan juta tiga ratus tiga puluh tiga ribu empat ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(26,'0036/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','D1/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',46619100,0,46619100,4661910,'Empat puluh enam juta enam ratus sembilan belas ribu seratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(27,'0037/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','D2/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',63571500,0,63571500,6357150,'Enam puluh tiga juta lima ratus tujuh puluh satu ribu lima ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(28,'0038/SIP.INV/V/2016','2016-05-17',3,'PT. MITRA USAHA PERKASA','RUKO CIKUPA NIAGA MAS BLOK B NO 23 CIKUPA - TANGERANG','D3/SPK/MUP/2016','033/BAST-SIP/V/2016',100,100,'1',25428600,0,25428600,2542860,'Dua puluh lima juta empat ratus dua puluh delapan ribu enam ratus rupiah ','BAJA RINGAN TRIRAKSA VILLAGE;TRIRAKSA VILLAGE 2','AGUNGJAWATA','17/05/2016','AGUNGJAWATA','17/05/2016'),(29,'0039/SIP.INV/V/2016','2016-05-27',1,'PT. ASIA NUSA GRAHA','RUKO CRYSTAL 1 NO.02 JL. GADING RAYA GOLF BOULEVARD, GADING SERPONG - TANGERANG TELPON 021-54217633','ANG/05/05/16','DP1.ANGBJ/SIP/V/2016',100,20,'2',29391050,0,5878210,587821,'Enam juta empat ratus enam puluh enam ribu tiga puluh satu rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA 2','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016'),(30,'0040/SIP.INV/V/2016','2016-05-27',1,'PT. ASIA NUSA GRAHA','RUKO CRYSTAL 1 NO.02 JL. GADING RAYA GOLF BOULEVARD, GADING SERPONG - TANGERANG TELPON 021-54217633','ANG/07/05/16','DP1.ANGWF/SIP/V/2016',100,20,'2',2853500,0,570700,57070,'Enam ratus dua puluh tujuh ribu tujuh ratus tujuh puluh rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA 2','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016'),(31,'0041/SIP.INV/V/2016','2016-05-27',1,'PT. ASIA NUSA GRAHA','RUKO CRYSTAL 1 NO.02 JL. GADING RAYA GOLF BOULEVARD, GADING SERPONG - TANGERANG TELPON 021-54217633','ANG/06/05/2016','DP1.ANGLP/SIP/V/2016',100,20,'2',12421272.5,0,2484254.5,248425.45,'Dua rupiah empat puluh delapan sen','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA 2','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016'),(32,'0042/SIP.INV/V/2016','2016-05-27',1,'PT. LAUTAN GRAHA MAS','RUKO GOLDEN BOULEVARD BLOK O NO. 8 BSD - SERPONG','00329/PR-ATL17/4/16','028/BAST-SIP/V/2016',100,95,'2',128155860,0,121748067,12174806.7,'Seratus tiga puluh tiga juta sembilan ratus dua puluh dua ribu delapan ratus tujuh puluh tiga rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA 2','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016'),(33,'0043/SIP.INV-J/V/2016','2016-05-27',2,'PT. LAUTAN GRAHA MAS','RUKO GOLDEN BOULEVARD BLOK O NO. 8 BSD - SERPONG','00329/PT-ATL17/4/2016','028/BAST-SIP/V/2016',100,95,'2',13820730,0,13129693.5,1312969.35,'Empat belas juta empat ratus empat puluh dua ribu enam ratus enam puluh dua rupiah ','BAJA RINGAN PARAMOUNT;CLUSTER ATLANTA','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016'),(34,'0044/SIP.INV/V/2016','2016-05-27',1,'PT. BANGUN PRIMA SENTOSA','Alamat : Taman Semanan Blok C No. 29 Semanan, email : bpsjkt@gmail.com','/Lisplank/Archadia Village/V/2016','030/BAST-SIP/III/2016',100,95,'2',14132520,0,13425894,1342589.4,'Tiga belas rupiah empat puluh tiga sen','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA 2','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016'),(35,'0045/SIP.INV-J/V/2016','2016-05-27',2,'PT. BANGUN PRIMA SENTOSA','Alamat : Taman Semanan Blok C No. 29 Semanan, email : bpsjkt@gmail.com','/Lisplank/Archadia Village/V/2016','030/BAST-SIP/III/2016',100,95,'2',5888550,0,5594122.5,559412.25,'Lima rupiah lima puluh sembilan sen','BAJA RINGAN PARAMOUNT;CLUSTER VIRGINIA 2','AGUNGJAWATA','26/05/2016','AGUNGJAWATA','26/05/2016');
/*!40000 ALTER TABLE `invoicedata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items_invoice`
--

DROP TABLE IF EXISTS `items_invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `items_invoice` (
  `RecordID` int(11) NOT NULL AUTO_INCREMENT,
  `InvoiceNo` varchar(50) NOT NULL DEFAULT '',
  `Items` varchar(255) DEFAULT NULL,
  `Quantity` double DEFAULT NULL,
  `Price` double DEFAULT NULL,
  `TotalPrice` double DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`RecordID`,`InvoiceNo`),
  KEY `InvoiceIndex` (`InvoiceNo`)
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items_invoice`
--

LOCK TABLES `items_invoice` WRITE;
/*!40000 ALTER TABLE `items_invoice` DISABLE KEYS */;
INSERT INTO `items_invoice` VALUES (1,'0004/SIP.INV/IV/2016','Pengadaan Rangka Atap Baja Ringan Type 4X8 = 21 Unit',504.62,94500,47686590,NULL,NULL,NULL,'19/08/2016'),(2,'0004/SIP.INV/IV/2016','Pengadaan Woven Alumunium Foil Type 4X8 = 21 Unit',504.62,7500,3784650,NULL,NULL,NULL,'19/08/2016'),(3,'0005/SIP.INV-J/IV/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 4X8 = 21 Unit',504.62,8500,4289270,NULL,NULL,NULL,'19/08/2016'),(4,'0005/SIP.INV-J/IV/2016','Jasa Pemasangan Alumunium Foil',504.62,2500,1261550,NULL,NULL,NULL,'19/08/2016'),(5,'0006/SIP.INV/IV/2016','Pengadaan Rangka Atap Baja Ringan Type 4X8 = 21 Unit',460.74,94500,43539930,NULL,NULL,NULL,'19/08/2016'),(6,'0006/SIP.INV/IV/2016','Pengadaan Rangka Atap Baja Ringan Type 5X8 = 7 Unit',163.1,94500,15412950,NULL,NULL,NULL,'19/08/2016'),(7,'0006/SIP.INV/IV/2016','Pengadaan Woven Alumunium Foil Type 4X8 = 21 Unit',460.74,7500,3455550,NULL,NULL,NULL,'19/08/2016'),(8,'0006/SIP.INV/IV/2016','Pengadaan Woven Alumunium Foil Type 5X8 = 7 Unit',163.1,7500,1223250,NULL,NULL,NULL,'19/08/2016'),(9,'0007/SIP.INV-J/IV/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 4X8 = 21 Unit',460.74,8500,3916290,NULL,NULL,NULL,'19/08/2016'),(10,'0007/SIP.INV-J/IV/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 5X8 = 7 Unit',163.1,8500,1386350,NULL,NULL,NULL,'19/08/2016'),(11,'0007/SIP.INV-J/IV/2016','Jasa Pemasangan Woven Alumunium Foil Type 4X8 = 21 Unit',460.74,2500,1151850,NULL,NULL,NULL,'19/08/2016'),(12,'0007/SIP.INV-J/IV/2016','Jasa Pemasangan Woven Alumunium Foil Type 5X8 = 7 Unit',163.1,2500,407750,NULL,NULL,NULL,'19/08/2016'),(13,'0008/SIP.INV/IV/2016','Pengadaan Rangka Atap Baja Ringan Type 4X8 = 23 Unit',504.62,94500,47686590,NULL,NULL,NULL,'19/08/2016'),(14,'0008/SIP.INV/IV/2016','Pengadaan Woven Alumunium Foil Type 4X8 = 23 Unit',504.62,7500,3784650,NULL,NULL,NULL,'19/08/2016'),(15,'0009/SIP.INV-J/IV/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 4X8 = 23 Unit',504.62,8500,4289270,NULL,NULL,NULL,'19/08/2016'),(16,'0009/SIP.INV-J/IV/2016','Jasa Pemasangan Woven Alumunium Foil Type 4X8 = 23 Unit',504.62,2500,1261550,NULL,NULL,NULL,'19/08/2016'),(17,'0010/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 5X8 = 14 Unit',390.18,94500,36872010,NULL,NULL,NULL,'19/08/2016'),(18,'0010/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 6X8 = 16 Unit',580.96,94500,54900720,NULL,NULL,NULL,'19/08/2016'),(19,'0010/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 5X8 = 14 Unit',390.18,7500,2926350,NULL,NULL,NULL,'19/08/2016'),(20,'0010/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 6X8 = 16 Unit',580.96,7500,4357200,NULL,NULL,NULL,'19/08/2016'),(21,'0010/SIP.INV/V/2016','Pengadaan Lisplang Type 5X8 = 14 Unit',295.12,36000,10624320,NULL,NULL,NULL,'19/08/2016'),(22,'0010/SIP.INV/V/2016','Pengadaan Lisplang Type 6X8 = 16 Unit',387.04,36000,13933440,NULL,NULL,NULL,'19/08/2016'),(23,'0010/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 5X8 = 14 Unit',390.18,8500,3316530,NULL,NULL,NULL,'19/08/2016'),(24,'0010/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 6X8 = 16 Unit',580.96,8500,4938160,NULL,NULL,NULL,'19/08/2016'),(25,'0010/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 5X8 = 14 Unit',390.18,2500,975450,NULL,NULL,NULL,'19/08/2016'),(26,'0010/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 6X8 = 16 Unit',580.96,2500,1452400,NULL,NULL,NULL,'19/08/2016'),(27,'0010/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 5X8 = 14 Unit',295.12,15000,4426800,NULL,NULL,NULL,'19/08/2016'),(28,'0010/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 6X8 = 16 Unit',387.07,15000,5806050,NULL,NULL,NULL,'19/08/2016'),(29,'0013/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 5X8 = 6 Unit',167.22,94500,15802290,NULL,NULL,NULL,NULL),(30,'0013/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 6X8 = 19 Unit',689.89,94500,65194605,NULL,NULL,NULL,NULL),(31,'0013/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 5X8 = 6 Unit',167.22,7500,1254150,NULL,NULL,NULL,NULL),(32,'0013/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 6X8 = 19 Unit',689.89,7500,5174175,NULL,NULL,NULL,NULL),(33,'0013/SIP.INV/V/2016','Pengadaan Lisplang Type 5X8 = 6 Unit',126.48,36000,4553280,NULL,NULL,NULL,NULL),(34,'0013/SIP.INV/V/2016','Pengadaan Lisplang Type 6X8 = 19 Unit',459.61,36000,16545960,NULL,NULL,NULL,NULL),(35,'0013/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 5X8 = 6 Unit',167.22,8500,1421370,NULL,NULL,NULL,NULL),(36,'0013/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 6X8 = 19 Unit',689.89,8500,5864065,NULL,NULL,NULL,NULL),(37,'0013/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 5X8 = 6 Unit',167.22,2500,418050,NULL,NULL,NULL,NULL),(38,'0013/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 6X8 = 19 Unit',689.89,2500,1724725,NULL,NULL,NULL,NULL),(39,'0013/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 5X8 = 6 Unit',126.48,15000,1897200,NULL,NULL,NULL,NULL),(40,'0013/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 6X8 = 19 Unit',459.61,15000,6894150,NULL,NULL,NULL,NULL),(41,'0015/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 5X8 = 16 Unit',445.92,94500,42139440,NULL,NULL,NULL,NULL),(42,'0015/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 6X8 = 14 Unit',508.34,94500,48038130,NULL,NULL,NULL,NULL),(43,'0015/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 5X8 = 16 Unit',445.92,7500,3344400,NULL,NULL,NULL,NULL),(44,'0015/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 6X8 = 14 Unit',508.34,7500,3812550,NULL,NULL,NULL,NULL),(45,'0015/SIP.INV/V/2016','Pengadaan Lisplang Type 5X8 = 16 Unit',337.28,36000,12142080,NULL,NULL,NULL,NULL),(46,'0015/SIP.INV/V/2016','Pengadaan Lisplang Type 6X8 = 14 Unit',338.66,36000,12191760,NULL,NULL,NULL,NULL),(47,'0015/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 5X8 = 16 Unit',445.92,8500,3790320,NULL,NULL,NULL,NULL),(48,'0015/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 6X8 = 14 Unit',508.34,8500,4320890,NULL,NULL,NULL,NULL),(49,'0015/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 5X8 = 16 Unit',445.92,2500,1114800,NULL,NULL,NULL,NULL),(50,'0015/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 6X8 = 14 Unit',508.34,2500,1270850,NULL,NULL,NULL,NULL),(51,'0015/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 5X8 = 16 Unit',337.28,15000,5059200,NULL,NULL,NULL,NULL),(52,'0015/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 6X8 = 14 Unit',338.66,15000,5079900,NULL,NULL,NULL,NULL),(53,'0016/SIP.INV/IV/2016','Rangka Atap Baja Ringan Archadia (Lebar 5) 6 Unit',167.22,94500,15802290,NULL,NULL,NULL,NULL),(54,'0016/SIP.INV/IV/2016','Rangka Atap Baja Ringan Archadia (Lebar 6) 11 Unit',399.41,94500,37744245,NULL,NULL,NULL,NULL),(55,'0016/SIP.INV/IV/2016','Woven Alumunium Foil (Lebar 5) 6 Unit',167.22,7500,1254150,NULL,NULL,NULL,NULL),(56,'0016/SIP.INV/IV/2016','Woven Alumunium Foil (Lebar 6) 11 Unit',399.41,7500,2995575,NULL,NULL,NULL,NULL),(57,'0016/SIP.INV-J/IV/2016','Jasa Rangka Atap Bj. Ringan (Lebar 5) 6 Unit',167.22,8500,1421370,NULL,NULL,NULL,NULL),(58,'0016/SIP.INV-J/IV/2016','Jasa Rangka Atap Bj. Ringan (Lebar 6) 11 Unit',399.41,8500,3394985,NULL,NULL,NULL,NULL),(59,'0016/SIP.INV-J/IV/2016','Jasa Pasang Alumunium Foil (Lebar 5) 6 Unit',167.22,2500,418050,NULL,NULL,NULL,NULL),(60,'0016/SIP.INV-J/IV/2016','Jasa Pasang Alumunium Foil (Lebar 6) 11 Unit',399.41,2500,998525,NULL,NULL,NULL,NULL),(61,'0017/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 5X8 = 16 Unit',445.92,94500,42139440,NULL,NULL,NULL,NULL),(62,'0017/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 6X8 = 14 Unit',508.34,94500,48038130,NULL,NULL,NULL,NULL),(63,'0017/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 5X8 = 16 Unit',445.92,7500,3344400,NULL,NULL,NULL,NULL),(64,'0017/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 6X8 = 14 Unit',508.34,7500,3812550,NULL,NULL,NULL,NULL),(65,'0017/SIP.INV/V/2016','Pengadaan Lisplank Type 5X8 = 16 Unit',337.28,36000,12142080,NULL,NULL,NULL,NULL),(66,'0017/SIP.INV/V/2016','Pengadaan Lisplank Type 6X8 = 14 Unit',338.66,36000,12191760,NULL,NULL,NULL,NULL),(67,'0017/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 5X8 = 16 Unit',445.92,8500,3790320,NULL,NULL,NULL,NULL),(68,'0017/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 6X8 = 14 Unit',508.34,8500,4320890,NULL,NULL,NULL,NULL),(69,'0017/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 5X8 = 16 Unit',445.92,2500,1114800,NULL,NULL,NULL,NULL),(70,'0017/SIP.INV-J/V/2016','Jasa Pemasangan Woven Alumunium Foil Type 6X8 = 14 Unit',508.34,2500,1270850,NULL,NULL,NULL,NULL),(71,'0017/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 5X8 = 16 Unit',337.28,15000,5059200,NULL,NULL,NULL,NULL),(72,'0017/SIP.INV-J/V/2016','Jasa Pemasangan Lisplang Type 6X8 = 14 Unit',338.66,15000,5079900,NULL,NULL,NULL,NULL),(73,'0023/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 8X10 = 21 Unit',1256.43,94500,118732635,NULL,NULL,NULL,NULL),(74,'0023/SIP.INV/V/2016','Pengadaan Woven Alumunium Foil Type 8X10 = 21 Unit',1256.43,8500,10679655,NULL,NULL,NULL,NULL),(75,'0030/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 13 Unit',648.18,85000,55095300,NULL,NULL,NULL,NULL),(76,'0031/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 10 Unit',498.86,85000,42403100,NULL,NULL,NULL,NULL),(77,'0032/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 28 Unit',1396.08,85000,118666800,NULL,NULL,NULL,NULL),(78,'0033/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 22 Unit',1096.92,85000,93238200,NULL,NULL,NULL,NULL),(79,'0034/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30X60 = 24 Unit',1196.64,85000,101714400,NULL,NULL,NULL,NULL),(80,'0035/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 14 Unit',698.04,85000,59333400,NULL,NULL,NULL,NULL),(81,'0036/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 11 Unit',548.46,85000,46619100,NULL,NULL,NULL,NULL),(82,'0037/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 15 Unit',747.9,85000,63571500,NULL,NULL,NULL,NULL),(83,'0038/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 30/60 = 6 Unit',299.16,85000,25428600,NULL,NULL,NULL,NULL),(84,'0039/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 4X8 = 13 Unit',285.35,94500,26965575,NULL,NULL,NULL,NULL),(85,'0039/SIP.INV/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 4X8 = 13 Unit',285.35,8500,2425475,NULL,NULL,NULL,NULL),(86,'0040/SIP.INV/V/2016','Pengadaan Woven Foil Type 4X8 = 13 Unit',285.35,7500,2140125,NULL,NULL,NULL,NULL),(87,'0040/SIP.INV/V/2016','Jasa Pemasangan Woven Foil Type 4X8 = 13 Unit',285.35,2500,713375,NULL,NULL,NULL,NULL),(88,'0041/SIP.INV/V/2016','Pengadaan Lisplang Apluss Type 4X8 = 13 Unit',227.5,39599,9008772.5,NULL,NULL,NULL,NULL),(89,'0041/SIP.INV/V/2016','Jasa Pemasangan Lisplang Apluss Type 4X8 = 13 Unit',227.5,15000,3412500,NULL,NULL,NULL,NULL),(90,'0042/SIP.INV/V/2016','Pengadaan Rangka Atap Baja Ringan Type 8X10 = 21 Unit',1256.43,94500,118732635,NULL,NULL,NULL,NULL),(91,'0042/SIP.INV/V/2016','Pengadaan Wovel Alumunium Foil Type 8X10 = 21 Unit',1256.43,7500,9423225,NULL,NULL,NULL,NULL),(92,'0043/SIP.INV-J/V/2016','Jasa Pemasangan Rangka Atap Baja Ringan Type 8X10 = 21 Unit',1256.43,8500,10679655,NULL,NULL,NULL,NULL),(93,'0043/SIP.INV-J/V/2016','Jasa Pemasangan Wovel Alumunium Foil Type 8X10 = 21 Unit',1256.43,2500,3141075,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `items_invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `items_ref`
--

DROP TABLE IF EXISTS `items_ref`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `items_ref` (
  `ID` int(11) DEFAULT NULL,
  `ITMCOL_CODE` varchar(255) DEFAULT NULL,
  `ITMCOL_DESCRIPTIONS` longtext,
  `ITMCOL_QTY` double DEFAULT NULL,
  `ITMCOL_PRICE` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items_ref`
--

LOCK TABLES `items_ref` WRITE;
/*!40000 ALTER TABLE `items_ref` DISABLE KEYS */;
INSERT INTO `items_ref` VALUES (1,'ITM-BJ-PR15','Pengadaan Rangka Atap Baja Ringan',1,'94.500,00','User','2016-06-22 22:36:00','User','23/06/2016'),(2,'ITM-WV-PR15','Pengadaan Woven Alumunium',1,'7500','User','2016-06-22 22:36:00','User','23/06/2016'),(3,'ITM-LP-PR15','Pengadaan Lisplang Apluss',1,'36.900,00','User','2016-06-22 22:36:00','User','23/06/2016'),(4,'ITM-JBJ-PR15','Jasa Pemasangan Rangka Atap Baja Ringan',1,'8500','User','2016-06-23 04:13:37','User','23/06/2016'),(5,'ITM-JBJ2-PR15','1',0,'1','1',NULL,NULL,'23/06/2016'),(6,'ITM-JBJ3-PR15','Jasa',0,NULL,NULL,NULL,NULL,'23/06/2016'),(8,'ITM-JLP-PR15','Jasa Pemasangan Lisplang',1,'15000','User','2016-06-23 04:53:23','User','23/06/2016');
/*!40000 ALTER TABLE `items_ref` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `listworkorder`
--

DROP TABLE IF EXISTS `listworkorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `listworkorder` (
  `ID` int(11) NOT NULL,
  `WO_CLIENTNAME` varchar(255) DEFAULT NULL,
  `WO_NO` varchar(255) DEFAULT NULL,
  `WO_DATE` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `WO_NO` (`WO_NO`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `listworkorder`
--

LOCK TABLES `listworkorder` WRITE;
/*!40000 ALTER TABLE `listworkorder` DISABLE KEYS */;
INSERT INTO `listworkorder` VALUES (1,'PT. SRIARTAMA SUKSES','11/Y.16/SS/XI/2015','2016-04-07 00:00:00','Administrator','07/04/2016','Administrator','2016-04-07 00:00:00'),(2,'PT. HUNI PERSADA CITRANUSA','PS-VRNV-022/HPC/XII/2015','2016-04-07 00:00:00','Administrator','07/04/2016','Administrator','2016-04-07 00:00:00'),(3,'PT. SERUNI HARUM MAS','950/SHM/PO/XI/15','2016-04-07 00:00:00','Administrator','13/04/2016','Administrator','2016-05-13 00:00:00'),(4,'PT. BANGUN PRIMA SENTOSA','/rangka atap/arcadia village/I/2016','2016-04-19 00:00:00','Administrator','13/04/2016','Administrator','2016-05-13 00:00:00'),(5,'CV. SURYA PRATAMA','6413/Arcadia Paramount/JKT/IX/15','2016-05-13 00:00:00','Administrator','13/05/2016','Administrator','2016-05-13 00:00:00'),(6,'PT. IKA BANGUN ARTISTIKA','139/ClusterArcadia-Paramount/1A/I/2016','2016-05-13 00:00:00','Administrator','13/05/2016','Administrator','2016-05-13 00:00:00'),(7,'PT. GANDA WISESA MAKMUR','01/GM/SIP/11/2015','2016-05-13 00:00:00','Administrator','13/05/2016','Administrator','2016-04-19 00:00:00'),(8,'PT. GRIYARONA ANDALAN PRATAMA','100/GAP-ARCADIA/I/2016','2016-05-13 00:00:00','Administrator','13/05/2016','Administrator','2016-05-17 00:00:00'),(9,'PT. LAUTAN GRAHA MAS','00329/PR-ATL17/4/2016','2016-05-17 00:00:00','Administrator','17/05/2016','Administrator','2016-05-17 00:00:00'),(10,'PT. MITRA USAHA PERKASA','C1/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','17/05/2016','Administrator','2016-05-17 00:00:00'),(11,'PT. MITRA USAHA PERKASA','C2/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-17 00:00:00'),(12,'PT. MITRA USAHA PERKASA','C3/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-17 00:00:00'),(13,'PT. MITRA USAHA PERKASA','C4/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-17 00:00:00'),(14,'PT. MITRA USAHA PERKASA','C5/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-17 00:00:00'),(15,'PT. MITRA USAHA PERKASA','C6/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-17 00:00:00'),(16,'PT. MITRA USAHA PERKASA','D1/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(17,'PT. MITRA USAHA PERKASA','D2/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(18,'PT. MITRA USAHA PERKASA','D3/SPK/MUP/2016','2016-05-17 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(19,'PT. ASIA NUSA GRAHA','ANG/05/05/16','2016-05-27 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(20,'PT. ASIA NUSA GRAHA','ANG/07/05/16','2016-05-27 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(21,'PT. ASIA NUSA GRAHA','ANG/06/05/2016','2016-05-27 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(22,'PT. LAUTAN GRAHA MAS','00329/PR-ATL17/4/16','2016-05-27 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(23,'PT. BANGUN PRIMA SENTOSA','/Lisplank/Archadia Village/V/2016','2016-05-27 00:00:00','Administrator','27/05/2016','Administrator','2016-05-27 00:00:00'),(24,'PT. ANTAH BERANTAH','0551/AB/VI/2016','19/07/2016','Agung','19/07/2016','Superuser','19/07/2016 02:13:31');
/*!40000 ALTER TABLE `listworkorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patch`
--

DROP TABLE IF EXISTS `patch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patch` (
  `Counter` int(11) DEFAULT NULL,
  `Ide` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patch`
--

LOCK TABLES `patch` WRITE;
/*!40000 ALTER TABLE `patch` DISABLE KEYS */;
INSERT INTO `patch` VALUES (3,3);
/*!40000 ALTER TABLE `patch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_client`
--

DROP TABLE IF EXISTS `ref_client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_client` (
  `ID_NUM` int(12) DEFAULT NULL,
  `CLIENT_NAME` varchar(255) DEFAULT NULL,
  `CLIENT_IDTAX` varchar(15) NOT NULL DEFAULT '',
  `CLIENT_ADDRESS` varchar(255) DEFAULT NULL,
  `CLIENT_STATE` varchar(255) DEFAULT NULL,
  `CLIENT_CITY` varchar(255) DEFAULT NULL,
  `CLIENT_DISTRICT` varchar(255) DEFAULT NULL,
  `CLIENT_VILLAGE` varchar(255) DEFAULT NULL,
  `CLIENT_ZIPCODE` varchar(255) DEFAULT NULL,
  `CLIENT_PHONE` varchar(255) DEFAULT NULL,
  `CLIENT_MAIL` longtext,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CLIENT_IDTAX`),
  UNIQUE KEY `ID_NUM` (`ID_NUM`),
  UNIQUE KEY `CLIENT_NAME` (`CLIENT_NAME`),
  KEY `CLIENT_IDTAX` (`CLIENT_IDTAX`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_client`
--

LOCK TABLES `ref_client` WRITE;
/*!40000 ALTER TABLE `ref_client` DISABLE KEYS */;
INSERT INTO `ref_client` VALUES (6,'PT. SERUNI HARUM MAS','013185830041000','JL. PLUIT MAS IV Blok 5 Nomor 5A RT.018 RW.011','DKI JAKARTA','JAKARTA UTARA','PENJARINGAN','PEJAGALAN','14450','021-66193658','seruniharummas@gmail.com','administrator','04/06/2016','administrator','04/06/2016'),(2,'PT. SRIARTAMA SUKSES','013241195034000','Jl. Boulevard Raya-Ruko The Green Court C No.15 RT.05 RW.14','DKI JAKARTA','JAKARTA BARAT','CENGKARENG','CENGKARENG TIMUR','11730','021-22523187,88,89','sriartamasukses@yahoo.com','administrator','04/06/2016','administrator','04/06/2016'),(3,'PT. HUNIPERSADA CITRANUSA','016540247046000','Jl. Griya Agung No. 59 Blok A No.59 RT.001 RW.001','DKI JAKARTA','JAKARTA UTARA','TANJUNG PRIOK','SUNTER AGUNG','14350','021-6404222','admin@huni.com','administrator','04/06/2016','administrator','04/06/2016'),(4,'PT. MITRA USAHA PERKASA','213430032451000','JALAN CIKUPA - SERANG, RUKO CIKUPA NIAGA MAS BLOK B/23','BANTEN','TANGERANG','TIGARAKSA','TIGARAKSA','17510','021-5940-0948','pt.mup.developer@gmail.com','administrator','04/06/2016','administrator','04/06/2016'),(5,'PT. SENTOSA INDORAYA PERKASA','313430084451001','JALAN TIGARAKSA - CISOKA, PERUM TRIRAKSA VILLAGE BLOK A1/01','BANTEN','TANGERANG','TIGARAKSA','TIGARAKSA','17520','021-5996-415','sentosaindorayaperkasa@yahoo.com','administrator','04/06/2016','administrator','04/06/2016'),(7,'PT. ANTAH BRANTAH','332423355242000','JKT','DKI JKT','JKT PUSAT','DAAN MOGOT','PESING','12440','021-5999-9999','ADMIN@ANTAHBRANTAH.COM','user','13/06/2016','user','13/06/2016');
/*!40000 ALTER TABLE `ref_client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_profile`
--

DROP TABLE IF EXISTS `ref_profile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_profile` (
  `NPWP` longtext,
  `NAMA_WP_PROFILE` longtext,
  `ALAMAT` longtext,
  `NEGARA` longtext,
  `PROPINSI` longtext,
  `KOTA` longtext,
  `KODEPOS` longtext,
  `TELEPON` longtext,
  `EMAIL_PT` longtext,
  `NAME_OWNER` longtext,
  `NOWP_OWNER` longtext,
  `TITLE_OWNER` longtext,
  `ALAMAT_OWNER` longtext,
  `NEGARA_OWNER` longtext,
  `PROPINSI_OWNER` longtext,
  `KOTA_OWNER` longtext,
  `KODEPOS_OWNER` longtext,
  `TELPON_OWNER` longtext,
  `EMAIL_OWNER` longtext,
  `USER_CREATED` longtext,
  `DATE_CREATED` datetime DEFAULT NULL,
  `USER_UPDATE` longtext,
  `DATE_UPDATE` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_profile`
--

LOCK TABLES `ref_profile` WRITE;
/*!40000 ALTER TABLE `ref_profile` DISABLE KEYS */;
INSERT INTO `ref_profile` VALUES ('313430084451000','PT. SENTOSA INDORAYA PERKASA','Jalan Tigaraksa - Cisoka, Perum. Triraksa Village 2 Blok A1 No. 01','INDONESIA','Banten','Tangerang','17520','___-____-____','pt.sentosaindorayaperkasa@yahoo.com','ROBERT INDRA, S.KOM, MBA','313430084451000','Direktur','Citra Raya, Lagoon View','Indonesia','Banten','Tangerang','17510','(___)-____-____','pt.sentosaindorayaperkasa@yahoo.com','administrator','2016-05-24 09:42:40','administrator','2016-06-04 06:35:47');
/*!40000 ALTER TABLE `ref_profile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_projectdata`
--

DROP TABLE IF EXISTS `ref_projectdata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_projectdata` (
  `ID_PROJECT` int(11) DEFAULT NULL,
  `PROJECTNAME` varchar(255) DEFAULT NULL,
  `PROJECTLOCATION` varchar(255) DEFAULT NULL,
  `SUBPROJECT` int(11) DEFAULT NULL,
  `REMARKS` varchar(255) DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_projectdata`
--

LOCK TABLES `ref_projectdata` WRITE;
/*!40000 ALTER TABLE `ref_projectdata` DISABLE KEYS */;
INSERT INTO `ref_projectdata` VALUES (1,'BAJA RINGAN TRIRAKSA VILLAGE','TIGARAKSA, BANTEN',3,'PEKERJAAN BAJA RINGAN TERPASANG',NULL,NULL,NULL,'19/08/2016'),(2,'BAJA RINGAN TRIRAKSA  VILLAGE 2','TIGARAKSA, BANTEN',2,'PEKERJAAN RANGKA ATAP BAJA RINGAN TERPASANG',NULL,NULL,NULL,'19/08/2016'),(3,'BAJA RINGAN PARAMOUNT','SERPONG, TANGERANG',3,'BAJA RINGAN TERPASANG',NULL,NULL,NULL,'19/08/2016'),(4,'BAJA RINGAN PARAMOUNT 2','SERPONG TANGERANG',2,'BAJA RINGAN TERPASANG',NULL,NULL,NULL,'19/08/2016');
/*!40000 ALTER TABLE `ref_projectdata` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ref_user`
--

DROP TABLE IF EXISTS `ref_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ref_user` (
  `ID_USER` int(11) DEFAULT NULL,
  `UNAME` varchar(50) DEFAULT NULL,
  `UPWD` varchar(50) DEFAULT NULL,
  `KDGROUP` varchar(2) DEFAULT NULL,
  `NIP_USER` varchar(50) DEFAULT NULL,
  `NM_USER` varchar(50) DEFAULT NULL,
  `ALAMAT` varchar(50) DEFAULT NULL,
  `KOTA` varchar(50) DEFAULT NULL,
  `LAST_LOGIN` datetime DEFAULT NULL,
  `UAKTIF` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ref_user`
--

LOCK TABLES `ref_user` WRITE;
/*!40000 ALTER TABLE `ref_user` DISABLE KEYS */;
INSERT INTO `ref_user` VALUES (1,'Administrator','di5t0rti0n','00','000000000','Administrator',NULL,NULL,NULL,'T'),(12,'User','123','01','000000000','Administrator',NULL,NULL,NULL,'T');
/*!40000 ALTER TABLE `ref_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-20 13:05:34
