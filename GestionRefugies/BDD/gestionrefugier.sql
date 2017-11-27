-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 27, 2017 at 05:55 PM
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
-- Table structure for table `refugiers`
--

DROP TABLE IF EXISTS `refugiers`;
CREATE TABLE IF NOT EXISTS `refugiers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `nationalite` varchar(255) NOT NULL,
  `sexe` char(10) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `dateNais` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `refugiers`
--

INSERT INTO `refugiers` (`id`, `nom`, `prenom`, `nationalite`, `sexe`, `adresse`, `dateNais`) VALUES
(1, 'Lakraa', 'Omer', 'français', 'M', '1', '2017-11-05'),
(2, 'Lakraa', 'Lakraa', 'français', 'M', '3', '2017-11-27');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `nom` varchar(255) NOT NULL,
  `prenom` int(255) NOT NULL,
  `agent` tinyint(1) NOT NULL,
  `magasinier` tinyint(1) NOT NULL,
  `administrateur` tinyint(1) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `login` varchar(255) NOT NULL,
  PRIMARY KEY (`login`),
  UNIQUE KEY `login` (`login`),
  KEY `login_2` (`login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
