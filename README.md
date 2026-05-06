BASE DE DATOS: 


USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'SSS')
BEGIN
    ALTER DATABASE SSS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE SSS;
END
GO

CREATE DATABASE SSS;
GO

USE SSS;
GO

CREATE TABLE Usuarios(
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(50) NOT NULL UNIQUE,
passwordUser VARCHAR(250) NOT NULL,
email VARCHAR(50) NOT NULL,
);
go
ALTER TABLE Usuarios ADD rol VARCHAR(20) NOT NULL DEFAULT 'usuario';
go
UPDATE Usuarios SET rol = 'admin' WHERE username = 'natraidor';
go
CREATE TABLE Categorias(
id INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR(100) NOT NULL, 
descripcion VARCHAR (100) NOT NULL
);
go
CREATE TABLE Productos(
id INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR(50) NOT NULL, 
precio DECIMAL(10,2) NOT NULL,
id_categoria INT,
 FOREIGN KEY (id_categoria) REFERENCES Categorias(id)
);
go
ALTER TABLE Productos ADD stock INT DEFAULT 0;
go

CREATE TABLE Ventas(
id INT PRIMARY KEY IDENTITY(1,1),
cantidad INT NOT NULL, 
total DECIMAL(10,2) NOT NULL,
id_productos INT,
 FOREIGN KEY (id_productos) REFERENCES Productos(id)

);
go




insert into Usuarios(username, passwordUser,email) VALUES ('natraidor', 'Tricks404', 'nata39520@gmail.com');
go
select * from Usuarios
go

insert into Categorias(nombre, descripcion) VALUES ('Carnes', 'Carne congelada 2lb');
go
select * from Categorias
go
insert into Productos(nombre, precio, id_categoria, stock) values ('pollo', 19, 1, 1000)
go
select * from Productos
go
insert into Ventas(cantidad,total,id_productos) VALUES (30, 500, 1);
go 
select * from Ventas


UPDATE Usuarios 
SET passwordUser = 'd17e81e9c377cba76d91b2ac49a8751c1bc7496fe878f0d182ad54b713e2cca7' 
WHERE username = 'natraidor';
