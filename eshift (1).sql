-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2022 at 09:08 PM
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
('CON002', '67Kg');

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
('C001', 'xxx', '123456', 'sula@dd.com', 'jfjfj 05A, nfnn'),
('C003', 'kdkd', '9490505', 'kfllflf', 'kglglg'),
('C004', 'kfkf', '305873', 'gdhdjjd', 'ndmmf'),
('C005', 'tyuu', '8687899', 'gjgjjkl', 'nmknkn'),
('C006', 'jkkk', '6666666666', 'vvv@cvb.com', 'jhjjbjb');

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
('EMP001', 'xxx', '1111111111', 'msm@gmail.com', 'Driver');

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
  `unit_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`id`, `date`, `destination_address`, `starting_address`, `customer_id`, `unit_id`) VALUES
('J001', '2022-07-13', ',flf,fm', 'jfjjf', 'C001', 'U001'),
('J002', '7/12/2022 7:11:58 PM', 'xxxxx', 'bbbbb', 'C001', 'U001');

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
  `privilege` varchar(255) DEFAULT NULL,
  `employee_id` varchar(255) DEFAULT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  ADD PRIMARY KEY (`userId`),
  ADD KEY `FK1yao5y1albiyi7r6ktr0wkx47` (`employee_id`);

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

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `FK1yao5y1albiyi7r6ktr0wkx47` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
