﻿--use master 
--go

--create database [RestaurantManagement]
--go

use [RestaurantManagement]
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL

 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_InvoiceInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_FoodStuffs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL, 
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Account] ([AccountName], [Password]) VALUES (N'levantuan', N'123')
INSERT [dbo].[Account] ([AccountName], [Password]) VALUES (N'nguyenminhquan', N'123')
INSERT [dbo].[Account] ([AccountName], [Password]) VALUES (N'tranhuuloc', N'123')
INSERT [dbo].[Account] ([AccountName], [Password]) VALUES (N'nguyenthiennhan', N'123')
INSERT [dbo].[Account] ([AccountName], [Password]) VALUES (N'letanphat', N'123')

SET IDENTITY_INSERT [dbo].[BillDetails] ON 
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 2, 1)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (3, 1, 3, 1)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (4, 1, 4, 1)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (5, 1, 5, 1)
SET IDENTITY_INSERT [dbo].[BillDetails] OFF

SET IDENTITY_INSERT [dbo].[Bills] ON 
INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Status],[CheckoutDate], [Account]) VALUES (1, N'Hóa đơn 1', 5, 410000, 1,null, N'levantuan')
SET IDENTITY_INSERT [dbo].[Bills] OFF

SET IDENTITY_INSERT [dbo].[Category] ON 
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai vị', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'Món chính', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'Hải sản', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'Món chay', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Tráng miệng', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF

SET IDENTITY_INSERT [dbo].[Food] ON 
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (1, N'Gỏi cuốn', 1, 20000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (1, N'Bún đậu mắm tôm', 1, 100000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (2, N'Soup', 1, 30000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (3, N'Thịt bò xào', 2, 150000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (4, N'Gà nướng', 2, 10000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (5, N'Tôm rang muối', 3, 200000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (6, N'Càng cua hấp', 3, 300000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (7, N'Rau muống xào tỏi', 4, 30000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (8, N'Đậu phụ xả ớt', 4, 25000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (9, N'Pudding', 5, 23000)
INSERT [dbo].[Food] ([ID], [Name], [FoodCategoryID], [Price]) VALUES (10, N'Plan', 5, 20000)
SET IDENTITY_INSERT [dbo].[Food] OFF

SET IDENTITY_INSERT [dbo].[Role] ON 
INSERT [dbo].[Role] ([ID], [RoleName]) VALUES (1, N'Adminstrator')
INSERT [dbo].[Role] ([ID], [RoleName]) VALUES (2, N'Staff')
SET IDENTITY_INSERT [dbo].[Role] OFF

INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived]) VALUES (1, N'levantuan', 1)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived]) VALUES (2, N'tranhuuloc', 1)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived]) VALUES (2, N'nguyenthiennhan', 1)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived]) VALUES (2, N'nguyenminhquan', 1)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived]) VALUES (2, N'letanphat', 1)

SET IDENTITY_INSERT [dbo].[Table] ON 
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (1, N'01', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (2, N'02', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (3, N'03', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (4, N'04', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (5, N'05', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (6, N'06', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (7, N'07', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (8, N'08', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (9, N'09', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (10, N'10', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (11, N'VIP.1', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (12, N'VIP.2', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (13, N'VIP.3', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (14, N'VIP.4', 0)
INSERT [dbo].[Table] ([ID], [Name], [Status]) VALUES (15, N'VIP.5', 0)
SET IDENTITY_INSERT [dbo].[Table] OFF

ALTER TABLE [dbo].[BillDetails] ADD  CONSTRAINT [DF_InvoiceDetails_Amount]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_Price]  DEFAULT ((0)) FOR [Price]
GO

ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_FoodStuffs] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_FoodStuffs]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_Invoice]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Invoice_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_FoodStuffs_FoodCategory] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_FoodStuffs_FoodCategory]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO

--Lay thong tin
Select * from [Account]
select * from [BillDetails]
select * from [Bills]
select * from [Category]
select * from [Food]
select * from [Role]
select * from [RoleAccount]
select * from [Table]
