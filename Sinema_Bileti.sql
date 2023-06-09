USE [master]
GO
/****** Object:  Database [Sinema_Bileti]    Script Date: 30.05.2023 17:11:23 ******/
CREATE DATABASE [Sinema_Bileti]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sinema_Bileti', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Sinema_Bileti.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sinema_Bileti_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Sinema_Bileti_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sinema_Bileti] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sinema_Bileti].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sinema_Bileti] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sinema_Bileti] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sinema_Bileti] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sinema_Bileti] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sinema_Bileti] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sinema_Bileti] SET  MULTI_USER 
GO
ALTER DATABASE [Sinema_Bileti] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sinema_Bileti] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sinema_Bileti] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sinema_Bileti] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sinema_Bileti] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sinema_Bileti] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sinema_Bileti] SET QUERY_STORE = OFF
GO
USE [Sinema_Bileti]
GO
/****** Object:  Table [dbo].[Film_Bilgileri]    Script Date: 30.05.2023 17:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film_Bilgileri](
	[Filmid] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [nvarchar](50) NOT NULL,
	[Yonetmen] [nvarchar](50) NULL,
	[FilmTuru] [nvarchar](50) NULL,
	[FilmSuresi] [nvarchar](50) NULL,
	[Tarih] [nvarchar](50) NULL,
	[YapimYili] [nvarchar](50) NULL,
	[Resim] [nvarchar](50) NULL,
 CONSTRAINT [PK_Film_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[FilmAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salon_Bilgileri]    Script Date: 30.05.2023 17:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon_Bilgileri](
	[Salonid] [int] IDENTITY(1,1) NOT NULL,
	[SalonAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Salon_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[SalonAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis_Bilgileri]    Script Date: 30.05.2023 17:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis_Bilgileri](
	[Satisid] [int] IDENTITY(1,1) NOT NULL,
	[KoltukNo] [nvarchar](50) NULL,
	[SalonAdi] [nvarchar](50) NULL,
	[FilmAdi] [nvarchar](50) NULL,
	[Tarih] [nvarchar](50) NULL,
	[Saat] [nvarchar](50) NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Ucret] [nvarchar](50) NULL,
	[Tarih2] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seans_Bilgileri]    Script Date: 30.05.2023 17:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seans_Bilgileri](
	[Seansid] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [nvarchar](50) NULL,
	[Salon] [nvarchar](50) NULL,
	[Tarih] [nvarchar](50) NULL,
	[Seans] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yeni_Kullanici_Bilgileri]    Script Date: 30.05.2023 17:11:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yeni_Kullanici_Bilgileri](
	[YeniKayitid] [int] NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[Tipi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Film_Bilgileri] ON 

INSERT [dbo].[Film_Bilgileri] ([Filmid], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [Tarih], [YapimYili], [Resim]) VALUES (5, N'Düğün Dernek 2', N'Selçuk Aydemir', N'Komedi', N'1 saat 52 dakika', N'19 mayıs 2022', N'19 Mayıs 2023 Cuma', N'C:\Users\MAZLUM\OneDrive\Resimler\DD2.jpg')
INSERT [dbo].[Film_Bilgileri] ([Filmid], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [Tarih], [YapimYili], [Resim]) VALUES (7, N'Hızlı ve Öfkeli1', N'Alex', N'Aksiyon', N'1 saat 45 dakika', N'2015', N'28 Mayıs 2023 Pazar', N'C:\Users\MAZLUM\OneDrive\Resimler\HO1.jpg')
INSERT [dbo].[Film_Bilgileri] ([Filmid], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [Tarih], [YapimYili], [Resim]) VALUES (9, N'Recep İvedik 6', N'Şahan Gökbakar', N'Komedi', N'1 saat 42 dakika', N'2022', N'31 Mayıs 2023 Çarşamba', N'C:\Users\MAZLUM\OneDrive\Resimler\Rİ6.jpg')
SET IDENTITY_INSERT [dbo].[Film_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Salon_Bilgileri] ON 

INSERT [dbo].[Salon_Bilgileri] ([Salonid], [SalonAdi]) VALUES (2, N'salon1')
INSERT [dbo].[Salon_Bilgileri] ([Salonid], [SalonAdi]) VALUES (4, N'salon2')
INSERT [dbo].[Salon_Bilgileri] ([Salonid], [SalonAdi]) VALUES (6, N'salon3')
INSERT [dbo].[Salon_Bilgileri] ([Salonid], [SalonAdi]) VALUES (7, N'salon4')
SET IDENTITY_INSERT [dbo].[Salon_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Satis_Bilgileri] ON 

INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (1, N'1', N'Salon3', N'Recep', N'28.05.2023 çarşamb', N'14:00', N'Mazlum', N'aksoy', N'45 TL', N'28.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (2, N'2', N'salon3', N'recep', N'22.05.2023', N'12:00', N'ahmet', N'taş', N'45', N'28.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (3, N'3', N'salon3', N'recep', N'28.05.2023', N'16:00', N'murat', N'kaş', N'45 TL', N'28.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (4, N'4', N'salon', N'recep', N'28.05.2023', N'20:00', N'abdullah', N'kumru', N'45', N'28.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (5, N'47', N'salon4', N'Recep İvedik 6', N'31 Mayıs 2023 Çarşamba', N'18:00', N'mazlum', N'kral', N'45', N'29.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (6, N'40', N'', N'recep', N'', N'', N'bfghn', N'hgjh', N'65', N'29.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (7, N'64', N'salon3', N'recep', N'30 Mayıs 2023 Salı', N'20:00', N'kkjh', N'hg', N'45', N'29.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (8, N'56', N'salon3', N'recep', N'30 Mayıs 2023 Salı', N'20:00', N'palis', N'fsb', N'45', N'29.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (11, N'39', N'salon4', N'Recep İvedik 6', N'31 Mayıs 2023 Çarşamba', N'20:00', N'suad', N'aksoy', N'45', N'30.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (12, N'64', N'salon4', N'Recep İvedik 6', N'31 Mayıs 2023 Çarşamba', N'20:00', N'', N'', N'45', N'30.05.2023')
INSERT [dbo].[Satis_Bilgileri] ([Satisid], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [Tarih2]) VALUES (13, N'62', N'salon4', N'Recep İvedik 6', N'31 Mayıs 2023 Çarşamba', N'20:00', N'', N'', N'45', N'30.05.2023')
SET IDENTITY_INSERT [dbo].[Satis_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Seans_Bilgileri] ON 

INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (1, N'alacakaranlik 1', N'salon1', N'7 Mayıs 2023 Pazar', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (2, N'alacakaranlik 1', N'salon2', N'7 Mayıs 2023 Pazar', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (3, N'alacakaranlik 1', N'salon1', N'7 Mayıs 2023 Pazar', N'10:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (4, N'alacakaranlik 1', N'salon1', N'7 Mayıs 2023 Pazar', N'10:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (8, N'çakallarla dans', N'salon3', N'7 Mayıs 2023 Pazar', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (9, N'çakallarla dans', N'salon1', N'7 Mayıs 2023 Pazar', N'10:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (15, N'korku dunyasi', N'salon3', N'7 Mayıs 2023 Pazar', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (16, N'Alacakaranlık', N'salon3', N'8 Mayıs 2023 Pazartesi', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (17, N'Recep İvedik 6', N'salon1', N'20 Mayıs 2023 Cumartesi', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (18, N'Düğün Dernek 2', N'salon4', N'20 Mayıs 2023 Cumartesi', N'14:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (19, N'Düğün Dernek 2', N'salon2', N'20 Mayıs 2023 Cumartesi', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (20, N'recep', N'salon3', N'22 Mayıs 2023 Pazartesi', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (21, N'Recep İvedik 6', N'salon4', N'21 Mayıs 2023 Pazar', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (22, N'Düğün Dernek 2', N'salon4', N'21 Mayıs 2023 Pazar', N'18:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (23, N'Hızlı ve Öfkeli1', N'Salon5', N'28 Mayıs 2023 Pazar', N'18:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (25, N'Recep İvedik 6', N'salon4', N'31 Mayıs 2023 Çarşamba', N'18:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (26, N'Recep İvedik 6', N'salon4', N'31 Mayıs 2023 Çarşamba', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (27, N'Düğün Dernek 2', N'salon4', N'31 Mayıs 2023 Çarşamba', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (5, N'', N'', N'7 Mayıs 2023 Pazar', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (6, N'', N'', N'7 Mayıs 2023 Pazar', N'14:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (7, N'alacakaranlik 1', N'salon2', N'7 Mayıs 2023 Pazar', N'12:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (10, N'Alacakaranlık', N'salon2', N'19 Mayıs 2023 Cuma', N'10:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (11, N'korku dunyasi', N'salon1', N'7 Mayıs 2023 Pazar', N'20:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (12, N'korku dunyasi', N'salon2', N'7 Mayıs 2023 Pazar', N'18:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (13, N'korku dunyasi', N'salon2', N'7 Mayıs 2023 Pazar', N'18:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (14, N'Alacakaranlık', N'salon4', N'7 Mayıs 2023 Pazar', N'16:00')
INSERT [dbo].[Seans_Bilgileri] ([Seansid], [FilmAdi], [Salon], [Tarih], [Seans]) VALUES (24, N'recep', N'salon3', N'30 Mayıs 2023 Salı', N'20:00')
SET IDENTITY_INSERT [dbo].[Seans_Bilgileri] OFF
GO
USE [master]
GO
ALTER DATABASE [Sinema_Bileti] SET  READ_WRITE 
GO
