-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 28, 2021 at 07:04 AM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: maji
--

-- --------------------------------------------------------

--
-- Table structure for table employees
--

create database maji;

use maji;

DROP TABLE IF EXISTS employees;
CREATE TABLE IF NOT EXISTS employees (
  Employee_ID int(11) NOT NULL AUTO_INCREMENT,
  Surname varchar(20) NOT NULL,
  Other_Names varchar(100) NOT NULL,
  Telephone_Number varchar(15) DEFAULT NULL,
  Residence varchar(100) DEFAULT NULL,
  National_ID varchar(20) DEFAULT NULL,
  Access_Level varchar(20) DEFAULT NULL,
  Username varchar(50) DEFAULT NULL,
  Access_Code varchar(20) DEFAULT NULL,
  PRIMARY KEY (Employee_ID)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table employees
--

INSERT INTO employees (Employee_ID, Surname, Other_Names, Telephone_Number, Residence, National_ID, Access_Level, Username, Access_Code) VALUES
(1, 'Ruthrock', 'Cynthia Ayuma', '9866-383877', 'Thika', '99-08-75-63', 'Attendant', 'Admin', 'Admin'),
(2, 'Weeword', 'Wansi Sinwa', '8765-45789', 'Thika', '98-65-45-67', 'System Monitor', 'Wee', 'nintendo'),
(3, 'Njune', 'sdknc', '8888-888888', 'Thika', '00-00-00-00', 'Attendant', 'x', 'y'),
(4, 'Kamau', 'Jameson Githedu', '0734-556781', 'Juja', '99-99-99-99', 'Attendant', 'Jammo', 'kamau'),
(6, 'Njoro', 'Roris Imkani', '78990887', 'Rwanda', '8899888', 'Attendant', 'Morris', 'Kimani'),
(7, 'Mino', 'Nomo Wino', '753525635', 'Juja', '6772356r', 'Attendant', 'Edgar', 'Obare'),
(8, 'Thuo', 'Cyrus Maina', '342235', 'Juja', '4772356r', 'Admin', 'Thuo', 'Thuo');

-- --------------------------------------------------------

--
-- Table structure for table water_level
--

DROP TABLE IF EXISTS water_level;
CREATE TABLE IF NOT EXISTS water_level (
  Data_ID int(11) NOT NULL AUTO_INCREMENT,
  water_level float DEFAULT NULL,
  Time_Checked time DEFAULT NULL,
  Date_Checked date DEFAULT NULL,
  Status varchar(20) DEFAULT NULL,
  water_Volume float DEFAULT NULL,
  Flow_rate_per_second float DEFAULT NULL,
  Liters_Pumped_Out float DEFAULT NULL,
  Payments_Due float DEFAULT NULL,
  PRIMARY KEY (Data_ID)
) ENGINE=MyISAM AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;

--
-- Dumping data for table water_level
--

INSERT INTO water_level (Data_ID, water_level, Time_Checked, Date_Checked, Status, water_Volume, Flow_rate_per_second, Liters_Pumped_Out, Payments_Due) VALUES
(1, 3, '11:44:39', '2020-09-14', 'Stagnant', 2000270, 0, 0, 0),
(2, 3, '11:44:41', '2020-09-14', 'Stagnant', 20002.7, 33337.9, 0, 100014000),
(3, -0.62, '11:44:47', '2020-09-14', 'Stagnant', 11868.3, 33004.4, 0, 1000140),
(4, 2.93, '11:44:48', '2020-09-14', 'Stagnant', 4133.9, 135.57, 0, 593414),
(5, -0.79, '11:44:49', '2020-09-14', 'Stagnant', 19536, 128.91, 0, 206695),
(6, 2.98, '11:44:50', '2020-09-14', 'Stagnant', 5267.39, 256.7, 0, 976800),
(7, 1.71, '11:44:51', '2020-09-14', 'Stagnant', 19869.4, 237.81, 0, 263370),
(8, 2.2, '11:44:52', '2020-09-14', 'Stagnant', 11401.5, 243.37, 0, 993469),
(9, 2.98, '11:44:53', '2020-09-14', 'Stagnant', 14668.7, 141.13, 0, 570078),
(10, -0.48, '11:44:54', '2020-09-14', 'Stagnant', 19869.4, 54.45, 0, 733434),
(11, 2.93, '11:44:55', '2020-09-14', 'Stagnant', 3200.44, 86.68, 0, 993469),
(12, 1.05, '11:44:56', '2020-09-14', 'Stagnant', 19536, 277.82, 0, 160022),
(13, 2.54, '11:44:57', '2020-09-14', 'Stagnant', 7000.95, 272.26, 0, 976800),
(14, 0.53, '11:44:58', '2020-09-14', 'Stagnant', 16935.6, 208.92, 0, 350048),
(15, 2.27, '11:44:59', '2020-09-14', 'Stagnant', 3533.82, 165.58, 0, 846782),
(16, -1.93, '11:45:00', '2020-09-14', 'Stagnant', 15135.4, 223.36, 0, 176691),
(17, 1.59, '11:45:01', '2020-09-14', 'Stagnant', 12868.4, 193.36, 0, 756770),
(18, 1.9, '11:45:02', '2020-09-14', 'Stagnant', 10601.5, 37.78, 0, 643421),
(19, 2.56, '11:45:03', '2020-09-14', 'Stagnant', 12668.4, 37.78, 0, 530072),
(20, -1.92, '11:45:04', '2020-09-14', 'Stagnant', 17069, 34.45, 0, 633420),
(21, 1.74, '11:45:05', '2020-09-14', 'Stagnant', 12801.8, 73.34, 0, 853450),
(22, 2.99, '11:45:06', '2020-09-14', 'Stagnant', 11601.6, 71.12, 0, 640088),
(23, -1.89, '11:45:07', '2020-09-14', 'Stagnant', 19936.1, 20, 0, 580079),
(24, 1.52, '11:45:08', '2020-09-14', 'Stagnant', 12601.7, 138.91, 0, 996802),
(25, -1.91, '11:45:09', '2020-09-14', 'Stagnant', 10134.7, 122.24, 0, 630086),
(26, 1.04, '11:45:10', '2020-09-14', 'Stagnant', 12735.1, 41.12, 0, 506736),
(27, 1.03, '11:45:11', '2020-09-14', 'Stagnant', 6934.28, 43.34, 0, 636754),
(28, 1.11, '11:45:12', '2020-09-14', 'Stagnant', 6867.6, 96.68, 0, 346714),
(29, 1.36, '11:45:13', '2020-09-14', 'Stagnant', 7401.01, 1.11, 0, 343380),
(30, 2.98, '11:45:14', '2020-09-14', 'Stagnant', 9067.9, 8.89, 0, 370050),
(31, -1.88, '11:45:15', '2020-09-14', 'Stagnant', 19869.4, 27.78, 0, 453395),
(32, 2.94, '11:45:16', '2020-09-14', 'Stagnant', 12535, 180.02, 0, 993469),
(33, -1.9, '11:45:17', '2020-09-14', 'Stagnant', 19602.7, 122.24, 0, 626752),
(34, 2.37, '11:45:18', '2020-09-14', 'Stagnant', 12668.4, 117.79, 0, 980134),
(35, -1.99, '11:45:19', '2020-09-14', 'Stagnant', 15802.2, 115.57, 0, 633420),
(36, 2.98, '11:45:20', '2020-09-14', 'Stagnant', 13268.5, 52.23, 0, 790108),
(37, -1.74, '11:45:21', '2020-09-14', 'Stagnant', 19869.4, 42.23, 0, 663424),
(38, -0.34, '11:45:22', '2020-09-14', 'Stagnant', 11601.6, 110.01, 0, 993469),
(39, 3, '11:45:24', '2020-09-14', 'Stagnant', 2266.98, 137.8, 0, 580079),
(40, 3, '11:45:26', '2020-09-14', 'Stagnant', 20002.7, 155.58, 0, 113349),
(41, 3, '11:45:34', '2020-09-14', 'Stagnant', 11734.9, 295.6, 0, 1000140),
(42, 3, '11:45:36', '2020-09-14', 'Stagnant', 20002.7, 137.8, 0, 586746),
(43, 0.34, '11:45:42', '2020-09-14', 'Stagnant', 16202.2, 137.8, 0, 1000140),
(44, 3, '11:45:43', '2020-09-14', 'Stagnant', 2266.98, 63.34, 0, 810110),
(45, 3, '11:45:45', '2020-09-14', 'Stagnant', 20002.7, 232.25, 0, 113349),
(46, 3, '11:46:36', '2020-09-14', 'Distributing', 3000.41, 295.6, 0, 1000140),
(47, 3, '11:46:38', '2020-09-14', 'Distributing', 20002.7, 283.37, 0, 150020);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
