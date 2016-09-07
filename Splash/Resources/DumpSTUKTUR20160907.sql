CREATE DATABASE  IF NOT EXISTS `db_apps` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `db_apps`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: db_apps
-- ------------------------------------------------------
-- Server version	5.6.33-log

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
-- Table structure for table `districts`
--

DROP TABLE IF EXISTS `districts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `districts` (
  `id` char(7) COLLATE utf8_unicode_ci NOT NULL,
  `regency_id` char(4) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `districts_regency_id_index` (`regency_id`),
  CONSTRAINT `districts_regency_id_foreign` FOREIGN KEY (`regency_id`) REFERENCES `regencies` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `provinces`
--

DROP TABLE IF EXISTS `provinces`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `provinces` (
  `id` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
-- Table structure for table `regencies`
--

DROP TABLE IF EXISTS `regencies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `regencies` (
  `id` char(4) COLLATE utf8_unicode_ci NOT NULL,
  `province_id` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `regencies_province_id_index` (`province_id`),
  CONSTRAINT `regencies_province_id_foreign` FOREIGN KEY (`province_id`) REFERENCES `provinces` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `temp_items`
--

DROP TABLE IF EXISTS `temp_items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `temp_items` (
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
-- Table structure for table `temp_subproject`
--

DROP TABLE IF EXISTS `temp_subproject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `temp_subproject` (
  `ID` int(11) DEFAULT NULL,
  `PROJECTNAME` varchar(255) DEFAULT NULL,
  `PROJECTSUBCLIENT` varchar(255) DEFAULT NULL,
  `TOTALUNITS` int(11) DEFAULT NULL,
  `PROJECTMAIN` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `temp_workorder`
--

DROP TABLE IF EXISTS `temp_workorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `temp_workorder` (
  `ID` int(11) DEFAULT NULL,
  `WO_INVOICE` varchar(255) DEFAULT NULL,
  `WO_NO` varchar(255) DEFAULT NULL,
  `WO_DATE` datetime DEFAULT NULL,
  `UserPerekam` varchar(255) DEFAULT NULL,
  `TanggalRekam` varchar(255) DEFAULT NULL,
  `UserUpdate` varchar(255) DEFAULT NULL,
  `TanggalUpdate` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `ID_USER` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(16) NOT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `UserRole` int(1) DEFAULT NULL COMMENT '0 as Administrator\r\n1 as Standard User\r\n2 as Superuser\r\n3 as technical',
  `JobTitle` varchar(255) DEFAULT NULL,
  `UserFName` varchar(255) DEFAULT NULL,
  `UserLName` varchar(255) DEFAULT NULL,
  `GrantAccess` varchar(5) DEFAULT NULL,
  `KdGroup` varchar(2) DEFAULT NULL,
  `nip_user` varchar(50) DEFAULT NULL,
  `Last_Login` datetime DEFAULT NULL,
  `Uaktif` varchar(2) DEFAULT NULL,
  `JobDesk` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_USER`),
  KEY `Username` (`Username`),
  KEY `PrimaryKey` (`ID_USER`),
  KEY `ID_USER` (`ID_USER`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `villages`
--

DROP TABLE IF EXISTS `villages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `villages` (
  `id` char(10) COLLATE utf8_unicode_ci NOT NULL,
  `district_id` char(7) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `villages_district_id_index` (`district_id`),
  CONSTRAINT `villages_district_id_foreign` FOREIGN KEY (`district_id`) REFERENCES `districts` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-07 11:09:12
