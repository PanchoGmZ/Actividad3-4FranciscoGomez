CREATE TABLE CLIENTES (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
CORREO NVARCHAR (20) NULL,
TELEFONO NVARCHAR (50) NULL,
DIRECCION NVARCHAR (50) NOT NULL,
PRIMARY KEY (IDCLIENTE),
)

insert into CLIENTES values('Pedro' ,'Fernandez','pedro@gmail.com','5744158','B_Pedro Antonio Flores');
insert into CLIENTES values('Adri�n' ,'P�rez' ,'adrian@gmail.com' ,'1234567' ,'B_Pedro Antonio Flores');
insert into CLIENTES values('Bel�n','Gonz�lez' ,'belen@gmail.com' ,'87654321' ,'B_Pedro Antonio Flores');
insert into CLIENTES values('Ana' ,'Rodr�guez' ,'ana@gmail.com' ,'2345678' ,'B_Pedro Antonio Flores');
insert into CLIENTES values('Bruno' ,'L�pez' ,'bruno@gmail.com' ,'76543210' ,'B_Pedro Antonio Flores');
insert into CLIENTES values('Carla' ,'Garc�a' ,'carla@gmail.com' ,'3456789' ,'B_Pedro Antonio Flores');