USE [master]
GO
/****** Object:  Database [HomeCare]    Script Date: 5/26/2024 5:19:16 PM ******/
GO
ALTER DATABASE [HomeCare] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
DROP DATABASE [HomeCare]
CREATE DATABASE [HomeCare]
GO
ALTER DATABASE [HomeCare] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeCare].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeCare] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeCare] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeCare] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeCare] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeCare] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeCare] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeCare] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeCare] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeCare] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeCare] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeCare] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeCare] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeCare] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeCare] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeCare] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeCare] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeCare] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeCare] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeCare] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeCare] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeCare] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeCare] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeCare] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HomeCare] SET  MULTI_USER 
GO
ALTER DATABASE [HomeCare] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeCare] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeCare] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeCare] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HomeCare] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HomeCare] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HomeCare] SET QUERY_STORE = OFF
GO
USE [HomeCare]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[ManagerID] [int] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[CommentText] [nvarchar](500) NOT NULL,
	[CommentDate] [datetime] NOT NULL,
	[RequestID] [int] NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[DocumentName] [nvarchar](200) NOT NULL,
	[UploadDate] [datetime] NOT NULL,
	[DocumentType] [nvarchar](50) NOT NULL,
	[DocumentPath] [nvarchar](200) NOT NULL,
	[RequestID] [int] NOT NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[Source] [nvarchar](50) NOT NULL,
	[ExceptionType] [nvarchar](50) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Message] [nvarchar](50) NOT NULL,
	[OriginalValues] [nvarchar](50) NOT NULL,
	[CurrentValues] [nvarchar](50) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[NotificationText] [nvarchar](100) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](30) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Notifications] PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceRequests]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceRequests](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[RequestDescription] [nvarchar](1000) NULL,
	[RequestDate] [datetime] NOT NULL,
	[DateNeeded] [datetime] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[RequestStatus] [int] NOT NULL,
 CONSTRAINT [PK_ServiceRequests] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](50) NOT NULL,
	[ServiceDescription] [nvarchar](500) NULL,
	[ServicePrice] [money] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[TechnicianID] [int] NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Technicians_Services]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Technicians_Services](
	[TechnicianID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
 CONSTRAINT [PK_Technicians_Services] PRIMARY KEY CLUSTERED 
(
	[TechnicianID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/26/2024 5:19:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[UserRole] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [ManagerID]) VALUES (1, N'Cleaning', N'House cleaning services', 10)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [ManagerID]) VALUES (2, N'Plumbing', N'Plumbing services', 11)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [ManagerID]) VALUES (3, N'Electrical', N'Electrical repair services', 12)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description], [ManagerID]) VALUES (4, N'Plane', N'Plane Maintainace', 13)
SET IDENTITY_INSERT [dbo].[Categories] OFF

GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDescription], [ServicePrice], [CategoryID], [TechnicianID]) VALUES (1, N'Basic Cleaning', N'Basic house cleaning service', 100.0000, 1, NULL)
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDescription], [ServicePrice], [CategoryID], [TechnicianID]) VALUES (2, N'Drain Cleaning', N'Clearing clogged drains', 150.0000, 2, NULL)
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDescription], [ServicePrice], [CategoryID], [TechnicianID]) VALUES (3, N'Wire Fixing', N'Restore Wires Capability', 150.0000, 3, NULL)
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDescription], [ServicePrice], [CategoryID], [TechnicianID]) VALUES (4, N'Basic Install', N'Install Quality Wings', 69.0000, 4, NULL)
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
INSERT [dbo].[Technicians_Services] ([TechnicianID], [ServiceID]) VALUES (5, 1)
INSERT [dbo].[Technicians_Services] ([TechnicianID], [ServiceID]) VALUES (6, 2)
GO

SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (1, N'admin@test.com', N'Test@123', N'admin@test.com', N'Admin', N'Florentino', N'Perez')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (2, N'user1@example.com', N'Test@123', N'user1@example.com', N'Customer', N'Jane', N'Doe')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (3, N'user2@example.com', N'Test@123', N'user2@example.com', N'Customer', N'Jim', N'Beam')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (4, N'user3@example.com', N'Test@123', N'user3@example.com', N'Customer', N'Jack', N'Daniels')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (5, N'tech1@test.com', N'Test@123', N'tech1@test.com', N'Technician', N'Johnny', N'Walker')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (6, N'tech2@test.com', N'Test@123', N'tech2@test.com', N'Technician', N'Sam', N'Johnson')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (7, N'tech3@test.com', N'Test@123', N'tech3@test.com', N'Technician', N'Cristiano', N'Ronaldo')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (8, N'tech4@test.com', N'Test@123', N'tech4@test.com', N'Technician', N'Hasan', N'Shehab')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (9, N'tech5@test.com', N'Test@123', N'tech5@test.com', N'Technician', N'Steve', N'Jobs')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (10, N'manager1@test.com', N'Test@123', N'manager1@test.com', N'Manager', N'John', N'Wick')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (11, N'manager2@test.com', N'Test@123', N'manager2@test.com', N'Manager', N'Peter', N'Parker')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (12, N'manager3@test.com', N'Test@123', N'manager3@test.com', N'Manager', N'Leo', N'Messi')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [Email], [UserRole], [FirstName], [LastName]) VALUES (13, N'manager4@test.com', N'Test@123', N'manager4@test.com', N'Manager', N'Kratos', N'Zues')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[ServiceRequests] ADD  CONSTRAINT [DF_ServiceRequests_RequestStatus]  DEFAULT ((1)) FOR [RequestStatus]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Users] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Users]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_ServiceRequests] FOREIGN KEY([RequestID])
REFERENCES [dbo].[ServiceRequests] ([RequestID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_ServiceRequests]
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_ServiceRequests] FOREIGN KEY([RequestID])
REFERENCES [dbo].[ServiceRequests] ([RequestID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_ServiceRequests]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Users]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_Notifications_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_Notifications_Users]
GO
ALTER TABLE [dbo].[ServiceRequests]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRequests_Services] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ServiceID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ServiceRequests] CHECK CONSTRAINT [FK_ServiceRequests_Services]
GO
ALTER TABLE [dbo].[ServiceRequests]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRequests_Users] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[ServiceRequests] CHECK CONSTRAINT [FK_ServiceRequests_Users]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_Users] FOREIGN KEY([TechnicianID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_Users]
GO
ALTER TABLE [dbo].[Technicians_Services]  WITH CHECK ADD  CONSTRAINT [FK_Technicians_Services_Services] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ServiceID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Technicians_Services] CHECK CONSTRAINT [FK_Technicians_Services_Services]
GO
ALTER TABLE [dbo].[Technicians_Services]  WITH CHECK ADD  CONSTRAINT [FK_Technicians_Services_Users] FOREIGN KEY([TechnicianID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Technicians_Services] CHECK CONSTRAINT [FK_Technicians_Services_Users]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_Categories]
GO
USE [master]
GO
ALTER DATABASE [HomeCare] SET  READ_WRITE 
GO
