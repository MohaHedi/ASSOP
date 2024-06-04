-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 04 juin 2024 à 17:34
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mlr3`
--

-- --------------------------------------------------------

--
-- Structure de la table `assister`
--

DROP TABLE IF EXISTS `assister`;
CREATE TABLE IF NOT EXISTS `assister` (
  `IDDEJ` smallint NOT NULL,
  `IDPROFESSIONEL` int NOT NULL,
  PRIMARY KEY (`IDDEJ`,`IDPROFESSIONEL`),
  KEY `I_FK_ASSISTER_PETIT_DEJ` (`IDDEJ`),
  KEY `I_FK_ASSISTER_PROFESSIONEL` (`IDPROFESSIONEL`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `bureau`
--

DROP TABLE IF EXISTS `bureau`;
CREATE TABLE IF NOT EXISTS `bureau` (
  `IDBUREAU` int NOT NULL AUTO_INCREMENT,
  `IDETUDIANT` int NOT NULL,
  `IDETUDIANT_PRESIDENT` int NOT NULL,
  `IDETUDIANT_TRESORIER` int NOT NULL,
  `ANNEESCOLAIRE` date DEFAULT NULL,
  PRIMARY KEY (`IDBUREAU`),
  KEY `I_FK_BUREAU_ÉTUDIANT` (`IDETUDIANT`),
  KEY `I_FK_BUREAU_ÉTUDIANT1` (`IDETUDIANT_PRESIDENT`),
  KEY `I_FK_BUREAU_ÉTUDIANT2` (`IDETUDIANT_TRESORIER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `etudiant`
--

DROP TABLE IF EXISTS `etudiant`;
CREATE TABLE IF NOT EXISTS `etudiant` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdIndividu` int DEFAULT NULL,
  `LyceeOrigine` varchar(50) DEFAULT NULL,
  `Baccalaureat` varchar(50) DEFAULT NULL,
  `SpecialiteBac` varchar(30) DEFAULT NULL,
  `AnneeObtentionBac` date DEFAULT NULL,
  `DateEntreeBts` date DEFAULT NULL,
  `DateSortieBts` date DEFAULT NULL,
  `PromoBts` date DEFAULT NULL,
  `SpecialiteBts` varchar(50) DEFAULT NULL,
  `DateObtentionBts` date DEFAULT NULL,
  `role` varchar(50) DEFAULT NULL,
  `Rang` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `etudiant`
--

INSERT INTO `etudiant` (`Id`, `IdIndividu`, `LyceeOrigine`, `Baccalaureat`, `SpecialiteBac`, `AnneeObtentionBac`, `DateEntreeBts`, `DateSortieBts`, `PromoBts`, `SpecialiteBts`, `DateObtentionBts`, `role`, `Rang`) VALUES
(2, 2, 'Perin', NULL, 'SVT', '2021-06-12', '2023-06-12', '2023-06-12', '2023-06-12', 'SLAM', '2023-06-12', '', NULL),
(3, 3, 'Claudel', NULL, 'NSI', '2020-04-01', '2023-06-12', '2023-06-12', '2022-06-12', 'SLAM', '2023-06-12', NULL, NULL),
(4, 6, 'htthth', NULL, 'htthtt', '2023-06-12', '2023-06-12', '2023-06-12', '2023-06-12', 'SISR', '2023-06-12', NULL, 'quatre'),
(5, 8, 'tiers', NULL, 'sti2d', '2022-05-11', '2024-06-04', '2024-06-06', '2024-06-04', 'dev', '2024-06-09', NULL, '5');

-- --------------------------------------------------------

--
-- Structure de la table `formation_post_bts`
--

DROP TABLE IF EXISTS `formation_post_bts`;
CREATE TABLE IF NOT EXISTS `formation_post_bts` (
  `IDFORMATION` int NOT NULL AUTO_INCREMENT,
  `LIBELLEFORMATION` varchar(50) DEFAULT NULL,
  `NIVEAU` varchar(20) DEFAULT NULL,
  `LIEU` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IDFORMATION`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `formation_post_bts`
--

INSERT INTO `formation_post_bts` (`IDFORMATION`, `LIBELLEFORMATION`, `NIVEAU`, `LIEU`) VALUES
(1, 'okkk', 'info', 'marseille');

-- --------------------------------------------------------

--
-- Structure de la table `individu`
--

DROP TABLE IF EXISTS `individu`;
CREATE TABLE IF NOT EXISTS `individu` (
  `IdIndividu` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(30) DEFAULT NULL,
  `Num` int DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `DateDeNaissance` date DEFAULT NULL,
  PRIMARY KEY (`IdIndividu`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `individu`
--

INSERT INTO `individu` (`IdIndividu`, `Nom`, `Prenom`, `Num`, `Email`, `DateDeNaissance`) VALUES
(2, 'Mze Ali', 'Naguib', 686154295, 'mzeali@gmail.com', '2003-01-24'),
(3, 'Mirabeau', 'Pascal ', 745865625, 'mirabeau13@gmail.com', '2002-06-12'),
(4, 'Peyre', 'Maxime', 648562514, 'peyre.romain@gmail.com', '1973-08-15'),
(5, 'Balao', 'Caroline', 635987412, 'balao.caro18@gmail.com', '1984-03-10'),
(6, 'rfgrgrg', 'rgrrg', 1234567894, 'grgrgrg', '2023-06-12'),
(7, 'naguib', 'mze ali', 652712307, 'naguibmzeali@gmail.com', '2024-06-07'),
(8, 'marquez', 'lucas', 652412365, 'marquezlucas@gmail.com', '2004-07-01');

-- --------------------------------------------------------

--
-- Structure de la table `jury`
--

DROP TABLE IF EXISTS `jury`;
CREATE TABLE IF NOT EXISTS `jury` (
  `IDJURY` int NOT NULL AUTO_INCREMENT,
  `IDPROFESSIONEL` int NOT NULL,
  `DATEJURY` date DEFAULT NULL,
  PRIMARY KEY (`IDJURY`),
  KEY `I_FK_JURY_PROFESSIONEL` (`IDPROFESSIONEL`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `jury`
--

INSERT INTO `jury` (`IDJURY`, `IDPROFESSIONEL`, `DATEJURY`) VALUES
(1, 0, '2024-06-06'),
(2, 0, '2024-06-06');

-- --------------------------------------------------------

--
-- Structure de la table `membre`
--

DROP TABLE IF EXISTS `membre`;
CREATE TABLE IF NOT EXISTS `membre` (
  `Identifiant` varchar(25) NOT NULL,
  `MotDePasse` varchar(25) NOT NULL,
  `Permission` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `membre`
--

INSERT INTO `membre` (`Identifiant`, `MotDePasse`, `Permission`) VALUES
('idt', 'mdp', NULL),
('Billal', 'Mdp', 'admin'),
('fefefe', 'Motdepasse77$', ''),
('rch', 'Marseille13@', ''),
('test', 'Peguy13006@.', '');

-- --------------------------------------------------------

--
-- Structure de la table `petit_dej`
--

DROP TABLE IF EXISTS `petit_dej`;
CREATE TABLE IF NOT EXISTS `petit_dej` (
  `IDDEJ` smallint NOT NULL AUTO_INCREMENT,
  `DATEDEJ` date DEFAULT NULL,
  PRIMARY KEY (`IDDEJ`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `petit_dej`
--

INSERT INTO `petit_dej` (`IDDEJ`, `DATEDEJ`) VALUES
(1, NULL),
(2, '2024-06-04'),
(3, '2024-06-04'),
(4, '2024-06-29'),
(5, '2024-06-29');

-- --------------------------------------------------------

--
-- Structure de la table `poursuivre`
--

DROP TABLE IF EXISTS `poursuivre`;
CREATE TABLE IF NOT EXISTS `poursuivre` (
  `IDFORMATION` int NOT NULL,
  `IDETUDIANT` int NOT NULL,
  `ANNEEOBTENTION` date DEFAULT NULL,
  `VALIDER` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IDFORMATION`,`IDETUDIANT`),
  KEY `I_FK_POURSUIVRE_FORMATION_POST_BTS` (`IDFORMATION`),
  KEY `I_FK_POURSUIVRE_ÉTUDIANT` (`IDETUDIANT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `professionnel`
--

DROP TABLE IF EXISTS `professionnel`;
CREATE TABLE IF NOT EXISTS `professionnel` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdIndividu` int NOT NULL,
  `SecteurActivite` varchar(30) DEFAULT NULL,
  `DateEntreeMondePro` date DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `professionnel`
--

INSERT INTO `professionnel` (`Id`, `IdIndividu`, `SecteurActivite`, `DateEntreeMondePro`) VALUES
(1, 4, 'Developpement', '1993-07-08'),
(2, 5, 'Intelligence artificielle', '2007-01-12'),
(3, 7, 'info', '2024-06-28');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `assister`
--
ALTER TABLE `assister`
  ADD CONSTRAINT `assister_ibfk_1` FOREIGN KEY (`IDDEJ`) REFERENCES `petit_dej` (`IDDEJ`),
  ADD CONSTRAINT `assister_ibfk_2` FOREIGN KEY (`IDPROFESSIONEL`) REFERENCES `professionnel` (`Id`);

--
-- Contraintes pour la table `bureau`
--
ALTER TABLE `bureau`
  ADD CONSTRAINT `bureau_ibfk_1` FOREIGN KEY (`IDETUDIANT`) REFERENCES `etudiant` (`Id`),
  ADD CONSTRAINT `bureau_ibfk_2` FOREIGN KEY (`IDETUDIANT_PRESIDENT`) REFERENCES `etudiant` (`Id`),
  ADD CONSTRAINT `bureau_ibfk_3` FOREIGN KEY (`IDETUDIANT_TRESORIER`) REFERENCES `etudiant` (`Id`);

--
-- Contraintes pour la table `poursuivre`
--
ALTER TABLE `poursuivre`
  ADD CONSTRAINT `poursuivre_ibfk_1` FOREIGN KEY (`IDFORMATION`) REFERENCES `formation_post_bts` (`IDFORMATION`),
  ADD CONSTRAINT `poursuivre_ibfk_2` FOREIGN KEY (`IDETUDIANT`) REFERENCES `etudiant` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
