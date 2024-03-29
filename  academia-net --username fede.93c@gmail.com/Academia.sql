USE [Academia]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 27/10/2014 14:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Materia](
	[Id_mat] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[Id_mat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 27/10/2014 14:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modulo](
	[Id_mod] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Modulo] PRIMARY KEY CLUSTERED 
(
	[Id_mod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 27/10/2014 14:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[Legajo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Tipo] [int] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personas_Materias]    Script Date: 27/10/2014 14:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas_Materias](
	[Legajo] [int] NOT NULL,
	[Id_mat] [int] NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Per_Mat] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC,
	[Id_mat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo_Persona]    Script Date: 27/10/2014 14:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo_Persona](
	[Id_tipo] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_Persona] PRIMARY KEY CLUSTERED 
(
	[Id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/10/2014 14:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usu] [varchar](50) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[Legajo] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios_Modulos]    Script Date: 27/10/2014 14:37:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios_Modulos](
	[Usu] [varchar](50) NOT NULL,
	[Id_mod] [int] NOT NULL,
	[Alta] [bit] NOT NULL,
	[Baja] [bit] NOT NULL,
	[Modifica] [bit] NOT NULL,
	[Consulta] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios_Modulos] PRIMARY KEY CLUSTERED 
(
	[Usu] ASC,
	[Id_mod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (1, N'Analisis Matematico I')
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (2, N'Algebra y geometria Analitica')
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (3, N'Sistemas y Org.')
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (4, N'Net')
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (5, N'Algoritmos')
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (6, N'Algoritmos Geneticos')
INSERT [dbo].[Materia] ([Id_mat], [Descripcion]) VALUES (7, N'Matematica Discreta')
INSERT [dbo].[Modulo] ([Id_mod], [Descripcion]) VALUES (1, N'Personas')
INSERT [dbo].[Modulo] ([Id_mod], [Descripcion]) VALUES (3, N'Materias')
INSERT [dbo].[Modulo] ([Id_mod], [Descripcion]) VALUES (8, N'Usuarios')
INSERT [dbo].[Modulo] ([Id_mod], [Descripcion]) VALUES (9, N'Permisos')
INSERT [dbo].[Modulo] ([Id_mod], [Descripcion]) VALUES (10, N'Inscripciones')
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Email], [Telefono], [Tipo]) VALUES (0, N'Admin', N'Admin', N'', N'', 0)
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Email], [Telefono], [Tipo]) VALUES (40302, N'Ignacio', N'Selva', N'nacho...', N'', 1)
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Email], [Telefono], [Tipo]) VALUES (40314, N'Juan Manuel', N'Sanchez', N'sanches...', N'124891', 1)
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Email], [Telefono], [Tipo]) VALUES (40412, N'asdlj', N'kljaslkfj', N'jaslkfjas', N'afslk', 2)
INSERT [dbo].[Persona] ([Legajo], [Nombre], [Apellido], [Email], [Telefono], [Tipo]) VALUES (40436, N'Federico', N'Calvagna', N'fedec....', N'', 1)
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40314, 3, CAST(N'1993-02-26' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40314, 4, CAST(N'1993-02-26' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40314, 5, CAST(N'1993-04-26' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 1, CAST(N'2014-10-11' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 2, CAST(N'2014-10-23' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 3, CAST(N'2014-10-23' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 4, CAST(N'2014-10-23' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 5, CAST(N'2014-10-23' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 6, CAST(N'2014-10-23' AS Date))
INSERT [dbo].[Personas_Materias] ([Legajo], [Id_mat], [fecha]) VALUES (40436, 7, CAST(N'2014-10-23' AS Date))
INSERT [dbo].[Tipo_Persona] ([Id_tipo], [Descripcion]) VALUES (0, N'Administrador')
INSERT [dbo].[Tipo_Persona] ([Id_tipo], [Descripcion]) VALUES (1, N'Alumno')
INSERT [dbo].[Tipo_Persona] ([Id_tipo], [Descripcion]) VALUES (2, N'Profesor')
INSERT [dbo].[Usuario] ([Usu], [Clave], [Legajo]) VALUES (N'admin', N'admin', 0)
INSERT [dbo].[Usuario] ([Usu], [Clave], [Legajo]) VALUES (N'fede', N'1234', 40436)
INSERT [dbo].[Usuario] ([Usu], [Clave], [Legajo]) VALUES (N'juan', N'123', 40314)
INSERT [dbo].[Usuario] ([Usu], [Clave], [Legajo]) VALUES (N'meca', N'adran', 99824)
INSERT [dbo].[Usuario] ([Usu], [Clave], [Legajo]) VALUES (N'nacho', N'123', 40302)
INSERT [dbo].[Usuario] ([Usu], [Clave], [Legajo]) VALUES (N'porta', N'ezequiel', 99823)
INSERT [dbo].[Usuarios_Modulos] ([Usu], [Id_mod], [Alta], [Baja], [Modifica], [Consulta]) VALUES (N'admin', 1, 1, 1, 1, 1)
INSERT [dbo].[Usuarios_Modulos] ([Usu], [Id_mod], [Alta], [Baja], [Modifica], [Consulta]) VALUES (N'admin', 3, 1, 1, 1, 1)
INSERT [dbo].[Usuarios_Modulos] ([Usu], [Id_mod], [Alta], [Baja], [Modifica], [Consulta]) VALUES (N'admin', 8, 1, 1, 1, 1)
INSERT [dbo].[Usuarios_Modulos] ([Usu], [Id_mod], [Alta], [Baja], [Modifica], [Consulta]) VALUES (N'admin', 9, 1, 1, 1, 1)
INSERT [dbo].[Usuarios_Modulos] ([Usu], [Id_mod], [Alta], [Baja], [Modifica], [Consulta]) VALUES (N'admin', 10, 1, 1, 1, 1)
INSERT [dbo].[Usuarios_Modulos] ([Usu], [Id_mod], [Alta], [Baja], [Modifica], [Consulta]) VALUES (N'fede', 10, 1, 1, 1, 1)
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK(Tipo_Persona)] FOREIGN KEY([Tipo])
REFERENCES [dbo].[Tipo_Persona] ([Id_tipo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK(Tipo_Persona)]
GO
ALTER TABLE [dbo].[Personas_Materias]  WITH CHECK ADD  CONSTRAINT [FK(Materia)] FOREIGN KEY([Id_mat])
REFERENCES [dbo].[Materia] ([Id_mat])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personas_Materias] CHECK CONSTRAINT [FK(Materia)]
GO
ALTER TABLE [dbo].[Personas_Materias]  WITH CHECK ADD  CONSTRAINT [FK(Persona)] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Persona] ([Legajo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personas_Materias] CHECK CONSTRAINT [FK(Persona)]
GO
ALTER TABLE [dbo].[Usuarios_Modulos]  WITH CHECK ADD  CONSTRAINT [FK(Modulo)] FOREIGN KEY([Id_mod])
REFERENCES [dbo].[Modulo] ([Id_mod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuarios_Modulos] CHECK CONSTRAINT [FK(Modulo)]
GO
ALTER TABLE [dbo].[Usuarios_Modulos]  WITH CHECK ADD  CONSTRAINT [FK(Usuario)] FOREIGN KEY([Usu])
REFERENCES [dbo].[Usuario] ([Usu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuarios_Modulos] CHECK CONSTRAINT [FK(Usuario)]
GO
