USE [master]
GO
/****** Object:  Database [GestionStock]    Script Date: 24/6/2024 19:15:57 ******/
CREATE DATABASE [GestionStock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionStock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GestionStock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionStock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GestionStock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GestionStock] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionStock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionStock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionStock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionStock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionStock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionStock] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionStock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionStock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionStock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionStock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionStock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionStock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionStock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionStock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionStock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionStock] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionStock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionStock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionStock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionStock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionStock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionStock] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionStock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionStock] SET RECOVERY FULL 
GO
ALTER DATABASE [GestionStock] SET  MULTI_USER 
GO
ALTER DATABASE [GestionStock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionStock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionStock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionStock] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionStock] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionStock] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GestionStock', N'ON'
GO
ALTER DATABASE [GestionStock] SET QUERY_STORE = ON
GO
ALTER DATABASE [GestionStock] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GestionStock]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CategoriaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[CompraId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CompraId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Habilitado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Hash] [nvarchar](255) NOT NULL,
	[Salt] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[VentaId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VentaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([CategoriaId], [Nombre]) VALUES (1, N'Mochilas')
INSERT [dbo].[Categoria] ([CategoriaId], [Nombre]) VALUES (2, N'Pepeleria')
INSERT [dbo].[Categoria] ([CategoriaId], [Nombre]) VALUES (3, N'Cuadernos')
INSERT [dbo].[Categoria] ([CategoriaId], [Nombre]) VALUES (4, N'Pizarras')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (1, CAST(N'2024-06-24T00:51:00.000' AS DateTime), 4, 10, 2)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (2, CAST(N'2024-06-24T00:52:00.000' AS DateTime), 1, 20, 2)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (3, CAST(N'2024-06-20T00:52:00.000' AS DateTime), 2, 20, 2)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (4, CAST(N'2024-06-23T01:29:00.000' AS DateTime), 5, 1, 1)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (5, CAST(N'2024-06-23T01:29:00.000' AS DateTime), 5, 1, 1)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (6, CAST(N'2024-06-24T01:30:00.000' AS DateTime), 5, 1, 1)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (7, CAST(N'2024-06-20T01:30:00.000' AS DateTime), 1, 1, 1)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (8, CAST(N'2024-06-24T10:20:00.000' AS DateTime), 6, 10, 1)
INSERT [dbo].[Compra] ([CompraId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (9, CAST(N'2024-06-24T16:57:00.000' AS DateTime), 13, 1, 4)
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (1, N'Mochila Frozen', 1, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (2, N'Cartulina', 2, CAST(300.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (3, N'Papel Creppe', 2, CAST(200.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (4, N'Cuaderno Ben10', 3, CAST(500.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (5, N'Cuaderno Frozen', 3, CAST(700.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (6, N'Pizarra 1x1m', 4, CAST(1000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (7, N'Mochila Ben1o', 1, CAST(1000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (8, N'Mochila Princes', 1, CAST(1200.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (9, N'Mochila StarWars', 1, CAST(1000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (10, N'Mochila Simpsons', 1, CAST(1000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (11, N'Mochila DragonBall', 1, CAST(1400.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (12, N'Resma Hojas A4', 2, CAST(4000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Producto] ([ProductoId], [Nombre], [CategoriaId], [Precio], [Habilitado]) VALUES (13, N'Cartulina Dorada', 2, CAST(550.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Hash], [Salt]) VALUES (1, N'admin', N'SMZkIoYpjhNGs86aKSIZNH+xyMvBQGydR07lzyxc1O0=', N'+OnpFWfyGVOLe0SCM2II+Q==')
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Hash], [Salt]) VALUES (2, N'gonzalo', N'ZOAO1567oDWR9D2jYK80eTUvSEzznGXJ2kfnG2X80zw=', N'dJFCR2NoWnvpoVf/nsDUnA==')
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Hash], [Salt]) VALUES (3, N'pedro', N'a32136fPCBAC40J1qzTAB7Sm3cq2ywXW03Czu8HHYUs=', N'YWadCJ8BGL7+QGcLDfXZ6Q==')
INSERT [dbo].[Usuario] ([UsuarioId], [Nombre], [Hash], [Salt]) VALUES (4, N'pedro2', N'KW8caT7DmMRmp6QNT/vCjXZybLOP7Wqz3/hMjQIRJMw=', N'G+u+X7IhSsm6xsqO7wGHBg==')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([VentaId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (1, CAST(N'2024-06-24T00:54:15.987' AS DateTime), 2, 5, 2)
INSERT [dbo].[Venta] ([VentaId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (2, CAST(N'2024-06-24T01:25:27.980' AS DateTime), 1, 10, 2)
INSERT [dbo].[Venta] ([VentaId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (3, CAST(N'2024-06-24T01:25:58.457' AS DateTime), 4, 2, 2)
INSERT [dbo].[Venta] ([VentaId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (4, CAST(N'2024-06-24T01:29:14.273' AS DateTime), 4, 8, 1)
INSERT [dbo].[Venta] ([VentaId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (5, CAST(N'2024-06-24T01:41:26.770' AS DateTime), 1, 1, 1)
INSERT [dbo].[Venta] ([VentaId], [Fecha], [ProductoId], [Cantidad], [UsuarioId]) VALUES (6, CAST(N'2024-06-24T01:42:45.143' AS DateTime), 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Producto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Producto] ([ProductoId])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Producto]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Usuario]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([CategoriaId])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Producto] ([ProductoId])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([UsuarioId])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[Listar_Compras]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Listar_Compras]
	@PageIndex INT, 
	@PageSize INT,
	@SearchText NVARCHAR(100) = NULL
AS 
BEGIN
	SET NOCOUNT ON;

	;WITH ComprasCTE AS
    (
        SELECT 
            c.CompraId, 
			c.Fecha,
            c.Cantidad, 
            c.ProductoId AS Producto, 
            c.UsuarioId Usuario,
            ROW_NUMBER() OVER (ORDER BY c.CompraId) AS RowNum
	FROM Compra as c
		INNER JOIN Producto as prod ON C.ProductoId = prod.ProductoId
		INNER JOIN Usuario as usu ON C.UsuarioId = usu.UsuarioId
	WHERE 
            prod.Nombre LIKE '%' + @SearchText + '%'
            OR usu.Nombre LIKE '%' + @SearchText + '%'
    )
	SELECT 
        CompraId, 
		Fecha,
        Cantidad, 
        Producto, 
        Usuario
    FROM 
        ComprasCTE
    WHERE 
        RowNum BETWEEN @PageIndex * @PageSize + 1 AND (@PageIndex + 1) * @PageSize;
END;
GO
/****** Object:  StoredProcedure [dbo].[Listar_Compras2]    Script Date: 24/6/2024 19:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[Listar_Compras2]
	@PageIndex INT, 
	@PageSize INT,
	@SearchText NVARCHAR(100) = NULL
AS 
BEGIN
	SET NOCOUNT ON;

        SELECT 
            c.CompraId, 
			c.Fecha,
            c.Cantidad, 
            c.ProductoId , 
            c.UsuarioId,
			prod.Nombre AS ProductoNombre,
			usu.Nombre AS UsuarioNombre
	FROM dbo.Compra as c
		INNER JOIN Producto as prod ON c.ProductoId = prod.ProductoId
		INNER JOIN Usuario as usu ON c.UsuarioId = usu.UsuarioId
	WHERE (
			@SearchText Is NULL OR @SearchText = '' 
            OR prod.Nombre LIKE '%' + @SearchText + '%'
            OR usu.Nombre LIKE '%' + @SearchText + '%'
			)
	ORDER BY 
        Fecha
    OFFSET @PageIndex * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
    
END;
GO
USE [master]
GO
ALTER DATABASE [GestionStock] SET  READ_WRITE 
GO
