CREATE DATABASE TareaPractica1

USE TareaPractica1

CREATE TABLE Cliente(
Carnet  int PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
DPI BIGINT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Telefono BIGINT NOT NULL
)

CREATE TABLE Libro(
IdLibro INT IDENTITY (1,1) PRIMARY KEY,
Nombrelibro VARCHAR(MAX) NOT NULL,
NumExistencias INT NOT NULL,
NumPaginas INT NOT NULL,
Autorlibro VARCHAR(MAX) NOT NULL,
Temalibro VARCHAR(MAX) NOT NULL,
Disponibles INT NOT NULL,
Prestamos INT NOT NULL,
Reserva Int NOT NULL
)

CREATE TABLE Prestamo(
IdPrestamo INT IDENTITY (1,1) PRIMARY KEY,
Carnet INT NOT NULL,
IdLibro INT NOT NULL,
FOREIGN KEY (Carnet) REFERENCES Cliente(Carnet),
FOREIGN KEY (IdLibro) REFERENCES Libro(IdLibro)
)