-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 18/11/2024 às 20:14
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
-- Estrutura para tabela `pedido`
--

CREATE TABLE `pedido` (
  `id` int(11) NOT NULL,
  `valorTotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `pedido`
--

INSERT INTO `pedido` (`id`, `valorTotal`) VALUES
(1, 32),
(2, 208),
(3, 608),
(4, 8),
(5, 816),
(6, 688),
(7, 208);

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedidoitens`
--

CREATE TABLE `pedidoitens` (
  `id` int(11) NOT NULL,
  `nPedido` int(11) NOT NULL,
  `codBarras` varchar(50) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `valorUn` int(11) NOT NULL,
  `itemTotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `pedidoitens`
--

INSERT INTO `pedidoitens` (`id`, `nPedido`, `codBarras`, `descricao`, `quantidade`, `valorUn`, `itemTotal`) VALUES
(1, 1, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(2, 1, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(3, 1, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(4, 1, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(5, 2, '005', 'Tênis Esportivo', 1, 200, 200),
(6, 2, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(7, 3, '005', 'Tênis Esportivo', 1, 200, 200),
(8, 3, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(9, 3, '003', 'Jaqueta de Couro', 1, 400, 400),
(10, 4, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(11, 5, '001', 'Camiseta Masculina Básica', 2, 8, 16),
(12, 5, '003', 'Jaqueta de Couro', 2, 400, 800),
(13, 6, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(14, 6, '003', 'Jaqueta de Couro', 1, 400, 400),
(15, 6, '005', 'Tênis Esportivo', 1, 200, 200),
(16, 6, '008', 'Saia de Tule', 1, 80, 80),
(17, 7, '001', 'Camiseta Masculina Básica', 1, 8, 8),
(18, 7, '005', 'Tênis Esportivo', 1, 200, 200);

-- --------------------------------------------------------

--
-- Estrutura para tabela `produtos`
--

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
(1, '001', 'Camiseta Masculina Básica', 'Camisetas', 'Adidas', 8, 163, 1),
(2, '002', 'Calça Jeans Feminina', 'Levi\'s', 'Calças', 150, 30, 0),
(3, '003', 'Jaqueta de Couro', 'Jaquetas', 'Diesel', 400, 11, 1),
(4, '004', 'Vestido Floral', 'Vestidos', 'Zara', 130, 25, 0),
(5, '005', 'Tênis Esportivo', 'Calçados', 'Adidas', 200, 36, 1),
(6, '006', 'Blusa de Frio Feminina', 'Blusas', 'C&A', 100, 60, 1),
(7, '007', 'Shorts Jeans Masculino', 'Shorts', 'Hollister', 80, 50, 1),
(8, '008', 'Saia de Tule', 'Saias', 'Forever 21', 80, 14, 1),
(9, '009', 'Camisa Polo', 'Camisetas', 'Tommy Hilfiger', 120, 35, 1),
(10, '010', 'Mochila de Couro', 'Acessórios', 'Coach', 300, 10, 1),
(11, '011', 'Camiseta Scooby Doo', 'Camiseta', 'Studio', 100, 0, 0),
(12, '012', 'Vestido Florido', 'Vestido', 'Hering', 100, 0, 1),
(13, '013', 'Calça alfaiataria azul', 'Calça', 'Hering', 100, 0, 1),
(14, '014', 'Camiseta polo preta', 'Camiseta', 'Adidas', 40, 0, 1),
(15, '015', 'Camisa polo azul', 'Camisa', 'Adidas', 50, 20, 1),
(16, '016', 'blusa moletom', 'blusa', 'adidas', 100, 40, 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `pedidoitens`
--
ALTER TABLE `pedidoitens`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `pedidoitens`
--
ALTER TABLE `pedidoitens`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
