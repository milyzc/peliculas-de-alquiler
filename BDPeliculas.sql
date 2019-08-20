USE [pav1-db]
GO
ALTER TABLE [dbo].[Peliculas] DROP CONSTRAINT [FK_Peliculas_Generos]
GO
ALTER TABLE [dbo].[Peliculas] DROP CONSTRAINT [FK_Peliculas_Directores]
GO
/****** Object:  Table [dbo].[Peliculas]     Script Date: 8/15/2019 8:49:28 PM ******/
DROP TABLE [dbo].[Peliculas]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 8/15/2019 8:49:28 PM ******/
DROP TABLE [dbo].[Generos]
GO
/****** Object:  Table [dbo].[Directores]    Script Date: 8/15/2019 8:49:28 PM ******/
DROP TABLE [dbo].[Directores]
GO
/****** Object:  Table [dbo].[Directores]    Script Date: 8/15/2019 8:49:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Nacionalidad] [varchar](50) NULL,
 CONSTRAINT [PK_Directores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 8/15/2019 8:49:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 8/15/2019 8:49:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[Id] [int] NOT NULL,
	[Titulo] [varchar](50) NULL,
	[FechaLanzamiento] [date] NULL,
	[GeneroId] [int] NOT NULL,
	[DirectorId] [int] NOT NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Directores] ON 

INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (1, N'Zack Snyder', N'Estadounidense')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (2, N'Tim Miller', N'Estadounidense')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (3, N'James Wan', N'Estadounidense')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (4, N'Rajkumar Hirani', N'Indio')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (5, N'Ridley Scott', N'Inglés')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (6, N'Todd Phillips', N'Estadounidense')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (7, N'Sam Mendes', N'Inglés')
INSERT [dbo].[Directores] ([Id], [Nombre], [Nacionalidad]) VALUES (8, N'Christopher Nolan', N'Inglés')
SET IDENTITY_INSERT [dbo].[Directores] OFF
SET IDENTITY_INSERT [dbo].[Generos] ON 

INSERT [dbo].[Generos] ([Id], [Tipo]) VALUES (1, N'Acción')
INSERT [dbo].[Generos] ([Id], [Tipo]) VALUES (2, N'Comedia')
INSERT [dbo].[Generos] ([Id], [Tipo]) VALUES (3, N'Thriller')
INSERT [dbo].[Generos] ([Id], [Tipo]) VALUES (4, N'Drama')
INSERT [dbo].[Generos] ([Id], [Tipo]) VALUES (5, N'Crimen')
SET IDENTITY_INSERT [dbo].[Generos] OFF
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (1, N'Superman vs Batman', CAST(N'2016-03-25' AS Date), 1, 1)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (2, N'Deadpool', CAST(N'2016-02-12' AS Date), 2, 2)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (3, N'Rápidos y Furiosos 7', CAST(N'2015-04-03' AS Date), 3, 3)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (4, N'PK', CAST(N'2014-12-19' AS Date), 4, 4)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (5, N'Gladiador', CAST(N'2000-05-05' AS Date), 1, 5)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (6, N'Qué paso ayer?', CAST(N'2009-06-05' AS Date), 2, 6)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (7, N'3 Idiots', CAST(N'2009-12-25' AS Date), 4, 4)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (8, N'James Bond: Spectre', CAST(N'2015-11-06' AS Date), 3, 7)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (9, N'Batman inicia', CAST(N'2005-06-15' AS Date), 1, 8)
INSERT [dbo].[Peliculas] ([Id], [Titulo], [FechaLanzamiento], [GeneroId], [DirectorId]) VALUES (10, N'El caballero de la noche', CAST(N'2008-07-18' AS Date), 5, 8)
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK_Peliculas_Directores] FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Directores] ([Id])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [FK_Peliculas_Directores]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK_Peliculas_Generos] FOREIGN KEY([GeneroId])
REFERENCES [dbo].[Generos] ([Id])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [FK_Peliculas_Generos]
GO
