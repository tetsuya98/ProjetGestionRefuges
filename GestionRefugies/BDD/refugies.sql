-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 10, 2017 at 08:10 AM
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
-- Database: `gestionrefugie`
--

-- --------------------------------------------------------

--
-- Table structure for table `refugies`
--

DROP TABLE IF EXISTS `refugies`;
CREATE TABLE IF NOT EXISTS `refugies` (
  `clef` varchar(64) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `nationalite` varchar(255) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `camps_id` int(11) NOT NULL,
  `sexe` char(32) NOT NULL,
  `dateNais` date NOT NULL,
  `adresse` varchar(255) NOT NULL,
  PRIMARY KEY (`clef`),
  KEY `fk_refugie_camps_idx` (`camps_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
