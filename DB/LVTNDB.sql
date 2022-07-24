USE [master]
GO
/****** Object:  Database [LVTN]    Script Date: 20/07/2022 9:40:14 SA ******/
CREATE DATABASE [LVTN]
 CONTAINMENT = NONE


GO
ALTER DATABASE [LVTN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LVTN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LVTN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LVTN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LVTN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LVTN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LVTN] SET ARITHABORT OFF 
GO
ALTER DATABASE [LVTN] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LVTN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LVTN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LVTN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LVTN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LVTN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LVTN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LVTN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LVTN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LVTN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LVTN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LVTN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LVTN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LVTN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LVTN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LVTN] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LVTN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LVTN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LVTN] SET  MULTI_USER 
GO
ALTER DATABASE [LVTN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LVTN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LVTN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LVTN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LVTN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LVTN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LVTN] SET QUERY_STORE = OFF
GO
USE [LVTN]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20/07/2022 9:40:14 SA ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[id_DanhMucCha] [int] NOT NULL,
	[Sdt_NguoiBan] [nvarchar](10) NULL,
	[Sdt_NguoiMua] [nvarchar](10) NULL,
	[AnTin] [bit] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[ThanhPho] [nvarchar](150) NULL,
	[QuanHuyen] [nvarchar](150) NULL,
	[PhuongXa] [nvarchar](150) NULL,
	[DiaChiCuThe] [nvarchar](150) NULL,
	[TieuDe] [nvarchar](150) NULL,
	[id_BaiDangChiTiet] [int] NULL,
	[TablesDetail] [nchar](50) NULL,
	[id_DanhMucCon] [int] NULL,
	[Mota] [nvarchar](max) NULL,
	[MienPhi] [bit] NULL,
	[Gia] [float] NULL,
	[CaNhan] [bit] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[isReviewed] [bit] NULL,
 CONSTRAINT [PK_BaiDang] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_BatDongSan]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_BatDongSan](
	[id_BaiDang] [int] NOT NULL,
	[TenDuAn] [nvarchar](max) NULL,
	[DienTich] [float] NULL,
	[CC_MaCan] [nchar](10) NULL,
	[CC_Block] [nchar](10) NULL,
	[CC_TangSo] [nchar](10) NULL,
	[CC_ChuaBanGiao] [bit] NULL,
	[CC_LoaiHinh] [nvarchar](max) NULL,
	[CC_SoPhongNgu] [tinyint] NULL,
	[NhaO_LoaiHinh] [nvarchar](max) NULL,
	[NhaO_SoPhongNgu] [tinyint] NULL,
	[NhaO_SoPhongVeSinh] [tinyint] NULL,
	[NhaO_TongSoTang] [tinyint] NULL,
	[NhaO_HemXeHoi] [bit] NULL,
	[NhaO_NoHau] [bit] NULL,
	[NhaO_ChieuNgang] [float] NULL,
	[NhaO_ChieuDai] [float] NULL,
	[Dat_LoaiHinhDat] [nvarchar](max) NULL,
	[Dat_HuongDat] [nvarchar](40) NULL,
	[Dat_MatTien] [bit] NULL,
	[Dat_HemXeHoi] [bit] NULL,
	[Dat_NoHau] [bit] NULL,
	[Dat_ChieuNgang] [float] NULL,
	[Dat_ChieuDai] [float] NULL,
	[VanPhong_MaCan] [nvarchar](50) NULL,
	[VanPhong_Block] [nchar](10) NULL,
	[VanPhong_TangSo] [nchar](10) NULL,
	[VanPhong_LoaiHinhVanPhong] [nvarchar](60) NULL,
	[PhongTro_TinhTrangNoiThat] [nvarchar](60) NULL,
	[PhongTro_SoTienCoc] [float] NULL,
	[CanBan] [bit] NULL,
	[CcBanCong] [nvarchar](max) NULL,
	[CcGiayToPhapLy] [nvarchar](max) NULL,
	[CcHuongCuaChinh] [nvarchar](max) NULL,
	[CcTinhTrangNoiThat] [nvarchar](max) NULL,
	[SoTienCoc] [real] NULL,
	[soToilet] [int] NULL,
	[NhaO_GiayToPhapLy] [nvarchar](150) NULL,
	[Dat_GiayToPhapLy] [nvarchar](150) NULL,
	[VanPhong_GiayToPhapLy] [nvarchar](150) NULL,
	[VanPhong_HuongCuaChinh] [nvarchar](150) NULL,
 CONSTRAINT [PK_BaiDang_BatDongSan] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_DoAnThucPham]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_DoAnThucPham](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[LoaiThucPham] [nvarchar](150) NULL,
 CONSTRAINT [PK_BaiDang_DoAnThucPham] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_DoDienTu]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_DoDienTu](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[BaoHanh] [bit] NULL,
	[DienThoai_Hang] [nvarchar](50) NULL,
	[DienThoai_MauSac] [varchar](30) NULL,
	[DienThoai_DungLuong] [nvarchar](15) NULL,
	[MayTinhBang_QuocTe] [bit] NULL,
	[MayTinhBang_4g] [bit] NULL,
	[MayTinhBang_DungLuong] [nvarchar](15) NULL,
	[MayTinhDeBan_BoViXuly] [nvarchar](15) NULL,
	[MayTinhDeBan_RAM] [nvarchar](20) NULL,
	[MayTinhDeBan_OCung] [nvarchar](20) NULL,
	[MayTinhDeBan_HDD] [bit] NULL,
	[MayTinhDeBan_CardManHinh] [nchar](10) NULL,
	[MayTinhDeBan_KichCoManHinh] [nchar](30) NULL,
	[Laptop_BoViXuly] [nvarchar](15) NULL,
	[Laptop_RAM] [nvarchar](20) NULL,
	[Laptop_OCung] [nvarchar](20) NULL,
	[Laptop_HDD] [bit] NULL,
	[Laptop_CardManHinh] [nchar](10) NULL,
	[Laptop_KichCoManHinh] [nchar](30) NULL,
	[Laptop_Hang] [nchar](20) NULL,
	[MayAnh_ThietBi] [nvarchar](50) NULL,
	[MayAnh_TinhTrang] [nvarchar](80) NULL,
	[Tivi_ThietBi] [nvarchar](50) NULL,
	[Tivi_TinhTrang] [nvarchar](80) NULL,
	[ThietBiDeoThongMinh_ThietBi] [nvarchar](50) NULL,
	[ThietBiDeoThongMinh_TinhTrang] [nvarchar](80) NULL,
	[ThietBiDeoThongMinh_Hang] [nvarchar](80) NULL,
	[PhuKien_LoaiPhuKien] [nvarchar](50) NULL,
	[PhuKien_ThietBi] [nvarchar](80) NULL,
	[PhuKien_TinhTrang] [nvarchar](80) NULL,
	[LinhKien_LoaiPhuKien] [nvarchar](50) NULL,
	[LinhKien_ThietBi] [nvarchar](80) NULL,
	[LinhKien_TinhTrang] [nvarchar](80) NULL,
	[TinhTrang] [nvarchar](max) NULL,
	[DienThoaiDongMay] [nvarchar](max) NULL,
	[LaptopDongMay] [nvarchar](max) NULL,
	[MayTinhBangDongMay] [nvarchar](max) NULL,
	[MayTinhBangHang] [nvarchar](max) NULL,
	[MayTinhBangKichCoManHinh] [nvarchar](max) NULL,
	[MayTinhDeBanMienPhi] [bit] NULL,
	[ThietBiDongMay] [nvarchar](max) NULL,
	[TiviHang] [nvarchar](max) NULL,
 CONSTRAINT [PK_BaiDang_DoDienTu] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_DoDungVanPhong]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_DoDungVanPhong](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[DaSuDung] [bit] NULL,
 CONSTRAINT [PK_BaiDang_DoDungVanPhong] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_DoGiaDung]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_DoGiaDung](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[DaSuDung] [bit] NULL,
	[LoaiSanPham] [nvarchar](100) NULL,
	[BanGhe_ChatLieu] [nvarchar](50) NULL,
	[TuKe_ChatLieu] [nvarchar](50) NULL,
	[Giuong_ChatLieu] [nvarchar](150) NULL,
	[Bep_ThuongHieu] [nvarchar](75) NULL,
	[Quat_ThuongHieu] [nvarchar](75) NULL,
	[ThietBiVeSinh_ThuongHieu] [nvarchar](75) NULL,
 CONSTRAINT [PK_BaiDang_DoGiaDung] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_GiaiTri]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_GiaiTri](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[DaSuDung] [bit] NULL,
	[MienPhi] [bit] NULL,
	[NhacCu_LoaiNhacCu] [nvarchar](100) NULL,
	[DoSuuTam_LoaiSanPham] [nvarchar](100) NULL,
 CONSTRAINT [PK_BaiDang_GiaiTri] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_MeVaBe]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_MeVaBe](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[DaSuDung] [bit] NULL,
	[LoaiSanPham] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BaiDang_MeVaBe] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_ThoiTrang]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_ThoiTrang](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[DaSuDung] [bit] NULL,
	[LoaiSanPham] [nvarchar](100) NULL,
 CONSTRAINT [PK_BaiDang_ThoiTrang] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_ThuCung]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_ThuCung](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[GiongThuCung] [nvarchar](250) NULL,
	[DoTuoi] [nvarchar](30) NULL,
	[Chim_GioiTinh] [nvarchar](100) NULL,
	[Cho_KichCo] [nvarchar](100) NULL,
 CONSTRAINT [PK_BaiDang_ThuCung] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_TuLanh]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_TuLanh](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[DaSuDung] [bit] NULL,
	[Hang] [nvarchar](100) NULL,
	[TuLanh_TheTich] [nvarchar](50) NULL,
	[MayLanh_CongSuat] [nvarchar](50) NULL,
	[MayGiat_CuaMayGiat] [nvarchar](50) NULL,
	[MayGiat_KhoiLuongGiat] [nvarchar](50) NULL,
 CONSTRAINT [PK_BaiDang_TuLanh] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_ViecLam]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_ViecLam](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[TenHoKinhDoanh] [nvarchar](max) NULL,
	[SoLuongTuyenDung] [tinyint] NULL,
	[NganhNghe] [nvarchar](150) NULL,
	[LoaiCongViec] [nvarchar](100) NULL,
	[HinhThucTraLuong] [nvarchar](75) NULL,
	[LuongToiThieu] [float] NULL,
	[LuongToiDa] [float] NULL,
	[Nam] [bit] NULL,
	[HocVanToiThieu] [nvarchar](50) NULL,
	[KinhNghiem] [nvarchar](20) NULL,
	[ChungChi] [nvarchar](50) NULL,
	[QuyenLoi] [nvarchar](max) NULL,
 CONSTRAINT [PK_BaiDang_ViecLam] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiDang_XeCo]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiDang_XeCo](
	[id_BaiDang] [int] IDENTITY(1,1) NOT NULL,
	[HangXe] [nvarchar](50) NULL,
	[Nam] [nchar](10) NULL,
	[SoKmDaDi] [float] NULL,
	[Gia] [float] NULL,
	[DaSuDung] [bit] NULL,
	[Xuatxu] [nvarchar](50) NULL,
	[MauSac] [nvarchar](50) NULL,
	[BienSoXe] [nvarchar](50) NULL,
	[Oto_HopSo] [nvarchar](50) NULL,
	[Oto_NhieuLieu] [nvarchar](50) NULL,
	[Oto_KieuDang] [nvarchar](50) NULL,
	[Oto_Socho] [tinyint] NULL,
	[XeMay_Dungtich] [nvarchar](50) NULL,
	[XeTai_TrongTai] [nvarchar](30) NULL,
	[XeTai_NhieuLieu] [nvarchar](30) NULL,
	[XeTai_XuatXu] [nvarchar](50) NULL,
	[XeDien_LoaiXe] [nvarchar](40) NULL,
	[XeDien_DongCo] [nvarchar](50) NULL,
	[XeDien_DaSuDung] [bit] NULL,
	[XeDien_MienPhi] [bit] NULL,
	[XeDap_KichThuocKhung] [nvarchar](20) NULL,
	[XeDap_ChatLuongKhung] [nvarchar](20) NULL,
	[XeDap_DaSuDung] [bit] NULL,
	[XeDap_MienPhi] [bit] NULL,
	[XeDap_BaoHang] [nvarchar](30) NULL,
	[PhuongTienKhac_NhienLieu] [nvarchar](20) NULL,
	[PhuTungXe_LoaiPhuTung] [nvarchar](50) NULL,
	[OtoDongXe] [nvarchar](max) NULL,
	[PhuTungXeMienPhi] [bit] NULL,
	[PhuongTienKhacLoaiXeChuyenDung] [nvarchar](max) NULL,
	[PhuongTienKhacSoChoXeKhachXeBuyt] [nvarchar](max) NULL,
	[XeDapLoaiXe] [nvarchar](max) NULL,
	[XeMayDongXe] [nvarchar](max) NULL,
	[XeMayLoaiXe] [nvarchar](max) NULL,
	[XeDien_BaoHanh] [nvarchar](150) NULL,
 CONSTRAINT [PK_BaiDang_XeCo] PRIMARY KEY CLUSTERED 
(
	[id_BaiDang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conversations]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conversations](
	[ConversationId] [int] IDENTITY(1,1) NOT NULL,
	[SdtNguoiBan] [nvarchar](50) NULL,
	[SdtNguoiMua] [nvarchar](50) NULL,
 CONSTRAINT [PK_Conversations] PRIMARY KEY CLUSTERED 
(
	[ConversationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[id_DanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[ten_DanhMuc] [nvarchar](max) NOT NULL,
	[id_DanhMucCha] [int] NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[id_DanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoDich_DatCoc]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich_DatCoc](
	[idDatCoc] [int] IDENTITY(1,1) NOT NULL,
	[SoTienDatCoc] [float] NULL,
	[sdtBan] [nvarchar](10) NULL,
	[sdtMua] [nvarchar](10) NULL,
	[giaoDichThanhCong] [bit] NULL,
	[huyGiaoDich] [bit] NULL,
 CONSTRAINT [PK_GiaoDich_DatCoc] PRIMARY KEY CLUSTERED 
(
	[idDatCoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhAnh_BaiDang]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhAnh_BaiDang](
	[id_HinhAnh] [int] IDENTITY(1,1) NOT NULL,
	[idMediaCloud] [nvarchar](max) NOT NULL,
	[id_SanPham] [int] NOT NULL,
	[videoType] [bit] NULL,
 CONSTRAINT [PK_HinhAnh_BaiDang] PRIMARY KEY CLUSTERED 
(
	[id_HinhAnh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[ConversationID] [int] NULL,
	[MessagesBy] [nvarchar](50) NULL,
	[Time] [datetime2](7) NULL,
	[MessageImageSource] [nvarchar](max) NULL,
	[MessageText] [nvarchar](max) NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[SoDienThoai] [nvarchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[NgayKetThuc_DichVu] [datetime] NULL,
	[Loai_DichVu] [tinyint] NULL,
	[So_CMND] [nchar](12) NULL,
	[Admin] [bit] NULL,
	[Hinh_CMND] [nvarchar](max) NULL,
	[MSDK_DoanhNghiep] [nchar](20) NULL,
	[passwordHash] [varbinary](max) NULL,
	[passwordSalt] [varbinary](max) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[DanhGiaHeThong] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[AnhDaiDienSource] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[LockTime] [datetime2](7) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[SoDienThoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[idThongBao] [int] IDENTITY(1,1) NOT NULL,
	[SdtNguoiDung] [nvarchar](50) NULL,
	[TieuDeThongBao] [nvarchar](max) NULL,
	[comment] [nvarchar](max) NULL,
	[checked] [bit] NULL,
	[IDPost] [int] NULL,
 CONSTRAINT [PK_ThongBao] PRIMARY KEY CLUSTERED 
(
	[idThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuocTinh_DanhMuc]    Script Date: 20/07/2022 9:40:14 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuocTinh_DanhMuc](
	[id_ThuocTinh] [int] NOT NULL,
	[ten_ThuocTinh] [nvarchar](max) NOT NULL,
	[id_DanhMuc] [int] NOT NULL,
 CONSTRAINT [PK_ThuocTinh_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[id_ThuocTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220508093547_DBContextInit', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220508121848_add_Column_CreatedDate_in_BaiDang', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220517095419_AddFieldToBaiDangBatDongSan', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220518092253_addMissingFieldIntoBaiDangXeCo', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220522135220_updateDBDetail', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220524130614_addCreatedDateToNguoiDung', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220524152154_addFieldIntoNguoiDung', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220527142737_addTableForChatModule', N'6.0.4')
GO
SET IDENTITY_INSERT [dbo].[BaiDang] ON 

INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (2, 1, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'Bình Chánh', N'Bình Hưng', N'3C', N'Cần bán gấp nhà chính chủ sổ hồng riêng', 1, N'BaiDang_BatDongSan                                ', 13, N'Cần bán gấp nhà chính chủ sổ hồng riêng Cần bán gấp nhà chính chủ sổ hồng riêng Cần bán gấp nhà chính chủ sổ hồng riêng', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (5, 2, N'0343679934', NULL, 0, 1, N'Hà Nội', N'Hoàn Kiếm', N'Hàng Bạc', N'3A', N'Bán ô tô gia đình do vừa chuyển sang ô tô 7 chỗ mới', 1, N'BaiDang_XeCo                                      ', 18, N'Bán ô tô gia đình do vừa chuyển sang ô tô 7 chỗ mới ', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (6, 2, N'0343679934', NULL, 0, 1, N'Hải Dương', N'Ái Quốc', N'An Châu', N'5C', N'Do thiếu nợ bài bạc nên cần bán', 2, N'BaiDang_XeCo                                      ', 18, N'Bán xe winner mới mua chưa lấy biển số do cờ bạc thiếu nợ nên cần bán', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (7, 3, N'0343679934', NULL, 0, 1, N'Sóc Trăng', N'', N'4', N'6F', N'Cần bán iphone 11 promax', 1, N'BaiDang_DoDienTu                                  ', 25, N'Không có nhu cầu sử dụng nên cần bán iphone 11 pro max 1TB ', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (8, 0, N'0343679934', NULL, 0, 1, N'Hà Nội', N'Hoàn Kiếm', N'Hàng Bài', N'7G', N'Việc làm bảo vệ ca đêm', 1, N'BaiDang_ViecLam                                   ', 4, N'Cần tuyển nam bảo vệ ca đêm từ 19h đến 7h sáng', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (9, 5, N'0343679934', NULL, 0, 1, N'Tây Ninh', N'Hòa Thành ', N'Trường Đông', N'8J', N'Gà đá cực chiến', 1, N'BaiDang_ThuCung                                   ', 34, N'Chí thú làm ăn không cờ bạc nữa nay', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (10, 5, N'0343679934', NULL, 0, 1, N'Sa Đéc ', N'', N'Tân Quy Đông', N'9L', N'Bull gốc Mỹ có đầy đủ giấy xác minh', 2, N'BaiDang_ThuCung                                   ', 35, N'Cần bán em bull gốc Mỹ có giấy tờ gia phả', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (11, 5, N'0343679934', NULL, 0, 1, N'Bến Tre', N'Châu Thành', N'Tân Thạch', N'12T', N'Anh lông ngắn, quấn người, biết đi vệ sinh', 3, N'BaiDang_ThuCung                                   ', 37, N'Ra đi em mèo anh lông ngắn, cực kì quấn người biết đi vệ sinh đúng nơi, đã tiêm sổ giun đầy đủ', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (12, 7, N'0343679934', NULL, 0, 1, N'Tây Ninh', N'Hòa Thành', N'Trường Tây', N'13K', N'Tủ lạnh Pannasonic', 1, N'BaiDang_TuLanh                                    ', 40, N'Nhu cầu đổi tủ lạnh nên cần bán tủ lạnh Pannasonic 120l ', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (13, 7, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'Tân Phú', N'3', N'14U', N'Máy lạnh Daikin', 2, N'BaiDang_TuLanh                                    ', 41, N'Cần bán máy lạnh Daikin', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (14, 7, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'8', N'4', N'15L', N'Máy giặt Sanyo 7Kg', 3, N'BaiDang_TuLanh                                    ', 42, N'Chuyển nhà nên cần bán máy giặt Sanyo', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (15, 8, N'0343679934', NULL, 0, 1, N'Sa Đéc', N'', N'Tân Quy Tây', N'16N', N'Ghế gaming extremeZeroS', 1, N'BaiDang_DoGiaDung                                 ', 43, N'Cần bán ghế gaming extreme zeroS do không có nhu cầu xử dụng, ghế chưa tróc da', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (16, 8, N'0343679934', NULL, 0, 1, N'Sa Đéc', N'', N'Tân Khánh Đông', N'17J', N'Quạt điều hòa ', 2, N'BaiDang_DoDienTu                                  ', 48, N'Quạt điều hoa không sử dụng nữa', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (17, 10, N'0343679934', NULL, 0, 1, N'Sóc Trăng', N'', N'7', N'18I', N'Applewatch seri 3, 42mm', 1, N'BaiDang_ThoiTrang                                 ', 54, N'Cần ra đi cứu chủ, aw sr3 42mm nhôm GPS đen', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (18, 10, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'Bình Thạnh', N'12', N'319 Nguyễn Xí', N'Yezzy 350 v2 tint', 2, N'BaiDang_ThoiTrang                                 ', 55, N'Yezzy 350 v2 tint size 42.5 cần ra đi gấp gdtt', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (19, 10, N'0343679934', NULL, 0, 1, N'Đà lạt', N'Di Linh', N'3', N'1412 Quốc lộ 20', N'Dior nước hoa quốc dân', 3, N'BaiDang_ThoiTrang                                 ', 57, N'Chiết Dior 10ml / 190k uy tín chất lương', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (20, 11, N'0343679934', NULL, 0, 1, N'Bảo Lộc', N'', N'Đam Bri', N'987 Đam BriA', N'Yamaha Piano', 1, N'BaiDang_GiaiTri                                   ', 59, N'Cần bán cây đàn piano do được tặng và không có nhu cầu sử dụng', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (21, 11, N'0343679934', NULL, 0, 1, N'Hà Nội', N'Hoàng Mai', N'Trần Phú', N'6F', N'Đắc nhân tâm', 2, N'BaiDang_GiaiTri                                   ', 60, N'Bán sách Đắc Nhân Tâm có chữ ký của tác giả', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (22, 11, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'Bình Tân', N'Tân tạo', N'Đường 5A', N'Máy chạy bộ', 3, N'BaiDang_GiaiTri                                   ', 61, N'Bán máy chạy bộ do không chạy nữa', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (23, 11, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'Tân Phú', N'8', N'Đường Hoa Sứ', N'PlayStation 5', 4, N'BaiDang_GiaiTri                                   ', 63, N'Cần bán PlayStation 5, 1TB', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (24, 12, N'0343679934', NULL, 0, 1, N'Tây Ninh', N'Dương Minh Châu', N'Suối Đá', N'Chợ Hòa Bình', N'Bút viết văn phòng các loại', 1, N'BaiDang_DoDungVanPhong                            ', 65, N'Thanh lý bút viết văn phòng trả mặt bằng', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (25, 12, N'0343679934', NULL, 0, 1, N'Bến Tre', N'Thạnh Phú', N'Thạnh Tây', N'Biển Thạnh Phú', N'Ghế văn phòng', 2, N'BaiDang_DoDungVanPhong                            ', 66, N'Đồ văn phòng thanh lý để trả văn phòng', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (26, 0, N'0343679934', NULL, 0, 1, N'Hồ Chí Minh', N'Bình Tân', N'Tân Tạo', N'Tỉnh lộ 10', N'Tuyển nam lễ tân ca đêm lương từ 7.5 triệu', 2, N'BaiDang_ViecLam                                   ', 4, N'Tuyển nam lễ tân khách sạn ca đêm từ 19h tới 7h sáng', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (27, 0, N'0343679934', NULL, 0, 1, N'Long An ', N'Tân Tạo', N'Tân Thạch', N'Quốc lộ 60', N'Tuyển lao động phổ thông', 3, N'BaiDang_ViecLam                                   ', 4, N'Tuyển lao động phổ thông làm việc tại khu công nghiệp Tân Hương lương tháng từ 10 triệu ', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (28, 0, N'0343679934', NULL, 0, 1, N'Bến Tre', N'Châu Thành', N'Giao Long', N'6F', N'Tuyển nam bảo vệ ca đêm', 4, N'BaiDang_ViecLam                                   ', 4, N'Tuyển nam bảo vệ ca đêm trực khu công nghiệp', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (29, 1, N'0343679934', N'string', 1, 0, N'hcm', N'q8', N'p4', N'180Caolo', N'string', 1, N'string                                            ', 13, N'string', 1, 3000000, 1, CAST(N'2022-05-17T21:03:35.7602709' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (30, 1, N'0343679934', N'string', 1, 0, N'hcm', N'q8', N'p4', N'180Caolo', N'string', 2, N'string                                            ', 13, N'string', 1, 3000000, 1, CAST(N'2022-05-17T21:04:20.3267542' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (31, 1, N'0343679934', NULL, 1, 0, N'hcm', N'q8', N'p4', N'180Caolo', N'string', 3, N'string                                            ', 13, N'string', 1, 3000000, 1, CAST(N'2022-05-17T21:16:35.1583491' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (35, 1, N'456', N'string', 1, 1, N'TPHCM', N'Nhà bè', N'Phước kiểng', N'757 Huỳnh Tấn Phát', N'Đặt UCL thua cần bán gấp nhà 2 mặt tiền, chính chủ, sổ hồng riêng', 7, NULL, 13, N'Lỡ xuống xác LIV giờ còn đúng cái nịt, cần bán gấp nhà 2 mặt tiền, sổ hồng riêng, chính chủ', 1, 13000000000000, 1, CAST(N'2022-05-29T16:14:43.1150000' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (36, 1, N'0343679934', N'string', 1, 1, N'string', N'string', N'string', N'string', N'string', 8, N'string                                            ', 13, N'string', 1, 0, 1, CAST(N'2022-05-29T16:55:13.2070000' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (37, 1, N'0343679934', N'string', 1, 1, N'string', N'string', N'string', N'string', N'string', 9, N'string                                            ', 14, N'string', 1, 0, 1, CAST(N'2022-05-29T16:58:01.8300000' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (38, 1, N'0343679934', N'string', 1, 1, N'string', N'string', N'string', N'string', N'string', 10, N'string                                            ', 13, N'string', 1, 0, 1, CAST(N'2022-05-29T17:01:15.5380000' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (41, 1, N'123', N'', 0, 1, N'Tp.HCM', N'quận 8', N'phường 4', N'180 Cao Lỗ', N'Bán nhà hẻm đường đông hồ p8 tân bình', 13, N'string                                            ', 14, N'BÁN NHÀ:
- ĐC: Đông Hồ, P.8, quận Tân Bình
- DT: 4,9m x 10,5m = 45,9 m2
- Trệt, 1 lầu BT, sân thượng.
- Hẻm thông LG 5m, hiện hữu 4,6m.
- Gần chợ Tân Bình, giáp quận 10, quận 11, tiện ra hướng trung tâm TP.
- Hướng nhà: Tây Bắc
- Đang cho thuê 10 triệu/tháng.
- Giá bán: 5.6tỷ TL', NULL, 5600000000, 1, CAST(N'2022-06-02T19:28:32.3477242' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (42, 1, N'123', N'', 0, 1, N'Tp.HCM', N'quận 8', N'phường 4', N'180 Cao Lỗ', N'Đất 6,8x13 thổ cư 100%_đường ô tô_Giá đầu tư 890TR', 14, N'string                                            ', 15, N'Bán đất đường Hương Lộ 15 vào, bến đò Tân Uyên .Sổ riêng thổ cư 100%.
=> Giá đầu tư F0: 900TR/lô
=> Đường bê tông hiện hữu
=> Bao hết chi phí. Hỗ trợ vây ngân hàng 3 bên 70%
Anh/chị có nhu cầu LH: 0962.766.616 em dẫn xem đất nhé!!!', NULL, 890000000, 1, CAST(N'2022-06-02T19:45:53.4059871' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (43, 1, N'123', N'', 0, 1, N'Tp.HCM', N'quận 8', N'phường 4', N'180 Cao Lỗ', N'Đất 6,8x13 thổ cư 100%_đường ô tô_Giá đầu tư 890TR', 15, N'string                                            ', 15, N'Bán đất đường Hương Lộ 15 vào, bến đò Tân Uyên .Sổ riêng thổ cư 100%.
=> Giá đầu tư F0: 900TR/lô
=> Đường bê tông hiện hữu
=> Bao hết chi phí. Hỗ trợ vây ngân hàng 3 bên 70%
Anh/chị có nhu cầu LH: 0962.766.616 em dẫn xem đất nhé!!!', NULL, 890000000, 1, CAST(N'2022-06-02T19:47:53.0661622' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (44, 1, N'456', N'', 1, 0, N'Tp.HCM', N'quận 8', N'phường 4', N'180 Cao Lỗ', N'Đất 6,8x13 thổ cư 100%_đường ô tô_Giá đầu tư 890TR', 17, N'string                                            ', 15, N'Bán đất đường Hương Lộ 15 vào, bến đò Tân Uyên .Sổ riêng thổ cư 100%.
=> Giá đầu tư F0: 900TR/lô
=> Đường bê tông hiện hữu
=> Bao hết chi phí. Hỗ trợ vây ngân hàng 3 bên 70%
Anh/chị có nhu cầu LH: 0962.766.616 em dẫn xem đất nhé!!!', NULL, 890000000, 1, CAST(N'2022-07-12T10:56:52.0117461' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (45, 1, N'123', N'', 1, 0, N'Tp.HCM', N'quận 8', N'phường 4', N'180 Cao Lỗ', N'Cần bán trường', 18, N'string                                            ', 14, N'cần bán trường', NULL, 100000, 1, CAST(N'2022-06-02T20:13:30.6271526' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (49, 0, N'456', N'', 1, 0, N'Tp.HCM', N'quận 8', N'phường 4', N'180 Cao Lỗ', N'cần bán nhà ở phường 4 quận 8', 22, N'string                                            ', 14, N'cần bán nhà mới xây ở diện tích 100 m2 ở quận 8', NULL, 100000000, 1, CAST(N'2022-07-11T11:44:52.1241036' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (50, 1, N'456', N'', 1, 0, N'Tp.HCM', N'quận 8', N'phường 4', N'180Cao Lỗ', N'Chung cư mới xây', 23, N'string                                            ', 13, N'Chung cư mới xây', NULL, 200000000, 1, CAST(N'2022-06-03T21:59:01.1542268' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (51, 5, N'456', N'', 1, 0, N'Tp.HCM', N'quận 8', N'phường 4', N'180Cao Lỗ', N'Cần bán chó ', 0, N'string                                            ', 35, N'Cần bán chó ', 0, 999996, NULL, CAST(N'2022-06-03T22:04:09.4637241' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (52, 5, N'123', N'', 1, 0, N'Tp.HCM', N'quận 8', N'phường 4', N'180Cao Lỗ', N'Chó Pug Mặt Xệ 52 ngày tuổi', 0, N'string                                            ', 35, N'Tìm chủ cho bầy pug mặt xệ thuần chủng 52 ngay
Đã sổ giun, biết ăn hạt
Thông tin: Mập mạp, ú nù, chân lùn, mặt xệ
Giá yêu thương: 2800k đến 3500k', 0, 2000000, NULL, CAST(N'2022-06-03T23:15:40.4103329' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (53, 5, N'123', N'', 1, 0, N'Tphcm', N'quan 8', N'phường 4', N'180Cao Lỗ', N'cần bán', 0, N'string                                            ', 35, N'cần bán', 0, 999999999999, NULL, CAST(N'2022-06-04T09:20:42.4065267' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (54, 5, N'123', N'', 1, 0, N'Tphcm', N'quan 8', N'phường 4', N'180Cao Lỗ', N'cần bán', 0, N'string                                            ', 35, N'cần bán', 0, 999999999999, NULL, CAST(N'2022-06-04T09:22:25.4178232' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (55, 5, N'123', N'', 1, 0, N'Tphcm', N'quan 8', N'phường 4', N'180Cao Lỗ', N'cần bán', 0, N'string                                            ', 35, N'cần bán', 0, 999999999999, NULL, CAST(N'2022-06-04T09:24:00.5767080' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (56, 5, N'456', N'', 1, 0, N'tphcm', N'quan 8', N'phuong 4', N'180Cao Lo', N'can ban cho', 0, N'string                                            ', 35, N'can ban cho', 0, 1000000, NULL, CAST(N'2022-06-16T08:19:39.0960339' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (57, 1, N'0854863505', N'', 1, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường An Phú', N'52 Đường Song Hành', N'BÁN CĂN HỘ CC AN KHÁNH 2PN 82M2 FULL NỘI THẤT', 24, N'string                                            ', 13, N'Chính chủ: Căn hộ Chung cư An Khánh, Căn Góc 2 pn, 2 toilet 82m2 rộng rãi.
Mặt tiền đường Song Hành x Nguyễn Quý Đức, Khu Đô thị An Phú - An Khánh, Q2.
Thuận tiện đi lại.
Nhà mới sửa lại theo kiểu mới hiện đại, thoáng. 3 view rất sáng.

Full nội thất như hình:
- Tủ bếp, tủ tivi, 2 tủ áo, 2 giường, bàn makeup, bàn học, Sofa, bàn trà, quạt hút...
- 2 điều hoà Panasonic, 2 máy nước nóng, quạt Senko treo tường
- Hệ thống đèn điện MPE 3 chế độ mới, đèn trần, đèn thả...
- Rèm 2 lớp
- Thiết bị vệ sinh Inax
- Khoá từ vân tay
- Hầm để xe rộng rãi, để xe hơi trong hầm.

Nhà đã có sổ, giấy tờ đầy đủ.
Khu dân trí cao, yên tĩnh, văn minh.', NULL, 3400000000, 1, CAST(N'2022-07-12T11:45:41.7656822' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (59, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 8', N'Phường 07', N'Nguyễn Văn Linh', N'Bán căn hộ giá rẻ, 62m2, chỉ 27tr/m2 ngay Quận 8', 26, N'string                                            ', 13, N'CC Dream Home Riverside, mặt tiền đường Nguyễn Văn Linh giao Phạm Thế Hiển, P7, Q8, HCM.
Trong KDC hiện hữu Phú Lợi, đầy đủ tiện ích sống. Đối diện khu làng đại học tây nam SG.
DT: 62m2, cửa: Tây Bắc, W: ĐN.
Giá hợp đồng: 1.390 tỷ (chưa VAT).
Chênh lệch: 160 triệu.
Mua thanh toán: 25% (348 tr) + chênh 160tr = 508tr.
Tháp hiện đang trong gđ móc hầm, nên tiến độ thanh toán rất giãn và dễ chịu.
Bank TP cho vay tới 70% gtch, với gói ưu đãi: Ân hạn gốc 01 năm đầu!
* (Khu chung cư có tháp gần giao nhà, nếu quý khách cần nhà ở sớm cũng có thể quan tâm ạ!).
Quý khách vui lòng nt hoặc ll để biết thêm thông tin và tham khảo thêm giỏ hàng giá tốt.', NULL, 1689000000000, 1, CAST(N'2022-07-12T21:58:31.8322562' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (60, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Tân Phú', N'Phường Sơn Kỳ', N' số 88, số 88 Số 88 đường N1', N'Gấp bán căn 2pn Emerald full nội thất bg sổ 5%', 27, N'string                                            ', 13, N'Chính chủ muốn bán lại căn 2PN tại Emerald- Celadon city.
- Diện tích: 63m2 view thoáng mát
- Tầng 10, bao đẹp
- Giá: 3.290 tỷ đã bg hết thuế phí và 5% nhận sổ
- Thiết kế: 2PN+1WC( 1 bancony, rộng rãi thoáng mát)
- Hiện đã thanh toán 95%, 5% còn lại nhận sổ
- Ngân hàng hỗ trợ vay 70-80%, lãi suất cực kì tốt, với thời hạn vay tối đa 20 năm
- Nhận nhà ở ngay sau khi công chứng
- Nhà được bàn giao full thiết bị vệ sinh cao cấp của Đức
* Tiện ích nội khu:
- Một bước tới hồ bơi, công viên, khu vui chơi cho bé, Đường chạy bộ trên không, cafe bên hồ, khu BBQ gia đình nằm riêng biệt trên tầng 5,
* Tiện ích hiện hữu:
- Liền kề TTTM Aeon Mall.
- Công viên cây xanh 16ha.
- Khu phức hợp thể thao chuẩn 5 sao: Gym, Spa, Tennis, cầu lông, bóng chuyền, bóng rổ...
- Hệ thống giáo dục Quốc tế Á Châu, trường cấp 1,2,3 công lập...
- Bệnh viện Hoàn Mỹ khu Tây...', NULL, 3290000000, 1, CAST(N'2022-07-12T22:07:47.3922160' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (61, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Gò Vấp', N'Phường 17', N'Nguyễn Anh', N'Nhà 5 Tầng Có Thang Máy DTSD 250m2 Giá 4 tỷ 800 tr', 28, N'string                                            ', 14, N'Vị trí Nằm trên trục đường Nguyễn Oanh- Hà Huy Giáp Nối dài.
Thanh toán 30% nhận nhà ở ngay
Giá 4 tỷ 800 triệu
Diện tích xây dựng: 280m2
Kết cấu Xây dựng 5 lầu : Phòng khách , Phòng ăn, Bếp , 6 PN , 7 WC, phòng thờ phòng giặt sân thượng trước và sau , ban công rộng rãi .
Pháp lý sổ hồng riêng sở hữu lâu dài.
Ngân hàng hỗ trợ lên đến 70% giá trị nhà .
Tiện ích: Đường nhựa 12 m vỉa hè 3m có chỗ đậu xe hơi , điện âm nước máy . Có chỗ đậu xe hơi có cây xanh vỉa hè khu dân cư đông đúc.
Khu nhà gần nhiều tiện ích trường tiểu học , trường mầm non quốc tế , chợ, siêu thị, ủy ban phường', NULL, 4800000000, 1, CAST(N'2022-07-12T22:21:56.7921939' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (62, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Tân', N'Phường Bình Trị Đông', N'225 đường Lê Văn Quới', N'Bán nhà Lê Văn Quới - Bình Tân SHR 60m2 X 4T', 29, N'string                                            ', 14, N'Sổ hồng riêng chính chủ, 60m2 x 4T (vuông vức)
Đang cho thuê 15 triệu/tháng
Nhà cạnh gốc công viên thoáng mát, kinh doanh tốt
Toàn bộ hẻm từ Lê Văn Quới vào 2 ô tô né nhau, Ô tô về đậu được trước nhà

3 phút ra ngã tư 4 xã
3 phút ra chợ lê văn quới
Ngay đầu hẻm đầy đủ Bách Hóa Xanh, Điện Máy Xanh...
Khu dân cư trí thức, toàn hẻm đã chỉnh trang xanh sạch đẹp

Đặc biệt mua nhanh trong tháng, tặng gói thiết kế nội thất cả ngôi nhà theo ý thích chủ mới.

Chính chủ, không tiếp môi giới', NULL, 5350000000, 1, CAST(N'2022-07-12T22:29:27.7692146' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (63, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 07', N'đường Hoàng Hoa Thám', N'Bán nhà HOÀNG HOA THÁM 2 Mặt 310m2 chỉ 96 tỷ ', 30, N'string                                            ', 14, N'Kết cấu nhà 2 mặt tiền đường trước 12m sau 12m .
+ Diện tích 12x25 . tổng diện tích 310m2 .
+ Có vìa hè 5m siệu đẹp , hai mặt tiền 12m còn có hẻm phía sau 5m rất hiếm.
+ Vị trí nhà rất hiếm trên thị trường có thể xây tòa nhà văn phòng , nhà hàng , khách sạn
hay kinh doanh bất cứ gì ngay vị trí nhà này đều tốt .
+ Vị trí ngôi nhà chờ đợi sự đầu tư sáng suốt của người thành đạt .', NULL, 96000000000, 0, CAST(N'2022-07-12T22:39:02.0436449' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (64, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Huyện Bình Chánh', N'Xã Lê Minh Xuân', N'Trần Văn Giàu', N'Bán cặp 210m2 kế KCN Lê Minh Xuân 3 tiện xây trọ', 31, N'string                                            ', 15, N'Bán cặp 210m2 ngay vòng xoay Tỉnh Lộ 10, Trần Văn Giàu gần bệnh viện Chợ Rẫy 2.

- Diện tích: 10m x 21m = 210m2 (2 nền 2 sổ)

- Giá: 2Tỷ/350 nền (bao sang tên công chứng).

- Xung quanh có nhiều tiện ích: Trường học cấp 1,2,3 công viên, siêu thị Coop Mart, đối diện các Khu Công Nghiệp lớn đang hoạt động mạnh.

- Thuận tiện cho việc định cư lâu dài, xây trọ cho công nhân.

- Sổ hồng chính chủ, bao mọi chi phí sang tên công chứng.', NULL, 2350000000, 1, CAST(N'2022-07-12T22:46:45.3129386' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (65, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Phước Long A', N'Đường Phước Long', N'Bán Đất View Sông Long Phước, Quận 9, Tp Thủ Đức', 32, N'string                                            ', 15, N'BÁN ĐẤT LONG PHƯỚC, QUẬN 9 VIEW SÔNG
Vị trí: Mặt tiền đường số 5-Long Phước & Mặt Sông.
- Diện tích đất: 10.000m2
- Giá bán: 160 tỷ', NULL, 160000000000, 1, CAST(N'2022-07-12T22:51:43.8621994' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (66, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Huyện Củ Chi', N'Thị trấn Củ Chi', N'Củ Chi', N'10×30m đất thổ cư em bán ngay gần trung tâm Củ Chi', 33, N'string                                            ', 15, N'Vị trí: Nằm trong trung tâm thị trấn cách quốc lộ 22 1km.
Ngang 10m dài 30m, thổ cư hết đất.
Mặt tiền đường trước nhà 20m.
Khu dân cư đông, an ninh gần ủy ban xã.
Sổ chính chủ bán.', NULL, 710000000, 1, CAST(N'2022-07-12T22:56:42.9244793' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (67, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Long Thạnh Mỹ', N'Đường Nguyễn Xiển', N'Bán shophouse Quận 9, mặt tiền Vành Đai 3 và Lò Lu', 34, N'string                                            ', 16, N'Bán shophouse Quận 9, mặt tiền đường Vành Đai 3 và đường Lò Lu. Ngay khu dân cư hiện hữu, trong khu đô thị 20ha sầm uất thuận tiện kinh doanh và cho thuê.

Giá chỉ từ 50tr/m2, diện tích đa dạng từ 120m2 - 300m2, thiết kế đa dạng từ 2 tầng - 4 tầng.

Thanh toán nhẹ nhàng đến quý 4/2024, được ân hạn gốc và miễn lãi tới 18 tháng.', NULL, 6000000000, 1, CAST(N'2022-07-12T23:01:03.3261860' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (68, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 12', N'Phường An Phú Đông', N'34/45A - 34/45B, Đường Võ Thị Thừa', N'BÁN NHÀ XƯỞNG 1.700,8 m2 AN PHÚ ĐÔNG, QUẬN 12', 35, N'string                                            ', 16, N'BÁN NHÀ XƯỞNG 1.700,8 m2 AN PHÚ ĐÔNG, QUẬN 12
Tại: 34/45 - 34/45A - 34/45B Đường Võ Thị Thừa, KP3, P. An Phú Đông, Quận 12, TP. HCM
- Diện tích: 21.2m x 80.2m = 1.700,8m2 nở hậu; Thổ cư 1.303,6m2
- Vị trí: Cách Quốc Lộ 1A 100m, gần Ngã Tư Bình Phước (3km), trung tâm quận Gò Vấp (6km), sân bay Tân Sơn Nhất (8km). Có 3 hướng ra vào từ Quốc Lộ 1A, đường nhựa, xe container ra vào 24/24, không kẹt xe, không cấm giờ, thuận tiện lưu thông hàng hóa.
- Xưởng mới phù hợp làm nhà máy sản xuất kinh doanh cho các doanh nghiệp, các tập đoàn trong nước hoặc nước ngoài đầu tư.
- Có 2 văn phòng làm việc, 1 phòng bảo vệ, khu vực để xe thông thoáng, thuận tiện cho việc xuất nhập hàng, tường bao khép kín, 2 lớp cửa kiên cố, an ninh cao.
- Xây dựng theo tiêu chuẩn công nghiệp:
• Tôn Hoa Sen, thép hình I Posco, xà gồ Nhật.
• Nền cao khô ráo bằng bê tông cốt thép chịu lực cao, xoa nền bằng Hardener tăng độ cứng, giúp sàn luôn sạch sẽ và dễ dàng vệ sinh.
• Kết cấu xưởng gắn cẩu trục 5 tấn dài 74m.
• Nóc cao 11.5m thông gió, có lưới inox ngăn côn trùng.
• Có hệ thống PCCC.
• Điện 3 pha, nước thủy cục sử dụng riêng.
Giá bán: 85 tỷ', NULL, 85000000000, 0, CAST(N'2022-07-12T23:04:21.5516188' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (69, 1, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Tân Phú', N'Phường Phú Thạnh', N'Văn Cao', N'Sang Hoặc Thuê Trung Nguyên Ecoffee Tân phú', 36, N'string                                            ', 16, N'Đi công tác gấp k ai quản lý cần sang hoặc cho thuê trung nguyên ecoffee Văn cao tân phú.

Giá 520tr thương lượng.

Quán mới sửa sạch sẻ thoáng mát, ae xem là ok giá thuê 20tr.

Doanh thu quán trung bình ngày 2tr5 đến 3tr ngày lễ lên 3-4tr.', NULL, 520000000, 0, CAST(N'2022-07-12T23:08:27.7399641' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (70, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường An Khánh', N'44 đường Lương Định Của', N'Toyota Camry 2.5Q siêu lướt', 1, N'string                                            ', 18, N'GÓC XE LƯỚT
Em đang có sẵn 3 chiếc Camry 2.5Q siêu siêu lướt từ 2019-2022. Mời Các Anh Chị Em Tham Khảo ạ:
- 2.5Q màu trắng ngọc trai 2022 siêu lướt 5000km
- 2.5Q màu đen 2020 siêu lướt 12k km
- 2.5Q màu đen 2019, lăn bánh 2020 siêu lướt 14k km
- Honda City 2020, siêu lướt 2.000km', NULL, 1184999999, NULL, CAST(N'2022-07-13T11:47:50.0283277' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (71, 2, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Hiệp Bình Phước', N'Hiệp Bình Phước', N'MG5 Standar nhập khẩu Thái Lan chỉ 145 tr nhận xe', 2, N'string                                            ', 18, N'=> MG5 bản Standar có sẵn xe giao ngay hỗ trợ trả góp chỉ 145 triệu nhận xe ngay

🚗 MG ZS:
ZS Standar: 519.000.000 đ
ZS Luxury: 619.000.000 đ

🚗 MG5:
MG5 Standar: 515.000.000đ
MG5 Luxury: 579.000.000đ
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒄𝒉𝒐̂́𝒏𝒈 𝒃𝒐́ 𝒄𝒖̛́𝒏𝒈 𝒑𝒉𝒂𝒏𝒉 (𝑨𝑩𝑺
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒌𝒊𝒆̂̉𝒎 𝒔𝒐𝒂́𝒕 𝒄𝒂̂𝒏 𝒃𝒂̆̀𝒏𝒈 đ𝒐̣̂𝒏𝒈 (𝑽𝑫𝑪)
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒑𝒉𝒂̂𝒏 𝒑𝒉𝒐̂́𝒊 𝒍𝒖̛̣𝒄 𝒑𝒉𝒂𝒏𝒉 đ𝒊𝒆̣̂𝒏 𝒕𝒖̛̉ (𝑬𝑩𝑫)
- 𝑲𝒊𝒆̂̉𝒎 𝒔𝒐𝒂́𝒕 𝒉𝒂̀𝒏𝒉 𝒕𝒓𝒊̀𝒏𝒉
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒌𝒊𝒆̂̉𝒎 𝒔𝒐𝒂́𝒕 đ𝒐̣̂ 𝒃𝒂́𝒎 đ𝒖̛𝒐̛̀𝒏𝒈 (𝑻𝑪𝑺)
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒌𝒉𝒐̛̉𝒊 𝒉𝒂̀𝒏𝒉 𝒏𝒈𝒂𝒏𝒈 𝒅𝒐̂́𝒄 (𝑯𝑯𝑪)
- 𝑪𝒉𝒖̛́𝒄 𝒏𝒂̆𝒏𝒈 𝒍𝒂̀𝒎 𝒌𝒉𝒐̂ 𝒑𝒉𝒂𝒏𝒉 đ𝒊̃𝒂 (𝑩𝑫𝑾)
- 𝑪𝒂̉𝒎 𝒃𝒊𝒆̂́𝒏 𝒂́𝒑 𝒔𝒖𝒂̂́𝒕 𝒍𝒐̂́𝒑 𝒕𝒓𝒖̛̣𝒄 𝒕𝒊𝒆̂́𝒑 (𝑻𝑷𝑴𝑺)
- 𝑲𝒊𝒆̂̉𝒎 𝒔𝒐𝒂́𝒕 𝒑𝒉𝒂𝒏𝒉 𝒐̛̉ 𝒈𝒐́𝒄 𝒄𝒖𝒂 (𝑪𝑩𝑪)
- 𝑪𝒂̉𝒎 𝒃𝒊𝒆̂́𝒏 𝒕𝒓𝒂́𝒏𝒉 𝒗𝒂 𝒄𝒉𝒂̣𝒎 𝒑𝒉𝒊́𝒂 𝒔𝒂𝒖
- 4-6 𝒕𝒖́𝒊 𝒌𝒉𝒊́
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒌𝒉𝒐́𝒂 𝒗𝒊 𝒔𝒂𝒊 đ𝒊𝒆̣̂𝒏 (𝑿𝑫𝑺)
- 𝑯𝒆̣̂ 𝒕𝒉𝒐̂́𝒏𝒈 𝒌𝒊𝒆̂̉𝒎 𝒔𝒐𝒂́𝒕 𝒄𝒉𝒐̂́𝒏𝒈 𝒍𝒂̣̂𝒕 𝒙𝒆 (𝑨𝑹𝑷)
- 𝑯𝒐̂̃ 𝒕𝒓𝒐̛̣ đ𝒐̂̉ đ𝒆̀𝒐 (𝑯𝑫𝑪)
- 𝑪𝒂̉𝒏𝒉 𝒃𝒂́𝒐 đ𝒊𝒆̂̉𝒎 𝒎𝒖̀ (𝑩𝑺𝑫)
- 𝑪𝒂̉𝒏𝒉 𝒃𝒂́𝒐 𝒎𝒐̛̉ 𝒄𝒖̛̉𝒂 𝒂𝒏 𝒕𝒐𝒂̀𝒏 (𝑫𝑶𝑾)
- 𝑪𝒂̉𝒏𝒉 𝒃𝒂́𝒐 𝒑𝒉𝒖̛𝒐̛𝒏𝒈 𝒕𝒊𝒆̣̂𝒏 𝒄𝒂̆́𝒕 𝒏𝒈𝒂𝒏𝒈 𝒑𝒉𝒊́𝒂 𝒔𝒂𝒖 (𝑹𝑪𝑻𝑨)
- 𝑯𝒐̂̃ 𝒕𝒓𝒐̛̣ 𝒄𝒉𝒖𝒚𝒆̂̉𝒏 𝒍𝒂̀𝒏 (𝑳𝑪𝑨)

✔️Tặng Gói Phụ Kiện Cao Cấp.
✔️Ưu Đãi Thêm Tiền Mặt.
✔️Màu sắc: Trắng, đỏ, đen, xám, vàng, bạc
✔️Hỗ trợ trọn gói cho Khách hàng: ngân hàng, đăng ký, đăng kiểm
và hậu mãi
🏦 𝐇𝐨̂̃ 𝐭𝐫𝐨̛̣ 𝐭𝐫𝐚̉ 𝐠𝐨́𝐩 𝐥𝐞̂𝐧 đ𝐞̂́𝐧 85% với lãi suất hấp dẫn
✔️5 năm Bảo hành không giới hạn KM
✔️5 năm Cứu hộ MG care 24/7
=> ĐỂ ĐƯỢC TƯ VẤN MIỄN PHÍ VÀ NHIỆT TÌNH XIN VUI LÒNG liên hệ Hotline:', NULL, 515000000, NULL, CAST(N'2022-07-13T12:04:22.4821023' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (72, 2, N'0786266752', N'', 0, 1, N'Tỉnh Long An', N'Thành phố Tân An', N'Phường 6', N'24 quốc lộ 1, Khu đô thị trung tâm Hành Chính Tỉnh', N'SANTAFE FULL DẦU PREMIUM SIÊU LƯỚT TRÊN THỊ TRƯỜNG', 3, N'string                                            ', 18, N'HYUNDAI SANTAFE DẦU PHIÊN BẢN PREMIUM 2021
__________________________________
🔹️Màu Trắng - Nội thất Nâu
🔹️Sản xuất 2021 . Đăng ký 2021
🔹️Lăn bánh: 24.000 Km
🔹️Động cơ Smartstream D2.2. Hộp số ly hợp kép ướt 8 cấp DCT
🔹️Trang bị nhiều tính năng tiện nghi:
- Đèn Auto Full Led tự động thích ứng
- Camera 360°
- Mâm 19 inch
- Màn hình thông tin Digital 12,3 inch
- Màn hình HUD
- 4 chế độ lái
- Hệ thống sưởi/làm mát ghế
- Cần số nút bấm
- Hệ thống 10 loa Harman Kardon
- Chìa khóa đề nổ từ xa
- Cảm biến áp suất lốp, v.v...
🔹️Tính năng an toàn bậc nhất: Hỗ trợ va chạm điểm mù, Giám sát điểm mù, Hỗ trợ giữ làn, Cảnh báo phương tiện cắt ngang khi lùi, Hỗ trợ phòng tránh va chạm người đi bộ, v.v...
🔹️Bảo hành chính hãng 5 năm đến năm 2026
💵Giá bán: 1 tỷ 5xx triệu
🏦Hỗ trợ vay ngân hàng 70% giá trị xe
', NULL, 1505000000, NULL, CAST(N'2022-07-13T12:12:44.6446320' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (73, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 22', N'Bình Thạnh', N'Honda Wave A tháng 3/ 2022 Mới 99% BSTP 1 đời chủ', 4, N'string                                            ', 19, N'Bán xe Honda Wave A mua tháng 3 năm 2022 . BSTP Xe 1 đời chủ .
* Tình trạng xe còn mới 99% . Đúng đời 2022 . Odo 800km . Còn đủ 2 kính 2 chìa khóa theo xe . Nói chung xe như mới trong hãng dắt ra , không chỗ chê , hình chụp rất chi tiết . Ai cần mua sử dụng tôi để giá 21 triệu 800 . Sẽ công chứng liền cho người mua .
* Xem xe tại 131 Ngô Tất Tố . P22 Q Bình Thạnh . Gọi trực tiếp gặp tôi xem xe . Thu 59 tuổi .', NULL, 21800000, NULL, CAST(N'2022-07-13T12:20:31.8862396' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (74, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Linh Trung', N'Linh Trung', N'Vario 150 2020 Siêu Lướt Biển VIP 31111 Chính Chủ', 5, N'string                                            ', 19, N'🌈 Siêu Phẩm Vario 150 2020 Biển VIP 31111 Siêu Lướt

➖#BSTP_31111
➖Đăng Kí : 2020
➖Odo 6k chuẩn
➖Chất xe siêu lướt mới như xe thùng
➖Ốc bánh trước sau chưa mở, cặp vỏ zin dày cui
➖BSTP chính chủ công chứng, sang tên nhanh lẹ
➖Xe như xe mới ko cần tả nhiều nha ae

💵Giá : Call

🔶 Nhận Giao Lưu Trao Đổi Các Thể Loại Bù Trừ Thương Lượng
🔥 Chính sách bảo hành 6-12 tháng cho ace yên tâm', NULL, 96000000, NULL, CAST(N'2022-07-13T13:35:50.2656246' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (75, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường An Khánh', N'20 Đường Số 6', N'Ab 150 thắng ABS chạy đúng 4 ngàn km', 6, N'string                                            ', 19, N'✅ Ab 150 ABS
❇ Đkí 6–2020 Odo chuẩn 4k bao test

Máy nguyên zin. xe đẹp ko trầy. Xe dán keo. Đủ đồ zin theo xe, xe 9 chủ kí giấy uy quyền vs mua bán 1p30s

✅ Giá 52Tr 999 fix lộc

✅ —- Mua Bán Trao Đổi Xe Máy Các Loại ..!
Hổ trợ quẹt thẻ tính dụng chuyển đổi trả góp

🏠 Xem xe 20 đường số 6 phường Bình An Q2 TpTĐ', NULL, 53000000, NULL, CAST(N'2022-07-13T13:45:16.0964550' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (76, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 12', N'Phường An Phú Đông', N'An Phú Đông', N'🔥Xe Tải Hino FC 6T 5M7-6M7-7M2 Góp 200Tr Xe Sẵn!', 7, N'string                                            ', 20, N'🔥Tặng ngay 10 triệu khi mua xe ngay hôm nay
--------------------
👉Trả trước 20-30% giao xe
👉Hỗ trợ vay trả góp lãi suất thấp trong vòng 6 năm
-------------------
🔥- Xe mới 100%, có sẵn
- Quà tặng giá trị gồm: định vị, phù hiệu, bao da tay lái, thảm lót sàn
- Khả năng chuyên chở lớn
- Thùng chắc chắn, bền đẹp. Nhận đóng thùng theo yêu cầu
- Vay ngân hàng không thế chấp. Bao mọi thủ tục. Giấy tờ chỉ cần: CMT, hộ khẩu, ĐK kết hôn (nếu đã lập gia đình)
- Xe chạy cực bốc. Di chuyển tốt trên mọi cung đường
----------------
🔥Thông số kỹ thuật:
Trọng lượng bản thân: 4005 Kg
Tải trọng cho phép chở: 6.200 kg - 6.600kg
Trọng lượng toàn bộ: 11000 kg
Kích thước lòng thùng hàng: 5m6, 6m7, 7m2
Công thức bánh xe: 4 x 2
Loại nhiên liệu: Diesel
Nhãn hiệu động cơ: J05E-UA
Loại động cơ: 4 kỳ, 4 xi lanh thẳng hàng, tăng áp
Thể tích: 5123 cm3
Công suất lớn /tốc độ quay: 132 kW/ 2500 v/ph', NULL, 860000000, NULL, CAST(N'2022-07-13T13:57:55.7605750' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (77, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 12', N'Phường An Phú Đông', N'An Phú Đông', N'Xe cẩu HUYNDAI đời 2018', 8, N'string                                            ', 20, N'Do bể hợp đồng công trình nên cần ra đi gấp xe cẩu HUYNDAI đời 2018 bao zin chưa đâm đụng 1 đời chủ ngay mình đứng tên


Xe bao sạch sẽ từ trong ra ngoài máy lạnh còn đầy đủ


Hiện trạng xe như hình ae cứ đến xem xe trực tiếp rồi trả giá


Miễn tiếp tin nhắn


Xem xe trực tiếp tại quận 12 TP.HCM


CÒ LÁI THA EM


CẢM ƠN AE ĐÃ BẤM VÀO XEM TIN', NULL, 899999998, NULL, CAST(N'2022-07-13T14:04:15.9911634' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (79, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 13', N'Bình Thạnh', N'Cần bán xe Klara A1 hình thức đẹp', 10, N'string                                            ', 21, N'Odo : 12000
Xe còn nguyên vẹn không bể vỡ
Màu đen', NULL, 15500000, NULL, CAST(N'2022-07-13T14:44:15.4689329' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (80, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 7', N'Phường Tân Kiểng', N'', N'❤Xe Trinx Tempo1.0 99%New', 11, N'string                                            ', 22, N'❤Xe mang thương hiệu Trinx cao cấp đến từ Taiwan
❤Khung xe bằng Nhôm cao cấp cực kỳ nhẹ
❤️Bánh xe 700C
❤️Màu xe Đen phối Cam thể thao - cá tính
🏠Xem xe tại : 81 đg 11 fuong Tân Kiểng Q7
Gọi 10 phut truoc khi qua', NULL, 3950000, NULL, CAST(N'2022-07-13T20:12:41.8934723' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (81, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 6', N'Phường 10', N'', N'Touring PEUGEOT thương hiệu Pháp', 12, N'string                                            ', 22, N'_ Touring PEUGEOT thương hiệu Pháp ( xe bãi nhật ) . Khung sườn thép kiểu cổ điển, bánh 26inch, 1x7 shimano, sơn zin có trầy xước, tổg thể xe còn đẹp 90%...
_ nhận cuộc gọi trực tiếp Ae có thiện chí ( KHÔNG NHẮN TIN ) xin cảm ơn', NULL, 7800000, NULL, CAST(N'2022-07-13T20:21:36.0608988' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (82, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 8', N'Phường 14', N'21l1/40 Ngô Sĩ Liên', N'Xe đạp martin', 13, N'string                                            ', 22, N'Xe chạy còn tốt
Bán xe cho gọn nhà hơn
Anh em nào cần liện hệ
Giá cả thì có thể trả giá', NULL, 75000, NULL, CAST(N'2022-07-13T20:25:00.9587082' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (83, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Huyện Hóc Môn', N'Xã Bà Điểm', N'', N'Xe nâng 3t 3ty 3 đao càng dịch chuyển', 14, N'string                                            ', 23, N'2 xe tình trạng ngon lành xe nhập nhật máy em rủ báo sài xanh 170tr vàng 110tr', NULL, 100000000, NULL, CAST(N'2022-07-13T20:36:19.9042220' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (84, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Tân Phú', N'Phường Tây Thạnh', N'', N'thanh lí vỏ xe size nhỏ không ruột cho ex wave', 19, N'string                                            ', 24, N'Gai 90% hàng mechelin thái lan
Size
60/90-17
70/90-17

Không ruột , có ship cho Anh em ở xa mọi miền tổ quốc', NULL, 700000, NULL, CAST(N'2022-07-13T21:37:35.2297381' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (85, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Tân', N'Phường Bình Trị Đông A', N'', N'Máy wave alpha', 20, N'string                                            ', 24, N'Y hình ae qua lấy nhanh gọn lẹ bớt ít
TPHCM Bình Tân giao dịch trực tiếp ko ship', NULL, 3500000, NULL, CAST(N'2022-07-13T21:40:42.3832871' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (86, 2, N'0786266752', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 6', N'Phường 14', N'', N'Mâm ô tô 18 inch mới 99,9%', 21, N'string                                            ', 24, N'Mâm xe cao cấp, gắn
được hầu hết các dòng xe Đức, Mỹ, Nhật - Hàn size 18 inch, lốp 245
/40/R18 hàng nhập còn 99,9% sử dụng được nhiều dòng xe sang. Giá 16 triệu trọn bộ 4 cái', NULL, 16000000, NULL, CAST(N'2022-07-13T21:42:55.3056283' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (87, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 13', N'', N'N20 ultra 5g- qtế mỹ zin 2sim chíp Snapdragon 99%', 1, N'string                                            ', 25, N'N20ultra 5g bảng mỹ chip Snapdragon ram 12gb full áp suất zin bao test nước. Bao lỗi 30ngày đầu phần cứng 1 đổi 1.hỗ trợ bảo hành 12tháng tiếp theo cho máy .dòng n20ultra 5g mỹ là bảng cấu hình mạnh mẽ. Màn hình đẹp nhất trong dòng n20ultra.xài 2sim esim nhé. Bút spen thần thánh rất tiện lợi cho ai làm vic văn phòng. Pin rất tốt .bảo mật vân tay nhận diện khuôn mặt cừc kỳ nhại.màn hình và camera cực đỉnh.zom chuẩn bung ko vỡ hình ảnh nhé. Sạc nhanh tai nghe kèm theo máy. Xem tt tại 338/1b Nơ Trang Long f13 Bình Thạnh', 0, 12900000, NULL, CAST(N'2022-07-14T12:07:55.2473657' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (88, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 10', N'Phường 01', N'', N'❇️IP 12 PRO MAX QTE MỚI ❇️TRẢ TRƯỚC 0Đ NHẬN MÁY', 2, N'string                                            ', 25, N'🌟🌟🌟 SUNO MOBIE SHOP IPHONE - IPAD UY TÍN TẠI SÀI GÒN 🌟🌟🌟
ĐỊA CHỈ :498/13 LÊ HỒNG PHONG ,P1 QUẬN 10
• Sản phẩm : 12 PRO MAX QUỐC TẾ
GIÁ BÁN: -17.5000.000
👉 NHẬN SHIP HÀNG TẬN NHÀ XUYÊN QUỐC GIA, MIỄN PHÍ SHIP SÀI GÒN .

👉THỦ TỤC MUA TRẢ GÓP CẦN:
- CMND HOẶC CCCD
- Không cần chứng minh thu nhập.
- Không giữ lại giấy tờ gốc.
- Áp dụng toàn quốc từ 20 tuổi trở lên.
- Thời gian xét duyệt nhanh

✅SUNO SHOP CAM KẾT:
✔️ Chỉ bán máy nguyên zin chính hãng Apple máy đẹp ✔️ Hoàn lại tiền 10 lần nếu phát hiện hàng giả hàng nhái .
✔️ Chế độ bảo hành #UY_TÍN . Không gây khó khăn hay đổi lỗi cho khách hàng trong trường hợp máy có lỗi nhà cung cấp.

✅CHẾ ĐỘ BẢO HÀNH VÀ ĐỔI TRẢ:
📌Bảo hành 12 Tháng Phần Cứng
📌Đổi mới 15 ngày đối với máy cũ ( Miễn phí, không hạn chế số lần đổi ).
📌 Dán cường lực miễn phí 18 tháng.
📌 Bảo hành phần mềm trọn đời máy .

✅QUYỀN LỢI KHÁCH HÀNG KHI MUA MÁY TẠI cửa hàng
✔️ Tặng đủ phụ kiện: sạc cáp, cường lực, ốp lưng..
✔️ Hỗ trợ khách hàng có nhu cầu lên đời máy .
', 0, 17500000, NULL, CAST(N'2022-07-14T14:29:29.3084069' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (89, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Tân Phú', N'Phường Tân Thành', N'', N'Galaxy Z Fold 3 bảo hành 22/9/2023', 3, N'string                                            ', 25, N'Bán máy ZFold 3 256gb bảo hành chính hãng cực dài và có bảo hiểm rơi vỡ vô nước Care+ đến 22/9/2023
Máy mới 98 có trầy nhẹ viền lầm tấm như hình, máy nguyên zin áp xuất cứng ngắt.
Phụ kiện có sạc cáp và bao da chính hãng tặng hết cho ai cần
Giá 23tr7 xem máy tại nhà yên tâm ạ', 0, 23700000, NULL, CAST(N'2022-07-14T14:32:59.0660598' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (90, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Gò Vấp', N'Phường 07', N'', N'Apple iPad Mini 4 32GB 4G Wifi | Hỗ trợ Góp', 4, N'string                                            ', 26, N'iPad Mini 4 32GB Wifi 4G
💰 Giá chỉ từ :
- 5tr990K( 97% có trầy cấn )
- 6tr390K( 99% máy đẹp keng )
🔥Vio Store cam kết chỉ bán hàng nguyên bản :
👉🏾 Main Zin , Màn zin ,chưa sửa chữa
👉🏾 Không bán hàng sửa main thay màn kém chất lượng

☎️Liên lạc với chúng tôi
👉🏾 Địa chỉ :
🏠CN1: Số 97 Lê Đức Thọ - Phường 7 - Gò Vấp - TP.HCM
🏠CN2: Số 55 Nguyễn Thiện Thuật - P2 -Q3 - TP.HCM

⛔️Chính sách Bảo Hành :
👉🏾 Bao đổi 1 đổi 1 trong 15 ngày sử dụng
👉🏾 Bảo hành 6 tháng PHẦN CỨNG ( Nhiều nơi đăng bảo hành 12 tháng nhưng chỉ BH phần mềm thôi )
👉🏾 Hỗ trợ phần mềm trọn đời máy

💡Hỗ trợ thanh toán
👉🏾 Trả góp 0% với thẻ tín Dụng của hơn 20 Ngân hàng trong nước và Quốc Tế
👉🏾 Hỗ trợ trả góp lãi suất thấp ,Xét duyệt nhanh , thủ tục đơn giản
( Chứng minh thư và Bằng lái Hoặc CMT Và Sổ hộ khẩu)
👉🏾 Hỗ trợ Quẹt thẻ thanh toán Với mọi Loại thẻ ATM ,Vía, Master...

🎂Phụ kiện
👉🏾 Sạc Cáp tặng (trị giá 150K)
👉🏾 Giảm 30% giá linh phụ kiện

🚚Vận chuyển , Giao hàng
👉🏾 Giao hàng tận nơi nội thành TP.HCM
👉🏾 Giao hàng COD tận nơi 64 Tỉnh thành
- Click vào cửa hàng để xem thêm nhiều sản phẩm hơn', 0, 6590000, NULL, CAST(N'2022-07-14T14:48:09.4707370' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (91, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Gò Vấp', N'Phường 07', N'', N'Máy Tính Bảng Lenovo Tab 3 8inch New | Học Online', 5, N'string                                            ', 26, N'☘ SHOP CÓ BÁN TRẢ GÓP ☘️

📲 Máy Tính Bảng Lenovo Tab 3 8inch- Học Online , Chơi Game , xem phim !!
Giá 🥇 1.290K ( 100% )

🔥Vio Store cam kết chỉ bán hàng nguyên bản :
👉🏾 Main Zin , Màn zin ,chưa sửa chữa
👉🏾 Không bán hàng sửa main thay màn kém chất lượng

☎️Liên lạc với chúng tôi
👉🏾 Địa chỉ :
🏠CN1: Số 97 Lê Đức Thọ - Phường 7 - Gò Vấp - TP.HCM
🏠CN2: Số 55 Nguyễn Thiện Thuật - P2 -Q3 - TP.HCM

⛔️Chính sách Bảo Hành :
👉🏾 Bao đổi 1 đổi 1 trong 15 ngày sử dụng
👉🏾 Bảo hành 6 tháng PHẦN CỨNG ( Nhiều nơi đăng bảo hành 12 tháng nhưng chỉ BH phần mềm thôi )
👉🏾 Hỗ trợ phần mềm trọn đời máy

💡Hỗ trợ thanh toán
👉🏾 Trả góp 0% với thẻ tín Dụng của hơn 20 Ngân hàng trong nước và Quốc Tế
👉🏾 Hỗ trợ trả góp lãi suất thấp ,Xét duyệt nhanh , thủ tục đơn giản
( Chứng minh thư và Bằng lái Hoặc CMT Và Sổ hộ khẩu)
👉🏾 Hỗ trợ Quẹt thẻ thanh toán Với mọi Loại thẻ ATM ,Vía, Master...

🎂Phụ kiện
👉🏾 Tặng Gậy Lấy Sim
👉🏾 Sạc Cáp +190K
👉🏾 Giảm 20% giá linh phụ kiện

🚚Vận chuyển , Giao hàng
👉🏾 Giao hàng tận nơi nội thành TP.HCM
👉🏾 Giao hàng COD tận nơi 64 Tỉnh thành', 0, 1290000, NULL, CAST(N'2022-07-14T14:51:17.8972536' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (92, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Gò Vấp', N'Phường 07', N'620 Đường Phạm Huy Thông', N'iPad Pro M1 12.9inch fullbox còn bảo hành', 6, N'string                                            ', 26, N'Bán iPad Pro M1 12.9inch (2021) fullbox còn bảo hành chính hãng apple 27/9/2022
Máy mình rất ít dùng, mới sạc 43 lần, pin còn 100%
Đầy đủ mọi chức năng, hoạt động hoàn hảo, màn hình mini-led sáng đẹp, pin trâu
Xem máy tại nhà mình.', 0, 18000000, NULL, CAST(N'2022-07-14T14:54:43.7001222' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (93, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Linh Chiểu', N'', N'DELL N3501, i5_1135G7, 12G, 256G, BH 10-2022, 99%', 7, N'string                                            ', 27, N'TINHOCMIENNAM.COM
Laptop DELL Inspiron 3501 - Zin 100%, ngoại hình đẹp 99%, BH Hãng 31-9-2022
Thiết kế gần như hoàn hảo với các công việc văn phòng + Màn 15.6IN Tràn Viền
=====================================
Cấu hình kĩ thuật :
- CPU: Intel® Core™ i5-1135G7 ( 2.40 upto 4.20GHz ) Thế hệ 11
- RAM: 12GB DDR4 Buss 3200
Ổ Cứng: 256GB NVMe™ PCIe® 3.0 SSD ( Truy xuất dữ liệu cực nhanh )
VGA: Card đồ họa tích hợp, Intel UHD Graphics
- Màn hình: 15.6 inch, 60 Hz, 220 nits, Wide-Viewing Angle (WVA)
- Pin 3h Adpater zin theo máy!
- Cổng kết nối: USB 3.2 Gen 1 Type-A | USB 3.2 Gen 1 Type-C | USB 2.0 Type-A | HDMI 1.4 | Micro SD
- Tặng kèm: Túi chống sốc + chuột không dây

Gía bán: 12.500.000đ ( bảo hành hãng đến 31-10-2022 , Bao test trong 7 ngày đầu sử dụng )

⭕️⭕️⭕️ HỖ TRỢ TRẢ GÓP QUA THẺ TÍN DỤNG
⭕️⭕️⭕️ HỖ TRỢ TRẢ GÓP BẰNG CMND + BẰNG LÁI XE, ( HỘ KHẨU ) LÃI SUẤT THẤP
⭕️⭕️⭕️ THANH TOÁN TIỀN MẶT HOẶC QUẸT THẺ

👉 Cở sở 1: 170/48 Lê Đức Thọ , P6 , Gò vấp
👉 Cở sở 2: 2/2 Đường số 6, P Linh Chiểu , Thủ Đức ( K bên NGUYỄN KIM VÀ NHÀ VĂN HÓA THIẾU NHI Thủ Đức
👉 : Ship COD toàn quốc nhận máy thanh toán , Giao hàng tận nơi khu vực HCM
======================================
✅ Bấm vào " XEM CỬA HÀNG " để xem thêm nhiều sản phẩm khác của shop
✅ Bấm vào " XEM CỬA HÀNG " để xem thêm nhiều sản phẩm khác của shop
✅ Bấm vào " XEM CỬA HÀNG " để xem thêm nhiều sản phẩm khác của shop', 0, 12500000, NULL, CAST(N'2022-07-14T15:20:35.0734936' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (94, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 22', N'', N'Laptop Acer Aspire mới 99% (ít sử dụng)', 8, N'string                                            ', 27, N'Máy mình ít sử dụng do đã có PC.
Muốn bán để tránh lãnh phí.
Rất mong bán được cho các bạn thực sự có nhu cầu học tập.
Máy không dành cho chơi game nên rất bền.
Có thể kiểm tra tận nơi.
Có nhận giao tận nơi, thời gian giao thoả thuận.', 0, 13000000, NULL, CAST(N'2022-07-14T15:24:17.0507216' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (95, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 17', N'', N'MacBook Pro touch bar sách tay nhật về nguyên zin', 9, N'string                                            ', 27, N'MacBook Pro touch bar 2016,13.inch
Cấu hình :
Core i7-3.3ghz
Ram 16 gb
SSD 512 gb
Pin 4 giờ
Máy đẹp lik new 99%
Full chức năng

Giá: 14.500
LH:
Bảo hành 1 đổi 1 trong vòng 30 ngày
Bao sử dụng 15 ngày
Có ship tận nhà ( kiểm tra hàng trước khi thanh toán )', 0, 14500000, NULL, CAST(N'2022-07-14T15:29:22.0609080' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (96, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 10', N'Phường 10', N'', N'imac 27" 2k 2012 2013 giá tốt. BH 6 tháng', 10, N'string                                            ', 28, N'ần bán vài chiếc imac 2012 2k 27"
Máy đẹp, nhiều cấu hình: văn phòng và đồ hoạ.

✅Cấu hình: i5/8gb/hdd 1tb
✅Giá bán: 13.500 - máy dây nguồn

❤️BH 6 tháng
Tặng bàn phím chuột windows

Ae cần nâng cấp cấu hình đồ hoạ inbox nhé.


Đang có imac 5K 2014 2105 đủ mã


Táo Vui - Chuyên mua bán sửa chữa Apple & Laptop.
CN1: Số 526/1 Lê Hồng Phong, P1, Quận 10 CN2: Số 1030 Nguyễn Trãi, P14, Quận 5', NULL, 13500000, NULL, CAST(N'2022-07-14T15:39:35.5159975' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (97, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 10', N'Phường 07', N' 140/9 Lý Thường Kiệt', N'Aio Dell Optiplex 3240 - 7440 - 7450 Japan', 11, N'string                                            ', 28, N'Loại máy: Desknote Dell OptiPlex 7450 All in One
Màn hình: 24 inch LED IPS Ultra HD
Bo mạch chủ: Intel® Q270 Express Chipset
Bộ xử lý: Intel Core™ i5 7500 3.40Ghz max 3.80Ghz
Ổ cứng: SSd M2 128Gb + Hdd 1Tb
Ram: 8GB DDR4 Bus 2400
Card màn hình: Intel HD Graphics 630
Cổng giao tiếp trước: 1 USB Type C. 1 USB 3.0 . Jack 3.5
Cổng giao tiếp sau: 4 USB 3.0, 2 USB 2.0, DisplayPort, 1 HDMI in, 1 HDMI Out, RJ45
Tình trạng: Hàng nhập zin từ Nhật, mới trên 97%
Bảo hành 3 tháng.tặng kèm phím chuột
Giá 7tr800k

Loại máy: Desknote Dell OptiPlex 7440 All in One
Màn hình: 24 inch LED IPS Ultra HD
Bo mạch chủ: Intel® Q170 Express Chipset
Bộ xử lý: Intel Core™ i5 6500 3.20Ghz max 3.60Ghz
Ổ cứng: SSd M2 128Gb + Hdd 1Tb
Ram: 8GB DDR4 Bus 2400
Card màn hình: Intel HD Graphics 530
Cổng giao tiếp trước: 2 USB 3.0
Cổng giao tiếp sau: 4 USB 3.0, 2 USB 2.0, DisplayPort, 1 HDMI in, 1 HDMI Out, RJ45
Tình trạng: Hàng nhập zin từ Nhật, mới trên 97%
Bảo hành 3 tháng.tặng kèm phím chuột
Giá 7tr300k

Loại máy: Desknote Dell OptiPlex 3240 All in One
Màn hình: 21.5 inch LED IPS Ultra HD
Bo mạch chủ: Intel® H110 Express Chipset
Bộ xử lý: Intel Core™ i5 6500 3.20Ghz max 3.60Ghz
Ổ cứng: SSd 256Gb
Ram: 8GB PC3L
Card màn hình: Intel HD Graphics 530
Cổng giao tiếp trước: 2 USB 3.0
Cổng giao tiếp sau: 4 USB 3.0, 2 USB 2.0, DisplayPort, 1 HDMI in, RJ45
Tình trạng: Hàng nhập zin từ Nhật, mới trên 97%
Bảo hành 3 tháng.tặng kèm phím chuột
Giá 6tr800k', NULL, 7800000, NULL, CAST(N'2022-07-14T15:42:30.9937146' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (98, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 12', N'Phường Tân Chánh Hiệp', N'', N'BÁN BỘ I7, CHƠI CÁC LOẠI GAME, THIẾT KẾ ĐỒ HỌA', 12, N'string                                            ', 28, N'BÁN BỘ CORE I7, MÁY CẤU HÌNH CAO CHƠI CÁC LOẠI GAME, THIẾT KẾ ĐỒ HỌA, LÀM VIỆC, HỌC TẬP.', NULL, 5000000, NULL, CAST(N'2022-07-14T16:21:56.2613805' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (99, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 1', N'Phường Phạm Ngũ Lão', N'', N'máy quay phim 4K panasonic AG-UX90 bảo hành 03T', 13, N'string                                            ', 29, N'Kèm micro zin - túi máy-the nhớ 64G-pin 2 viên- sạc zin
Cảm biến : 1.0-type MOS Sensor
Ống kính : zoom quang 15x
Quay hình : 4K
Chống rung : 5-Axis Hybrid O.I.S.
Khe thẻ nhớ : 2 khe cắm thẻ SD', 0, 22000000, NULL, CAST(N'2022-07-14T16:27:50.5947640' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (100, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 6', N'Phường 12', N'', N'(Máy ảnh KTS) Canon 80D kèm lens 17-85mm', 14, N'string                                            ', 29, N'📷 Máy ảnh #Canon #80D kèm lens 17-85mm USM. Máy ngoại hình khá, 23k shot. Dòng drop đời cao chất ảnh rất tốt, thích hợp cả làm dịch vụ và chụp du lịch.

_ #Giá #14.500.000 VNĐ

_ Phụ kiện: Pin, sạc, thẻ nhớ, dây đeo.

🛠 Bảo hành 1 tháng tại shop Máy ảnh KTS

✓ Bên shop có nhiều dòng máy giá rẻ, các bạn cần có thể ghé xem ưng thì lấy không thôi không sao hết.

✓Xem thêm máy tại Facebook "Máy ảnh KTS"

👉 Trả góp qua Thẻ tín dụng

👉 Trả góp tài chính qua HDSaison

☎️ *** - 🏤 P14 Cư Xá Phú Lâm A P12 Q6 TPHCM (chạy vào hẻm 85 Kinh Dương Vương P12 Q6)

Gọi giúp shop trước khi đến.
Cảm ơn.', 0, 145000000, NULL, CAST(N'2022-07-14T16:31:12.2183321' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (101, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Tân Phú', N'Phường Phú Trung', N'', N'Bán Camera IP Wifi TP-Link Tapo C200', 15, N'string                                            ', 29, N'Vì không có nhu cầu sử dụng nên mình cần bán Camera IP Wifi TP-Link Tapo C200 360° 1080P 2MP.
Mua tại Cellphones tháng 05/2021. Hiện vẫn đang còn bảo hành.
Giá bán 300k.
Có hộp, sạc đầy đủ.
Giấy hướng dẫn sử dụng.
Địa chỉ: Hẻm 48 đường Lê Ngã, Phường Phú Trung, Quận Tân phú.

VUI LÒNG GỌI ĐIỆN THOẠI TRỰC TIẾP GIÚP MÌNH, MÌNH KHÔNG ONLINE NHIỀU TRÊN CHỢ TỐT.', 0, 299998, NULL, CAST(N'2022-07-14T16:34:28.8755440' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (102, 3, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 10', N'Phường 11', N'', N'Tai Nghe Powerbeats 3 Wireless Fullbox', 16, N'string                                            ', 31, N'- Xả hàng tồn kho Fullbox chưa sử dụng. Sản phẩm sử dụng chip độc quyền Apple W1, cải thiện chất lượng âm thanh mạnh mẽ.

- Pin sử dụng 12h liên tục, công nghệ sạc nhanh chỉ 5 phút cho thời lượng pin 1h chơi nhạc. Dual-Driver cung cấp một hiệu suất âm thanh cao.

- Chuẩn IPX4 chống mồ hôi và khả năng chịu nước từ chồi tai

- Cáp chống rối RemoteTalk™ bạn có thể điều chỉnh tăng giảm âm lượng hoặc chuyển đổi bài hát trong danh sách nhạc, hay thực hiện cuộc gọi ở chế độ rảnh tay..

- Sản phẩm chính hãng Beats (Apple)

****** GIÁ: 490.000Đ. Tai nghe không Fullbox và phụ kiện.
****** GIÁ: 990.000Đ. Tai nghe Fullbox, Full phụ kiện bao gồm (hộp đựng, dây sạc, nút tai, Sticker, sách hướng dẫn sử dụng).

******ÔM LÔ SỐ LƯỢNG LIÊN HỆ QUA ZALO SỐ TRÊN CHỢ TỐT

****BẢO HÀNH 01 THÁNG LỖI 1 ĐỔI 1

Liên hệ ĐT: - SỐ 71 ĐƯỜNG 3/2 , PHƯỜNG 11, QUẬN 10, (NGAY NGÃ TƯ CAO THẮNG GIAO VỚI 3 THÁNG 2).', 0, 490000, NULL, CAST(N'2022-07-15T09:45:16.5536499' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (103, 3, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Gò Vấp', N'Phường 07', N'', N'Apple Watch Series 5 40mm New Active Rồi Nobox', 17, N'string                                            ', 31, N'☘ SHOP CÓ BÁN TRẢ GÓP ☘️

📲 Apple Watch Series 5 40mm New Active vài ngày Nobox

Giá🥇 5tr790K

🔥Vio Store cam kết chỉ bán hàng nguyên bản :
👉🏾 Main Zin , Màn zin ,chưa sửa chữa
👉🏾 Không bán hàng sửa main thay màn kém chất lượng

☎️Liên lạc với chúng tôi
👉🏾 Địa chỉ :
🏠CN1: Số 97 Lê Đức Thọ - Phường 7 - Gò Vấp - TP.HCM
🏠CN2: Số 55 Nguyễn Thiện Thuật - P2 -Q3 - TP.HCM

⛔️Chính sách Bảo Hành :
👉🏾 Bao đổi 1 đổi 1 trong 15 ngày sử dụng
👉🏾 Bảo hành 6 tháng PHẦN CỨNG ( Nhiều nơi đăng bảo hành 12 tháng nhưng chỉ BH phần mềm thôi )
👉🏾 Hỗ trợ phần mềm trọn đời máy

💡Hỗ trợ thanh toán
👉🏾 Trả góp 0% với thẻ tín Dụng của hơn 20 Ngân hàng trong nước và Quốc Tế
👉🏾 Hỗ trợ trả góp lãi suất thấp ,Xét duyệt nhanh , thủ tục đơn giản
( Chứng minh thư và Bằng lái Hoặc CMT Và Sổ hộ khẩu)
👉🏾 Hỗ trợ Quẹt thẻ thanh toán Với mọi Loại thẻ ATM ,Vía, Master...

🎂Phụ kiện
👉🏾 Tặng dây đeo cao su
👉🏾 Sạc zin Aw +350k

🚚Vận chuyển , Giao hàng
👉🏾 Giao hàng tận nơi nội thành TP.HCM
👉🏾 Giao hàng COD tận nơi 64 Tỉnh thành', 0, 5790000, NULL, CAST(N'2022-07-15T09:48:07.4666903' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (104, 3, N'0854863505', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Phú Nhuận', N'Phường 03', N'', N'AW seri 6- 44mm - màu trắng- còn đẹp', 18, N'string                                            ', 31, N'mình cần bán apple watch seri 6 44mm- màu trắng, còn đẹp. kính ko trầy xước vết nào, sườn bị trầy chút xíu vài chỗ, ko đáng kể.
dung lượng pin còn 89% , cũng dc 2 ngày xài liên tục
phụ kiện : xac và cáp zin theo máy.', 0, 5100000, NULL, CAST(N'2022-07-15T09:50:44.1534133' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (105, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Thạnh', N'Phường 25', N'', N'Bán màn hình Samsung 32" cong mã C32F395', 19, N'string                                            ', 32, N'Cần thanh lý màn hình Samsung 32" cong mã C32F395. Màn đẹp sắc nét ảnh đẹp, chất lượng và hình thức đẹp', 0, 3699999, NULL, CAST(N'2022-07-15T09:54:06.5377695' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (106, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Bình Tân', N'Phường Bình Hưng Hòa', N'Hẻm Số 85 Đường Số 10', N'Apple Pencil 1, bút zin fullbox likenew, ShipCOD', 20, N'string                                            ', 32, N'🌿🌿🌿Bút Apple Pencil 1 phù hợp các dòng ipad đời cũ như air,mini,gen,phù hợp để note hoặc vẽ,học tập hoặc làm việc đều mang đến trải nghiệm mới mẽ,k có độ trễ vì là hàng chính hãng của apple sản xuất
Ngoại hình còn rất đẹp, ko cấn móp, lựa thoải mái , pin tốt
Kích thước như một chiếc bút chì dễ cầm tay.
Bút sạc pin rất đơn giản qua Lightning - 15 giây sạc sử dụng 30 phút.
Thích hợp các iPad : Air 3 , Mini 5 , Pro9.7”10.5”12.9”Gen1-2 , Gen6-7-8-9

☀
Có hộp zin cực kỳ thích hợp làm quà tặng người thân, công việc, nghệ thuật, học tập giải trí đều rất ok.
💸 Giá bán : 1.500K gồm bút, box, giấy tờ
✅ Mình bán đúng giá, đúng tình trạng, mua bán GDTT tại nhà riêng hoặc shipcod toàn quốc ( yêu cầu cọc nhẹ tiền ship )
✅✅ мong вán anн cнị тнιện cнí мυa нàng. Ngoài ra còn nнιềυ мáy ĸнác nên gнé qυa хeм lựa тнoảι мáι. Bấm vào chữ khung "xem trang" ở phía trên để tham khảo thêm Hoặc add Zalo ⓿❾❹❾.❺❻❽.❺❻❸ để тrao đổι cụ тнể нơn.
🏡 : Đường số 10, Bình Hưng Hòa, Bình Tân, HCM.
Cám ơn ACE đã xem tin và đội ngũ duyệt tin.', 0, 1500000, NULL, CAST(N'2022-07-15T09:58:05.6849000' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (107, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Phú Nhuận', N'Phường 11', N'173A Đường Nguyễn Văn Trỗi', N'Keycaps bàn phím ikbc cd87', 21, N'string                                            ', 32, N'Keycaps default của ikbc cd87
PBT Doubleshot
Mới mua bàn phím 1 ngày đổi keycaps nên thanh lí', 0, 200000, NULL, CAST(N'2022-07-15T10:01:57.1747606' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (108, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 11', N'Phường 08', N'', N'Combo main chip ram : x58 x79 x99 v1 v2 v3 v4.....', 22, N'string                                            ', 33, N'shop chuyên render/giả lập 8-30acc hỗ trợ tối uu tất cả các game giả lập )
HÀN NEW FULLBOX
*************************************************
Combo X58:
main x58 hunanzhi
x5670 or x5675
ram3 16gb 1600buss ( thêm 16gb 1600buss thêm 700k )
Giá : 2tr400
*******************************
Mainboard X79 1pci Socket 2011 (+300k lên x79 plex hd 3pci )
CPU E5 2650v2/2689 SK 2011 8C/16L
DDR3 16GB/1600
Giá : 2 TR 850 (Bảo hành 1T 1 dổi 1)
**********************************
Mainboard X79 1pci Socket 2011 HUNANZHI
CPU E5 2650v2/2689 SK 2011 8C/16L
DDR3 16GB/1600
Giá : 3 TR 400 (Bảo hành 12 T 1 dổi 1 cho tháng dầu)
*********************************
Mainboard X79 Socket 2011 (+300k lên x79 plex hd 3pci )
CPU E5 2670 V2 Socket 2011 10C/20L
DDR3 16GB/1600
Giá :3TR3 (Bảo hành 1T 1 đổi 1)
****************************
Mainboard X79 1pci Socket 2011 (+300k lên x79 plex hd 3pci )
CPU E5 2650v2/2689 SK 2011 8C/16L
DDR3 16GB/1600
Giá : 3 TR 6 (Bảo hành 12T 1 dổi 1 cho tháng đầu)
*******************************
Mainboard Dual X79 Socket 2011
X2 CPU E5 2670 V2 Socket 2011 20C/40L
DDR3 32GB/1600
Giá : 5TR8 (Bảo hành 1T 1 đổi 1)
*******************************
Mainboard Dual X79 Socket 2011
X2 CPU E5 2650 V2 Socket 2011 16C/32L
DDR3 32GB/1600
Giá : 5TR4 (Bảo hành 1T 1 đổi 1)
*******************************
Combo x99 :
main x99
2630v4 or 2640v4
ram4 16gb 2133 ( thêm 16gb 2133 + 1 tr )
Giá : 4tr300
*******************************
Dual x99
2680v4 x 2
ram4 32gb 2400 ( thêm 32gb bù 1tr8 )
9 tr 999
*******************************
26 đương số 6 F8 Q11', 0, 2850000, NULL, CAST(N'2022-07-15T10:07:26.4983915' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (109, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 11', N'Phường 12', N'174, Đường Công Chúa Ngọc Hân', N'RAM Laptop DDR4 SODIMM 8GB bus 3200 Samsung/Hynix', 23, N'string                                            ', 33, N'💯 RAM tháo máy trạm nhập khẩu trực tiếp từ Mỹ - Độ bền & chất lượng cực cao kèm bảo hành 4 năm.
RAM DDR4 SO-DIMM dùng cho:
☑️Laptop (Máy tính xách tay)
☑️Mini PC (Tuỳ thuộc kích thước mainboard)
▶️Dung lượng 8GB
⏫Bus 3200: ưu đãi giá cực shock chỉ 619k
Phù hợp cho nhu cầu nâng cấp máy tính để nâng cao hiệu suất & tốc độ máy.
Các thương hiệu: Samsung, Micron, SK Hynix.
👉Tin còn là hàng còn
👉Ship hàng - nhận trong ngày nội thành Sài Gòn (Grab 4h) - Ship COD toàn quốc
☑️Bảo hành: 1 đổi 1 trong 4 năm
👉Shop có hỗ trợ nâng cấp máy cho các bạn có nhu cầu
👉Ngoài ra shop còn rất nhiều những SSD và Ram Samsung & các hãng khác (WD, Micron, Toshiba, Intel, Kioxia, SK Hynix)
👉Click vào Cửa Hàng của shop để xem thêm những sảm phẩm khác nha', 0, 619000, NULL, CAST(N'2022-07-15T10:11:13.7143104' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (110, 3, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 12', N'Phường Trung Mỹ Tây', N'', N'rtx 3060ti asus full box còn bảo hành 32 tháng', 24, N'string                                            ', 33, N'Card như mới. Còn bảo hành hơn 32 tháng. Fix xăng xe. Còn hộp đầy đủ.', 0, 10500000, NULL, CAST(N'2022-07-15T10:13:23.6066675' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (111, 4, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Phú Nhuận', N'Phường 03', N'178/27 Phan Đăng Lưu', N'NV Nữ Biết Sử Dụng Máy Tính Lương 6-8TR Quận Pn', 1, N'string                                            ', 4, N'TUYỂN NHÂN VIÊN BÁN HÀNG NỮ BIẾT SỬ DỤNG MÁY TÍNH LƯƠNG 6-8TR QUẬN PHÚ NHUẬN

SẢN PHẨM CỦA CỬA HÀNG : quà tặng độc lạ , vật phẩm phong thủy, tiền VN và các nước sưu tầm . ( Sẽ được đào tạo sản phẩm )

MÔ TẢ CÔNG VIỆC:
- Check đơn hàng , tin nhắn trên các kênh Facebook , shopee, Lazada, Tiki, Sendo
- Đăng sản phẩm trên các kênh trên ( sẽ được đào tạo theo quy trình )
- Soạn hàng, đóng gói sản phẩm
- Kiểm hàng và sắp xếp hàng hóa

THỜI GIAN LÀM VIỆC : 8h30 - 18h30 , OFF 1 NGÀY/TUẦN

QUYỀN LỢI:
- Được học Marketing trên các kênh sàn thương mại điện tử, bán hàng online trên Facebook , Tiktok, Youtube
- Xét tăng lương đều mỗi 6 tháng - 12 tháng/lần theo năng lực
- Hưởng hoa hồng theo doanh số , khách hàng đã có sẵn .
- Thưởng tết tốt
- Cơ hội tăng thu nhập tốt và đều khi làm việc lâu dài

YÊU CẦU:

- Nữ từ 20-26 tuổi
- Trình độ học vấn 12/12
- BIẾT sử dụng thành thạo WORD
- Không cần kinh nghiệm chỉ cần THÁI ĐỘ chịu HỌC HỎI và HÒA ĐỒNG với môi trường làm việc.
- Làm việc ỔN ĐỊNH và LÂU DÀI
- THời gian thử việc : 3 NGÀY KHÔNG LƯƠNG

LƯƠNG :
- Cơ bản : 6 TRIỆU
- Thưởng : Chuyên cần 500k
- Hoa hồng theo doanh số , hệ thống khách hàng đã có sẵn
- Thưởng tết + tháng 13 + %doanh số
- Cơ hội tăng lương đều nếu THÁI ĐỘ và PHÁT TRIỂN NĂNG LỰC TỐT

ĐỊA ĐIỂM LÀM VIỆC:

- 178/27 Phan Đăng Lưu P.3 Q.Phú nhuận , Tp.HCM
- Liên hệ trực tiếp để hẹn phỏng vấn : gặp Chị Đào', NULL, NULL, 0, CAST(N'2022-07-15T10:18:15.5389735' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (112, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Huyện Củ Chi', N'Xã Tân Thông Hội', N'', N'Cú lửa 1k370 vip đá liền', 8, N'string                                            ', 34, N'Gà trại nhà đổ ra bổn bao ae $á cựa và cực lỳ dòng mỹ chuẩn ae đá tiền gà mình nuôi san ae về đá liền ok ae tin tưởng kết bạn zalo nc thu bon làm wen', 0, 1200000, NULL, CAST(N'2022-07-15T10:37:35.6140359' AS DateTime2), 1)
GO
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (113, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Tân Phú', N'', N'Thanh lý 2kg8', 9, N'string                                            ', 34, N'Thanh lý lại gà đều siu 2kg8 chân vàng 8 móng đen .Gà đá ăn 1cai đá tiền. Về đâm long thêm con cự con ko thanh lý lai cho ai cần nọc hoặc nuôi lai chơi.', 0, 700000, NULL, CAST(N'2022-07-15T10:40:15.3522834' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (114, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Huyện Củ Chi', N'Xã Tân Thông Hội', N'', N'Xanh 3k đá liền', 10, N'string                                            ', 34, N'Gà bon nhà đổ ra bổn bao ae đá cựa và cực lỳ gà mình nuôi rất pin ae về hẹn đá liền ok hiện cực xung nết cực dữ ae tin tưởng xuống nhà xem dc bắt kết bạn zalo nói c', 0, 1200000, NULL, CAST(N'2022-07-15T10:45:25.6911588' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (115, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Thảo Điền', N'', N'Phốc sóc thuần chủng', 11, N'string                                            ', 35, N'Lại là các con đây ạ . Chào tháng mới
Shop lên đàn pomeranian 2 tháng tuổi :
- Đã tiêm 1 mũi , xổ giun định kỳ
- Ăn cơm giỏi
- Thông minh , quấn chủ
- Đặc biết giống chó không rụng lông
+khi mua bán có thẻ bảo hành + sổ tiêm
+ Bảo hành thuần chủng trọn đời
+ bảo hành 2 bệnh pravo và care virut 3 ngày tính từ hôm mua
Lưu ý : khi khám yêu cầu có video test bệnh và hình ảnh . Kết luận của phòng khám thú y
🏠 22 đỗ năng tế - phường a lạc - quận bình tân
Zalo/sms/face time', 0, 4500000, NULL, CAST(N'2022-07-15T10:47:47.2237717' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (116, 4, N'0833017943', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận 12', N'Phường Tân Chánh Hiệp', NULL, N'Tuyển Thực Tập Sinh Kinh Doanh, Tư Vấn Phần Mềm', 2, N'string                                            ', 4, N'☘️ MÔ TẢ CÔNG VIỆC:
- Liên hệ khách hàng mảng website
- Soạn báo giá, lên hợp đồng cho khách hàng
- Chăm sóc khách hàng cũ
☘️ QUYỀN LỢI:
- Được hưởng các chế độ đầy đủ theo luật lao động.
- Mức lương và hoa hồng cao, thu nhập theo khả năng.
- Được đào tạo chuyên nghiệp , không yêu cầu kinh nghiệm
- Làm việc trong môi trường năng động, vui vẻ
☘️ YÊU CẦU CÔNG VIỆC:
- Tối thiểu bằng cấp 3
- Có nhiệt huyết về kinh doanh.
- Trung thực, nhiệt tình, chịu được áp lực trong công việc.
☘️ THỜI GIAN, ĐỊA ĐIỂM LÀM VIỆC
- Thời gian: T2-T6 (8h-17h00), sáng T7 (8h-12h)
- Địa điểm: CVPM Quang Trung, Tân Chánh Hiệp, Quận 12 (cổng QL1A).', NULL, NULL, 0, CAST(N'2022-07-15T11:36:51.1635612' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (117, 4, N'0833017943', N'', 0, 1, N'Tỉnh Bình Dương', N'Thành phố Thủ Dầu Một', N'Phường Chánh Nghĩa', NULL, N'Unilever Tuyển Nhân Viên Sale Thị Trường', 3, N'string                                            ', 4, N'💥UNILEVER TUYỂN DỤNG NHÂN VIÊN KINH DOANH THỊ TRƯỜNG 💥
✅KHU VỰC LÀM VIỆC:
- Bình Dương: Thủ Dầu Một, Dĩ An, Thuận An
✅THU NHẬP:
+ Thu nhập từ 10 - 15 triệu
+ Training học việc có lương và được hỗ trợ chi phí học việc (ăn uống, khách sạn, xăng xe di chuyển,...)
✅ QUYỀN LỢI:
+ Được training đào tạo bài bản 1 kèm 1
+ Không chở hàng, không thu công nợ, không cọc, không ghi đơn
+ KHÔNG BỎ TIỀN TÚI ĐỂ CHẠY SỐ SỈ
+ Thử việc nhận 100% lương, bảo đảm lương tháng đầu trên 10 triệu
+ Ký hợp đồng chính thức với công ty với chế độ bảo hiểm BHYT, BHXH, BH Tai nạn đầy đủ
+ Được nhận Lương tháng 13, du lịch và khám sức khỏe định kỳ
+ 12 ngày phép năm
✅YÊU CẦU:
- Tốt nghiệp cấp 3, còn giữ bằng
- Có xe máy', NULL, NULL, 0, CAST(N'2022-07-15T11:42:29.3606872' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (118, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Hiệp Bình Chánh', N'', N'Chó Rottweiler dòng đại', 12, N'string                                            ', 35, N'🤗Trại mình đang rã bầy rottweiler tay chân to ,mõm ngắn mặt bự, chó đẹp chuẩn để làm giống .
✔Các bé đã được sổ giun và tiêm ngừa 3 mũi vacxin 7in1 của Mỹ .
✔Trại mình bán hàng chất lượng cao, chó đẹp chuẩn, thuần chủng dòng đại 100% , đạt chuẩn con giống.
✔Ngoài dòng rottweiler bên mình còn dòng malinois, becgie và các dòng khác.
✔Mình nhận phối giống và bao tiêu sản phẩm
✔Để biết thêm thông tin về bé, các bạn gọi điện trực tiếp hoặc kết bạn zalo với mình để xem hình và clip của các bé.
🐕🐕 Bên mình tư vấn chăm sóc sức khỏe bé 24/24. Cam kết chó khỏe mạnh ngừa 3 mũi vacxin mới xuất bầy và giao toàn quốc.
✔Vị thế của trại xưa nay luôn được tin tưởng từ khách hàng là uy tín chất lượng cao
✔Hình thật chó thật chất lượng thật
✔Trại có nhiều bé đẹp, các bạn nhanh tay đón bé về cưng nựng nha.', 0, 7500000, NULL, CAST(N'2022-07-15T11:47:00.3485663' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (119, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Quận Gò Vấp', N'Phường 11', N'', N'ĐÀN CHÓ CORGI CON THUẦN CHỦNG NHÀ SINH SẢN', 13, N'string                                            ', 35, N'Cần rã bầy Corgi chó nhà đẻ. Đã được chích ngừa 2 mũi và sổ giun đầy đủ. Chó khỏe mạnh quấn chủ, chân siêu ngắn, lắc mông.
Giá từ 6 triệu/bé…
Khách muốn ship tận nhà, gửi hình zalo mình ship đến!', 0, 6000000, NULL, CAST(N'2022-07-15T11:49:51.4979916' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (120, 5, N'0343679935', N'', 0, 1, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Long Thạnh Mỹ', N'', N'Yến Phụng Hà Lan bông cúc', 14, N'string                                            ', 36, N'Kẹt chuồng, cần nhượng lại cặp Yến Phụng Hà Lan bông cúc, cho ae về chăm, chim khỏe mạnh, ktl.', 0, 550000, NULL, CAST(N'2022-07-15T11:52:30.7576742' AS DateTime2), 1)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (121, 5, N'0343679935', N'', 1, 0, N'Thành phố Hồ Chí Minh', N'Quận 1', N'Phường Tân Định', N'', N'Yến Phụng Hà Lan bông cúc', 16, N'string                                            ', 36, N'Kẹt chuồng, cần nhượng lại cặp Yến Phụng Hà Lan bông cúc, cho ae về chăm, chim khỏe mạnh, ktl.', 0, 1000000, NULL, CAST(N'2022-07-15T12:09:21.5916711' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (122, 5, N'0343679935', N'', 1, 0, N'Thành phố Hồ Chí Minh', N'Quận 1', N'Phường Tân Định', N'', N'Yến Phụng Hà Lan bông cúc', 16, N'string                                            ', 36, N'Kẹt chuồng, cần nhượng lại cặp Yến Phụng Hà Lan bông cúc, cho ae về chăm, chim khỏe mạnh, ktl.', 0, 500000, NULL, CAST(N'2022-07-15T12:12:44.5004653' AS DateTime2), 0)
INSERT [dbo].[BaiDang] ([id_BaiDang], [id_DanhMucCha], [Sdt_NguoiBan], [Sdt_NguoiMua], [AnTin], [TrangThai], [ThanhPho], [QuanHuyen], [PhuongXa], [DiaChiCuThe], [TieuDe], [id_BaiDangChiTiet], [TablesDetail], [id_DanhMucCon], [Mota], [MienPhi], [Gia], [CaNhan], [CreatedDate], [isReviewed]) VALUES (123, 1, N'0854863505', N'', 1, 0, N'Thành phố Hồ Chí Minh', N'Thành phố Thủ Đức', N'Phường Long Thạnh Mỹ', N'Đường Nguyễn Xiển', N'BÁN LỖ CĂN HỘ 3PN VIN ORIGAMI VIEW HỒ BƠI MÁT MẺ', 37, N'string                                            ', 13, N'Chủ nhà gửi bán căn hộ 3PN diện tích 82m2 bán bằng giá hợp đồng hoặc bán lỗ nếu khách thiện chí thương lượng:
- Diện tích 82m2.
- Căn hộ gồm 3 phòng ngủ + 2 toilet.
- Ban công hướng Đông Nam mát mẻ view hồ bơi trung tâm, hướng sông lộng gió.
- Căn hộ mới vừa được chủ đầu tư bàn giao.
- Chủ nhà cần bán gấp để mua nhà ở bán bằng giá hợp đồng hoặc bán lỗ nhẹ bớt lộc cho khách thiện chí.
- Giá HĐ 4.365 tỷ còn 195 triệu tiền sổ.

Anh chị quan tâm liên hệ Mr. Hiếu - để biết thêm thông tin chi tiết.
Ngoài ra em còn nắm thông tin nhiều căn hộ khác ở Vinhome giá tốt với đa dạng diện tích 1PN - 2PN - 3PN.', NULL, 4175000000, 1, CAST(N'2022-07-16T12:17:40.8740804' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[BaiDang] OFF
GO
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (1, N'An Gia', 120, N'A41       ', N'A4        ', N'14        ', 0, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (2, N'FLC', 134, NULL, NULL, NULL, NULL, NULL, NULL, N'Nhà mặt phố, mặt tiền', 3, 1, 2, 1, 1, 12, 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (3, N'Đất Xanh', 140, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (4, N'string', 0, N'string    ', N'string    ', N'string    ', 1, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (5, N'string', 0, N'string    ', N'string    ', N'string    ', 1, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (6, N'string', 0, N'string    ', N'string    ', N'string    ', 1, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (7, N'string', 0, N'string    ', N'string    ', N'string    ', 1, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (8, N'string', 0, N'string    ', N'string    ', N'string    ', 1, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (9, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, N'string', 0, 0, 0, 1, 1, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (10, N'string', 0, N'string    ', N'string    ', N'string    ', 1, N'string', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'string', N'string', N'string', N'string', 0, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (11, N'', 46, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0, 4.9, 10.5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (12, N'', 46, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0, 4.9, 10.5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (13, N'nhà ở', 46, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0, 4.9, 10.5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (14, N'Đất thành phố', 86, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Thổ cư', N'Đông', 1, 1, 1, 6.8, 13, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (15, N'Đất thành phố', 86, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Thổ cư', N'Đông', 1, 1, 1, 6.8, 13, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (16, N'Đất thành phố', 86, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Thổ cư', N'Đông', 1, 1, 1, 6.8, 13, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (17, N'Đất thành phố', 86, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đất thổ cư', N'Đông', 1, 1, 1, 6.8, 13, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (18, N'', 100, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 0, 10, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, 10000, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (19, N'', 100, N'          ', N'          ', N'          ', 0, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Đông', N'Đã có sổ', N'Đông', N'Nội thất cao cấp', 1000000, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (20, N'', 100, N'          ', N'          ', N'          ', 0, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Đông', N'Đã có sổ', N'Đông', N'Nội thất cao cấp', 1000000, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (21, N'', 100, N'          ', N'          ', N'          ', 0, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Đông', N'Đã có sổ', N'Đông', N'Nội thất cao cấp', 1000000, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (22, N'', 100, N'          ', N'          ', N'          ', 0, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Tây', N'Đã có sổ', N'Tây', N'Nội thất cao cấp', 1000000, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (23, N'', 50, N'          ', N'          ', N'          ', 0, N'Duplex', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Đông', N'Đã có sổ', N'Đông', N'Nội thất cao cấp', 2000000, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (24, N'Chung cư An Khánh', 82, N'          ', N'          ', N'          ', 0, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Đông', N'Đã có sổ', N'Đông Nam', N'Nội thất đầy đủ', 1E+08, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (25, N'CC Dream Home Riverside', 62, N'          ', N'          ', N'          ', 1, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Tây', N'Giấy tờ khác', N'Đông', N'Hoàn thiện cơ bản', 1E+08, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (26, N'CC Dream Home Riverside', 62, N'          ', N'          ', N'          ', 1, N'Chung cư', 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Đông', N'Giấy tờ khác', N'Đông', N'Hoàn thiện cơ bản', 1E+09, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (27, N'Emerald- Celadon city', 63, N'          ', N'          ', N'          ', 0, N'Chung cư', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'Tây', N'Chưa có sổ', N'Nam', N'Nội thất đầy đủ', 2E+08, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (28, N'', 72, NULL, NULL, NULL, NULL, NULL, NULL, N'Nhà mặt phố, mặt tiền', 6, 7, NULL, 1, 0, 4, 18, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, 1E+08, NULL, N'Đã có sổ', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (29, N'', 60, NULL, NULL, NULL, NULL, NULL, NULL, N'Nhà ngõ, hẻm', 4, 4, NULL, 1, 0, 4, 15, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, 2E+08, NULL, N'Đã có sổ', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (30, N'', 310, NULL, NULL, NULL, NULL, NULL, NULL, N'Nhà mặt phố, mặt tiền', 10, 6, NULL, 1, 1, 12, 25, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, 2E+09, NULL, N'Đã có sổ', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (31, N'', 210, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đất thổ cư', N'', 1, 1, 1, 10, 21, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã có sổ', NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (32, N'', 1000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đất thổ cư', N'', 0, 0, 0, 80, 125, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã có sổ', NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (33, N'', 300, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đất thổ cư', N'', 0, 0, 0, 10, 30, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã có sổ', NULL, NULL)
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (34, N'', 120, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'          ', N'Mặt bằng kinh doanh', NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', N'')
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (35, N'', 1700, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'          ', N'Mặt bằng kinh doanh', NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã có sổ', N'Tây Nam')
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (36, N'', 100, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'          ', N'Mặt bằng kinh doanh', NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã có sổ', N'')
INSERT [dbo].[BaiDang_BatDongSan] ([id_BaiDang], [TenDuAn], [DienTich], [CC_MaCan], [CC_Block], [CC_TangSo], [CC_ChuaBanGiao], [CC_LoaiHinh], [CC_SoPhongNgu], [NhaO_LoaiHinh], [NhaO_SoPhongNgu], [NhaO_SoPhongVeSinh], [NhaO_TongSoTang], [NhaO_HemXeHoi], [NhaO_NoHau], [NhaO_ChieuNgang], [NhaO_ChieuDai], [Dat_LoaiHinhDat], [Dat_HuongDat], [Dat_MatTien], [Dat_HemXeHoi], [Dat_NoHau], [Dat_ChieuNgang], [Dat_ChieuDai], [VanPhong_MaCan], [VanPhong_Block], [VanPhong_TangSo], [VanPhong_LoaiHinhVanPhong], [PhongTro_TinhTrangNoiThat], [PhongTro_SoTienCoc], [CanBan], [CcBanCong], [CcGiayToPhapLy], [CcHuongCuaChinh], [CcTinhTrangNoiThat], [SoTienCoc], [soToilet], [NhaO_GiayToPhapLy], [Dat_GiayToPhapLy], [VanPhong_GiayToPhapLy], [VanPhong_HuongCuaChinh]) VALUES (37, N'VIN ORIGAMI ', 82, N'          ', N'          ', N'          ', 0, N'Chung cư', 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'', N'Đã có sổ', N'', N'Bàn giao thô', 1E+08, 2, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[BaiDang_DoDienTu] ON 

INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (1, 1, N'Samsung', N'Vàng', N'128GB', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', N'Galaxy Note 20 Ultra', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (2, 1, N'Apple', N'Vàng', N'128GB', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', N'Iphone 12 pro max', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (3, 1, N'Samsung', N'B?c', N'256GB', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', N'Galaxy Z Fold3', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (4, 1, NULL, NULL, NULL, 1, 0, N'32GB', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, N'iPad Mini 4', N'Apple', N'8 - 8.9 inch', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (5, 1, NULL, NULL, NULL, 1, 0, N'8GB', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Mới', NULL, NULL, N'Lenovo Tab3', N'Khác', N'8 - 8.9 inch', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (6, 1, NULL, NULL, NULL, 1, 0, N'128GB', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, N'Ipad pro M1', N'Apple', N'> 10 inch', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (7, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Intel Core i5', N'16GB', N'256GB', 0, N'onBoard   ', N'15 - 16.9 inch                ', N'Dell                ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, N'Inspiron', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (8, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Intel Core i5', N'4GB', N'256GB', 0, N'onBoard   ', N'13 - 14.9 inch                ', N'Acer                ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, N'Aspire', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (9, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Intel Core i7', N'16GB', N'512GB', 0, N'onBoard   ', N'13 - 14.9 inch                ', N'Apple               ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, N'Macbook Pro Touch Bar', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (10, 0, NULL, NULL, NULL, NULL, NULL, NULL, N'Khác', N'8GB', N'>1TB', 0, N'NVIDIA    ', N'>= 21 inch                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (11, 1, NULL, NULL, NULL, NULL, NULL, NULL, N'Intel Core i5', N'8GB', N'256GB', 0, N'onBoard   ', N'>= 21 inch                    ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (12, 0, NULL, NULL, NULL, NULL, NULL, NULL, N'Intel Core i7', N'8GB', N'128GB', 1, N'Khác      ', N'19 - 20.9 inch                ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (13, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Máy quay', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, N'panasonic AG-UX90', NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (14, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Máy ảnh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, N'Canon 80D', NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (15, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Máy quay', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Mới', NULL, NULL, NULL, NULL, NULL, NULL, N'IP Wifi TP-Link Tapo C200', NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (16, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Khác', NULL, N'Apple', NULL, NULL, NULL, NULL, NULL, NULL, N'Mới', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (17, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đồng hồ thông minh', NULL, N'Apple', NULL, NULL, NULL, NULL, NULL, NULL, N'Mới', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (18, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đồng hồ thông minh', NULL, N'Apple', NULL, NULL, NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (19, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ kiện máy tính', N'Màn hình', NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (20, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ kiện điện thoại', N'Apple Pencil', NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (21, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Khác', N'Keycaps', NULL, NULL, NULL, NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (22, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ kiện máy tính', N'main chip ram', NULL, N'Mới', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (23, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ kiện máy tính', N'Ram', NULL, N'Mới', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_DoDienTu] ([id_BaiDang], [BaoHanh], [DienThoai_Hang], [DienThoai_MauSac], [DienThoai_DungLuong], [MayTinhBang_QuocTe], [MayTinhBang_4g], [MayTinhBang_DungLuong], [MayTinhDeBan_BoViXuly], [MayTinhDeBan_RAM], [MayTinhDeBan_OCung], [MayTinhDeBan_HDD], [MayTinhDeBan_CardManHinh], [MayTinhDeBan_KichCoManHinh], [Laptop_BoViXuly], [Laptop_RAM], [Laptop_OCung], [Laptop_HDD], [Laptop_CardManHinh], [Laptop_KichCoManHinh], [Laptop_Hang], [MayAnh_ThietBi], [MayAnh_TinhTrang], [Tivi_ThietBi], [Tivi_TinhTrang], [ThietBiDeoThongMinh_ThietBi], [ThietBiDeoThongMinh_TinhTrang], [ThietBiDeoThongMinh_Hang], [PhuKien_LoaiPhuKien], [PhuKien_ThietBi], [PhuKien_TinhTrang], [LinhKien_LoaiPhuKien], [LinhKien_ThietBi], [LinhKien_TinhTrang], [TinhTrang], [DienThoaiDongMay], [LaptopDongMay], [MayTinhBangDongMay], [MayTinhBangHang], [MayTinhBangKichCoManHinh], [MayTinhDeBanMienPhi], [ThietBiDongMay], [TiviHang]) VALUES (24, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ kiện máy tính', N'Card Màn hình', NULL, N'Đã sử dụng (chưa sửa chữa)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BaiDang_DoDienTu] OFF
GO
SET IDENTITY_INSERT [dbo].[BaiDang_ThuCung] ON 

INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (1, N'Chó Nhật', N'Chó nhỏ(dưới 1 năm tuổi)', NULL, N'Nhỏ')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (2, N'Chó Nhật', N'Chó nhỏ(dưới 1 năm tuổi)', NULL, N'Nhỏ')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (3, N'Chó Bắc kinh', N'Chó con(dưới 3 tháng tuổi)', NULL, N'Nhỏ')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (7, N'Cho Bull', N'Cho con', NULL, N'nho')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (8, N'Gà tre', N'Gà con(từ 3 tháng tuổi)', NULL, NULL)
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (9, N'Khác', N'Gà con(từ 3 tháng tuổi)', NULL, NULL)
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (10, N'Gà Nòi(Gà chọi)', N'Gà con(từ 3 tháng tuổi)', NULL, NULL)
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (11, N'Khác', N'Chó con(dưới 3 tháng tuổi)', NULL, N'Nhỏ')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (12, N'Chó Rottweiler', N'Chó con(dưới 3 tháng tuổi)', NULL, N'Lớn')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (13, N'Chó Corgi', N'Chó con(dưới 3 tháng tuổi)', NULL, N'Trung bình')
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (14, N'Chim Vẹt', N'Chim lớn(từ 3 tháng tuổi)', N'khác', NULL)
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (15, N'Chim bồ câu', N'Chim nhỏ(dưới 3 tháng tuổi)', N'Chim mái', NULL)
INSERT [dbo].[BaiDang_ThuCung] ([id_BaiDang], [GiongThuCung], [DoTuoi], [Chim_GioiTinh], [Cho_KichCo]) VALUES (16, N'Chim chào mào', N'Chim lớn(từ 3 tháng tuổi)', N'Chim trống', NULL)
SET IDENTITY_INSERT [dbo].[BaiDang_ThuCung] OFF
GO
SET IDENTITY_INSERT [dbo].[BaiDang_ViecLam] ON 

INSERT [dbo].[BaiDang_ViecLam] ([id_BaiDang], [TenHoKinhDoanh], [SoLuongTuyenDung], [NganhNghe], [LoaiCongViec], [HinhThucTraLuong], [LuongToiThieu], [LuongToiDa], [Nam], [HocVanToiThieu], [KinhNghiem], [ChungChi], [QuyenLoi]) VALUES (1, N'tmt-collection', 1, N'Bán hàng (Online/cửa hàng)', N'Toàn thời gian', N'Theo tháng', 6000000, 8000000, 0, N'Không yêu cầu', N'Không yêu cầu', N'', N'')
INSERT [dbo].[BaiDang_ViecLam] ([id_BaiDang], [TenHoKinhDoanh], [SoLuongTuyenDung], [NganhNghe], [LoaiCongViec], [HinhThucTraLuong], [LuongToiThieu], [LuongToiDa], [Nam], [HocVanToiThieu], [KinhNghiem], [ChungChi], [QuyenLoi]) VALUES (2, N'Công Ty TNHH Thương Mại Dịch Vụ NiNa', 15, N'Nhân viên kinh doanh', N'Toàn thời gian', N'Theo tháng', 5000000, 20000000, 0, N'Cấp 3', N'Không yêu cầu', N'Tối thiểu bằng tốt nghiệp trung học', N'Thưởng , du dịch , thăng tiến')
INSERT [dbo].[BaiDang_ViecLam] ([id_BaiDang], [TenHoKinhDoanh], [SoLuongTuyenDung], [NganhNghe], [LoaiCongViec], [HinhThucTraLuong], [LuongToiThieu], [LuongToiDa], [Nam], [HocVanToiThieu], [KinhNghiem], [ChungChi], [QuyenLoi]) VALUES (3, N'Công ty TNHH Acacy', 30, N'Nhân viên kinh doanh', N'Toàn thời gian', N'Theo tháng', 12000000, 25000000, 0, N'Cấp 3', N'Không yêu cầu', N'Nhanh nhẹn, siêng năng', N'BHYT, BHXH đầy đủ')
SET IDENTITY_INSERT [dbo].[BaiDang_ViecLam] OFF
GO
SET IDENTITY_INSERT [dbo].[BaiDang_XeCo] ON 

INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (1, N'Toyota', N'2022      ', 10000, 1184999999, 1, N'Thái Lan', N'', N'', N'Số tự động', N'Xăng', N'Sedan', 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Camry', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (2, N'Toyota', N'2022      ', 0, 515000000, 1, N'Thái Lan', N'Đen', N'', N'Số tự động', N'Xăng', N'Sedan', 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'5', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (3, N'Huyndai', N'2022      ', 23000, 1505000000, 1, N'Việt Nam', N'Trắng', N'', N'Số tự động', N'Dầu', N'SUV / Cross over', 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Santafe', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (4, N'Honda', N'2022      ', 800, 21800000, 1, N'', N'Đen', N'', NULL, NULL, NULL, NULL, N'100cc - 175cc', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Wave', N'Xe số', NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (5, N'Honda', N'2022      ', 6000, 96000000, 1, N'', N'Trắng', N'59S S3 31111', NULL, NULL, NULL, NULL, N'100cc - 175cc', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Vario', N'Tay ga', NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (6, N'Honda', N'2022      ', 4000, 53000000, 1, N'', N'Xanh', N'', NULL, NULL, NULL, NULL, N'100cc - 175cc', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Air Blade', N'Tay ga', NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (7, N'Hino', N'2022      ', 0, 860000000, 1, N'Nhật Bản', N'Trắng', N'', NULL, NULL, NULL, NULL, NULL, N'6 tấn', N'Dầu', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (8, N'Huyndai', N'2018      ', 5000, 899999998, 1, N'Việt Nam', N'Xanh dương', N'', NULL, NULL, NULL, NULL, NULL, N'7 tấn', N'Xăng', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (9, N'Asama', N'          ', NULL, 5000000, NULL, N'Đài Loan', N'Đỏ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Xe đạp điện', N'501 - 1000W', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'>24 tháng')
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (10, N'Khác', N'          ', NULL, 15500000, NULL, N'Việt Nam', N'Trắng', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Xe máy điện', N'>100W', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Hết bảo hành')
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (11, N'Khác', N'          ', NULL, 3950000, NULL, N'Đài Loan', N'Cam', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N' L (55.5 cm)', N'Nhôm', 1, NULL, N'Hết bảo hành', NULL, NULL, NULL, NULL, NULL, NULL, N'Xe đạp thể thao', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (12, N'Khác', N'          ', NULL, 7800000, NULL, N'', N'Xanh dương', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', N'Nhôm', 1, NULL, N'', NULL, NULL, NULL, NULL, NULL, NULL, N'Xe đạp khác', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (13, N'Khác', N'          ', NULL, 75000, NULL, N'Việt Nam', N'Trắng', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'M ( 50 cm)', N'Inox', 1, NULL, N'', NULL, NULL, NULL, NULL, NULL, NULL, N'Xe đạp phổ thông', NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (14, N'', N'2007      ', 20000, 100000000, NULL, N'', N'Xanh dương', N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Dầu', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (19, NULL, NULL, NULL, 700000, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ tùng xe máy', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (20, NULL, NULL, NULL, 3500000, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ tùng xe máy', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BaiDang_XeCo] ([id_BaiDang], [HangXe], [Nam], [SoKmDaDi], [Gia], [DaSuDung], [Xuatxu], [MauSac], [BienSoXe], [Oto_HopSo], [Oto_NhieuLieu], [Oto_KieuDang], [Oto_Socho], [XeMay_Dungtich], [XeTai_TrongTai], [XeTai_NhieuLieu], [XeTai_XuatXu], [XeDien_LoaiXe], [XeDien_DongCo], [XeDien_DaSuDung], [XeDien_MienPhi], [XeDap_KichThuocKhung], [XeDap_ChatLuongKhung], [XeDap_DaSuDung], [XeDap_MienPhi], [XeDap_BaoHang], [PhuongTienKhac_NhienLieu], [PhuTungXe_LoaiPhuTung], [OtoDongXe], [PhuTungXeMienPhi], [PhuongTienKhacLoaiXeChuyenDung], [PhuongTienKhacSoChoXeKhachXeBuyt], [XeDapLoaiXe], [XeMayDongXe], [XeMayLoaiXe], [XeDien_BaoHanh]) VALUES (21, NULL, NULL, NULL, 16000000, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Phụ tùng ô tô', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BaiDang_XeCo] OFF
GO
SET IDENTITY_INSERT [dbo].[Conversations] ON 

INSERT [dbo].[Conversations] ([ConversationId], [SdtNguoiBan], [SdtNguoiMua]) VALUES (1, N'456', N'123')
INSERT [dbo].[Conversations] ([ConversationId], [SdtNguoiBan], [SdtNguoiMua]) VALUES (9, N'0786266752', N'0343679935')
INSERT [dbo].[Conversations] ([ConversationId], [SdtNguoiBan], [SdtNguoiMua]) VALUES (10, N'0854863505', N'0343679935')
SET IDENTITY_INSERT [dbo].[Conversations] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (1, N'Bất động sản', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (2, N'Xe cộ', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (3, N'Đồ điện tử', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (4, N'Việc làm', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (5, N'Thú cưng', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (6, N'Đồ ăn, thực phẩm và các loại khác', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (7, N'Tủ lạnh, máy lạnh, máy giặt', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (8, N'Đồ gia dụng, nội thất, cây cảnh', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (9, N'Mẹ và bé', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (10, N'Thời trang, Đồ dùng cá nhân', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (11, N'Giải trí, Thể thao, Sở thích', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (12, N'Đồ dùng văn phòng, công nông nghiệp', NULL)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (13, N'Căn hộ/Chung cư', 1)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (14, N'Nhà ở', 1)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (15, N'Đất', 1)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (16, N'Văn phòng, Mặt bằng kinh doanh', 1)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (17, N'Phòng trọ', 1)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (18, N'Ô tô', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (19, N'Xe máy', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (20, N'Xe tải, xe ben', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (21, N'Xe điện', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (22, N'Xe đạp', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (23, N'Phương tiện khác', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (24, N'Phụ tùng xe', 2)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (25, N'Điện thoại', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (26, N'Máy tính bảng', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (27, N'Laptop', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (28, N'Máy tính để bàn', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (29, N'Máy ảnh, máy quay', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (30, N'Tivi, Âm thanh', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (31, N'Thiết bị đeo thông minh', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (32, N'Phụ kiện (Màn hình, Chuột.... )', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (33, N'Linh kiện (RAM, Card, ... )', 3)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (34, N'Gà', 5)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (35, N'Chó', 5)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (36, N'Chim', 5)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (37, N'Mèo', 5)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (38, N'Thú cưng khác ', 5)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (39, N'Phụ kiện, Thức ăn, Dịch vụ', 5)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (40, N'Tủ lạnh', 7)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (41, N'Máy lạnh, điều hòa', 7)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (42, N'Máy giặt', 7)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (43, N'Bàn ghế', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (44, N'Tủ, kệ gia đình', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (45, N'Giường, chăn ga gối nệm', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (46, N'Bếp, lò, đồ điện nhà bếp', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (47, N'Dụng cụ nhà bếp', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (48, N'Quạt', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (49, N'Đèn', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (50, N'Cây cảnh, đồ trang trí', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (51, N'Thiết bị vệ sinh, nhà tắm', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (52, N'Nội thất, đồ gia dụng khác', 8)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (53, N'Quần áo', 10)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (54, N'Đồng hồ', 10)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (55, N'Giày dép', 10)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (56, N'Túi xách', 10)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (57, N'Nước hoa', 10)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (58, N'Phụ kiện thời trang khác', 10)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (59, N'Nhạc cụ', 11)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (60, N'Sách', 11)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (61, N'Đồ thể thao, dã ngoại', 11)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (62, N'Đồ sưu tâm, đồ cổ', 11)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (63, N'Thiết bị chơi game', 11)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (64, N'Sở thích khác', 11)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (65, N'Đồ dùng văn phòng', 12)
INSERT [dbo].[DanhMuc] ([id_DanhMuc], [ten_DanhMuc], [id_DanhMucCha]) VALUES (66, N'Đồ chuyên dụng, Giống nuôi trồng', 12)
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[HinhAnh_BaiDang] ON 

INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (4, N'1L6TabvDRDLp2XYvfq_UM0zU7XRdpT4-6', 5, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (5, N'1L6TabvDRDLp2XYvfq_UM0zU7XRdpT4-6', 5, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (6, N'1L6TabvDRDLp2XYvfq_UM0zU7XRdpT4-6', 6, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (7, N'1cw8Z--owi4bMh9agyyxTbECZysC2LLBp', 6, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (8, N'1Gx5eFd1Z3O9ZJ3x_jlBlrzeIqsPRs4px', 2, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (9, N'12GtMAXPFIhQ6Kx0aw6Pz6e6QcHC_SYn8', 5, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (10, N'1J1PArr71HazaHPorx61mQiW0cixr3tK-', 6, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (11, N'1KNt2lglIHJwiNcBQfdcu5AMSt20nwy8D', 7, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (12, N'1RbHhx7eO2X8IUxULzwGBVbf2-ASiUYKX', 8, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (13, N'1Mos54hKrSTC0qRQRy2-XL6nj7zTXjRVf', 9, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (14, N'1a7J2vT0HODUupFZ-m1b7xb9fPrVLGIVo', 10, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (15, N'1p-uDL8XQjFIA7PeX450G_C0wiqANtNbr', 2, 1)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (16, N'12gJzYbW4DtmViOaSXJA_TwyWaIKE5Gdl', 12, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (17, N'1riC65R2RpgkxYeoPejuYhy7U0cYd7SNj', 13, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (18, N'15xbCJapCu15z-bLJ6x34Z905cBrV_DxR', 14, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (19, N'1P3uxWEbohjGPdKTrqI47JbUPEMzA48xt', 15, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (20, N'1McIIPfQIwET5ojWZMefEJ4YLFX2GR5b9', 16, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (21, N'1-xG8y3XnGfJ0nRNp01JMv1_PsOuty6y3', 17, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (22, N'1jyPPg3UX6H1DvJLOjSLDpHC5mgrfKdQ2', 18, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (23, N'17d6vOcQoYnT7fLs_WzVBIaw3uPHTxQHC', 19, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (24, N'1kuquK2Ve1Ky7ebWnudE2qRAZ9pxzjTX4', 20, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (25, N'1muzSn7Zdd2UuiW9dMJlzAuDtSRftI78z', 21, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (26, N'1Q-2TI32lOaIY8bkG6Nln81g5dhwttGh8', 22, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (27, N'1xMTj8P7uKRKpp_IYI42KL5_QHaP291GY', 23, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (28, N'1-xG8y3XnGfJ0nRNp01JMv1_PsOuty6y3', 24, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (29, N'1P3uxWEbohjGPdKTrqI47JbUPEMzA48xt', 25, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (30, N'1cw8Z--owi4bMh9agyyxTbECZysC2LLBp', 26, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (31, N'1a7J2vT0HODUupFZ-m1b7xb9fPrVLGIVo', 27, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (32, N'1muzSn7Zdd2UuiW9dMJlzAuDtSRftI78z', 28, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (34, N'12gJzYbW4DtmViOaSXJA_TwyWaIKE5Gdl29', 29, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (38, N'15xbCJapCu15z-bLJ6x34Z905cBrV_DxR', 30, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (39, N'1P3uxWEbohjGPdKTrqI47JbUPEMzA48xt', 31, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1028, N'15xbCJapCu15z-bLJ6x34Z905cBrV_DxR', 7, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1029, N'1a7J2vT0HODUupFZ-m1b7xb9fPrVLGIVo', 8, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1030, N'1-xG8y3XnGfJ0nRNp01JMv1_PsOuty6y3', 9, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1031, N'1muzSn7Zdd2UuiW9dMJlzAuDtSRftI78z', 10, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1035, N'15xbCJapCu15z-bLJ6x34Z905cBrV_DxR', 35, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1036, N'1-xG8y3XnGfJ0nRNp01JMv1_PsOuty6y3', 36, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1037, N'15xbCJapCu15z-bLJ6x34Z905cBrV_DxR', 37, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1038, N'1McIIPfQIwET5ojWZMefEJ4YLFX2GR5b9', 38, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1039, N'12gJzYbW4DtmViOaSXJA_TwyWaIKE5Gdl', 11, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1040, N'1SSdIKIiXIlSRZK-RsSzkZJ6icdQB6AL6', 11, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1041, N'1YEEC1vMO98IaH7BENvpdmqxEWTjzNmMG', 45, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1042, N'1dx3Tel885dS-_NxR6WpwJrr1fnsdaro-', 12, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1043, N'1dAS0DeoyohHC1ksn2So5cFro-lM0JI4C', 12, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1044, N'1GKN2k8fKuAub4_lsjNvJlEvrtTmX8iDI', 13, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1045, N'1rfBHsnj58V3X3vXVmsMJIkvYjPK7ZTl4', 13, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1046, N'1rxFscgM71O1WipUdEerv4Y2NL4hJ4dnv', 41, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1047, N'17Hyo3EfdvesQhNB1oQKuaTe3MHYnJJI3', 41, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1048, N'1auOCAlHPltnzKX1i0kG656L4DeMf5u4C', 42, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1049, N'1ffHfyzGYActpZK-63ecXeRI_P5RZjlbK', 42, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1050, N'1em2dh7EFUS5NcWMJ-9iyH7GE49uLnHFK', 43, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1052, N'1k12BKFSp1Rpliu1fwYtsmkKAW5wHKk6z', 45, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1053, N'1NK2sn1QToHLwiKFCPOY02-Ed2KNbjKei', 45, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1054, N'1i0Yuh9IhCXQ6kagz6LEb6rBPW0_jDmCW', 45, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1055, N'1_hbsRAqh1pC5ypnhfb7K2rAKklWTjyqr', 49, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1056, N'1NEEFgYjR5KUHA4GD9lhIFBi_MYFL2SH5', 50, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1057, N'16vSH-u7Vnsgel5TBXg0eWbjNFT4dULW0', 51, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1058, N'1k5_37ZxdLw0icWPPVwA-UdUBlkuTQJ86', 52, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1059, N'1qYkoPEKQ7HaCGY6EcfGaEB8BpI3mSV5I', 53, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1060, N'1zecVOd8vufjyVX-KbV6MxXqubbI8eY4Z', 54, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1061, N'14-arRXLu8q2IU5d0mSh2YMdhUr4oqsH6', 55, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1062, N'1208gHDGfMWFHIwTwE9Z9dWZ4y5sYVrJb', 55, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1063, N'1OlGPl0A_y4tgOjgE9dICzxKbyA-RaOeO', 56, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1064, N'1gyy9ST-LPOTAzug2BNO1sOGGeptfxylD', 56, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1065, N'1_hbsRAqh1pC5ypnhfb7K2rAKklWTjyqr', 49, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1066, N'1nTTXkISDEfbRjrOCNfjbODBe_3NbRu7a', 49, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1067, N'1PfY9SoGgv8H8Fix3MpeZcbm2aedBT8Bz', 44, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1068, N'18FoLYMN_EOgT69vmJQeh2Q0UH7U_j2eO', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1069, N'1xfndMa8OzudP6iZMjmoVnksG6eYbFK7K', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1070, N'1i4_ZtzVx7l-lBvuX1RwE-aoy-00CpU-0', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1071, N'1VqIs2Uckdp1ktv6Jqozes0fouGGwNxVi', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1072, N'1CtKKQY8V08NrS3CAA4H1Rv0Qb4XCtnVk', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1073, N'10HuUUQGFEOSArBDGJfxCojS5JTIjMxRr', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1074, N'19BxsTpbDPqUBF4MlVg18qi64-lgR3a9H', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1075, N'12xhW-HJEbG9McUuJ79FsnAe5nRW3zkPb', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1076, N'1mzFVDB1f3EC6HdW7MMfpjKfnFNQAwxg_', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1077, N'1Yh-rpHlGAM4zUXyZxkinPcfcnJwEMs3k', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1078, N'18CCthVSRjWlLJ-07HY--Cub8kpsEG7bm', 57, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1079, N'1QtSbhieErCmPLC9UeeqTZQj_b5qMyJSX', 59, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1080, N'1ej5TmnEC0nmwmca8ge6OGxpOWN2GMOcw', 59, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1081, N'18ISKXDcT-ePuu7ZB2u3MpGWIBjK9ZYIM', 59, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1082, N'1W4FF4fpw1czmWVs9tuEr7xyAdeW45ZcP', 59, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1083, N'1fZ34cqUm-EiJlAejwIfnAoOdRgCvpIex', 59, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1084, N'1dDXUAZ_v4Ieu4bfOUGDqBN3fhDwxTNct', 59, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1085, N'1AzCSmsOQikf7T17sglYgiCvC6o2UzSrt', 60, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1086, N'1sa6dXC7zvVkjz1ig11UW5EmITX5efhNU', 60, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1087, N'1K1KlaScyMkewXuUNnrdUHUsHEcz9OoZN', 60, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1088, N'1c_brQHbUItFBwqO2Wybc45Rb4G1rCeMw', 60, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1089, N'1oHNJFmWvRUb4HbH5Drdx4oLdkGeR8gWy', 60, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1090, N'1ZyosaJGCwnP5owZQoSiTY29V9t3y1K3j', 60, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1091, N'1qn973SZcE4E0idMoYYejvjTQBIQDwxXH', 61, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1092, N'1aslYmllKBbbbi0wIZA9_buZiSOmRWaqy', 61, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1093, N'1pG14Glw5QdIJF7TjqgdC-6Bp2WliW7TG', 61, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1094, N'1n-vam-1aOmF49xloLDRzWScLxZzIAr49', 61, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1095, N'1zY0wcBQPvKAV3xj56pOxeNRCPPM3saNz', 61, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1096, N'1y7V9ZqPbSkCXseZuW6sLLeQS4JtK5Q4M', 61, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1097, N'1wPDomIW29CCSS3TzrsQ4UzduQ-RO8apA', 62, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1098, N'102ksLXlzWaGaXdP9peLKnZnaTaX94-g3', 62, 0)
GO
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1099, N'1qyqWlqw24PEB1ahbDdqQGMafznvA98oN', 62, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1100, N'1EZFSayfj5N5_0ucn4F8ac4HVemlzjxNK', 62, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1101, N'1kZmdT3aG12Aavc4lgtc2CFFBbhwlsff1', 62, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1102, N'1dJYcTw6lcNEo_seu157d_oT1RdV1zeAC', 62, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1103, N'1xk_k9fsMk3_MGtQV-RxAEEhvAaZZFPA5', 63, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1104, N'1jqqBE2OMADr_iAte59Eb-DnX9SmZn-QJ', 63, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1105, N'1vVl3578hjKtc2UOSsCUJoUWaVt4PNAWS', 63, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1106, N'1T0_U8j7y_Ia86lO19tlS3l-a-KAujjnU', 63, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1107, N'1DZSN7f-kTFohaOdHk6R0MUBtlZ1qIKxy', 64, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1108, N'10W0VFewkYGIZFQ88rmxaA5ur-k6q92R6', 64, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1109, N'1zdjQ4HdyeZLvlpHltuvOduT01tiCDnjI', 64, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1110, N'147MNtCfCzwrQwEUgCKUqK3yLwYywyyVI', 65, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1111, N'1r1X1yI5wQDsnVQDcLipZzCHeW8Qysc4H', 65, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1112, N'1Cn5WA8x0jYyouUM-6eNRpIrowaPjLFCc', 65, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1113, N'1RWlb5vJfihSdX1Kks0ofFN09b0t8t4kH', 65, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1114, N'1qDAfvVl4L7aRg2OsM1StxFye0PNc5sKU', 65, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1115, N'1OhLIenIfIuz56u3WMLRQ-ZpEHIvUOfwb', 66, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1116, N'1Y6jjT-JE9IwuViQtDy8pPJ4JoWJg0gcq', 66, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1117, N'18P-eurCBhmaH4gw1pmbOpvp7UkLJnMXm', 66, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1118, N'1khiElSsWhNJAcSdEC0ST_Q788jV-oTpl', 67, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1119, N'1J6_PkIUyVonpfW_wQoNL1MLFO1M6HQZ-', 67, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1120, N'1uPzBVsFXZn8umtUJStFCprOosSMWBPmp', 67, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1121, N'1y30dP-8Crx5gyrTiI6rLGT40xkbe-WQ_', 67, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1122, N'1sxvcTqX6PCC4ObsGidbTgTKVSiMPYYoc', 67, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1123, N'1grkSd8ySKYRmFDR6s5qjTNZwbdt7PKZa', 67, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1124, N'1RVqQeF0rWK3BLEoJ9uVbnAQK8ftRmh7L', 68, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1125, N'1S-vsnia637c-x4hkuO_5tlIA1zwPmdEE', 68, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1126, N'1hrf7_KPdfUXikGD-S8cySi2aTgMJa64N', 68, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1127, N'1vD8iwqsfRZ1rG6kGIbDhucq0RS0bGVrb', 68, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1128, N'15G8_0leDp4oWaYTYHQiAcapLb38vpYT1', 69, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1129, N'1ddt0P9e7Tn3j5J9jK5B_uale1plDq9kX', 69, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1130, N'1OP3YTnmyWmsWwkOV1Brrz-OHjzRpoAbv', 69, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1131, N'191ejnkLC6Gqadfd9Gu39x3aoTEPt048o', 69, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1132, N'16mT-PbFKAp-fARe3DQojTKJy-bFMu9CL', 69, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1133, N'1VVM8aILKZ_fC7AB5-83WLjBSi_mUUh9h', 69, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1134, N'1rFatn6aIco0MssFvjNqHAh1osoZFZU8f', 70, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1135, N'10Ncwz7plHxXEYPteGrGphyoWfEoyoNN9', 70, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1136, N'15f7KwWtRrE7ZofminmTgrco6fdUrWgcT', 70, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1137, N'1klhv-_UY9tby021r8ZIM9DaNMKd4mDWr', 70, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1138, N'1s--4z4PURrvQSvUZrfC_bu1f2xqLfsXn', 71, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1139, N'1wOQOQNeto7jOk5c4rMsu-4oKr_tzX4LC', 71, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1140, N'1gerUWNi86L03hhNQzw3P5NLCxuFtJ7Qq', 71, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1141, N'19i6x2bqWoQC6gEF0t3oSU2qeunrArlw8', 71, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1142, N'1ru5Mt5a8H3u2KfYjIVnrdT-iTHNZy0j_', 71, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1143, N'1mDoEd4OghyZgP1cH64nI5FCoY9KLScKp', 71, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1144, N'1UeCqkMz5x1kYMKsVOmdtiJ5EFgo2AZk3', 72, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1145, N'1xb2khBFDr7PyqMfGPGvxW9JhNmSYCYwB', 72, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1146, N'1dIoNTb-w3w1Qmcs5V84hbvKvRr6UC7Y3', 72, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1147, N'1b8wsrln6-XCs-W8EvmTqMesO38HC2K-a', 72, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1148, N'1NE_WrROzVwQ5DS-YYyswEuHqKDmcYtCY', 72, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1149, N'1canJ2B6o2MHZnIPn_IxOqbnof-47TgFH', 72, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1150, N'1D3Hdg2nvvDpTKqClg8UxBydoAexYM8yN', 73, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1151, N'1_wPDTqxo00nKeVRTgKjELB92xJJoh1G_', 73, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1152, N'1Rs9juGDfvJHgFfRG8Jsijg73nC-8w20B', 73, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1153, N'1mG3lnIqJ4QKyP9AGhMUJvnsWE6xtUFL7', 73, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1154, N'1dFQQhDjva6Uk4g6-Yi0cwD7rGp-u4k7-', 73, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1155, N'1ZUHE4H3su-RQAB6fYxRzGHbC8KMAHPvv', 73, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1156, N'1ZRkXSh5lLm2e-Fl5yMJL6bFkHerRHF17', 74, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1157, N'1oohZvpSwOQx57Tkkwz99NHKTIDum4yc4', 74, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1158, N'1HxW0LcRKSN-DPa_a3BVpgPXpNCmkO6k0', 74, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1159, N'1TuIzaJY-Jmylk-k_gA_rrV3yI981JhY3', 74, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1160, N'1CkhAOHhg4jl5Wjoe0YQ6Y1XbCZco43l6', 74, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1161, N'1FT9YkiUj5w1mvPuNZs5ZsZ5jW2B51uyO', 74, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1162, N'1LNSRcERBpXUADVFps2mqWqNB4lG-x26p', 75, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1163, N'1hDCogmQzCRc7vUIplGU7Yw7wqoDHPw6y', 75, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1164, N'1m5x5vx_ILXyTxAsOQFTbXPDfeNrnVSQD', 75, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1165, N'1_mSanybbzWSZnKQFIiN2GP9Me5b3RxXD', 75, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1166, N'1WgPtaxFD8wQA3IP2eeKi_Z_MBdB7ovG7', 75, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1167, N'1QMK9ms826X0-hMN8UHOnbdQi89mv2BLo', 75, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1168, N'1HxflnYzk-zFqBKUYQsZtHtcfB0JvPAc0', 76, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1169, N'1VqlDYi6ZYyakYZ-4cQC7PK1Rzlaehz8M', 76, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1170, N'1Ynz_xAhBgXz8VIJJX8glXyoH4lLnFUsM', 76, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1171, N'1SSpWuMFYVHCNXXdjGZ9LlAJMVSWSER3_', 76, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1172, N'18v1jruVAIo3ChGJnud8hbTuMOHjJ8qxJ', 76, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1173, N'1sCbnE2kfPYPV43x997Yv7_owz3e3ck2e', 76, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1174, N'1eJB2-jidxJBgPjkISKIdsuXTXP-jmxl5', 77, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1175, N'1yn8QROQ53ojOgyMph11FGhqsoSE4mam7', 77, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1176, N'1FuO9bhD9m7AE9rTrRXIUpphcsvzwxIWm', 77, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1177, N'1A8dQtgKnDSIDQJVvmgERgl9yw8kBRmnh', 77, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1178, N'19M372O_ewCbTjNcPkN5fgT-Rf2wUg0vj', 77, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1179, N'1EiMuDNCKMC2iEOdd5bD7QbD2ZPO3yoGn', 77, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1180, N'1sRGvJyDX5mudYfqINqmvgULkEHGd8sD-', 9, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1181, N'1xmvg8cOl5i7JEO8RuRWJMzcqSNwZ3ZI4', 9, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1182, N'1WSAWD46A8iHcF4P43zhG9ha2VHJ8cNlm', 9, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1183, N'1wPYedLvnV7CMo4B4NzT4Oh_oYRkZCTdq', 79, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1184, N'1DSzFGU6Ed-Q8pjPvYJd5gm43y0m9tMUp', 79, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1185, N'1rBfJy2ZKa4dXfaWTVJiYwlWmV71qbJLk', 79, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1186, N'1ciZvWbxey84_C8dvckFa4Ylmq9b_YljC', 79, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1187, N'17tLJNHC8_MKgFJBSrl7_9kip0J5sg-4d', 79, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1188, N'1y5L8DPNGwuInQptdKeGEYhKEF0a9k2n1', 79, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1189, N'1Z1qCprGI4v93whQujo41MjAeM-l6TZzu', 80, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1190, N'13kLpNXYN-fm0pcqWTmYiKYHRX7Vmz9c3', 80, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1191, N'1aNJCsM_KNccD_x_ReytDBnPNcDkibfuq', 80, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1192, N'1ak8E3OF2UboKSXvOswqhKB7UCN3Ntrmm', 81, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1193, N'1EzoYkeVpfAi2HK8MTioDNffZ_MvRCrl8', 81, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1194, N'1wVySx84OIdRYwlq89IRGMlLn72g8oCGT', 81, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1195, N'1grxlHJQjqCKFwEhBozZzAYWX01DkxSaq', 81, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1196, N'1RDbeIlMNNvMa7Ys5J9UAwB_USRQ-KHA6', 81, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1197, N'1yJpqIaIqYeo67GadC6apu_l8DFZyrYDV', 81, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1198, N'19LZNo8uUMoEegqhHMJwwRsS4k4A3h79N', 82, 0)
GO
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1199, N'1ed1pYzB_xN_QFgR3fmaCuypbFcRZa8-m', 82, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1200, N'1hKtRko-_99UM-Bv_RAYZsEK57-JEXux7', 83, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1201, N'1NMf7e9CcFi6fLGNzO-HYhMCLdwiyZ6-v', 83, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1202, N'1Np26cV0CS2zoJAbv03HEZu3_RUYcGlZN', 84, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1203, N'1azXPrJ5ktliWm-RjuqnjtNGE5t_TzYpE', 84, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1204, N'1dxrhAgGW9LHE7tDqvthOZAdu51xaHxIq', 84, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1205, N'1zGAHMZrU6BgNpBXSBO3R5axZ_mxeGfqz', 85, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1206, N'1fe9G5yAU4mSsRBiUvuVMxZqm0kv1Vlcn', 85, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1207, N'1iPni0XyspCe8aNjfjZY7PjjoMGA6enPz', 85, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1208, N'1N_Oh50IFg2uvsvmU8pVldRSkL7MNdx2g', 85, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1209, N'1iNnXc0bq84sLc-ImL9arPU1gtVuYcYxf', 86, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1210, N'1WXft9cAtPESxOfO27jh39JNG_4CLvPD8', 86, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1211, N'1FdnyJzIFeP9HmHjHld5skoEYzjhL6FJK', 86, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1212, N'1y6GoHvQFi72kg9O7EXlEv5KcmOufUba7', 86, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1213, N'1XY8HGVLrep0BYETx-u8JemAZEFBj7L1G', 87, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1214, N'1OzAvey8acIq89thDY1DZmuKSZ0yvXRJN', 87, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1215, N'1NZTrxKzefV5A8oDMM51hJy5kXboVGXjP', 87, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1216, N'1bFuh26gMh7dDvaHjWZ_E3U0bZPV6ceSn', 87, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1217, N'1t3V0kMOpxPcAcVfvjMtF1DO68HGY-sPl', 87, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1218, N'1IpkNRo7HLONOlAIzFBsSIJjxVMeq3z-t', 88, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1219, N'1St4cRSmpDoJGvEbGyCIYlLrWU94mI_d5', 88, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1220, N'17dDwWFcfoqnmeeuY9a1yBTqaCzYWB-0K', 89, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1221, N'1eDAuALDzP6BJQ25ivgYGaNf-Bdydvlor', 89, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1222, N'1fSErgdn2NJCEtNW7iA_cZbezZt_Xe5Hx', 89, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1223, N'1AdTxGh9WwKmZmSKBoJ2PMqUZohO_b8j7', 89, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1224, N'1LSrmU563K8ZE7R6E-NyQfjnBAmrKU6LC', 89, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1225, N'1soMFXYjHJr8rjuTgJXnDbZAkR4--2RWd', 90, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1226, N'1mXOVyHdxvIbq4s05hDCry_M5Y1tLl-3Z', 90, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1227, N'1Js1czYHmuEUmttpWlMKL6IOGE90ldXv4', 90, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1228, N'1XvLJXli1JZ6YHD6efFESAOxJDc1vLTO4', 90, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1229, N'1AUyXHGZ4xlAPj-p3HIAMkw-Rx2Dcl0VR', 90, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1230, N'1H6r_q5t4xbpOpYRkoH-xQhP_gc5-NjUB', 91, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1231, N'1u2VkpDpqydy998rCcRddwn05CbELdMO5', 91, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1232, N'1Low8UhLbcyjd8Mcc11EDIZrm0INItqf6', 91, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1233, N'1sqxtpT8b7gh3vK08rrKFLaIkEuHymFSR', 91, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1234, N'1n8EsqQuJ4p33jSlrp0K_TJHVGzHPIwXj', 91, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1235, N'1pu7c4yac4XT_yShBHDqJYehz5YKF-wN8', 92, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1236, N'1qCcjSrvJyKesr9PoT6Mf5wN3E-xWNwcf', 92, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1237, N'1JQjUkOVWBtVqjDGIBA_L3GCDOsYBLjcq', 92, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1238, N'1w3BMMqrJniwdtohviPZXhoj9jGXfob7v', 92, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1239, N'1bRK3qSjj_UFztZlNW_R-nVD5N7kf4iTr', 92, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1240, N'1TOxKuR3fSVnBihbneyq-eTBMwOF9dzsF', 93, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1241, N'1_TLdKHg5MxtbW_4KbUtcKQNxHk-gIE4A', 93, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1242, N'1HdxIwrMtBixkI1VMasfopV5tjCywF_z0', 93, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1243, N'1SkYO0hJygodbm93jPlDzYxPPn9e2Jg_H', 93, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1244, N'1FJD1zF8TSxhVySurwUDnVTRLxE070W4L', 93, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1245, N'1lErHRCQosSrT3oYZXVSs7Y3hYwZCnVGY', 94, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1246, N'1ctzzEmTl-dNpCvDjG7hsd8VBcws9debN', 94, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1247, N'1QVwEWpAoI1Oh_ebkw87WgR_TvdgcirQM', 94, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1248, N'1Vm5anL9G46t1R0PhaITWePmTM8qhqVV5', 95, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1249, N'1KNwTFr5hbW9Xw0o7dQAahO5PPKQHBwN-', 95, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1250, N'1MLWn7lzJ5KAqzWt3W34r6nuQjH8BW5Dj', 95, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1251, N'1OK36sD17YucO4N0-ZAAZ-uJC6G6t1ZiJ', 95, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1252, N'1nKLbPSZRVBljgfcDrKyVXa-lm2Swzy1Y', 96, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1253, N'1Uw4EvRjwJqxESimQwzH_00U43kE_FeHX', 96, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1254, N'1i4ZHbGpE0xQ2-VyDSMWXjv1EeLLjoQLp', 96, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1255, N'1HgwbIRvEGN1STUGVDsfkaKMMIUCxQ8EM', 96, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1256, N'11ulAJZc1tGUdebUJA8s1l3pGsSTyZoqe', 97, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1257, N'1LhBfitg6d0XoURQxXqio7YeI1fHlEVNE', 97, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1258, N'1rsLpzPb57hsRuvmjt1UseCcgz4lv81Ur', 97, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1259, N'1LJgvwm9avAAzxiA7fzhGlG3DCLNm30XY', 98, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1260, N'1Wa-X8Vta1SYzzdwRgw0qBum2ZhCunOr7', 98, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1261, N'1DXyAT6Zy99UJ3AGIrso5qSA-uRniTCYe', 98, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1262, N'1ED3V4Dy1pAgG3WvmGN-YUn701MTxA9dj', 99, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1263, N'180UEOkVk2aIdhdiZYDjszjYwTFQvMatk', 99, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1264, N'1-bcK4bF8R4lU9KjIXAEVOqANKLpewmHL', 99, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1265, N'1tpIsowU52ujSM6kcDkh55fhjJ4_5Gc9p', 99, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1266, N'1AwhRC2hSpUUvmc71JPMGMWayNUVThxcc', 99, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1267, N'1w3bC5stXoIhgJL8j_OuqCcflBHtyPfWe', 100, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1268, N'1i-y5_1Fi02huk1WqITGtPMC_TCWVsPLb', 100, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1269, N'1KjNxatb3hVm-2AGdFdNPeP5OGi6mBgx0', 100, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1270, N'15hOyIBPMv9NYwra55vgQMBYTvk399vAh', 100, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1271, N'1jT8C-882AKsj1NnZnYVGr6C89DNW6lws', 100, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1272, N'1OLXt0bt3OkGNwu-WXoidIYqwprkUCmzB', 101, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1273, N'1Q16FbEeQh3KyrUyB1wXEVxBTbDAIwUqF', 102, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1274, N'1S-OszTOscxR6QRmibkNfcTOKwaSDchbJ', 102, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1275, N'1yEx44xMIz_alCb0P10VrXE-gDyEgObXN', 102, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1276, N'17L6QL2q8nUeCr4rppynHwinhHafbkBAX', 102, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1277, N'1kiJVuYC-pbMKSU5y9W6flt_ayGWD8CKr', 102, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1278, N'1HGk9AdR9GktR9E-l08YuT2h7-ImPrZSC', 103, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1279, N'1vVUF4r-4IFqSF-CMwuotO-5Z0Qeh0KM9', 103, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1280, N'1inmXgTO1rL9fBblhCO2mJ3KgaofPJQS3', 103, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1281, N'1bYqb9OUgvA5HIWoIvVof45n-Ukt8T0x6', 103, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1282, N'1VY5kIIjByMy7wg41YMIFr0vHq5SVGdEm', 104, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1283, N'1wPXOfmjnUfxWlof79UDUtu3bEgav8IOi', 104, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1284, N'1NMYLm6w1bKQ7iAbNcCVrOf1nGRZRVJGh', 104, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1285, N'1I3i785Xsnl_Hxp9OivReRofrKUc4Gvdi', 104, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1286, N'1PgtUCbsTcTTKhaX3JpbwmvShAoPu7KAl', 104, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1287, N'1XshXqBi9jpycZf0RZAM_pzA5IKB36oFB', 105, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1288, N'1_KAKwVVXA_8NMDGdvCNrErBRl84j306t', 105, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1289, N'1JFvEkVCq7LKTsdIWF3ErhGd_tBxuqmPJ', 106, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1290, N'15VbmG2jer5LQ8A8HIqua5d8ZKZm2UVXB', 106, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1291, N'1pQBY6UVIWAzrctsLAYT1wBZhZYYZSEmx', 106, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1292, N'1m_FMQHuzGMr6HSsHvXDQjjZGiRMLeBYJ', 106, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1293, N'1u9eON4HbayQoWAP3eQP1CpjEKFB3v9f3', 107, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1294, N'1mMRdmh1jC_SfC06-QiqlFIc5r3NUeSG3', 107, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1295, N'1AYAX67d1R5ujlK4nYQOiREYI-b5o3vcy', 107, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1296, N'1fGRlzEZNxI8rufqkQyLyG1yXGNpHgKRa', 107, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1297, N'1jYlVMHKeG0ZTF89svYNbVexxkrBezykN', 108, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1298, N'11etNIWGVEJONtis1oLzBT4JWzQXUN2QK', 108, 0)
GO
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1299, N'1Yn7ZO5hM8OV7puURE2rJYdlY1O3eL_X7', 108, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1300, N'1cQ-RWMz3uWGCrOpb6bpdrOWQnbJO44Ee', 108, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1301, N'10cKe7FFQHN1BsaHcCDQvXnuPziCT8nUk', 108, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1302, N'1dcJWTcVbD0EMndjIVHiuMWpipUP-hUIA', 109, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1303, N'11BdHJBWxtEcxF5aqNJFXU6p8cQwz57bD', 109, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1304, N'1IfMqspl3EXhx-hhX8VT1DcWl_7ASluS8', 109, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1305, N'196n4Xrud9eBIGLBHFlS04hCU3_BGrmDO', 109, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1306, N'1hCuMrLNorSTV6U47Ap-fFM8uiooLPRHb', 110, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1307, N'1M11hfv04x58v54sfOrpcQgULDuYcBsHn', 111, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1308, N'1DECjVxx3b-G0fKEmXL9opsyWURSqrCiB', 112, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1309, N'1Y8OyYRTVZH3oh7RSwMWVlOBBCoBefTIw', 112, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1310, N'1ox4mLHMKbVX89k92E7PEZ4bC-A5MYGut', 112, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1311, N'1E49YxARo1-L6yN_bCLksMi-NRWozbm5M', 112, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1312, N'1p819PuDMx86Tr3CAw584aAN_P1qSSfzx', 113, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1313, N'1KkZI4l0gsNYUqQh2kQmPdIgZ7vKAvYTl', 113, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1314, N'1zEbQ99epWRtmVlnTTE9Rs_5XZePZIF2w', 114, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1315, N'1ba10ofv-JOuOWA5USBA_czCDBwffgB2b', 114, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1316, N'1cRzDHFMfCSrzB9t2pDCeA4-Ihnxlwhul', 114, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1317, N'1AulS3kG7X0zCpblDCCbelWrfPwKJcHyh', 114, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1318, N'1AqA4aD-Z8KdLyiMBiVzuHo6xKbcM45n2', 115, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1319, N'1wEDNmcTXmBNxUKS70efDSh5O4hqf6FkV', 115, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1320, N'11dNwPEgn4t83HG47STMSj-5YsRJ8EpRx', 115, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1321, N'1lyOB4khYhLNx2JbPmNkYd7ag_aLTQq7B', 116, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1322, N'1uGv4B157VjnkTBx2g7GaHy6p9qVYepli', 117, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1323, N'1QnALGcgC7JZWZ3mLEDgJJpgM0IpvVTLq', 118, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1324, N'1bb2xSQ51dTzHW-sVYWtbA_duQBdsFwaU', 118, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1325, N'1dB_hEOMkntvbdcDAwu6tQuTInAwYsmzb', 119, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1326, N'1eFbRxWVYYJc_HhlJ7_peA2OCIrvsY_Cl', 119, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1327, N'1hrsFhipqJZLNZvtHq6HXkOXzTN_N9DEC', 119, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1328, N'13lyBVFNDoZF7pTl1tpiVINdzw3aZ4wQq', 120, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1329, N'1J1AZKAcbaDEHmL0Ba5yE6CiozvBKZI1L', 120, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1330, N'1Qbtl2J18ao_jEXE24EnbYpEL687YJZup', 121, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1331, N'1s6JOYlLAyprvfFXCrfJOWlKCV5hBXMQv', 122, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1332, N'16XqQlmihhq5njcgXEUWkTcL3KxOwFaa1', 123, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1333, N'1caQEARuZNIOwRGsZnIY_8VIy6nIT9n0x', 123, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1334, N'1_ZFKxEJs22NHb-pYc0z51dA8ksSst0xd', 123, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1335, N'16l7hOD6obxq7ZaEIs62WvIYWgT5PMcAj', 123, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1336, N'1k6GHKuwd71g6f_jj4yt0PCKQJqAtt0_A', 123, 0)
INSERT [dbo].[HinhAnh_BaiDang] ([id_HinhAnh], [idMediaCloud], [id_SanPham], [videoType]) VALUES (1337, N'1mHq16NUt8QoIiW3vmMXrTf6HHEx-vrT1', 123, 0)
SET IDENTITY_INSERT [dbo].[HinhAnh_BaiDang] OFF
GO
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (1, 1, N'456', CAST(N'2022-06-07T21:55:54.8465441' AS DateTime2), NULL, N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (2, 1, N'456', CAST(N'2022-06-07T21:59:03.0526614' AS DateTime2), N'', N'Chào bạn')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (3, 1, N'456', CAST(N'2022-06-08T10:38:54.5966521' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (4, 1, N'456', CAST(N'2022-06-08T10:40:07.4836297' AS DateTime2), N'', N'jwsdfhgjsadh')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (5, 1, N'456', CAST(N'2022-06-08T10:54:08.7658996' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (6, 1, N'456', CAST(N'2022-06-08T10:55:30.3573948' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (7, 1, N'456', CAST(N'2022-06-08T10:57:20.3634032' AS DateTime2), N'', N'saffasdf')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (8, 1, N'456', CAST(N'2022-06-08T16:12:07.3854393' AS DateTime2), N'', N'hellooooooooooooooooooooooooo')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (9, 1, N'456', CAST(N'2022-06-08T16:41:46.4916755' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (10, 1, N'456', CAST(N'2022-06-08T17:44:23.8421978' AS DateTime2), N'', N'test')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (11, 1, N'456', CAST(N'2022-06-14T10:38:06.3855742' AS DateTime2), N'', N'test message')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (12, 1, N'456', CAST(N'2022-06-14T10:44:30.7190998' AS DateTime2), N'', N'test 2')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (13, 1, N'456', CAST(N'2022-06-14T11:23:27.7225816' AS DateTime2), N'', N'hello 3')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (14, 1, N'456', CAST(N'2022-06-14T12:33:59.4579280' AS DateTime2), N'', N'hello 4')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (15, 1, N'456', CAST(N'2022-06-14T12:34:09.9466653' AS DateTime2), N'', N'hello 5')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (16, 1, N'456', CAST(N'2022-06-14T13:22:36.3371649' AS DateTime2), N'', N'aajdjnkankjdak')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (17, 1, N'456', CAST(N'2022-06-14T16:21:11.5410775' AS DateTime2), N'', N'ajdajhdaj')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (18, 1, N'456', CAST(N'2022-06-14T16:22:21.8095696' AS DateTime2), N'', N'dhgahdgahsgdhag')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (19, 1, N'456', CAST(N'2022-06-14T17:23:41.0473298' AS DateTime2), N'', N'adsjasndjansjd')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (20, 1, N'456', CAST(N'2022-06-14T17:23:52.4819323' AS DateTime2), N'', N'asdnajnajs')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (21, 1, N'456', CAST(N'2022-06-14T17:25:27.2442711' AS DateTime2), N'', N'hello 1')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (22, 1, N'456', CAST(N'2022-06-15T15:40:58.5265709' AS DateTime2), N'', N'hello 123')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (23, 1, N'123', CAST(N'2022-06-15T15:41:10.1317332' AS DateTime2), N'', N'chao ban')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (24, 1, N'456', CAST(N'2022-06-15T15:42:00.7521704' AS DateTime2), N'', N'hello456')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (25, 1, N'123', CAST(N'2022-06-15T15:42:10.0995376' AS DateTime2), N'', N'hello789')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (26, 1, N'456', CAST(N'2022-06-15T16:59:02.3104621' AS DateTime2), N'', N'có bán con này ko bạn')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (27, 1, N'456', CAST(N'2022-06-15T17:04:08.1375007' AS DateTime2), N'18GqfiqF_qmLLhkCUnlPQwJScqDvv8b-k', N'')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (28, 1, N'456', CAST(N'2022-06-15T17:05:24.2239861' AS DateTime2), N'1YNEnMxLvWncB-0wuR8zS5lV69-XxAKXV', N'')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (29, 1, N'456', CAST(N'2022-06-15T17:17:26.3899055' AS DateTime2), N'15WbNwED4epQJvKkfJQp7gxa4D2sswQAR', N'con này nữa ')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (30, 1, N'456', CAST(N'2022-06-15T17:20:33.6242948' AS DateTime2), N'14c0M_N8YzMVE5X7jWy-YWhI9_5-u9_Ay', N'con này ')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (31, 3, N'0854863505', CAST(N'2022-07-16T16:17:48.7613281' AS DateTime2), N'', N'Chào bạn')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (32, 4, N'0343679935', CAST(N'2022-07-16T16:18:07.4181367' AS DateTime2), N'', N'Chào')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (33, 4, N'0343679935', CAST(N'2022-07-16T16:26:48.0893383' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (34, 3, N'0854863505', CAST(N'2022-07-16T16:27:07.9110668' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (35, 5, N'0854863505', CAST(N'2022-07-16T17:06:51.4614647' AS DateTime2), N'', N'Chào bạn')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (36, 6, N'0343679935', CAST(N'2022-07-16T17:07:06.7641453' AS DateTime2), N'', N'chào')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (37, 7, N'0854863505', CAST(N'2022-07-16T17:15:51.6250445' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (38, 8, N'0343679935', CAST(N'2022-07-16T17:16:06.0330611' AS DateTime2), N'', N'hello')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (39, 7, N'0854863505', CAST(N'2022-07-16T17:20:42.4489335' AS DateTime2), N'', N'Chào bạn')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (40, 7, N'0343679935', CAST(N'2022-07-16T17:22:48.9811267' AS DateTime2), N'', N'chào bạn')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (41, 7, N'0854863505', CAST(N'2022-07-16T17:25:56.8976723' AS DateTime2), N'', N'chào từ Trí')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (42, 7, N'0343679935', CAST(N'2022-07-16T17:26:07.9870567' AS DateTime2), N'', N'chào từ Trường')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (43, 9, N'0786266752', CAST(N'2022-07-16T17:33:35.6464518' AS DateTime2), N'', N'chat từ Vũ')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (44, 9, N'0343679935', CAST(N'2022-07-16T17:33:55.7083462' AS DateTime2), N'', N'chat từ Trường')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (45, 10, N'0854863505', CAST(N'2022-07-16T17:51:32.6332840' AS DateTime2), N'', N'chào từ Trí')
INSERT [dbo].[Messages] ([MessageID], [ConversationID], [MessagesBy], [Time], [MessageImageSource], [MessageText]) VALUES (46, 10, N'0343679935', CAST(N'2022-07-16T17:52:01.4104328' AS DateTime2), N'', N'chào từ Trường')
SET IDENTITY_INSERT [dbo].[Messages] OFF
GO
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'0343679934', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0xD9A7CD617389219C5CB7D6E7A2B2A6A57822C8DEE47EC4DF580F06778A3B1C4A833E6429C181A1238955D54BA5347BDF63E58AC73FAFB3B4AEEF32ED8E49301E, 0x1902606A256C00EC84F85AC2C7B117D8DB239249D5B11D0C96D03A922C50226A341B5591F81FF9FBC5627F992AA3D0A721F3F3DDE26A927501799135BCC28D68A0F5C16AE6CA7F7B8B3A5F75F78CE4655909A7367A9F0172C28DD0EB883EAC12F8F80B53508FE5EFD2ABD759B374DFE6C9FE5925E42E265A8A376E3AE21FB54A, CAST(N'2022-05-28T20:56:11.0747603' AS DateTime2), NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'0343679935', N'Bùi Lê Hoàng Nhật Trường', NULL, NULL, N'123456789   ', NULL, NULL, NULL, 0x200DE1C349793DBBBA8A44B348B0B4CB85F5AFF459B8033D3CC47378B8600144263E1D2E652C7BAAD1A59E020B743C2F801468ED68763B3CDAAD728BF173466F, 0xD95A70475D88FAAB69845CBB68FF7F3686486BA49EED3FCF234A09E4EE6D5CD352A62AFBA9B1290BEBBCE46CFBD681A6E1F3230B215ECACCDD669CD2D94E76673FD53E1CA330BF559F9D5398573466CEFB4C622D2A21DF353D2495D472E663D19247A78A90C8A4486CFAE852170317A878987E51F1B5A79B25E66AC6A1D9419B, CAST(N'2022-07-15T10:32:52.8040466' AS DateTime2), NULL, N'180 Cao Lỗ, phường 4, quận 8', N'17AwhgPC7iz1PkE6hXymsRw4j9ir0uCUA', 1, NULL)
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'0786266752', N'Trần Tuấn Vũ', NULL, NULL, N'123456789   ', NULL, NULL, NULL, 0x6F5C6C2B5F69C93E156D7BB1D5A7E8EC86E0188ACA60C8BB6C4443402D967FC2434C75E6E000365421C7CA70A5729063676DDA5502DA5C29AF007613319A7458, 0x8F2E3A23DAF053CB8606A923CA04BD2309F38E4C45B04A569B18F50A0820B3172DD7507D471B1009C35746EFBB65FF1EDED8275DE320236B3FEE1F88178935A84665F0ECE49FD397DB97268B8B53F90C3529BFDD9A95A4A0F54446D0F3AF3BF862E6C186D86159ADA2CFC0B22DBCE67B075221B73E4834AC9EC13F06377358D8, CAST(N'2022-07-13T11:29:38.1359526' AS DateTime2), NULL, N'20/11 Trung Lang, phường 12, quận Tân Bình, TP.HCM', NULL, 1, NULL)
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'0833017943', N'Phong', NULL, NULL, N'123456789   ', NULL, NULL, NULL, 0x3ACD483A54AC0EB57AC7C7D52351BAF2B1CCA516CEE14A2CD6868A90CE210231268C984A6B123B2D709C240A98112C66A3EC344CA4E8823185CBE3616622B989, 0x1E58CE5A494CDAA1BE3B7BF42B5EA9FAAF8F3B3BE25E833CC9BA09761BDD0F091FCA8EA2A793D012B5EEC4F90D07189956F2FE33D6D7903E04960AD4E50759415A2329C48C80F3CC1F14D2A201125821B6F2D60DE05143AB3D87ABFE4AF68CA46703558D9FE5428D928D33CECE117F5AA8F638EE821CAD60F2DFF14989DEA033, CAST(N'2022-07-13T22:38:56.9647238' AS DateTime2), NULL, N'Tp Cao Lãnh, Đồng Tháp', N'1O9X2ZQVtj9Wr4pEQ9bxN8vwaaNzBziPc', 1, NULL)
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'0854863505', N'Nguyễn Trọng Trí', NULL, NULL, N'123456789   ', NULL, NULL, NULL, 0x2A456706CDB1CCB5E2D99657F1F7BB34CF5C01C6E4565F10A373B95008FFF7A2E8215405C82C67135B2C9D05D13265BD2F81D71A690BCCFC9ADE82D08CE803E6, 0x2A6F9327A306C725A7F44EC5C02A5AD4A8D6EFE882FF826390B750DC1FC806915C2263339960F0CF72B29C9DE455AEFA1A01B94D15F7C7D066D5155F223A868C7D372C556D8A764A7AFB22B42A64E36E9464875C545B809F82CD9CF3F172406C2E955012FB339F237FFB1402137481CCEFDE2DCC6EF115822803321FFB4C7BAD, CAST(N'2022-07-12T11:14:30.5882058' AS DateTime2), NULL, N'180 Cao Lỗ, phường 4, quận 8, Tp.HCM', N'1KboIhvxjklkgfTK2sB2TGwuqx09cDzF0', 1, NULL)
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'123', N'User 6:53:03', NULL, NULL, NULL, NULL, NULL, NULL, 0xEF558E577875D487148DC2AD09911B46AB1B0BC5D377B6236EFA1466523B29A3012A07A3C0F419B1316378268AB03332B1E1DD56AD5C5F3183291CBF1A7E3BDD, 0x76A1B399250D0C17AA57956915384D55A542BBC7C48B357CDB14B43B8161152393724035E02C910A68FF25707B0CBEBDD2C8781A9184ABBAB0A85F687E46D144D0C13B38EA37FDE5B8D0EE9A9F755D1C9FE77844BB46F420A6B7A91BC07CCFD9821F31970BF03857A0DF90423266672B99B938BCE1CAF4865A0F5C5BA3F8607D, CAST(N'2022-06-02T18:53:03.3307199' AS DateTime2), NULL, NULL, NULL, 0, CAST(N'2022-07-25T21:18:21.6152153' AS DateTime2))
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'456', N'Nguyễn Trọng Trí', NULL, NULL, N'123456789   ', 1, NULL, NULL, 0xBA3C84F7AA1AD8707CB956166AD089B5DC15BB5AD5631A33BE86DF4C48A3617299ED41656A91BEEF2FEC6BE3D29F44BA05722C6E4199B6BE5C306775B22D2F33, 0x24396EE09760F98A60260A08C15BC1E39B78D09DD1C58BCBA7F8079148C270D3ED0AD6F21D8EDBC62B58AD0D6DA7C0258F30981D9E022DF3A7D017435ACB790B2DD8473CB501DC0913E40CB709262DEAF4AF72235E0705510AB580D007506FDDF463357853D62F54DA88127540F32B53CC611BFE5CDD6D70B1229544E02AD983, CAST(N'2022-06-02T18:53:47.7596249' AS DateTime2), NULL, N'Tp.HCM', N'16wMq5e8vbPaBeRh1SHK-SjQxcPQWw11J', 1, NULL)
INSERT [dbo].[NguoiDung] ([SoDienThoai], [ten], [NgayKetThuc_DichVu], [Loai_DichVu], [So_CMND], [Admin], [Hinh_CMND], [MSDK_DoanhNghiep], [passwordHash], [passwordSalt], [CreatedDate], [DanhGiaHeThong], [DiaChi], [AnhDaiDienSource], [Active], [LockTime]) VALUES (N'string', N'User 8:29:27', NULL, NULL, NULL, NULL, NULL, NULL, 0x85380EEE780F00926B6F0A4E9AB58AFCBBCED51B9EC27420E90516B549603A320679680E7A5141A81B39364A2597B76E7E0D24C624B18029CDEBA78CF6918033, 0x4FF78EFED174CA961A4C2DA75F4D09A2292FF282D2C737F58CA14226BD6E0EC7A328C607C319C9A6685EAB74F85B22BFF725EF61020F3FA872BEBE6B325783B715119C230EF10AF7697BA10FA7A1497A8FC3ECA5914DD5CCE834B09E6CEC704102894B6ABA4AFC12EBC30AA48394097E2FD578BEF640215784A04CFBEC37CEF8, CAST(N'2022-05-24T20:29:27.9245882' AS DateTime2), NULL, NULL, N'1Gx5eFd1Z3O9ZJ3x_jlBlrzeIqsPRs4px', 0, CAST(N'2022-07-12T17:57:40.9835733' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[ThongBao] ON 

INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (1, N'0343679934', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 7)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (2, N'0343679934', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 30)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (3, N'0343679934', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 38)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (4, N'123', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 41)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (5, N'123', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 42)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (6, N'123', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 43)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (7, N'123', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 44)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (8, N'123', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 45)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (12, N'456', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 49)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (13, N'456', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 50)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (19, N'456', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 56)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (20, N'456', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 56)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (21, N'456', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 56)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (22, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 57)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (23, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 57)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (24, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 59)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (25, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 60)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (26, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 61)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (27, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 62)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (28, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 63)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (29, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 64)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (30, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 65)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (31, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 66)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (32, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 67)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (33, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 68)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (34, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 69)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (35, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 70)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (36, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 71)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (37, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 72)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (41, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 76)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (42, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 77)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (44, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 79)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (45, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 80)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (46, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 81)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (47, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 82)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (48, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 83)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (49, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 84)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (50, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 85)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (51, N'0786266752', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 86)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (52, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 87)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (53, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 88)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (54, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 89)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (55, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 90)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (56, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 91)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (57, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 92)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (58, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 93)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (59, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 94)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (60, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 95)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (61, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 96)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (62, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 97)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (63, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 98)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (64, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 99)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (65, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 100)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (66, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 101)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (67, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 102)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (68, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 103)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (69, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 104)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (70, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 105)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (71, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 106)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (72, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 107)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (73, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 108)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (74, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 109)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (75, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 110)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (76, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 111)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (77, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 112)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (78, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 113)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (79, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 114)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (80, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 115)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (81, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 116)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (82, N'0833017943', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 117)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (83, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 118)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (84, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 119)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (85, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 120)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (86, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 121)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (87, N'0343679935', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 122)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (88, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 120)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (89, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 119)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (90, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 118)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (91, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 117)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (92, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 116)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (93, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 115)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (94, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 114)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (95, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 113)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (96, N'0343679935', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 112)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (97, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 111)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (98, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 110)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (99, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 109)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (100, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 108)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (101, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 107)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (102, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 106)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (103, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 105)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (104, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 104)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (105, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 103)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (106, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 102)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (107, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 101)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (108, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 100)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (109, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 99)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (110, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 98)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (111, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 97)
GO
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (112, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 96)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (113, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 95)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (114, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 94)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (115, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 93)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (116, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 92)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (117, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 91)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (118, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 90)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (119, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 89)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (120, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 88)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (121, N'0833017943', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 87)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (122, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 86)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (123, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 85)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (124, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 84)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (125, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 83)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (126, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 82)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (127, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 81)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (128, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 80)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (129, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 79)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (130, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 77)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (131, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 76)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (132, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 75)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (133, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 74)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (134, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 73)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (135, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 72)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (136, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 71)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (137, N'0786266752', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 70)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (138, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 69)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (139, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 68)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (140, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 67)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (141, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 66)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (142, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 62)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (143, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 65)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (144, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 64)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (145, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 63)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (146, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 61)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (147, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 60)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (148, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 59)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (149, N'0854863505', N'Bài đăng của bạn đã được phê duyệt', NULL, 0, 57)
INSERT [dbo].[ThongBao] ([idThongBao], [SdtNguoiDung], [TieuDeThongBao], [comment], [checked], [IDPost]) VALUES (150, N'0854863505', N'Bạn có một bài đăng cần được phê duyệt', NULL, 0, 123)
SET IDENTITY_INSERT [dbo].[ThongBao] OFF
GO
ALTER TABLE [dbo].[BaiDang_MeVaBe] ADD  DEFAULT (N'') FOR [LoaiSanPham]
GO
ALTER TABLE [dbo].[BaiDang]  WITH CHECK ADD  CONSTRAINT [FK_BaiDang_DanhMuc] FOREIGN KEY([id_DanhMucCon])
REFERENCES [dbo].[DanhMuc] ([id_DanhMuc])
GO
ALTER TABLE [dbo].[BaiDang] CHECK CONSTRAINT [FK_BaiDang_DanhMuc]
GO
ALTER TABLE [dbo].[BaiDang]  WITH CHECK ADD  CONSTRAINT [FK_BaiDang_NguoiDung] FOREIGN KEY([Sdt_NguoiBan])
REFERENCES [dbo].[NguoiDung] ([SoDienThoai])
GO
ALTER TABLE [dbo].[BaiDang] CHECK CONSTRAINT [FK_BaiDang_NguoiDung]
GO
ALTER TABLE [dbo].[DanhMuc]  WITH CHECK ADD  CONSTRAINT [FK_DanhMuc_DanhMuc] FOREIGN KEY([id_DanhMucCha])
REFERENCES [dbo].[DanhMuc] ([id_DanhMuc])
GO
ALTER TABLE [dbo].[DanhMuc] CHECK CONSTRAINT [FK_DanhMuc_DanhMuc]
GO
ALTER TABLE [dbo].[GiaoDich_DatCoc]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_DatCoc_NguoiDung] FOREIGN KEY([sdtBan])
REFERENCES [dbo].[NguoiDung] ([SoDienThoai])
GO
ALTER TABLE [dbo].[GiaoDich_DatCoc] CHECK CONSTRAINT [FK_GiaoDich_DatCoc_NguoiDung]
GO
ALTER TABLE [dbo].[GiaoDich_DatCoc]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_DatCoc_NguoiDung1] FOREIGN KEY([sdtMua])
REFERENCES [dbo].[NguoiDung] ([SoDienThoai])
GO
ALTER TABLE [dbo].[GiaoDich_DatCoc] CHECK CONSTRAINT [FK_GiaoDich_DatCoc_NguoiDung1]
GO
ALTER TABLE [dbo].[HinhAnh_BaiDang]  WITH CHECK ADD  CONSTRAINT [FK_HinhAnh_BaiDang_BaiDang] FOREIGN KEY([id_SanPham])
REFERENCES [dbo].[BaiDang] ([id_BaiDang])
GO
ALTER TABLE [dbo].[HinhAnh_BaiDang] CHECK CONSTRAINT [FK_HinhAnh_BaiDang_BaiDang]
GO
USE [master]
GO
ALTER DATABASE [LVTN] SET  READ_WRITE 
GO
