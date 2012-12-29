-- MySQL dump 10.13  Distrib 5.5.9, for Win32 (x86)
--
-- Host: localhost    Database: sadl_mb
-- ------------------------------------------------------
-- Server version	5.5.15

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
-- Current Database: `sadl_mb`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `sadl_mb` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `sadl_mb`;

--
-- Table structure for table `agents`
--

DROP TABLE IF EXISTS `agents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `agents` (
  `agent_id` varchar(45) NOT NULL,
  `agent_rank` varchar(45) DEFAULT NULL,
  `agent_designation` varchar(45) DEFAULT NULL,
  `agent_nationality` varchar(45) DEFAULT NULL,
  `agent_educational_qualification` varchar(45) DEFAULT NULL,
  `agent_nominee_name` varchar(45) DEFAULT NULL,
  `agent_nominee_dob` date DEFAULT NULL,
  `agent_nominee_relationship` varchar(45) DEFAULT NULL,
  `agent_introducer_id` varchar(45) DEFAULT NULL,
  `agent_branch_id` varchar(45) DEFAULT NULL,
  `agent_name` varchar(45) DEFAULT NULL,
  `agent_father_husband_name` varchar(45) DEFAULT NULL,
  `agent_address` varchar(88) DEFAULT NULL,
  `agent_pin_code` varchar(45) DEFAULT NULL,
  `agent_state` varchar(45) DEFAULT NULL,
  `agent_phone_number` varchar(45) DEFAULT NULL,
  `agent_blood_group` varchar(45) DEFAULT NULL,
  `agent_dob` date DEFAULT NULL,
  `agent_join_date` date DEFAULT NULL,
  PRIMARY KEY (`agent_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agents`
--

LOCK TABLES `agents` WRITE;
/*!40000 ALTER TABLE `agents` DISABLE KEYS */;
INSERT INTO `agents` VALUES ('Agent-Bally-01','1','JAVA DEV','INDIAN','BTECH','KUDDUS','2010-03-04','Uncle','12','maldah','amit paul','PK PAUL','BARASAT','700124','WEST BENGAL','9231919212','B','1987-11-24','2012-03-04'),('Agent-Bally-02','13','ORACLE','INDIAN','NCA','SIDDHARTHA NANDY','1987-12-11','BROTHER','123454','HOOGLY','SUMAN NANDY','DEBABRATA NANDY','BANAMALIPUR, NEAR 5 STAR CLUB','700124','WestBengal','876656','A','1999-01-28','2012-02-29'),('Agent-Bally-03','3','DEVELOPER','INDIAN','BCOM','SUMIT PAUL','2009-01-17','SON','29893823','heaven','DINESH PAUL','ABHIRUP PAUL','NILGUNJ, NEAR BANKIM SCHOOL','700134','BIHAR','6567889','O','1980-08-23','2012-03-04'),('Agent-Bally-04','22','CODER','AMERICAN','BTECH','RAKESH BAIDYA','2011-12-28','FRIENDS','2345','DELHI','RAJESH BAIDYA','JOY RAJ BAIDYA','NOA PARA BARASAT','700123','WEST BENGAL','77675767','AB','2006-02-02','2012-03-04'),('Agent-Bally-40973.8186207986','15','Manager','Indian','Msc','Bishal','2012-03-16','brother','Amit','bally','Kingshuk Naskar','Shyam Naskar','Joypur','700145','West Bengal','9832145678','A','1992-03-22','2011-03-21'),('Agent-Bally-40973.8266445023','15','Owner','Indian','MSc','Bipasa','2012-03-14','wife','amlan','bally','Shubhankar Dhara','Shitol Chandra Dhara','Bally','740156','Wb','321456789','B','2012-03-07','1972-03-22');
/*!40000 ALTER TABLE `agents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `appointments` (
  `appointment_id` int(11) NOT NULL,
  `appointment_taker_name` varchar(45) NOT NULL,
  `appointment_taker_contact_info` varchar(100) DEFAULT NULL,
  `apointment_date_time` datetime DEFAULT NULL,
  `appointment_personnel_name` varchar(45) DEFAULT NULL,
  `appointment_personnel_acknowledgement` tinyint(1) DEFAULT NULL,
  `appointment_status` tinyint(1) DEFAULT NULL,
  `appointment_reason` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`appointment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1233,'amit','4563',NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clients` (
  `client_id` varchar(45) NOT NULL,
  `client_name` varchar(45) DEFAULT NULL,
  `client_dob` date DEFAULT NULL,
  `client_joint_applicant_name` varchar(45) DEFAULT NULL,
  `client_joint_applicant_dob` date DEFAULT NULL,
  `client_gurdain_father_husband_name` varchar(45) DEFAULT NULL,
  `client_address` varchar(100) DEFAULT NULL,
  `client_pin_code` varchar(45) DEFAULT NULL,
  `client_phone_number` varchar(45) DEFAULT NULL,
  `client_occupation` varchar(45) DEFAULT NULL,
  `client_nominee_name` varchar(45) DEFAULT NULL,
  `client_nominee_dob` date DEFAULT NULL,
  `client_nominee_relationship` varchar(45) DEFAULT NULL,
  `client_plan` varchar(45) DEFAULT NULL,
  `client_proposed_value` double DEFAULT NULL,
  `client_period_month` int(11) DEFAULT NULL,
  `client_payment_mode` varchar(45) DEFAULT NULL,
  `client_payment_amount_instalment` double DEFAULT NULL,
  `client_payment_amount_service_charge` double DEFAULT NULL,
  `client_payment_amount_total` double DEFAULT NULL,
  `client_payment_receipt_number` varchar(45) DEFAULT NULL,
  `client_introducer_id` varchar(45) DEFAULT NULL,
  `client_join_date` date DEFAULT NULL,
  PRIMARY KEY (`client_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES ('Client-Bally-01','partha','2000-09-29','puspi','2002-02-27','bidesh','bmg','743706','1452369','business','manju','1973-03-14','mom','qwer',12345,12,'cash',234,12,1234,'1234WE','ASDF345','2012-03-09'),('Client-Bally-02','AMLAN KARMAKAR','1989-06-14','RAHUL KARMAKAR','2012-03-10','KAUSHIK KARMAKAR','DUM DUM MOTIJHIL COLLEGE','876876','878787','MARKETING MANAGER','ARPAN HAJRA','2012-02-29','SON','C',25555,323,'Cheque',1234,123,4641,'234555','12324','2012-03-01'),('Client-Bally-03','abhijit sarkar','2012-12-12','debabrata sarkar','2012-04-13','prasun sarkar','kolkata station','898655','8766576','sweeper','tapan sarkar','2012-03-04','friends','c',123,12,'Cash',123,12,135,'334546','13455','2010-01-01'),('Client-Bally-04','CHANDRA','1984-07-13','JOY SANKAR','1988-12-27','FATHER','BAMUNGACHI','76554','987866','COM ENGG','ROBIN','1989-12-07','BHAI','C',765,45,'Cash',233,23,267,'3455665','2354','2012-03-05');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employees` (
  `employee_id` varchar(45) NOT NULL,
  `employee_name` varchar(45) NOT NULL,
  `employee_dob` date DEFAULT NULL,
  `employee_address` varchar(100) DEFAULT NULL,
  `employee_phone_no` varchar(45) DEFAULT NULL,
  `employee_email` varchar(45) DEFAULT NULL,
  `employee_join_date` date DEFAULT NULL,
  `department` varchar(45) DEFAULT NULL,
  `salary` double DEFAULT NULL,
  `employee_manager_id` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`employee_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES ('Employee-Bally-40972.921669375','Amit','2012-03-01','bhagar','123456','sayan&  ','2012-03-15','azaaa',5e19,'12356'),('Employee-Bally-40974.6442865394','shantu','1980-07-17','bangalore','123456789','D@dnaiml.com','1999-03-16','HR',25000,'12345rt'),('Employee-Bally-40976.5294654167','Soumen Paul','1984-03-03','Vill- Kulberia, P.O.- Bamangachhi, P.S.- Barasat, Dist- 24 pgs(N), Pin- 743248.','09163194994.','souman07.paul@gmail.com','2012-03-21','Computer Hardware Maintenance.',7500,'420');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_details`
--

DROP TABLE IF EXISTS `login_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login_details` (
  `user_name` varchar(64) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_details`
--

LOCK TABLES `login_details` WRITE;
/*!40000 ALTER TABLE `login_details` DISABLE KEYS */;
INSERT INTO `login_details` VALUES ('amit','12345','user'),('anirban','54321','manager'),('chandra','123456789','owner');
/*!40000 ALTER TABLE `login_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `share_holders`
--

DROP TABLE IF EXISTS `share_holders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `share_holders` (
  `shareholder_id` varchar(45) NOT NULL,
  `shareholder_name` varchar(45) NOT NULL,
  `shareholder_address` varchar(100) DEFAULT NULL,
  `shareholder_email` varchar(45) DEFAULT NULL,
  `shareholder_website` varchar(45) DEFAULT NULL,
  `shareholder_phone_number` varchar(45) DEFAULT NULL,
  `shareholder_nominee_name` varchar(45) DEFAULT NULL,
  `shareholder_nominee_contact_info` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`shareholder_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `share_holders`
--

LOCK TABLES `share_holders` WRITE;
/*!40000 ALTER TABLE `share_holders` DISABLE KEYS */;
/*!40000 ALTER TABLE `share_holders` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-03-08 15:01:09
