-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 02, 2021 at 07:38 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarydata`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `id` int(11) UNSIGNED NOT NULL,
  `name` varchar(255) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `author` varchar(255) NOT NULL,
  `language` varchar(50) NOT NULL,
  `publisher` varchar(255) NOT NULL,
  `pages` int(8) UNSIGNED NOT NULL,
  `year` int(4) UNSIGNED NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `name`, `genre`, `author`, `language`, `publisher`, `pages`, `year`) VALUES
(1, 'Хоббіт', 'Фентезі', 'Толкіен', 'Українська', 'Абабагаламага', 436, 1982),
(6, 'Сто років самотності', 'Роман', 'Маркес', 'Російська', 'Питер', 386, 1967),
(7, 'Мобі-Дік', 'Роман', 'Мелвіл', 'Українська', 'Абабагаламага', 238, 1851),
(8, 'Великий Гетсбі', 'Наратив', 'Фійджеральд', 'Українська', 'Абабагаламага', 1200, 1982),
(11, 'Ігрова Індустрія', 'Документальне', 'Шрейер', 'Украънська', 'Бомбора', 326, 2015);

-- --------------------------------------------------------

--
-- Table structure for table `borrowedbooks`
--

CREATE TABLE `borrowedbooks` (
  `BorrowID` int(11) UNSIGNED NOT NULL,
  `UserLogin` varchar(100) NOT NULL,
  `BookId` int(11) NOT NULL,
  `BorrowedStatus` tinyint(1) NOT NULL DEFAULT '1',
  `borrowDateStart` date NOT NULL,
  `borrowDateEnd` date NOT NULL,
  `borrowDateRealEnd` date DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `borrowedbooks`
--

INSERT INTO `borrowedbooks` (`BorrowID`, `UserLogin`, `BookId`, `BorrowedStatus`, `borrowDateStart`, `borrowDateEnd`, `borrowDateRealEnd`) VALUES
(11, 'Ivan', 7, 0, '2021-04-16', '2021-04-30', '2021-04-16'),
(10, 'Dan', 11, 1, '2021-04-16', '2021-04-30', NULL),
(8, 'Dan', 5, 0, '2021-04-12', '2021-04-26', '2021-04-15'),
(9, 'mylog', 1, 1, '2021-04-16', '2021-04-30', NULL),
(6, 'Dan', 1, 0, '2021-04-12', '2021-04-26', '2021-04-12');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `secondName` varchar(50) NOT NULL,
  `thirdName` varchar(50) NOT NULL,
  `phoneNumber` varchar(20) NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(32) NOT NULL,
  `email` varchar(50) NOT NULL,
  `admin` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstName`, `secondName`, `thirdName`, `phoneNumber`, `login`, `password`, `email`, `admin`) VALUES
(22, 'Андрій', 'Набаранчук', 'Олександрович', '+380673756647', 'andrej', '123', 'andrej@yandex.ru', 0),
(23, 'Іван', 'Джух', 'Вікторович', '+380967445833', 'mylog', 'mypass', 'vanyahere@mail.ru', 0),
(24, 'Дмитро', 'Царенко', 'Константинович', '+380969746574', 'dimas333', 'Pass', 'dimchik@gmail.com', 0),
(25, 'Арем', 'Лодигін', 'Іванович', '+380967586744', 'artemmiz', 'JW05', 'artem.lod@gmail.com', 1),
(27, 'Іван', 'Іванов', 'Іванович', '+380989334408', 'Ivan', '123', 'ivan@gmail.com', 1),
(21, 'Даниїл', 'Бичек', 'Максимович', '+380989334408\'', 'Dan', 'pass', 'bytchekdaneel@gmail.com', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  ADD UNIQUE KEY `BorrowID` (`BorrowID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  MODIFY `BorrowID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
