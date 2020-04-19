-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 19 avr. 2020 à 11:47
-- Version du serveur :  5.7.26
-- Version de PHP :  7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ligue`
--

-- --------------------------------------------------------

--
-- Structure de la table `animer`
--

DROP TABLE IF EXISTS `animer`;
CREATE TABLE IF NOT EXISTS `animer` (
  `id_seance` int(11) NOT NULL,
  `id_moniteur` int(11) NOT NULL,
  PRIMARY KEY (`id_seance`,`id_moniteur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descriptif` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `descriptif`) VALUES
(1, 'Initiation'),
(2, 'Loisir'),
(3, 'Compétition');

-- --------------------------------------------------------

--
-- Structure de la table `habiliter`
--

DROP TABLE IF EXISTS `habiliter`;
CREATE TABLE IF NOT EXISTS `habiliter` (
  `id_moniteur` int(11) NOT NULL,
  `id_categorie` int(11) NOT NULL,
  PRIMARY KEY (`id_moniteur`,`id_categorie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `inscrire`
--

DROP TABLE IF EXISTS `inscrire`;
CREATE TABLE IF NOT EXISTS `inscrire` (
  `id_seance` int(11) NOT NULL,
  `id_licencie` int(11) NOT NULL,
  PRIMARY KEY (`id_seance`,`id_licencie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `licencie`
--

DROP TABLE IF EXISTS `licencie`;
CREATE TABLE IF NOT EXISTS `licencie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `email` varchar(150) NOT NULL,
  `telephone` varchar(10) NOT NULL,
  `mdp` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `licencie`
--

INSERT INTO `licencie` (`id`, `nom`, `prenom`, `email`, `telephone`, `mdp`) VALUES
(1, 'Paul', 'Jean-Luc', 'jeanlucpaul@gmail.com', '0343546576', 'azerty'),
(2, 'Tomato', 'Ketchup', 'tomato@gmail.com', '0454657898', 'azerty');

-- --------------------------------------------------------

--
-- Structure de la table `moniteur`
--

DROP TABLE IF EXISTS `moniteur`;
CREATE TABLE IF NOT EXISTS `moniteur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `email` varchar(150) NOT NULL,
  `telephone` varchar(10) NOT NULL,
  `mdp` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `moniteur`
--

INSERT INTO `moniteur` (`id`, `nom`, `prenom`, `email`, `telephone`, `mdp`) VALUES
(1, 'Jacquette', 'Jean-Louis', 'jl@gmail.com', '0609080706', 'azerty'),
(2, 'Collaro', 'Yves', 'yves.collaro@gmail.com', '0809987867', 'azerty');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

DROP TABLE IF EXISTS `proposer`;
CREATE TABLE IF NOT EXISTS `proposer` (
  `id_seande` int(11) NOT NULL,
  `id_moniteur` int(11) NOT NULL,
  PRIMARY KEY (`id_seande`,`id_moniteur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

DROP TABLE IF EXISTS `seance`;
CREATE TABLE IF NOT EXISTS `seance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `jour` varchar(8) NOT NULL,
  `descriptif` varchar(50) NOT NULL,
  `debut` datetime NOT NULL,
  `fin` datetime NOT NULL,
  `la_categorie` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `seance`
--

INSERT INTO `seance` (`id`, `jour`, `descriptif`, `debut`, `fin`, `la_categorie`) VALUES
(1, 'Samedi', 'Séance d\'initiation pour les débutans', '2019-12-14 14:30:00', '2019-12-14 15:30:00', 1),
(2, 'Mercredi', 'Entraînement des compétiteurs', '2019-12-18 15:30:00', '2019-12-18 17:30:00', 3);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
