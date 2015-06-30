Use Fase3V1
insert into Departamento values('Servicio al Cliente','Este módulo tiene un conjunto de herramientas orientadas al servicio al cliente')
insert into Departamento values('Paquete','Por medio de éste módulo los empleados hacen toda la gestión de paquetes')
insert into Departamento values('Bodega','Cada sucursal tiene una bodega, los empleados de bodega son los encargados de revisar si todos los paquetes dentro del lote salieron de aduana')
insert into Departamento values('General','Aplica para director y administrador')

insert into empleado values('Lesly','Barrera',7896541023654,42117848,3500,'San Jose Villa Nueva','empleado','1','LeslyBarrera','lbarrera37')
insert into empleado values('Alejandro','Lopez',7896540258741,57896314,3500,'San Jose Villa Nueva','empleado','2','alejoLop','alejo89')
insert into empleado values('Dora','Arreaga',147852036985,78541203,3500,'zona 1 colonia las flores','empleado','3','dora','da69')

insert into cliente values('Jose','Melgar',1478520321456,14523608,22321478,'9na Av. 1-56 zona 1',0,'josmel','1234',1)
truncate table cliente
update Cliente set NoTarjeta=4785693210258796 where DPI=1478520321456
update Cliente set NoTarjeta=5789632102478569 where DPI=2159685210101
update Cliente set NoTarjeta=4785693210258963 where DPI=2492944860101
update Cliente set NoTarjeta=4789652012365874 where DPI=2589631470101
update Cliente set NoTarjeta=4102589630258963 where DPI=2685268110101
alter table cliente
ADD  NoTarjeta bigint  null
select * from empleado
select * from cliente
select * from paquete
select * from detalle
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

