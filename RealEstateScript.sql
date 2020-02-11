USE [master]
GO
/****** Object:  Database [RealEstate]    Script Date: 2/11/2020 3:36:07 PM ******/
CREATE DATABASE [RealEstate]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RealEstate', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RealEstate.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RealEstate_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RealEstate_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RealEstate] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RealEstate].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RealEstate] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RealEstate] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RealEstate] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RealEstate] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RealEstate] SET ARITHABORT OFF 
GO
ALTER DATABASE [RealEstate] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RealEstate] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RealEstate] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RealEstate] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RealEstate] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RealEstate] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RealEstate] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RealEstate] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RealEstate] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RealEstate] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RealEstate] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RealEstate] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RealEstate] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RealEstate] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RealEstate] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RealEstate] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RealEstate] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RealEstate] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RealEstate] SET  MULTI_USER 
GO
ALTER DATABASE [RealEstate] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RealEstate] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RealEstate] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RealEstate] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RealEstate] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RealEstate]
GO
/****** Object:  Table [dbo].[Tbl_Client]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [varchar](200) NULL,
	[FatherName] [varchar](200) NULL,
	[Cnic] [varchar](20) NULL,
	[MobNo] [varchar](20) NULL,
	[PhoneNo] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Colony]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Colony](
	[ColonyId] [int] IDENTITY(1,1) NOT NULL,
	[ColonyName] [varchar](max) NULL,
	[Location] [varchar](max) NULL,
	[Area] [varchar](50) NULL,
	[OwnerName] [varchar](100) NULL,
	[FName] [varchar](100) NULL,
	[Cnic] [varchar](20) NULL,
	[Address] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ColonyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Partner]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Partner](
	[PartnerId] [int] IDENTITY(1,1) NOT NULL,
	[PartnerName] [varchar](100) NULL,
	[FName] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[Cnic] [varchar](20) NULL,
	[MobileNo] [varchar](20) NULL,
	[PhoneNo] [varchar](20) NULL,
	[Address] [varchar](max) NULL,
	[Amount] [decimal](18, 2) NULL DEFAULT ('0.00'),
PRIMARY KEY CLUSTERED 
(
	[PartnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Partner_Transaction]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Partner_Transaction](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[PartnerId] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
	[TransactionDate] [datetime] NULL,
	[Debit] [decimal](18, 2) NULL,
	[Credit] [decimal](18, 2) NULL,
	[Description] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Plot]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Plot](
	[PlotId] [int] IDENTITY(1,1) NOT NULL,
	[PlotNo] [int] NULL,
	[Size] [varchar](50) NULL,
	[PlotAmount] [decimal](18, 2) NULL,
	[Status] [varchar](20) NULL,
	[ColonyId] [int] NULL,
	[AmountOnInstall] [decimal](18, 2) NULL,
	[Area] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[PlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Sale]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Sale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[ContractId] [varchar](100) NULL,
	[ColonyId] [int] NULL,
	[PlotId] [int] NULL,
	[SaleStatus] [int] NULL,
	[SaleDate] [datetime] NULL,
	[NoOfMonth] [int] NULL DEFAULT ((0)),
	[MonthlyPayment] [decimal](18, 0) NULL,
	[DateOfPay] [int] NULL,
	[ClientId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_PartnerTransaction]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_PartnerTransaction]
AS
SELECT        dbo.Tbl_Partner_Transaction.TransactionId, dbo.Tbl_Partner_Transaction.PartnerId, dbo.Tbl_Partner.PartnerName, dbo.Tbl_Partner.FName, dbo.Tbl_Partner.Cnic, dbo.Tbl_Partner.MobileNo, dbo.Tbl_Partner.PhoneNo, 
                         dbo.Tbl_Partner_Transaction.TransactionDate, dbo.Tbl_Partner_Transaction.Description, dbo.Tbl_Partner_Transaction.Credit, dbo.Tbl_Partner_Transaction.Debit, dbo.Tbl_Partner_Transaction.Amount
FROM            dbo.Tbl_Partner INNER JOIN
                         dbo.Tbl_Partner_Transaction ON dbo.Tbl_Partner.PartnerId = dbo.Tbl_Partner_Transaction.PartnerId

GO
/****** Object:  View [dbo].[View_Plot]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Plot]
AS
SELECT        dbo.Tbl_Plot.PlotId, dbo.Tbl_Plot.PlotNo, dbo.Tbl_Plot.Area AS PlotArea, dbo.Tbl_Plot.Size, dbo.Tbl_Plot.PlotAmount AS Cash, dbo.Tbl_Colony.Area AS ColonyArea, dbo.Tbl_Plot.Status, dbo.Tbl_Plot.ColonyId, 
                         dbo.Tbl_Colony.ColonyName, dbo.Tbl_Plot.AmountOnInstall AS Installment
FROM            dbo.Tbl_Plot INNER JOIN
                         dbo.Tbl_Colony ON dbo.Tbl_Plot.ColonyId = dbo.Tbl_Colony.ColonyId

GO
SET IDENTITY_INSERT [dbo].[Tbl_Client] ON 

INSERT [dbo].[Tbl_Client] ([ClientId], [ClientName], [FatherName], [Cnic], [MobNo], [PhoneNo], [Email], [Address]) VALUES (1, N'Shoaib', N'Saleem', N'12101-5736186-1', N'0331-7602124', N'0966-733777', N'm.klose7@yahoo.com', N'Dera Ismail Khan')
INSERT [dbo].[Tbl_Client] ([ClientId], [ClientName], [FatherName], [Cnic], [MobNo], [PhoneNo], [Email], [Address]) VALUES (2, N'shamoon', N'', N'     -       -', N'    -', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[Tbl_Client] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Colony] ON 

INSERT [dbo].[Tbl_Colony] ([ColonyId], [ColonyName], [Location], [Area], [OwnerName], [FName], [Cnic], [Address]) VALUES (1, N'Gulsahan', N'D i Khan', N'50 Kanal .8 Marla', N'Ahmad', N'Khan', N'13131-0346131-6', N'D i khan')
SET IDENTITY_INSERT [dbo].[Tbl_Colony] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Partner] ON 

INSERT [dbo].[Tbl_Partner] ([PartnerId], [PartnerName], [FName], [Email], [Cnic], [MobileNo], [PhoneNo], [Address], [Amount]) VALUES (1, N'Salman', N'Khan', N'sal@gmail.com', N'13164-1034646-4', N'0346-7794134', N'0966-711444', N'D I Khan', CAST(42000.00 AS Decimal(18, 2)))
INSERT [dbo].[Tbl_Partner] ([PartnerId], [PartnerName], [FName], [Email], [Cnic], [MobileNo], [PhoneNo], [Address], [Amount]) VALUES (2, N'Shoaib Akhtar', N'Saleem Akhtar', N'm.klose7@yahoo.com', N'12100-5763186-3', N'0356-1564979', N'0966-711799', N'D I Khan', CAST(20000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tbl_Partner] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Partner_Transaction] ON 

INSERT [dbo].[Tbl_Partner_Transaction] ([TransactionId], [PartnerId], [Amount], [TransactionDate], [Debit], [Credit], [Description]) VALUES (1, 1, CAST(20000.00 AS Decimal(18, 2)), CAST(N'2020-02-07 16:47:00.953' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Tbl_Partner_Transaction] ([TransactionId], [PartnerId], [Amount], [TransactionDate], [Debit], [Credit], [Description]) VALUES (2, 1, CAST(22000.00 AS Decimal(18, 2)), CAST(N'2020-02-09 00:00:00.000' AS DateTime), CAST(2000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Debit')
INSERT [dbo].[Tbl_Partner_Transaction] ([TransactionId], [PartnerId], [Amount], [TransactionDate], [Debit], [Credit], [Description]) VALUES (3, 1, CAST(42000.00 AS Decimal(18, 2)), CAST(N'2020-02-10 00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Debit')
INSERT [dbo].[Tbl_Partner_Transaction] ([TransactionId], [PartnerId], [Amount], [TransactionDate], [Debit], [Credit], [Description]) VALUES (4, 2, CAST(20000.00 AS Decimal(18, 2)), CAST(N'2020-02-10 00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Debit')
SET IDENTITY_INSERT [dbo].[Tbl_Partner_Transaction] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Plot] ON 

INSERT [dbo].[Tbl_Plot] ([PlotId], [PlotNo], [Size], [PlotAmount], [Status], [ColonyId], [AmountOnInstall], [Area]) VALUES (1, 1, N'60x30', CAST(200000.00 AS Decimal(18, 2)), N'Available', 1, CAST(2200000.00 AS Decimal(18, 2)), N'7.2Marla')
INSERT [dbo].[Tbl_Plot] ([PlotId], [PlotNo], [Size], [PlotAmount], [Status], [ColonyId], [AmountOnInstall], [Area]) VALUES (2, 20, N'50 * 25', CAST(3000000.00 AS Decimal(18, 2)), N'Available', 1, CAST(3500000.00 AS Decimal(18, 2)), N'5 Marla')
SET IDENTITY_INSERT [dbo].[Tbl_Plot] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Sale] ON 

INSERT [dbo].[Tbl_Sale] ([SaleId], [ContractId], [ColonyId], [PlotId], [SaleStatus], [SaleDate], [NoOfMonth], [MonthlyPayment], [DateOfPay], [ClientId]) VALUES (1, N'CN-1-PL-1-Table', 1, 1, 1, CAST(N'2020-02-11 00:00:00.000' AS DateTime), 0, CAST(0 AS Decimal(18, 0)), 0, 1)
SET IDENTITY_INSERT [dbo].[Tbl_Sale] OFF
/****** Object:  StoredProcedure [dbo].[SP_ContractNo]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_ContractNo]
@ColonyId int,
@PlotId int
as
Begin
select  count(PlotId)+1 As PlotId from Tbl_Sale where ColonyId=@ColonyId 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TotalAmount_Update]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_TotalAmount_Update]
@Amount decimal,
@PartnerId int,
@Action int
As
Begin
if(@Action=1)
update Tbl_Partner set  Amount= Amount-@Amount where PartnerId=@PartnerId
else if(@Action=2)
update Tbl_Partner set  Amount= Amount+@Amount where PartnerId=@PartnerId
End
GO
/****** Object:  StoredProcedure [dbo].[SP_TransactionReport]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_TransactionReport]
@Cnic varchar(20)
as
begin
 select * from View_PartnerTransaction where Cnic=@Cnic
 end
GO
/****** Object:  StoredProcedure [dbo].[Transaction_AddNew]    Script Date: 2/11/2020 3:36:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Transaction_AddNew]
@TransactionId int
as
begin
select Top 1 max(isnull(TransactionId,0)+1) as TransactionId from Tbl_Partner_Transaction
end
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
         Begin Table = "Tbl_Partner"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "Tbl_Partner_Transaction"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 3
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PartnerTransaction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_PartnerTransaction'
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
         Begin Table = "Tbl_Plot"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Tbl_Colony"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 4
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
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Plot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Plot'
GO
USE [master]
GO
ALTER DATABASE [RealEstate] SET  READ_WRITE 
GO
