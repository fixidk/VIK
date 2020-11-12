USE [VKDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kunder](
	[Kunde_ID] [int] IDENTITY(1,1) NOT NULL,
	[Kunde_Navn] [nvarchar](50) NULL,
	[Kunde_Adresse] [nvarchar](50) NULL,
	[Kunde_Telefon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Kunde_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [VKDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rejser](
	[Rejse_ID] [int] IDENTITY(1,1) NOT NULL,
	[Rejse_Titel] [nvarchar](50) NULL,
	[Rejse_By] [nvarchar](50) NULL,
	[Rejse_Stardato] [datetime] NULL,
	[Rejse_Slutdato] [datetime] NULL,
	[Rejse_Pris] [int] NULL,
	[Rejse_MaxAntal] [int] NULL,
	[Rejse_Beskrivelse] [nvarchar](100) NULL,
 CONSTRAINT [PK_Rejser] PRIMARY KEY CLUSTERED 
(
	[Rejse_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [VKDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transportor](
	[Transportor_ID] [int] IDENTITY(1,1) NOT NULL,
	[Transportor_Navn] [nvarchar](50) NULL,
	[Transportor_Adresse] [nvarchar](50) NULL,
	[Transportor_Telefon] [int] NULL,
	[Transportor_Bemaerkninger] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Transportor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

