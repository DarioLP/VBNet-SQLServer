Create Database Asignacion8Soft8
go

use Asignacion8Soft8

Create Table Registro
(
Correo Nvarchar(50) Primary Key not null,
Usuario Nvarchar(50),
Nombre Nvarchar(50),
Contrase�a Nvarchar(50),
Telefono Nvarchar(9),
)


-----------------INSERCION DE REGISTROS-------------------------

Insert into Registro (Correo, Usuario, Nombre, Contrase�a, Telefono)
	values
	('usuario1@gmail.com', 'Maria','Maria Cade�o','weq2ew', '3984-4778')
	

	drop database Asignacion8Soft8
