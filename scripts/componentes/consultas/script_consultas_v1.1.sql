CREATE DATABASE dbConsulta;
USE dbConsulta;

CREATE TABLE tblConsulta (
    Pk_Consulta INT AUTO_INCREMENT,
    nombreConsulta VARCHAR(100) NOT NULL,
    tablaConsulta VARCHAR(255) NOT NULL, 
    queryConsulta TEXT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
        ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_Consulta PRIMARY KEY (Pk_Consulta),
    CONSTRAINT Uq_NombreConsulta UNIQUE (nombreConsulta)
);
