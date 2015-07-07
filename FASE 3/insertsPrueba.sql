Use Fase3V1
/*INSERTS DEPARTAMENTO*/
insert into Departamento values('Servicio al Cliente','Este módulo tiene un conjunto de herramientas orientadas al servicio al cliente')
insert into Departamento values('Paquete','Por medio de éste módulo los empleados hacen toda la gestión de paquetes')
insert into Departamento values('Bodega','Cada sucursal tiene una bodega, los empleados de bodega son los encargados de revisar si todos los paquetes dentro del lote salieron de aduana')

/*INSERTS EMPLEADO*/
insert into empleado values('Lesly','Barrera',42117848,3500,'San Jose Villa Nueva','empleado','1','LeslyBarrera','lbarrera37',1,3)
insert into empleado values('Alejandro','Lopez',57896314,3500,'San Jose Villa Nueva','empleado','2','alejoLop','alejo89',1,3)
insert into empleado values('Dora','Arreaga',78541203,3500,'zona 1 colonia las flores','empleado','3','dora','da69',1,3)

insert into empleado values('Marellyn','Trejo',89652314,4500,'zona 7','director','1','malisTrejo','jossie',1,3)
insert into empleado values('Jossie','Castrillo',40125603,4500,'Villa Nueva','director','2','luser','marellyn',1,3)
insert into empleado values('Glen','Calel',78965412,4500,'Petapa','director','3','glencal','mate',1,3)

insert into empleado values('Jose','gonzales',78989412,5500,'zona 7','administrador','3','josg','1234',1,3)
/*INSERT DE SEDE*/
insert into sede values('Guatemala',5)
insert into sede values('USA',5)
/*INSERTS DE SUCURSAL*/
insert into sucursal values('La rapidita','zona 10',22883421,42,1)
insert into sucursal values('Punto 1','zona 12 Universidad de San Carlos',22887477,36,1)
insert into sucursal values('Central','Miami FL', 4027394,24,2)
/*INSERTS DE CLIENTES*/
insert into cliente values('Jose','Melgar',1478520321456,14523608,22321478,'9na Av. 1-56 zona 1',1,'josmel','1234',3,1478520321456)
/*INSERTS DE CATEGORIA*/
insert into Categoria values('Accesorio de Telefonia',15)
insert into Categoria values('Accesorio Deportivo',10)
insert into Categoria values('Videojuegos',15)
/*INSERTS DE ESTADO DE PRECIO*/
insert into estadoPrecio values('si tiene precio')
insert into estadoPrecio values('tiene imagen')
insert into estadoPrecio values('aprobado bodega')
insert into estadoPrecio values('aprobado director')
/*INSERTS DE ESTADO DE PAQUETE*/
insert into EstadoPaqete values('Pendiente de aprobacion')
insert into EstadoPaqete values('En espera')
insert into EstadoPaqete values('En USA')
insert into EstadoPaqete values('En transito')
insert into EstadoPaqete values('En sucursal')
insert into EstadoPaqete values('Devuelto')
update Paquete set IdEstado=3, Precio=0 where IdPaquete=1
update Paquete set IdEstado=3, Precio=0  where IdPaquete=2
update Empleado set Estado=0 where DPI=2159685210101
update Cliente set Estado=0 where DPI=2492944860101
update Cliente set NoTarjeta=4789652012365874 where DPI=2589631470101
update Cliente set NoTarjeta=4102589630258963 where DPI=2685268110101
// and Tipo:'"+tipo+"'//
alter table cliente
ADD  NoTarjeta bigint  null
update cliente set Estado=0 where dpi=1478520321456
select * from empleado
select * from cliente
select * from paquete
select * from Sucursal
use fase2
BULK INSERT Categoria FROM '‪C:/Users/Denisse/Desktop/datoC.csv' WITH (FIRSTROW = 2, FIELDTERMINATOR=',', ROWTERMINATOR= '/n')
select * from Categoria
BULK INSERT Categoria FROM 'C:\Users\Denisse\Desktop\datoC.csv' WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',', ROWTERMINATOR = '\n', TABLOCK )

select * from paquete
/*ROL: EMPLEADO
TIPO: 1-SERVICIO AL CLIENTE
      2-BODEGA
	  3-PAQUETE
ROL: DIRECTOR
TIPO:4
ROL ADMINISTRADOR
TIPO:4*/
select * from cliente where CONCAT (Nombre,Apellido,Telefono,Nit,Direccion,casilla,UsuarioCliente,PasswordC) like%  'Leal'
update  cliente set Nombre='Vicente', Apellido='Leal', Estado=0 where dpi=2589631470101
update  cliente set Nombre='Oscar', Apellido='Rolando', Estado=0 where dpi=2492944860101

alter table paquete
add  Descripcion VARCHAR(MAX)
insert into lote values('28/06/2015')

Select nombre,apellido,dpi,telefono,nit,direccion,Casilla,Estado,UsuarioCliente from cliente where Estado=0

Select nombre,apellido,dpi,telefono,nit,direccion,Casilla,Estado,UsuarioCliente from Cliente where Estado= 'false'

Select nombre,apellido,dpi,telefono,nit,direccion,Casilla,Estado,UsuarioCliente from Cliente where  Nombre LIKE 'oscar %'

alter table Categoria
drop column Descripcion

select * from asignacionSD


select P.IdPaquete,P.Estado,C.Nombre
from dbo.Paquete P join dbo.Categoria C
on P.IdCategoria = C.IdCategoria



SELECT TOP 5 C.Nombre
from dbo.Paquete P inner join dbo.Categoria C
on P.IdCategoria = C.IdCategoria
group by C.Nombre

SELECT TOP 5 C.Nombre, Cantidad = COUNT(C.Nombre), Ingresos=SUM(P.Precio)
FROM dbo.Paquete P
INNER JOIN dbo.Categoria C
ON P.IdCategoria = C.IdCategoria
GROUP BY C.Nombre
ORDER BY 2 DESC
use Fase3V1
Select * from empleado
Select * from empleado where IdEmpleado=9
select MAX(idhistorialE) from historialEmp where IdEmpleado=9
insert into historialEmp (fechainicio,Idempleado,nombre,apellido,telefono,sueldo,Direccion,tipo,rol,UsuarioEmpleado,PasswordE,Habilitado) values('6/07/2015',9,'Dora','Arreaga','78541204','3550','zona 1 colonia las flores','empleado',3,'dora1','da69',1) 
select P.IdPaquete,P.Estado,P.Precio,C.Nombre
from dbo.Paquete P join dbo.Categoria C
on P.IdCategoria = C.IdCategoria

Update  Empleado set Rol=3 where IdEmpleado=9
select * from cliente
SELECT * FROM cliente WHERE CONCAT (Nombre,Apellido,Dpi,Telefono,Nit,Direccion,Casilla,UsuarioCliente) LIKE '%1%'
select * from dbo.Empleado where Tipo= %like em%
use Fase3V1
select * from dbo.Paquete
update paquete set idLote=1 where idPaquete=3
select * from dbo.EstadoPaqete
select * from dbo.Cliente
select * from departamento
select * from lote
insert into historialPa values('4/07/2015',9,3,2)
SELECT C.casilla, P.IdPaquete, P.Nombre, P.Descripcion FROM dbo.Paquete P JOIN dbo.Cliente C ON P.Dpi = C.Dpi where P.Dpi=1478520321456

select P.IdPaquete,P.IdEstado,P.Precio,C.Nombre
from dbo.Paquete P join dbo.Categoria C
on P.IdCategoria = C.IdCategoria
update historialPa set EstadoTrack=3 where IdHistorialPa=2

select Categoria=C.Nombre, P.Precio, P.Peso,'Fecha de Modificacion'= E.FechaMod, Estado=EP.EstadoDes
from dbo.Paquete p 
join dbo.Categoria C on P.IdCategoria = C.IdCategoria
join dbo.historialPa E on P.IdPaquete=E.IdPaquete 
join dbo.Cliente Cl on P.Dpi=Cl.Dpi
join dbo.EstadoPaqete EP on E.EstadoTrack=EP.EstadoTrack
where P.IdPaquete=3 and P.Dpi=1478520321456


select Categoria=C.Nombre, P.Precio, P.Peso,'Fecha de Modificacion'= E.FechaMod, Estado=EP.EstadoDes 
from dbo.Paquete p 
join dbo.Categoria C on P.IdCategoria = C.IdCategoria 
join dbo.historialPa E on P.IdPaquete=E.IdPaquete  
join dbo.EstadoPaqete EP on E.EstadoTrack=EP.EstadoTrack 
where P.IdPaquete=3

insert into lote values('5/07/2015',3)
select * from lote
select MAX(IdLote) from lote

select Fechasalida from lote

CREATE TABLE LotePrueba(
IdLote INT IDENTITY(1,1) PRIMARY KEY,
FechaSalida DATE NOT NULL,
IdSucursal INT NOT NULL
)
use Fase3V1
select * from historialEmp
update EstadoPaqete set estadoDes='entregado' where EstadoTrack=6
insert into estadopaqete values('devuelto')
insert into LotePrueba (FechaSalida,IdSucursal) values('5/07/2015',3)
select dpi from cliente where casilla=2
select C.Casilla,P.IdPaquete, C.Nombre,C.Apellido,P.Nombre,P.Descripcion,'Precio Q'=P.Precio,'Peso LB'=P.Peso, Estado=E.EstadoDes 
from Paquete P 
join Cliente C on C.Dpi=P.Dpi  
join historialPa H on H.IdPaquete=P.IdPaquete 
join EstadoPaqete E on E.EstadoTrack=H.EstadoTrack 
where C.Dpi=1478520321456 and H.EstadoTrack=2

select 'Identificador'=E.IdEmpleado, E.Nombre,E.Apellido,E.Telefono,E.Sueldo,E.Direccion,'Rol'=D.Nombre,'Usuario'=E.UsuarioEmpleado,'Contraseña'=E.PasswordE,'Sucursal'=S.Nombre,H.FechaInicio,H.Fechafin
from Empleado E
join historialEmp H on  H.IdEmpleado = E.IdEmpleado
join Departamento D on D.IdDepartamento=E.Rol
join Sucursal S on S.IdSucursal=E.IdSucursal
where E.IdEmpleado=18

select 'Fecha Inicio'=fechainicio, 'Fecha Fin'=fechafin, 'Id Empleado'=IdEmpleado, H.nombre, apellido,telefono,Sueldo,Direccion,'Departamento'=D.Nombre,'Usuario Empleado'=usuarioEmpleado, 'Contraseña'=PasswordE  from historialEmp H join Departamento D on D.IdDepartamento=H.Rol

select 'Identificador'=E.IdEmpleado, E.Nombre,E.Apellido,E.Telefono,E.Sueldo,E.Direccion,'Rol'=D.Nombre,'Usuario'=E.UsuarioEmpleado,'Contraseña'=E.PasswordE,S.Nombre,H.FechaInicio,H.Fechafin from Empleado E join historialEmp H on  H.IdEmpleado = E.IdEmpleado join Departamento D on D.IdDepartamento=E.Rol join Sucursal S on S.IdSucursal=E.IdSucursal where E.IdEmpleado=9
alter table historialEmp
drop column IdSucursal
Nombre de categoría,
cantidad de paquetes recibidos, cantidad de paquetes perdidos, cantidad de paquetes
entregados a cliente, suma de totales de costos en impuestos, suma de totales de
costos en peso, suma de totales de comisiones
select C.Nombre, P.IdPaquete, 'Cantidad de Paquetes'=Sum(P.IdPaquete)
from Paquete P
join Categoria c on C.IdCategoria=P.IdCategoria
group by C.Nombre


Nombre de categoría, cantidad
de paquetes recibidos, cantidad de paquetes perdidos, cantidad de paquetes
entregados a cliente, suma de totales de costos en impuestos, suma de totales de
costos en peso, suma de totales de comisione




Resumen administrativo sobre los empleados por departamentos y sucursales.
(Nombre de depto/sucursal, número de empleados, totales en sueldos).


Select S.Nombre,'Sucursal'=Count(E.IdEmpleado),'Suma de Sueldos'=Sum(E.Sueldo)
from Empleado E
join Sucursal S on S.IdSucursal=E.Idsucursal 
Group by S.Nombre

Select 'Departamento'=D.Nombre,'Cantidad de empleados por Departamento'=Count(E.IdEmpleado),'Suma de Sueldos'=Sum(E.Sueldo)
from Empleado E
join Departamento D on D.IdDepartamento=E.Rol 
Group by D.Nombre


Nombre de categoría, cantidad
de paquetes recibidos, cantidad de paquetes perdidos, cantidad de paquetes
entregados a cliente, suma de totales de costos en impuestos, suma de totales de
costos en peso, suma de totales de comisiones

Select C.Nombre, 'Cantidad de paquetes'=Sum(P.IdPaquete)
from Paquete P
join Categoria C on C.IdCategoria = P.IdCategoria
Group by C.Nombre

