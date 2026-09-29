CREATE DATABASE IF NOT EXISTS umg_didactica;
USE umg_didactica;

CREATE TABLE IF NOT EXISTS tbl_roles (
    id_rol INT AUTO_INCREMENT,
    nombre_rol VARCHAR(50) NOT NULL,
    descripcion_rol VARCHAR(200),
    CONSTRAINT pk_tbl_roles PRIMARY KEY (id_rol)
);
