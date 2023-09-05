-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-02-2018 a las 01:51:25
-- Versión del servidor: 10.1.29-MariaDB
-- Versión de PHP: 7.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hospedajealdia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `idBitacora` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `tipo` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `fecha` datetime NOT NULL,
  `n°HorasLaboradas` varchar(1) COLLATE utf8_spanish_ci NOT NULL,
  `descripcionDetallada` varchar(99) COLLATE utf8_spanish_ci NOT NULL,
  `idReunionBitacora` varchar(9) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inmueblearea`
--

CREATE TABLE `inmueblearea` (
  `idInmuebleArea` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `valorInmueble` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `diaIngresoInmueble` datetime NOT NULL,
  `diaUltimoMantenimiento` datetime NOT NULL,
  `tipo` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idRolInmuebleArea` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idSedeInmuebleArea` varchar(9) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reunion`
--

CREATE TABLE `reunion` (
  `idReunion` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `tipo` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `meta` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `descripcionMeta` varchar(99) COLLATE utf8_spanish_ci NOT NULL,
  `diayHoraInicio` datetime NOT NULL,
  `diayHoraFin` datetime NOT NULL,
  `listaEmpleadosParticipantes` varchar(999) COLLATE utf8_spanish_ci NOT NULL,
  `descripcionReunion` varchar(999) COLLATE utf8_spanish_ci NOT NULL,
  `estadoMeta` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `diaMaximoCumplimientoMeta` datetime NOT NULL,
  `n°Meta` varchar(2) COLLATE utf8_spanish_ci NOT NULL,
  `idSedeReunion` varchar(9) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

CREATE TABLE `rol` (
  `idRol` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `nombreRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idReunionRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idSedeRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idBitacoraRol` varchar(9) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sede`
--

CREATE TABLE `sede` (
  `idSede` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `direccion` varchar(99) COLLATE utf8_spanish_ci NOT NULL,
  `localidad` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `ciudad` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `estrato` varchar(1) COLLATE utf8_spanish_ci NOT NULL,
  `web` varchar(99) COLLATE utf8_spanish_ci NOT NULL,
  `telefono` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `n°MaximoHuespedes` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `n°MaximoEmpleados` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `n°AreasFisicas` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `n°Habitaciones` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `n°RegistroNacionalDeTurismo` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `diaARenovarRNT` datetime NOT NULL,
  `diaInauguracion` datetime NOT NULL,
  `recibosProveedores` varchar(99) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `tipoId` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `nombres` varchar(35) COLLATE utf8_spanish_ci NOT NULL,
  `apellidos` varchar(35) COLLATE utf8_spanish_ci NOT NULL,
  `paisNacimiento` varchar(35) COLLATE utf8_spanish_ci NOT NULL,
  `fechaNacimiento` datetime NOT NULL,
  `genero` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `email` varchar(35) COLLATE utf8_spanish_ci NOT NULL,
  `telefono` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `salario` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `profesion` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `clave` varchar(19) COLLATE utf8_spanish_ci NOT NULL,
  `estadoActual` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `fechaIngreso` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fechaInicioVacaciones` datetime NOT NULL,
  `fechaFinVacaciones` datetime NOT NULL,
  `idReunionUsuario` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idRolUsuario` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `idSedeUsuario` varchar(9) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`idBitacora`),
  ADD KEY `idReunionBitacora` (`idReunionBitacora`);

--
-- Indices de la tabla `inmueblearea`
--
ALTER TABLE `inmueblearea`
  ADD PRIMARY KEY (`idInmuebleArea`),
  ADD KEY `idRolInmuebleArea` (`idRolInmuebleArea`),
  ADD KEY `idSedeInmuebleArea` (`idSedeInmuebleArea`);

--
-- Indices de la tabla `reunion`
--
ALTER TABLE `reunion`
  ADD PRIMARY KEY (`idReunion`),
  ADD KEY `idSedeReunion` (`idSedeReunion`);

--
-- Indices de la tabla `rol`
--
ALTER TABLE `rol`
  ADD PRIMARY KEY (`idRol`),
  ADD KEY `idReunionRol` (`idReunionRol`),
  ADD KEY `idSedeRol` (`idSedeRol`),
  ADD KEY `idBitacoraRol` (`idBitacoraRol`);

--
-- Indices de la tabla `sede`
--
ALTER TABLE `sede`
  ADD PRIMARY KEY (`idSede`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`),
  ADD KEY `idRolUsuario` (`idRolUsuario`),
  ADD KEY `idReunionUsuario` (`idReunionUsuario`),
  ADD KEY `idSedeUsuario` (`idSedeUsuario`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `bitacora_ibfk_1` FOREIGN KEY (`idReunionBitacora`) REFERENCES `reunion` (`idReunion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `inmueblearea`
--
ALTER TABLE `inmueblearea`
  ADD CONSTRAINT `inmueblearea_ibfk_1` FOREIGN KEY (`idSedeInmuebleArea`) REFERENCES `sede` (`idSede`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `inmueblearea_ibfk_2` FOREIGN KEY (`idRolInmuebleArea`) REFERENCES `rol` (`idRol`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `reunion`
--
ALTER TABLE `reunion`
  ADD CONSTRAINT `reunion_ibfk_1` FOREIGN KEY (`idSedeReunion`) REFERENCES `sede` (`idSede`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `rol`
--
ALTER TABLE `rol`
  ADD CONSTRAINT `rol_ibfk_1` FOREIGN KEY (`idSedeRol`) REFERENCES `sede` (`idSede`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rol_ibfk_2` FOREIGN KEY (`idBitacoraRol`) REFERENCES `bitacora` (`idBitacora`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rol_ibfk_3` FOREIGN KEY (`idReunionRol`) REFERENCES `reunion` (`idReunion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`idRolUsuario`) REFERENCES `rol` (`idRol`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `usuario_ibfk_2` FOREIGN KEY (`idSedeUsuario`) REFERENCES `sede` (`idSede`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `usuario_ibfk_3` FOREIGN KEY (`idReunionUsuario`) REFERENCES `reunion` (`idReunion`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
