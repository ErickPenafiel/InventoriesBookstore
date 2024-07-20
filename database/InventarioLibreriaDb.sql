USE [master]
GO

CREATE DATABASE [InventarioLibreria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventarioLibreria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\InventarioLibreria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventarioLibreria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\InventarioLibreria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [InventarioLibreria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventarioLibreria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventarioLibreria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventarioLibreria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventarioLibreria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventarioLibreria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventarioLibreria] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventarioLibreria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InventarioLibreria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventarioLibreria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventarioLibreria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventarioLibreria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventarioLibreria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventarioLibreria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventarioLibreria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventarioLibreria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventarioLibreria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InventarioLibreria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventarioLibreria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventarioLibreria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventarioLibreria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventarioLibreria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventarioLibreria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventarioLibreria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventarioLibreria] SET RECOVERY FULL 
GO
ALTER DATABASE [InventarioLibreria] SET  MULTI_USER 
GO
ALTER DATABASE [InventarioLibreria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventarioLibreria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventarioLibreria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventarioLibreria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventarioLibreria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InventarioLibreria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'InventarioLibreria', N'ON'
GO
ALTER DATABASE [InventarioLibreria] SET QUERY_STORE = ON
GO
ALTER DATABASE [InventarioLibreria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [InventarioLibreria]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEntrada](
	[IdDetalleEntrada] [int] IDENTITY(1,1) NOT NULL,
	[IdEntrada] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioUnitario] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[Consignacion] [decimal](10, 2) NULL,
	[Fecha] [datetime] NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleSalida](
	[IdDetalleSalida] [int] IDENTITY(1,1) NOT NULL,
	[IdSalida] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioSalida] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[Fecha] [datetime] NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Editoriales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Telefono] [varchar](20) NULL,
	[Direccion] [varchar](255) NULL,
	[Correo] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Total] [decimal](10, 2) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Apellidos] [varchar](255) NULL,
	[CI] [varchar](20) NULL,
	[Telefono] [varchar](20) NULL,
	[Titulo] [varchar](255) NULL,
	[Autor] [varchar](255) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](60) NULL,
	[Titulo] [varchar](255) NULL,
	[Autor] [varchar](255) NULL,
	[IdEditorial] [int] NULL,
	[Cantidad] [int] NULL,
	[Imagen] [image] NULL,
	[Precio] [decimal](10, 2) NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Total] [decimal](10, 2) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[Apellidos] [varchar](255) NULL,
	[Identificador] [varchar](50) NULL,
	[Contrasena] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleEntrada] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[DetalleSalida] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Entrada] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Salida] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[DetalleEntrada]  WITH CHECK ADD FOREIGN KEY([IdEntrada])
REFERENCES [dbo].[Entrada] ([Id])
GO
ALTER TABLE [dbo].[DetalleEntrada]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[DetalleSalida]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[DetalleSalida]  WITH CHECK ADD FOREIGN KEY([IdSalida])
REFERENCES [dbo].[Salida] ([Id])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([IdEditorial])
REFERENCES [dbo].[Editoriales] ([Id])
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD CHECK  (([Total]>=(0)))
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD CHECK  (([Cantidad]>=(0)))
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD CHECK  (([Precio]>=(0)))
GO
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD CHECK  (([Total]>=(0)))
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EliminarProducto](
	@IdProducto int,
	@Resultado bit output,
	@Mensaje varchar(500) output
)as
begin
	set @Resultado = 0
	set @Mensaje = ''
begin
	delete from Productos where Id = @IdProducto
	set @Resultado = 1
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ModificarEditorial](
	@IdEditorial int,
	@Nombre varchar(60),
	@Telefono varchar(60),
	@Direccion varchar(60),
	@Correo varchar(60),
	@Resultado int output,
	@Mensaje varchar(500) output
) as begin

set @Resultado = 1
if not exists (select * from Editoriales where Nombre = @Nombre and Id != @IdEditorial)
begin
	UPDATE Editoriales set Nombre = @Nombre, Telefono = @Telefono, Direccion = @Direccion, Correo = @Correo WHERE Id = @IdEditorial
	set @Mensaje = 'Registro Modificado Correctamente'
	set @Resultado = 1
end
else
begin
	set @Resultado = 0
	set @Mensaje = 'Ya existe una editorial con el mismo nombre'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ModificarPedido](
	@IdPedido int,
	@Nombre varchar(60),
	@Apellidos varchar(60),
	@CI varchar(60),
	@Telefono varchar(60),
	@Titulo varchar(60),
	@Autor varchar(60),
	@Resultado int output,
	@Mensaje varchar(500) output
) as begin

if exists (select * from Pedidos where Id = @IdPedido)
begin
	UPDATE Pedidos set Nombre = @Nombre, Apellidos = @Apellidos, CI = @CI, Telefono = @Telefono, Titulo = @Titulo, Autor = @Autor WHERE Id = @IdPedido
	set @Mensaje = 'Pedido Modificado Correctamente'
	set @Resultado = 1
end
else
begin
	set @Resultado = 0
	set @Mensaje = 'No existe un pedido con ese identificador'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ModificarProducto](
	@IdProducto int,
	@Codigo varchar(60),
	@Titulo varchar(60),
	@Autor varchar(60),
	@IdEditorial int,
	@Cantidad int,
	@Imagen Image,
	@Precio decimal(10,2),
	@Resultado int output,
	@Mensaje varchar(500) output
) as begin

set @Resultado = 1
if not exists (select * from Productos where Codigo = @Codigo and Id != @IdProducto)
begin
	UPDATE Productos SET Codigo = @Codigo, Titulo = @Titulo, Autor = @Autor, IdEditorial = @IdEditorial, Cantidad = @Cantidad, Imagen = @Imagen, Precio = @Precio WHERE Id = @IdProducto
	set @Mensaje = 'Registro Modificado Correctamente'
	set @Resultado = 1
end
else
begin
	set @Resultado = 0
	set @Mensaje = 'Ya existe un producto con el mismo Codigo'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ModificarTotal](
	@IdEntrada int,
	@Subtotal decimal(10,2),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
begin
	UPDATE Entrada set Total = Total - @Subtotal WHERE Id = @IdEntrada
	set @Mensaje = 'Modificado Correctamente'
end
end

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ModificarUsuario](
	@IdUsuario int,
	@Nombre varchar(60),
	@Apellidos varchar(60),
	@Identificador varchar(60),
	@Contrasena varchar(60),
	@Resultado int output,
	@Mensaje varchar(500) output
) as begin

set @Resultado = 1
if not exists (select * from Usuario where Identificador = @Identificador and Id != @IdUsuario)
begin
	UPDATE Usuario set Nombre = @Nombre, Apellidos = @Apellidos, Identificador = @Identificador, Contrasena = @Contrasena WHERE Id = @IdUsuario
	set @Mensaje = 'Usuario Modificado Correctamente'
	set @Resultado = 1
end
else
begin
	set @Resultado = 0
	set @Mensaje = 'Ya existe una usuario con el mismo identificador'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarDetalleEntrada](
	@IdEntrada int,
	@IdProducto int,
	@PrecioUnitario decimal(10,2),
	@Cantidad int,
	@MontoTotal decimal(10,2),
	@Consignacion decimal(10,2),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
begin
	INSERT INTO DetalleEntrada(IdEntrada, IdProducto, PrecioUnitario, Cantidad, MontoTotal, Consignacion) values (@IdEntrada, @IdProducto, @PrecioUnitario, @Cantidad, @MontoTotal, @Consignacion)
	UPDATE Productos SET Cantidad = Cantidad + @Cantidad WHERE Id = @IdProducto
	set @Mensaje = 'Entrada registrada correctamente'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarDetalleSalida](
	@IdSalida int,
	@IdProducto int,
	@PrecioUnitario decimal(10,2),
	@Cantidad int,
	@MontoTotal decimal(10,2),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
if ((select Cantidad from Productos where Id = @IdProducto) >= @Cantidad)
begin
	INSERT INTO DetalleSalida(IdSalida, IdProducto, PrecioSalida, Cantidad, MontoTotal) values (@IdSalida, @IdProducto, @PrecioUnitario, @Cantidad, @MontoTotal)
	UPDATE Productos SET Cantidad = Cantidad - @Cantidad WHERE Id = @IdProducto
	set @Mensaje = 'Entrada registrada correctamente'
end
else
begin
	set @Mensaje = 'No hay suficiente cantidad de productos en el inventario - ' + (select Titulo from Productos where Id = @IdProducto)
end
end

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarEditorial](
	@Nombre varchar(60),
	@Telefono varchar(60),
	@Direccion varchar(60),
	@Correo varchar(60),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
if not exists (select * from Editoriales where Nombre = @Nombre)
begin
	INSERT INTO Editoriales(Nombre, Telefono, Direccion, Correo) values (@Nombre, @Telefono, @Direccion, @Correo)
	set @Resultado = SCOPE_IDENTITY()
	set @Mensaje = 'Editorial registrada correctamente'
end
else
begin
	set @Mensaje = 'Ya existe una editorial con el mismo nombre'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarEntrada](
	@Total int,
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin
	INSERT INTO Entrada(Total) values (@Total)
	set @Resultado = (SELECT MAX(Id) FROM Entrada);
	set @Mensaje = 'Entrada registrada correctamente'
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarPedido](
	@Nombre varchar(60),
	@Apellidos varchar(60),
	@CI varchar(60),
	@Telefono varchar(60),
	@Titulo varchar(60),
	@Autor varchar(60),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
begin
	INSERT INTO Pedidos(Nombre, Apellidos, CI, Telefono, Titulo, Autor) values (@Nombre, @Apellidos, @CI, @Telefono, @Titulo, @Autor)
	set @Resultado = SCOPE_IDENTITY()
	set @Mensaje = 'Pedido registrado correctamente'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarProducto](
	@Codigo varchar(60),
	@Titulo varchar(60),
	@Autor varchar(60),
	@IdEditorial int,
	@Imagen Image,
	@Precio decimal(10,2),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
if not exists (select * from Productos where Codigo = @Codigo)
begin
	INSERT INTO Productos(Codigo,Titulo,Autor,IdEditorial,Cantidad,Imagen,Precio) values (@Codigo,@Titulo,@Autor,@IdEditorial,0,@Imagen,@Precio)
	set @Resultado = SCOPE_IDENTITY()
	set @Mensaje = 'Producto registrado correctamente'
end
else
begin
	set @Mensaje = 'Ya existe un producto con el mismo Codigo'
end
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarSalida](
	@Total int,
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin
	INSERT INTO Salida(Total) values (@Total)
	set @Resultado = (SELECT MAX(Id) FROM Salida);
	set @Mensaje = 'Salida registrada correctamente'
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RegistrarUsuario](
	@Nombre varchar(60),
	@Apellidos varchar(60),
	@Identificador varchar(60),
	@Contrasena varchar(60),
	@Resultado int output,
	@Mensaje varchar(500) output
)as begin

set @Resultado = 0
if not exists (select * from Usuario where Identificador = @Identificador)
begin
	INSERT INTO Usuario(Nombre, Apellidos, Identificador, Contrasena) values (@Nombre, @Apellidos, @Identificador, @Contrasena)
	set @Resultado = SCOPE_IDENTITY()
	set @Mensaje = 'Usuario registrado correctamente'
end
else
begin
	set @Mensaje = 'Ya existe una usuario con el mismo identificador'
end
end
GO
USE [master]
GO
ALTER DATABASE [InventarioLibreria] SET  READ_WRITE 
GO
