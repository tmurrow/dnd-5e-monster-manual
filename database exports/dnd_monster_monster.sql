-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: middleearth    Database: dnd_monster
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `monster`
--

DROP TABLE IF EXISTS `monster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `monster` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(63) NOT NULL,
  `url_name` varchar(63) NOT NULL,
  `size_id` int(11) NOT NULL,
  `type_id` int(11) NOT NULL,
  `alignment_attitude_id` int(11) NOT NULL,
  `alignment_morality_id` int(11) NOT NULL,
  `ac` int(11) NOT NULL DEFAULT '0',
  `ac_note` varchar(63) DEFAULT NULL,
  `hp` int(11) NOT NULL DEFAULT '0',
  `hp_note` varchar(15) DEFAULT NULL,
  `str` int(11) NOT NULL DEFAULT '0',
  `dex` int(11) NOT NULL DEFAULT '0',
  `con` int(11) NOT NULL DEFAULT '0',
  `int` int(11) NOT NULL DEFAULT '0',
  `wis` int(11) NOT NULL DEFAULT '0',
  `cha` int(11) NOT NULL DEFAULT '0',
  `str_save` int(11) NOT NULL DEFAULT '0',
  `dex_save` int(11) NOT NULL DEFAULT '0',
  `con_save` int(11) NOT NULL DEFAULT '0',
  `int_save` int(11) NOT NULL DEFAULT '0',
  `wis_save` int(11) NOT NULL DEFAULT '0',
  `cha_save` int(11) NOT NULL DEFAULT '0',
  `passive_perception` int(11) NOT NULL DEFAULT '0',
  `language_note` varchar(127) DEFAULT NULL,
  `challenge_rating` float NOT NULL DEFAULT '0',
  `experience_points` int(11) NOT NULL DEFAULT '0',
  `telepathy_distance` int(11) NOT NULL DEFAULT '0',
  `source_id` int(11) NOT NULL DEFAULT '1',
  `source_page` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `url_name_UNIQUE` (`url_name`),
  KEY `alignment_attitude_id_idx` (`alignment_attitude_id`),
  KEY `alignment_morality_id_idx` (`alignment_morality_id`),
  KEY `size_id_idx` (`size_id`),
  KEY `type_id_idx` (`type_id`),
  KEY `source_id_idx` (`source_id`),
  KEY `source_id_monster_idx` (`source_id`),
  CONSTRAINT `alignment_attitude_id` FOREIGN KEY (`alignment_attitude_id`) REFERENCES `alignment_attitude` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `alignment_morality_id` FOREIGN KEY (`alignment_morality_id`) REFERENCES `alignment_morality` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `size_id` FOREIGN KEY (`size_id`) REFERENCES `size` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `source_id_monster` FOREIGN KEY (`source_id`) REFERENCES `source` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `type_id` FOREIGN KEY (`type_id`) REFERENCES `monster_type` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monster`
--

LOCK TABLES `monster` WRITE;
/*!40000 ALTER TABLE `monster` DISABLE KEYS */;
INSERT INTO `monster` VALUES (1,'Aarakocra','Aarakocra',3,10,2,1,12,NULL,13,'3d8',10,14,10,11,12,11,0,2,0,0,1,0,15,NULL,0.25,50,0,1,12),(2,'Aboleth','Aboleth',4,1,1,3,17,'natural armor',135,'18d10+36',21,9,15,18,15,18,5,-1,6,8,6,4,20,NULL,10,5900,0,1,13),(3,'Deva','Deva',3,3,1,1,17,'natural armor',136,'16d+64',18,18,18,17,20,20,4,4,4,3,9,9,15,NULL,10,5900,120,1,16),(4,'Planetar','Planetar',4,3,1,1,19,'natural armor',200,'16d10+112',24,20,24,19,22,25,7,5,12,4,11,12,21,NULL,16,15000,120,1,17),(5,'Solar','Solar',4,3,1,1,21,'natural armor',243,'18d10+144',26,22,26,25,25,30,8,6,8,14,14,17,24,NULL,21,33000,120,1,18),(6,'Animated Armor','Animated_Armor',3,4,5,5,18,'natural armor',33,'6d8+6',14,11,13,1,3,1,2,0,1,-5,-4,-5,6,NULL,1,200,0,1,19),(7,'Flying Sword','Flying_Sword',2,4,5,5,17,'natural armor',17,'5d6',12,15,11,1,5,1,1,4,0,-5,-3,-5,7,NULL,0.25,50,0,1,20),(8,'Rug of Smothering','Rug_of_Smothering',4,4,5,5,12,NULL,33,'6d10',17,14,10,1,3,1,3,2,0,-5,-4,-5,6,NULL,2,450,0,1,20),(9,'Ankheg','Ankheg',4,11,5,5,14,'natural armor, 11 while prone',39,'6d10+6',17,11,13,1,13,6,3,0,1,-5,1,-2,11,NULL,2,450,0,1,21),(10,'Azer','Azer',3,6,1,2,17,'natural armor, shield',39,'6d8+12',17,12,15,12,13,10,3,1,4,1,1,0,11,NULL,2,450,0,1,22);
/*!40000 ALTER TABLE `monster` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-21 13:10:32
