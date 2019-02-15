-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 14, 2018 at 01:58 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `unity_test`
--

-- --------------------------------------------------------

--
-- Table structure for table `igrac`
--

CREATE TABLE `igrac` (
  `ID` int(11) NOT NULL,
  `Ime` varchar(25) NOT NULL,
  `Prezime` varchar(30) NOT NULL,
  `KorisnickoIme` varchar(15) NOT NULL,
  `Lozinka` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `igrac`
--

INSERT INTO `igrac` (`ID`, `Ime`, `Prezime`, `KorisnickoIme`, `Lozinka`) VALUES
(1, 'Filip', 'Strahija', 'fstrahij', 'fico1');

-- --------------------------------------------------------

--
-- Table structure for table `igrac_stats`
--

CREATE TABLE `igrac_stats` (
  `ID` int(11) NOT NULL,
  `PozicijaX` float NOT NULL,
  `PozicijaY` float NOT NULL,
  `PozicijaZ` float NOT NULL,
  `KolicinaZnanja` int(11) NOT NULL,
  `PreostaloZadataka` int(11) NOT NULL,
  `Minute` float NOT NULL,
  `Sekunde` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `igrac_stats`
--

INSERT INTO `igrac_stats` (`ID`, `PozicijaX`, `PozicijaY`, `PozicijaZ`, `KolicinaZnanja`, `PreostaloZadataka`, `Minute`, `Sekunde`) VALUES
(1, 1649.6, 5.05, 344.567, 20, 19, 59, 20.5179);

-- --------------------------------------------------------

--
-- Table structure for table `pitanje_odgovori`
--

CREATE TABLE `pitanje_odgovori` (
  `ID` int(11) NOT NULL,
  `Pitanje` varchar(500) CHARACTER SET utf8 NOT NULL,
  `Odgovor1` varchar(100) CHARACTER SET utf8 NOT NULL,
  `Odgovor2` varchar(100) CHARACTER SET utf8 NOT NULL,
  `Odgovor3` varchar(100) CHARACTER SET utf8 NOT NULL,
  `Odgovor4` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `pitanje_odgovori`
--

INSERT INTO `pitanje_odgovori` (`ID`, `Pitanje`, `Odgovor1`, `Odgovor2`, `Odgovor3`, `Odgovor4`) VALUES
(1, 'Tko je razvio C++ programski jezik?', 'Steve Jobs', 'Mark Zuckerberg', 'Steve Wozniak', 'Bjarne Stroustrup'),
(2, 'Od čega se sastoji C++ programski jezik?', 'Od deklaracijskog i izvedbenog dijela', 'Od zaglavlja i podnožja', 'Od matematičkih funkcija', 'Od skupa cijelih brojeva');

-- --------------------------------------------------------

--
-- Table structure for table `skrinjeznanja`
--

CREATE TABLE `skrinjeznanja` (
  `ID` int(11) NOT NULL,
  `SZ0` char(1) NOT NULL,
  `SZ1` char(1) NOT NULL,
  `SZ2` char(1) NOT NULL,
  `SZ3` char(1) NOT NULL,
  `SZ4` char(1) NOT NULL,
  `SZ5` char(1) NOT NULL,
  `SZ6` char(1) NOT NULL,
  `SZ7` char(1) NOT NULL,
  `SZ8` char(1) NOT NULL,
  `SZ9` char(1) NOT NULL,
  `SZ10` char(1) NOT NULL,
  `SZ11` char(1) NOT NULL,
  `SZ12` char(1) NOT NULL,
  `SZ13` char(1) NOT NULL,
  `SZ14` char(1) NOT NULL,
  `SZ15` char(1) NOT NULL,
  `SZ16` char(1) NOT NULL,
  `SZ17` char(1) NOT NULL,
  `SZ18` char(1) NOT NULL,
  `SZ19` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `skrinjeznanja`
--

INSERT INTO `skrinjeznanja` (`ID`, `SZ0`, `SZ1`, `SZ2`, `SZ3`, `SZ4`, `SZ5`, `SZ6`, `SZ7`, `SZ8`, `SZ9`, `SZ10`, `SZ11`, `SZ12`, `SZ13`, `SZ14`, `SZ15`, `SZ16`, `SZ17`, `SZ18`, `SZ19`) VALUES
(1, 'T', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F', 'F');

-- --------------------------------------------------------

--
-- Table structure for table `tocan_odgovor`
--

CREATE TABLE `tocan_odgovor` (
  `ID` int(11) NOT NULL,
  `TocanOdgovor` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tocan_odgovor`
--

INSERT INTO `tocan_odgovor` (`ID`, `TocanOdgovor`) VALUES
(1, 'Bjarne Stroustrup'),
(2, 'Od deklaracijskog i izvedbenog dijela');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `igrac`
--
ALTER TABLE `igrac`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `igrac_stats`
--
ALTER TABLE `igrac_stats`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pitanje_odgovori`
--
ALTER TABLE `pitanje_odgovori`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `skrinjeznanja`
--
ALTER TABLE `skrinjeznanja`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tocan_odgovor`
--
ALTER TABLE `tocan_odgovor`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `igrac_stats`
--
ALTER TABLE `igrac_stats`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `pitanje_odgovori`
--
ALTER TABLE `pitanje_odgovori`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `skrinjeznanja`
--
ALTER TABLE `skrinjeznanja`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tocan_odgovor`
--
ALTER TABLE `tocan_odgovor`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `igrac_stats`
--
ALTER TABLE `igrac_stats`
  ADD CONSTRAINT `igrac2` FOREIGN KEY (`ID`) REFERENCES `igrac` (`ID`);

--
-- Constraints for table `skrinjeznanja`
--
ALTER TABLE `skrinjeznanja`
  ADD CONSTRAINT `igrac1` FOREIGN KEY (`ID`) REFERENCES `igrac` (`ID`);

--
-- Constraints for table `tocan_odgovor`
--
ALTER TABLE `tocan_odgovor`
  ADD CONSTRAINT `tocan_odgovor_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `pitanje_odgovori` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
