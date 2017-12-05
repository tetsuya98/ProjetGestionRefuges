-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 05, 2017 at 06:02 PM
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
  `taille` int(11) NOT NULL,
  `couleurPeau` varchar(255) NOT NULL,
  `couleurCheveux` varchar(255) NOT NULL,
  `typeCheveux` varchar(255) NOT NULL,
  `couleurYeux` varchar(255) NOT NULL,
  `blessure` varchar(255) NOT NULL,
  `allergie` varchar(255) NOT NULL,
  `handicap` varchar(255) NOT NULL,
  `autre` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `nom` (`nom`),
  KEY `prenom` (`prenom`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `refugiers`
--

INSERT INTO `refugiers` (`id`, `nom`, `prenom`, `nationalite`, `sexe`, `adresse`, `dateNais`, `taille`, `couleurPeau`, `couleurCheveux`, `typeCheveux`, `couleurYeux`, `blessure`, `allergie`, `handicap`, `autre`) VALUES
(1, 'Lakraa', 'Omer', 'français', 'M', 3, '2017-12-05', 3, 'blue', 'rouge', 'bouclé', 'Orange', 'Non', 'math', 'con', 'autre....'),
(2, 'Lakraa', 'Omer', 'français', 'M', 3, '2017-12-05', 3, 'blue', 'rouge', 'bouclé', 'Orange', 'Non', 'math', 'con', 'autre....'),
(3, 'Lakraa', 'Omer', 'français', 'M', 3, '2017-12-05', 3, 'blue', 'rouge', 'bouclé', 'Orange', 'Non', 'math', 'con', 'autre....');

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
('user', 'user', 0, 0, 0, '1GuYutcFvVbqkiFRQhjaynkuk05tV4aiK8azjzPOa08mWJZy5XTBM4l6cJzIgvA3IYO4yOIaVKkweGTxBliS5g==', 'useru103'),
('user', 'user', 0, 0, 0, 'sE/j4jDD/79Iy8CkxrInPt+1dIRR1Yz404kopwoWsJdQMNqPOBHhyOfGQ2fTwNAB8j+kStheehAjV2wIGI+hgg==', 'useru361'),
('user', 'user', 0, 0, 0, 'Fuxvftxu+I+MIauwvOxwzBogODEqAxXHGOemUBKsstjW5IkOqssqv6NXnvIKcbfKu7vlI9n5WFgTLiUFIs5I+w==', 'useru404'),
('user', 'user', 0, 0, 0, 'vumSytlEnMelfWVK2v2TtPtoMdoDB6P/yhSBgL/0WZ6y2qSRNH/HkGs7FiE//KbCrh6a1fkOE5yJ1bXQSUxOow==', 'useru848'),
('user', 'user', 0, 0, 0, 'O8NUT2qizyyoJnIKBiGlo4XVGJWrMtMVJybEoVXjgxm/PgYS/JioMdRV84ssE+xhD5jEeK4ziMJSeLZ8udEgnQ==', 'useru441'),
('user', 'user', 0, 0, 0, 'U6RCnUw8O2+/IBZB1KCWP/+1JR0HjBqkNRCVM6s+VIatWAx6UkD2RGuYTV34XmSDzMw6mmrGlrQ9ve443HX5vw==', 'useru739');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
