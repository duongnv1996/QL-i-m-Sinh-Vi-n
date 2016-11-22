USE [SinhVien]
GO
/****** Object:  Table [dbo].[account]    Script Date: 11/22/2016 7:34:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[account](
	[masv] [varchar](10) NOT NULL,
	[password] [nvarchar](50) NULL,
	[quyen] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bangdiem]    Script Date: 11/22/2016 7:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bangdiem](
	[masv] [varchar](10) NOT NULL,
	[mamonhoc] [varchar](10) NOT NULL,
	[diemtp] [real] NULL,
	[diemthilan1] [real] NULL,
	[diemthilan2] [real] NULL,
	[tkmonlan1he10] [real] NULL,
	[tkmonlan1he4] [real] NULL,
	[tkmonlan2he10] [real] NULL,
	[tkmonlan2he4] [real] NULL,
	[tkmonhe10] [real] NULL,
	[tkmonhe4] [real] NULL,
	[tkmonhechu] [varchar](2) NULL,
	[sotietnghi] [int] NULL,
	[trangthai] [text] NULL,
 CONSTRAINT [PK_bangdiem] PRIMARY KEY CLUSTERED 
(
	[masv] ASC,
	[mamonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 11/22/2016 7:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khoa](
	[makhoa] [varchar](10) NOT NULL,
	[tenkhoa] [varchar](50) NULL,
 CONSTRAINT [PK_khoa] PRIMARY KEY CLUSTERED 
(
	[makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lop]    Script Date: 11/22/2016 7:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lop](
	[malop] [varchar](10) NOT NULL,
	[tenlop] [varchar](50) NULL,
	[makhoa] [varchar](10) NOT NULL,
 CONSTRAINT [PK_lop] PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[monhoc]    Script Date: 11/22/2016 7:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[monhoc](
	[mamonhoc] [varchar](10) NOT NULL,
	[tenmonhoc] [varchar](50) NULL,
	[tongsotiet] [int] NULL,
	[sotinchi] [int] NULL,
	[hocky] [int] NULL,
 CONSTRAINT [PK_monhoc] PRIMARY KEY CLUSTERED 
(
	[mamonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 11/22/2016 7:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masv] [varchar](10) NOT NULL,
	[hoten] [varchar](50) NULL,
	[malop] [varchar](10) NOT NULL,
	[ngaysinh] [varchar](30) NULL,
	[diachi] [varchar](50) NULL,
	[gioitinh] [varchar](10) NULL,
	[tenkhoa] [varchar](10) NULL,
 CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tongket]    Script Date: 11/22/2016 7:34:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tongket](
	[masv] [varchar](10) NOT NULL,
	[diemtkhe10] [real] NULL,
	[diemtkhe4] [real] NULL,
	[sotcdat] [int] NULL,
	[diemtlky1] [real] NULL,
	[diemtlky2] [real] NULL,
	[diemtlky3] [real] NULL,
	[diemtlky4] [real] NULL,
	[diemtlky5] [real] NULL,
	[diemtlky6] [real] NULL,
	[diemtlky7] [real] NULL,
	[diemtlky8] [real] NULL,
	[diemtlky9] [real] NULL,
 CONSTRAINT [PK_tongket] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[account] ([masv], [password], [quyen]) VALUES (N'sv06', N'123123', 1)
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv01', N'mh01', 10, 9, 10, 9.299999, 4, 10, 4, 10, 4, N'A+', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv01', N'mh02', 10, 10, 10, 10, 4, 10, 4, 10, 4, N'A+', 1, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv01', N'mh03', 10, 10, 10, 10, 4, 10, 4, 10, 4, N'A+', 1, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh01', 10, 1, 10, 3.7, 0, 10, 4, 10, 4, N'A+', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh02', 5, 6, 7, 5.7, 2, 6.4, 2, 6.4, 2, N'C', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh03', 7, 7, 7, 7, 3, 7, 3, 7, 3, N'B', 5, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh04', 7, 7, 7, 7, 3, 7, 3, 7, 3, N'B', 5, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh05', 0, 0, 0, 0, 0, 0, 0, 0, 0, N'F', 5, N'Hoc Lai')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh06', 4, 4, 4, 4, 1, 4, 1, 4, 1, N'D', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh07', 5.5, 5.5, 5.5, 5.5, 2, 5.5, 2, 5.5, 2, N'C', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh08', 6, 5.5, 7, 5.65, 2, 6.7, 2.5, 6.7, 2.5, N'C+', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv02', N'mh09', 4, 3.5, 4, 3.65, 0, 4, 1, 4, 1, N'D', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh01', 10, 10, 10, 10, 4, 10, 4, 10, 4, N'A+', 0, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh02', 5, 6, 7, 5.7, 2, 6.4, 2, 6.4, 2, N'C', 1, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh03', 5, 10, 8, 8.5, 3.7, 7.1, 3, 8.5, 3.7, N'A', 5, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh04', 5, 5, 5, 5, 1, 5, 1, 5, 1, N'D', 1, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh05', 4, 3, 5, 3.3, 0, 4.7, 1, 4.7, 1, N'D', 1, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh06', 6, 5.5, 7, 5.65, 2, 6.7, 2.5, 6.7, 2.5, N'C+', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh07', 10, 8, 8, 8.6, 3.7, 8.6, 3.7, 8.6, 3.7, N'A', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh08', 6, 5.5, 7, 5.65, 2, 6.7, 2.5, 6.7, 2.5, N'C+', 8, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv03', N'mh09', 7, 10, 7, 9.1, 4, 7, 3, 9.1, 4, N'A+', 0, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv04', N'mh01', 7, 10, 7, 9.1, 4, 7, 3, 9.1, 4, N'A+', 0, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv04', N'mh02', 5, 6, 7, 5.7, 2, 6.4, 2, 6.4, 2, N'C', 1, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv04', N'mh03', 5, 10, 8, 8.5, 3.7, 7.1, 3, 8.5, 3.7, N'A', 5, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv04', N'mh04', 9, 6, 7, 6.9, 2.5, 7.6, 3, 7.6, 3, N'B', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv04', N'mh05', 2, 9, 10, 6.9, 2.5, 7.6, 3, 7.6, 3, N'B', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv05', N'mh01', 5, 9, 10, 7.8, 3, 8.5, 3.7, 8.5, 3.7, N'A', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv05', N'mh02', 2, 9, 10, 6.9, 2.5, 7.6, 3, 7.6, 3, N'B', 4, N'Qua Mon')
INSERT [dbo].[bangdiem] ([masv], [mamonhoc], [diemtp], [diemthilan1], [diemthilan2], [tkmonlan1he10], [tkmonlan1he4], [tkmonlan2he10], [tkmonlan2he4], [tkmonhe10], [tkmonhe4], [tkmonhechu], [sotietnghi], [trangthai]) VALUES (N'sv05', N'mh03', 10, 5, 7, 6.5, 2.5, 7.9, 3, 7.9, 3, N'B', 4, N'Qua Mon')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'mk01', N'CNTT')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'mk02', N'QLNL')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'mk03', N'QTDLKS')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'mk04', N'TKDH')
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'mk05', N'QTKD')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'ml01', N'D9CNPM', N'mk01')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'ml02', N'D9QTANM', N'mk01')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'ml03', N'D9TMDT', N'mk01')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'ml04', N'D9KHMT', N'mk01')
INSERT [dbo].[lop] ([malop], [tenlop], [makhoa]) VALUES (N'ml05', N'D9TKDH', N'mk01')
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh01', N'C', 30, 2, 1)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh02', N'C++', 30, 2, 2)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh03', N'C#', 30, 2, 3)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh04', N'SQL', 30, 2, 4)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh05', N'PS', 30, 2, 5)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh06', N'AI', 30, 2, 6)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh07', N'LR', 30, 2, 7)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh08', N'.NET', 30, 2, 8)
INSERT [dbo].[monhoc] ([mamonhoc], [tenmonhoc], [tongsotiet], [sotinchi], [hocky]) VALUES (N'mh09', N'Java', 30, 2, 9)
INSERT [dbo].[sinhvien] ([masv], [hoten], [malop], [ngaysinh], [diachi], [gioitinh], [tenkhoa]) VALUES (N'sv01', N'iji', N'ml01', N'03-02-1996', N'Quang Ninh', N'Nam', N'CNTT')
INSERT [dbo].[sinhvien] ([masv], [hoten], [malop], [ngaysinh], [diachi], [gioitinh], [tenkhoa]) VALUES (N'sv02', N'Pham Thi Hue', N'ml01', N'20-01-1996', N'Hai Phong', N'Nu', N'CNTT')
INSERT [dbo].[sinhvien] ([masv], [hoten], [malop], [ngaysinh], [diachi], [gioitinh], [tenkhoa]) VALUES (N'sv03', N'Nguyen Thi Hoa', N'ml01', N'08-01-1996', N'Da Nang', N'Nu', N'CNTT')
INSERT [dbo].[sinhvien] ([masv], [hoten], [malop], [ngaysinh], [diachi], [gioitinh], [tenkhoa]) VALUES (N'sv04', N'Le Thanh Duong', N'ml01', N'01-08-1996', N'Lao Cao', N'Nam', N'CNTT')
INSERT [dbo].[sinhvien] ([masv], [hoten], [malop], [ngaysinh], [diachi], [gioitinh], [tenkhoa]) VALUES (N'sv05', N'Ninh Hoang Ngoc', N'ml01', N'19-01-1996', N'Nghe An', N'Nu', N'CNTT')
INSERT [dbo].[sinhvien] ([masv], [hoten], [malop], [ngaysinh], [diachi], [gioitinh], [tenkhoa]) VALUES (N'sv06', N'test', N'ml01', N'11-11-1111', N'test', N'nam', N'CNTT')
INSERT [dbo].[tongket] ([masv], [diemtkhe10], [diemtkhe4], [sotcdat], [diemtlky1], [diemtlky2], [diemtlky3], [diemtlky4], [diemtlky5], [diemtlky6], [diemtlky7], [diemtlky8], [diemtlky9]) VALUES (N'sv01', 6.66666651, 2.66666675, 6, 4, 4, 4, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tongket] ([masv], [diemtkhe10], [diemtkhe4], [sotcdat], [diemtlky1], [diemtlky2], [diemtlky3], [diemtlky4], [diemtlky5], [diemtlky6], [diemtlky7], [diemtlky8], [diemtlky9]) VALUES (N'sv02', 4.51111126, 1.61111116, 16, 0, 2, 3, 3, 0, 1, 0, 0, 0)
INSERT [dbo].[tongket] ([masv], [diemtkhe10], [diemtkhe4], [sotcdat], [diemtlky1], [diemtlky2], [diemtlky3], [diemtlky4], [diemtlky5], [diemtlky6], [diemtlky7], [diemtlky8], [diemtlky9]) VALUES (N'sv03', 7.3, 2.711111, 18, 4, 2, 3.7, 1, 1, 2.5, 3.7, 2.5, 4)
INSERT [dbo].[tongket] ([masv], [diemtkhe10], [diemtkhe4], [sotcdat], [diemtlky1], [diemtlky2], [diemtlky3], [diemtlky4], [diemtlky5], [diemtlky6], [diemtlky7], [diemtlky8], [diemtlky9]) VALUES (N'sv04', 7.84, 3.14, 10, 4, 2, 3.7, 3, 3, 0, NULL, NULL, NULL)
INSERT [dbo].[tongket] ([masv], [diemtkhe10], [diemtkhe4], [sotcdat], [diemtlky1], [diemtlky2], [diemtlky3], [diemtlky4], [diemtlky5], [diemtlky6], [diemtlky7], [diemtlky8], [diemtlky9]) VALUES (N'sv05', 5.366667, 2.23333335, 6, 3.7, 3, 3.7, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tongket] ([masv], [diemtkhe10], [diemtkhe4], [sotcdat], [diemtlky1], [diemtlky2], [diemtlky3], [diemtlky4], [diemtlky5], [diemtlky6], [diemtlky7], [diemtlky8], [diemtlky9]) VALUES (N'sv06', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
ALTER TABLE [dbo].[account]  WITH CHECK ADD  CONSTRAINT [FK_account_sinhvien] FOREIGN KEY([masv])
REFERENCES [dbo].[sinhvien] ([masv])
GO
ALTER TABLE [dbo].[account] CHECK CONSTRAINT [FK_account_sinhvien]
GO
ALTER TABLE [dbo].[bangdiem]  WITH CHECK ADD  CONSTRAINT [FK_bangdiem_monhoc] FOREIGN KEY([mamonhoc])
REFERENCES [dbo].[monhoc] ([mamonhoc])
GO
ALTER TABLE [dbo].[bangdiem] CHECK CONSTRAINT [FK_bangdiem_monhoc]
GO
ALTER TABLE [dbo].[bangdiem]  WITH CHECK ADD  CONSTRAINT [FK_bangdiem_sinhvien] FOREIGN KEY([masv])
REFERENCES [dbo].[sinhvien] ([masv])
GO
ALTER TABLE [dbo].[bangdiem] CHECK CONSTRAINT [FK_bangdiem_sinhvien]
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK_lop_khoa] FOREIGN KEY([makhoa])
REFERENCES [dbo].[khoa] ([makhoa])
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK_lop_khoa]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_lop] FOREIGN KEY([malop])
REFERENCES [dbo].[lop] ([malop])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_lop]
GO
ALTER TABLE [dbo].[tongket]  WITH CHECK ADD  CONSTRAINT [FK_tongket_sinhvien] FOREIGN KEY([masv])
REFERENCES [dbo].[sinhvien] ([masv])
GO
ALTER TABLE [dbo].[tongket] CHECK CONSTRAINT [FK_tongket_sinhvien]
GO
