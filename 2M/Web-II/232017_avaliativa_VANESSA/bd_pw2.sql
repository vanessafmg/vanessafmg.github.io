-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 09-Abr-2024 às 23:51
-- Versão do servidor: 8.2.0
-- versão do PHP: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_pw2`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carros`
--

DROP TABLE IF EXISTS `carros`;
CREATE TABLE IF NOT EXISTS `carros` (
  `id` int NOT NULL AUTO_INCREMENT,
  `modelo` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `marca` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `cor` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `valor` decimal(8,2) NOT NULL,
  `ano` varchar(4) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `carros`
--

INSERT INTO `carros` (`id`, `modelo`, `marca`, `cor`, `valor`, `ano`) VALUES
(4, 'Uno', 'Fiat', 'Vermelho', 40000.00, '2012'),
(7, 'Gol', 'Volkswagen', 'Prata', 38000.00, '2015'),
(3, 'March', 'Nissan', 'Cinza', 40000.00, '2012'),
(8, 'Palio', 'Fiat', 'Cinza', 40000.00, '2013');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cidades`
--

DROP TABLE IF EXISTS `cidades`;
CREATE TABLE IF NOT EXISTS `cidades` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) COLLATE utf8mb4_general_ci NOT NULL,
  `uf` varchar(2) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `cidades`
--

INSERT INTO `cidades` (`id`, `nome`, `uf`) VALUES
(7, 'Pederneiras', 'SP'),
(6, 'Barra Bonita', 'SP'),
(4, 'Jau', 'SP'),
(5, 'Mineiros do Tiete', 'SP'),
(9, 'Araraquara', 'SP'),
(10, 'Marília', 'SP');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `senha` varchar(35) COLLATE utf8mb4_general_ci NOT NULL,
  `email` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `senha`, `email`) VALUES
(12, 'Claudio', '97d810f41d48561d74719865ce0841ef', 'claudio@gmail.com'),
(3, 'Carol', '6fe5d47a28d687083cd32913c828629b', 'carol.linda@gmail.com'),
(11, 'Dalva', '2ce9396504daa17f16e1439f5b25a7c5', 'dalva@gmail.com'),
(5, 'Jaque', '8eefcfdf5990e441f0fb6f3fad709e21', 'jaque@gmail.com'),
(7, 'Erick', '6f7235b46d282b8ead0e863e6522b49b', 'erick@gmail.com'),
(8, 'Joao', 'f01b8bf3c88dab0d56d3b36c16fa90dd', 'joao@gmail.com'),
(9, 'Thiago', '4e68ac458ba24573475378f09f591e6f', 'thiago@gmail.com'),
(10, 'Robson', 'b91e4a7b425f2eb15b68641d1ffbbee5', 'robson@gmail.com');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
