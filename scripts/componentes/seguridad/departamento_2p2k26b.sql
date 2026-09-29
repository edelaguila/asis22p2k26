-- =====================================================================
-- Script: departamento_2p2k26b.sql
-- Examen 2P - Mantenimiento2k26 (tabla departamento)
-- Ejecutar DESPUÉS de dbSistemaEmbutidos_v1.8.sql
-- =====================================================================
USE `dbsistemaembutidos`;

-- 1. Tabla del mantenimiento
CREATE TABLE IF NOT EXISTS `departamento` (
  `codigo_departamento` VARCHAR(5) NOT NULL,
  `nombre_departamento` VARCHAR(80) NOT NULL,
  `estatus_departamento` VARCHAR(1) NOT NULL,
  PRIMARY KEY (`codigo_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 2. Aplicación en Seguridad (Módulo 4 = Seguridad, Aplicación 16 = Departamentos)
--    El código C# usa IdModulo = 4 e IdAplicacion = 16.
INSERT INTO `tblaplicacion` (`idAplicacion`, `idModulo`, `nombreAplicacion`, `descripcionAplicacion`, `is_active`)
VALUES (16, 4, 'Departamentos', 'Mantenimiento de departamentos (Mantenimiento2k26)', 1);

-- 3. Perfil del examen: perfil2p2k26b (agrupa el mantenimiento de departamentos)
INSERT INTO `tblrol` (`nombreRol`, `descripcionRol`, `is_active`)
VALUES ('perfil2p2k26b', 'Perfil del segundo parcial: mantenimiento de departamentos', 1);

INSERT INTO `tblrolmoduloaplicacion`
  (`idRol`, `idModulo`, `idAplicacion`, `derInsertarRolModuloAplicacion`, `derEditarRolModuloAplicacion`, `derEliminarRolModuloAplicacion`, `derImprimirRolModuloAplicacion`)
SELECT `idRol`, 4, 16, 1, 1, 1, 1 FROM `tblrol` WHERE `nombreRol` = 'perfil2p2k26b';

-- Bitácora (Módulo 4, Aplicación 12) para poder mostrar los movimientos con el mismo usuario
INSERT INTO `tblrolmoduloaplicacion`
  (`idRol`, `idModulo`, `idAplicacion`, `derInsertarRolModuloAplicacion`, `derEditarRolModuloAplicacion`, `derEliminarRolModuloAplicacion`, `derImprimirRolModuloAplicacion`)
SELECT `idRol`, 4, 12, 0, 0, 0, 1 FROM `tblrol` WHERE `nombreRol` = 'perfil2p2k26b';

-- El Administrador (idRol 1) también puede usar el mantenimiento
INSERT INTO `tblrolmoduloaplicacion`
  (`idRol`, `idModulo`, `idAplicacion`, `derInsertarRolModuloAplicacion`, `derEditarRolModuloAplicacion`, `derEliminarRolModuloAplicacion`, `derImprimirRolModuloAplicacion`)
VALUES (1, 4, 16, 1, 1, 1, 1);

-- 4. Empleado y usuario del examen: examen2p2k26b   contraseña: Examen2p2k26b
--    Cada empleado solo puede tener un usuario (uqIdEmpleadoUsuario), por eso se crea
--    un empleado nuevo. La contraseña va cifrada con BCrypt como el resto.
INSERT INTO `tblempleado`
  (`codigoEmpleado`, `dpiEmpleado`, `nitEmpleado`, `nombresEmpleado`, `apellidosEmpleado`, `puestoEmpleado`,
   `generoEmpleado`, `fechaNacimientoEmpleado`, `fechaContratacionEmpleado`, `telefonoEmpleado`, `correoEmpleado`, `is_active`)
VALUES ('EMP-2P26', '2026222222222', '2026222-2', 'Examen', 'Segundo Parcial', 'Pruebas examen 2P',
        'M', '2000-01-01', CURDATE(), '22222222', 'examen2p2k26b@terminus.com', 1);

INSERT INTO `tblusuario` (`idEmpleado`, `nombreUsuario`, `contrasenaUsuario`, `ultimoAccesoUsuario`, `is_active`)
SELECT `idEmpleado`, 'examen2p2k26b', '$2b$10$EMUboTSezgbWhd7PjhaUZO/xWujFuYxbZdnyl02g31dTHLec8vLlS', NOW(), 1
FROM `tblempleado` WHERE `codigoEmpleado` = 'EMP-2P26';

INSERT INTO `tblusuariorol` (`idUsuario`, `idRol`, `fechaAsignacionUsuarioRol`)
SELECT u.`idUsuario`, r.`idRol`, CURDATE()
FROM `tblusuario` u, `tblrol` r
WHERE u.`nombreUsuario` = 'examen2p2k26b' AND r.`nombreRol` = 'perfil2p2k26b';

-- 5. Revisión
SELECT * FROM `departamento`;
SELECT * FROM `tblbitacora` WHERE `tablaBitacora` = 'departamento' ORDER BY `idBitacora` DESC;
