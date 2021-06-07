USE [master]
GO
/****** Object:  Database [biblioteca]    Script Date: 4/11/2019 06:43:31 ******/
CREATE DATABASE [biblioteca]
/*
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\biblioteca.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\biblioteca_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
*/
ALTER DATABASE [biblioteca] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [biblioteca] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [biblioteca] SET  ENABLE_BROKER 
GO
ALTER DATABASE [biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [biblioteca] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [biblioteca] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
USE [biblioteca]
GO
/****** Object:  Table [dbo].[j_laboral]    Script Date: 4/11/2019 06:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[j_laboral](
	[id_jornada] [char](5) NOT NULL,
	[id_personal] [char](5) NOT NULL,
	[hora_ENT] [char](5) NOT NULL,
	[HORA_SAL] [char](5) NOT NULL,
	[fecha] [varchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_jornada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lector]    Script Date: 4/11/2019 06:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lector](
	[id_lector] [char](5) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](25) NOT NULL,
	[sexo] [char](1) NOT NULL,
	[dni] [char](8) NOT NULL,
	[ocupacion] [varchar](20) NOT NULL,
	[fecha_NACIMIENTO] [char](10) NOT NULL,
	[fecha_inscripcion] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_lector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[libros]    Script Date: 4/11/2019 06:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[libros](
	[id_libro] [char](5) NOT NULL,
	[titulo] [varchar](50) NOT NULL,
	[genero] [varchar](15) NOT NULL,
	[autor] [varchar](35) NOT NULL,
	[nro_paginas] [int] NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[año_d_edicion] [char](4) NOT NULL,
	[editorial] [varchar](30) NOT NULL,
	[modo_adquisicion] [varchar](20) NOT NULL,
	[fecha_adquisicion] [varchar](11) NOT NULL,
	[disponible] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_libro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[mora_persona]    Script Date: 4/11/2019 06:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mora_persona](
	[id_mora] [char](5) NOT NULL,
	[id_libro] [char](5) NOT NULL,
	[id_lector] [char](5) NOT NULL,
	[fecha_d_prestamo] [char](10) NOT NULL,
	[fecha_d_devolucion] [char](10) NOT NULL,
	[tiempo_mora] [char](5) NOT NULL,
	[costo_mora] [float] NOT NULL,
	[fecha_mora] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personal]    Script Date: 4/11/2019 06:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personal](
	[id_personal] [char](5) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellidos] [varchar](30) NOT NULL,
	[dni] [char](8) NOT NULL,
	[sexo] [char](1) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[cargo] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[prestamo]    Script Date: 4/11/2019 06:43:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[prestamo](
	[id_prestamo] [char](5) NOT NULL,
	[id_lector] [char](5) NOT NULL,
	[id_personal] [char](5) NOT NULL,
	[fech_prestamo] [char](10) NOT NULL,
	[fech_devolucion] [char](10) NOT NULL,
	[id_libro] [char](5) NOT NULL,
	[estado_prestamo] [varchar](150) NOT NULL,
	[estado_devolucion] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_prestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[j_laboral] ([id_jornada], [id_personal], [hora_ENT], [HORA_SAL], [fecha]) VALUES (N'J0001', N'P0001', N'8.00 ', N'4.00 ', N'01/01/2019')
INSERT [dbo].[j_laboral] ([id_jornada], [id_personal], [hora_ENT], [HORA_SAL], [fecha]) VALUES (N'J0002', N'P0002', N'8.00 ', N'4.00 ', N'02/01/2019')
INSERT [dbo].[j_laboral] ([id_jornada], [id_personal], [hora_ENT], [HORA_SAL], [fecha]) VALUES (N'J0003', N'P0003', N'8.00 ', N'4.00 ', N'01/05/2019')
INSERT [dbo].[j_laboral] ([id_jornada], [id_personal], [hora_ENT], [HORA_SAL], [fecha]) VALUES (N'J0004', N'P0004', N'8.00 ', N'4.00 ', N'01/02/2019')
INSERT [dbo].[j_laboral] ([id_jornada], [id_personal], [hora_ENT], [HORA_SAL], [fecha]) VALUES (N'J0005', N'P0005', N'8.00 ', N'4.00 ', N'01/07/2019')
INSERT [dbo].[j_laboral] ([id_jornada], [id_personal], [hora_ENT], [HORA_SAL], [fecha]) VALUES (N'J0006', N'P0006', N'8.00 ', N'4.00 ', N'01/01/2019')
INSERT [dbo].[lector] ([id_lector], [nombre], [apellido], [sexo], [dni], [ocupacion], [fecha_NACIMIENTO], [fecha_inscripcion]) VALUES (N'LE001', N'David', N'muñoz fuentes', N'M', N'78654212', N'Estudiante', N'10/10/2000', N'10/08/2019')
INSERT [dbo].[lector] ([id_lector], [nombre], [apellido], [sexo], [dni], [ocupacion], [fecha_NACIMIENTO], [fecha_inscripcion]) VALUES (N'LE002', N'Ines', N' Camera Llosa', N'F', N'78965231', N'Estudiante', N'10/02/1999', N'10/09/2019')
INSERT [dbo].[lector] ([id_lector], [nombre], [apellido], [sexo], [dni], [ocupacion], [fecha_NACIMIENTO], [fecha_inscripcion]) VALUES (N'LE003', N'Virginia', N'Tapa Vega', N'F', N'78524136', N'Estudiante', N'02/02/1999', N'09/02/2019')
INSERT [dbo].[lector] ([id_lector], [nombre], [apellido], [sexo], [dni], [ocupacion], [fecha_NACIMIENTO], [fecha_inscripcion]) VALUES (N'LE004', N'Beto', N'Ortis Campos', N'M', N'74589632', N'Estudiante', N'01/05/1998', N'10/11/2019')
INSERT [dbo].[lector] ([id_lector], [nombre], [apellido], [sexo], [dni], [ocupacion], [fecha_NACIMIENTO], [fecha_inscripcion]) VALUES (N'LE005', N'Mauricio', N'Mania Vola', N'M', N'74589623', N'Estudiante', N'05/05/2000', N'10/10/2019')
INSERT [dbo].[lector] ([id_lector], [nombre], [apellido], [sexo], [dni], [ocupacion], [fecha_NACIMIENTO], [fecha_inscripcion]) VALUES (N'LE006', N'Denis', N'Carpa Monte', N'M', N'74589621', N'Estudiante', N'16/12/1999', N'10/12/2019')
INSERT [dbo].[libros] ([id_libro], [titulo], [genero], [autor], [nro_paginas], [estado], [año_d_edicion], [editorial], [modo_adquisicion], [fecha_adquisicion], [disponible]) VALUES (N'L0001', N'Juego de la vida', N'Finanzas', N'Robert Kiyosaki', 350, N'nuevo', N'2001', N'Aguilar', N'Donado', N'02/10/2019', N'Si')
INSERT [dbo].[libros] ([id_libro], [titulo], [genero], [autor], [nro_paginas], [estado], [año_d_edicion], [editorial], [modo_adquisicion], [fecha_adquisicion], [disponible]) VALUES (N'L0002', N'Cien años de soledad', N'Literatura', N'Gabriel Garcia Marques', 389, N'semi nuevo', N'1967', N'Santillana', N'Donado', N'05/11/2019', N'Si')
INSERT [dbo].[libros] ([id_libro], [titulo], [genero], [autor], [nro_paginas], [estado], [año_d_edicion], [editorial], [modo_adquisicion], [fecha_adquisicion], [disponible]) VALUES (N'L0003', N'La Odisea', N'Relato', N'Homero', 400, N'nuevo', N'VIII', N'Antonio Lopez', N'Donado', N'01/08/2019', N'Si')
INSERT [dbo].[libros] ([id_libro], [titulo], [genero], [autor], [nro_paginas], [estado], [año_d_edicion], [editorial], [modo_adquisicion], [fecha_adquisicion], [disponible]) VALUES (N'L0004', N'Lo que el Viento se lo llevo', N'Drama', N'Margaret Michel', 350, N'nuevo', N'1936', N'Santillana', N'Donado', N'05/09/2019', N'No')
INSERT [dbo].[libros] ([id_libro], [titulo], [genero], [autor], [nro_paginas], [estado], [año_d_edicion], [editorial], [modo_adquisicion], [fecha_adquisicion], [disponible]) VALUES (N'L0005', N'El proyecto Esposa', N'Narrativo', N'Graeme Simsion', 250, N'nuevo', N'1963', N'Santillana', N'Donado', N'02/05/2019', N'No')
INSERT [dbo].[libros] ([id_libro], [titulo], [genero], [autor], [nro_paginas], [estado], [año_d_edicion], [editorial], [modo_adquisicion], [fecha_adquisicion], [disponible]) VALUES (N'L0006', N'Hamlet', N'Narrativo', N'William Shakespeare', 500, N'nuevo', N'1599', N'Edicion B', N'Donado', N'02/05/2019', N'Si')
INSERT [dbo].[mora_persona] ([id_mora], [id_libro], [id_lector], [fecha_d_prestamo], [fecha_d_devolucion], [tiempo_mora], [costo_mora], [fecha_mora]) VALUES (N'M0001', N'L0001', N'LE001', N'01/10/2019', N'05/10/2019', N'24:00', 6, N'10/10/2019')
INSERT [dbo].[mora_persona] ([id_mora], [id_libro], [id_lector], [fecha_d_prestamo], [fecha_d_devolucion], [tiempo_mora], [costo_mora], [fecha_mora]) VALUES (N'M0002', N'L0002', N'LE004', N'14/05/2019', N'14/06/2019', N'2:00 ', 1, N'15/06/2019')
INSERT [dbo].[mora_persona] ([id_mora], [id_libro], [id_lector], [fecha_d_prestamo], [fecha_d_devolucion], [tiempo_mora], [costo_mora], [fecha_mora]) VALUES (N'M0003', N'L0004', N'LE005', N'23/09/2019', N'24/10/2019', N'12:00', 3, N'25/10/2019')
INSERT [dbo].[mora_persona] ([id_mora], [id_libro], [id_lector], [fecha_d_prestamo], [fecha_d_devolucion], [tiempo_mora], [costo_mora], [fecha_mora]) VALUES (N'M0004', N'L0006', N'LE006', N'30/10/2019', N'22/11/2019', N'24:00', 6, N'02/12/2019')
INSERT [dbo].[personal] ([id_personal], [nombre], [apellidos], [dni], [sexo], [direccion], [cargo]) VALUES (N'P0001', N'Edwin', N'Laura Vegazo', N'4689453 ', N'M', N'Socabaya N° 354', N'Inspector')
INSERT [dbo].[personal] ([id_personal], [nombre], [apellidos], [dni], [sexo], [direccion], [cargo]) VALUES (N'P0002', N'Efrain', N'vargas piña', N'74689453', N'M', N'Socabaya N° 354', N'Inspector')
INSERT [dbo].[personal] ([id_personal], [nombre], [apellidos], [dni], [sexo], [direccion], [cargo]) VALUES (N'P0003', N'David', N'Montes Lazo', N'74658934', N'M', N'Pasaje Umacollo 201', N'Tecnico responsable de coleccion')
INSERT [dbo].[personal] ([id_personal], [nombre], [apellidos], [dni], [sexo], [direccion], [cargo]) VALUES (N'P0004', N'Elfer', N'Ponce Martinez', N'74658931', N'M', N'Av. independencia 201', N'Tecnico de Biblioteca')
INSERT [dbo].[personal] ([id_personal], [nombre], [apellidos], [dni], [sexo], [direccion], [cargo]) VALUES (N'P0005', N'Sandra', N'Calani Diaz', N'74589632', N'F', N'Baden Pasj 201 ', N'Tecnico Auxiliar')
INSERT [dbo].[personal] ([id_personal], [nombre], [apellidos], [dni], [sexo], [direccion], [cargo]) VALUES (N'P0006', N'Elizabeth', N'Joestar Blanco', N'74589612', N'F', N'Pasj la union 101', N'Limpieza y orden')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR001', N'LE001', N'P0001', N'10/10/2019', N'15/10/2019', N'l0001', N'Nuevo', N'Arañado')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR002', N'LE002', N'P0002', N'10/11/2019', N'12/11/2019', N'l0002', N'Nuevo', N'Normal')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR003', N'LE003', N'P0001', N'11/09/2019', N'11/10/2019', N'l0004', N'Nuevo', N'Normal')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR004', N'LE004', N'P0003', N'14/05/2019', N'14/06/2019', N'l0001', N'Nuevo', N'Forro Roto')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR005', N'LE005', N'P0004', N'23/09/2019', N'24/10/2019', N'l0006', N'Nuevo', N'Normal')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR006', N'LE006', N'P0001', N'30/10/2019', N'31/11/2019', N'l0003', N'Nuevo', N'Normal')
INSERT [dbo].[prestamo] ([id_prestamo], [id_lector], [id_personal], [fech_prestamo], [fech_devolucion], [id_libro], [estado_prestamo], [estado_devolucion]) VALUES (N'PR007', N'LE004', N'P0005', N'10/10/2019', N'15/10/2019', N'L0001', N'asd', N'asd')
ALTER TABLE [dbo].[j_laboral]  WITH CHECK ADD FOREIGN KEY([id_personal])
REFERENCES [dbo].[personal] ([id_personal])
GO
ALTER TABLE [dbo].[mora_persona]  WITH CHECK ADD FOREIGN KEY([id_lector])
REFERENCES [dbo].[lector] ([id_lector])
GO
ALTER TABLE [dbo].[mora_persona]  WITH CHECK ADD FOREIGN KEY([id_libro])
REFERENCES [dbo].[libros] ([id_libro])
GO
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD FOREIGN KEY([id_lector])
REFERENCES [dbo].[lector] ([id_lector])
GO
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD FOREIGN KEY([id_libro])
REFERENCES [dbo].[libros] ([id_libro])
GO
ALTER TABLE [dbo].[prestamo]  WITH CHECK ADD FOREIGN KEY([id_personal])
REFERENCES [dbo].[personal] ([id_personal])
GO
USE [master]
GO
ALTER DATABASE [biblioteca] SET  READ_WRITE 
GO
/*
USE VENTAS
GO
IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
WHERE TABLE_NAME='REPORTE')
DROP VIEW REPORTE
GO
CREATE VIEW REPORTE AS
SELECT CLIENTES.CODCLI,NOMBRES,APELLIDOS,FACTURA.NUMFAC,FECHA,DESCRIPCION,UNIMED,CANTI,PRECIO,PRECIO*CANTI AS TOTAL FROM CLIENTES 
INNER JOIN FACTURA ON CLIENTES.CODCLI=FACTURA.CODCLI
INNER JOIN DETALLE ON FACTURA.NUMFAC=DETALLE.NUMFAC
INNER JOIN PRODUCTOS ON DETALLE.CODPRO=PRODUCTOS.CODPRO
WITH CHECK OPTION
GO
*/
use biblioteca
go
IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
WHERE TABLE_NAME='personalactivo')
DROP VIEW personalactivo
GO
create view personalactivo as
SELECT personal.id_personal , personal.nombre as 'nombre' , personal.apellidos as 'Apellidos' ,personal.dni as'DNI', personal.sexo as 'Sexo', personal.direccion as 'Direccion', personal.cargo as'Cargo', j_laboral.id_jornada, j_laboral.hora_ent as'H_Ent', j_laboral.hora_sal as'H_Sal', j_laboral.fecha as 'Fecha' 
      from personal inner join j_laboral on personal.id_personal=j_laboral.id_personal
	  with check option
 go

 select * from personalactivo
 go

 use biblioteca
go
IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
WHERE TABLE_NAME='libroad') /*libroad = libro adquerdido*/
DROP VIEW libroad
GO
create view libroad as
 SELECT id_libro,titulo,genero,autor,nro_paginas,estado,año_d_edicion as 'Año de edicion',editorial,modo_adquisicion,fecha_adquisicion,disponible from libros where modo_adquisicion='Donado'
 with check option
 go

 select * from libroad
 select * from prestamo
 go

 use biblioteca
 go
 select count(*)as 'CANTIDAD D PRESTAMO' from prestamo 
 go
 select * from prestamo
  select * from libros
SELECT prestamo.id_prestamo, libros.id_libro,libros.titulo  from prestamo inner join libros on prestamo.id_libro=libros.id_libro 
go

use biblioteca
go
IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
WHERE TABLE_NAME='boleta') 
DROP VIEW boleta
GO
create view boleta as
 SELECT lector.dni , libros.titulo , prestamo.fech_prestamo, prestamo.fech_devolucion, personal.nombre,personal.apellidos from 
 prestamo inner join lector on lector.id_lector=prestamo.id_lector inner join libros on libros.id_libro=prestamo.id_libro
 inner join personal on personal.id_personal=prestamo.id_personal 
 with check option
 go


 select * from boleta
 go

 /* PRACTICIA GAA
 select lector.dni ,libros.titulo from prestamo inner join lector on
 lector.id_lector=prestamo.id_lector inner join libros on libros.id_libro=prestamo.id_libro */