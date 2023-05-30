USE [master]
GO
/****** Object:  Database [Sinema_Bileti]    Script Date: 30.05.2023 16:41:40 ******/
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
/****** Object:  Table [dbo].[Film_Bilgileri]    Script Date: 30.05.2023 16:41:40 ******/
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
/****** Object:  Table [dbo].[Salon_Bilgileri]    Script Date: 30.05.2023 16:41:40 ******/
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
/****** Object:  Table [dbo].[Satis_Bilgileri]    Script Date: 30.05.2023 16:41:40 ******/
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
/****** Object:  Table [dbo].[Seans_Bilgileri]    Script Date: 30.05.2023 16:41:40 ******/
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
/****** Object:  Table [dbo].[Yeni_Kullanici_Bilgileri]    Script Date: 30.05.2023 16:41:40 ******/
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
USE [master]
GO
ALTER DATABASE [Sinema_Bileti] SET  READ_WRITE 
GO
