USE dbsistemaembutidos; 
CREATE TABLE IF NOT EXISTS tbl_paciente 
(pk_idPaciente INT NOT NULL PRIMARY KEY, 
nombrePaci VARCHAR(50) NOT NULL, 
apellidoPaci VARCHAR(50) NOT NULL, 
FechaNacimiento DATE NOT NULL, 
Genero INT NOT NULL, 
direccionPaci VARCHAR(30) NOT NULL, 
Telefono INT NOT NULL, 
estadoPaci INT NOT NULL);
