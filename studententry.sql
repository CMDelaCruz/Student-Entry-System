-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2017-09-24 19:07:33
-- --------------------------------------
-- Server version 10.1.26-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of admins
-- 

DROP TABLE IF EXISTS `admins`;
CREATE TABLE IF NOT EXISTS `admins` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `state` varchar(15) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `middlename` varchar(45) DEFAULT NULL,
  `employeeid` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  UNIQUE KEY `employeeid_UNIQUE` (`employeeid`),
  UNIQUE KEY `employeeid` (`employeeid`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table admins
-- 

/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
INSERT INTO `admins`(`ID`,`state`,`username`,`password`,`firstname`,`lastname`,`middlename`,`employeeid`) VALUES
(1,'admin','admin01','ad234','Augustus','October','September','1234'),
(2,'master','master','947am','Master','Min','Ad','132'),
(3,'admin','admin','admin','ad','in','m','011');
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;

-- 
-- Definition of connector
-- 

DROP TABLE IF EXISTS `connector`;
CREATE TABLE IF NOT EXISTS `connector` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` varchar(10) NOT NULL,
  `CardNumber` varchar(10) NOT NULL,
  `state` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `StudentID` (`StudentID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table connector
-- 

/*!40000 ALTER TABLE `connector` DISABLE KEYS */;
INSERT INTO `connector`(`ID`,`StudentID`,`CardNumber`,`state`) VALUES
(1,'14-00190','0006830265',0),
(2,'14-00078','0006855430',0),
(3,'15-00910','0009060703',0),
(4,'15-10322','0006858490',0),
(5,'23-45678','0009052663',0);
/*!40000 ALTER TABLE `connector` ENABLE KEYS */;

-- 
-- Definition of logs
-- 

DROP TABLE IF EXISTS `logs`;
CREATE TABLE IF NOT EXISTS `logs` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `adminID` int(11) NOT NULL,
  `log` varchar(200) NOT NULL,
  `time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table logs
-- 

/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs`(`ID`,`adminID`,`log`,`time`) VALUES
(1,132,'Updated log table','2017-09-23 12:00:45'),
(2,132,'Testing database','2017-09-23 12:01:13'),
(3,11,'Updated student 15-10322 information','2017-09-23 16:44:11'),
(4,11,'Registered student 123-12345','2017-09-23 17:21:46'),
(5,132,'Registered student 67-89101','2017-09-24 12:20:39'),
(6,11,'Registered student 123213','2017-09-24 12:49:12'),
(7,11,'Registered student 12-1212','2017-09-24 14:20:25'),
(8,11,'Deleted student 19','2017-09-24 14:24:05'),
(9,11,'Registered student asd','2017-09-24 14:24:32'),
(10,11,'Registered student student','2017-09-24 14:28:58'),
(11,11,'Registered student 1','2017-09-24 14:29:44'),
(12,11,'Registered student 01010101','2017-09-24 14:30:25'),
(13,11,'Deleted student 22','2017-09-24 14:30:34'),
(14,11,'Deleted student 23','2017-09-24 14:30:37'),
(15,132,'Registered student 14-00001','2017-09-24 15:46:34');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;

-- 
-- Definition of studentinformation
-- 

DROP TABLE IF EXISTS `studentinformation`;
CREATE TABLE IF NOT EXISTS `studentinformation` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `MiddleName` varchar(255) DEFAULT NULL,
  `Course` varchar(255) DEFAULT NULL,
  `Year` int(11) DEFAULT NULL,
  `Section` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Gender` tinyint(4) DEFAULT NULL,
  `ContactNo` varchar(255) DEFAULT NULL,
  `Image` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `StudentNo` (`StudentNo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table studentinformation
-- 

/*!40000 ALTER TABLE `studentinformation` DISABLE KEYS */;
INSERT INTO `studentinformation`(`ID`,`StudentNo`,`LastName`,`FirstName`,`MiddleName`,`Course`,`Year`,`Section`,`Address`,`Gender`,`ContactNo`,`Image`) VALUES
(2,'15-10322','Santos','Dimitri','Javes','BS Computer Science',3,'B','Somewhere sa mindanao',0,'09231547866',NULL),
(4,'23-45678','Arroyo','Theresa','Galang','BS Tourism',3,'A','Sa likod ng bahay ni ____',1,'0987654321',NULL),
(6,'14-00190','Lim','Rineth','Somehow','BS Information Technology',4,'A','SF',1,'123',NULL),
(7,'14-00078','Cunanan','Prince','Something','BS Information Technology',4,'A','Yeah',0,'3421',NULL),
(8,'15-00910','Dimatulac','Jean','Most things','BS Information Technology',4,'A','yeah',1,'123213123',NULL);
/*!40000 ALTER TABLE `studentinformation` ENABLE KEYS */;

-- 
-- Definition of studentlogs
-- 

DROP TABLE IF EXISTS `studentlogs`;
CREATE TABLE IF NOT EXISTS `studentlogs` (
  `StudentNo` varchar(50) NOT NULL,
  `logtime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `Course` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table studentlogs
-- 

/*!40000 ALTER TABLE `studentlogs` DISABLE KEYS */;
INSERT INTO `studentlogs`(`StudentNo`,`logtime`,`Status`,`LastName`,`FirstName`,`Course`) VALUES
('23-45678','2017-09-24 13:28:08','Logged in','Arroyo','Theresa','BS Tourism'),
('15-10322','2017-09-24 13:28:14','Logged out','Santos','Dimitri','BS Computer Science'),
('15-00910','2017-09-24 13:28:19','Logged in','Dimatulac','Jean','BS Information Technology'),
('14-00078','2017-09-24 13:28:24','Logged in','Cunanan','Prince','BS Information Technology'),
('14-00190','2017-09-24 13:28:28','Logged in','Lim','Rineth','BS Information Technology'),
('14-00190','2017-09-24 13:28:34','Logged out','Lim','Rineth','BS Information Technology'),
('14-00078','2017-09-24 13:28:38','Logged out','Cunanan','Prince','BS Information Technology'),
('15-00910','2017-09-24 13:28:46','Logged out','Dimatulac','Jean','BS Information Technology'),
('15-10322','2017-09-24 13:28:52','Logged in','Santos','Dimitri','BS Computer Science'),
('15-10322','2017-09-24 13:29:35','Logged out','Santos','Dimitri','BS Computer Science'),
('14-00190','2017-09-24 15:38:50','Logged in','Lim','Rineth','BS Information Technology'),
('14-00001','2017-09-24 15:48:09','Logged in','Norewen','Mamawan','BS Information Technology'),
('14-00001','2017-09-24 15:48:26','Logged out','Norewen','Mamawan','BS Information Technology'),
('14-00190','2017-09-24 18:48:18','Logged out','Lim','Rineth','BS Information Technology'),
('14-00190','2017-09-24 18:49:11','Logged in','Lim','Rineth','BS Information Technology'),
('14-00190','2017-09-24 18:49:42','Logged out','Lim','Rineth','BS Information Technology'),
('23-45678','2017-09-24 18:50:08','Logged out','Arroyo','Theresa','BS Tourism'),
('23-45678','2017-09-24 18:51:29','Logged in','Arroyo','Theresa','BS Tourism'),
('23-45678','2017-09-24 18:51:30','Logged out','Arroyo','Theresa','BS Tourism');
/*!40000 ALTER TABLE `studentlogs` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2017-09-24 19:07:34
-- Total time: 0:0:0:1:349 (d:h:m:s:ms)
