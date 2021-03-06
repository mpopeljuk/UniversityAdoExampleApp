USE [master]
GO
/****** Object:  Database [University]    Script Date: 20.02.2015 23:28:12 ******/
CREATE DATABASE [University]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'University', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS14\MSSQL\DATA\University2.mdf' , SIZE = 5184KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'University_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS14\MSSQL\DATA\University2_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [University] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University] SET ARITHABORT OFF 
GO
ALTER DATABASE [University] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [University] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University] SET  ENABLE_BROKER 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [University] SET  MULTI_USER 
GO
ALTER DATABASE [University] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [University] SET DELAYED_DURABILITY = DISABLED 
GO
USE [University]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 20.02.2015 23:28:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupToSubject]    Script Date: 20.02.2015 23:28:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupToSubject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 20.02.2015 23:28:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](250) NULL,
	[LastName] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[GroupId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 20.02.2015 23:28:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([Id], [Name]) VALUES (1, N'651')
INSERT [dbo].[Groups] ([Id], [Name]) VALUES (2, N'561')
INSERT [dbo].[Groups] ([Id], [Name]) VALUES (4, N'965')
INSERT [dbo].[Groups] ([Id], [Name]) VALUES (5, N'896')
INSERT [dbo].[Groups] ([Id], [Name]) VALUES (6, N'754')
INSERT [dbo].[Groups] ([Id], [Name]) VALUES (8, N'245')
SET IDENTITY_INSERT [dbo].[Groups] OFF
SET IDENTITY_INSERT [dbo].[GroupToSubject] ON 

INSERT [dbo].[GroupToSubject] ([Id], [GroupId], [SubjectId]) VALUES (1, 1, 1)
INSERT [dbo].[GroupToSubject] ([Id], [GroupId], [SubjectId]) VALUES (2, 1, 2)
INSERT [dbo].[GroupToSubject] ([Id], [GroupId], [SubjectId]) VALUES (3, 1, 4)
INSERT [dbo].[GroupToSubject] ([Id], [GroupId], [SubjectId]) VALUES (14, 1, 7)
INSERT [dbo].[GroupToSubject] ([Id], [GroupId], [SubjectId]) VALUES (4, 2, 3)
INSERT [dbo].[GroupToSubject] ([Id], [GroupId], [SubjectId]) VALUES (5, 2, 5)
SET IDENTITY_INSERT [dbo].[GroupToSubject] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (1, N'John', N'Doe', 24, 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (2, N'Jane', N'Doe', 22, 2)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (4, N'Harry', N'Potter', 26, 1)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (5, N'Mike', N'Love', 63, 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (6, N'King', N'James', 89, 4)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (8, N'Dorin', N'Mykaylo', 21, 6)
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [Age], [GroupId]) VALUES (9, N'Alex', N'Mitsan', 21, 8)
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (1, N'Math')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (2, N'Physics')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (3, N'IT')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (4, N'English')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (5, N'History')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (6, N'PT')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (7, N'Phyl')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
ALTER TABLE [dbo].[GroupToSubject]  WITH CHECK ADD  CONSTRAINT [fk_groups_subj] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupToSubject] CHECK CONSTRAINT [fk_groups_subj]
GO
ALTER TABLE [dbo].[GroupToSubject]  WITH CHECK ADD  CONSTRAINT [fk_subj_groups] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupToSubject] CHECK CONSTRAINT [fk_subj_groups]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [fk_groups] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [fk_groups]
GO
USE [master]
GO
ALTER DATABASE [University] SET  READ_WRITE 
GO
