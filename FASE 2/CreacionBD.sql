CREATE DATABASE IPC2J15

USE IPC2J15 

CREATE TABLE Sede(
IdSede	INT IDENTITY(1,1) PRIMARY KEY,
NombrePais VARCHAR(MAX) NOT NULL,
Comision FLOAT NOT NULL
)

CREATE TABLE Sucursal(
IdSucursal INT IDENTITY(1,1) PRIMARY KEY,
IdSede INT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
Telefono int NOT NULL,
Capacidad_empleado INT NOT NULL,
FOREIGN KEY (IdSede) REFERENCES Sede(IdSede)
)

CREATE TABLE Departamento(
IdDepartamento INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL
)

CREATE TABLE AsignacionDepartamento(
NumeroAsignacion INT IDENTITY(1,1) PRIMARY KEY,
IdSucursal INT NOT NULL,
IdDepartamento INT NOT NULL,
FOREIGN KEY (IdSucursal) REFERENCES Sucursal(IdSucursal),
FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento)
)

CREATE TABLE Empleado(
DPIEmpleado INT  PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Apelllido VARCHAR(MAX) NOT NULL,
Telefono BIGINT NOT NULL,
Sueldo FLOAT NOT NULL,
Direccion VARCHAR(MAX) NOT NULL,
IdDepartamento INT NOT NULL,
Rol VARCHAR(13) NOT NULL,
IdSucursal INT NOT NULL,
Usuario VARCHAR(MAX) NOT NULL,
Contrase�a VARCHAR(15) NOT NULL
FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento),
FOREIGN KEY (IdSucursal) REFERENCES Sucursal(IdSucursal)
)

CREATE TABLE Categoria(
IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
NombreCategoria VARCHAR(MAX) NOT NULL,
ValorImpuesto FLOAT NOT NULL
)

CREATE TABLE Producto(
IdProducto INT IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Descripcion VARCHAR(MAX) NOT NULL,
IdCategoria INT NOT NULL,
Precio FLOAT NOT NULL,
Peso INT NOT NULL,
Estado VARCHAR(MAX) NOT NULL
FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
)

CREATE TABLE Cliente(
DPI INT PRIMARY KEY,
Nombre VARCHAR(MAX) NOT NULL,
Apellido VARCHAR(MAX) NOT NULL,
NIT INT NULL,
Telefono INT NULL,
Domicilio VARCHAR(MAX) NOT NULL,
Tarjeta BIGINT NOT NULL,
Casilla INT IDENTITY(1,1) NOT NULL,
Idsucursal INT NOT NULL,
IdProducto INT NOT NULL,
Usuario VARCHAR(MAX) NOT NULL,
Contrase�a VARCHAR(15) NOT NULL,
Activo BIT NOT NULL,
FOREIGN KEY(IdSucursal) REFERENCES Sucursal(IdSucursal),
FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
)

CREATE TABLE Detalle(
IdDetalle INT IDENTITY(1,1) PRIMARY KEY,
IdProducto INT NOT NULL,
PrecioTotal FLOAT NOT NULL,
FOREIGN KEY(IdProducto) REFERENCES Producto(IdProducto)
)

CREATE TABLE Factura(
NumeroFactura INT IDENTITY(1,1) PRIMARY KEY,
FechaEmision DATE NOT NULL,
DPI INT NOT NULL,
IdDetalle INT NOT NULL,
FOREIGN KEY(DPI) REFERENCES Cliente(DPI),
FOREIGN KEY (IdDetalle) REFERENCES Detalle(IdDetalle)
)