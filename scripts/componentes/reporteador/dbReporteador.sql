CREATE DATABASE dbReporteador;

USE dbReporteador;
-- TABLA: REPORTE
CREATE TABLE tblReporte (
    numeroReporte INT NOT NULL,
    nombreReporte VARCHAR(150) NOT NULL,
    rutaReporte VARCHAR(500) NOT NULL,
    fechaReporte DATE NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_Reporte PRIMARY KEY (numeroReporte),
    CONSTRAINT uqNombreReporte UNIQUE (nombreReporte)
) ENGINE=InnoDB;
-- TABLA INTERMEDIA: APLICACION - REPORTE
CREATE TABLE tblAplicacionReporte (
    idAplicacion INT NOT NULL,
    numeroReporte INT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_AplicacionReporte PRIMARY KEY (idAplicacion, numeroReporte),
    CONSTRAINT Fk_Aplicacion_IdAplicacion FOREIGN KEY (idAplicacion)
        REFERENCES tblAplicacion (idAplicacion) ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT Fk_Reporte_NumeroReporte FOREIGN KEY (numeroReporte)
        REFERENCES tblReporte (numeroReporte) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;