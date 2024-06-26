USE [Techbuild]
GO
/****** Object:  Table [dbo].[Carrito]    Script Date: 25/3/2024 11:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito](
	[IdCarrito] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Carrito] PRIMARY KEY CLUSTERED 
(
	[IdCarrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 25/3/2024 11:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[Motherboard] [int] NULL,
	[CPU] [int] NULL,
	[RAM] [int] NULL,
	[GPU] [int] NULL,
	[Almacenamiento] [int] NULL,
	[Cooler] [int] NULL,
	[Fuente] [int] NULL,
	[Gabinete] [int] NULL,
	[IdUsuario] [int] NOT NULL,
	[Total] [real] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 25/3/2024 11:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[img] [varchar](500) NOT NULL,
	[Precio] [real] NOT NULL,
	[Consumo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/3/2024 11:32:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[FotoDePerfil] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (1, N'https://http2.mlstatic.com/D_NQ_NP_659520-MLM51338788281_082022-O.webp', 177378, 65, N'AMD Radeon 5 4600G', N'8 MB 6 Nucleos 12 Hilos', N'CPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (2, N'https://http2.mlstatic.com/D_NQ_NP_960613-MLU72593800573_102023-O.webp', 669999, 125, N'Intel Core I9 12900KF', N'16 Nucleos y 5.2 Ghz de frecuencia', N'CPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (3, N'https://http2.mlstatic.com/D_NQ_NP_623058-MLA69870650494_062023-O.webp', 359999, 65, N'Intel Core I5 13400', N'10 Nucleos y 4.6 GHz de frecuencia, incluye grafica', N'CPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (4, N'https://http2.mlstatic.com/D_NQ_NP_709815-MLA53109755837_122022-O.webp', 107728, 65, N'AMD Radeon 3 4100', N'4 Nucleos y 4GHz de frecuencia', N'CPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (5, N'https://http2.mlstatic.com/D_NQ_NP_612966-MLA42885628349_072020-O.webp', 179999, 65, N'Intel Core i5 10400', N'6 Nucleos y 4.3Ghz de frecuencia, Con graficas integradas', N'CPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (6, N'https://http2.mlstatic.com/D_NQ_NP_727035-MLU69204666376_052023-O.webp', 89699, 100, N'Biostar H310m', N'Tipo Intel Lga 1151 de 9na  generacion y con Ddr4 y Hdmi', N'Motherboard')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (7, N'https://http2.mlstatic.com/D_NQ_NP_790913-MLM46547491768_062021-O.webp', 155998, 120, N'GIGABYTE B450m', N'Tipo AMD AM4 DDR4', N'Motherboard')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (8, N'https://http2.mlstatic.com/D_NQ_NP_865300-MLU70743000283_072023-O.webp', 88000, 100, N'Asus Prime H510m', N'Tipo Intel LGA 1200 DDR4', N'Motherboard')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (9, N'https://http2.mlstatic.com/D_NQ_NP_969607-MLU52296049875_112022-O.webp', 201469, 140, N'GIGABYTE H610m', N'Tipo Intel LGA 1700 DDR4', N'Motherboard')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (10, N'https://http2.mlstatic.com/D_NQ_NP_944738-MLA48851348389_012022-O.webp', 72579, 100, N'Asrock B360m', N'Tipo Intel LGA 1151 DDR4', N'Motherboard')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (11, N'https://http2.mlstatic.com/D_NQ_NP_667453-MLA50418240420_062022-O.webp', 56728, 25, N'Fury Beast ', N'DDR4 16 GB 3200 MHz', N'RAM')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (12, N'https://http2.mlstatic.com/D_NQ_NP_631376-MLA45255956114_032021-O.webp', 18004, 10, N'Hikvison', N'DDR4 8 GB 2666 MHz', N'RAM')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (13, N'https://http2.mlstatic.com/D_NQ_NP_616488-MLA54486294241_032023-O.webp', 60770, 25, N'XPG Spectrix', N'DDR4 16 GB 3600 MHz', N'RAM')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (14, N'https://http2.mlstatic.com/D_NQ_NP_917035-MLA70940119285_082023-O.webp', 60191, 20, N'Geil Orion', N'DDR4 16GB (2x8GB) 3600 MHz', N'RAM')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (15, N'https://http2.mlstatic.com/D_NQ_NP_922042-MLU69877099419_062023-O.webp', 56589, 25, N'Mushkim Redline', N'DDR4 16GB 3600 MHz', N'RAM')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (16, N'https://http2.mlstatic.com/D_NQ_NP_698119-MLA45919517808_052021-O.webp', 544170, 600, N'NVIDIA Zotac Gaming GeForce RTX 3060', N'12GB', N'GPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (17, N'https://http2.mlstatic.com/D_NQ_NP_833705-MLA71539840382_092023-O.webp', 749990, 500, N'AMD Radeon RX 6600 Xt', N'8GB', N'GPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (18, N'https://http2.mlstatic.com/D_NQ_NP_651453-MLA42136307725_062020-O.webp', 145199, 300, N'NVIDIA MSI GeForce GT 1030', N'2GB', N'GPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (19, N'https://http2.mlstatic.com/D_NQ_NP_895888-MLA48789741452_012022-O.webp', 650000, 1000, N'AMD Asrock RX 6900 Xt', N'16GB', N'GPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (20, N'https://http2.mlstatic.com/D_NQ_NP_613953-MLA70847054745_082023-O.webp', 2353896, 500, N'NVIDIA GIGABYTE RTX 4060 TI', N'8GB', N'GPU')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (21, N'https://http2.mlstatic.com/D_NQ_NP_702412-MLA46221874856_052021-O.webp', 495220, 7, N'Seagate HDD Skyhawk 8TB', N'122 MB De escritura', N'Almacenamiento')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (22, N'https://http2.mlstatic.com/D_NQ_NP_825890-MLA54124091906_032023-O.webp', 25750, 1, N'Kingston SSD 240 GB', N'318 MB De escritura', N'Almacenamiento')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (23, N'https://http2.mlstatic.com/D_NQ_NP_833729-MLA71520897901_092023-O.webp', 56933, 2, N'Kingston SSD 960 GB', N'403 MB De escritura', N'Almacenamiento')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (24, N'https://http2.mlstatic.com/D_NQ_NP_830625-MLA52062909392_102022-O.webp', 78624, 4, N'Kingston M.2 1TB', N'1037 MB De lectura', N'Almacenamiento')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (25, N'https://http2.mlstatic.com/D_NQ_NP_662756-MLA44281136599_122020-O.webp', 165699, 5, N'Seagate IronWolf HDD 6TB', N'119 MB de escritura', N'Almacenamiento')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (26, N'https://http2.mlstatic.com/D_NQ_NP_952794-MLA70325493015_072023-O.webp', 399999, 10, N'Evga 400', N'RGB Refrigeracion liquida', N'Cooler')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (27, N'https://http2.mlstatic.com/D_NQ_NP_808499-MLA72664616842_112023-O.webp', 380000, 10, N'ROG Strix', N'RGB Refrigeracion liquida', N'Cooler')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (28, N'https://http2.mlstatic.com/D_NQ_NP_978977-MLA54036279806_022023-O.webp', 40716, 7, N'Id-cooling', N'RGB Disipador', N'Cooler')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (29, N'https://http2.mlstatic.com/D_NQ_NP_716347-MLA49824603047_052022-O.webp', 102650, 7, N'Deepcol As500', N'Disipador', N'Cooler')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (30, N'https://http2.mlstatic.com/D_NQ_NP_916192-MLA44582520583_012021-O.webp', 50695, 7, N'Hyper H410r', N'RGB Disipador', N'Cooler')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (31, N'https://http2.mlstatic.com/D_NQ_NP_871496-MLA45687292161_042021-O.webp', 80999, 0, N'Sentey High Beat Power', N'700W', N'Fuente')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (32, N'https://http2.mlstatic.com/D_NQ_NP_909129-MLU72847777035_112023-O.webp', 74000, 0, N'Sentey Snp650-gs', N'650W', N'Fuente')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (33, N'https://http2.mlstatic.com/D_NQ_NP_930786-MLU70488049500_072023-O.webp', 76238, 0, N'Xfx Namakaze', N'750W', N'Fuente')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (34, N'https://http2.mlstatic.com/D_NQ_NP_681867-MLA52248682583_112022-O.webp', 97488, 0, N'Full Modular Xfx', N'1600W', N'Fuente')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (35, N'https://http2.mlstatic.com/D_NQ_NP_982015-MLA51838855582_102022-O.webp', 120999, 0, N'Redragon Gc Series', N'800W', N'Fuente')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (36, N'https://http2.mlstatic.com/D_NQ_NP_759447-MLU54959619263_042023-O.webp', 69480, 0, N'Solarmax', N'Mid tower con 6 coolers RGB', N'Gabinete')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (37, N'https://http2.mlstatic.com/D_NQ_NP_952777-MLU72635661919_112023-O.webp', 57785, 0, N'Xigmatek Infinity', N'Mid Tower', N'Gabinete')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (38, N'https://http2.mlstatic.com/D_NQ_NP_688022-MLU72756428052_112023-O.webp', 73599, 0, N'Andromeda Atx', N'Mid Tower Con 6 Coolers RGB', N'Gabinete')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (39, N'https://http2.mlstatic.com/D_NQ_NP_618319-MLU72636792203_112023-O.webp', 98998, 0, N'MSI MPG Gungnir', N'Full Tower', N'Gabinete')
INSERT [dbo].[Producto] ([IdProducto], [img], [Precio], [Consumo], [Nombre], [Descripcion], [Categoria]) VALUES (40, N'https://http2.mlstatic.com/D_NQ_NP_850900-MLA43939869555_102020-O.webp', 136023, 0, N'Corsair 4000D Airflow', N'Mid Tower con 6 coolers RGB', N'Gabinete')
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
ALTER TABLE [dbo].[Carrito]  WITH CHECK ADD  CONSTRAINT [FK_Carrito_Producto] FOREIGN KEY([IdCarrito])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Carrito] CHECK CONSTRAINT [FK_Carrito_Producto]
GO
ALTER TABLE [dbo].[Carrito]  WITH CHECK ADD  CONSTRAINT [FK_Carrito_Usuario] FOREIGN KEY([IdCarrito])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Carrito] CHECK CONSTRAINT [FK_Carrito_Usuario]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Usuario]
GO
