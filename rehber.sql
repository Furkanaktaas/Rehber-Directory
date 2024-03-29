USE [Rehber]
GO
/****** Object:  Table [dbo].[Bilgi]    Script Date: 09/06/2019 23:04:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilgi](
	[bilgiID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[birim] [nvarchar](50) NULL,
	[dahili] [nvarchar](50) NULL,
	[cep] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bilgi] PRIMARY KEY CLUSTERED 
(
	[bilgiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 09/06/2019 23:04:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[kad] [varchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[ipucu] [nvarchar](50) NULL,
	[soru] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bilgi] ON 

INSERT [dbo].[Bilgi] ([bilgiID], [ad], [soyad], [birim], [dahili], [cep]) VALUES (1, N'furkan', N'aktaş', N'BİLGİ İŞLEM', N'536', N'05442771236')
INSERT [dbo].[Bilgi] ([bilgiID], [ad], [soyad], [birim], [dahili], [cep]) VALUES (2, N'eren', N'fidan', N'MUHASEBE', N'236', N'05412366895')
INSERT [dbo].[Bilgi] ([bilgiID], [ad], [soyad], [birim], [dahili], [cep]) VALUES (3, N'yasin', N'akpınar', N'BİLGİ İŞLEM', N'210', N'05412477889')
INSERT [dbo].[Bilgi] ([bilgiID], [ad], [soyad], [birim], [dahili], [cep]) VALUES (4, N'yusra', N'kara', N'bilgi işlem', N'145', N'05421210120')
SET IDENTITY_INSERT [dbo].[Bilgi] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([kullaniciID], [kad], [sifre], [ipucu], [soru]) VALUES (3, N'admin', N'123', N'tavşan', N'kanka')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
