USE [master]
GO
/****** Object:  Database [WorldIsAwesome] ******/
CREATE DATABASE [WorldIsAwesome]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WorldIsAwesome', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WorldIsAwesome.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WorldIsAwesome_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WorldIsAwesome.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WorldIsAwesome] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorldIsAwesome].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorldIsAwesome] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorldIsAwesome] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorldIsAwesome] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorldIsAwesome] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorldIsAwesome] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WorldIsAwesome] SET  MULTI_USER 
GO
ALTER DATABASE [WorldIsAwesome] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorldIsAwesome] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WorldIsAwesome] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WorldIsAwesome] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WorldIsAwesome] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WorldIsAwesome] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WorldIsAwesome] SET QUERY_STORE = OFF
GO
USE [WorldIsAwesome]
GO
/****** Object:  Table [dbo].[Users_ExperiencesToDo] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_ExperiencesToDo](
	[ExperienceId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Users_ExperiencesToDo] PRIMARY KEY CLUSTERED 
(
	[ExperienceId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Experiences] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Experiences](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[Time] [time](7) NULL,
	[MorningNightEnum] [int] NULL,
	[MediaFileId] [uniqueidentifier] NULL,
	[PlaceId] [uniqueidentifier] NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[DateTimeCreated] [datetimeoffset](7) NOT NULL,
	[PrivacyLevel] [int] NULL,
	[StatusEnum] [int] NOT NULL,
 CONSTRAINT [PK_Experiences] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Files] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Files](
	[Id] [uniqueidentifier] NOT NULL,
	[FileName] [varchar](100) NOT NULL,
	[FileType] [varchar](100) NOT NULL,
	[FileCreated] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_Files] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ExperienceFiles] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ExperienceFiles]
AS
SELECT e.Id AS ExperienceId, e.Name AS ExperienceName, e.MorningNightEnum AS ExperienceMorningNightEnum, e.PrivacyLevel AS ExperiencePrivacyLevel, e.StatusEnum AS ExperienceStatusEnum, e.PlaceId, e.UserId, f.Id AS FileId, 
                  f.FileName, f.FileType, ue.UserId AS UserToDo
FROM     dbo.Experiences AS e INNER JOIN
                  dbo.Files AS f ON e.MediaFileId = f.Id LEFT OUTER JOIN
                  dbo.Users_ExperiencesToDo AS ue ON ue.ExperienceId = e.Id
GO
/****** Object:  Table [dbo].[Places] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Latitude] [decimal](10, 8) NOT NULL,
	[Longitude] [decimal](11, 8) NOT NULL,
	[ProfilePictureFileId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_PlaceExperiences] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*GROUP BY p.Id, p.Name, p.Description, p.Latitude, p.Longitude*/
CREATE VIEW [dbo].[View_PlaceExperiences]
AS
SELECT p.Id AS PlaceId, p.Name AS PlaceName, p.Description AS PlaceDescription, p.Latitude AS PlaceLatitude, p.Longitude AS PlaceLongitude, p.ProfilePictureFileId AS PlaceProfilePictureFileId, e.UserId, e.Id AS ExperienceId, 
                  e.Name AS ExperienceName, e.Description AS ExperienceDescription, e.Date AS ExperienceDate, e.Time AS ExperienceTime, e.DateTimeCreated AS ExperienceDateTimeCreated, e.MorningNightEnum AS ExperienceMorningNightEnum, 
                  e.MediaFileId AS ExperienceMediaFileId, e.PrivacyLevel AS ExperiencePrivacyLevel, e.StatusEnum AS ExperienceStatusEnum, ue.UserId AS UserToDo
FROM     dbo.Places AS p INNER JOIN
                  dbo.Experiences AS e ON e.PlaceId = p.Id LEFT OUTER JOIN
                  dbo.Users_ExperiencesToDo AS ue ON ue.ExperienceId = e.Id
GO
/****** Object:  Table [dbo].[Users] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[Nickname] [nvarchar](100) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Surname] [varchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[BirthDate] [date] NULL,
	[ProfilePhotoFileId] [uniqueidentifier] NULL,
	[Mail] [varchar](100) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[LastAccess] [datetimeoffset](7) NULL,
	[ResidencePlaceId] [uniqueidentifier] NULL,
	[StatusEnum] [int] NOT NULL,
	[RegistrationDateTime] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Users] UNIQUE NONCLUSTERED 
(
	[Nickname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Users_1] UNIQUE NONCLUSTERED 
(
	[Mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_UsersFriends] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_UsersFriends](
	[UserId] [uniqueidentifier] NOT NULL,
	[UserFriendId] [uniqueidentifier] NOT NULL,
	[StatusEnum] [int] NOT NULL,
	[RequestedDateTime] [datetimeoffset](7) NOT NULL,
	[AcceptedDateTime] [datetimeoffset](7) NULL,
 CONSTRAINT [PK_Users_UsersFriends] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[UserFriendId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Experiences]  WITH NOCHECK ADD  CONSTRAINT [FK_Experiences_Files] FOREIGN KEY([MediaFileId])
REFERENCES [dbo].[Files] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Experiences] NOCHECK CONSTRAINT [FK_Experiences_Files]
GO
ALTER TABLE [dbo].[Experiences]  WITH NOCHECK ADD  CONSTRAINT [FK_Experiences_Places] FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Places] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Experiences] NOCHECK CONSTRAINT [FK_Experiences_Places]
GO
ALTER TABLE [dbo].[Experiences]  WITH NOCHECK ADD  CONSTRAINT [FK_Experiences_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Experiences] NOCHECK CONSTRAINT [FK_Experiences_Users]
GO
ALTER TABLE [dbo].[Places]  WITH CHECK ADD  CONSTRAINT [FK_Places_Files] FOREIGN KEY([ProfilePictureFileId])
REFERENCES [dbo].[Files] ([Id])
GO
ALTER TABLE [dbo].[Places] CHECK CONSTRAINT [FK_Places_Files]
GO
ALTER TABLE [dbo].[Users]  WITH NOCHECK ADD  CONSTRAINT [FK_Users_Files] FOREIGN KEY([ProfilePhotoFileId])
REFERENCES [dbo].[Files] ([Id])
GO
ALTER TABLE [dbo].[Users] NOCHECK CONSTRAINT [FK_Users_Files]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Places] FOREIGN KEY([ResidencePlaceId])
REFERENCES [dbo].[Places] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Places]
GO
ALTER TABLE [dbo].[Users_ExperiencesToDo]  WITH CHECK ADD  CONSTRAINT [FK_Users_ExperiencesToDo_Experiences] FOREIGN KEY([ExperienceId])
REFERENCES [dbo].[Experiences] ([Id])
GO
ALTER TABLE [dbo].[Users_ExperiencesToDo] CHECK CONSTRAINT [FK_Users_ExperiencesToDo_Experiences]
GO
ALTER TABLE [dbo].[Users_ExperiencesToDo]  WITH CHECK ADD  CONSTRAINT [FK_Users_ExperiencesToDo_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Users_ExperiencesToDo] CHECK CONSTRAINT [FK_Users_ExperiencesToDo_Users]
GO
ALTER TABLE [dbo].[Users_UsersFriends]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersFriends_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Users_UsersFriends] CHECK CONSTRAINT [FK_Users_UsersFriends_Users]
GO
ALTER TABLE [dbo].[Users_UsersFriends]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersFriends_Users1] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Users_UsersFriends] CHECK CONSTRAINT [FK_Users_UsersFriends_Users1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "e"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "f"
            Begin Extent = 
               Top = 6
               Left = 272
               Bottom = 119
               Right = 442
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ue"
            Begin Extent = 
               Top = 7
               Left = 490
               Bottom = 126
               Right = 684
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ExperienceFiles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_ExperienceFiles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "p"
            Begin Extent = 
               Top = 6
               Left = 480
               Bottom = 136
               Right = 650
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 298
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "ue"
            Begin Extent = 
               Top = 7
               Left = 698
               Bottom = 126
               Right = 892
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1356
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PlaceExperiences'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PlaceExperiences'
GO
USE [master]
GO
ALTER DATABASE [WorldIsAwesome] SET  READ_WRITE 
GO
