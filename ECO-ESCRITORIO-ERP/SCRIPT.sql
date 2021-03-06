
CREATE DATABASE ECO
USE [ECO]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 19/08/2019 15:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[intIdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[vchNombres] [varchar](50) NULL,
	[vchApellidos] [varchar](50) NULL,
	[vchUsuario] [varchar](50) NULL,
	[vchPassword] [varchar](50) NULL,
	[Icono] [varchar](200) NULL,
	[vchCorreo] [varchar](50) NULL,
	[vchRol] [varchar](50) NULL,
	[intEstado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[LOGINSESION]    Script Date: 19/08/2019 15:41:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOGINSESION] --LOGINSESION 'ALEX','ALEX'
@vchUsuario VARCHAR(50),
@vchPassword VARCHAR(50)
AS
BEGIN
	SELECT COUNT(*) AS 'ESTADO'
	FROM Usuario
	WHERE vchUsuario = @vchUsuario 
	AND   vchPassword = @vchPassword
END
GO
