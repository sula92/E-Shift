-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 24, 2022 at 10:49 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eshift`
--

-- --------------------------------------------------------

--
-- Table structure for table `container`
--

CREATE TABLE `container` (
  `id` varchar(255) NOT NULL,
  `max_weight` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `container`
--

INSERT INTO `container` (`id`, `max_weight`) VALUES
('CON001', '50KG'),
('CON003', '45KG'),
('CON004', '23Kg');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` varchar(255) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `contact_number` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `name`, `contact_number`, `email`, `address`) VALUES
('C001', 'xxx', '1234567890', 'sula@dd.com', 'jfjfj 05A, nfnn'),
('C003', 'kdkd', '9490505', 'kfllflf', 'kglglg'),
('C004', 'kfkf', '305873', 'gdhdjjd', 'ndmmf'),
('C005', 'tyuu', '8687899', 'gjgjjkl', 'nmknkn'),
('C006', 'jkkk', '6666666666', 'vvv@cvb.com', 'jhjjbjb'),
('C007', 'fjfk', '8888888888', 'ndn@gmail.com', 'ldldkl'),
('C008', 'bhbvj', '8888888888', 'xxx@gmail.com', 'hjnjm,mk'),
('C009', 'qwe', '1234567890', 'mme@gmail.com', 'nfnfn');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `contact_number` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `position` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `name`, `contact_number`, `email`, `position`) VALUES
('EMP002', 'vvv', '8888888889', 'bhh@gmail.com', 'driver');

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

CREATE TABLE `job` (
  `id` varchar(255) NOT NULL,
  `date` varchar(255) DEFAULT NULL,
  `destination_address` varchar(255) DEFAULT NULL,
  `starting_address` varchar(255) DEFAULT NULL,
  `customer_id` varchar(255) DEFAULT NULL,
  `unit_id` varchar(255) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`id`, `date`, `destination_address`, `starting_address`, `customer_id`, `unit_id`, `status`) VALUES
('J001', '2022-07-13', ',flf,fm', 'jfjjf', 'C001', 'U001', 'pending'),
('J002', '7/12/2022 7:11:58 PM', 'xxxxx', 'xxx', 'C001', 'U001', 'pending'),
('J003', '7/18/2022 5:38:18 PM', 'mdmf', 'kvkv', 'C001', 'U001', 'completed');

-- --------------------------------------------------------

--
-- Table structure for table `lorry`
--

CREATE TABLE `lorry` (
  `id` varchar(255) NOT NULL,
  `model` varchar(255) DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lorry`
--

INSERT INTO `lorry` (`id`, `model`, `status`) VALUES
('L001', 'yyy', 'xxx');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `job_id` varchar(255) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`job_id`, `product_name`, `quantity`) VALUES
('J002', 'b b ', 10),
('J002', 'nhjl', 2),
('J002', 'TV', 10),
('J002', 'xxx', 6);

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `request_id` varchar(255) NOT NULL,
  `customer_id` varchar(255) NOT NULL,
  `product_inf` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `request`
--

INSERT INTO `request` (`request_id`, `customer_id`, `product_inf`, `status`) VALUES
('R001', 'C001', 'assd', 'pending'),
('R002', 'C001', 'kfkf', 'approved'),
('R003', 'C001', 'dcdmnc 4, djncjnv 8', 'cancel');

-- --------------------------------------------------------

--
-- Table structure for table `unit`
--

CREATE TABLE `unit` (
  `id` varchar(255) NOT NULL,
  `container_id` varchar(255) DEFAULT NULL,
  `lorry_id` varchar(255) DEFAULT NULL,
  `driver_id` varchar(255) NOT NULL,
  `assistant_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `unit`
--

INSERT INTO `unit` (`id`, `container_id`, `lorry_id`, `driver_id`, `assistant_id`) VALUES
('U001', 'CON001', 'L001', 'EMP001', 'EMP002');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userId` varchar(255) NOT NULL,
  `user_name` varchar(255) NOT NULL,
  `privilege` varchar(255) DEFAULT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userId`, `user_name`, `privilege`, `password`) VALUES
('C001', 'cus', 'customer', 'cus'),
('C005', 'vgb', 'customer', 'gjgj'),
('EMP001', 'admin', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `container`
--
ALTER TABLE `container`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `job`
--
ALTER TABLE `job`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK5p79nj8sgdc455xmpjobomnbv` (`customer_id`),
  ADD KEY `unit_id` (`unit_id`);

--
-- Indexes for table `lorry`
--
ALTER TABLE `lorry`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`job_id`,`product_name`);

--
-- Indexes for table `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`request_id`);

--
-- Indexes for table `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FKjawf3vvqkcm9qdhjxw3irih33` (`container_id`),
  ADD KEY `FKb3yhr7pfqmp5wh6cw5d9bhcyl` (`lorry_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `job`
--
ALTER TABLE `job`
  ADD CONSTRAINT `FK5p79nj8sgdc455xmpjobomnbv` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`),
  ADD CONSTRAINT `job_ibfk_1` FOREIGN KEY (`unit_id`) REFERENCES `unit` (`id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `FKs4cnsnqnau0piwj08yi0q1uvr` FOREIGN KEY (`job_id`) REFERENCES `job` (`id`);

--
-- Constraints for table `unit`
--
ALTER TABLE `unit`
  ADD CONSTRAINT `FKb3yhr7pfqmp5wh6cw5d9bhcyl` FOREIGN KEY (`lorry_id`) REFERENCES `lorry` (`id`),
  ADD CONSTRAINT `FKjawf3vvqkcm9qdhjxw3irih33` FOREIGN KEY (`container_id`) REFERENCES `container` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
