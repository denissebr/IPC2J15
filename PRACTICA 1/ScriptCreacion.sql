create database tareaPractica1

 use tareaPractica1

create table cliente(
idCliente int PRIMARY KEY,
nombre varchar(50) not null,
dpi bigint not null UNIQUE,
direccion varchar(60),
telefono int
)

create table libro(
idLibro int PRIMARY KEY,
nombre varchar(20) not null,
NoExistencia int not null,
NoPagina int not null
)

create table tema(
idTema int PRIMARY KEY,
nombre varchar(20) not null
)

create table autor(
idAutor int PRIMARY KEY,
nombre varchar(20) not null
)

create table asignacion(
idAsignacion int PRIMARY KEY,
idTema int not null,
idAutor int not null,
idLibro int not null,
FOREIGN KEY (idTema) REFERENCES tema(idTema),
FOREIGN KEY (idAutor) REFERENCES autor(idAutor),
FOREIGN KEY (idLibro) REFERENCES libro(idLibro)
)

create table prestamo(
idPrestamo int PRIMARY KEY,
idLibro int not null,
idCliente int not null,
FOREIGN KEY (idLibro) REFERENCES libro(idLibro),
FOREIGN KEY (idCliente) REFERENCES cliente(idCliente)
)

