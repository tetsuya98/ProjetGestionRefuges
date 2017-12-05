-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 05, 2017 at 07:06 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gestionrefugier`
--
DROP DATABASE IF EXISTS gestionrefugier;
CREATE DATABASE gestionrefugier CHARACTER SET 'utf8';
use gestionrefugier;
-- --------------------------------------------------------

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
CREATE TABLE IF NOT EXISTS `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `description` int(255) NOT NULL,
  `datePeremtion` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `nom` (`nom`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `refugiers`
--

DROP TABLE IF EXISTS `refugiers`;
CREATE TABLE IF NOT EXISTS `refugiers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `nationalite` varchar(255) NOT NULL,
  `sexe` char(10) NOT NULL,
  `adresse` int(11) NOT NULL,
  `dateNais` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `nom` (`nom`),
  KEY `prenom` (`prenom`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `refugiers`
--

INSERT INTO `refugiers` (`id`, `nom`, `prenom`, `nationalite`, `sexe`, `adresse`, `dateNais`) VALUES
(3, 'Lakraa', 'Oumer', 'français', 'M', 3, '2017-12-02'),
(4, 'Flipo', 'Yann', 'français', 'F', 2, '2017-11-08'),
(5, 'Lakraa', 'Lakraa', 'français', 'M', 3, '2017-11-27'),
(6, 'Lakraa', 'Lakraa', 'français', 'M', 3, '2017-11-27'),
(7, 'Lakraa', 'Omer', 'français', 'M', 3, '2017-11-27'),
(8, 'Lakraa', 'Omer', 'français', 'M', 3, '2017-12-02'),
(9, 'Lakraa', 'Omer', 'français', 'M', 3, '2017-12-02');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `agent` tinyint(1) NOT NULL,
  `magasinier` tinyint(1) NOT NULL,
  `administrateur` tinyint(1) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `login` varchar(255) NOT NULL,
  PRIMARY KEY (`login`),
  UNIQUE KEY `login` (`login`),
  KEY `login_2` (`login`),
  KEY `login_3` (`login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`nom`, `prenom`, `agent`, `magasinier`, `administrateur`, `mdp`, `login`) VALUES
('Bonjour', 'Elvire', 1, 0, 1, '1dxYKgHDM4M1kI9bSy7JaZwL6fwCFPQ/LAM5ZHXOJ1ta7lVyM2//GHBkKKiyJNeGmR0nbPVJls3MABZgYchRrw==', 'lakraao'),
('Flipo', 'Yann', 0, 1, 1, 'mdp', 'flipoy'),
('Lakraa', 'Omer', 0, 0, 1, 'QVvfWX+DEokiN+LjzwOXIouluFRtjXZ4FL+rktslEEM4PnteKj3FAiIaNt3aZFzBsTAgt6fmck5lcTGtcqyXJA==', 'lakraao476'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao1011566107'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao1529273179'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao1627656101'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao873'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao107'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao658'),
('Lakraa', 'Omer', 0, 0, 1, '59nvWRCa1zW4ZDjtt31l1jCTtUPfoU5gLuUkfqGJ+EQUZqGGcYIwgFmpX+vKFBFmcHGDy9jOfWjfJ1jbaisliQ==', 'lakraao456'),
('Lakraa', 'Omer', 0, 0, 1, 'fyake+G/qdbB3VzFh8xrNjKTd8jdFmbHclyQCsVaF+eUKpnTmzsci6oFhwJmQSQnQOOCA1Qq4LE/Y9hiZYK2rw==', 'lakraao2'),
('Bonjour', 'Salut', 0, 0, 1, 'Ho53yEKuCFRHeuJzUz2tAr08/U1auEX6lfeT/6op2BHeo6odgOjdipa1d9aLjoM2lYyDzf17veWbiQ6mNxpRsA==', 'bonjours974'),
('user', 'user', 0, 0, 0, '5vfPAmPGcMqIggDCuGZu/T7bV2lFXRqHzfszCTQ+9ukcADqcu6OG6a2xMU9xx083PHJEz2at8yoxDvvVQ4VL1Q==', 'useru637'),
('user', 'user', 0, 0, 0, 'zYh6Zj7I3froYDu0FCEdU84/ovVtn3vpo+URohLD+CaGkK37rnVZF4Xf4igN+hFAJT+lDpQw6zUUGUG1pldbSg==', 'useru328'),
('user', 'user', 0, 0, 0, 'ZEpvJz10dFiIoYnslzQgDA/KDmtKPPIXI6d6gai63guwLJ40cBJIIJBMsv2tT/o9gNabiXtTLxX39rxWUIyInA==', 'useru266'),
('user', 'user', 0, 0, 0, 'yPpFgpIOb103KNYhfbEMBm9xgJoNTxjZr934J2FAkfl6+64EV3ELdrDbuiHUIBx4cbvEPf2rfmXXCUnLjr5RkA==', 'useru803'),
('user', 'user', 0, 0, 0, '1GuYutcFvVbqkiFRQhjaynkuk05tV4aiK8azjzPOa08mWJZy5XTBM4l6cJzIgvA3IYO4yOIaVKkweGTxBliS5g==', 'useru103');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
