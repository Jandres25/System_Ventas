USE [master]
GO
/****** Object:  Database [Dbventas]    Script Date: 05/01/2023 16:21:11 ******/
CREATE DATABASE [Dbventas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dbventas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Dbventas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Dbventas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Dbventas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Dbventas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dbventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dbventas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dbventas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dbventas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dbventas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dbventas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dbventas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dbventas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dbventas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dbventas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dbventas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dbventas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dbventas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dbventas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dbventas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dbventas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Dbventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dbventas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dbventas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dbventas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dbventas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dbventas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dbventas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dbventas] SET RECOVERY FULL 
GO
ALTER DATABASE [Dbventas] SET  MULTI_USER 
GO
ALTER DATABASE [Dbventas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dbventas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dbventas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dbventas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Dbventas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Dbventas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dbventas', N'ON'
GO
ALTER DATABASE [Dbventas] SET QUERY_STORE = OFF
GO
USE [Dbventas]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[Idarticulo] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](256) NULL,
	[Imagen] [image] NULL,
	[Idcategoria] [int] NOT NULL,
	[Idpresentacion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Idarticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[Idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Idcliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](100) NULL,
	[Genero] [char](1) NULL,
	[fecha_nacimiento] [date] NULL,
	[tipo_documento] [varchar](20) NOT NULL,
	[Num_documento] [varchar](20) NOT NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](20) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_ingreso](
	[iddetalle_ingreso] [int] IDENTITY(1,1) NOT NULL,
	[Idingreso] [int] NOT NULL,
	[Idarticulo] [int] NOT NULL,
	[precio_compra] [money] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[stock_inicial] [int] NOT NULL,
	[stock_actual] [int] NOT NULL,
	[fecha_produccion] [date] NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
	[Estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[iddetalle_ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_venta](
	[Iddetalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[Idventa] [int] NOT NULL,
	[iddetalle_ingreso] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[Descuento] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Iddetalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingreso](
	[Idingreso] [int] IDENTITY(1,1) NOT NULL,
	[Idtrabajador] [int] NOT NULL,
	[Idproveedor] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[tipo_comprobante] [varchar](20) NOT NULL,
	[Serie] [varchar](10) NULL,
	[Correlativo] [varchar](10) NULL,
	[Igv] [decimal](4, 2) NOT NULL,
	[Estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presentacion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentacion](
	[Idpresentacion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idpresentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [varchar](150) NOT NULL,
	[sector_comercial] [varchar](50) NOT NULL,
	[tipo_documento] [varchar](20) NOT NULL,
	[numero_documento] [varchar](20) NOT NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[url] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[Idtrabajador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Genero] [char](1) NULL,
	[fecha_nac] [date] NOT NULL,
	[numero_documento] [varchar](20) NOT NULL,
	[Direccion] [varchar](150) NULL,
	[Telefono] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[Acceso] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Idtrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Idventa] [int] IDENTITY(1,1) NOT NULL,
	[Idcliente] [int] NOT NULL,
	[Idtrabajador] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[tipo_comprobante] [varchar](30) NOT NULL,
	[Serie] [varchar](10) NULL,
	[Correlativo] [varchar](10) NULL,
	[Igv] [decimal](4, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_articulo_categoria] FOREIGN KEY([Idcategoria])
REFERENCES [dbo].[Categoria] ([Idcategoria])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_articulo_categoria]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_articulo_presentacion] FOREIGN KEY([Idpresentacion])
REFERENCES [dbo].[Presentacion] ([Idpresentacion])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_articulo_presentacion]
GO
ALTER TABLE [dbo].[Detalle_ingreso]  WITH CHECK ADD  CONSTRAINT [FK_detalle_ingreso_articulo] FOREIGN KEY([Idarticulo])
REFERENCES [dbo].[Articulo] ([Idarticulo])
GO
ALTER TABLE [dbo].[Detalle_ingreso] CHECK CONSTRAINT [FK_detalle_ingreso_articulo]
GO
ALTER TABLE [dbo].[Detalle_ingreso]  WITH CHECK ADD  CONSTRAINT [FK_detalle_ingreso_ingreso] FOREIGN KEY([Idingreso])
REFERENCES [dbo].[Ingreso] ([Idingreso])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_ingreso] CHECK CONSTRAINT [FK_detalle_ingreso_ingreso]
GO
ALTER TABLE [dbo].[Detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_detalle_ingreso] FOREIGN KEY([iddetalle_ingreso])
REFERENCES [dbo].[Detalle_ingreso] ([iddetalle_ingreso])
GO
ALTER TABLE [dbo].[Detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_detalle_ingreso]
GO
ALTER TABLE [dbo].[Detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_venta] FOREIGN KEY([Idventa])
REFERENCES [dbo].[Venta] ([Idventa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_venta]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_ingreso_proveedor] FOREIGN KEY([Idproveedor])
REFERENCES [dbo].[Proveedor] ([Idproveedor])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_ingreso_proveedor]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_ingreso_trabajador] FOREIGN KEY([Idtrabajador])
REFERENCES [dbo].[Trabajador] ([Idtrabajador])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_ingreso_trabajador]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([Idcliente])
REFERENCES [dbo].[Cliente] ([Idcliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Trabajador] FOREIGN KEY([Idtrabajador])
REFERENCES [dbo].[Trabajador] ([Idtrabajador])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Trabajador]
GO
/****** Object:  StoredProcedure [dbo].[eliminar_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_ingreso]
@idingreso int
as
delete from Ingreso
where Idingreso = @idingreso
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_detalle_venta_articulo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscar_detalle_venta_articulo]
@textobuscar varchar(50)
as
select dv.iddetalle_venta,a.nombre as Articulo,dv.cantidad,dv.precio_venta,dv.descuento,
((dv.precio_venta*dv.cantidad)-dv.descuento) as Subtotal
from Detalle_venta dv 
inner join Detalle_ingreso di on dv.iddetalle_ingreso=di.iddetalle_ingreso
inner join Articulo a on di.idarticulo=a.Idarticulo
where a.nombre = @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spanular_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spanular_ingreso]
@idingreso int
As
update Ingreso set estado='ANULADO'
where idingreso=@idingreso
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_articulo_nombre]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_articulo_nombre]
@textobuscar varchar(50)
As
select a.idarticulo,a.codigo,a.nombre,a.descripcion,a.imagen,a.idcategoria,
c.nombre as Categoria,a.idpresentacion, p.nombre as Presentacion
from Articulo a inner join Categoria c on a.Idcategoria=c.idcategoria
inner join Presentacion p on a.idpresentacion=p.Idpresentacion
where a.Nombre like @textobuscar + '%'
order by a.Idarticulo desc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_categoria]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_categoria]
@textobuscar varchar(50)
As
select * from Categoria
where nombre like @textobuscar + '%' --buscara todas las ocurrencias hacia la derecha Ej Lac% = Lacteos
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cliente_apellidos]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_cliente_apellidos]
@textobuscar varchar(50)
As
select * from Cliente
where Apellidos like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cliente_num_documento]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_cliente_num_documento]
@textobuscar varchar(50)
As
select * from Cliente
where num_documento like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_detalle_venta_cliente]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_detalle_venta_cliente]
@textobuscar varchar(50)
as
select dv.iddetalle_ingreso,c.nombre as cliente,a.nombre as Articulo,dv.cantidad,dv.precio_venta,
dv.descuento,((dv.precio_venta*dv.cantidad)-dv.descuento) as Subtotal
from Detalle_venta dv
inner join Detalle_ingreso di on dv.iddetalle_ingreso = di.iddetalle_ingreso
inner join Articulo a on di.idarticulo = a.Idarticulo 
inner join venta v on dv.idventa = v.idventa
inner join cliente c on v.idcliente = c.idcliente
where c.nombre= @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_detalle_venta_id]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_detalle_venta_id]
@textobuscar int
as
select dv.iddetalle_ingreso,a.nombre as Articulo,dv.cantidad,dv.precio_venta,dv.descuento,
((dv.precio_venta*dv.cantidad)-dv.descuento) as Subtotal
from Detalle_venta dv 
inner join Detalle_ingreso di on dv.iddetalle_ingreso=di.iddetalle_ingreso
inner join Articulo a on di.idarticulo=a.Idarticulo
where dv.idventa=@textobuscar
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_ingreso_fecha]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_ingreso_fecha]
@textobuscar1 varchar(50),
@textobuscar2 varchar(50)
As
select i.idingreso,(t.apellidos + ' ' + t.nombre) as Trabajador,p.razon_social as Proveedor,i.fecha,
i.tipo_comprobante,i.serie,i.correlativo,i.estado,SUM(di.precio_compra*di.stock_inicial) as Total,i.igv as Impuesto
from Detalle_ingreso di inner join Ingreso i on di.idingreso=i.idingreso
inner join Proveedor p on i.idproveedor=p.Idproveedor
inner join Trabajador t on t.Idtrabajador= i.idtrabajador
group by i.idingreso,t.apellidos + ' ' + t.nombre,p.razon_social,i.fecha,i.tipo_comprobante,i.serie,
i.correlativo,i.estado,i.igv
having i.fecha >= @textobuscar1 and i.fecha <= @textobuscar2
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_nombre_presentacion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_nombre_presentacion]
@textobuscar varchar(50)
As
select * from Presentacion
where nombre like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_direccion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_direccion]
@textobuscar varchar(50)
as
select * from Proveedor
where Direccion like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_email]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_email]
@textobuscar varchar(50)
as
select * from Proveedor
where email like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_num_documento]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_num_documento]
@textobuscar varchar(50)
as
select * from Proveedor
where numero_documento like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_razon_social]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_razon_social]
@textobuscar varchar(50)
as
select * from Proveedor
where Razon_social like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_sector_comercial]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_sector_comercial]
@textobuscar varchar(50)
as
select * from Proveedor
where sector_comercial like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_telefono]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_telefono]
@textobuscar varchar(50)
as
select * from Proveedor
where Telefono like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_tipo_documento]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_tipo_documento]
@textobuscar varchar(50)
as
select * from Proveedor
where tipo_documento like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_proveedor_url]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spbuscar_proveedor_url]
@textobuscar varchar(50)
as
select * from Proveedor
where url like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_trabajador_apellidos]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_trabajador_apellidos]
@textobuscar varchar(50)
As
select * from Trabajador
where Apellidos like @textobuscar + '%'
order by Apellidos asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_trabajador_num_documento]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_trabajador_num_documento]
@textobuscar varchar(50)
As
select * from Trabajador
where Numero_documento like @textobuscar + '%'
order by Numero_documento asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_venta_fecha]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_venta_fecha]
@textobuscar1 varchar(50),
@textobuscar2 varchar(50)
As
select v.idventa,(t.apellidos + ' ' + t.nombre) as Trabajador,(c.apellidos + ' ' + c.nombre) as Cliente,
v.fecha,v.tipo_comprobante,v.serie,v.correlativo,SUM((dv.cantidad*dv.precio_venta)-dv.descuento) as Total,
v.igv as Impuesto
from Detalle_venta dv inner join venta v on dv.idventa=v.idventa
inner join Cliente c on v.idcliente=c.Idcliente
inner join Trabajador t on v.idtrabajador=t.Idtrabajador
group by v.idventa,t.apellidos + ' ' + t.nombre,c.apellidos + ' ' + c.nombre,
v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.igv
having v.fecha between @textobuscar1 and @textobuscar2
GO
/****** Object:  StoredProcedure [dbo].[spbuscararticulo_venta_codigo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscararticulo_venta_codigo]
@textobuscar varchar(50)
As
select di.iddetalle_ingreso,a.codigo,a.nombre,c.nombre as Categoria,p.nombre as Presentacion,
di.stock_actual,di.precio_compra,di.precio_venta,di.fecha_vencimiento
from Articulo a inner join Categoria c on a.Idcategoria=c.idcategoria
inner join Presentacion p on a.Idpresentacion=p.Idpresentacion
inner join Detalle_ingreso di on a.Idarticulo=di.idarticulo
inner join Ingreso i on di.idingreso=i.idingreso
where a.Codigo = @textobuscar and di.stock_actual > 0 and i.estado <> 'ANULADO'
GO
/****** Object:  StoredProcedure [dbo].[spbuscararticulo_venta_nombre]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscararticulo_venta_nombre]
@textobuscar varchar(50)
As
select di.iddetalle_ingreso,a.codigo,a.nombre,c.nombre as Categoria,p.nombre as Presentacion,
di.stock_actual,di.precio_compra,di.precio_venta,di.fecha_vencimiento
from Articulo a inner join Categoria c on a.Idcategoria=c.idcategoria
inner join Presentacion p on a.Idpresentacion=p.Idpresentacion
inner join Detalle_ingreso di on a.Idarticulo=di.idarticulo
inner join Ingreso i on di.idingreso=i.idingreso
where a.Nombre like @textobuscar + '%' and di.stock_actual > 0 and i.estado <> 'ANULADO'
GO
/****** Object:  StoredProcedure [dbo].[spdisminuir_stock]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spdisminuir_stock]
@iddetalle_ingreso int,
@cantidad int
As
update Detalle_ingreso set stock_actual = stock_actual - @cantidad
where iddetalle_ingreso=@iddetalle_ingreso
GO
/****** Object:  StoredProcedure [dbo].[speditar_articulo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_articulo]
@idarticulo int,
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(256),
@imagen image,
@idcategoria int,
@idpresentacion int
As
update Articulo set codigo=@codigo,nombre=@nombre,descripcion=@descripcion,imagen=@imagen,
idcategoria=@idcategoria,idpresentacion=@idpresentacion
where idarticulo=@idarticulo
GO
/****** Object:  StoredProcedure [dbo].[speditar_categoria]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_categoria]
@idcategoria int,
@nombre varchar(50),
@descripcion varchar(256)
As
update Categoria set nombre=@nombre,descripcion=@descripcion
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[speditar_cliente]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_cliente]
@idcliente int  ,
@nombre varchar (50),
@apellidos varchar (100),
@genero char (1),
@fecha_nacimiento date,
@tipo_documento varchar (20),
@num_documento varchar (20),
@direccion varchar (100),
@telefono varchar (20),
@email varchar (50)
as
update Cliente set
Nombre=@nombre ,
Apellidos=@apellidos,
Genero=@genero ,
fecha_nacimiento=@fecha_nacimiento ,
tipo_documento=@tipo_documento  ,
Num_documento=@num_documento  ,
Direccion=@direccion  ,
Telefono=@telefono ,
email=@email  
where Idcliente=@idcliente
GO
/****** Object:  StoredProcedure [dbo].[speditar_detalle_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_detalle_ingreso]
@iddetalle_ingreso int,
@Idingreso int,
@Idarticulo int,
@precio_compra money,
@precio_venta money,
@stock_inicial int,
@stock_actual int,
@fecha_produccion date,
@fecha_vencimiento date
as
update Detalle_ingreso set precio_compra=@precio_compra,precio_venta=@precio_venta,
                           stock_inicial=@stock_inicial,stock_actual=@stock_actual,fecha_produccion=@fecha_produccion,fecha_vencimiento=@fecha_vencimiento
where iddetalle_ingreso=@iddetalle_ingreso
GO
/****** Object:  StoredProcedure [dbo].[speditar_detalle_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speditar_detalle_venta] 
@iddetalle_venta int,
@idventa int,
@iddetalle_ingreso int,
@cantidad int,
@precio_venta money,
@descuento money
as
update detalle_venta set idventa=@idventa,iddetalle_ingreso=@iddetalle_ingreso,cantidad=@cantidad,
precio_venta=@precio_venta,descuento=@descuento
where iddetalle_venta=@iddetalle_venta
GO
/****** Object:  StoredProcedure [dbo].[speditar_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_ingreso]
@idingreso int,
@idtrabajador int,
@idproveedor int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(10),
@correlativo varchar(10),
@igv decimal(4,2),
@estado varchar(10)
as
update Ingreso set Idtrabajador=@idtrabajador,Idproveedor=@idproveedor,Fecha=@fecha,
tipo_comprobante=@tipo_comprobante,Serie=@serie,Correlativo=@correlativo,Igv=@igv,Estado=@estado
where Idingreso = @idingreso
GO
/****** Object:  StoredProcedure [dbo].[speditar_presentacion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_presentacion]
@idpresentacion int,
@nombre varchar(50),
@descripcion varchar(256)
As
update Presentacion set nombre=@nombre,descripcion=@descripcion
where idpresentacion=@idpresentacion 
GO
/****** Object:  StoredProcedure [dbo].[speditar_proveedor]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speditar_proveedor]
@idproveedor int,
@Razon_social varchar(150),
@Sector_comercial varchar(50),
@Tipo_documento varchar(20),
@Numero_documento varchar(20),
@Direccion varchar(100),
@Telefono varchar(20),
@Email varchar(50),
@Url varchar(100)
as
update Proveedor set Razon_social=@Razon_social, Sector_comercial=@Sector_comercial,Tipo_documento=@Tipo_documento
,Numero_documento=@Numero_documento,Direccion=@Direccion,Telefono=@Telefono,Email=@Email,Url=@Url
where Idproveedor=@idproveedor
GO
/****** Object:  StoredProcedure [dbo].[speditar_trabajador]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_trabajador]
@idtrabajador int,
@nombre varchar(50),
@apellidos varchar(50),
@genero char(1),
@fecha_nacimiento date,
@numero_documento varchar(20),
@direccion varchar(150),
@telefono varchar(20),
@email varchar(50),
@acceso varchar(50),
@usuario varchar(50),
@clave varchar(50)
As
update Trabajador set Nombre=@nombre, Apellidos=@apellidos, Genero=@genero, fecha_nac=@fecha_nacimiento, numero_documento=@numero_documento
where Idtrabajador = @idtrabajador
GO
/****** Object:  StoredProcedure [dbo].[speliminar_articulo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_articulo]
@idarticulo int
As
delete from Articulo
where Idarticulo=@idarticulo
GO
/****** Object:  StoredProcedure [dbo].[speliminar_categoria]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_categoria]
@idcategoria int
As
delete from Categoria
where idcategoria=@idcategoria
GO
/****** Object:  StoredProcedure [dbo].[speliminar_cliente]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_cliente]
@idcliente int 
as
delete from Cliente 
where Idcliente=@idcliente
GO
/****** Object:  StoredProcedure [dbo].[speliminar_detalle_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_detalle_ingreso]
@iddetalle_ingreso int
as
delete from Detalle_ingreso where iddetalle_ingreso= @iddetalle_ingreso
GO
/****** Object:  StoredProcedure [dbo].[speliminar_detalle_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_detalle_venta]
@iddetalle_venta int
as
delete from detalle_venta
where iddetalle_venta = @iddetalle_venta
GO
/****** Object:  StoredProcedure [dbo].[speliminar_presentacion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_presentacion]
@idpresentacion int
As
delete from Presentacion
where idpresentacion=@idpresentacion
GO
/****** Object:  StoredProcedure [dbo].[speliminar_proveedor]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[speliminar_proveedor]
@idproveedor int
as
delete from Proveedor
where Idproveedor=@idproveedor
GO
/****** Object:  StoredProcedure [dbo].[speliminar_trabajador]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_trabajador]
@idtrabajador int
as
delete from Trabajador
where Idtrabajador = @idtrabajador
GO
/****** Object:  StoredProcedure [dbo].[spinsert_proveedor]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spinsert_proveedor]
@idproveedor int output,
@Razon_social varchar(150),
@Sector_comercial varchar(50),
@Tipo_documento varchar(20),
@Numero_documento varchar(20),
@Direccion varchar(100),
@Telefono varchar(20),
@Email varchar(50),
@Url varchar(100)
as
insert into Proveedor
values(@Razon_social,@Sector_comercial,@Tipo_documento,@Numero_documento,@Direccion,@Telefono,@Email,@Url)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_articulo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_articulo]
@idarticulo int output,
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(256),
@imagen image,
@idcategoria int,
@idpresentacion int
As
insert into Articulo
values(@codigo,@nombre,@descripcion,@imagen,@idcategoria,@idpresentacion)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_categoria]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spinsertar_categoria]
@idcategoria int output,  --parametro retorna el valor de la clave id
@nombre varchar(50),
@descripcion varchar(256)
As
insert into Categoria(nombre,descripcion)
values(@nombre,@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_cliente]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_cliente]
@idcliente int output ,
@nombre varchar (50),
@apellidos varchar (100),
@genero char (1),
@fecha_nacimiento date,
@tipo_documento varchar (20),
@num_documento varchar (20),
@direccion varchar (100),
@telefono varchar (20),
@email varchar (50)
as
insert into Cliente
values (@nombre,@apellidos,@genero,@fecha_nacimiento,@tipo_documento,@num_documento,
@direccion,@telefono,@email)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_detalle_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_detalle_ingreso]
@iddetalle_ingreso int output,
@idingreso int,
@idarticulo int,
@precio_compra money,
@precio_venta money,
@stock_inicial int,
@stock_final int,
@fecha_produccion date,
@fecha_vencimiento date,
@estado varchar
As
insert into Detalle_ingreso
values(@idingreso,@idarticulo,@precio_compra,@precio_venta,@stock_inicial,@stock_final,
@fecha_produccion,@fecha_vencimiento,@estado)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_detalle_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_detalle_venta]
@iddetalle_venta int output,
@idventa int,
@iddetalle_ingreso int,
@cantidad int,
@precio_venta money,
@descuento money
As
insert into Detalle_venta
values(@idventa,@iddetalle_ingreso,@cantidad,@precio_venta,@descuento)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_ingreso]
@idingreso int=null output,
@idtrabajador int,
@idproveedor int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(10),
@correlativo varchar(10),
@igv decimal(4,2),
@estado varchar(10)
As
insert into Ingreso
values(@idtrabajador,@idproveedor,@fecha,@tipo_comprobante,@serie,@correlativo,@igv,@estado)
--Obtener el codigo idingreso autogenerado
set @idingreso=@@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_presentacion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spinsertar_presentacion]
@idpresentacion int output,  --parametro retorna el valor de la clave id
@nombre varchar(50),
@descripcion varchar(256)
As
insert into Presentacion(nombre,descripcion)
values(@nombre,@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_trabajador]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spinsertar_trabajador]
@idtrabajador int output,
@nombre varchar(50),
@apellidos varchar(50),
@genero char(1),
@fecha_nacimiento date,
@numero_documento varchar(20),
@direccion varchar(150),
@telefono varchar(20),
@email varchar(50),
@acceso varchar(50),
@usuario varchar(50),
@clave varchar(50)
As
insert into Trabajador(Nombre, Apellidos, Genero, fecha_nac, Numero_documento, Direccion, Telefono, Email, Acceso, Usuario, Clave)
values(@nombre, @apellidos, @genero, @fecha_nacimiento, @numero_documento, @direccion, @telefono, @email, @acceso, @usuario, @clave)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_venta]
@idventa int=null output,
@idcliente int,
@idtrabajador int,
@fecha date,
@tipo_comprobante varchar(30),
@serie varchar(10),
@correlativo varchar(10),
@igv decimal(4,2)
As
insert into Venta
values(@idcliente,@idtrabajador,@fecha,@tipo_comprobante,@serie,@correlativo,@igv)
--Obtenemos el codigo idventa autogenerado
set @idventa=@@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[splogin]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splogin]
@usuario varchar(50),
@clave varchar(50)
As
select idtrabajador,apellidos,nombre,acceso
from Trabajador
where Usuario=@usuario and Clave=@clave
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_articulo]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_articulo]
As
select a.idarticulo,a.codigo,a.nombre,a.descripcion,a.imagen,a.idcategoria,
c.nombre as Categoria,a.idpresentacion, p.nombre as Presentacion
from Articulo a inner join Categoria c on a.Idcategoria=c.idcategoria
inner join Presentacion p on a.idpresentacion=p.Idpresentacion
order by a.Idarticulo desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_categoria]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_categoria]
As
select * from Categoria
order by idcategoria desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_cliente]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_cliente]
As
select * from Cliente
order by Apellidos asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_detalle_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_detalle_ingreso]
@textobuscar int
As
select di.idarticulo,a.nombre as Articulo,di.precio_compra,di.precio_venta,di.stock_inicial,
di.fecha_produccion,di.fecha_vencimiento,(di.stock_inicial*di.precio_compra) as Subtotal
from Detalle_ingreso di inner join Articulo a on di.idarticulo=a.Idarticulo
where di.idingreso=@textobuscar
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_detalle_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_detalle_venta]
@textobuscar int
As
select dv.iddetalle_ingreso,a.nombre as Articulo,dv.cantidad,dv.precio_venta,dv.descuento,
((dv.precio_venta*dv.cantidad)-dv.descuento) as Subtotal
from Detalle_venta dv inner join Detalle_ingreso di on dv.iddetalle_ingreso=di.iddetalle_ingreso
inner join Articulo a on di.idarticulo=a.Idarticulo
where dv.idventa=@textobuscar
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_ingreso]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_ingreso]
As
select i.idingreso,(t.apellidos+' '+t.nombre) as Trabajador,p.razon_social as Proveedor,
i.fecha,i.tipo_comprobante,i.serie,i.correlativo,i.estado,
SUM(d.precio_compra*d.stock_inicial) as Total, i.igv as Impuesto
from Detalle_ingreso d inner join Ingreso i on d.idingreso=i.idingreso
inner join Proveedor p on i.idproveedor=p.Idproveedor
inner join Trabajador t on i.idtrabajador=t.Idtrabajador
group by i.idingreso,t.apellidos+' '+t.nombre,p.razon_social,i.fecha,
i.tipo_comprobante,i.serie,i.correlativo,i.estado,i.igv
order by i.idingreso desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_presentacion]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_presentacion]
As
select * from Presentacion
order by idpresentacion desc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_proveedor]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spmostrar_proveedor]
as
select * from Proveedor
order by Idproveedor asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_trabajador]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_trabajador]
As
select * from Trabajador
order by Apellidos asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_venta]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_venta]
As
select v.idventa,(t.apellidos + ' ' +t.nombre) as Trabajador,(c.apellidos + ' ' + c.nombre) as Cliente,
v.fecha,v.tipo_comprobante,v.serie,v.correlativo,
SUM((dv.cantidad*dv.precio_venta)-dv.descuento) as Total,v.igv as Impuesto
from Detalle_venta dv inner join Venta v on dv.idventa=v.idventa
inner join Cliente c on v.idcliente=c.Idcliente
inner join Trabajador t on v.idtrabajador=t.Idtrabajador
group by v.idventa,t.apellidos + ' ' +t.nombre,c.apellidos + ' ' + c.nombre,
v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.igv
order by v.idventa desc
GO
/****** Object:  StoredProcedure [dbo].[spreporte_factura]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spreporte_factura]
@idventa int
As
select v.idventa,(t.apellidos + ' ' + t.nombre) as Trabajador,(c.apellidos + ' ' + c.nombre) as Cliente,
c.direccion,c.telefono,c.num_documento,v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.igv,
a.nombre,dv.precio_venta,dv.cantidad,dv.descuento,(dv.cantidad*dv.precio_venta-dv.descuento) as Total_Parcial
from Detalle_venta dv inner join Detalle_ingreso di on dv.iddetalle_ingreso=di.iddetalle_ingreso
inner join Articulo a on a.Idarticulo=di.idarticulo
inner join Venta v on v.idventa=dv.idventa
inner join Cliente c on c.Idcliente=v.idcliente
inner join Trabajador t on v.Idtrabajador=t.Idtrabajador
where v.idventa=@idventa
GO
/****** Object:  StoredProcedure [dbo].[spstock_articulos]    Script Date: 05/01/2023 16:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spstock_articulos]
As
select a.codigo,a.nombre,c.nombre as Categoria,SUM(di.stock_inicial) as Cantidad_Ingreso,
SUM(di.stock_actual) as Cantidad_Stock,(SUM(di.stock_inicial)-SUM(di.stock_actual)) as Cantidad_Venta
from Articulo a inner join Categoria c on a.Idcategoria=c.idcategoria
inner join Detalle_ingreso di on a.Idarticulo=di.idarticulo
inner join Ingreso i on di.idingreso=i.idingreso
where i.estado <> 'ANULADO'
group by a.Codigo,a.Nombre,c.nombre
GO
USE [master]
GO
ALTER DATABASE [Dbventas] SET  READ_WRITE 
GO
