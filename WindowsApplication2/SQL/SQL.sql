USE [master]
GO
/****** Object:  Database [ChuoiCuaHang]    Script Date: 05/05/2017 23:45:05 ******/
CREATE DATABASE [ChuoiCuaHang] ON  PRIMARY 
( NAME = N'ChuoiCuaHang', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ChuoiCuaHang.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ChuoiCuaHang_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\ChuoiCuaHang_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ChuoiCuaHang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChuoiCuaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChuoiCuaHang] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET ARITHABORT OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ChuoiCuaHang] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ChuoiCuaHang] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ChuoiCuaHang] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET  DISABLE_BROKER
GO
ALTER DATABASE [ChuoiCuaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ChuoiCuaHang] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ChuoiCuaHang] SET  READ_WRITE
GO
ALTER DATABASE [ChuoiCuaHang] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ChuoiCuaHang] SET  MULTI_USER
GO
ALTER DATABASE [ChuoiCuaHang] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ChuoiCuaHang] SET DB_CHAINING OFF
GO
USE [ChuoiCuaHang]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 05/05/2017 23:45:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID_nv] [nvarchar](30) NOT NULL,
	[MK_nv] [nvarchar](50) NULL,
	[GhiChu_nv] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID_nv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([ID_nv], [MK_nv], [GhiChu_nv]) VALUES (N'admin', N'admin', N'asdas')
INSERT [dbo].[TaiKhoan] ([ID_nv], [MK_nv], [GhiChu_nv]) VALUES (N'b', N'b', N'b')
/****** Object:  Table [dbo].[NhaCC]    Script Date: 05/05/2017 23:45:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[ID_nhaCC] [nvarchar](30) NOT NULL,
	[Ten_nhaCC] [nvarchar](50) NULL,
	[DT_nhaCC] [int] NULL,
	[DC_nhaCC] [nvarchar](50) NULL,
	[Email_nhaCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCC] PRIMARY KEY CLUSTERED 
(
	[ID_nhaCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhaCC] ([ID_nhaCC], [Ten_nhaCC], [DT_nhaCC], [DC_nhaCC], [Email_nhaCC]) VALUES (N'NCC001', N'bibi', 123456789, N'Hà Nội', N'Bibi@gmail.com')
INSERT [dbo].[NhaCC] ([ID_nhaCC], [Ten_nhaCC], [DT_nhaCC], [DC_nhaCC], [Email_nhaCC]) VALUES (N'NCC002', N'caca', 12346, N'Hải Phòng', N'Ca@gmail.com')
INSERT [dbo].[NhaCC] ([ID_nhaCC], [Ten_nhaCC], [DT_nhaCC], [DC_nhaCC], [Email_nhaCC]) VALUES (N'NCC003', N'Haha', 1234444, N'Hải Dương', N'Haha@gmail.com')
INSERT [dbo].[NhaCC] ([ID_nhaCC], [Ten_nhaCC], [DT_nhaCC], [DC_nhaCC], [Email_nhaCC]) VALUES (N'NCC004', N'AA', 9999999, N'Sơn La', N'AA@gmail.com')
INSERT [dbo].[NhaCC] ([ID_nhaCC], [Ten_nhaCC], [DT_nhaCC], [DC_nhaCC], [Email_nhaCC]) VALUES (N'NCC005', N'bbb', 89898989, N'Sơn La', N'bbb@gmai.com')
/****** Object:  Table [dbo].[Khachhang]    Script Date: 05/05/2017 23:45:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[ID_kh] [nvarchar](30) NOT NULL,
	[Ten_kh] [nvarchar](50) NULL,
	[DC_kh] [nvarchar](50) NULL,
	[DT_kh] [int] NULL,
	[GT_kh] [nchar](10) NULL,
	[Email_kh] [nchar](20) NULL,
	[Date_kh] [date] NULL,
 CONSTRAINT [PK_Khachhang] PRIMARY KEY CLUSTERED 
(
	[ID_kh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 05/05/2017 23:45:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ID_sp] [nvarchar](30) NOT NULL,
	[ID_nhaCC] [nvarchar](30) NULL,
	[Ten_sp] [nvarchar](50) NULL,
	[SoLuong_sp] [int] NULL,
	[TT_sp] [nvarchar](50) NULL,
	[HSD_sp] [date] NULL,
	[GiaBan_sp] [float] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ID_sp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuaHang]    Script Date: 05/05/2017 23:45:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuaHang](
	[ID_CHang] [nvarchar](30) NOT NULL,
	[Ten_CHang] [nvarchar](50) NULL,
	[DC_CHang] [nvarchar](50) NULL,
	[DT_CHang] [nchar](10) NULL,
	[Email_CHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[ID_CHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CuaHang] ([ID_CHang], [Ten_CHang], [DC_CHang], [DT_CHang], [Email_CHang]) VALUES (N'123', N'a', N'a', N'123456    ', N'a')
/****** Object:  Table [dbo].[ChucVu]    Script Date: 05/05/2017 23:45:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[ID_cv] [nvarchar](30) NOT NULL,
	[Ten_cv] [nvarchar](50) NOT NULL,
	[QuyenHan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[ID_cv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([ID_cv], [Ten_cv], [QuyenHan]) VALUES (N'1', N'cam', N'abc')
INSERT [dbo].[ChucVu] ([ID_cv], [Ten_cv], [QuyenHan]) VALUES (N'a', N'aa', N'a')
/****** Object:  StoredProcedure [dbo].[sp_insertNCC]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertNCC] 
	-- Add the parameters for the stored procedure here
	@id NVARCHAR(50),
	@name NVARCHAR(50),
	@Add NVARCHAR(50),
	@phone INTEGER,
	@Email NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO dbo.NhaCC
	        ( ID_nhaCC ,
	          Ten_nhaCC ,
	          DT_nhaCC ,
	          DC_nhaCC ,
	          Email_nhaCC
	        )
	VALUES  ( @id , -- ID_nhaCC - nvarchar(30)
	          @name , -- Ten_nhaCC - nvarchar(50)
	          @phone, -- DT_nhaCC - int
	          @Add , -- DC_nhaCC - nvarchar(50)
	          @Email -- Email_nhaCC - nvarchar(50)
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertKH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertKH]
@ID NVARCHAR(50),
@Name NVARCHAR(50),
@DC NVARCHAR(50),
@DT int,
@GT nchar(20),
@Email NVARCHAR(50),
@Date date
AS
BEGIN
	INSERT INTO dbo.Khachhang
	        ( ID_kh ,
	          Ten_kh ,
	          DC_kh ,
	          DT_kh ,
	          GT_kh ,
	          Email_kh ,
	          Date_kh
	        )
	VALUES  ( @ID , -- ID_kh - nvarchar(30)
	          @Name , -- Ten_kh - nvarchar(50)
	         @DC , -- DC_kh - nvarchar(50)
	          @DT, -- DT_kh - int
	         @GT , -- GT_kh - nchar(10)
	          @Email , -- Email_kh - nchar(20)
	          @Date  -- Date_kh - date
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertChucVu]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertChucVu]
	-- Add the parameters for the stored procedure here
	@ma NVARCHAR(50),
	@ten NVARCHAR(50),
	@note NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.ChucVu
	        ( ID_cv, Ten_cv, QuyenHan )
	VALUES  ( @ma, -- ID_cv - nvarchar(30)
	          @ten, -- Ten_cv - nvarchar(50)
	          @note  -- QuyenHan - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertCH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertCH]
@ma NVARCHAR(50),
@ten NVARCHAR(50),
@dc NVARCHAR(50),
@dt NVARCHAR(50),
@mail NVARCHAR(50)
as	
BEGIN
	INSERT dbo.CuaHang
	        ( ID_CHang ,
	          Ten_CHang ,
	          DC_CHang ,
	          DT_CHang ,
	          Email_CHang
	        )
	VALUES  ( @ma , -- ID_CHang - nvarchar(30)
	          @ten , -- Ten_CHang - nvarchar(50)
	          @dc , -- DC_CHang - nvarchar(50)
	          @dt , -- DT_CHang - nchar(10)
	          @mail  -- Email_CHang - nvarchar(50)
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deTK]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deTK]
@ma NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DELETE dbo.TaiKhoan WHERE ID_nv = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[sp_countTK]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_countTK]
AS
BEGIN
	SELECT COUNT(*) FROM dbo.TaiKhoan
END
GO
/****** Object:  Table [dbo].[CTNhaCC]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTNhaCC](
	[ID_sp] [nvarchar](30) NOT NULL,
	[ID_nhaCC] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_CTNhaCC] PRIMARY KEY CLUSTERED 
(
	[ID_sp] ASC,
	[ID_nhaCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_loadNhacCC]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_loadNhacCC]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	SELECT * FROM	dbo.NhaCC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadKH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadKH]
AS
BEGIN
	SELECT * FROM dbo.Khachhang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadChucVu]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[sp_LoadChucVu]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SELECT * FROM dbo.ChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadCH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadCH]
as	
BEGIN
	SELECT * FROM dbo.CuaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertTK]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertTK]
@ma NVARCHAR(50),
@Matkhau NVARCHAR(50),
@note NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO dbo.TaiKhoan
	        ( ID_nv, MK_nv, GhiChu_nv )
	VALUES  ( @ma, -- ID_nv - nvarchar(30)
	          @Matkhau, -- MK_nv - nvarchar(50)
	          @note  -- GhiChu_nv - nvarchar(50)
	          )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertSP]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertSP]
@ID_sp NVARCHAR(50),
@ID_NCC NVARCHAR(50),
@Name NVARCHAR(50),
@SL int,
@TT NVARCHAR(50),
@HSD DATE,
@Gia_sp FLOAT
AS
BEGIN
	INSERT INTO dbo.SanPham
	        ( ID_sp ,
	          ID_nhaCC ,
	          Ten_sp ,
	          SoLuong_sp ,
	          TT_sp ,
	          HSD_sp ,
	          GiaBan_sp
	        )
	VALUES  ( @ID_sp , -- ID_sp - nvarchar(30)
	          @ID_NCC , -- ID_nhaCC - nvarchar(30)
	          @Name , -- Ten_sp - nvarchar(50)
	          @SL, -- SoLuong_sp - int
	          @TT , -- TT_sp - nvarchar(50)
	          @HSD , -- HSD_sp - date
	          @Gia_sp  -- GiaBan_sp - float
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveNCC]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RemoveNCC]
@ma NVARCHAR(50)
AS
BEGIN
	DELETE dbo.NhaCC WHERE ID_nhaCC = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveKH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RemoveKH]
@ID NVARCHAR(50)
AS
BEGIN
	DELETE dbo.Khachhang WHERE ID_kh = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveCV]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RemoveCV]
@ID NVARCHAR(50)
AS
BEGIN
	DELETE dbo.ChucVu WHERE ID_cv = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_removeCH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_removeCH]
@ma NVARCHAR(50)
as	
BEGIN
	DELETE dbo.CuaHang WHERE ID_CHang = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadTaiKhoan]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadTaiKhoan]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
SELECT * FROM	dbo.TaiKhoan
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadSP]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadSP]
AS
BEGIN
	SELECT * FROM dbo.SanPham
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateNCC]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateNCC]
@ma NVARCHAR(50),
@ten NVARCHAR(50),
@dc NVARCHAR(50),
@dt INTEGER,
@email NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.NhaCC SET Ten_nhaCC = @ten, DT_nhaCC = @dt, DC_nhaCC = @dc,Email_nhaCC = @email
	WHERE ID_nhaCC = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateKH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateKH]
@ID NVARCHAR(50),
@Name NVARCHAR(50),
@DC NVARCHAR(50),
@DT int,
@GT nchar(20),
@Email NVARCHAR(50),
@Date date
AS
BEGIN
	UPDATE dbo.Khachhang SET
		Ten_kh = @Name, DC_kh = @DC, DT_kh = @DT,GT_kh =@GT, Email_kh = @Email,Date_kh= @Date 
		WHERE ID_kh = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCV]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateCV]
@ID NVARCHAR(50),
@Ten NVARCHAR(50),
@Quyen NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.ChucVu SET
		Ten_cv = @Ten, QuyenHan = @Quyen
		WHERE ID_cv = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCH]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateCH]
@ma NVARCHAR(50),
@ten NVARCHAR(50),
@phone INTEGER,
@dc NVARCHAR(50),
@email NVARCHAR(50)
as	
BEGIN
	UPDATE dbo.CuaHang SET Ten_CHang = @ten, DC_CHang = @dc, DT_CHang = @phone,Email_CHang = @email
	WHERE ID_CHang = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchTK]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SearchTK]
@ma NVARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan 
	WHERE ID_nv LIKE '%'+ @ma+ '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveTK]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RemoveTK]
@ID NVARCHAR(50)
AS
BEGIN
	DELETE dbo.TaiKhoan WHERE ID_nv = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveSP]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RemoveSP]
@ID NVARCHAR(50)
AS
BEGIN
	DELETE dbo.SanPham WHERE ID_sp = @ID
END
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID_nv] [nvarchar](30) NOT NULL,
	[Ten_nv] [nvarchar](50) NULL,
	[GT_nv] [nchar](10) NULL,
	[DC_nv] [nvarchar](50) NULL,
	[DT_nv] [int] NULL,
	[Email_nv] [nchar](20) NULL,
	[ID_CHang] [nvarchar](30) NULL,
	[ID_cv] [nvarchar](30) NULL,
	[Date_nv] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID_nv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTCuaHang]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTCuaHang](
	[ID_sp] [nvarchar](30) NOT NULL,
	[ID_CHang] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_CTCuaHang] PRIMARY KEY CLUSTERED 
(
	[ID_sp] ASC,
	[ID_CHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateTK]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_updateTK]
@ma NVARCHAR(50),
@pass NVARCHAR(50),
@note NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.TaiKhoan
	SET  MK_nv = @pass, GhiChu_nv = @note 
	WHERE ID_nv = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSP]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateSP]
@ID NVARCHAR(50),
@Name NVARCHAR(50),
@TT NVARCHAR(50),
@sl int,
@HSD Date,
@Gia FLOAT,
@ID_nhaCC NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.SanPham SET
		 Ten_sp = @Name, ID_nhaCC = @ID_nhaCC,SoLuong_sp = @sl, TT_sp = @TT, HSD_sp = @HSD,GiaBan_sp = @Gia
		WHERE ID_sp  = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateNV]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateNV]
@ID NVARCHAR(50),
@Name NVARCHAR(50),
@DC NVARCHAR(50),
@DT int,
@GT nchar(20),
@Email NVARCHAR(50),
@ID_CHang NVARCHAR(50),
@ID_cv NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.NhanVien SET
		 Ten_nv = @Name, GT_nv = @GT, DC_nv = @DC, DT_nv = @DT, Email_nv = @Email, ID_CHang = @ID_CHang, ID_cv = @ID_cv
		WHERE ID_nv  = @ID
END
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[ID_hdn] [nvarchar](30) NOT NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [float] NULL,
	[ID_nv] [nvarchar](30) NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[ID_hdn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBan](
	[ID_hdb] [nvarchar](30) NOT NULL,
	[NgayBan] [date] NULL,
	[TongTien] [float] NULL,
	[ID_nv] [nvarchar](30) NULL,
	[ID_kh] [nvarchar](30) NULL,
 CONSTRAINT [PK_HoaDonBan] PRIMARY KEY CLUSTERED 
(
	[ID_hdb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_RemoveNV]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[sp_RemoveNV]
@ID NVARCHAR(50)
AS
BEGIN
	DELETE dbo.NhanVien WHERE ID_nv = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadNV]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadNV]
	
AS
BEGIN
	SELECT * FROM dbo.NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insertNV]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertNV]
@ID NVARCHAR(50),
@Name NVARCHAR(50),
@DC NVARCHAR(50),
@DT int,
@GT nchar(20),
@Email NVARCHAR(50),
@ID_CHang nvarchar(30),
@ID_cv nvarchar(30),
@Date date
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( ID_nv ,
	          Ten_nv ,
	          GT_nv ,
	          DC_nv ,
	          DT_nv ,
	          Email_nv ,
	          ID_CHang ,
	          ID_cv ,
	          Date_nv
	        )
	VALUES  ( @ID , -- ID_nv - nvarchar(30)
	          @Name , -- Ten_nv - nvarchar(50)
	          @GT , -- GT_nv - nchar(10)
	          @DC , -- DC_nv - nvarchar(50)
	          @DT , -- DT_nv - int
	          @Email , -- Email_nv - nchar(20)
	          @ID_CHang , -- ID_CHang - nvarchar(30)
	          @ID_cv , -- ID_cv - nvarchar(30)
	          @Date  -- Date_nv - date
	        )
END
GO
/****** Object:  Table [dbo].[CTHoaDonNhap]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDonNhap](
	[ID_hdn] [nvarchar](30) NOT NULL,
	[ID_sp] [nvarchar](30) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
	[GiaNhap_sp] [float] NULL,
 CONSTRAINT [PK_CTHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[ID_hdn] ASC,
	[ID_sp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHoaDonBan]    Script Date: 05/05/2017 23:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDonBan](
	[ID_hdb] [nvarchar](30) NOT NULL,
	[ID_sp] [nvarchar](30) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CTHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[ID_hdb] ASC,
	[ID_sp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_CTNhaCC_NhaCC]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTNhaCC]  WITH CHECK ADD  CONSTRAINT [FK_CTNhaCC_NhaCC] FOREIGN KEY([ID_nhaCC])
REFERENCES [dbo].[NhaCC] ([ID_nhaCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTNhaCC] CHECK CONSTRAINT [FK_CTNhaCC_NhaCC]
GO
/****** Object:  ForeignKey [FK_CTNhaCC_SanPham]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTNhaCC]  WITH CHECK ADD  CONSTRAINT [FK_CTNhaCC_SanPham] FOREIGN KEY([ID_sp])
REFERENCES [dbo].[SanPham] ([ID_sp])
GO
ALTER TABLE [dbo].[CTNhaCC] CHECK CONSTRAINT [FK_CTNhaCC_SanPham]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChucVu]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([ID_cv])
REFERENCES [dbo].[ChucVu] ([ID_cv])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
/****** Object:  ForeignKey [FK_NhanVien_Kho]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Kho] FOREIGN KEY([ID_CHang])
REFERENCES [dbo].[CuaHang] ([ID_CHang])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Kho]
GO
/****** Object:  ForeignKey [FK_CTCuaHang_CuaHang]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTCuaHang]  WITH CHECK ADD  CONSTRAINT [FK_CTCuaHang_CuaHang] FOREIGN KEY([ID_CHang])
REFERENCES [dbo].[CuaHang] ([ID_CHang])
GO
ALTER TABLE [dbo].[CTCuaHang] CHECK CONSTRAINT [FK_CTCuaHang_CuaHang]
GO
/****** Object:  ForeignKey [FK_CTCuaHang_SanPham]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTCuaHang]  WITH CHECK ADD  CONSTRAINT [FK_CTCuaHang_SanPham] FOREIGN KEY([ID_sp])
REFERENCES [dbo].[SanPham] ([ID_sp])
GO
ALTER TABLE [dbo].[CTCuaHang] CHECK CONSTRAINT [FK_CTCuaHang_SanPham]
GO
/****** Object:  ForeignKey [FK_HoaDonNhap_NhanVien]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien] FOREIGN KEY([ID_nv])
REFERENCES [dbo].[NhanVien] ([ID_nv])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_HoaDonBan_Khachhang]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_Khachhang] FOREIGN KEY([ID_kh])
REFERENCES [dbo].[Khachhang] ([ID_kh])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_Khachhang]
GO
/****** Object:  ForeignKey [FK_HoaDonBan_NhanVien]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan_NhanVien] FOREIGN KEY([ID_nv])
REFERENCES [dbo].[NhanVien] ([ID_nv])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan_NhanVien]
GO
/****** Object:  ForeignKey [FK_CTHoaDonNhap_HoaDonNhap]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDonNhap_HoaDonNhap] FOREIGN KEY([ID_hdn])
REFERENCES [dbo].[HoaDonNhap] ([ID_hdn])
GO
ALTER TABLE [dbo].[CTHoaDonNhap] CHECK CONSTRAINT [FK_CTHoaDonNhap_HoaDonNhap]
GO
/****** Object:  ForeignKey [FK_CTHoaDonNhap_SanPham]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDonNhap_SanPham] FOREIGN KEY([ID_sp])
REFERENCES [dbo].[SanPham] ([ID_sp])
GO
ALTER TABLE [dbo].[CTHoaDonNhap] CHECK CONSTRAINT [FK_CTHoaDonNhap_SanPham]
GO
/****** Object:  ForeignKey [FK_CTHoaDonBan_HoaDonBan]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDonBan_HoaDonBan] FOREIGN KEY([ID_hdb])
REFERENCES [dbo].[HoaDonBan] ([ID_hdb])
GO
ALTER TABLE [dbo].[CTHoaDonBan] CHECK CONSTRAINT [FK_CTHoaDonBan_HoaDonBan]
GO
/****** Object:  ForeignKey [FK_CTHoaDonBan_SanPham]    Script Date: 05/05/2017 23:45:06 ******/
ALTER TABLE [dbo].[CTHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDonBan_SanPham] FOREIGN KEY([ID_sp])
REFERENCES [dbo].[SanPham] ([ID_sp])
GO
ALTER TABLE [dbo].[CTHoaDonBan] CHECK CONSTRAINT [FK_CTHoaDonBan_SanPham]
GO
