USE [Library_Management]
GO

CREATE TABLE [dbo].[Books](
	[book_ID] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](50) NOT NULL,
	[author] [nvarchar](50) NOT NULL,
	[availability] [bit] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[book_ID] ASC
)
)

CREATE TABLE [dbo].[Checkout](
	[checkout_ID] [int] IDENTITY(1,1) NOT NULL,
	[book_ID] [int] NOT NULL,
	[patron_ID] [int] NOT NULL,
	[checkout_Date] [date] NOT NULL,
	[due_Date] [date] NOT NULL,
 CONSTRAINT [PK_Checkout] PRIMARY KEY CLUSTERED 
(
	[checkout_ID] ASC
)
)

CREATE TABLE [dbo].[Patrons](
	[patron_ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](50) NOT NULL,
	[phone] [char](10) NOT NULL,
 CONSTRAINT [PK_Patrons] PRIMARY KEY CLUSTERED 
(
	[patron_ID] ASC
)
)

CREATE TABLE [dbo].[UserInfos](
	[user_ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[user_level] [int] NOT NULL,
 CONSTRAINT [PK_UserInfos] PRIMARY KEY CLUSTERED 
(
	[user_ID] ASC
)
)

ALTER TABLE [dbo].[Checkout] ADD CONSTRAINT [FK_Checkout_Books] FOREIGN KEY([book_ID]) REFERENCES [dbo].[Books] ([book_ID])

ALTER TABLE [dbo].[Checkout] ADD CONSTRAINT [FK_Checkout_Patrons] FOREIGN KEY([patron_ID]) REFERENCES [dbo].[Patrons] ([patron_ID])

INSERT INTO UserInfos
Values('admin', 'admin@?123', 'admin@email.com', 0)