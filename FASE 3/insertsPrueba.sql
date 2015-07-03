Use Fase3V1
/*INSERTS DEPARTAMENTO*/
insert into Departamento values('Servicio al Cliente','Este módulo tiene un conjunto de herramientas orientadas al servicio al cliente')
insert into Departamento values('Paquete','Por medio de éste módulo los empleados hacen toda la gestión de paquetes')
insert into Departamento values('Bodega','Cada sucursal tiene una bodega, los empleados de bodega son los encargados de revisar si todos los paquetes dentro del lote salieron de aduana')

/*INSERTS EMPLEADO*/
insert into empleado values('Lesly','Barrera',42117848,3500,'San Jose Villa Nueva','empleado','1','LeslyBarrera','lbarrera37',1)
insert into empleado values('Alejandro','Lopez',57896314,3500,'San Jose Villa Nueva','empleado','2','alejoLop','alejo89',1)
insert into empleado values('Dora','Arreaga',78541203,3500,'zona 1 colonia las flores','empleado','3','dora','da69',1)

insert into empleado values('Marellyn','Trejo',89652314,4500,'zona 7','director','1','malisTrejo','jossie',1)
insert into empleado values('Jossie','Castrillo',40125603,4500,'Villa Nueva','director','2','luser','marellyn',1)
insert into empleado values('Glen','Calel',78965412,4500,'Petapa','director','3','glencal','mate',1)

insert into sede values('Guatemala',5)

insert into sucursal values('La rapidita','zona 10',22883421,42,1)
insert into sucursal values('Punto 1','zona 12 Universidad de San Carlos',22887477,36,1)

insert into cliente values('Jose','Melgar',1478520321456,14523608,22321478,'9na Av. 1-56 zona 1',1,'josmel','1234',1,1478520321456)

insert into Categoria values('Accesorio de Telefonia',15)
insert into Categoria values('Accesorio Deportivo',10)
insert into Categoria values('Videojuegos',15)
update Cliente set Estado=1 where DPI=2492944860101
update Cliente set Estado=0 where DPI=2159685210101
update Cliente set Estado=0 where DPI=2492944860101
update Cliente set NoTarjeta=4789652012365874 where DPI=2589631470101
update Cliente set NoTarjeta=4102589630258963 where DPI=2685268110101
// and Tipo:'"+tipo+"'//
alter table cliente
ADD  NoTarjeta bigint  null
update Empleado set Habilitado=1
select * from paquete
select * from cliente
select * from paquete
select * from departamento
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
insert into estadoPrecio values('si tiene precio')
insert into estadoPrecio values('tiene imagen')
insert into estadoPrecio values('aprobado bodega')
insert into estadoPrecio values('aprobado director')

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

select P.IdPaquete,P.Estado,P.Precio,C.Nombre
from dbo.Paquete P join dbo.Categoria C
on P.IdCategoria = C.IdCategoria
Update  Paquete set Precio=129.405 where Nombre='Call of Duty: MWF'

select * from Paquete
insert into 