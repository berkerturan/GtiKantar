USE [master]
GO
/****** Object:  Database [NEXSUS]    Script Date: 02/03/2014 14:02:11 ******/
CREATE DATABASE [NEXSUS] ON  PRIMARY 
( NAME = N'NEXSUS', FILENAME = N'd:\Program Files\Microsoft SQL Server\MSSQL10_50.GTIDB\MSSQL\DATA\NEXSUS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NEXSUS_log', FILENAME = N'd:\Program Files\Microsoft SQL Server\MSSQL10_50.GTIDB\MSSQL\DATA\NEXSUS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NEXSUS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NEXSUS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NEXSUS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [NEXSUS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [NEXSUS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [NEXSUS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [NEXSUS] SET ARITHABORT OFF
GO
ALTER DATABASE [NEXSUS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [NEXSUS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [NEXSUS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [NEXSUS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [NEXSUS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [NEXSUS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [NEXSUS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [NEXSUS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [NEXSUS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [NEXSUS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [NEXSUS] SET  DISABLE_BROKER
GO
ALTER DATABASE [NEXSUS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [NEXSUS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [NEXSUS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [NEXSUS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [NEXSUS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [NEXSUS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [NEXSUS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [NEXSUS] SET  READ_WRITE
GO
ALTER DATABASE [NEXSUS] SET RECOVERY FULL
GO
ALTER DATABASE [NEXSUS] SET  MULTI_USER
GO
ALTER DATABASE [NEXSUS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [NEXSUS] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'NEXSUS', N'ON'
GO
USE [NEXSUS]
GO
/****** Object:  User [AppUser]    Script Date: 02/03/2014 14:02:11 ******/
CREATE USER [AppUser] FOR LOGIN [AppUser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[KAPI]    Script Date: 02/03/2014 14:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KAPI](
	[ID] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[ADI] [varchar](50) NOT NULL,
	[ERPBRANCHID] [int] NULL,
 CONSTRAINT [PK_KAPI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KAPI.ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KAPI', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KAPI.ADI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KAPI', @level2type=N'COLUMN',@level2name=N'ADI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KAPI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KAPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KAPI.PK_KAPI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KAPI', @level2type=N'CONSTRAINT',@level2name=N'PK_KAPI'
GO
/****** Object:  Table [dbo].[KANTARLAR]    Script Date: 02/03/2014 14:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KANTARLAR](
	[ID] [numeric](10, 0) NOT NULL,
	[KAPI] [numeric](10, 0) NOT NULL,
	[ADI] [varchar](50) NOT NULL,
	[DOSYA_YOLU] [varchar](100) NULL,
	[DOSYA_UZANTI] [varchar](10) NULL,
	[ROWID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_KANTARLAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR.ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR.KAPI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR', @level2type=N'COLUMN',@level2name=N'KAPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR.ADI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR', @level2type=N'COLUMN',@level2name=N'ADI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR.DOSYA_YOLU' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR', @level2type=N'COLUMN',@level2name=N'DOSYA_YOLU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR.DOSYA_UZANTI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR', @level2type=N'COLUMN',@level2name=N'DOSYA_UZANTI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTARLAR.PK_KANTARLAR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTARLAR', @level2type=N'CONSTRAINT',@level2name=N'PK_KANTARLAR'
GO
/****** Object:  Table [dbo].[KANTAR]    Script Date: 02/03/2014 14:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KANTAR](
	[ID] [numeric](10, 0) IDENTITY(1,1) NOT NULL,
	[KAPI] [numeric](10, 0) NOT NULL,
	[KANTARLAR] [numeric](10, 0) NOT NULL,
	[DOSYA] [varchar](50) NOT NULL,
	[TARIH] [datetime] NOT NULL,
	[TIP] [varchar](1) NULL,
	[PLAKA] [varchar](50) NULL,
	[DORSE] [varchar](50) NULL,
	[ILKTARTIMTARIHI] [datetime] NULL,
	[SONTARTIMTARIHI] [datetime] NULL,
	[TARTIMNO] [numeric](10, 0) NULL,
	[FIRMAKODU] [varchar](20) NULL,
	[FIRMAADI] [varchar](100) NULL,
	[MALZEMEKODU] [varchar](20) NULL,
	[MALZEMEADI] [varchar](100) NULL,
	[ALAN1] [varchar](50) NULL,
	[ALAN2] [varchar](50) NULL,
	[ALAN3] [varchar](50) NULL,
	[ALAN4] [varchar](50) NULL,
	[IRSALIYENO] [varchar](50) NULL,
	[KANTARNO] [numeric](2, 0) NULL,
	[FIREMIKTARI] [numeric](10, 0) NULL,
	[TARTIM1] [numeric](10, 0) NULL,
	[TARTIM2] [numeric](10, 0) NULL,
	[KULLANICI] [varchar](50) NULL,
	[ROWID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_KANTAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.KAPI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'KAPI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.KANTARLAR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'KANTARLAR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.DOSYA' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'DOSYA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.TARIH' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'TARIH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.TIP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'TIP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.PLAKA' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'PLAKA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.DORSE' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'DORSE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.ILKTARTIMTARIHI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'ILKTARTIMTARIHI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.SONTARTIMTARIHI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'SONTARTIMTARIHI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.TARTIMNO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'TARTIMNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.FIRMAKODU' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'FIRMAKODU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.FIRMAADI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'FIRMAADI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.MALZEMEKODU' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'MALZEMEKODU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.MALZEMEADI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'MALZEMEADI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.ALAN1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'ALAN1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.ALAN2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'ALAN2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.ALAN3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'ALAN3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.ALAN4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'ALAN4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.IRSALIYENO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'IRSALIYENO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.KANTARNO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'KANTARNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.FIREMIKTARI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'FIREMIKTARI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.TARTIM1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'TARTIM1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.TARTIM2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'TARTIM2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.KULLANICI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'COLUMN',@level2name=N'KULLANICI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'GTISCHEMA.KANTAR.PK_KANTAR' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KANTAR', @level2type=N'CONSTRAINT',@level2name=N'PK_KANTAR'
GO
/****** Object:  Default [DF__KANTARLAR__ROWID__4222D4EF]    Script Date: 02/03/2014 14:02:12 ******/
ALTER TABLE [dbo].[KANTARLAR] ADD  CONSTRAINT [DF__KANTARLAR__ROWID__4222D4EF]  DEFAULT (newid()) FOR [ROWID]
GO
/****** Object:  Default [DF__KANTAR__TARIH__6EF57B66]    Script Date: 02/03/2014 14:02:12 ******/
ALTER TABLE [dbo].[KANTAR] ADD  CONSTRAINT [DF__KANTAR__TARIH__6EF57B66]  DEFAULT (sysdatetime()) FOR [TARIH]
GO
/****** Object:  Default [DF__KANTAR__ROWID__6FE99F9F]    Script Date: 02/03/2014 14:02:12 ******/
ALTER TABLE [dbo].[KANTAR] ADD  CONSTRAINT [DF__KANTAR__ROWID__6FE99F9F]  DEFAULT (newid()) FOR [ROWID]
GO
