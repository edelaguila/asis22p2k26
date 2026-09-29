USE `dbsistemaembutidos`;

-- 1. Tabla
CREATE TABLE `tbltipopuesto` (
  `idTipoPuesto` int NOT NULL AUTO_INCREMENT,
  `nombreTipoPuesto` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `salarioTipoPuesto` double NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idTipoPuesto`),
  UNIQUE KEY `uqNombreTipoPuesto` (`nombreTipoPuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 2. Datos de ejemplo
INSERT INTO tbltipopuesto (nombreTipoPuesto, salarioTipoPuesto) VALUES
('Gerente', 12000.00),
('Coordinador de Implementación', 8500.00),
('Analista de Sistemas', 6500.00),
('Administrador de Base de Datos', 7500.00),
('Probador', 4500.00);

-- 3. Registrar el mantenimiento como aplicación del módulo Seguridad
INSERT INTO tblaplicacion (idModulo, nombreAplicacion, descripcionAplicacion)
SELECT idModulo, 'Tipo de Puesto', 'Mantenimiento de tipos de puesto y salarios'
FROM tblmodulo WHERE nombreModulo = 'Seguridad';

SET @idApp = LAST_INSERT_ID();

-- 4. Permisos completos para Administrador y perfil2p2k26e
INSERT INTO tblrolmoduloaplicacion
(idRol, idModulo, idAplicacion,
 derInsertarRolModuloAplicacion, derEditarRolModuloAplicacion,
 derEliminarRolModuloAplicacion, derImprimirRolModuloAplicacion)
SELECT r.idRol, a.idModulo, a.idAplicacion, 1, 1, 1, 1
FROM tblrol r
JOIN tblaplicacion a ON a.idAplicacion = @idApp
WHERE r.nombreRol IN ('Administrador', 'perfil2p2k26e');