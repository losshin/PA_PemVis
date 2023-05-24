-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2023 at 05:40 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbekspedisi`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblakun`
--

CREATE TABLE `tblakun` (
  `id_akun` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(30) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblakun`
--

INSERT INTO `tblakun` (`id_akun`, `username`, `password`, `nama`, `role`) VALUES
(1, 'admin', 'admin', 'Admin', 'Admin'),
(2, 'kevin', '123', 'Kevin Yaneld Cendhana', 'User'),
(4, 'Hafiz', 'Hafiz', 'Hafiz', 'Admin'),
(5, 'Riski', '123', 'Riski Agung Romadhon', 'User');

-- --------------------------------------------------------

--
-- Table structure for table `tblekspedisi`
--

CREATE TABLE `tblekspedisi` (
  `id_ekspedisi` int(11) NOT NULL,
  `asal` varchar(50) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `tujuan` varchar(50) NOT NULL,
  `harga` int(50) NOT NULL,
  `estimasi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblekspedisi`
--

INSERT INTO `tblekspedisi` (`id_ekspedisi`, `asal`, `nama`, `tujuan`, `harga`, `estimasi`) VALUES
(1, 'Samarinda', 'Truck', 'Balikpapan', 12000, '5 - 6 Hari'),
(3, 'Samarinda', 'Instant', 'Tenggarong', 12000, '1 - 2 hari'),
(4, 'Balikpapan', 'Truck', 'Jakarta', 20000, '5 - 6 Hari'),
(5, 'Samarinda', 'Kargo', 'Balikpapan', 5000, '7 - 10 Hari');

-- --------------------------------------------------------

--
-- Table structure for table `tblpesanan`
--

CREATE TABLE `tblpesanan` (
  `id_pesanan` int(11) NOT NULL,
  `id_ekspedisi` int(50) NOT NULL,
  `id_akun` int(11) NOT NULL,
  `nama_pengirim` varchar(50) NOT NULL,
  `alamat_pengirim` varchar(100) NOT NULL,
  `telepon_pengirim` varchar(50) NOT NULL,
  `berat` int(50) NOT NULL,
  `nama_penerima` varchar(50) NOT NULL,
  `alamat_penerima` varchar(100) NOT NULL,
  `telepon_penerima` varchar(50) NOT NULL,
  `total` int(100) NOT NULL,
  `validasi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblpesanan`
--

INSERT INTO `tblpesanan` (`id_pesanan`, `id_ekspedisi`, `id_akun`, `nama_pengirim`, `alamat_pengirim`, `telepon_pengirim`, `berat`, `nama_penerima`, `alamat_penerima`, `telepon_penerima`, `total`, `validasi`) VALUES
(1, 3, 0, 'Kevin Yaneld', 'Jl.Teuku Umar Perum BIP ', '8132412412', 23, 'Muh. Hafiz', 'Jl. Soekarno Hatta Nomor 5', '34521343214', 276000, 'Sudah'),
(6, 3, 2, '123', '123', '123', 123, '123', '123', '123', 1476000, 'Sudah'),
(7, 4, 5, 'Riski', 'Jl. bla bla', '1234', 12, 'kevin', 'jl.belatuk', '123', 240000, 'Sudah'),
(8, 3, 1, 'waduh', 'waduh', '123123', 12, 'Waduh', 'waduh', '12312', 144000, 'Sudah');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblakun`
--
ALTER TABLE `tblakun`
  ADD PRIMARY KEY (`id_akun`);

--
-- Indexes for table `tblekspedisi`
--
ALTER TABLE `tblekspedisi`
  ADD PRIMARY KEY (`id_ekspedisi`);

--
-- Indexes for table `tblpesanan`
--
ALTER TABLE `tblpesanan`
  ADD PRIMARY KEY (`id_pesanan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblakun`
--
ALTER TABLE `tblakun`
  MODIFY `id_akun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblekspedisi`
--
ALTER TABLE `tblekspedisi`
  MODIFY `id_ekspedisi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblpesanan`
--
ALTER TABLE `tblpesanan`
  MODIFY `id_pesanan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
