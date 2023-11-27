-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 07 Paź 2023, 14:50
-- Wersja serwera: 10.4.25-MariaDB
-- Wersja PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `quizlet`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `słowa`
--

CREATE TABLE `słowa` (
  `id` int(11) NOT NULL,
  `Polski` varchar(50) CHARACTER SET utf16 COLLATE utf16_polish_ci NOT NULL,
  `Angielski` varchar(50) CHARACTER SET utf16 COLLATE utf16_polish_ci NOT NULL,
  `Nauczone` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `słowa`
--

INSERT INTO `słowa` (`id`, `Polski`, `Angielski`, `Nauczone`) VALUES
(1, 'dobrze', 'good', 0),
(2, 'zły', 'bad', 0),
(3, 'głupi', 'stupid', 0);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `słowa`
--
ALTER TABLE `słowa`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `słowa`
--
ALTER TABLE `słowa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
