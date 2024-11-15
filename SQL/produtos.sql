-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 12/11/2024 às 02:31
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `shop`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `codBarras` varchar(50) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `preco` decimal(10,0) NOT NULL,
  `estoque` int(11) NOT NULL DEFAULT 0,
  `ativo` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `produtos`
--

INSERT INTO `produtos` (`id`, `codBarras`, `descricao`, `categoria`, `marca`, `preco`, `estoque`, `ativo`) VALUES
(1, '001', 'Camiseta Masculina Básica', 'Camisetas', 'Nike', 79.90, 50, 1),
(2, '002', 'Calça Jeans Feminina', 'Calças', 'Levi\'s', 149.90, 30, 1),
(3, '003', 'Jaqueta de Couro', 'Jaquetas', 'Diesel', 399.90, 20, 1),
(4, '004', 'Vestido Floral', 'Vestidos', 'Zara', 129.90, 25, 1),
(5, '005', 'Tênis Esportivo', 'Calçados', 'Adidas', 199.90, 40, 1),
(6, '006', 'Blusa de Frio Feminina', 'Blusas', 'C&A', 99.90, 60, 1),
(7, '007', 'Shorts Jeans Masculino', 'Shorts', 'Hollister', 79.90, 50, 1),
(8, '008', 'Saia de Tule', 'Saias', 'Forever 21', 79.90, 15, 1),
(9, '009', 'Camisa Polo', 'Camisetas', 'Tommy Hilfiger', 119.90, 35, 1),
(10, '010', 'Mochila de Couro', 'Acessórios', 'Coach', 299.90, 10, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
