USE [master]
GO
/****** Object:  Database [ProjectIdentityDB]    Script Date: 5/28/2024 10:20:05 PM ******/
CREATE DATABASE [ProjectIdentityDB]
GO
ALTER DATABASE [ProjectIdentityDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectIdentityDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectIdentityDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProjectIdentityDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectIdentityDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectIdentityDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProjectIdentityDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectIdentityDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProjectIdentityDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectIdentityDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectIdentityDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectIdentityDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectIdentityDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectIdentityDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjectIdentityDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjectIdentityDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProjectIdentityDB] SET QUERY_STORE = OFF
GO
USE [ProjectIdentityDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/28/2024 10:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/28/2024 10:20:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240427121232_InitialPush', N'6.0.29')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'15d63a6e-c4ad-4a4b-a55d-2a55a69ac45c', N'Admin', N'ADMIN', N'7930bbac-049b-4e44-b185-843b5026f166')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3a0c5827-6fa0-4999-bf30-c282f7c90446', N'User', N'USER', N'c7098687-efeb-4fe4-8157-944b31403364')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4240b14f-3c30-4bbe-8e68-f54ea4d5cef7', N'Manager', N'MANAGER', N'393783e8-0481-444c-87c1-6462723f47dd')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e8714079-d147-49fd-8877-3d33b0da7e38', N'Technician', N'TECHNICIAN', N'fd71f8f8-b630-4f75-8c0b-1eb4407557c8')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dc73524f-1c2d-4311-b61f-6c4249b27c1f', N'15d63a6e-c4ad-4a4b-a55d-2a55a69ac45c')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9ed3db0d-3e97-414d-8c11-0ce880d69eef', N'3a0c5827-6fa0-4999-bf30-c282f7c90446')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac9a15ba-cefb-468f-bed9-5a268a0b1cbf', N'3a0c5827-6fa0-4999-bf30-c282f7c90446')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b3ce2592-edc0-49e0-a81a-76105ad466c0', N'3a0c5827-6fa0-4999-bf30-c282f7c90446')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'011ea0c7-ec3f-42eb-b3ae-a74d0c4f5ea5', N'4240b14f-3c30-4bbe-8e68-f54ea4d5cef7')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6e1737ec-5c35-48bc-a260-f088f3a331a3', N'4240b14f-3c30-4bbe-8e68-f54ea4d5cef7')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c890eeba-14b5-4477-9cc4-e4adf89e3a67', N'4240b14f-3c30-4bbe-8e68-f54ea4d5cef7')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dbb9b07e-76c3-4554-b3d4-b6647fdcb705', N'4240b14f-3c30-4bbe-8e68-f54ea4d5cef7')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f3fe42ab-5bed-4183-886d-d58d40fd01fe', N'4240b14f-3c30-4bbe-8e68-f54ea4d5cef7')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96110a8c-5cd2-42d0-8db6-61a7b0794904', N'e8714079-d147-49fd-8877-3d33b0da7e38')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'beb64a4f-5f52-4391-8d56-d95218f6fb8b', N'e8714079-d147-49fd-8877-3d33b0da7e38')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'011ea0c7-ec3f-42eb-b3ae-a74d0c4f5ea5', N'manager3@test.com', N'MANAGER3@TEST.COM', N'manager3@test.com', N'MANAGER3@TEST.COM', 0, N'AQAAAAEAACcQAAAAEKE8UMJwU0wFO+kSb8jMY1lQyln+uE4DWpvJVLfpKUfQeYS/f0vfS66dMARnZbDiEw==', N'S6GAJQTHKEIHVWK4ODULG6XX5S6XTSLV', N'56ea4177-aa7c-4f9f-b145-975e13ea5231', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'6e1737ec-5c35-48bc-a260-f088f3a331a3', N'manager4@test.com', N'MANAGER4@TEST.COM', N'manager4@test.com', N'MANAGER4@TEST.COM', 0, N'AQAAAAEAACcQAAAAEEGsa36xZuHJE+uZKWktrDJaRF+7i9FUpWUswJGQ9LjjvR6L5l3aWdpDAeVLa5O6JA==', N'XZNPQFAQ2HRQQUI66YCOGWWFHPSAOLJA', N'e5dad235-727b-48d8-b4d5-ee89ff6b8d75', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'96110a8c-5cd2-42d0-8db6-61a7b0794904', N'tech2@test.com', N'TECH2@TEST.COM', N'tech2@test.com', N'TECH2@TEST.COM', 1, N'AQAAAAEAACcQAAAAEJ3ddz7NOrqcrlyNzg1qYnduD5FrPF2b1TY8ShHd/sIBUJ6i3izZY0ARntGwuB3haA==', N'JRIGAYDCNOYJ7XJNKAHSD2BHITNW27HA', N'0e8ec0d9-7552-4337-abe3-05fc6ca01360', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9ed3db0d-3e97-414d-8c11-0ce880d69eef', N'user1@test.com', N'USER1@TEST.COM', N'user1@test.com', N'USER1@TEST.COM', 1, N'AQAAAAEAACcQAAAAEAVnYjACUtmFZMzOKigVkGTkZbELCVM8BL8p8xN7UqApAY0As39wHjjVE3t+k7Ks+g==', N'ZXZD56DPOVMF6FXKOBL5QWBLCGLWQXUO', N'64a09c57-0a47-4abe-84d0-825c03bfd587', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ac9a15ba-cefb-468f-bed9-5a268a0b1cbf', N'user2@test.com', N'USER2@TEST.COM', N'user2@test.com', N'USER2@TEST.COM', 1, N'AQAAAAEAACcQAAAAEOvInsPmSpFTN7FmYrwkErMGtfrVIIhDkZ4Rp75KOsD6sJvVrx/TJVqsY2JVPcMNtA==', N'EZXEFN3BM5J42NR6PQA4UKIB4QJXVZ6Z', N'29f8ea3f-3f84-4cb1-babf-be6ad2a78713', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b3ce2592-edc0-49e0-a81a-76105ad466c0', N'user3@test.com', N'USER3@TEST.COM', N'user3@test.com', N'USER3@TEST.COM', 1, N'AQAAAAEAACcQAAAAEPNBiDb4S1WVJzYtskU84FE2GWmBTLbbHV6fhQFwZ3/8S37ppine+Gz3ud5otvUwag==', N'6I2RQWV4ZJ55DONJPIAGITHZRAF6HFBZ', N'0188da3c-ff22-47d9-9b48-4b31371a0074', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'beb64a4f-5f52-4391-8d56-d95218f6fb8b', N'tech1@test.com', N'TECH1@TEST.COM', N'tech1@test.com', N'TECH1@TEST.COM', 1, N'AQAAAAEAACcQAAAAELEsbBZMFIICyDbKf3kK4Ai22ZNzoNsM9Pze1y42dZJCSOXTwRdNTbVYL5X9kDQddg==', N'FEHQV54RXXATLZIQT5WPZIOLGE6F4CJZ', N'b59e3820-063f-4175-9429-2c5d95af5710', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c890eeba-14b5-4477-9cc4-e4adf89e3a67', N'manager1@test.com', N'MANAGER1@TEST.COM', N'manager1@test.com', N'MANAGER1@TEST.COM', 0, N'AQAAAAEAACcQAAAAEDAEMvlX/9pnR02XpaHOo/Tp59t5/F5uJH2o4e5wXJNBxtEHH6tbWY/ML17SayS28Q==', N'LCFSDRSQW4DHMYJIVFO422RJG2M6IN2F', N'94ae26a2-2787-492f-81ae-1fa4276bd1b3', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'dbb9b07e-76c3-4554-b3d4-b6647fdcb705', N'manager@test.com', N'MANAGER@TEST.COM', N'manager@test.com', N'MANAGER@TEST.COM', 1, N'AQAAAAEAACcQAAAAEJ8BZkdpARA/hxb9kKeMZ87eeXEr04AiosQoe0e5nTgIViAI1gzAYfy7AdG2WvhBlw==', N'YOYGOXY7OJH2MN35ZERWX4DXLKB2SRCC', N'add890a9-587f-4e3f-9390-1984d7b626e7', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'dc73524f-1c2d-4311-b61f-6c4249b27c1f', N'admin@test.com', N'ADMIN@TEST.COM', N'admin@test.com', N'ADMIN@TEST.COM', 1, N'AQAAAAEAACcQAAAAEEQdJmP0aETlQUz5tUlmg5avSR8rOR7M5f5SbgZoQ2svJNDSFwFVBua9BOTwOHI+IQ==', N'7APV3OMCABVKSF6PEWHWD2DGXT5FASUS', N'ecb2ff89-8aae-43e0-8dc5-38bbf740349a', NULL, 1, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f3fe42ab-5bed-4183-886d-d58d40fd01fe', N'manager2@test.com', N'MANAGER2@TEST.COM', N'manager2@test.com', N'MANAGER2@TEST.COM', 0, N'AQAAAAEAACcQAAAAEG526zkNnpq+1Xtk2rk8xkmuQen7anAuNIhdXh2oznxAB2yOzVc2QrmmQuXIvTibiA==', N'VXB4YQVWQKKXDDUDVY5SX6H3HWLAX6XW', N'c0204127-642f-45dd-8acf-d5f013d4a55b', NULL, 0, 0, NULL, 1, 0)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/28/2024 10:20:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [ProjectIdentityDB] SET  READ_WRITE 
GO
