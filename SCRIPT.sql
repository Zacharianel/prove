USE [PASTICCERIA]
GO
/****** Object:  Table [dbo].[DOLCI]    Script Date: 08/02/2022 08:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOLCI](
	[cod_d] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[costo] [float] NOT NULL,
 CONSTRAINT [PK_DOLCI] PRIMARY KEY CLUSTERED 
(
	[cod_d] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INGREDIENTI]    Script Date: 08/02/2022 08:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INGREDIENTI](
	[cod_i] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[um] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_INGREDIENTI] PRIMARY KEY CLUSTERED 
(
	[cod_i] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RICETTE]    Script Date: 08/02/2022 08:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RICETTE](
	[cod_r] [int] IDENTITY(1,1) NOT NULL,
	[qta_ingredienti] [int] NOT NULL,
	[cod_d] [int] NOT NULL,
	[cod_i] [int] NOT NULL,
 CONSTRAINT [PK_RICETTE] PRIMARY KEY CLUSTERED 
(
	[cod_r] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 08/02/2022 08:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[cod_u] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[cod_u] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VETRINA]    Script Date: 08/02/2022 08:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VETRINA](
	[cod_v] [int] IDENTITY(1,1) NOT NULL,
	[cod_d] [int] NOT NULL,
	[data] [date] NOT NULL,
 CONSTRAINT [PK_VETRINA] PRIMARY KEY CLUSTERED 
(
	[cod_v] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DOLCI] ON 

INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (1, N'Cheesecake alle fragole', 20.5)
INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (2, N'Cheesecake ai mirtilli', 20.5)
INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (3, N'Cheesecake alla cioccolata', 19)
INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (4, N'Crostata di albicocche', 17.5)
INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (5, N'Crostata di fragole', 18)
INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (6, N'Crostata alla cioccolata', 19.5)
INSERT [dbo].[DOLCI] ([cod_d], [nome], [costo]) VALUES (7, N'Crostata alle mandorle', 19.5)
SET IDENTITY_INSERT [dbo].[DOLCI] OFF
GO
SET IDENTITY_INSERT [dbo].[INGREDIENTI] ON 

INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (1, N'biscotti', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (2, N'burro', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (3, N'formaggio', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (4, N'zucchero', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (5, N'latte', N'ml')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (6, N'acqua', N'ml')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (7, N'limone', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (8, N'lamponi', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (9, N'mirtilli', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (10, N'cioccolata', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (11, N'mandorle', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (12, N'farina', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (13, N'uova', N'unità')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (14, N'albicocche', N'g')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (15, N'panna', N'ml')
INSERT [dbo].[INGREDIENTI] ([cod_i], [nome], [um]) VALUES (16, N'fragole', N'g')
SET IDENTITY_INSERT [dbo].[INGREDIENTI] OFF
GO
SET IDENTITY_INSERT [dbo].[RICETTE] ON 

INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (1, 250, 1, 1)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (2, 125, 1, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (4, 750, 1, 3)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (5, 170, 1, 15)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (6, 80, 1, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (7, 10, 1, 7)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (10, 250, 1, 8)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (11, 250, 2, 1)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (12, 125, 2, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (13, 750, 2, 3)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (14, 170, 2, 15)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (15, 80, 2, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (16, 10, 2, 7)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (17, 250, 2, 9)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (18, 250, 3, 1)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (19, 125, 3, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (20, 750, 3, 3)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (21, 170, 3, 15)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (22, 80, 3, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (23, 10, 3, 7)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (24, 250, 3, 10)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (25, 245, 4, 12)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (26, 245, 4, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (27, 50, 4, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (28, 2, 4, 13)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (29, 400, 4, 5)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (30, 50, 4, 11)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (32, 160, 4, 14)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (33, 245, 5, 12)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (34, 245, 5, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (35, 50, 5, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (36, 2, 5, 13)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (37, 400, 5, 5)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (38, 50, 5, 11)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (39, 160, 5, 16)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (40, 245, 6, 12)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (41, 245, 6, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (42, 50, 6, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (43, 2, 6, 13)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (44, 400, 6, 5)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (45, 50, 6, 11)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (46, 160, 6, 10)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (47, 245, 7, 12)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (48, 245, 7, 2)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (49, 50, 7, 4)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (50, 2, 7, 13)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (51, 400, 7, 5)
INSERT [dbo].[RICETTE] ([cod_r], [qta_ingredienti], [cod_d], [cod_i]) VALUES (52, 200, 7, 11)
SET IDENTITY_INSERT [dbo].[RICETTE] OFF
GO
SET IDENTITY_INSERT [dbo].[USER] ON 

INSERT [dbo].[USER] ([cod_u], [nome], [password]) VALUES (1, N'l', N'l')
INSERT [dbo].[USER] ([cod_u], [nome], [password]) VALUES (2, N'm', N'm')
SET IDENTITY_INSERT [dbo].[USER] OFF
GO
SET IDENTITY_INSERT [dbo].[VETRINA] ON 

INSERT [dbo].[VETRINA] ([cod_v], [cod_d], [data]) VALUES (1, 1, CAST(N'2022-02-04' AS Date))
INSERT [dbo].[VETRINA] ([cod_v], [cod_d], [data]) VALUES (3, 4, CAST(N'2022-02-07' AS Date))
SET IDENTITY_INSERT [dbo].[VETRINA] OFF
GO
ALTER TABLE [dbo].[RICETTE]  WITH CHECK ADD  CONSTRAINT [FK_RICETTE_DOLCI] FOREIGN KEY([cod_d])
REFERENCES [dbo].[DOLCI] ([cod_d])
GO
ALTER TABLE [dbo].[RICETTE] CHECK CONSTRAINT [FK_RICETTE_DOLCI]
GO
ALTER TABLE [dbo].[RICETTE]  WITH CHECK ADD  CONSTRAINT [FK_RICETTE_INGREDIENTI] FOREIGN KEY([cod_i])
REFERENCES [dbo].[INGREDIENTI] ([cod_i])
GO
ALTER TABLE [dbo].[RICETTE] CHECK CONSTRAINT [FK_RICETTE_INGREDIENTI]
GO
ALTER TABLE [dbo].[VETRINA]  WITH CHECK ADD  CONSTRAINT [FK_VETRINA_DOLCI] FOREIGN KEY([cod_d])
REFERENCES [dbo].[DOLCI] ([cod_d])
GO
ALTER TABLE [dbo].[VETRINA] CHECK CONSTRAINT [FK_VETRINA_DOLCI]
GO
