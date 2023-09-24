USE [master]
GO
/****** Object:  Database [Library_Management]    Script Date: 9/24/2023 9:19:53 AM ******/
CREATE DATABASE [Library_Management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library_Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Library_Management.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Library_Management_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Library_Management] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library_Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library_Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library_Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library_Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library_Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library_Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library_Management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library_Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library_Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library_Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library_Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library_Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library_Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library_Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library_Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library_Management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library_Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library_Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library_Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library_Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library_Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library_Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library_Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library_Management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library_Management] SET  MULTI_USER 
GO
ALTER DATABASE [Library_Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library_Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library_Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library_Management] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library_Management] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library_Management] SET QUERY_STORE = OFF
GO
USE [Library_Management]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 9/24/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[book_ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](100) NOT NULL,
	[author] [nvarchar](50) NOT NULL,
	[publisher] [nchar](20) NULL,
	[ISBN] [int] NULL,
	[releaseDate] [date] NOT NULL,
	[genre] [nchar](10) NOT NULL,
	[condition] [char](10) NOT NULL,
	[availability] [char](10) NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[book_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Checkout]    Script Date: 9/24/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Checkout](
	[checkout_ID] [int] IDENTITY(1,1) NOT NULL,
	[book_ID] [int] NOT NULL,
	[patron_ID] [int] NOT NULL,
	[checkout_Date] [date] NOT NULL,
	[due_Date] [date] NOT NULL,
 CONSTRAINT [PK_Checkout] PRIMARY KEY CLUSTERED 
(
	[checkout_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patrons]    Script Date: 9/24/2023 9:19:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patrons](
	[patron_ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone] [int] NOT NULL,
 CONSTRAINT [PK_Patrons] PRIMARY KEY CLUSTERED 
(
	[patron_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Checkout]  WITH CHECK ADD  CONSTRAINT [FK_Checkout_Books] FOREIGN KEY([book_ID])
REFERENCES [dbo].[Books] ([book_ID])
GO
ALTER TABLE [dbo].[Checkout] CHECK CONSTRAINT [FK_Checkout_Books]
GO
ALTER TABLE [dbo].[Checkout]  WITH CHECK ADD  CONSTRAINT [FK_Checkout_Patrons] FOREIGN KEY([patron_ID])
REFERENCES [dbo].[Patrons] ([patron_ID])
GO
ALTER TABLE [dbo].[Checkout] CHECK CONSTRAINT [FK_Checkout_Patrons]
GO
USE [master]
GO
ALTER DATABASE [Library_Management] SET  READ_WRITE 
GO
