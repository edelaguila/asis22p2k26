CREATE DATABASE IF NOT EXISTS dbSistemaEmbutidos
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;
/*final*/
USE dbSistemaEmbutidos;

CREATE TABLE tblEmpleado (
    idEmpleado INT AUTO_INCREMENT NOT NULL,
    codigoEmpleado VARCHAR(30) NOT NULL,
    dpiEmpleado CHAR(13) NOT NULL,
    nitEmpleado CHAR(10) NOT NULL,
    nombresEmpleado VARCHAR(100) NOT NULL,
    apellidosEmpleado VARCHAR(100) NOT NULL,
    puestoEmpleado VARCHAR(255) NOT NULL,
    generoEmpleado CHAR(1) NOT NULL COMMENT 'M = Masculino, F = Femenino',
    fechaNacimientoEmpleado DATE NOT NULL,
    fechaContratacionEmpleado DATE NOT NULL,
    telefonoEmpleado VARCHAR(30) NOT NULL,
    correoEmpleado VARCHAR(150) NOT NULL,
    is_active BOOLEAN NOT NULL DEFAULT TRUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Empleado PRIMARY KEY (idEmpleado),
    CONSTRAINT uqCodigoEmpleado UNIQUE (codigoEmpleado),
    CONSTRAINT uqDpiEmpleado UNIQUE (dpiEmpleado),
    CONSTRAINT uqNitEmpleado UNIQUE (nitEmpleado),
    CONSTRAINT uqCorreoEmpleado UNIQUE (correoEmpleado)
) ENGINE=InnoDB;

CREATE TABLE tblRol (
    idRol INT AUTO_INCREMENT NOT NULL,
    nombreRol VARCHAR(100) NOT NULL,
    descripcionRol VARCHAR(255) NOT NULL,
    is_active BOOLEAN NOT NULL DEFAULT TRUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Rol PRIMARY KEY (idRol),
    CONSTRAINT uqNombreRol UNIQUE (nombreRol)
) ENGINE=InnoDB;

CREATE TABLE tblModulo (
    idModulo INT AUTO_INCREMENT NOT NULL,
    nombreModulo VARCHAR(100) NOT NULL,
    descripcionModulo VARCHAR(255) NOT NULL,
    is_active BOOLEAN NOT NULL DEFAULT TRUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Modulo PRIMARY KEY (idModulo),
    CONSTRAINT uqNombreModulo UNIQUE (nombreModulo)
) ENGINE=InnoDB;

CREATE TABLE tblAplicacion (
    idAplicacion INT AUTO_INCREMENT NOT NULL,
    idModulo INT NOT NULL,
    nombreAplicacion VARCHAR(100) NOT NULL,
    descripcionAplicacion VARCHAR(255) NOT NULL,
    is_active BOOLEAN NOT NULL DEFAULT TRUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Aplicacion PRIMARY KEY (idAplicacion),
    CONSTRAINT Fk_Aplicacion_Modulo FOREIGN KEY (idModulo)
        REFERENCES tblModulo (idModulo) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE tblUsuario (
    idUsuario INT AUTO_INCREMENT,
    idEmpleado INT NOT NULL,
    nombreUsuario VARCHAR(30) NOT NULL,
    contrasenaUsuario VARCHAR(255) NOT NULL,
    ultimoAccesoUsuario DATETIME NOT NULL,
    is_active BOOLEAN NOT NULL DEFAULT TRUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Usuario PRIMARY KEY (idUsuario),
    CONSTRAINT uqIdEmpleadoUsuario UNIQUE (idEmpleado),
    CONSTRAINT uqUsuarioUsuario UNIQUE (nombreUsuario),
    CONSTRAINT Fk_Usuario_Empleado FOREIGN KEY (idEmpleado)
        REFERENCES tblEmpleado (idEmpleado) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE tblRecuperacionContrasena (
    idRecuperacionContrasena INT AUTO_INCREMENT NOT NULL,
    idUsuario INT NOT NULL,
    tokenRecuperacionContrasena VARCHAR(255) NOT NULL,
    fechaExpiracionRecuperacionContrasena DATETIME NOT NULL,
    usadoRecuperacionContrasena BOOLEAN NOT NULL DEFAULT FALSE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_RecuperacionContrasena PRIMARY KEY (idRecuperacionContrasena),
    CONSTRAINT uqTokenRecuperacionContrasena UNIQUE (tokenRecuperacionContrasena),
    CONSTRAINT Fk_RecuperacionContrasena_Usuario FOREIGN KEY (idUsuario)
        REFERENCES tblUsuario (idUsuario) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE tblUsuarioRol (
    idUsuario INT NOT NULL,
    idRol INT NOT NULL,
    fechaAsignacionUsuarioRol DATE NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_UsuarioRol PRIMARY KEY (idUsuario, idRol),
    CONSTRAINT Fk_UsuarioRol_Usuario FOREIGN KEY (idUsuario)
        REFERENCES tblUsuario (idUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT Fk_UsuarioRol_Rol FOREIGN KEY (idRol)
        REFERENCES tblRol (idRol) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE tblRolModuloAplicacion (
    idRol INT NOT NULL,
    idModulo INT NOT NULL,
    idAplicacion INT NOT NULL,
    derInsertarRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    derEditarRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    derEliminarRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    derImprimirRolModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_RolModuloAplicacion PRIMARY KEY (idRol, idModulo, idAplicacion),
    CONSTRAINT Fk_RolModuloAplicacion_Rol FOREIGN KEY (idRol)
        REFERENCES tblRol (idRol) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT Fk_RolModuloAplicacion_Modulo FOREIGN KEY (idModulo)
        REFERENCES tblModulo (idModulo) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT Fk_RolModuloAplicacion_Aplicacion FOREIGN KEY (idAplicacion)
        REFERENCES tblAplicacion (idAplicacion) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE tblUsuarioModuloAplicacion (
    idUsuario INT NOT NULL,
    idModulo INT NOT NULL,
    idAplicacion INT NOT NULL,
    derInsertarUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    derEditarUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    derEliminarUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    derImprimirUsuarioModuloAplicacion BOOLEAN NOT NULL DEFAULT FALSE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT Pk_UsuarioModuloAplicacion PRIMARY KEY (idUsuario, idModulo, idAplicacion),
    CONSTRAINT Fk_UsuarioModuloAplicacion_Usuario FOREIGN KEY (idUsuario)
        REFERENCES tblUsuario (idUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT Fk_UsuarioModuloAplicacion_Modulo FOREIGN KEY (idModulo)
        REFERENCES tblModulo (idModulo) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT Fk_UsuarioModuloAplicacion_Aplicacion FOREIGN KEY (idAplicacion)
        REFERENCES tblAplicacion (idAplicacion) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE tblBitacora (
    idBitacora INT AUTO_INCREMENT NOT NULL,
    idUsuario INT,
    accionBitacora VARCHAR(30) NOT NULL,
    tablaBitacora VARCHAR(100) NOT NULL,
    idRegistroBitacora INT NOT NULL,
    detallesBitacora TEXT NOT NULL,
    ipBitacora VARCHAR(50) NOT NULL,
    fechaHoraBitacora DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT Pk_Bitacora PRIMARY KEY (idBitacora),
    CONSTRAINT Fk_Bitacora_Usuario FOREIGN KEY (idUsuario)
        REFERENCES tblUsuario (idUsuario) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE INDEX idxUsuarioIdEmpleado ON tblUsuario (idEmpleado);
CREATE INDEX idxRecuperacionContrasenaIdUsuario ON tblRecuperacionContrasena (idUsuario);
CREATE INDEX idxUsuarioRolIdRol ON tblUsuarioRol (idRol);
CREATE INDEX idxAplicacionIdModulo ON tblAplicacion (idModulo);
CREATE INDEX idxRolModAplIdModulo ON tblRolModuloAplicacion (idModulo);
CREATE INDEX idxRolModAplIdAplicacion ON tblRolModuloAplicacion (idAplicacion);
CREATE INDEX idxUsrModAplIdModulo ON tblUsuarioModuloAplicacion (idModulo);
CREATE INDEX idxUsrModAplIdAplicacion ON tblUsuarioModuloAplicacion (idAplicacion);
CREATE INDEX idxBitacoraIdUsuario ON tblBitacora (idUsuario);
CREATE INDEX idxBitacoraFechaHora ON tblBitacora (fechaHoraBitacora);
CREATE INDEX idxBitacoraTabla ON tblBitacora (tablaBitacora);

USE dbSistemaEmbutidos;

-- 1. tblEmpleado
INSERT INTO tblEmpleado (
    codigoEmpleado, dpiEmpleado, nitEmpleado, nombresEmpleado, apellidosEmpleado,
    puestoEmpleado, generoEmpleado, fechaNacimientoEmpleado, fechaContratacionEmpleado,
    telefonoEmpleado, correoEmpleado
) VALUES
('EMP-001', '1234567890123', '1234567K', 'Isabel', 'Meléndez', 'Coordinadora de Implementación', 'F', '2000-05-14', '2026-01-10', '55512345', 'terminus.seguridad22026@gmail.com'),
('EMP-002', '2345678901234', '2345678K', 'Carlos', 'Ramírez', 'Analista de Sistemas', 'M', '1998-03-22', '2025-11-05', '55523456', 'carlos.ramirez@terminus.com'),
('EMP-003', '3456789012345', '3456789K', 'María', 'López', 'Administradora de Base de Datos', 'F', '1995-09-30', '2025-08-19', '55534567', 'maria.lopez@terminus.com');

-- 2. tblRol
INSERT INTO tblRol (nombreRol, descripcionRol) VALUES
('Administrador', 'Rol con acceso total al sistema'),
('Supervisor', 'Rol con acceso a reportes y aprobaciones'),
('Operativo', 'Rol con acceso limitado a registro de datos');

-- 3. tblModulo (módulos de negocio + Seguridad restaurado)
INSERT INTO tblModulo (nombreModulo, descripcionModulo) VALUES
('Producción', 'Módulo de control de producción de embutidos'),
('Inventario', 'Módulo de control de materia prima y producto terminado'),
('Ventas', 'Módulo de gestión de pedidos y clientes'),
('Seguridad', 'Módulo de administración y seguridad del sistema');

-- 4. tblAplicacion - Aplicaciones de negocio
INSERT INTO tblAplicacion (idModulo, nombreAplicacion, descripcionAplicacion) VALUES
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Producción'), 'Registro de Lotes', 'Registro y seguimiento de lotes de producción'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Inventario'), 'Control de Existencias', 'Control de entradas y salidas de inventario'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Ventas'), 'Gestión de Pedidos', 'Registro y seguimiento de pedidos de clientes');

-- 4b. tblAplicacion - Aplicaciones del módulo Seguridad (restauradas)
INSERT INTO tblAplicacion (idModulo, nombreAplicacion, descripcionAplicacion) VALUES
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Empleados', 'Gestión de empleados del sistema'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Usuarios', 'Gestión de usuarios del sistema'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Módulos', 'Administración de módulos del sistema'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Aplicaciones', 'Administración de aplicaciones del sistema'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Perfiles', 'Administración de roles/perfiles'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Asignación de Perfiles', 'Asignación de roles a usuarios'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Asignación Aplicación Perfiles', 'Asignación de permisos por rol/módulo/aplicación'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Asignación Aplicación Usuario', 'Asignación de permisos por usuario/módulo/aplicación'),
((SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'), 'Bitácora', 'Consulta de bitácora del sistema');

-- 5. tblUsuario (contraseñas hasheadas con BCrypt)
INSERT INTO tblUsuario (idEmpleado, nombreUsuario, contrasenaUsuario, ultimoAccesoUsuario) VALUES
((SELECT idEmpleado FROM tblEmpleado WHERE codigoEmpleado = 'EMP-001'), 'imelendez', '$2b$10$e9CQKArQRmpf.IUtqpxYmOoO9vyh2./7ped56qEokwfgn7DkcacPC', NOW()),
((SELECT idEmpleado FROM tblEmpleado WHERE codigoEmpleado = 'EMP-002'), 'cramirez', '$2b$10$ojN1MyPkUaylOuupBEGmhemdx5tQi4BdbbJrpSF2ZJjD0ZWM/lbe2', NOW()),
((SELECT idEmpleado FROM tblEmpleado WHERE codigoEmpleado = 'EMP-003'), 'mlopez', '$2b$10$Bo9RDmJRGKKLxm1tSmRO1ODP0CiGmuqy/wcnJ6bs2MkOVe1OQml5i', NOW());

-- 6. tblRecuperacionContrasena
INSERT INTO tblRecuperacionContrasena (idUsuario, tokenRecuperacionContrasena, fechaExpiracionRecuperacionContrasena, usadoRecuperacionContrasena) VALUES
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'imelendez'), 'TOKEN-A1B2C3D4', DATE_ADD(NOW(), INTERVAL 1 DAY), FALSE),
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'cramirez'), 'TOKEN-E5F6G7H8', DATE_ADD(NOW(), INTERVAL 1 DAY), FALSE),
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'mlopez'), 'TOKEN-I9J0K1L2', DATE_ADD(NOW(), INTERVAL 1 DAY), TRUE);

-- 7. tblUsuarioRol
INSERT INTO tblUsuarioRol (idUsuario, idRol, fechaAsignacionUsuarioRol) VALUES
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'imelendez'), (SELECT idRol FROM tblRol WHERE nombreRol = 'Administrador'), CURDATE()),
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'cramirez'), (SELECT idRol FROM tblRol WHERE nombreRol = 'Supervisor'), CURDATE()),
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'mlopez'), (SELECT idRol FROM tblRol WHERE nombreRol = 'Operativo'), CURDATE());

INSERT INTO tblRolModuloAplicacion (idRol, idModulo, idAplicacion, derInsertarRolModuloAplicacion, derEditarRolModuloAplicacion, derEliminarRolModuloAplicacion, derImprimirRolModuloAplicacion) VALUES
(
    (SELECT idRol FROM tblRol WHERE nombreRol = 'Administrador'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Producción'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Registro de Lotes'),
    TRUE, TRUE, TRUE, TRUE
),
(
    (SELECT idRol FROM tblRol WHERE nombreRol = 'Supervisor'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Inventario'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Control de Existencias'),
    TRUE, TRUE, FALSE, TRUE
),
(
    (SELECT idRol FROM tblRol WHERE nombreRol = 'Operativo'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Ventas'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Gestión de Pedidos'),
    TRUE, FALSE, FALSE, FALSE
);

-- Administrador: acceso TOTAL a las 9 aplicaciones de Seguridad
INSERT INTO tblRolModuloAplicacion (idRol, idModulo, idAplicacion, derInsertarRolModuloAplicacion, derEditarRolModuloAplicacion, derEliminarRolModuloAplicacion, derImprimirRolModuloAplicacion)
SELECT
    (SELECT idRol FROM tblRol WHERE nombreRol = 'Administrador'),
    a.idModulo,
    a.idAplicacion,
    TRUE, TRUE, TRUE, TRUE
FROM tblAplicacion a
WHERE a.idModulo = (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad');

-- Supervisor: acceso PARCIAL solo a Empleados y Usuarios
INSERT INTO tblRolModuloAplicacion (idRol, idModulo, idAplicacion, derInsertarRolModuloAplicacion, derEditarRolModuloAplicacion, derEliminarRolModuloAplicacion, derImprimirRolModuloAplicacion) VALUES
(
    (SELECT idRol FROM tblRol WHERE nombreRol = 'Supervisor'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Empleados' AND idModulo = (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad')),
    TRUE, TRUE, FALSE, FALSE
),
(
    (SELECT idRol FROM tblRol WHERE nombreRol = 'Supervisor'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Usuarios' AND idModulo = (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad')),
    FALSE, FALSE, FALSE, TRUE
);

-- Operativo: SIN acceso al módulo Seguridad (a propósito, no se inserta ninguna fila)

INSERT INTO tblUsuarioModuloAplicacion (idUsuario, idModulo, idAplicacion, derInsertarUsuarioModuloAplicacion, derEditarUsuarioModuloAplicacion, derEliminarUsuarioModuloAplicacion, derImprimirUsuarioModuloAplicacion) VALUES
(
    (SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'imelendez'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Producción'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Registro de Lotes'),
    TRUE, TRUE, TRUE, TRUE
),
(
    (SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'cramirez'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Inventario'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Control de Existencias'),
    TRUE, TRUE, FALSE, FALSE
),
(
    (SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'mlopez'),
    (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Ventas'),
    (SELECT idAplicacion FROM tblAplicacion WHERE nombreAplicacion = 'Gestión de Pedidos'),
    TRUE, FALSE, FALSE, FALSE
);

-- 10. tblBitacora
INSERT INTO tblBitacora (idUsuario, accionBitacora, tablaBitacora, idRegistroBitacora, detallesBitacora, ipBitacora) VALUES
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'imelendez'), 'INSERT', 'tblEmpleado', 1, 'Alta de empleado de prueba', '192.168.1.10'),
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'cramirez'), 'UPDATE', 'tblAplicacion', 2, 'Actualización de datos de aplicación', '192.168.1.11'),
((SELECT idUsuario FROM tblUsuario WHERE nombreUsuario = 'mlopez'), 'DELETE', 'tblUsuarioRol', 3, 'Eliminación de asignación de rol', '192.168.1.12');

SELECT a.idModulo, a.idAplicacion, a.nombreAplicacion, r.nombreRol,
       rma.derInsertarRolModuloAplicacion AS Insertar,
       rma.derEditarRolModuloAplicacion AS Editar,
       rma.derEliminarRolModuloAplicacion AS Eliminar,
       rma.derImprimirRolModuloAplicacion AS Imprimir
FROM tblAplicacion a
LEFT JOIN tblRolModuloAplicacion rma ON rma.idAplicacion = a.idAplicacion AND rma.idModulo = a.idModulo
LEFT JOIN tblRol r ON r.idRol = rma.idRol
WHERE a.idModulo = (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad')
ORDER BY a.idAplicacion, r.nombreRol;

SELECT idAplicacion, nombreAplicacion
FROM tblAplicacion
WHERE idModulo = (SELECT idModulo FROM tblModulo WHERE nombreModulo = 'Seguridad')
ORDER BY idAplicacion;

SELECT * FROM dbSistemaEmbutidos.tblBitacora ORDER BY idBitacora DESC LIMIT 5;
