USE [master]
GO
/****** Object:  Database [SearchSystem]    Script Date: 4/9/2019 23:09:24 ******/
CREATE DATABASE [SearchSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SearchSystem', FILENAME = N'D:\sql\MSSQL14.MSSQLSERVER\MSSQL\DATA\SearchSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SearchSystem_log', FILENAME = N'D:\sql\MSSQL14.MSSQLSERVER\MSSQL\DATA\SearchSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SearchSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SearchSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SearchSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SearchSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SearchSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SearchSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [SearchSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SearchSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SearchSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SearchSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SearchSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SearchSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SearchSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SearchSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SearchSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SearchSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SearchSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SearchSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SearchSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SearchSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SearchSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SearchSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SearchSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SearchSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [SearchSystem] SET  MULTI_USER 
GO
ALTER DATABASE [SearchSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SearchSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SearchSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SearchSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SearchSystem', N'ON'
GO
USE [SearchSystem]
GO
/****** Object:  Table [dbo].[BloodGroup]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodGroup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EyeColor]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EyeColor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaritalStatus]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaritalStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MilitaryStatus]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MilitaryStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nationality]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationality](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](70) NOT NULL,
	[LastName] [nvarchar](70) NOT NULL,
	[FatherName] [nvarchar](70) NULL,
	[BirthPlace] [nvarchar](70) NULL,
	[BirthofDate] [date] NULL,
	[GenderID] [int] NULL,
	[NationalityID] [int] NULL,
	[MaritalStatusID] [int] NULL,
	[Height] [tinyint] NULL,
	[MilitaryStatusID] [int] NULL,
	[EyeColorID] [int] NULL,
	[BloodGroupID] [int] NULL,
	[LivingPlace] [nvarchar](200) NULL,
	[IssueDate] [date] NOT NULL,
	[ExpiryDate] [date] NULL,
	[Series] [varchar](20) NOT NULL,
	[Number] [varchar](9) NOT NULL,
	[IssuingAuthority] [nvarchar](250) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/9/2019 23:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[RoleID] [int] NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BloodGroup] ON 

INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (1, N'I-', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (2, N'I+', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (3, N'II-', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (4, N'II+', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (5, N'III-', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (6, N'III+', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (7, N'IV-', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (8, N'IV+', NULL)
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (9, N'I+', CAST(N'2019-04-05T00:42:43.073' AS DateTime))
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (10, N'I+', CAST(N'2019-04-05T00:42:37.187' AS DateTime))
INSERT [dbo].[BloodGroup] ([ID], [Value], [DeletedDate]) VALUES (11, N'9+', CAST(N'2019-04-08T16:34:00.270' AS DateTime))
SET IDENTITY_INSERT [dbo].[BloodGroup] OFF
SET IDENTITY_INSERT [dbo].[EyeColor] ON 

INSERT [dbo].[EyeColor] ([ID], [ColorName], [DeletedDate]) VALUES (1, N'Blue', NULL)
INSERT [dbo].[EyeColor] ([ID], [ColorName], [DeletedDate]) VALUES (2, N'Black', NULL)
INSERT [dbo].[EyeColor] ([ID], [ColorName], [DeletedDate]) VALUES (3, N'Green', NULL)
INSERT [dbo].[EyeColor] ([ID], [ColorName], [DeletedDate]) VALUES (4, N'Gray', NULL)
INSERT [dbo].[EyeColor] ([ID], [ColorName], [DeletedDate]) VALUES (5, N'orange', CAST(N'2019-04-05T00:52:22.177' AS DateTime))
SET IDENTITY_INSERT [dbo].[EyeColor] OFF
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([ID], [Name], [DeletedDate]) VALUES (1, N'Male', NULL)
INSERT [dbo].[Gender] ([ID], [Name], [DeletedDate]) VALUES (2, N'Female', NULL)
SET IDENTITY_INSERT [dbo].[Gender] OFF
SET IDENTITY_INSERT [dbo].[MaritalStatus] ON 

INSERT [dbo].[MaritalStatus] ([ID], [Name], [DeletedDate]) VALUES (1, N'Single', NULL)
INSERT [dbo].[MaritalStatus] ([ID], [Name], [DeletedDate]) VALUES (2, N'Married', NULL)
INSERT [dbo].[MaritalStatus] ([ID], [Name], [DeletedDate]) VALUES (3, N'Engaged', CAST(N'2019-04-05T16:54:36.150' AS DateTime))
SET IDENTITY_INSERT [dbo].[MaritalStatus] OFF
SET IDENTITY_INSERT [dbo].[MilitaryStatus] ON 

INSERT [dbo].[MilitaryStatus] ([ID], [Name], [DeletedDate]) VALUES (1, N'Yes', NULL)
INSERT [dbo].[MilitaryStatus] ([ID], [Name], [DeletedDate]) VALUES (2, N'No', NULL)
INSERT [dbo].[MilitaryStatus] ([ID], [Name], [DeletedDate]) VALUES (3, N'Not Yet', CAST(N'2019-04-05T01:21:44.733' AS DateTime))
SET IDENTITY_INSERT [dbo].[MilitaryStatus] OFF
SET IDENTITY_INSERT [dbo].[Nationality] ON 

INSERT [dbo].[Nationality] ([ID], [Name], [DeletedDate]) VALUES (1, N'Azerbaijan', NULL)
INSERT [dbo].[Nationality] ([ID], [Name], [DeletedDate]) VALUES (2, N'English', NULL)
INSERT [dbo].[Nationality] ([ID], [Name], [DeletedDate]) VALUES (3, N'Turkish', NULL)
INSERT [dbo].[Nationality] ([ID], [Name], [DeletedDate]) VALUES (4, N'Georgian12yjftyff', CAST(N'2019-04-05T00:11:00.070' AS DateTime))
SET IDENTITY_INSERT [dbo].[Nationality] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (2, N'Ali', N'Veliyev', N'Samir', N'Baku', CAST(N'1987-11-12' AS Date), 1, 2, 1, 176, 2, 3, 6, N'Baku', CAST(N'2019-04-04' AS Date), CAST(N'2029-04-04' AS Date), N'123456789', N'1241231', N'BDP', CAST(N'2019-04-06T00:19:10.447' AS DateTime))
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (3, N'Orxan', N'Babayev', N'Kenan', N'Sumqayit', CAST(N'1990-01-30' AS Date), 2, 3, 1, 112, 2, 3, 7, N'Baku', CAST(N'2019-04-05' AS Date), CAST(N'2019-05-31' AS Date), N'213', N'134134', N'Baku Police', NULL)
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (4, N'Kanan', N'Kamranov', N'Kamran', N'Agsu', CAST(N'2012-04-08' AS Date), 1, 1, 1, 167, 1, 1, 1, N'Agsu', CAST(N'2019-04-05' AS Date), CAST(N'2022-04-14' AS Date), N'234', N'356', N'Agsu Police', NULL)
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (5, N'Orxan', N'Aliyev', N'Huseyn', N'Naxcivan', CAST(N'1990-06-04' AS Date), 1, 1, 1, 176, 1, 1, 1, N'Baku', CAST(N'2019-04-06' AS Date), CAST(N'2022-12-22' AS Date), N'253245', N'245246', N'Baku Police', NULL)
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (6, N'Aytac', N'Mahmudlu', N'Vusal', N'Baku', CAST(N'1990-07-11' AS Date), 2, 3, 1, 167, 2, 3, 7, N'Baku', CAST(N'2019-04-06' AS Date), CAST(N'2019-05-11' AS Date), N'1414', N'31413', N'Baku Police', NULL)
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (7, N'Orxan', N'Babayev', N'Kenan', N'Sumqayit', CAST(N'1990-01-30' AS Date), 1, 1, 1, 112, 1, 1, 1, N'Baku', CAST(N'2019-04-05' AS Date), CAST(N'2019-05-31' AS Date), N'213', N'134134', N'Baku Police', CAST(N'2019-04-07T20:25:15.157' AS DateTime))
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (8, N'gfdtdtd', N'jgcghg', N'', N'Baku', CAST(N'2015-05-18' AS Date), 1, 1, 1, 186, 2, 4, 3, N'Baku', CAST(N'2019-04-08' AS Date), CAST(N'2024-03-06' AS Date), N'87087', N'476486', N'Baku Police', CAST(N'2019-04-09T21:20:23.193' AS DateTime))
INSERT [dbo].[Person] ([ID], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthofDate], [GenderID], [NationalityID], [MaritalStatusID], [Height], [MilitaryStatusID], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (9, N'Aysel', N'Aliyev', N'Faiq', N'Baku', CAST(N'1990-04-04' AS Date), 2, 1, 2, 154, 2, 3, 5, N'Baku', CAST(N'2019-04-09' AS Date), CAST(N'2019-11-13' AS Date), N'2452', N'23524', N'Baku Police', NULL)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [Name], [DeletedDate]) VALUES (1, N'Admin', NULL)
INSERT [dbo].[Role] ([ID], [Name], [DeletedDate]) VALUES (2, N'Operator', NULL)
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (1, N'alakbar@code.az', N'i?uy????@??Ku$?9???-????MG?', 1, NULL)
INSERT [dbo].[User] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (2, N'Iqbal@code.az', N'????G?;U??r???pKb???0??Y????', 2, NULL)
INSERT [dbo].[User] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (3, N'Cavid', N'-K?#;????l2?g?d??H????m???U?', 2, CAST(N'2019-04-06T02:16:17.103' AS DateTime))
INSERT [dbo].[User] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (4, N'Vusal', N'??9?_???M?	?%?M?????a??b?L???R?', 1, NULL)
INSERT [dbo].[User] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (5, N'12', N'kQ?1?]??????=?a???f>????', 2, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([BloodGroupID])
REFERENCES [dbo].[BloodGroup] ([ID])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([EyeColorID])
REFERENCES [dbo].[EyeColor] ([ID])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([GenderID])
REFERENCES [dbo].[Gender] ([ID])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([MaritalStatusID])
REFERENCES [dbo].[MaritalStatus] ([ID])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([MilitaryStatusID])
REFERENCES [dbo].[MilitaryStatus] ([ID])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([NationalityID])
REFERENCES [dbo].[Nationality] ([ID])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
USE [master]
GO
ALTER DATABASE [SearchSystem] SET  READ_WRITE 
GO
