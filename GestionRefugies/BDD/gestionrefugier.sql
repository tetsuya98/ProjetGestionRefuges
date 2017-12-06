-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 06, 2017 at 06:03 PM
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
-- Table structure for table `camps`
--

DROP TABLE IF EXISTS `camps`;
CREATE TABLE IF NOT EXISTS `camps` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `capacite` int(11) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_2` (`id`),
  KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
  `taille` int(11) NOT NULL,
  `couleurPeau` varchar(255) NOT NULL,
  `couleurCheveux` varchar(255) NOT NULL,
  `typeCheveux` varchar(255) NOT NULL,
  `couleurYeux` varchar(255) NOT NULL,
  `blessure` varchar(255) NOT NULL,
  `allergie` varchar(255) NOT NULL,
  `handicap` varchar(255) NOT NULL,
  `autre` varchar(255) NOT NULL,
  `id_camps` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `nom` (`nom`),
  KEY `prenom` (`prenom`),
  KEY `fk_refugiers_camps` (`id_camps`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

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
  `id_camps` int(11) NOT NULL,
  PRIMARY KEY (`login`),
  UNIQUE KEY `login` (`login`),
  KEY `login_2` (`login`),
  KEY `login_3` (`login`),
  KEY `fk_users_camps` (`id_camps`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `refugiers`
--
ALTER TABLE `refugiers`
  ADD CONSTRAINT `fk_refugiers_camps` FOREIGN KEY (`id_camps`) REFERENCES `camps` (`id`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `fk_users_camps` FOREIGN KEY (`id_camps`) REFERENCES `camps` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
