-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 11, 2017 at 09:17 PM
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
-- Table structure for table `agents`
--

DROP TABLE IF EXISTS `agents`;
CREATE TABLE IF NOT EXISTS `agents` (
  `clef` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `prenom` varchar(255) DEFAULT NULL,
  `mdp` varchar(255) DEFAULT NULL,
  `camps_id` int(11) NOT NULL,
  PRIMARY KEY (`clef`),
  KEY `fk_agents_camps` (`camps_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `camps`
--

DROP TABLE IF EXISTS `camps`;
CREATE TABLE IF NOT EXISTS `camps` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `magasiniers`
--

DROP TABLE IF EXISTS `magasiniers`;
CREATE TABLE IF NOT EXISTS `magasiniers` (
  `clef` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  `camps_id` int(11) NOT NULL,
  PRIMARY KEY (`clef`),
  KEY `fk_magasiniers_camps` (`camps_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `refugies`
--

DROP TABLE IF EXISTS `refugies`;
CREATE TABLE IF NOT EXISTS `refugies` (
  `clef` int(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `nationalite` varchar(255) NOT NULL,
  `mdp` varchar(255) NOT NULL,
  `camps_id` int(11) NOT NULL,
  `sexe` tinyint(4) NOT NULL,
  `dateNais` date NOT NULL,
  `adresse` varchar(255) NOT NULL,
  PRIMARY KEY (`clef`),
  KEY `fk_refugiers_camps` (`camps_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `stocks`
--

DROP TABLE IF EXISTS `stocks`;
CREATE TABLE IF NOT EXISTS `stocks` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `camps_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_stocks_camps` (`camps_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `agents`
--
ALTER TABLE `agents`
  ADD CONSTRAINT `fk_agents_camps` FOREIGN KEY (`camps_id`) REFERENCES `camps` (`id`);

--
-- Constraints for table `magasiniers`
--
ALTER TABLE `magasiniers`
  ADD CONSTRAINT `fk_magasiniers_camps` FOREIGN KEY (`camps_id`) REFERENCES `camps` (`id`);

--
-- Constraints for table `refugies`
--
ALTER TABLE `refugies`
  ADD CONSTRAINT `fk_refugiers_camps` FOREIGN KEY (`camps_id`) REFERENCES `camps` (`id`);

--
-- Constraints for table `stocks`
--
ALTER TABLE `stocks`
  ADD CONSTRAINT `fk_stocks_camps` FOREIGN KEY (`camps_id`) REFERENCES `camps` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
