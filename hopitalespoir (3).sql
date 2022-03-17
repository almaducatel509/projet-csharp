-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 14, 2021 at 06:24 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hopitalespoir`
--

-- --------------------------------------------------------

--
-- Table structure for table `chambre`
--

CREATE TABLE `chambre` (
  `idChambre` int(5) NOT NULL,
  `nomChambre` varchar(40) NOT NULL,
  `typeChambre` varchar(40) NOT NULL,
  `couvrirParAssurance` varchar(20) NOT NULL,
  `prixLocationParJour` double NOT NULL,
  `Etat` varchar(30) NOT NULL,
  `constituantsChambre` varchar(60) NOT NULL,
  `Description` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COMMENT='Table chambre';

--
-- Dumping data for table `chambre`
--

INSERT INTO `chambre` (`idChambre`, `nomChambre`, `typeChambre`, `couvrirParAssurance`, `prixLocationParJour`, `Etat`, `constituantsChambre`, `Description`) VALUES
(1, 'Maman', 'Seule', 'Oui', 350, 'Disponible', 'Lit, Medicament, Materiel d\'analyse', 'Chambre d\'analyse'),
(2, 'Psychiatrie', 'Privee', 'Non', 1000, 'Disponible', 'lit, serum, Table', 'Chambre Phychiatrie'),
(3, 'Generaliste', 'Seule', 'Oui', 400, 'Disponible', 'chaise, buffet, Table', 'Chambre generale'),
(4, 'Odontologie', 'gite', 'Non', 500, 'Disponible', 'Chaise, Materiaux dentaire', 'Chambre pour ceux qui ont des problemes dentaires'),
(6, 'Radiologie', 'Privee', 'Non', 2000, 'Disponible', 'Appareil Radiographie, buffet', 'Chambre pour faire la radiographie'),
(9, 'Urgences', 'Privee', 'Oui', 5000, 'Disponible', 'Lits, serum, table', 'chambre d\'urgence'),
(10, 'Accouchement', 'Commune', 'Non', 1000, 'Disponible', 'lits, berceau, table,chaises', 'Chambre d\'accouchement'),
(17, 'Laboratoire', 'Commune', 'Oui', 5000, 'Disponible', 'Appareil d\'analyse, buffet, Table', 'chambre de laboratoire'),
(18, 'maternite', 'Commune', 'Oui', 900, 'Disponible', 'Lits, berceau', 'Chambre apres accouchement'),
(21, 'San Jose', 'Commune', 'Oui', 200, 'Disponible', ' Lit double, defibrilateur', 'Ne  pas recevoir de visite la nuit');

-- --------------------------------------------------------

--
-- Table structure for table `consultation`
--

CREATE TABLE `consultation` (
  `idCons` int(5) NOT NULL,
  `noDossPat` int(10) NOT NULL,
  `consultationServices` varchar(140) NOT NULL,
  `paiementConsAss` varchar(10) NOT NULL,
  `motifCons` varchar(60) NOT NULL,
  `dateConsul` date NOT NULL,
  `idChambre` int(11) NOT NULL,
  `dureeHosp` int(20) NOT NULL,
  `medecin` varchar(70) NOT NULL,
  `necHospitalisation` varchar(100) NOT NULL,
  `hospAss` varchar(40) NOT NULL,
  `dateHospitalisation` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultation`
--

INSERT INTO `consultation` (`idCons`, `noDossPat`, `consultationServices`, `paiementConsAss`, `motifCons`, `dateConsul`, `idChambre`, `dureeHosp`, `medecin`, `necHospitalisation`, `hospAss`, `dateHospitalisation`) VALUES
(1, 1, 'Chirugien', 'Non', 'Anemie', '2021-11-05', 1, 4, 'Wister', 'Oui', 'Non', '2021-11-09'),
(3, 6, 'Radiologie', 'Non', 'Appendicite', '2021-06-03', 2, 6, 'Guirlande', 'Oui', 'Non', '2021-06-10'),
(4, 2, 'Radiologie', 'Non', 'Oreillons', '2020-04-01', 3, 3, 'Isemanie', 'Oui', 'Non', '2020-04-04'),
(5, 5, 'Accouchement', 'Oui', 'Rubeole', '2020-02-02', 4, 3, 'Kedny', 'Oui', 'Oui', '2020-02-05'),
(6, 7, 'Chirugien', 'Oui', 'Ulcere d\'estomac', '2021-10-02', 6, 1, 'Naki', 'Oui', 'Oui', '2021-10-03'),
(9, 22, 'Radiologie', 'Oui', 'Oreillons', '2021-11-05', 18, 4, 'Rodlin', 'Oui', 'Oui', '2021-11-09'),
(10, 20, 'Maternite', 'Oui', 'Mal au ventre, tete', '2021-03-07', 17, 12, 'Judelin', 'Oui', 'Oui', '2021-03-19'),
(11, 22, 'Maternite', 'Oui', 'Mal au ventre, tete', '2021-11-05', 10, 3, 'Kedny', 'Oui', 'Oui', '2021-11-08'),
(12, 6, 'Chirugien', 'Non', 'Oreillons', '2021-11-02', 10, 8, 'Monel', 'Oui', '', '2021-11-10'),
(13, 5, 'Accouchement', 'Oui', 'Mal au ventre, tete', '2021-03-19', 3, 1, 'Widna', 'Oui', 'Oui', '2021-03-19');

-- --------------------------------------------------------

--
-- Table structure for table `contrats`
--

CREATE TABLE `contrats` (
  `idContrats` int(10) NOT NULL,
  `nomCompAs` varchar(60) NOT NULL,
  `sigleCompAs` varchar(10) NOT NULL,
  `nomDir` varchar(40) NOT NULL,
  `adresse` varchar(60) NOT NULL,
  `tlf` varchar(20) NOT NULL,
  `email` varchar(60) NOT NULL,
  `pourcentageCons` double NOT NULL,
  `pourcentageChambre` double NOT NULL,
  `pourcentageHosp` double NOT NULL,
  `etat` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contrats`
--

INSERT INTO `contrats` (`idContrats`, `nomCompAs`, `sigleCompAs`, `nomDir`, `adresse`, `tlf`, `email`, `pourcentageCons`, `pourcentageChambre`, `pourcentageHosp`, `etat`) VALUES
(9, 'Office Assurance Accident du travail maladie et de maternite', 'OFATMA', 'Erick', 'Port-Au-prince', '+(509) 3987-6654', 'erick@gmail.com', 30, 50, 65, 'En cours'),
(6, 'Nationale d\'Assurance', 'NASSA', 'Djempson', 'Fort-liberte', '+(509) 4667-6778', 'Djempson@gmail.com', 25, 98, 45, 'En cours'),
(7, 'Haiti securite Assurance', 'SA', 'Jay', 'dadsads', '+(509) 3376-4645', 'wesly@gmail.com', 20, 30, 40, 'Resilie'),
(15, 'Protection Assurance', 'Protecta', 'Bicha', 'Port-au-Prince', '+(509) 2345-3456', 'protecta@gmail.com', 12, 25, 15, 'En cours'),
(14, 'Office National d\'Assurance Vieillesse', 'ONA', 'Iveno', 'Port-Au-Prince', '+(509) 3567-8909', 'ive@gmail.com', 50, 50, 50, 'En cours'),
(13, 'Alernative insurance Company', 'AIC', 'Wilbert', 'Port-au-Prince', '+(509) 3567-8902', 'wil@gmail.com', 40, 70, 80, 'Resilie'),
(16, 'UniAssurance', 'UA', 'Roberto ', 'Limbe', '+(509) 4647-7831', 'robert@gmail.com', 50, 50, 50, 'En cours'),
(17, 'Assurance Leger', 'AL', 'Alexandro', 'Limonade', '+(509) 3456-2772', 'alex@gmail.com', 33, 67, 75, 'En cours'),
(18, 'Aucune', 'Aucune', 'Theodor', 'morne-rouge', '+(509) 4678-9342', 'theodor@gmail.com', 0, 0, 0, 'Resilie');

-- --------------------------------------------------------

--
-- Table structure for table `dossiers`
--

CREATE TABLE `dossiers` (
  `noDossier` int(10) NOT NULL,
  `nomPatient` varchar(40) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `sexe` varchar(15) NOT NULL,
  `dateNaiss` date NOT NULL,
  `age` int(16) NOT NULL,
  `compAssure` varchar(250) NOT NULL,
  `persResp` varchar(50) NOT NULL,
  `numeroPers` varchar(20) NOT NULL,
  `adres` varchar(50) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `mail` varchar(40) NOT NULL,
  `trtSuivi` varchar(100) NOT NULL,
  `memo` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dossiers`
--

INSERT INTO `dossiers` (`noDossier`, `nomPatient`, `prenom`, `sexe`, `dateNaiss`, `age`, `compAssure`, `persResp`, `numeroPers`, `adres`, `telephone`, `mail`, `trtSuivi`, `memo`) VALUES
(1, 'Jean', 'Marianise', 'Feminin', '1995-09-30', 26, 'Alernative insurance Company', 'Jules Marilene', '+(509) 4567-8796', 'Champin', '+(500) 3838-4884', 'JeanMaria@gmail.com', 'Typhoide', 'Eviter les aliments crus et les produits laitiers.'),
(2, 'Paul', 'Ermanio', 'Masculin', '1963-01-02', 58, 'Les assurances leger', 'Paul Marco', '+(509) 4675-6432', 'Pister', '+(509) 7365-5543', 'rose@gmail.com', 'Hypoglycemie', 'L’hypoglycémie correspond à une quantité de glucose dans le sang inférieure à 4 mmol par litre.'),
(3, 'Desir', 'Joel', 'Masculin', '1967-06-28', 54, 'Aucune', 'Noel Anise', '+(509) 3379-0809', 'Limonade', '+(509) 9552-5535', 'joel@gmail.com', 'Hypertension', 'Eviter les grands excès caloriques, de sel et d\'alcool'),
(4, 'Joseph', 'Ronisha', 'Feminin', '2007-07-10', 14, 'Haiti securite Assurance', 'Romain Rousse', '+(509) 3923-0896', 'Gachette', '+(509) 3452-5535', 'ronisha@gmail.com', 'Typhoide', 'Eviter de prendre des produits crus'),
(5, 'Lorrin', 'Rose', 'Feminin', '1995-03-25', 26, 'Office Assurance Accident du travail maladie et de maternite', 'Lorrin Ana', '+(509) 4418-3270', 'Cap-Haitien', '+(509) 4260-1469', 'lorrin@gmail.Com', 'H-pylori', 'Eviter de prendre des produits laitiers'),
(6, 'Mathieu', 'Mania', 'Feminin', '2000-10-10', 21, 'Aucune', 'Jean Maxon', '+(509) 3245-6789', 'Plaisance', '+(509) 4567-8904', 'Mania@gmail.com', 'Typhoide', 'Eviter de prendre des produits non cuits'),
(7, 'Ducatel', 'Alma', 'Feminin', '1997-02-16', 24, 'Nationale d\'Assurance', 'Ducatel Iphomene', '+(509) 6654-3333', 'Vilage', '+(509) 3433-3334', 'almaducatel@gmail.com', 'H-pylori', 'Ne consomme pas trop de graisses'),
(8, 'Pierre', 'Josue', 'Masculin', '1996-07-01', 25, 'Alernative insurance Company', 'Pierre Julien', '+(509) 4567-8900', 'Limbe', '+(509) 3324-5678', 'josue@gmail.com', 'Hypoglycemie', 'ne pas prendre de lait'),
(19, 'Joseph', 'Wilmine', 'Feminin', '1980-12-04', 41, 'Aucune', 'Joseph Manette', '+(509) 3222-3456', 'Limbe', '+(509) 4512-2184', 'manette@gmail.com', 'H-pylori', 'Eviter de prendre de la vitamine c le soir'),
(20, 'Romain', 'Belo', 'Masculin', '1993-08-09', 28, 'UniAssurance', 'Romain Rosena', '+(509) 3567-8032', 'Bas-vertieres', '+(509) 4512-3145', 'belo@gmail.com', 'Typhoide', 'Eviter de prendre beaucoup de l\'huile'),
(25, 'dede', 'poli', 'Feminin', '1992-12-13', 29, 'Office Assurance Accident du travail maladie et de maternite', 'Dada poli', '+(509) 4803-0267', 'p78t', '+(509) 3234-4553', 'dede@gmail.com', 'Hypoglycemie', 'antecedent de guerre');

-- --------------------------------------------------------

--
-- Table structure for table `personels`
--

CREATE TABLE `personels` (
  `idPersonel` int(5) NOT NULL,
  `nom` varchar(30) NOT NULL,
  `prenom` varchar(40) NOT NULL,
  `sexe` varchar(20) NOT NULL,
  `adresse` varchar(40) NOT NULL,
  `domaineEtude` varchar(100) NOT NULL,
  `niveauEtude` varchar(50) NOT NULL,
  `specialisation` varchar(100) NOT NULL,
  `nombreAnneeExp` int(10) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `dateNaissance` varchar(40) NOT NULL,
  `servicesAffectes` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `nifCin` varchar(50) NOT NULL,
  `etat` varchar(20) NOT NULL,
  `categorie` varchar(70) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `personels`
--

INSERT INTO `personels` (`idPersonel`, `nom`, `prenom`, `sexe`, `adresse`, `domaineEtude`, `niveauEtude`, `specialisation`, `nombreAnneeExp`, `telephone`, `dateNaissance`, `servicesAffectes`, `email`, `nifCin`, `etat`, `categorie`) VALUES
(6, 'Jean', 'Madenaika', 'Feminin', 'Dubout', 'Infirmiere', 'maitrise', 'Radiotherapie', 7, '+(509)    4-3364', '17/11/1994', 'Accouchement', 'madenou@gmail.com', '097-430-987-1 ', 'Actif', 'Infirmier(ère)'),
(2, 'Lorrin', 'Emmanuella', 'Feminin', 'Cap-haitien', 'Science informatique', 'Licencie', 'Bases de donnees', 4, '+(509) 3345-6787', '06/11/1996', 'Generaliste', 'rose@gmail.com', '004-567-980-1 ', 'Actif', 'Informaticien(ne)'),
(5, 'Jean', 'Julesa', 'Feminin', 'Dubout', 'Electricien', 'maitrise', 'electronique', 7, '+(509) 7543-2232', '02/08/1990', 'Generaliste', 'jule@ddf.com', '002-004-012-0 ', 'Quitter', 'Electricien(e)'),
(4, 'Oseme', 'Wildarline', 'Feminin', 'Cap-Haitien', 'Technicien Laboratoire', 'licencie', 'accouchement', 2, '+(509) 4567-8798', '17/11/1981', 'Accouchement', 'dada@gmail.com', '020-305-850-2 ', 'Actif', 'Médecin'),
(16, 'Pierrre', 'Joananes', 'Masculin', 'dubout', 'Psychologie', 'Maitrise', 'Psychologie clinique', 10, '+(509) 7353-5353', '04/06/1985', 'Psychologie', 'joanaes@gmail.com', '045-566-771-0 ', 'Actif', 'Psychologue'),
(22, 'Joseph', 'Monel', 'Masculin', 'Cap-Haitien', 'Medecine', 'Doctorat', 'Gynecologue', 8, '+(509) 3553-1232', '17/11/1983', 'Accouchement', 'monel@gmail.com', '097-366-464-7 ', 'Actif', 'Directeur (trice)');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `idService` int(11) NOT NULL,
  `nomChefService` varchar(40) NOT NULL,
  `prixConsultation` double NOT NULL,
  `Etat` varchar(20) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `CouvrirParAssurance` varchar(10) NOT NULL,
  `nomService` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COMMENT='Table services';

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`idService`, `nomChefService`, `prixConsultation`, `Etat`, `Description`, `CouvrirParAssurance`, `nomService`) VALUES
(6, 'Dada', 750, 'Disponible', 'Hopital espoir de Delmas', 'Oui', 'Chirugien'),
(7, 'Wister', 1000, 'Disponible', 'Services pour consultation des yeux', 'Oui', 'Oftalmologie'),
(8, 'Bibi', 800, 'Disponible', 'Hopital espoir de delmas', 'Oui', 'Accouchement'),
(9, 'James', 1000, 'Disponible', 'Service Pour les malades mentales', 'Oui', 'Psychologie'),
(10, 'Kedny', 1250, 'Disponible', 'Service pour femme enceinte', 'Non', 'Maternite'),
(11, 'Wilins', 500, 'Non disponible', 'Service pour dents', 'Non', 'Odontologie'),
(13, 'Claudin', 2000, 'Non disponible', 'Service pour la radiographie', 'Non', 'Radiologie'),
(24, 'Cheperd Carl', 2500, 'Disponible', 'Traitement des appareils urinaires', 'Oui', 'Urologie');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `idEmp` int(10) NOT NULL,
  `pseudo` varchar(40) NOT NULL,
  `motDPass` varchar(40) NOT NULL,
  `etat` varchar(20) NOT NULL,
  `moduleAcces` varchar(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `utilisateurs`
--

INSERT INTO `utilisateurs` (`idEmp`, `pseudo`, `motDPass`, `etat`, `moduleAcces`) VALUES
(1, 'Judeline', '6578', 'Actif', 'Gestion Chambres,Gestion Services,Gestion Contrats,Gestion Consultations'),
(2, 'Darlou', '1257', 'Actif', 'GestionServices,GestionChambres,GestionConsultations,GestionUtilisateurs'),
(3, 'Admin', '3579', 'Actif', 'GestionServices,GestionChambres,GestionConsultations,GestionDossiers,GestionContrats,GestionUtilisateurs,GestionPersonnels'),
(4, 'Guigui', '01234', 'Actif', 'GestionServices,GestionChambres,GestionUtilisateurs'),
(8, 'Love', '2468', 'Inactif', 'GestionServices,GestionChambres,GestionConsultations'),
(9, 'Kedny', '13579', 'Actif', 'GestionChambres,GestionConsultations,GestionContrats'),
(10, 'ewee', '1111', 'Actif', 'GestionContrats'),
(11, 'Ilda', '3823', 'Actif', 'Gestion Dossiers,Gestion Services,Gestion Consultations'),
(12, 'Ada', '3456', 'Actif', 'Gestion Chambres,Gestion Personels,Gestion Consultations'),
(13, 'Jodeline', '9765', 'Actif', 'Gestion Services,Gestion Personels,Gestion Consultations'),
(14, 'Rose', '4322', 'Actif', 'Gestion Utilisateurs,Gestion Personels,Gestion Consultations');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chambre`
--
ALTER TABLE `chambre`
  ADD PRIMARY KEY (`idChambre`),
  ADD UNIQUE KEY `nomChambre` (`nomChambre`);

--
-- Indexes for table `consultation`
--
ALTER TABLE `consultation`
  ADD PRIMARY KEY (`idCons`),
  ADD KEY `fk_dossier` (`noDossPat`);

--
-- Indexes for table `contrats`
--
ALTER TABLE `contrats`
  ADD PRIMARY KEY (`idContrats`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `tlf` (`tlf`);

--
-- Indexes for table `dossiers`
--
ALTER TABLE `dossiers`
  ADD PRIMARY KEY (`noDossier`),
  ADD UNIQUE KEY `mail` (`mail`),
  ADD UNIQUE KEY `telephone` (`telephone`);

--
-- Indexes for table `personels`
--
ALTER TABLE `personels`
  ADD PRIMARY KEY (`idPersonel`),
  ADD UNIQUE KEY `nifCin` (`nifCin`),
  ADD UNIQUE KEY `telephone` (`telephone`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`idService`),
  ADD UNIQUE KEY `nomService` (`nomService`);

--
-- Indexes for table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`idEmp`),
  ADD UNIQUE KEY `motDPass` (`motDPass`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chambre`
--
ALTER TABLE `chambre`
  MODIFY `idChambre` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `consultation`
--
ALTER TABLE `consultation`
  MODIFY `idCons` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `contrats`
--
ALTER TABLE `contrats`
  MODIFY `idContrats` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `dossiers`
--
ALTER TABLE `dossiers`
  MODIFY `noDossier` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `personels`
--
ALTER TABLE `personels`
  MODIFY `idPersonel` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `idService` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  MODIFY `idEmp` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
