-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 22, 2023 at 10:13 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `staff`
--

-- --------------------------------------------------------

--
-- Table structure for table `gender`
--

CREATE TABLE `gender` (
  `GENDER_ID` int(11) NOT NULL,
  `GENDER_NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gender`
--

INSERT INTO `gender` (`GENDER_ID`, `GENDER_NAME`) VALUES
(1, 'Male'),
(2, 'Female'),
(3, 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `title`
--

CREATE TABLE `title` (
  `TITLE_ID` int(11) NOT NULL,
  `TITLE_NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `title`
--

INSERT INTO `title` (`TITLE_ID`, `TITLE_NAME`) VALUES
(1, 'Mr.'),
(2, 'Mrs.'),
(3, 'Ms.'),
(4, 'Dr.'),
(5, 'Prof.');

-- --------------------------------------------------------

--
-- Table structure for table `usergroup`
--

CREATE TABLE `usergroup` (
  `USERGROUP_ID` int(11) NOT NULL,
  `USERGROUP_CODE` varchar(50) DEFAULT NULL,
  `USERGROUP_NAME` varchar(50) DEFAULT NULL,
  `USERGROUP_REMARK` varchar(255) DEFAULT NULL,
  `USERGROUP_URL` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usergroup`
--

INSERT INTO `usergroup` (`USERGROUP_ID`, `USERGROUP_CODE`, `USERGROUP_NAME`, `USERGROUP_REMARK`, `USERGROUP_URL`) VALUES
(1, '4', 'Student', 'Student Member', 'Student@Member.com'),
(17, '18', 'SooN', 'GTK', 'GTK@GTK.com'),
(18, '1', 'Games', 'Games', 'Games.com');

-- --------------------------------------------------------

--
-- Table structure for table `user_`
--

CREATE TABLE `user_` (
  `USER_ID` int(11) NOT NULL,
  `USER_TITLE` int(11) DEFAULT NULL,
  `USER_FNAME` varchar(50) DEFAULT NULL,
  `USER_LNAME` varchar(50) DEFAULT NULL,
  `USER_GENDER` int(11) DEFAULT NULL,
  `USER_EMAIL` varchar(50) DEFAULT NULL,
  `USER_NAME` varchar(25) DEFAULT NULL,
  `USER_PASSWD` varchar(25) DEFAULT NULL,
  `USER_GROUPID` int(11) DEFAULT NULL,
  `DISABLE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user_`
--

INSERT INTO `user_` (`USER_ID`, `USER_TITLE`, `USER_FNAME`, `USER_LNAME`, `USER_GENDER`, `USER_EMAIL`, `USER_NAME`, `USER_PASSWD`, `USER_GROUPID`, `DISABLE`) VALUES
(14, 1, 'Games', 'SooN', 1, 'gtk', 'gtk', '1234', 1, 0),
(15, 2, 'Orewa', 'Nooto', 2, 'ktg', 'ktg', '0147', 17, 0),
(16, 2, 'Mundo', 'Olaf', 2, 'MOMO', 'MO', '159', 18, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gender`
--
ALTER TABLE `gender`
  ADD PRIMARY KEY (`GENDER_ID`);

--
-- Indexes for table `title`
--
ALTER TABLE `title`
  ADD PRIMARY KEY (`TITLE_ID`);

--
-- Indexes for table `usergroup`
--
ALTER TABLE `usergroup`
  ADD PRIMARY KEY (`USERGROUP_ID`);

--
-- Indexes for table `user_`
--
ALTER TABLE `user_`
  ADD PRIMARY KEY (`USER_ID`),
  ADD KEY `fk_staffuser_title` (`USER_TITLE`),
  ADD KEY `fk_staffuser_gender` (`USER_GENDER`),
  ADD KEY `fk_staffuser_usergroup` (`USER_GROUPID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `usergroup`
--
ALTER TABLE `usergroup`
  MODIFY `USERGROUP_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `user_`
--
ALTER TABLE `user_`
  MODIFY `USER_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `user_`
--
ALTER TABLE `user_`
  ADD CONSTRAINT `fk_staffuser_gender` FOREIGN KEY (`USER_GENDER`) REFERENCES `gender` (`GENDER_ID`),
  ADD CONSTRAINT `fk_staffuser_title` FOREIGN KEY (`USER_TITLE`) REFERENCES `title` (`TITLE_ID`),
  ADD CONSTRAINT `fk_staffuser_usergroup` FOREIGN KEY (`USER_GROUPID`) REFERENCES `usergroup` (`USERGROUP_ID`),
  ADD CONSTRAINT `user__ibfk_1` FOREIGN KEY (`USER_GROUPID`) REFERENCES `usergroup` (`USERGROUP_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
