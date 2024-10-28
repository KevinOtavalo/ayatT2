USE [AyA]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 26/10/2024 02:15:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[IdAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[ApellidoPat] [nvarchar](100) NULL,
	[ApellidoMat] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[NumeroMatricula] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 26/10/2024 02:15:43 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignatura](
	[CodAsignatura] [int] IDENTITY(1,1) NOT NULL,
	[NombreAsignatura] [nvarchar](255) NOT NULL,
	[Creditos] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodAsignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
