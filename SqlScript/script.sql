USE [Beraberiz2]
GO
/****** Object:  Table [dbo].[Animal]    Script Date: 22.04.2019 23:52:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KindOfAnimalId] [int] NOT NULL,
	[ShelterId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateOfRegister] [datetime] NOT NULL,
	[Note] [nvarchar](150) NOT NULL,
	[Pet] [bit] NOT NULL,
 CONSTRAINT [PK_Hayvan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 22.04.2019 23:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_iller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Districts]    Script Date: 22.04.2019 23:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Districts](
	[Id] [int] NOT NULL,
	[District] [nvarchar](255) NULL,
	[City] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ilceler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KindOfAnimal]    Script Date: 22.04.2019 23:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KindOfAnimal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_HayvanTur] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Management]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Management](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagementTypeId] [int] NULL,
	[CityId] [int] NULL,
	[DistrictId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Point] [int] NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Isletme] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagementFood]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagementFood](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagementId] [int] NULL,
	[DateOfFood] [datetime] NULL,
	[DeliveryTime] [datetime] NULL,
	[SupplyDelivery] [bit] NULL,
	[ResponsibleUser] [int] NULL,
 CONSTRAINT [PK_IsletmeErzak] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagementPhone]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagementPhone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagementId] [int] NULL,
	[PhoneTypeId] [int] NULL,
	[PhoneNumber] [char](11) NULL,
 CONSTRAINT [PK_IsletmeTelefon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagementShelter]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagementShelter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagementId] [int] NULL,
	[ShelterId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_IsletmeBarinak] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagementType]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagementType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_IsletmeTur] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneType]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_TelefonTur] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponsibleOfManagement]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponsibleOfManagement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ManagementId] [int] NOT NULL,
 CONSTRAINT [PK_IsletmeSorumlu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shelter]    Script Date: 22.04.2019 23:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shelter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NULL,
	[DistrictId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Barinak] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShelterOfUser]    Script Date: 22.04.2019 23:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShelterOfUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ShelterId] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_KullaniciBarinak] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 22.04.2019 23:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NULL,
	[DistrictId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[IdentityNumber] [char](11) NULL,
	[Gender] [bit] NULL,
	[Birthday] [date] NULL,
	[Address] [nvarchar](100) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Point] [int] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPhone]    Script Date: 22.04.2019 23:52:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPhone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[PhoneNumber] [char](11) NULL,
	[PhoneId] [int] NULL,
 CONSTRAINT [PK_KullaniciTelefon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Animal] ON 

INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (2, 1, 1, N'Boncuk', CAST(N'2019-04-13T18:24:34.600' AS DateTime), N'Sokakta bulundu', 0)
INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (3, 1, 2, N'Kara zeytin', CAST(N'2019-04-13T18:29:36.000' AS DateTime), N'Vatandaş tarafından bırakıldı', 1)
INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (4, 1, 1, N'Rıfkı', CAST(N'2019-04-13T18:30:02.793' AS DateTime), N'Maraz ali getirdi', 1)
INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (5, 1, 2, N'Garip kont ekle', CAST(N'2019-04-13T18:30:30.000' AS DateTime), N'Emekli oldu', 0)
INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (6, 2, 2, N'Nikaragua', CAST(N'2019-04-13T18:31:35.713' AS DateTime), N'Sokakta bulundu', 0)
INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (9, 3, 3, N'çiçek', CAST(N'2016-07-15T10:13:00.000' AS DateTime), N'Damda bulduk...', 1)
INSERT [dbo].[Animal] ([Id], [KindOfAnimalId], [ShelterId], [Name], [DateOfRegister], [Note], [Pet]) VALUES (12, 7, 2, N'Ejder necdet', CAST(N'1774-06-08T20:43:12.000' AS DateTime), N'Fosilini bulduk.', 1)
SET IDENTITY_INSERT [dbo].[Animal] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [Name]) VALUES (1, N'ADANA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (2, N'ADIYAMAN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (3, N'AFYON')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (4, N'AĞRI')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (5, N'AMASYA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (6, N'ANKARA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (7, N'ANTALYA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (8, N'ARTVİN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (9, N'AYDIN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (10, N'BALIKESİR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (11, N'BİLECİK')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (12, N'BİNGÖL')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (13, N'BİTLİS')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (14, N'BOLU')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (15, N'BURDUR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (16, N'BURSA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (17, N'ÇANAKKALE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (18, N'ÇANKIRI')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (19, N'ÇORUM')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (20, N'DENİZLİ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (21, N'DİYARBAKIR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (22, N'EDİRNE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (23, N'ELAZIĞ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (24, N'ERZİNCAN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (25, N'ERZURUM')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (26, N'ESKİŞEHİR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (27, N'GAZİANTEP')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (28, N'GİRESUN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (29, N'GÜMÜŞHANE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (30, N'HAKKARİ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (31, N'HATAY')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (32, N'ISPARTA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (33, N'İÇEL')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (34, N'İSTANBUL')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (35, N'İZMİR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (36, N'KARS')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (37, N'KASTAMONU')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (38, N'KAYSERİ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (39, N'KIRKLARELİ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (40, N'KIRŞEHİR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (41, N'KOCAELİ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (42, N'KONYA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (43, N'KÜTAHYA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (44, N'MALATYA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (45, N'MANİSA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (46, N'KAHRAMANMARAŞ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (47, N'MARDİN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (48, N'MUĞLA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (49, N'MUŞ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (50, N'NEVŞEHİR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (51, N'NİĞDE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (52, N'ORDU')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (53, N'RİZE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (54, N'SAKARYA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (55, N'SAMSUN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (56, N'SİİRT')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (57, N'SİNOP')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (58, N'SİVAS')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (59, N'TEKİRDAĞ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (60, N'TOKAT')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (61, N'TRABZON')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (62, N'TUNCELİ')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (63, N'ŞANLIURFA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (64, N'UŞAK')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (65, N'VAN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (66, N'YOZGAT')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (67, N'ZONGULDAK')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (68, N'AKSARAY')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (69, N'BAYBURT')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (70, N'KARAMAN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (71, N'KIRIKKALE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (72, N'BATMAN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (73, N'ŞIRNAK')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (74, N'BARTIN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (75, N'ARDAHAN')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (76, N'IĞDIR')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (77, N'YALOVA')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (78, N'KARABÜK')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (79, N'KİLİS')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (80, N'OSMANİYE')
INSERT [dbo].[Cities] ([Id], [Name]) VALUES (81, N'DÜZCE')
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Districts] ON 

INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (1, N'SEYHAN', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (2, N'CEYHAN', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (3, N'FEKE', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (4, N'KARAİSALI', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (5, N'KARATAŞ', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (6, N'KOZAN', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (7, N'POZANTI', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (8, N'SAİMBEYLİ', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (9, N'TUFANBEYLİ', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (10, N'YUMURTALIK', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (11, N'YÜREĞİR', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (12, N'ALADAĞ', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (13, N'İMAMOĞLU', 1)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (14, N'ADIYAMAN MERKEZ', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (15, N'BESNİ', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (16, N'ÇELİKHAN', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (17, N'GERGER', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (18, N'GÖLBAŞI', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (19, N'KAHTA', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (20, N'SAMSAT', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (21, N'SİNCİK', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (22, N'TUT', 2)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (23, N'AFYONMERKEZ', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (24, N'BOLVADİN', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (25, N'ÇAY', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (26, N'DAZKIRI', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (27, N'DİNAR', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (28, N'EMİRDAĞ', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (29, N'İHSANİYE', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (30, N'SANDIKLI', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (31, N'SİNANPAŞA', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (32, N'SULDANDAĞI', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (33, N'ŞUHUT', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (34, N'BAŞMAKÇI', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (35, N'BAYAT', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (36, N'İŞCEHİSAR', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (37, N'ÇOBANLAR', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (38, N'EVCİLER', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (39, N'HOCALAR', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (40, N'KIZILÖREN', 3)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (41, N'AKSARAY MERKEZ', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (42, N'ORTAKÖY', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (43, N'AĞAÇÖREN', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (44, N'GÜZELYURT', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (45, N'SARIYAHŞİ', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (46, N'ESKİL', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (47, N'GÜLAĞAÇ', 68)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (48, N'AMASYA MERKEZ', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (49, N'GÖYNÜÇEK', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (50, N'GÜMÜŞHACIKÖYÜ', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (51, N'MERZİFON', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (52, N'SULUOVA', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (53, N'TAŞOVA', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (54, N'HAMAMÖZÜ', 5)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (55, N'ALTINDAĞ', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (56, N'AYAS', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (57, N'BALA', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (58, N'BEYPAZARI', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (59, N'ÇAMLIDERE', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (60, N'ÇANKAYA', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (61, N'ÇUBUK', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (62, N'ELMADAĞ', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (63, N'GÜDÜL', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (64, N'HAYMANA', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (65, N'KALECİK', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (66, N'KIZILCAHAMAM', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (67, N'NALLIHAN', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (68, N'POLATLI', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (69, N'ŞEREFLİKOÇHİSAR', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (70, N'YENİMAHALLE', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (71, N'GÖLBAŞI', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (72, N'KEÇİÖREN', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (73, N'MAMAK', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (74, N'SİNCAN', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (75, N'KAZAN', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (76, N'AKYURT', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (77, N'ETİMESGUT', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (78, N'EVREN', 6)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (79, N'ANSEKİ', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (80, N'ALANYA', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (81, N'ANTALYA MERKEZİ', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (82, N'ELMALI', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (83, N'FİNİKE', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (84, N'GAZİPAŞA', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (85, N'GÜNDOĞMUŞ', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (86, N'KAŞ', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (87, N'KORKUTELİ', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (88, N'KUMLUCA', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (89, N'MANAVGAT', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (90, N'SERİK', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (91, N'DEMRE', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (92, N'İBRADI', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (93, N'KEMER', 7)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (94, N'ARDAHAN MERKEZ', 75)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (95, N'GÖLE', 75)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (96, N'ÇILDIR', 75)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (97, N'HANAK', 75)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (98, N'POSOF', 75)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (99, N'DAMAL', 75)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (100, N'ARDANUÇ', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (101, N'ARHAVİ', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (102, N'ARTVİN MERKEZ', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (103, N'BORÇKA', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (104, N'HOPA', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (105, N'ŞAVŞAT', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (106, N'YUSUFELİ', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (107, N'MURGUL', 8)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (108, N'AYDIN MERKEZ', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (109, N'BOZDOĞAN', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (110, N'ÇİNE', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (111, N'GERMENCİK', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (112, N'KARACASU', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (113, N'KOÇARLI', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (114, N'KUŞADASI', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (115, N'KUYUCAK', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (116, N'NAZİLLİ', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (117, N'SÖKE', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (118, N'SULTANHİSAR', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (119, N'YENİPAZAR', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (120, N'BUHARKENT', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (121, N'İNCİRLİOVA', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (122, N'KARPUZLU', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (123, N'KÖŞK', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (124, N'DİDİM', 9)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (125, N'AĞRI MERKEZ', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (126, N'DİYADİN', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (127, N'DOĞUBEYAZIT', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (128, N'ELEŞKİRT', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (129, N'HAMUR', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (130, N'PATNOS', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (131, N'TAŞLIÇAY', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (132, N'TUTAK', 4)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (133, N'AYVALIK', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (134, N'BALIKESİR MERKEZ', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (135, N'BALYA', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (136, N'BANDIRMA', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (137, N'BİGADİÇ', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (138, N'BURHANİYE', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (139, N'DURSUNBEY', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (140, N'EDREMİT', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (141, N'ERDEK', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (142, N'GÖNEN', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (143, N'HAVRAN', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (144, N'İVRİNDİ', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (145, N'KEPSUT', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (146, N'MANYAS', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (147, N'SAVAŞTEPE', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (148, N'SINDIRGI', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (149, N'SUSURLUK', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (150, N'MARMARA', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (151, N'GÖMEÇ', 10)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (152, N'BARTIN MERKEZ', 74)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (153, N'KURUCAŞİLE', 74)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (154, N'ULUS', 74)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (155, N'AMASRA', 74)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (156, N'BATMAN MERKEZ', 72)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (157, N'BEŞİRİ', 72)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (158, N'GERCÜŞ', 72)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (159, N'KOZLUK', 72)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (160, N'SASON', 72)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (161, N'HASANKEYF', 72)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (162, N'BAYBURT MERKEZ', 69)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (163, N'AYDINTEPE', 69)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (164, N'DEMİRÖZÜ', 69)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (165, N'BOLU MERKEZ', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (166, N'GEREDE', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (167, N'GÖYNÜK', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (168, N'KIBRISCIK', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (169, N'MENGEN', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (170, N'MUDURNU', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (171, N'SEBEN', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (172, N'DÖRTDİVAN', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (173, N'YENİÇAĞA', 14)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (174, N'AĞLASUN', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (175, N'BUCAK', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (176, N'BURDUR MERKEZ', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (177, N'GÖLHİSAR', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (178, N'TEFENNİ', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (179, N'YEŞİLOVA', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (180, N'KARAMANLI', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (181, N'KEMER', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (182, N'ALTINYAYLA', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (183, N'ÇAVDIR', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (184, N'ÇELTİKÇİ', 15)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (185, N'GEMLİK', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (186, N'İNEGÖL', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (187, N'İZNİK', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (188, N'KARACABEY', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (189, N'KELES', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (190, N'MUDANYA', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (191, N'MUSTAFA K. PAŞA', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (192, N'ORHANELİ', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (193, N'ORHANGAZİ', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (194, N'YENİŞEHİR', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (195, N'BÜYÜK ORHAN', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (196, N'HARMANCIK', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (197, N'NÜLİFER', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (198, N'OSMAN GAZİ', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (199, N'YILDIRIM', 16)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (200, N'GÜRSU', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (201, N'KESTEL', 16)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (202, N'BİLECİK MERKEZ', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (203, N'BOZÜYÜK', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (204, N'GÖLPAZARI', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (205, N'OSMANELİ', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (206, N'PAZARYERİ', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (207, N'SÖĞÜT', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (208, N'YENİPAZAR', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (209, N'İNHİSAR', 11)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (210, N'BİNGÖL MERKEZ', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (211, N'GENÇ', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (212, N'KARLIOVA', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (213, N'KİGI', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (214, N'SOLHAN', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (215, N'ADAKLI', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (216, N'YAYLADERE', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (217, N'YEDİSU', 12)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (218, N'ADİLCEVAZ', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (219, N'AHLAT', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (220, N'BİTLİS MERKEZ', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (221, N'HİZAN', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (222, N'MUTKİ', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (223, N'TATVAN', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (224, N'GÜROYMAK', 13)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (225, N'DENİZLİ MERKEZ', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (226, N'ACIPAYAM', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (227, N'BULDAN', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (228, N'ÇAL', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (229, N'ÇAMELİ', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (230, N'ÇARDAK', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (231, N'ÇİVRİL', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (232, N'GÜNEY', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (233, N'KALE', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (234, N'SARAYKÖY', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (235, N'TAVAS', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (236, N'BABADAĞ', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (237, N'BEKİLLİ', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (238, N'HONAZ', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (239, N'SERİNHİSAR', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (240, N'AKKÖY', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (241, N'BAKLAN', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (242, N'BEYAĞAÇ', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (243, N'BOZKURT', 20)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (244, N'DÜZCE MERKEZ', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (245, N'AKÇAKOCA', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (246, N'YIĞILCA', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (247, N'CUMAYERİ', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (248, N'GÖLYAKA', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (249, N'ÇİLİMLİ', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (250, N'GÜMÜŞOVA', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (251, N'KAYNAŞLI', 81)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (252, N'DİYARBAKIR MERKEZ', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (253, N'BİSMİL', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (254, N'ÇERMİK', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (255, N'ÇINAR', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (256, N'ÇÜNGÜŞ', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (257, N'DİCLE', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (258, N'ERGANİ', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (259, N'HANİ', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (260, N'HAZRO', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (261, N'KULP', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (262, N'LİCE', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (263, N'SİLVAN', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (264, N'EĞİL', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (265, N'KOCAKÖY', 21)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (266, N'EDİRNE MERKEZ', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (267, N'ENEZ', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (268, N'HAVSA', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (269, N'İPSALA', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (270, N'KEŞAN', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (271, N'LALAPAŞA', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (272, N'MERİÇ', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (273, N'UZUNKÖPRÜ', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (274, N'SÜLOĞLU', 22)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (275, N'ELAZIĞ MERKEZ', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (276, N'AĞIN', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (277, N'BASKİL', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (278, N'KARAKOÇAN', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (279, N'KEBAN', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (280, N'MADEN', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (281, N'PALU', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (282, N'SİVRİCE', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (283, N'ARICAK', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (284, N'KOVANCILAR', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (285, N'ALACAKAYA', 23)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (286, N'ERZURUM MERKEZ', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (287, N'PALANDÖKEN', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (288, N'AŞKALE', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (289, N'ÇAT', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (290, N'HINIS', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (291, N'HORASAN', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (292, N'OLTU', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (293, N'İSPİR', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (294, N'KARAYAZI', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (295, N'NARMAN', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (296, N'OLUR', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (297, N'PASİNLER', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (298, N'ŞENKAYA', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (299, N'TEKMAN', 25)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (300, N'TORTUM', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (301, N'KARAÇOBAN', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (302, N'UZUNDERE', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (303, N'PAZARYOLU', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (304, N'ILICA', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (305, N'KÖPRÜKÖY', 25)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (306, N'ÇAYIRLI', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (307, N'ERZİNCAN MERKEZ', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (308, N'İLİÇ', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (309, N'KEMAH', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (310, N'KEMALİYE', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (311, N'REFAHİYE', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (312, N'TERCAN', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (313, N'OTLUKBELİ', 24)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (314, N'ESKİŞEHİR MERKEZ', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (315, N'ÇİFTELER', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (316, N'MAHMUDİYE', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (317, N'MİHALIÇLIK', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (318, N'SARICAKAYA', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (319, N'SEYİTGAZİ', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (320, N'SİVRİHİSAR', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (321, N'ALPU', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (322, N'BEYLİKOVA', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (323, N'İNÖNÜ', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (324, N'GÜNYÜZÜ', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (325, N'HAN', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (326, N'MİHALGAZİ', 26)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (327, N'ARABAN', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (328, N'İSLAHİYE', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (329, N'NİZİP', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (330, N'OĞUZELİ', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (331, N'YAVUZELİ', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (332, N'ŞAHİNBEY', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (333, N'ŞEHİT KAMİL', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (334, N'KARKAMIŞ', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (335, N'NURDAĞI', 27)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (336, N'GÜMÜŞHANE MERKEZ', 29)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (337, N'KELKİT', 29)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (338, N'ŞİRAN', 29)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (339, N'TORUL', 29)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (340, N'KÖSE', 29)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (341, N'KÜRTÜN', 29)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (342, N'ALUCRA', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (343, N'BULANCAK', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (344, N'DERELİ', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (345, N'ESPİYE', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (346, N'EYNESİL', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (347, N'GİRESUN MERKEZ', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (348, N'GÖRELE', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (349, N'KEŞAP', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (350, N'ŞEBİNKARAHİSAR', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (351, N'TİREBOLU', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (352, N'PİPAZİZ', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (353, N'YAĞLIDERE', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (354, N'ÇAMOLUK', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (355, N'ÇANAKÇI', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (356, N'DOĞANKENT', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (357, N'GÜCE', 28)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (358, N'HAKKARİ MERKEZ', 30)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (359, N'ÇUKURCA', 30)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (360, N'ŞEMDİNLİ', 30)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (361, N'YÜKSEKOVA', 30)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (362, N'ALTINÖZÜ', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (363, N'DÖRTYOL', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (364, N'HATAY MERKEZ', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (365, N'HASSA', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (366, N'İSKENDERUN', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (367, N'KIRIKHAN', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (368, N'REYHANLI', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (369, N'SAMANDAĞ', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (370, N'YAYLADAĞ', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (371, N'ERZİN', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (372, N'BELEN', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (373, N'KUMLU', 31)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (374, N'ISPARTA MERKEZ', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (375, N'ATABEY', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (376, N'KEÇİBORLU', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (377, N'EĞİRDİR', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (378, N'GELENDOST', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (379, N'SİNİRKENT', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (380, N'ULUBORLU', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (381, N'YALVAÇ', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (382, N'AKSU', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (383, N'GÖNEN', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (384, N'YENİŞAR BADEMLİ', 32)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (385, N'IĞDIR MERKEZ', 76)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (386, N'ARALIK', 76)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (387, N'TUZLUCA', 76)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (388, N'KARAKOYUNLU', 76)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (389, N'AFŞİN', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (390, N'ANDIRIN', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (391, N'ELBİSTAN', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (392, N'GÖKSUN', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (393, N'KAHRAMANMARAŞ MERKEZ', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (394, N'PAZARCIK', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (395, N'TÜRKOĞLU', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (396, N'ÇAĞLAYANCERİT', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (397, N'EKİNÖZÜ', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (398, N'NURHAK', 46)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (399, N'EFLANİ', 78)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (400, N'ESKİPAZAR', 78)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (401, N'KARABÜK MERKEZ', 78)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (402, N'OVACIK', 78)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (403, N'SAFRANBOLU', 78)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (404, N'YENİCE', 78)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (405, N'ERMENEK', 70)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (406, N'KARAMAN MERKEZ', 70)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (407, N'AYRANCI', 70)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (408, N'KAZIMKARABEKİR', 70)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (409, N'BAŞYAYLA', 70)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (410, N'SARIVELİLER', 70)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (411, N'KARS MERKEZ', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (412, N'ARPAÇAY', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (413, N'DİGOR', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (414, N'KAĞIZMAN', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (415, N'SARIKAMIŞ', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (416, N'SELİM', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (417, N'SUSUZ', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (418, N'AKYAKA', 36)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (419, N'ABANA', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (420, N'KASTAMONU MERKEZ', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (421, N'ARAÇ', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (422, N'AZDAVAY', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (423, N'BOZKURT', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (424, N'CİDE', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (425, N'ÇATALZEYTİN', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (426, N'DADAY', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (427, N'DEVREKANİ', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (428, N'İNEBOLU', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (429, N'KÜRE', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (430, N'TAŞKÖPRÜ', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (431, N'TOSYA', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (432, N'İHSANGAZİ', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (433, N'PINARBAŞI', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (434, N'ŞENPAZAR', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (435, N'AĞLI', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (436, N'DOĞANYURT', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (437, N'HANÖNÜ', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (438, N'SEYDİLER', 37)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (439, N'BÜNYAN', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (440, N'DEVELİ', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (441, N'FELAHİYE', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (442, N'İNCESU', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (443, N'PINARBAŞI', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (444, N'SARIOĞLAN', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (445, N'SARIZ', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (446, N'TOMARZA', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (447, N'YAHYALI', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (448, N'YEŞİLHİSAR', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (449, N'AKKIŞLA', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (450, N'TALAS', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (451, N'KOCASİNAN', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (452, N'MELİKGAZİ', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (453, N'HACILAR', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (454, N'ÖZVATAN', 38)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (455, N'DERİCE', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (456, N'KESKİN', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (457, N'KIRIKKALE MERKEZ', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (458, N'SALAK YURT', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (459, N'BAHŞİLİ', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (460, N'BALIŞEYH', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (461, N'ÇELEBİ', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (462, N'KARAKEÇİLİ', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (463, N'YAHŞİHAN', 71)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (464, N'KIRKKLARELİ MERKEZ', 39)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (465, N'BABAESKİ', 39)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (466, N'DEMİRKÖY', 39)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (467, N'KOFÇAY', 39)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (468, N'LÜLEBURGAZ', 39)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (469, N'VİZE', 39)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (470, N'KIRŞEHİR MERKEZ', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (471, N'ÇİÇEKDAĞI', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (472, N'KAMAN', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (473, N'MUCUR', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (474, N'AKPINAR', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (475, N'AKÇAKENT', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (476, N'BOZTEPE', 40)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (477, N'KOCAELİ MERKEZ', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (478, N'GEBZE', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (479, N'GÖLCÜK', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (480, N'KANDIRA', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (481, N'KARAMÜRSEL', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (482, N'KÖRFEZ', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (483, N'DERİNCE', 41)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (484, N'KONYA MERKEZ', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (485, N'AKŞEHİR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (486, N'BEYŞEHİR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (487, N'BOZKIR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (488, N'CİHANBEYLİ', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (489, N'ÇUMRA', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (490, N'DOĞANHİSAR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (491, N'EREĞLİ', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (492, N'HADİM', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (493, N'ILGIN', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (494, N'KADINHANI', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (495, N'KARAPINAR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (496, N'KULU', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (497, N'SARAYÖNÜ', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (498, N'SEYDİŞEHİR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (499, N'YUNAK', 42)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (500, N'AKÖREN', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (501, N'ALTINEKİN', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (502, N'DEREBUCAK', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (503, N'HÜYÜK', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (504, N'KARATAY', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (505, N'MERAM', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (506, N'SELÇUKLU', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (507, N'TAŞKENT', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (508, N'AHIRLI', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (509, N'ÇELTİK', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (510, N'DERBENT', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (511, N'EMİRGAZİ', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (512, N'GÜNEYSINIR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (513, N'HALKAPINAR', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (514, N'TUZLUKÇU', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (515, N'YALIHÜYÜK', 42)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (516, N'KÜTAHYA  MERKEZ', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (517, N'ALTINTAŞ', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (518, N'DOMANİÇ', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (519, N'EMET', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (520, N'GEDİZ', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (521, N'SİMAV', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (522, N'TAVŞANLI', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (523, N'ASLANAPA', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (524, N'DUMLUPINAR', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (525, N'HİSARCIK', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (526, N'ŞAPHANE', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (527, N'ÇAVDARHİSAR', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (528, N'PAZARLAR', 43)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (529, N'KİLİS MERKEZ', 79)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (530, N'ELBEYLİ', 79)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (531, N'MUSABEYLİ', 79)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (532, N'POLATELİ', 79)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (533, N'MALATYA MERKEZ', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (534, N'AKÇADAĞ', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (535, N'ARAPGİR', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (536, N'ARGUVAN', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (537, N'DARENDE', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (538, N'DOĞANŞEHİR', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (539, N'HEKİMHAN', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (540, N'PÜTÜRGE', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (541, N'YEŞİLYURT', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (542, N'BATTALGAZİ', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (543, N'DOĞANYOL', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (544, N'KALE', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (545, N'KULUNCAK', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (546, N'YAZIHAN', 44)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (547, N'AKHİSAR', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (548, N'ALAŞEHİR', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (549, N'DEMİRCİ', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (550, N'GÖRDES', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (551, N'KIRKAĞAÇ', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (552, N'KULA', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (553, N'MANİSA MERKEZ', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (554, N'SALİHLİ', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (555, N'SARIGÖL', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (556, N'SARUHANLI', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (557, N'SELENDİ', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (558, N'SOMA', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (559, N'TURGUTLU', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (560, N'AHMETLİ', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (561, N'GÖLMARMARA', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (562, N'KÖPRÜBAŞI', 45)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (563, N'DERİK', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (564, N'KIZILTEPE', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (565, N'MARDİN MERKEZ', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (566, N'MAZIDAĞI', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (567, N'MİDYAT', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (568, N'NUSAYBİN', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (569, N'ÖMERLİ', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (570, N'SAVUR', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (571, N'YEŞİLLİ', 47)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (572, N'MERSİN MERKEZ', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (573, N'ANAMUR', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (574, N'ERDEMLİ', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (575, N'GÜLNAR', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (576, N'MUT', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (577, N'SİLİFKE', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (578, N'TARSUS', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (579, N'AYDINCIK', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (580, N'BOZYAZI', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (581, N'ÇAMLIYAYLA', 33)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (582, N'BODRUM', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (583, N'DATÇA', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (584, N'FETHİYE', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (585, N'KÖYCEĞİZ', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (586, N'MARMARİS', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (587, N'MİLAS', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (588, N'MUĞLA MERKEZ', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (589, N'ULA', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (590, N'YATAĞAN', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (591, N'DALAMAN', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (592, N'KAVAKLI DERE', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (593, N'ORTACA', 48)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (594, N'BULANIK', 49)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (595, N'MALAZGİRT', 49)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (596, N'MUŞ MERKEZ', 49)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (597, N'VARTO', 49)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (598, N'HASKÖY', 49)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (599, N'KORKUT', 49)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (600, N'NEVŞEHİR MERKEZ', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (601, N'AVANOS', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (602, N'DERİNKUYU', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (603, N'GÜLŞEHİR', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (604, N'HACIBEKTAŞ', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (605, N'KOZAKLI', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (606, N'ÜRGÜP', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (607, N'ACIGÖL', 50)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (608, N'NİĞDE MERKEZ', 51)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (609, N'BOR', 51)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (610, N'ÇAMARDI', 51)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (611, N'ULUKIŞLA', 51)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (612, N'ALTUNHİSAR', 51)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (613, N'ÇİFTLİK', 51)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (614, N'AKKUŞ', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (615, N'AYBASTI', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (616, N'FATSA', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (617, N'GÖLKÖY', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (618, N'KORGAN', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (619, N'KUMRU', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (620, N'MESUDİYE', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (621, N'ORDU MERKEZ', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (622, N'PERŞEMBE', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (623, N'ULUBEY', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (624, N'ÜNYE', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (625, N'GÜLYALI', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (626, N'GÜRGENTEPE', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (627, N'ÇAMAŞ', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (628, N'ÇATALPINAR', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (629, N'ÇAYBAŞI', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (630, N'İKİZCE', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (631, N'KABADÜZ', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (632, N'KABATAŞ', 52)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (633, N'BAHÇE', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (634, N'KADİRLİ', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (635, N'OSMANİYE MERKEZ', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (636, N'DÜZİÇİ', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (637, N'HASANBEYLİ', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (638, N'SUMBAŞ', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (639, N'TOPRAKKALE', 80)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (640, N'RİZE MERKEZ', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (641, N'ARDEŞEN', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (642, N'ÇAMLIHEMŞİN', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (643, N'ÇAYELİ', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (644, N'FINDIKLI', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (645, N'İKİZDERE', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (646, N'KALKANDERE', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (647, N'PAZAR', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (648, N'GÜNEYSU', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (649, N'DEREPAZARI', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (650, N'HEMŞİN', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (651, N'İYİDERE', 53)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (652, N'AKYAZI', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (653, N'GEYVE', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (654, N'HENDEK', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (655, N'KARASU', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (656, N'KAYNARCA', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (657, N'SAKARYA MERKEZ', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (658, N'PAMUKOVA', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (659, N'TARAKLI', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (660, N'FERİZLİ', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (661, N'KARAPÜRÇEK', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (662, N'SÖĞÜTLÜ', 54)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (663, N'ALAÇAM', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (664, N'BAFRA', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (665, N'ÇARŞAMBA', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (666, N'HAVZA', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (667, N'KAVAK', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (668, N'LADİK', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (669, N'SAMSUN MERKEZ', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (670, N'TERME', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (671, N'VEZİRKÖPRÜ', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (672, N'ASARCIK', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (673, N'ONDOKUZMAYIS', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (674, N'SALIPAZARI', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (675, N'TEKKEKÖY', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (676, N'AYVACIK', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (677, N'YAKAKENT', 55)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (678, N'AYANCIK', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (679, N'BOYABAT', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (680, N'SİNOP MERKEZ', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (681, N'DURAĞAN', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (682, N'ERGELEK', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (683, N'GERZE', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (684, N'TÜRKELİ', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (685, N'DİKMEN', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (686, N'SARAYDÜZÜ', 57)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (687, N'DİVRİĞİ', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (688, N'GEMEREK', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (689, N'GÜRÜN', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (690, N'HAFİK', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (691, N'İMRANLI', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (692, N'KANGAL', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (693, N'KOYUL HİSAR', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (694, N'SİVAS MERKEZ', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (695, N'SU ŞEHRİ', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (696, N'ŞARKIŞLA', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (697, N'YILDIZELİ', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (698, N'ZARA', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (699, N'AKINCILAR', 58)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (700, N'ALTINYAYLA', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (701, N'DOĞANŞAR', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (702, N'GÜLOVA', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (703, N'ULAŞ', 58)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (704, N'BAYKAN', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (705, N'ERUH', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (706, N'KURTALAN', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (707, N'PERVARİ', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (708, N'SİİRT MERKEZ', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (709, N'ŞİRVARİ', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (710, N'AYDINLAR', 56)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (711, N'TEKİRDAĞ MERKEZ', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (712, N'ÇERKEZKÖY', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (713, N'ÇORLU', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (714, N'HAYRABOLU', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (715, N'MALKARA', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (716, N'MURATLI', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (717, N'SARAY', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (718, N'ŞARKÖY', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (719, N'MARAMARAEREĞLİSİ', 59)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (720, N'ALMUS', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (721, N'ARTOVA', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (722, N'TOKAT MERKEZ', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (723, N'ERBAA', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (724, N'NİKSAR', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (725, N'REŞADİYE', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (726, N'TURHAL', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (727, N'ZİLE', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (728, N'PAZAR', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (729, N'YEŞİLYURT', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (730, N'BAŞÇİFTLİK', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (731, N'SULUSARAY', 60)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (732, N'TRABZON MERKEZ', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (733, N'AKÇAABAT', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (734, N'ARAKLI', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (735, N'ARŞİN', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (736, N'ÇAYKARA', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (737, N'MAÇKA', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (738, N'OF', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (739, N'SÜRMENE', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (740, N'TONYA', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (741, N'VAKFIKEBİR', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (742, N'YOMRA', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (743, N'BEŞİKDÜZÜ', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (744, N'ŞALPAZARI', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (745, N'ÇARŞIBAŞI', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (746, N'DERNEKPAZARI', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (747, N'DÜZKÖY', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (748, N'HAYRAT', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (749, N'KÖPRÜBAŞI', 61)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (750, N'TUNCELİ MERKEZ', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (751, N'ÇEMİŞGEZEK', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (752, N'HOZAT', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (753, N'MAZGİRT', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (754, N'NAZİMİYE', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (755, N'OVACIK', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (756, N'PERTEK', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (757, N'PÜLÜMÜR', 62)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (758, N'BANAZ', 64)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (759, N'EŞME', 64)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (760, N'KARAHALLI', 64)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (761, N'SİVASLI', 64)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (762, N'ULUBEY', 64)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (763, N'UŞAK MERKEZ', 64)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (764, N'BAŞKALE', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (765, N'VAN MERKEZ', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (766, N'EDREMİT', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (767, N'ÇATAK', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (768, N'ERCİŞ', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (769, N'GEVAŞ', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (770, N'GÜRPINAR', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (771, N'MURADİYE', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (772, N'ÖZALP', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (773, N'BAHÇESARAY', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (774, N'ÇALDIRAN', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (775, N'SARAY', 65)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (776, N'YALOVA MERKEZ', 77)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (777, N'ALTINOVA', 77)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (778, N'ARMUTLU', 77)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (779, N'ÇINARCIK', 77)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (780, N'ÇİFTLİKKÖY', 77)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (781, N'TERMAL', 77)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (782, N'AKDAĞMADENİ', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (783, N'BOĞAZLIYAN', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (784, N'YOZGAT MERKEZ', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (785, N'ÇAYIRALAN', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (786, N'ÇEKEREK', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (787, N'SARIKAYA', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (788, N'SORGUN', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (789, N'ŞEFAATLI', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (790, N'YERKÖY', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (791, N'KADIŞEHRİ', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (792, N'SARAYKENT', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (793, N'YENİFAKILI', 66)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (794, N'ÇAYCUMA', 67)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (795, N'DEVREK', 67)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (796, N'ZONGULDAK MERKEZ', 67)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (797, N'EREĞLİ', 67)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (798, N'ALAPLI', 67)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (799, N'GÖKÇEBEY', 67)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (800, N'ÇANAKKALE MERKEZ', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (801, N'AYVACIK', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (802, N'BAYRAMİÇ', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (803, N'BİGA', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (804, N'BOZCAADA', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (805, N'ÇAN', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (806, N'ECEABAT', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (807, N'EZİNE', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (808, N'LAPSEKİ', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (809, N'YENİCE', 17)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (810, N'ÇANKIRI MERKEZ', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (811, N'ÇERKEŞ', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (812, N'ELDİVAN', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (813, N'ILGAZ', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (814, N'KURŞUNLU', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (815, N'ORTA', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (816, N'ŞABANÖZÜ', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (817, N'YAPRAKLI', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (818, N'ATKARACALAR', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (819, N'KIZILIRMAK', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (820, N'BAYRAMÖREN', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (821, N'KORGUN', 18)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (822, N'ALACA', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (823, N'BAYAT', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (824, N'ÇORUM MERKEZ', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (825, N'İKSİPLİ', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (826, N'KARGI', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (827, N'MECİTÖZÜ', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (828, N'ORTAKÖY', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (829, N'OSMANCIK', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (830, N'SUNGURLU', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (831, N'DODURGA', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (832, N'LAÇİN', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (833, N'OĞUZLAR', 19)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (834, N'ADALAR', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (835, N'BAKIRKÖY', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (836, N'BEŞİKTAŞ', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (837, N'BEYKOZ', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (838, N'BEYOĞLU', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (839, N'ÇATALCA', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (840, N'EMİNÖNÜ', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (841, N'EYÜP', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (842, N'FATİH', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (843, N'GAZİOSMANPAŞA', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (844, N'KADIKÖY', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (845, N'KARTAL', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (846, N'SARIYER', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (847, N'SİLİVRİ', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (848, N'ŞİLE', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (849, N'ŞİŞLİ', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (850, N'ÜSKÜDAR', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (851, N'ZEYTİNBURNU', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (852, N'BÜYÜKÇEKMECE', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (853, N'KAĞITHANE', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (854, N'KÜÇÜKÇEKMECE', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (855, N'PENDİK', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (856, N'ÜMRANİYE', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (857, N'BAYRAMPAŞA', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (858, N'AVCILAR', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (859, N'BAĞCILAR', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (860, N'BAHÇELİEVLER', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (861, N'GÜNGÖREN', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (862, N'MALTEPE', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (863, N'SULTANBEYLİ', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (864, N'TUZLA', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (865, N'ESENLER', 34)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (866, N'ALİAĞA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (867, N'BAYINDIR', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (868, N'BERGAMA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (869, N'BORNOVA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (870, N'ÇEŞME', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (871, N'DİKİLİ', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (872, N'FOÇA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (873, N'KARABURUN', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (874, N'KARŞIYAKA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (875, N'KEMALPAŞA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (876, N'KINIK', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (877, N'KİRAZ', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (878, N'MENEMEN', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (879, N'ÖDEMİŞ', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (880, N'SEFERİHİSAR', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (881, N'SELÇUK', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (882, N'TİRE', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (883, N'TORBALI', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (884, N'URLA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (885, N'BEYDAĞ', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (886, N'BUCA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (887, N'KONAK', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (888, N'MENDERES', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (889, N'BALÇOVA', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (890, N'ÇİGLİ', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (891, N'GAZİEMİR', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (892, N'NARLIDERE', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (893, N'GÜZELBAHÇE', 35)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (894, N'ŞANLIURFA MERKEZ', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (895, N'AKÇAKALE', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (896, N'BİRECİK', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (897, N'BOZOVA', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (898, N'CEYLANPINAR', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (899, N'HALFETİ', 63)
GO
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (900, N'HİLVAN', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (901, N'SİVEREK', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (902, N'SURUÇ', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (903, N'VİRANŞEHİR', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (904, N'HARRAN', 63)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (905, N'BEYTÜŞŞEBAP', 73)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (906, N'ŞIRNAK MERKEZ', 73)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (907, N'CİZRE', 73)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (908, N'İDİL', 73)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (909, N'SİLOPİ', 73)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (910, N'ULUDERE', 73)
INSERT [dbo].[Districts] ([Id], [District], [City]) VALUES (911, N'GÜÇLÜKONAK', 73)
SET IDENTITY_INSERT [dbo].[Districts] OFF
SET IDENTITY_INSERT [dbo].[KindOfAnimal] ON 

INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (1, N'Köpek')
INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (2, N'Kedi')
INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (3, N'Kuş')
INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (4, N'İnek')
INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (5, N'Kaplumbağa')
INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (6, N'Sırtlan')
INSERT [dbo].[KindOfAnimal] ([Id], [Name]) VALUES (7, N'Ölmüş dinazor')
SET IDENTITY_INSERT [dbo].[KindOfAnimal] OFF
SET IDENTITY_INSERT [dbo].[Management] ON 

INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (1, 1, 11, 202, N'Bilecik merkez restoran', N'Bilecik/Merkez', NULL, N'Bilecik', N'11')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (2, 1, 11, 203, N'Miras değil alın teri', N'Bilecik/Bozüyük', NULL, N'Bozüyük', N'11')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (3, 2, 54, 662, N'Söğütlü restorantı', N'Söğütlü bim yanı', NULL, N'Sögütlü', N'54')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (5, 2, 54, 659, N'Ferizli restoran', N'Ferizli merkez', NULL, N'Ferizli', N'5454')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (7, 3, 35, 884, N'izmir urla', N'İzmir ileride solda', NULL, N'İzmir', N'35')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (8, 4, 35, 884, N'İzmir tanzim büfe', N'İzmir merkez park yanı', NULL, N'İzmir', N'3535')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (9, 1, 34, 852, N'İstanbul aile lokantası', N'Büyükçekme A100 karayolu üzeri', NULL, N'İstanbul', N'34')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (10, 2, 34, 852, N'İstanbul akraba restoranı', N'Büyükçekmece  bilinmeyen sokak', NULL, N'İstanbul', N'34')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (11, 1, 15, 174, N'Burdur lokanta', N'Burdu', NULL, N'Burdur', N'15')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (13, 1, 4, 127, N'Ağrı', N'Ağrı', NULL, N'Ağrı', N'4')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (15, 2, 46, 397, N'Maraş Restoran', N'Belediye yanı', NULL, N'BelediyeMaraş', N'maraşlıyık')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (16, 1, 54, 652, N'Akyazı', N'akyazı', NULL, N'sakaryalokanta', N'akyazi')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (17, 3, 45, 547, N'üzüm kasab', N'manisa bağcılar', NULL, N'kırkbeş', N'manisa')
INSERT [dbo].[Management] ([Id], [ManagementTypeId], [CityId], [DistrictId], [Name], [Address], [Point], [Username], [Password]) VALUES (25, 1, 34, 855, N'Adalar lokanta', N'istanbul pendik', NULL, N'lokanta', N'3434')
SET IDENTITY_INSERT [dbo].[Management] OFF
SET IDENTITY_INSERT [dbo].[ManagementPhone] ON 

INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (1, 1, 2, N'1239812391 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (2, 1, 3, N'2139213981 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (3, 2, 2, N'2139821391 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (4, 2, 3, N'2193812398 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (5, 3, 3, N'2139821391 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (6, 3, 2, N'2319832193 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (7, 5, 2, N'2139128312 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (8, 5, 3, N'2139182312 ')
INSERT [dbo].[ManagementPhone] ([Id], [ManagementId], [PhoneTypeId], [PhoneNumber]) VALUES (9, 8, 2, N'1239812319 ')
SET IDENTITY_INSERT [dbo].[ManagementPhone] OFF
SET IDENTITY_INSERT [dbo].[ManagementShelter] ON 

INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (1, 1, 1, 1)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (2, 2, 2, 0)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (3, 3, 3, 1)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (4, 5, 4, 1)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (5, 8, 8, 0)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (6, 7, 7, 1)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (7, 13, 9, 0)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (8, 13, 8, 1)
INSERT [dbo].[ManagementShelter] ([Id], [ManagementId], [ShelterId], [Active]) VALUES (9, 13, 4, 0)
SET IDENTITY_INSERT [dbo].[ManagementShelter] OFF
SET IDENTITY_INSERT [dbo].[ManagementType] ON 

INSERT [dbo].[ManagementType] ([Id], [Name]) VALUES (1, N'Lokanta   ')
INSERT [dbo].[ManagementType] ([Id], [Name]) VALUES (2, N'Restoran  ')
INSERT [dbo].[ManagementType] ([Id], [Name]) VALUES (3, N'Kasap     ')
INSERT [dbo].[ManagementType] ([Id], [Name]) VALUES (4, N'Kafe      ')
INSERT [dbo].[ManagementType] ([Id], [Name]) VALUES (5, N'Büfe      ')
SET IDENTITY_INSERT [dbo].[ManagementType] OFF
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([Id], [Username], [Password]) VALUES (1, N'Kadir', N'54')
SET IDENTITY_INSERT [dbo].[Manager] OFF
SET IDENTITY_INSERT [dbo].[PhoneType] ON 

INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (1, N'GSM')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (2, N'Sabit hat')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (3, N'İş hattı')
INSERT [dbo].[PhoneType] ([Id], [Name]) VALUES (13, N'deneme')
SET IDENTITY_INSERT [dbo].[PhoneType] OFF
SET IDENTITY_INSERT [dbo].[Shelter] ON 

INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (1, 11, 202, N'Bilecik Hayvan Barınağı', N'Merkez Bilecik', N'02641111111')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (2, 11, 203, N'Bozüyük Hayvan Barınağı', N'Merkez Bozüyük ', N'02647811123')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (3, 54, 662, N'Söğütlü City barınağı', N'Texas Söğütlü city', N'04123123451')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (4, 54, 652, N'Ferizli Dallas hayvan barınağı', N'Ferizli', N'12312345123')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (7, 35, 884, N'İzmir hayvan b.', N'İzmir merkez', N'19231239182')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (8, 54, 659, N'Ferizli', N'Sakarya-ferizlii', N'54')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (13, 24, 306, N'deneme', N'deneme', N'deneme')
INSERT [dbo].[Shelter] ([Id], [CityId], [DistrictId], [Name], [Address], [Phone]) VALUES (15, 63, 897, N'Tavşanlı barınağı', N'tavşanlı', N'31234123412')
SET IDENTITY_INSERT [dbo].[Shelter] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (47, 11, 202, N'Ersan', N'çekiç', N'12312312311', 1, CAST(N'1988-06-08' AS Date), N'sakarya/ferizli', N'ersan', N'11', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (48, 41, 477, N'Mehmet', N'kanyılmaz', N'12345678910', 1, CAST(N'1996-11-22' AS Date), N'Ferizli/sakarya', N'mehmet', N'154', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (49, 35, 884, N'Eren alp', N'kaşka', N'12345678910', 1, CAST(N'1997-12-18' AS Date), N'İzmir/urla', N'eren', N'alp', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (50, 54, 660, N'Kadir', N'Bekar', N'12345678910', 1, CAST(N'1996-11-18' AS Date), N'Sakarya/Ferizli', N'Kadir', N'kadir54', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (51, 54, 662, N'Ahmet', N'Ceylan', N'23456789011', 1, CAST(N'1995-07-14' AS Date), N'Söğütlü', N'ahmet', N'54', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (52, 34, 852, N'Berkem', N'Yılmaz', N'12345612311', 1, CAST(N'1997-09-24' AS Date), N'İstanbul/Büyükçekmece', N'berkem', N'34', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (53, 26, 314, N'İsmail', N'erdoğmuş', N'98980987890', 1, CAST(N'1996-07-10' AS Date), N'Eskişehir', N'iso', N'kolsuz', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (54, 22, 268, N'Eda', N'Eren', N'98783912831', 0, CAST(N'1995-08-23' AS Date), N'Edirne', N'eda', N'eda', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (55, 11, 202, N'buse', N'ersan', N'23989231231', 0, CAST(N'1994-05-13' AS Date), N'Bilecik merkez', N'buse', N'11', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (56, 43, 521, N'sinem', N'aslan', N'90923189982', 0, CAST(N'1964-06-10' AS Date), N'Simav/Kütahya', N'sinem', N'dumlupınar', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (57, 45, 551, N'Ayşe', N'fatma', N'12398923121', 0, CAST(N'1994-06-18' AS Date), N'Kırkağaç', N'ayşe', N'komando', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (61, 54, 660, N'Ayşe', N'sinem', N'12345612311', 0, CAST(N'1990-06-16' AS Date), N'Ferizli', N'ayşe', N'komando', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (62, 35, 874, N'Betül', N'karanfil', N'92839123129', 0, CAST(N'2003-05-15' AS Date), N'İzmir/Karşıyaka', N'betül', N'izmir35', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (63, 53, 644, N'Samet', N'fındık', N'98923123121', 1, CAST(N'1994-07-23' AS Date), N'Rize fındık mahallesi', N'samet', N'fındık', NULL)
INSERT [dbo].[User] ([Id], [CityId], [DistrictId], [Name], [Surname], [IdentityNumber], [Gender], [Birthday], [Address], [Username], [Password], [Point]) VALUES (64, 40, 470, N'furkan', N'çiçen', N'21341231231', 1, CAST(N'1997-10-25' AS Date), N'Kırşehir', N'furkan', N'kırşehir', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Animal] ADD  CONSTRAINT [DF_Animal_DateOfRegister]  DEFAULT (getdate()) FOR [DateOfRegister]
GO
ALTER TABLE [dbo].[ManagementFood] ADD  CONSTRAINT [DF_ManagementFood_DateOfFood]  DEFAULT (getdate()) FOR [DateOfFood]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Hayvan_Barinak] FOREIGN KEY([ShelterId])
REFERENCES [dbo].[Shelter] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Hayvan_Barinak]
GO
ALTER TABLE [dbo].[Animal]  WITH CHECK ADD  CONSTRAINT [FK_Hayvan_HayvanTur] FOREIGN KEY([KindOfAnimalId])
REFERENCES [dbo].[KindOfAnimal] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Animal] CHECK CONSTRAINT [FK_Hayvan_HayvanTur]
GO
ALTER TABLE [dbo].[Management]  WITH CHECK ADD  CONSTRAINT [FK_Isletme_Ilceler] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[Districts] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Management] CHECK CONSTRAINT [FK_Isletme_Ilceler]
GO
ALTER TABLE [dbo].[Management]  WITH CHECK ADD  CONSTRAINT [FK_Isletme_Iller] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Management] CHECK CONSTRAINT [FK_Isletme_Iller]
GO
ALTER TABLE [dbo].[Management]  WITH CHECK ADD  CONSTRAINT [FK_Isletme_IsletmeTur] FOREIGN KEY([ManagementTypeId])
REFERENCES [dbo].[ManagementType] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Management] CHECK CONSTRAINT [FK_Isletme_IsletmeTur]
GO
ALTER TABLE [dbo].[ManagementFood]  WITH CHECK ADD  CONSTRAINT [FK_IsletmeErzak_Kullanici] FOREIGN KEY([ResponsibleUser])
REFERENCES [dbo].[User] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ManagementFood] CHECK CONSTRAINT [FK_IsletmeErzak_Kullanici]
GO
ALTER TABLE [dbo].[ManagementPhone]  WITH CHECK ADD  CONSTRAINT [FK_IsletmeTelefon_Isletme] FOREIGN KEY([ManagementId])
REFERENCES [dbo].[Management] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ManagementPhone] CHECK CONSTRAINT [FK_IsletmeTelefon_Isletme]
GO
ALTER TABLE [dbo].[ManagementPhone]  WITH CHECK ADD  CONSTRAINT [FK_IsletmeTelefon_TelefonTur] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneType] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ManagementPhone] CHECK CONSTRAINT [FK_IsletmeTelefon_TelefonTur]
GO
ALTER TABLE [dbo].[ResponsibleOfManagement]  WITH CHECK ADD  CONSTRAINT [FK_IsletmeSorumlu_Kullanici] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ResponsibleOfManagement] CHECK CONSTRAINT [FK_IsletmeSorumlu_Kullanici]
GO
ALTER TABLE [dbo].[Shelter]  WITH CHECK ADD  CONSTRAINT [FK_Barinak_Ilceler] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[Districts] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Shelter] CHECK CONSTRAINT [FK_Barinak_Ilceler]
GO
ALTER TABLE [dbo].[Shelter]  WITH CHECK ADD  CONSTRAINT [FK_Barinak_Iller] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Shelter] CHECK CONSTRAINT [FK_Barinak_Iller]
GO
ALTER TABLE [dbo].[ShelterOfUser]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciBarinak_Kullanici] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShelterOfUser] CHECK CONSTRAINT [FK_KullaniciBarinak_Kullanici]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Cities] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Cities]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Districts] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[Districts] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Districts]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Districts1] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[Districts] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Districts1]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Districts2] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[Districts] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Districts2]
GO
ALTER TABLE [dbo].[UserPhone]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciTelefon_Kullanici] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPhone] CHECK CONSTRAINT [FK_KullaniciTelefon_Kullanici]
GO
ALTER TABLE [dbo].[UserPhone]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciTelefon_TelefonTur] FOREIGN KEY([PhoneId])
REFERENCES [dbo].[PhoneType] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPhone] CHECK CONSTRAINT [FK_KullaniciTelefon_TelefonTur]
GO
