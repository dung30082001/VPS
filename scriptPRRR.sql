USE [VPS]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[Avatar] [nvarchar](max) NULL,
	[Status] [bit] NULL,
	[Profile] [nvarchar](500) NULL,
	[RoleId] [int] NULL,
	[BloggerId] [int] NULL,
	[ConsultantId] [int] NULL,
	[CustomerId] [int] NULL,
	[ManagerId] [int] NULL,
	[SupplierId] [int] NULL,
	[TechnicalId] [int] NULL,
	[AdminId] [int] NULL,
	[SaleId] [int] NULL,
	[ShipperId] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NULL,
	[Phone] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[DOB] [datetime] NULL,
	[StatusID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BloggerId] [int] NULL,
	[Title] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
	[PublishDate] [date] NULL,
	[ImageId] [int] NULL,
	[StatusId] [int] NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogger]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogger](
	[BloggerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[StatusId] [int] NULL,
	[BlogId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BloggerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Description] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[CommentId] [int] IDENTITY(1,1) NOT NULL,
	[BlogId] [int] NULL,
	[BloggerId] [int] NULL,
	[CustomerId] [int] NULL,
	[Content] [nvarchar](500) NULL,
	[CommentDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consultant]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultant](
	[ConsultantId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[StatusId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ConsultantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractId] [int] IDENTITY(1,1) NOT NULL,
	[TechnicalId] [int] NULL,
	[SupplierId] [int] NULL,
	[Content] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conversation]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conversation](
	[ConversationId] [int] IDENTITY(1,1) NOT NULL,
	[ConversationName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ConversationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[Balance] [int] NULL,
	[DOB] [datetime] NULL,
	[StatusId] [int] NULL,
	[Avatar] [nvarchar](500) NULL,
	[IsValid] [bit] NULL,
	[Voucher] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeedBack]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedBack](
	[FeedbackId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[ShipperId] [int] NULL,
	[ConsultantId] [int] NULL,
	[OrderId] [int] NULL,
	[Content] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[FeedbackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[ImageId] [int] IDENTITY(1,1) NOT NULL,
	[ImageName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ManagerId] [int] NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[StatusId] [int] NULL,
	[Avatar] [nvarchar](250) NULL,
	[SaleId] [int] NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageId] [int] IDENTITY(1,1) NOT NULL,
	[ConversationId] [int] NULL,
	[CustomerId] [int] NULL,
	[Description] [nvarchar](500) NULL,
	[Time] [datetime] NULL,
	[StatusId] [int] NULL,
	[ConsultantId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NULL,
	[CustomerId] [int] NULL,
	[OrderDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[ShipId] [int] NULL,
	[Price] [float] NOT NULL,
	[Status] [int] NOT NULL,
	[ShipCost] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[UnitPrice] [float] NULL,
	[Quantity] [int] NULL,
	[Discount] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NULL,
	[CategoryId] [int] NULL,
	[UnitInStock] [int] NULL,
	[UnitPrice] [float] NULL,
	[Image] [nvarchar](max) NULL,
	[StatusId] [int] NULL,
	[Brand] [nvarchar](250) NULL,
	[Description] [nvarchar](max) NULL,
	[DiscountDate] [datetime] NULL,
	[Type] [nvarchar](100) NULL,
	[Moneytype] [nvarchar](50) NULL,
	[Quality] [int] NULL,
	[Maintaince] [nchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetail]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetail](
	[DetailId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[ImageId] [int] NULL,
	[Description] [nchar](100) NULL,
 CONSTRAINT [PK_ProductDetail] PRIMARY KEY CLUSTERED 
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QRCode]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QRCode](
	[QRID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[DayCreate] [datetime] NULL,
	[ProductId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[QRID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rent]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rent](
	[BuyId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_Buy] PRIMARY KEY CLUSTERED 
(
	[BuyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[OrderId] [int] NULL,
	[StatusId] [int] NULL,
	[ShipperId] [int] NULL,
	[CustomerId] [int] NULL,
	[Avatar] [nchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipper]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipper](
	[ShipperID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[Avatar] [nvarchar](200) NULL,
	[OrderId] [int] NULL,
	[StatusId] [int] NULL,
	[CustomerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusNum] [int] NULL,
	[StatusValue] [nchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[TechnicalId] [int] NULL,
	[SupplierId] [int] NULL,
	[CategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[Avatar] [nvarchar](1) NULL,
	[StatusId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierProduct]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierProduct](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[CategoryId] [int] NULL,
	[Image] [nvarchar](250) NULL,
	[Brand] [nvarchar](250) NULL,
	[StatusId] [int] NULL,
	[UnitInStock] [int] NULL,
	[UnitPrice] [float] NULL,
	[NumberOfUse] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierStock]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierStock](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[SupplierId] [int] NULL,
	[CategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Technical]    Script Date: 7/13/2023 6:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Technical](
	[TechnicalId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[DOB] [datetime] NULL,
	[Avatar] [nvarchar](250) NULL,
	[StatusId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TechnicalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [Email], [Avatar], [Status], [Profile], [RoleId], [BloggerId], [ConsultantId], [CustomerId], [ManagerId], [SupplierId], [TechnicalId], [AdminId], [SaleId], [ShipperId], [CreatedDate]) VALUES (17, N'nguyenhoanglong', N'123456', N'nguyenhoanglong@email.com', NULL, 1, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2023-05-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [Email], [Avatar], [Status], [Profile], [RoleId], [BloggerId], [ConsultantId], [CustomerId], [ManagerId], [SupplierId], [TechnicalId], [AdminId], [SaleId], [ShipperId], [CreatedDate]) VALUES (19, N'nguyenhoainam', N'123456', N'nguyenhoainam@email.com', NULL, 1, NULL, 2, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-01-07T00:00:00.000' AS DateTime))
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [Email], [Avatar], [Status], [Profile], [RoleId], [BloggerId], [ConsultantId], [CustomerId], [ManagerId], [SupplierId], [TechnicalId], [AdminId], [SaleId], [ShipperId], [CreatedDate]) VALUES (20, N'lehoanganh', N'123456', N'lehoanganh@email.com', NULL, 1, NULL, 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, CAST(N'2023-03-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [Email], [Avatar], [Status], [Profile], [RoleId], [BloggerId], [ConsultantId], [CustomerId], [ManagerId], [SupplierId], [TechnicalId], [AdminId], [SaleId], [ShipperId], [CreatedDate]) VALUES (21, N'nguyenvananh', N'123456', N'nguyenvananh@email.com', NULL, 1, NULL, 9, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, CAST(N'2023-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Account] ([AccountId], [UserName], [Password], [Email], [Avatar], [Status], [Profile], [RoleId], [BloggerId], [ConsultantId], [CustomerId], [ManagerId], [SupplierId], [TechnicalId], [AdminId], [SaleId], [ShipperId], [CreatedDate]) VALUES (1020, N'nguyenvanminh', N'123456', N'nguyenvanminh@gmail.com', NULL, 1, NULL, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2023-03-02T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminId], [FullName], [Phone], [Address], [DOB], [StatusID]) VALUES (1, N'Nguyễn Hoàng Long', N'0985551234', N'Hà Nội', CAST(N'1990-01-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Admin] ([AdminId], [FullName], [Phone], [Address], [DOB], [StatusID]) VALUES (2, N'Trần Đình Nam', N'0965355678', N'Hồ Chí Minh', CAST(N'1995-05-05T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Admin] ([AdminId], [FullName], [Phone], [Address], [DOB], [StatusID]) VALUES (3, N'Nguyễn Huy Hoàng', N'0963452468', N'Đà Nẵng', CAST(N'1985-12-31T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Admin] ([AdminId], [FullName], [Phone], [Address], [DOB], [StatusID]) VALUES (4, N'Kim Ngọc Sinh', N'0985463698', N'Hải Phòng', CAST(N'1995-06-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Admin] ([AdminId], [FullName], [Phone], [Address], [DOB], [StatusID]) VALUES (5, N'Trần Quốc Bảo', N'0946789876', N'Hà Nội', CAST(N'1992-09-30T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Blog] ON 

INSERT [dbo].[Blog] ([Id], [BloggerId], [Title], [Description], [PublishDate], [ImageId], [StatusId], [CategoryId]) VALUES (2, 1, N'Cách chọn thiết bị âm thanh hoàn hảo cho sự kiện của bạn', N'', CAST(N'2023-07-02' AS Date), 1, 1, 1)
INSERT [dbo].[Blog] ([Id], [BloggerId], [Title], [Description], [PublishDate], [ImageId], [StatusId], [CategoryId]) VALUES (3, 2, N'Olala', N'Mistric', CAST(N'2023-07-02' AS Date), 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Blog] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogger] ON 

INSERT [dbo].[Blogger] ([BloggerId], [FullName], [Phone], [Address], [DOB], [StatusId], [BlogId]) VALUES (1, N'Nguyễn Hoài Nam', N'0985551234', N'Hà Nội', CAST(N'1985-06-15T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Blogger] ([BloggerId], [FullName], [Phone], [Address], [DOB], [StatusId], [BlogId]) VALUES (2, N'Phí Thị Quỳnh', N'0955555678', N'Lai Châu', CAST(N'1990-01-01T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[Blogger] ([BloggerId], [FullName], [Phone], [Address], [DOB], [StatusId], [BlogId]) VALUES (3, N'Trần Nam Anh', N'0935559876', N'Hải Phòng', CAST(N'1978-12-31T00:00:00.000' AS DateTime), 1, 2)
INSERT [dbo].[Blogger] ([BloggerId], [FullName], [Phone], [Address], [DOB], [StatusId], [BlogId]) VALUES (4, N'Trần Tiến Đạt', N'0965555555', N'Đà Nẵng', CAST(N'1987-05-20T00:00:00.000' AS DateTime), 2, 3)
INSERT [dbo].[Blogger] ([BloggerId], [FullName], [Phone], [Address], [DOB], [StatusId], [BlogId]) VALUES (5, N'Nguyễn Quang Linh', N'0925554321', N'Nghệ An', CAST(N'1995-11-11T00:00:00.000' AS DateTime), 1, 2)
SET IDENTITY_INSERT [dbo].[Blogger] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (1, N'Thiết Bị Âm Thanh – Ánh Sáng', N'Thiết bị kết hợp âm thanh và ánh sáng để tạo ra hiệu ứng âm nhạc và ánh sáng đặc biệt.')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (2, N'Màn Hình LED', N'Thiết bị hiển thị hình ảnh và video sử dụng công nghệ LED.')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (3, N'Hệ Thống Sân Khấu', N'Thiết bị âm thanh, ánh sáng và hiệu ứng trên sân khấu.')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (4, N'Trang Thiết Bị Khu Vực Tiệc', N'Thiết bị âm thanh, ánh sáng và trang trí dùng cho khu vực tiệc.')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Description]) VALUES (5, N'Thiết Bị Nhà Bạt Không Gian', N'Thiết bị âm thanh, ánh sáng và trang trí dùng cho không gian nhà bạt. ')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Consultant] ON 

INSERT [dbo].[Consultant] ([ConsultantId], [FullName], [Phone], [Address], [DOB], [StatusId]) VALUES (1, N'Nguyễn Văn An', N'0987654321', N'Hà Nội', CAST(N'1990-01-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Consultant] ([ConsultantId], [FullName], [Phone], [Address], [DOB], [StatusId]) VALUES (2, N'Trần Thị Bích', N'0954645456', N'Hồ Chí Minh', CAST(N'1985-02-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Consultant] ([ConsultantId], [FullName], [Phone], [Address], [DOB], [StatusId]) VALUES (3, N'Lê Quang Cao', N'0912345678', N'Đà Nẵng', CAST(N'1995-07-30T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Consultant] ([ConsultantId], [FullName], [Phone], [Address], [DOB], [StatusId]) VALUES (4, N'Phạm Thanh Dung', N'0994834848', N'Hà Tĩnh', CAST(N'1993-04-21T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Consultant] ([ConsultantId], [FullName], [Phone], [Address], [DOB], [StatusId]) VALUES (5, N'Võ Hoàng Yến', N'0994383483', N'Hải Phòng', CAST(N'1988-11-03T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Consultant] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Address], [Balance], [DOB], [StatusId], [Avatar], [IsValid], [Voucher]) VALUES (16, N'Nguyễn Văn Anh', N'0987654321', N'Hà Nội', 5000000, CAST(N'1990-01-01T00:00:00.000' AS DateTime), 1, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Address], [Balance], [DOB], [StatusId], [Avatar], [IsValid], [Voucher]) VALUES (18, N'Lê Quang Cường', N'0912345678', N'Đà Nẵng', 7500000, CAST(N'1995-07-30T00:00:00.000' AS DateTime), 1, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Address], [Balance], [DOB], [StatusId], [Avatar], [IsValid], [Voucher]) VALUES (19, N'Phạm Thanh Hùng', N'099897635', N'Nghệ An', 2000000, CAST(N'1993-04-21T00:00:00.000' AS DateTime), 2, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Address], [Balance], [DOB], [StatusId], [Avatar], [IsValid], [Voucher]) VALUES (20, N'Nguyễn Đăng Dũng', N'0349175696', N'Hải Dương', 100000000, CAST(N'2023-07-02T15:09:32.367' AS DateTime), 3, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([CustomerId], [FullName], [Phone], [Address], [Balance], [DOB], [StatusId], [Avatar], [IsValid], [Voucher]) VALUES (1002, N'Hồ Hởi', N'0394834734', N'Hà Nội', 138438750, CAST(N'2023-07-02T15:38:50.340' AS DateTime), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Image] ON 

INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (1, N'function.jpg')
INSERT [dbo].[Image] ([ImageId], [ImageName]) VALUES (2, N'Domain.jpg')
SET IDENTITY_INSERT [dbo].[Image] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (18, 2, 18, CAST(N'2023-06-03T00:00:00.000' AS DateTime), CAST(N'2023-06-07T00:00:00.000' AS DateTime), 3, 250000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (19, 2, 19, CAST(N'2023-06-04T00:00:00.000' AS DateTime), CAST(N'2023-06-08T00:00:00.000' AS DateTime), 3, 200000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (20, 3, 20, CAST(N'2023-06-05T00:00:00.000' AS DateTime), CAST(N'2023-06-09T00:00:00.000' AS DateTime), 1, 300000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1011, 1, 16, CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-01-07T00:00:00.000' AS DateTime), 1, 195000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1012, 2, 16, CAST(N'2023-01-23T00:00:00.000' AS DateTime), CAST(N'2023-01-29T00:00:00.000' AS DateTime), 2, 190000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1013, 3, 16, CAST(N'2023-01-22T00:00:00.000' AS DateTime), CAST(N'2023-01-30T00:00:00.000' AS DateTime), 3, 500000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1015, 5, 16, CAST(N'2023-01-12T00:00:00.000' AS DateTime), CAST(N'2023-01-28T00:00:00.000' AS DateTime), 2, 433000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1021, 1, 18, CAST(N'2023-02-21T00:00:00.000' AS DateTime), CAST(N'2023-02-22T00:00:00.000' AS DateTime), 2, 130000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1022, 2, 19, CAST(N'2023-02-20T00:00:00.000' AS DateTime), CAST(N'2023-02-21T00:00:00.000' AS DateTime), 3, 200000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1024, 4, 20, CAST(N'2023-02-18T00:00:00.000' AS DateTime), CAST(N'2023-02-23T00:00:00.000' AS DateTime), 2, 120000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1025, 5, 20, CAST(N'2023-02-17T00:00:00.000' AS DateTime), CAST(N'2023-02-28T00:00:00.000' AS DateTime), 3, 130000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1026, 1, 18, CAST(N'2023-02-16T00:00:00.000' AS DateTime), CAST(N'2023-02-27T00:00:00.000' AS DateTime), 1, 110000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1027, 2, 19, CAST(N'2023-02-15T00:00:00.000' AS DateTime), CAST(N'2023-02-26T00:00:00.000' AS DateTime), 2, 140000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1029, 4, 20, CAST(N'2023-02-13T00:00:00.000' AS DateTime), CAST(N'2023-02-24T00:00:00.000' AS DateTime), 1, 340000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1030, 5, 20, CAST(N'2023-02-12T00:00:00.000' AS DateTime), CAST(N'2023-02-23T00:00:00.000' AS DateTime), 2, 560000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1031, 2, 18, CAST(N'2023-03-11T00:00:00.000' AS DateTime), CAST(N'2023-03-22T00:00:00.000' AS DateTime), 3, 730000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1032, 2, 19, CAST(N'2023-03-10T00:00:00.000' AS DateTime), CAST(N'2023-03-21T00:00:00.000' AS DateTime), 1, 100000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1034, 4, 20, CAST(N'2023-03-08T00:00:00.000' AS DateTime), CAST(N'2023-03-19T00:00:00.000' AS DateTime), 3, 350000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1035, 5, 20, CAST(N'2023-03-07T00:00:00.000' AS DateTime), CAST(N'2023-03-18T00:00:00.000' AS DateTime), 1, 720000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1036, 1, 18, CAST(N'2023-03-06T00:00:00.000' AS DateTime), CAST(N'2023-03-17T00:00:00.000' AS DateTime), 2, 490000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1037, 2, 19, CAST(N'2023-03-05T00:00:00.000' AS DateTime), CAST(N'2023-03-16T00:00:00.000' AS DateTime), 3, 872000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1039, 4, 20, CAST(N'2023-03-03T00:00:00.000' AS DateTime), CAST(N'2023-03-14T00:00:00.000' AS DateTime), 2, 130000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1040, 5, 20, CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-03-13T00:00:00.000' AS DateTime), 3, 400000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1041, 1, 19, CAST(N'2023-04-01T00:00:00.000' AS DateTime), CAST(N'2023-04-11T00:00:00.000' AS DateTime), 1, 200000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1042, 2, 19, CAST(N'2023-04-12T00:00:00.000' AS DateTime), CAST(N'2023-04-14T00:00:00.000' AS DateTime), 2, 430000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1044, 4, 20, CAST(N'2023-04-09T00:00:00.000' AS DateTime), CAST(N'2023-04-22T00:00:00.000' AS DateTime), 1, 190000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1045, 5, 20, CAST(N'2023-04-08T00:00:00.000' AS DateTime), CAST(N'2023-04-29T00:00:00.000' AS DateTime), 2, 145000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1046, 1, 18, CAST(N'2023-04-07T00:00:00.000' AS DateTime), CAST(N'2023-04-28T00:00:00.000' AS DateTime), 3, 210000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1047, 2, 19, CAST(N'2023-04-06T00:00:00.000' AS DateTime), CAST(N'2023-04-27T00:00:00.000' AS DateTime), 1, 320000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1049, 4, 20, CAST(N'2023-04-04T00:00:00.000' AS DateTime), CAST(N'2023-04-25T00:00:00.000' AS DateTime), 3, 420000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1050, 5, 20, CAST(N'2023-04-03T00:00:00.000' AS DateTime), CAST(N'2023-04-24T00:00:00.000' AS DateTime), 1, 680000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1051, 1, 18, CAST(N'2023-04-02T00:00:00.000' AS DateTime), CAST(N'2023-04-23T00:00:00.000' AS DateTime), 2, 530000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1052, 2, 19, CAST(N'2023-04-01T00:00:00.000' AS DateTime), CAST(N'2023-04-22T00:00:00.000' AS DateTime), 3, 290000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1054, 4, 20, CAST(N'2023-04-09T00:00:00.000' AS DateTime), CAST(N'2023-04-20T00:00:00.000' AS DateTime), 2, 410000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1055, 5, 20, CAST(N'2023-04-08T00:00:00.000' AS DateTime), CAST(N'2023-04-19T00:00:00.000' AS DateTime), 3, 890000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1056, 1, 18, CAST(N'2023-05-17T00:00:00.000' AS DateTime), CAST(N'2023-05-28T00:00:00.000' AS DateTime), 1, 120000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1057, 2, 19, CAST(N'2023-05-16T00:00:00.000' AS DateTime), CAST(N'2023-05-27T00:00:00.000' AS DateTime), 2, 123000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1059, 4, 20, CAST(N'2023-05-14T00:00:00.000' AS DateTime), CAST(N'2023-05-25T00:00:00.000' AS DateTime), 1, 490000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1060, 5, 20, CAST(N'2023-05-13T00:00:00.000' AS DateTime), CAST(N'2023-05-24T00:00:00.000' AS DateTime), 2, 790000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1061, 1, 18, CAST(N'2023-05-12T00:00:00.000' AS DateTime), CAST(N'2023-05-23T00:00:00.000' AS DateTime), 3, 320000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1062, 2, 19, CAST(N'2023-05-11T00:00:00.000' AS DateTime), CAST(N'2023-05-22T00:00:00.000' AS DateTime), 1, 189000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1064, 4, 20, CAST(N'2023-05-09T00:00:00.000' AS DateTime), CAST(N'2023-05-10T00:00:00.000' AS DateTime), 3, 690000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1065, 5, 20, CAST(N'2023-05-08T00:00:00.000' AS DateTime), CAST(N'2023-05-19T00:00:00.000' AS DateTime), 1, 790000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1066, 1, 18, CAST(N'2023-06-07T00:00:00.000' AS DateTime), CAST(N'2023-06-08T00:00:00.000' AS DateTime), 2, 320000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1067, 2, 19, CAST(N'2023-06-06T00:00:00.000' AS DateTime), CAST(N'2023-06-17T00:00:00.000' AS DateTime), 3, 290000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1069, 4, 20, CAST(N'2023-06-04T00:00:00.000' AS DateTime), CAST(N'2023-06-15T00:00:00.000' AS DateTime), 2, 400000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1070, 5, 20, CAST(N'2023-06-03T00:00:00.000' AS DateTime), CAST(N'2023-06-14T00:00:00.000' AS DateTime), 3, 700000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1071, 1, 18, CAST(N'2023-06-02T00:00:00.000' AS DateTime), CAST(N'2023-06-13T00:00:00.000' AS DateTime), 1, 200000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1072, 2, 19, CAST(N'2023-06-01T00:00:00.000' AS DateTime), CAST(N'2023-06-12T00:00:00.000' AS DateTime), 2, 600000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1074, 4, 20, CAST(N'2023-06-12T00:00:00.000' AS DateTime), CAST(N'2023-06-30T00:00:00.000' AS DateTime), 1, 320000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1075, 5, 20, CAST(N'2023-06-12T00:00:00.000' AS DateTime), CAST(N'2023-06-29T00:00:00.000' AS DateTime), 2, 470000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1076, 1, 18, CAST(N'2023-07-17T00:00:00.000' AS DateTime), CAST(N'2023-07-28T00:00:00.000' AS DateTime), 3, 320000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1077, 2, 19, CAST(N'2023-07-16T00:00:00.000' AS DateTime), CAST(N'2023-07-27T00:00:00.000' AS DateTime), 1, 370000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1079, 4, 20, CAST(N'2023-07-14T00:00:00.000' AS DateTime), CAST(N'2023-07-25T00:00:00.000' AS DateTime), 3, 300000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1080, 5, 20, CAST(N'2023-07-13T00:00:00.000' AS DateTime), CAST(N'2023-07-24T00:00:00.000' AS DateTime), 1, 600000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1081, 1, 18, CAST(N'2023-07-12T00:00:00.000' AS DateTime), CAST(N'2023-07-23T00:00:00.000' AS DateTime), 2, 550000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1082, 2, 19, CAST(N'2023-07-11T00:00:00.000' AS DateTime), CAST(N'2023-07-22T00:00:00.000' AS DateTime), 3, 320000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1084, 4, 20, CAST(N'2023-07-09T00:00:00.000' AS DateTime), CAST(N'2023-07-20T00:00:00.000' AS DateTime), 2, 720000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1085, 5, 20, CAST(N'2023-07-08T00:00:00.000' AS DateTime), CAST(N'2023-07-19T00:00:00.000' AS DateTime), 3, 320000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1086, 1, 18, CAST(N'2023-08-07T00:00:00.000' AS DateTime), CAST(N'2023-08-18T00:00:00.000' AS DateTime), 1, 420000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1087, 2, 19, CAST(N'2023-08-06T00:00:00.000' AS DateTime), CAST(N'2023-08-17T00:00:00.000' AS DateTime), 2, 350000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1089, 4, 20, CAST(N'2023-08-04T00:00:00.000' AS DateTime), CAST(N'2023-08-15T00:00:00.000' AS DateTime), 1, 550000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1090, 5, 20, CAST(N'2023-08-03T00:00:00.000' AS DateTime), CAST(N'2023-08-14T00:00:00.000' AS DateTime), 2, 720000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1091, 1, 18, CAST(N'2023-08-02T00:00:00.000' AS DateTime), CAST(N'2023-08-13T00:00:00.000' AS DateTime), 3, 840000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1092, 2, 19, CAST(N'2023-08-01T00:00:00.000' AS DateTime), CAST(N'2023-08-12T00:00:00.000' AS DateTime), 1, 190000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1094, 4, 20, CAST(N'2023-08-09T00:00:00.000' AS DateTime), CAST(N'2023-08-20T00:00:00.000' AS DateTime), 3, 230000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1095, 5, 20, CAST(N'2023-08-08T00:00:00.000' AS DateTime), CAST(N'2023-08-19T00:00:00.000' AS DateTime), 1, 290000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1096, 1, 18, CAST(N'2023-09-07T00:00:00.000' AS DateTime), CAST(N'2023-09-18T00:00:00.000' AS DateTime), 2, 480000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1097, 2, 19, CAST(N'2023-09-06T00:00:00.000' AS DateTime), CAST(N'2023-09-17T00:00:00.000' AS DateTime), 3, 230000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1099, 4, 20, CAST(N'2023-09-04T00:00:00.000' AS DateTime), CAST(N'2023-09-15T00:00:00.000' AS DateTime), 2, 120000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1100, 5, 20, CAST(N'2023-09-03T00:00:00.000' AS DateTime), CAST(N'2023-09-14T00:00:00.000' AS DateTime), 3, 140000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1101, 1, 18, CAST(N'2023-09-02T00:00:00.000' AS DateTime), CAST(N'2023-09-13T00:00:00.000' AS DateTime), 1, 260000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1102, 2, 19, CAST(N'2023-09-10T00:00:00.000' AS DateTime), CAST(N'2023-09-22T00:00:00.000' AS DateTime), 2, 490000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1104, 4, 20, CAST(N'2023-09-13T00:00:00.000' AS DateTime), CAST(N'2023-09-30T00:00:00.000' AS DateTime), 1, 320000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1105, 5, 20, CAST(N'2023-09-12T00:00:00.000' AS DateTime), CAST(N'2023-09-30T00:00:00.000' AS DateTime), 2, 310000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1106, 1, 18, CAST(N'2023-10-18T00:00:00.000' AS DateTime), CAST(N'2023-10-29T00:00:00.000' AS DateTime), 3, 220000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1107, 2, 19, CAST(N'2023-10-17T00:00:00.000' AS DateTime), CAST(N'2023-10-28T00:00:00.000' AS DateTime), 1, 290000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1109, 4, 20, CAST(N'2023-10-15T00:00:00.000' AS DateTime), CAST(N'2023-10-26T00:00:00.000' AS DateTime), 3, 300000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1110, 5, 20, CAST(N'2023-10-14T00:00:00.000' AS DateTime), CAST(N'2023-10-25T00:00:00.000' AS DateTime), 1, 210000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1111, 1, 18, CAST(N'2023-10-19T00:00:00.000' AS DateTime), CAST(N'2023-10-29T00:00:00.000' AS DateTime), 3, 310000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1112, 2, 19, CAST(N'2023-10-16T00:00:00.000' AS DateTime), CAST(N'2023-10-28T00:00:00.000' AS DateTime), 1, 370000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1114, 4, 20, CAST(N'2023-10-25T00:00:00.000' AS DateTime), CAST(N'2023-10-28T00:00:00.000' AS DateTime), 3, 420000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1115, 5, 20, CAST(N'2023-10-24T00:00:00.000' AS DateTime), CAST(N'2023-10-29T00:00:00.000' AS DateTime), 1, 310000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1116, 1, 18, CAST(N'2023-11-08T00:00:00.000' AS DateTime), CAST(N'2023-11-19T00:00:00.000' AS DateTime), 3, 230000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1117, 2, 19, CAST(N'2023-11-07T00:00:00.000' AS DateTime), CAST(N'2023-11-18T00:00:00.000' AS DateTime), 1, 210000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1119, 4, 20, CAST(N'2023-11-05T00:00:00.000' AS DateTime), CAST(N'2023-11-16T00:00:00.000' AS DateTime), 3, 240000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1120, 5, 20, CAST(N'2023-11-04T00:00:00.000' AS DateTime), CAST(N'2023-11-15T00:00:00.000' AS DateTime), 1, 100000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1121, 1, 18, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-19T00:00:00.000' AS DateTime), 3, 200000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1122, 2, 19, CAST(N'2023-11-06T00:00:00.000' AS DateTime), CAST(N'2023-11-18T00:00:00.000' AS DateTime), 1, 310000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1124, 4, 20, CAST(N'2023-11-03T00:00:00.000' AS DateTime), CAST(N'2023-11-18T00:00:00.000' AS DateTime), 3, 290000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1125, 5, 20, CAST(N'2023-11-01T00:00:00.000' AS DateTime), CAST(N'2023-11-19T00:00:00.000' AS DateTime), 1, 120000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1126, 1, 18, CAST(N'2023-12-16T00:00:00.000' AS DateTime), CAST(N'2023-12-29T00:00:00.000' AS DateTime), 3, 130000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1127, 2, 19, CAST(N'2023-12-15T00:00:00.000' AS DateTime), CAST(N'2023-12-28T00:00:00.000' AS DateTime), 1, 250000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1129, 4, 20, CAST(N'2023-12-12T00:00:00.000' AS DateTime), CAST(N'2023-12-26T00:00:00.000' AS DateTime), 3, 400000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1130, 5, 20, CAST(N'2023-12-13T00:00:00.000' AS DateTime), CAST(N'2023-12-25T00:00:00.000' AS DateTime), 1, 360000, 2, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1131, 1, 18, CAST(N'2023-12-11T00:00:00.000' AS DateTime), CAST(N'2023-12-29T00:00:00.000' AS DateTime), 3, 280000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1132, 2, 19, CAST(N'2023-12-16T00:00:00.000' AS DateTime), CAST(N'2023-12-28T00:00:00.000' AS DateTime), 1, 210000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1134, 4, 20, CAST(N'2023-12-25T00:00:00.000' AS DateTime), CAST(N'2023-12-28T00:00:00.000' AS DateTime), 3, 420000, 1, NULL)
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1135, 5, 20, CAST(N'2023-12-24T00:00:00.000' AS DateTime), CAST(N'2023-12-29T00:00:00.000' AS DateTime), 1, 310000, 1, NULL)
GO
INSERT [dbo].[Order] ([OrderId], [SaleId], [CustomerId], [OrderDate], [ShippedDate], [ShipId], [Price], [Status], [ShipCost]) VALUES (1136, 1, 20, CAST(N'2023-07-02T14:31:04.693' AS DateTime), CAST(N'2023-07-02T14:31:04.693' AS DateTime), 3, 100000, 3, NULL)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (10, 20, 5, 12.49, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1023, 1011, 1, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1024, 1011, 2, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1025, 1011, 3, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1026, 1012, 4, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1027, 1012, 5, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1028, 1012, 6, 20, 4, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1029, 1013, 7, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1030, 1013, 8, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1031, 1013, 9, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1032, 1013, 10, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1033, 1036, 14, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1034, 1036, 14, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1035, 1036, 15, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1036, 1036, 14, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1037, 1035, 15, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1038, 1035, 18, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1039, 1035, 17, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1040, 1035, 18, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1041, 1034, 19, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1042, 1034, 20, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1043, 1034, 21, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1044, 1034, 22, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1045, 1034, 23, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1046, 1034, 24, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1047, 1015, 25, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1048, 1015, 1, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1049, 1015, 2, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1050, 1029, 3, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1051, 1029, 4, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1052, 1029, 5, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1053, 1021, 6, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1054, 1021, 7, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1055, 1021, 8, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1056, 1022, 9, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1057, 1022, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1058, 1022, 14, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1059, 1022, 16, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1060, 1022, 15, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1061, 1022, 14, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1062, 1024, 15, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1063, 1024, 16, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1064, 1024, 17, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1065, 1011, 1, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1066, 1011, 2, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1067, 1011, 3, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1068, 1012, 4, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1069, 1012, 5, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1070, 1012, 6, 20, 4, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1071, 1013, 7, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1072, 1013, 8, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1073, 1013, 9, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1074, 1013, 10, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1075, 1036, 14, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1076, 1036, 14, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1077, 1036, 15, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1078, 1036, 14, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1079, 1035, 15, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1080, 1035, 18, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1081, 1035, 17, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1082, 1035, 18, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1083, 1034, 19, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1084, 1034, 20, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1085, 1034, 21, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1086, 1034, 22, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1087, 1034, 23, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1088, 1034, 24, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1089, 1015, 25, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1090, 1015, 1, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1091, 1015, 2, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1092, 1029, 3, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1093, 1029, 4, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1094, 1029, 5, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1095, 1021, 6, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1096, 1021, 7, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1097, 1021, 8, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1098, 1022, 9, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1099, 1022, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1100, 1022, 14, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1101, 1022, 16, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1102, 1022, 15, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1103, 1022, 14, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1104, 1024, 15, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1105, 1024, 16, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1106, 1024, 17, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1122, 1011, 1, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1123, 1011, 2, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1124, 1011, 3, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1125, 1012, 4, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1126, 1012, 5, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1127, 1012, 6, 20, 4, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1128, 1013, 7, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1129, 1013, 8, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1130, 1013, 9, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1131, 1015, 10, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1132, 1015, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1133, 1015, 1, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1134, 1015, 1, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1135, 1015, 1, 15.75, 1, 0.05)
GO
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1136, 1015, 16, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1137, 1021, 16, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1138, 1021, 17, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1139, 1021, 18, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1140, 1021, 19, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1141, 1022, 20, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1142, 1022, 21, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1143, 1022, 22, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1144, 1022, 23, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1145, 1022, 24, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1146, 1027, 25, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1147, 1027, 1, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1148, 1027, 2, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1149, 1035, 3, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1150, 1035, 4, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1151, 1035, 5, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1152, 1035, 6, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1153, 1035, 7, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1154, 1040, 8, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1155, 1040, 9, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1156, 1040, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1157, 1055, 7, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1158, 1056, 15, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1159, 1056, 14, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1160, 1055, 14, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1161, 1060, 15, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1162, 1060, 16, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1163, 1060, 17, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1164, 1060, 18, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1165, 1060, 19, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1166, 1011, 1, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1167, 1011, 2, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1168, 1011, 3, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1169, 1012, 4, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1170, 1012, 5, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1171, 1012, 6, 20, 4, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1172, 1013, 7, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1173, 1013, 8, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1174, 1013, 9, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1175, 1015, 10, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1176, 1015, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1177, 1015, 1, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1178, 1015, 1, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1179, 1015, 1, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1180, 1015, 16, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1181, 1021, 16, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1182, 1021, 17, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1183, 1021, 18, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1184, 1021, 19, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1185, 1022, 20, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1186, 1022, 21, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1187, 1022, 22, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1188, 1022, 23, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1189, 1022, 24, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1190, 1027, 25, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1191, 1027, 1, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1192, 1027, 2, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1193, 1035, 3, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1194, 1035, 4, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1195, 1035, 5, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1196, 1035, 6, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1197, 1035, 7, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1198, 1040, 8, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1199, 1040, 9, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1200, 1040, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1201, 1055, 7, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1202, 1056, 15, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1203, 1056, 14, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1204, 1055, 14, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1205, 1060, 15, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1206, 1060, 16, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1207, 1060, 17, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1208, 1060, 18, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1209, 1060, 19, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1210, 1011, 1, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1211, 1011, 2, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1212, 1011, 3, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1213, 1012, 4, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1214, 1012, 5, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1215, 1012, 6, 20, 4, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1216, 1013, 7, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1217, 1013, 8, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1218, 1013, 9, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1219, 1015, 10, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1220, 1015, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1221, 1015, 1, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1222, 1015, 1, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1223, 1015, 1, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1224, 1015, 16, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1225, 1021, 16, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1226, 1021, 17, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1227, 1021, 18, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1228, 1021, 19, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1229, 1022, 20, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1230, 1022, 21, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1231, 1022, 22, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1232, 1022, 23, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1233, 1022, 24, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1234, 1027, 25, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1235, 1027, 1, 15.75, 1, 0.05)
GO
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1236, 1027, 2, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1237, 1035, 3, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1238, 1035, 4, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1239, 1035, 5, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1240, 1035, 6, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1241, 1035, 7, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1242, 1040, 8, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1243, 1040, 9, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1244, 1040, 10, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1245, 1055, 7, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1246, 1056, 15, 10.5, 3, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1247, 1056, 14, 15.75, 1, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1248, 1055, 14, 20, 2, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1249, 1060, 15, 10.5, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1250, 1060, 16, 15.75, 2, 0.05)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1251, 1060, 17, 20, 3, 0.15)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1252, 1060, 18, 10.5, 2, 0.1)
INSERT [dbo].[OrderDetail] ([OrderDetailId], [OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1253, 1060, 19, 15.75, 1, 0.05)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (1, N'Loa', 1, 100, 200, NULL, 1, N'ABC Electronics', N'Loa là thiết bị âm thanh được sử dụng để tái tạo âm thanh từ các nguồn khác nhau. Có nhiều loại loa khác nhau, bao gồm loa bookshelf, loa đứng, loa siêu trầm, loa không dây.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (2, N'Amplifie', 1, 150, 150, NULL, 1, N'XYZ Corporation', N'Được sử dụng để cung cấp nguồn điện cho loa và tăng cường âm lượng.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (3, N'Màn hình LED ngoài trời', 2, 80, 500, NULL, 1, N'DEF Displays', N'Cung cấp cho khách hàng một giải pháp truyền thông đa phương tiện với độ sáng cao và khả năng chống thời tiết tốt, được sử dụng rộng rãi trong quảng cáo ngoài trời, các sự kiện âm nhạc và thể thao.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (4, N'Màn hình LED vuông, chữ nhật, tròn', 2, 100, 600, NULL, 1, N'123 Electronics', N'Được thiết kế cho các ứng dụng khác nhau, từ hiển thị thông tin đơn giản đến trình diễn nghệ thuật, quảng cáo sản phẩm..', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (5, N'Mixer', 3, 200, 1000, NULL, 1, N'GHI Systems', N'Thiết bị điều chỉnh âm thanh và kết nối các nguồn âm thanh khác nhau vào hệ thống.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (6, N'Backdrop', 3, 120, 1200, NULL, 1, N'JKL Audio', N'Được sử dụng để tạo nền cho các buổi trình diễn, chương trình.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (7, N'Bàn ghế tiệc', 4, 90, 300, NULL, 1, N'MNO Rentals', N'Sản phẩm không thể thiếu trong một buổi tiệc, được sử dụng để phục vụ thực phẩm cho khách mời.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (8, N'Tủ giữ nóng, tủ giữ lạnh', 4, 160, 250, NULL, 1, N'PQR Events', N'Được sử dụng để giữ đồ ăn nóng hoặc lạnh trong suốt thời gian diễn ra tiệc..', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (9, N'Nhà bạt không gian', 5, 300, 400, NULL, 1, N'STU Structures', N'Sản phẩm được sử dụng để tạo ra một không gian che chắn, bảo vệ khỏi ánh nắng, mưa hoặc gió.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (10, N'Sân khấu, backdrop', 5, 420, 450, NULL, 1, N'VWX Rentals', N'Sản phẩm được sử dụng trong các buổi biểu diễn âm nhạc, kịch nghệ và các chương trình sự kiện.', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (14, N'Máy chiếu Epson EB-U05', 1, 10, 500, N'https://example.com/epson-eb-u05.jpg', 1, N'Epson', N'Máy chi?u Epson EB-U05 là m?t s?n ph?m ch?t lu?ng v?i d? phân gi?i cao và d? sáng t?t d? ph?c v? cho các s? ki?n l?n.', NULL, N'Máy chi?u', N'USD', 100, N'1 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (15, N'Loa di động JBL Charge 4', 2, 20, 150, N'https://example.com/jbl-charge-4.jpg', 1, N'JBL', N'Loa di d?ng JBL Charge 4 là m?t s?n ph?m tuy?t v?i v?i âm thanh ch?t lu?ng cao và kh? nang ch?ng nu?c.', NULL, N'Loa di d?ng', N'USD', 50, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (16, N'Máy quay Sony Handycam HDR-CX405', 3, 5, 300, N'https://example.com/sony-handycam-hdr-cx405.jpg', 1, N'Sony', N'Máy quay Sony Handycam HDR-CX405 là m?t s?n ph?m ch?t lu?ng v?i kh? nang quay video Full HD và ch?ng rung t?t.', NULL, N'Máy quay', N'USD', 50, N'1 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (17, N'Máy chiếu Sony VPL-HW45ES', 2, 5, 1500, N'https://example.com/sony-vpl-hw45es.jpg', 1, N'Sony', N'Máy chi?u Sony VPL-HW45ES là m?t s?n ph?m ch?t lu?ng v?i d? phân gi?i cao và d? sáng t?t d? ph?c v? cho các s? ki?n l?n.', NULL, N'Máy chi?u', N'USD', 100, N'1 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (18, N'Micro Shure SM58', 2, 20, 100, N'https://example.com/shure-sm58.jpg', 1, N'Shure', N'Micro Shure SM58 là m?t s?n ph?m ch?t lu?ng v?i âm thanh rõ ràng và kh? nang ch?ng hú t?t.', NULL, N'Microphone', N'USD', 50, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (19, N'Ðầu karaoke Arirang AR3600', 4, 10, 300, N'https://example.com/arirang-ar3600.jpg', 1, N'Arirang', N'Ð?u karaoke Arirang AR3600 là m?t s?n ph?m ch?t lu?ng v?i kh? nang k?t n?i nhi?u thi?t b? và tính nang tìm ki?m bài hát nhanh chóng.', NULL, N'Ð?u karaoke', N'USD', 30, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (20, N'Màn hình LED Samsung U28E590D', 1, 10, 400, N'https://example.com/samsung-u28e590d.jpg', 1, N'Samsung', N'Màn hình LED Samsung U28E590D là m?t s?n ph?m ch?t lu?ng v?i d? phân gi?i cao và tính nang chia màn hình cho nhi?u thi?t b?.', NULL, N'Màn hình LED', N'USD', 20, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (21, N'Máy phun suong Mistral 30', 3, 5, 200, N'https://example.com/mistral-30.jpg', 1, N'Mistral', N'Máy phun suong Mistral 30 là m?t s?n ph?m ch?t lu?ng v?i kh? nang phun suong m?nh m? và ki?m soát du?c lu?ng nu?c phun.', NULL, N'Máy phun suong', N'USD', 10, N'3 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (22, N'Máy chiếu DLP', 1, 10, 500, N'https://example.com/epson-eb-u05.jpg', 1, N'DLP', N'DLP (Digital Light Processing) là công nghệ sử dụng chip xử lý quang học để tạo ra hình ảnh. Máy chiếu DLP thường có độ sáng cao, độ tương phản tốt và khả năng tái tạo màu sắc chính xác.', NULL, N'Máy chi?u', N'USD', 100, N'1 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (23, N'Máy chiếu đa phương tiện', 2, 20, 150, N'https://example.com/jbl-charge-4.jpg', 1, N'DPT', N'Loại máy chiếu này kết hợp giữa máy chiếu và các tính năng đa phương tiện khác như loa tích hợp, trình chiếu từ xa, khe cắm thẻ nhớ hoặc cổng USB để trình chiếu trực tiếp các tập tin đa phương tiện.', NULL, N'Máy chi?u', N'USD', 50, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (24, N'Máy chiếu ánh sáng laser', 3, 5, 300, N'https://example.com/sony-handycam-hdr-cx405.jpg', 1, N'Laser', N'Các máy chi?u ánh sáng laser s? d?ng công ngh? chi?u sáng b?ng laser thay vì bóng dèn truy?n th?ng. Ði?u này mang l?i l?i ích nhu tu?i th? cao, d? sáng t?t và kh? nang tái t?o màu s?c chính xác hon.', NULL, N'Máy chi?u', N'USD', 50, N'1 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (25, N'Máy quay phim DSLR', 2, 5, 1500, N'https://example.com/sony-vpl-hw45es.jpg', 1, N'DSRS', N'Đây là loại máy quay phim được sử dụng rộng rãi trong các sự kiện vì khả năng quay video chất lượng cao, độ phân giải cao và khả năng thay đổi ống kính..', NULL, N'Máy quay phim', N'USD', 100, N'1 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (26, N'Máy quay phim Mirrorless', 2, 20, 100, N'https://example.com/shure-sm58.jpg', 1, N'Mirrorless', N'Các máy quay phim mirrorless cũng được sử dụng trong các sự kiện vì chúng có độ phân giải cao và khả năng quay video chất lượng cao, nhưng chúng nhỏ gọn hơn so với máy quay DSLR..', NULL, N'Máy quay phim', N'USD', 50, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (27, N'Máy quay phim Mirrorless', 4, 10, 300, N'https://example.com/arirang-ar3600.jpg', 1, N'Arirang', N'Các máy quay phim chuyên nghiệp thường được sử dụng trong các sự kiện lớn, như hội nghị, triển lãm, và sự kiện âm nhạc. Chúng có khả năng quay video chất lượng cao, độ phân giải cao và các tính năng chuyên nghiệp khác.', NULL, N'Máy quay phim', N'USD', 30, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (28, N'Máy quay phim gắn trên Drone', 1, 10, 400, N'https://example.com/samsung-u28e590d.jpg', 1, N'Drone', N'DroneCác thiết bị bay không người lái (Drone) được trang bị máy quay phim gắn trên thường được sử dụng để quay video từ không gian cao hoặc để quay video các góc cảnh quay độc đáo.', NULL, N'Máy quay phim', N'USD', 20, N'2 nam b?o hành                                                                                      ')
INSERT [dbo].[Product] ([ProductId], [ProductName], [CategoryId], [UnitInStock], [UnitPrice], [Image], [StatusId], [Brand], [Description], [DiscountDate], [Type], [Moneytype], [Quality], [Maintaince]) VALUES (29, N'Máy quay phim điện thoại di động', 3, 5, 200, N'https://example.com/mistral-30.jpg', 1, N'Mistral', N'Đây là lựa chọn phổ biến và tiết kiệm chi phí cho các sự kiện nhỏ, với nhiều điện thoại thông minh hiện nay đã được trang bị tính năng quay video với chất lượng tốt..', NULL, N'Máy quay phim', N'USD', 10, N'3 nam b?o hành                                                                                      ')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Rent] ON 

INSERT [dbo].[Rent] ([BuyId], [OrderId], [CustomerId]) VALUES (2, 18, 16)
SET IDENTITY_INSERT [dbo].[Rent] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Blogger')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'Consultant')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (4, N'Customers')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (5, N'Manager')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (6, N'Sale')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (7, N'Shipper')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (8, N'Supplier')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (9, N'Technical')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale] ON 

INSERT [dbo].[Sale] ([SaleId], [FullName], [Phone], [Address], [DOB], [OrderId], [StatusId], [ShipperId], [CustomerId], [Avatar]) VALUES (1, N'Nguyễn Thị Anh', N'0987654321', N'Hà Nội', CAST(N'1990-01-01T00:00:00.000' AS DateTime), 1, 1, 2, 1, NULL)
INSERT [dbo].[Sale] ([SaleId], [FullName], [Phone], [Address], [DOB], [OrderId], [StatusId], [ShipperId], [CustomerId], [Avatar]) VALUES (2, N'Trần Văn Bình', N'0901234567', N'Tp.HCM', CAST(N'1985-05-20T00:00:00.000' AS DateTime), 2, 1, 1, 2, NULL)
INSERT [dbo].[Sale] ([SaleId], [FullName], [Phone], [Address], [DOB], [OrderId], [StatusId], [ShipperId], [CustomerId], [Avatar]) VALUES (3, N'Lê Minh Cung', N'0912345678', N'Đà Nẵng', CAST(N'2000-12-31T00:00:00.000' AS DateTime), 3, 1, 2, 2, NULL)
INSERT [dbo].[Sale] ([SaleId], [FullName], [Phone], [Address], [DOB], [OrderId], [StatusId], [ShipperId], [CustomerId], [Avatar]) VALUES (4, N'Phạm Thanh Danh', N'0976543210', N'Hải Phòng', CAST(N'1975-06-15T00:00:00.000' AS DateTime), 4, 2, 4, 3, NULL)
INSERT [dbo].[Sale] ([SaleId], [FullName], [Phone], [Address], [DOB], [OrderId], [StatusId], [ShipperId], [CustomerId], [Avatar]) VALUES (5, N'Đặng Hoàng Chung', N'0965432109', N'Nghệ An', CAST(N'1999-03-10T00:00:00.000' AS DateTime), 5, 1, 5, 4, NULL)
SET IDENTITY_INSERT [dbo].[Sale] OFF
GO
SET IDENTITY_INSERT [dbo].[Shipper] ON 

INSERT [dbo].[Shipper] ([ShipperID], [FullName], [Phone], [Address], [DOB], [Avatar], [OrderId], [StatusId], [CustomerId]) VALUES (1, N'Nguyễn Thành Long', N'0987433564', N'Hà Nội', CAST(N'1992-12-22T00:00:00.000' AS DateTime), NULL, 1, 1, 1)
INSERT [dbo].[Shipper] ([ShipperID], [FullName], [Phone], [Address], [DOB], [Avatar], [OrderId], [StatusId], [CustomerId]) VALUES (2, N'Trần Bình Dang', N'0987963746', N'Hải Phòng', CAST(N'1994-03-12T00:00:00.000' AS DateTime), NULL, 2, 2, 2)
INSERT [dbo].[Shipper] ([ShipperID], [FullName], [Phone], [Address], [DOB], [Avatar], [OrderId], [StatusId], [CustomerId]) VALUES (3, N'Nguyễn Trí Tuệ', N'0987673647', N'Hà Nội', CAST(N'1998-03-02T00:00:00.000' AS DateTime), NULL, 1, 1, 1)
INSERT [dbo].[Shipper] ([ShipperID], [FullName], [Phone], [Address], [DOB], [Avatar], [OrderId], [StatusId], [CustomerId]) VALUES (4, N'Lê Hoàng Anh', N'0937846573', N'Hà Tĩnh', CAST(N'1996-05-27T00:00:00.000' AS DateTime), NULL, 1, 2, 3)
INSERT [dbo].[Shipper] ([ShipperID], [FullName], [Phone], [Address], [DOB], [Avatar], [OrderId], [StatusId], [CustomerId]) VALUES (5, N'Kim Song Ngưu', N'0926374657', N'Hưng Yên', CAST(N'1991-07-29T00:00:00.000' AS DateTime), NULL, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Shipper] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (1, 1, N'Hoạt động                               ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (2, 2, N'Ngừng Hoạt Động                         ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (3, 3, N'Còn Hàng                                ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (4, 4, N'Hết Hàng                                ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (1002, 5, N'Chưa Được Manager Xác Nhận              ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (1003, 6, N'Chưa Được Sale Xác Nhận                 ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (1004, 7, N'Chưa Được Ship Xác Nhận                 ')
INSERT [dbo].[Status] ([StatusId], [StatusNum], [StatusValue]) VALUES (1005, 8, NULL)
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Technical] ON 

INSERT [dbo].[Technical] ([TechnicalId], [FullName], [Phone], [Address], [DOB], [Avatar], [StatusId]) VALUES (1, N'Nguyễn Văn Anh', N'0987654321', N'Hà Nội', CAST(N'1980-01-01T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Technical] ([TechnicalId], [FullName], [Phone], [Address], [DOB], [Avatar], [StatusId]) VALUES (2, N'Trần Thị Bắc', N'0901234567', N'Tp.HCM', CAST(N'1995-05-20T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Technical] ([TechnicalId], [FullName], [Phone], [Address], [DOB], [Avatar], [StatusId]) VALUES (3, N'Lê Minh Canh', N'0912345678', N'Đà Nẵng', CAST(N'1990-12-31T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[Technical] ([TechnicalId], [FullName], [Phone], [Address], [DOB], [Avatar], [StatusId]) VALUES (4, N'Phạm Thanh Dũng', N'0976543210', N'Hải Phòng', CAST(N'1985-06-15T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[Technical] ([TechnicalId], [FullName], [Phone], [Address], [DOB], [Avatar], [StatusId]) VALUES (5, N'Đặng Hoàng Nam', N'0965432109', N'Nghệ An', CAST(N'2000-03-10T00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[Technical] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Admin] FOREIGN KEY([AdminId])
REFERENCES [dbo].[Admin] ([AdminId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Admin]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Blogger] FOREIGN KEY([BloggerId])
REFERENCES [dbo].[Blogger] ([BloggerId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Blogger]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Consultant] FOREIGN KEY([ConsultantId])
REFERENCES [dbo].[Consultant] ([ConsultantId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Consultant]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Customers]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Manager] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Manager] ([ManagerId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Manager]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Sale] FOREIGN KEY([SaleId])
REFERENCES [dbo].[Sale] ([SaleId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Sale]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Shipper] FOREIGN KEY([ShipperId])
REFERENCES [dbo].[Shipper] ([ShipperID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Shipper]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Supplier]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Technical] FOREIGN KEY([TechnicalId])
REFERENCES [dbo].[Technical] ([TechnicalId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Technical]
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [FK_Blog_Blogger] FOREIGN KEY([BloggerId])
REFERENCES [dbo].[Blogger] ([BloggerId])
GO
ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [FK_Blog_Blogger]
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [FK_Blog_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [FK_Blog_Status]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Blogger] FOREIGN KEY([BloggerId])
REFERENCES [dbo].[Blogger] ([BloggerId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Blogger]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Customers]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Supplier]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Technical] FOREIGN KEY([TechnicalId])
REFERENCES [dbo].[Technical] ([TechnicalId])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Technical]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Status]
GO
ALTER TABLE [dbo].[FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Consultant] FOREIGN KEY([ConsultantId])
REFERENCES [dbo].[Consultant] ([ConsultantId])
GO
ALTER TABLE [dbo].[FeedBack] CHECK CONSTRAINT [FK_FeedBack_Consultant]
GO
ALTER TABLE [dbo].[FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[FeedBack] CHECK CONSTRAINT [FK_FeedBack_Customers]
GO
ALTER TABLE [dbo].[FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[FeedBack] CHECK CONSTRAINT [FK_FeedBack_Order]
GO
ALTER TABLE [dbo].[FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Shipper] FOREIGN KEY([ShipperId])
REFERENCES [dbo].[Shipper] ([ShipperID])
GO
ALTER TABLE [dbo].[FeedBack] CHECK CONSTRAINT [FK_FeedBack_Shipper]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Consultant] FOREIGN KEY([ConsultantId])
REFERENCES [dbo].[Consultant] ([ConsultantId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Consultant]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Conversation] FOREIGN KEY([ConversationId])
REFERENCES [dbo].[Conversation] ([ConversationId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Conversation]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Customers]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Status]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customers]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Sale] FOREIGN KEY([SaleId])
REFERENCES [dbo].[Sale] ([SaleId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Sale]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Shipper] FOREIGN KEY([ShipId])
REFERENCES [dbo].[Shipper] ([ShipperID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Shipper]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Status]
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [FK_Buy_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [FK_Buy_Customers]
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD  CONSTRAINT [FK_Buy_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[Rent] CHECK CONSTRAINT [FK_Buy_Order]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Status]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([SupplierId])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Supplier]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_SupplierProduct] FOREIGN KEY([ProductId])
REFERENCES [dbo].[SupplierProduct] ([ProductId])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_SupplierProduct]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Technical] FOREIGN KEY([TechnicalId])
REFERENCES [dbo].[Technical] ([TechnicalId])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Technical]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_Status]
GO
ALTER TABLE [dbo].[SupplierProduct]  WITH CHECK ADD  CONSTRAINT [FK_SupplierProduct_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[SupplierProduct] CHECK CONSTRAINT [FK_SupplierProduct_Category]
GO
ALTER TABLE [dbo].[SupplierStock]  WITH CHECK ADD  CONSTRAINT [FK_SupplierStock_SupplierProduct] FOREIGN KEY([ProductId])
REFERENCES [dbo].[SupplierProduct] ([ProductId])
GO
ALTER TABLE [dbo].[SupplierStock] CHECK CONSTRAINT [FK_SupplierStock_SupplierProduct]
GO
ALTER TABLE [dbo].[Technical]  WITH CHECK ADD  CONSTRAINT [FK_Technical_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Technical] CHECK CONSTRAINT [FK_Technical_Status]
GO
