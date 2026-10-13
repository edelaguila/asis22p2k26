-- ===================================================================
-- Área   : Mantenimiento2k26u
-- Autor  : José Pablo Cano Cóbar
-- Carné  : 0901-23-1727
-- Fecha  : 13/10/2026
-- ===================================================================
-- Propósito :
--   Script de base de datos del mantenimiento de Películas. Crea la
--   tabla tblpelicula dentro de la base del sistema de Seguridad,
--   la registra como aplicación en el catálogo de módulos y
--   aplicaciones, y otorga los permisos al rol Administrador para
--   que el formulario quede habilitado en el menú del MDI.
--
-- Reglas específicas :
--   Todo el script es idempotente: se puede ejecutar varias veces
--   sin duplicar registros ni perder los datos ya capturados.
--   La bitácora NO se crea aquí: se reutiliza tblbitacora del
--   sistema de Seguridad, que es lo que exige el enunciado.
-- ===================================================================

USE `dbsistemaembutidos`;

-- -------------------------------------------------------------------
-- 1) TABLA DEL MANTENIMIENTO
-- -------------------------------------------------------------------
-- Equivalencia con el diagrama entregado:
--   idPeliculas  -> idPelicula            Clasificación -> clasificacionPelicula
--   Nombre       -> nombrePelicula        Genero        -> generoPelicula
--   Subtitulado  -> subtituladoPelicula   Idioma        -> idiomaPelicula
--   precio       -> precioPelicula
-- Se adoptó la convención del resto del esquema (camelCase + sufijo de
-- la entidad) y se quitó la tilde de "Clasificación": un identificador
-- acentuado obliga a backticks en cada sentencia y rompe la lectura
-- por ODBC si el archivo .cs no está guardado como UTF-8.
-- Las tres columnas de control (is_active, created_at, updated_at)
-- existen en las nueve tablas de Seguridad; se mantienen por simetría.
-- -------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS `tblpelicula` (
  `idPelicula`            int          NOT NULL AUTO_INCREMENT,
  `nombrePelicula`        varchar(45)  COLLATE utf8mb4_unicode_ci NOT NULL,
  `clasificacionPelicula` varchar(45)  COLLATE utf8mb4_unicode_ci NOT NULL,
  `generoPelicula`        varchar(45)  COLLATE utf8mb4_unicode_ci NOT NULL,
  `subtituladoPelicula`   varchar(45)  COLLATE utf8mb4_unicode_ci NOT NULL,
  `idiomaPelicula`        varchar(45)  COLLATE utf8mb4_unicode_ci NOT NULL,
  `precioPelicula`        double       NOT NULL DEFAULT 0,
  `is_active`             tinyint(1)   NOT NULL DEFAULT 1,
  `created_at`            timestamp    NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at`            timestamp    NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idPelicula`),
  UNIQUE KEY `uqNombrePelicula` (`nombrePelicula`),
  KEY `idxPeliculaGenero` (`generoPelicula`),
  KEY `idxPeliculaClasificacion` (`clasificacionPelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- -------------------------------------------------------------------
-- 2) REGISTRO EN EL CATÁLOGO DE MÓDULOS Y APLICACIONES
-- -------------------------------------------------------------------
-- El MDI de Seguridad habilita cada botón consultando el par
-- (idModulo, idAplicacion) en tblrolmoduloaplicacion. Sin estas filas
-- el formulario queda deshabilitado aunque el código esté perfecto.
-- Se usan ids fijos 20 y 21 porque el AUTO_INCREMENT sembrado llega a
-- 14 en tblmodulo y a 16 en tblaplicacion: quedan libres.
-- -------------------------------------------------------------------

INSERT INTO `tblmodulo` (`idModulo`, `nombreModulo`, `descripcionModulo`, `is_active`)
VALUES (20, 'Catálogos', 'Catálogos y mantenimientos generales del sistema', 1)
ON DUPLICATE KEY UPDATE
  `nombreModulo`      = VALUES(`nombreModulo`),
  `descripcionModulo` = VALUES(`descripcionModulo`),
  `is_active`         = 1;

INSERT INTO `tblaplicacion` (`idAplicacion`, `idModulo`, `nombreAplicacion`, `descripcionAplicacion`, `is_active`)
VALUES (21, 20, 'Películas', 'Mantenimiento del catálogo de películas', 1)
ON DUPLICATE KEY UPDATE
  `idModulo`              = VALUES(`idModulo`),
  `nombreAplicacion`      = VALUES(`nombreAplicacion`),
  `descripcionAplicacion` = VALUES(`descripcionAplicacion`),
  `is_active`             = 1;

-- -------------------------------------------------------------------
-- 3) PERMISOS
-- -------------------------------------------------------------------
-- Los permisos del sistema son por ROL (tblrolmoduloaplicacion).
-- tblusuariomoduloaplicacion existe pero no se evalúa en ningún punto
-- del código, así que asignar permisos ahí no habilita nada.
-- Rol 1 = Administrador: los cuatro derechos.
-- -------------------------------------------------------------------

INSERT INTO `tblrolmoduloaplicacion`
      (`idRol`, `idModulo`, `idAplicacion`,
       `derInsertarRolModuloAplicacion`, `derEditarRolModuloAplicacion`,
       `derEliminarRolModuloAplicacion`, `derImprimirRolModuloAplicacion`)
VALUES (1, 20, 21, 1, 1, 1, 1)
ON DUPLICATE KEY UPDATE
  `derInsertarRolModuloAplicacion`  = 1,
  `derEditarRolModuloAplicacion`    = 1,
  `derEliminarRolModuloAplicacion`  = 1,
  `derImprimirRolModuloAplicacion`  = 1;

-- Rol 2 = Supervisor: puede ingresar, editar e imprimir, pero no eliminar.
-- Sirve para demostrar en vivo que los permisos se están leyendo de verdad.
INSERT INTO `tblrolmoduloaplicacion`
      (`idRol`, `idModulo`, `idAplicacion`,
       `derInsertarRolModuloAplicacion`, `derEditarRolModuloAplicacion`,
       `derEliminarRolModuloAplicacion`, `derImprimirRolModuloAplicacion`)
VALUES (2, 20, 21, 1, 1, 0, 1)
ON DUPLICATE KEY UPDATE
  `derInsertarRolModuloAplicacion`  = 1,
  `derEditarRolModuloAplicacion`    = 1,
  `derEliminarRolModuloAplicacion`  = 0,
  `derImprimirRolModuloAplicacion`  = 1;

-- -------------------------------------------------------------------
-- 4) DATOS DE PRUEBA
-- -------------------------------------------------------------------
-- Ocho registros que cubren los casos que conviene enseñar: precios con
-- y sin decimales, subtitulado en ambos valores, cuatro clasificaciones
-- y un registro inactivo para que se vea la casilla Estado desmarcada.
-- -------------------------------------------------------------------

INSERT INTO `tblpelicula`
      (`nombrePelicula`, `clasificacionPelicula`, `generoPelicula`,
       `subtituladoPelicula`, `idiomaPelicula`, `precioPelicula`, `is_active`)
VALUES
  ('El Padrino',                  'C',    'Drama',            'Sí', 'Inglés',  45.00, 1),
  ('Buscando a Nemo',             'A',    'Animación',        'No', 'Español', 35.50, 1),
  ('El Origen',                   'B',    'Ciencia ficción',  'Sí', 'Inglés',  52.75, 1),
  ('Roma',                        'B-15', 'Drama',            'Sí', 'Español', 40.00, 1),
  ('Parásitos',                   'C',    'Suspenso',         'Sí', 'Coreano', 55.25, 1),
  ('Coco',                        'A',    'Animación',        'No', 'Español', 38.00, 1),
  ('El Laberinto del Fauno',      'C',    'Terror',           'Sí', 'Español', 48.90, 1),
  ('Cinta Descontinuada',         'D',    'Documental',       'No', 'Francés', 25.00, 0)
ON DUPLICATE KEY UPDATE `updated_at` = CURRENT_TIMESTAMP;

-- -------------------------------------------------------------------
-- 5) VERIFICACIÓN
-- -------------------------------------------------------------------
-- Si cualquiera de estas tres consultas viene vacía, el mantenimiento
-- no va a funcionar y aquí se ve por qué.
-- -------------------------------------------------------------------

SELECT 'Tabla'       AS Revision, COUNT(*) AS Registros FROM `tblpelicula`
UNION ALL
SELECT 'Aplicación',  COUNT(*) FROM `tblaplicacion`          WHERE `idAplicacion` = 21 AND `idModulo` = 20
UNION ALL
SELECT 'Permisos',    COUNT(*) FROM `tblrolmoduloaplicacion` WHERE `idModulo` = 20 AND `idAplicacion` = 21;

-- Qué rol puede hacer qué sobre el mantenimiento:
SELECT r.`idRol`, r.`nombreRol`,
       p.`derInsertarRolModuloAplicacion`  AS Insertar,
       p.`derEditarRolModuloAplicacion`    AS Editar,
       p.`derEliminarRolModuloAplicacion`  AS Eliminar,
       p.`derImprimirRolModuloAplicacion`  AS Imprimir
  FROM `tblrolmoduloaplicacion` p
  JOIN `tblrol` r ON r.`idRol` = p.`idRol`
 WHERE p.`idModulo` = 20 AND p.`idAplicacion` = 21;
