# Supermarket Storage System 

##  Funcionalidades Implementadas

###  Interfaz Web
-  **Login funcional** - Inicio de sesión con validación
-  **Logout funcional** - Cierre de sesión con confirmación
-  **Navegación entre pantallas** - Sistema de navegación completo
-  **CRUDS funcionales** - Sistema de cruds completo
-  **Alamacenamiento de datos** - Base de datos SQL Server

## Prerrequisitos
- SQL Server
- Visual Studio

##  Estructura del Proyecto

```
S.S.S/            
│   │   ├── controllers/       
│   │   ├── data/         
│   │   ├── models/           
│   │   ├── resources/      
│   │   └── views/         
│   └── Program.cs               

```
## Librerias instaladas 

- System.Data.SqlClient

- System

- System.Windows.Forms

- System.Security.Cryptography

- System.Text

- System.Collections.Generic

- System.ComponentModel

- System.Data

- System.Linq

- System.Drawing

- System.Threading.Tasks


  ## Nomenclatura utlizada

  PascalCase


## Base de datos


USE master; GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'SSS') BEGIN ALTER DATABASE SSS SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE SSS; END 

CREATE DATABASE SSS; 

USE SSS; 

CREATE TABLE Usuarios( 
id INT PRIMARY KEY IDENTITY(1,1),
username VARCHAR(50) NOT NULL UNIQUE, 
passwordUser VARCHAR(250) NOT NULL, 
email VARCHAR(50) NOT NULL, ); 
ALTER TABLE Usuarios ADD rol VARCHAR(20) NOT NULL 
DEFAULT 'usuario'; 
UPDATE Usuarios SET rol = 'admin' WHERE username = 'natraidor'; 

CREATE TABLE Categorias( id INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR(100) NOT NULL, 
descripcion VARCHAR (100) NOT NULL ); 

CREATE TABLE Productos( 
id INT PRIMARY KEY IDENTITY(1,1), 
nombre VARCHAR(50) NOT NULL, 
precio DECIMAL(10,2) NOT NULL, 
id_categoria INT,
FOREIGN KEY (id_categoria) REFERENCES Categorias(id) ); 
ALTER TABLE Productos ADD stock INT DEFAULT 0; 

CREATE TABLE Ventas(
id INT PRIMARY KEY IDENTITY(1,1),
cantidad INT NOT NULL, 
total DECIMAL(10,2) NOT NULL, 
id_productos INT, FOREIGN KEY
(id_productos) REFERENCES Productos(id)
); 
