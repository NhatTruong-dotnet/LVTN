using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STU.LVTN.SERVER.Migrations
{
    public partial class DBContextInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaiDang_BatDongSan",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false),
                    TenDuAn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTich = table.Column<double>(type: "float", nullable: true),
                    CC_MaCan = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CC_Block = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CC_TangSo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CC_ChuaBanGiao = table.Column<bool>(type: "bit", nullable: true),
                    CC_LoaiHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CC_SoPhongNgu = table.Column<byte>(type: "tinyint", nullable: true),
                    NhaO_LoaiHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhaO_SoPhongNgu = table.Column<byte>(type: "tinyint", nullable: true),
                    NhaO_SoPhongVeSinh = table.Column<byte>(type: "tinyint", nullable: true),
                    NhaO_TongSoTang = table.Column<byte>(type: "tinyint", nullable: true),
                    NhaO_HemXeHoi = table.Column<bool>(type: "bit", nullable: true),
                    NhaO_NoHau = table.Column<bool>(type: "bit", nullable: true),
                    NhaO_ChieuNgang = table.Column<double>(type: "float", nullable: true),
                    NhaO_ChieuDai = table.Column<double>(type: "float", nullable: true),
                    Dat_LoaiHinhDat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dat_HuongDat = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Dat_MatTien = table.Column<bool>(type: "bit", nullable: true),
                    Dat_HemXeHoi = table.Column<bool>(type: "bit", nullable: true),
                    Dat_NoHau = table.Column<bool>(type: "bit", nullable: true),
                    Dat_ChieuNgang = table.Column<double>(type: "float", nullable: true),
                    Dat_ChieuDai = table.Column<double>(type: "float", nullable: true),
                    VanPhong_MaCan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VanPhong_Block = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    VanPhong_TangSo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    VanPhong_LoaiHinhVanPhong = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PhongTro_TinhTrangNoiThat = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PhongTro_SoTienCoc = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_BatDongSan", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_DoAnThucPham",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiThucPham = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_DoAnThucPham", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_DoDienTu",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaoHanh = table.Column<bool>(type: "bit", nullable: true),
                    DienThoai_Hang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DienThoai_MauSac = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DienThoai_DungLuong = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MayTinhBang_QuocTe = table.Column<bool>(type: "bit", nullable: true),
                    MayTinhBang_4g = table.Column<bool>(type: "bit", nullable: true),
                    MayTinhBang_DungLuong = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MayTinhDeBan_BoViXuly = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MayTinhDeBan_RAM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MayTinhDeBan_OCung = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MayTinhDeBan_HDD = table.Column<bool>(type: "bit", nullable: true),
                    MayTinhDeBan_CardManHinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MayTinhDeBan_KichCoManHinh = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    Laptop_BoViXuly = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Laptop_RAM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Laptop_OCung = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Laptop_HDD = table.Column<bool>(type: "bit", nullable: true),
                    Laptop_CardManHinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Laptop_KichCoManHinh = table.Column<string>(type: "nchar(30)", fixedLength: true, maxLength: 30, nullable: true),
                    Laptop_Hang = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    MayAnh_ThietBi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MayAnh_TinhTrang = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Tivi_ThietBi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tivi_TinhTrang = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ThietBiDeoThongMinh_ThietBi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThietBiDeoThongMinh_TinhTrang = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ThietBiDeoThongMinh_Hang = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    PhuKien_LoaiPhuKien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhuKien_ThietBi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    PhuKien_TinhTrang = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    LinhKien_LoaiPhuKien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LinhKien_ThietBi = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    LinhKien_TinhTrang = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_DoDienTu", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_DoDungVanPhong",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_DoDungVanPhong", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_DoGiaDung",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    LoaiSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BanGhe_ChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TuKe_ChatLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Giuong_ChatLieu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Bep_ThuongHieu = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Quat_ThuongHieu = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    ThietBiVeSinh_ThuongHieu = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_DoGiaDung", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_GiaiTri",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    MienPhi = table.Column<bool>(type: "bit", nullable: true),
                    NhacCu_LoaiNhacCu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DoSuuTam_LoaiSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_GiaiTri", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_MeVaBe",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_MeVaBe", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_ThoiTrang",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    LoaiSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_ThoiTrang", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_ThuCung",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiongThuCung = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DoTuoi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_ThuCung", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_TuLanh",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    Hang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TuLanh_TheTich = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MayLanh_CongSuat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MayGiat_CuaMayGiat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MayGiat_KhoiLuongGiat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_TuLanh", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_ViecLam",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoKinhDoanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongTuyenDung = table.Column<byte>(type: "tinyint", nullable: true),
                    NganhNghe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LoaiCongViec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HinhThucTraLuong = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    LuongToiThieu = table.Column<double>(type: "float", nullable: true),
                    LuongToiDa = table.Column<double>(type: "float", nullable: true),
                    Nam = table.Column<bool>(type: "bit", nullable: true),
                    HocVanToiThieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KinhNghiem = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ChungChi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuyenLoi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_ViecLam", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang_XeCo",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HangXe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nam = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SoKmDaDi = table.Column<double>(type: "float", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: true),
                    DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    Xuatxu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MauSac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BienSoXe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Oto_HopSo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Oto_NhieuLieu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Oto_KieuDang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Oto_Socho = table.Column<byte>(type: "tinyint", nullable: true),
                    XeMay_Dungtich = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    XeTai_TrongTai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    XeTai_NhieuLieu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    XeTai_XuatXu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    XeDien_LoaiXe = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    XeDien_DongCo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    XeDien_DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    XeDien_MienPhi = table.Column<bool>(type: "bit", nullable: true),
                    XeDap_KichThuocKhung = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    XeDap_ChatLuongKhung = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    XeDap_DaSuDung = table.Column<bool>(type: "bit", nullable: true),
                    XeDap_MienPhi = table.Column<bool>(type: "bit", nullable: true),
                    XeDap_BaoHang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PhuongTienKhac_NhienLieu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhuTungXe_LoaiPhuTung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang_XeCo", x => x.id_BaiDang);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    id_DanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_DanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_DanhMucCha = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.id_DanhMuc);
                    table.ForeignKey(
                        name: "FK_DanhMuc_DanhMuc",
                        column: x => x.id_DanhMucCha,
                        principalTable: "DanhMuc",
                        principalColumn: "id_DanhMuc");
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayKetThuc_DichVu = table.Column<DateTime>(type: "datetime", nullable: true),
                    Loai_DichVu = table.Column<byte>(type: "tinyint", nullable: true),
                    So_CMND = table.Column<string>(type: "nchar(12)", fixedLength: true, maxLength: 12, nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: true),
                    Hinh_CMND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSDK_DoanhNghiep = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true),
                    passwordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    passwordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.SoDienThoai);
                });

            migrationBuilder.CreateTable(
                name: "ThuocTinh_DanhMuc",
                columns: table => new
                {
                    id_ThuocTinh = table.Column<int>(type: "int", nullable: false),
                    ten_ThuocTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_DanhMuc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuocTinh_DanhMuc", x => x.id_ThuocTinh);
                });

            migrationBuilder.CreateTable(
                name: "BaiDang",
                columns: table => new
                {
                    id_BaiDang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_DanhMucCha = table.Column<int>(type: "int", nullable: false),
                    Sdt_NguoiBan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Sdt_NguoiMua = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AnTin = table.Column<bool>(type: "bit", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    QuanHuyen = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PhuongXa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DiaChiCuThe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TieuDe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    id_BaiDangChiTiet = table.Column<int>(type: "int", nullable: true),
                    TablesDetail = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    id_DanhMucCon = table.Column<int>(type: "int", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MienPhi = table.Column<bool>(type: "bit", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: true),
                    CaNhan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiDang", x => x.id_BaiDang);
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_BatDongSan",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_BatDongSan",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_DoAnThucPham",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_DoAnThucPham",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_DoDienTu",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_DoDienTu",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_DoDungVanPhong",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_DoDungVanPhong",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_DoGiaDung",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_DoGiaDung",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_GiaiTri",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_GiaiTri",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_MeVaBe",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_MeVaBe",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_ThoiTrang",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_ThoiTrang",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_ThuCung",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_ThuCung",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_TuLanh",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_TuLanh",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_ViecLam",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_ViecLam",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_BaiDang_XeCo",
                        column: x => x.id_BaiDangChiTiet,
                        principalTable: "BaiDang_XeCo",
                        principalColumn: "id_BaiDang");
                    table.ForeignKey(
                        name: "FK_BaiDang_DanhMuc",
                        column: x => x.id_DanhMucCon,
                        principalTable: "DanhMuc",
                        principalColumn: "id_DanhMuc");
                    table.ForeignKey(
                        name: "FK_BaiDang_NguoiDung",
                        column: x => x.Sdt_NguoiBan,
                        principalTable: "NguoiDung",
                        principalColumn: "SoDienThoai");
                });

            migrationBuilder.CreateTable(
                name: "GiaoDich_DatCoc",
                columns: table => new
                {
                    idDatCoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoTienDatCoc = table.Column<double>(type: "float", nullable: true),
                    sdtBan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    sdtMua = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    giaoDichThanhCong = table.Column<bool>(type: "bit", nullable: true),
                    huyGiaoDich = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoDich_DatCoc", x => x.idDatCoc);
                    table.ForeignKey(
                        name: "FK_GiaoDich_DatCoc_NguoiDung",
                        column: x => x.sdtBan,
                        principalTable: "NguoiDung",
                        principalColumn: "SoDienThoai");
                    table.ForeignKey(
                        name: "FK_GiaoDich_DatCoc_NguoiDung1",
                        column: x => x.sdtMua,
                        principalTable: "NguoiDung",
                        principalColumn: "SoDienThoai");
                });

            migrationBuilder.CreateTable(
                name: "HinhAnh_BaiDang",
                columns: table => new
                {
                    id_HinhAnh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMediaCloud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_SanPham = table.Column<int>(type: "int", nullable: false),
                    videoType = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh_BaiDang", x => x.id_HinhAnh);
                    table.ForeignKey(
                        name: "FK_HinhAnh_BaiDang_BaiDang",
                        column: x => x.id_SanPham,
                        principalTable: "BaiDang",
                        principalColumn: "id_BaiDang");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiDang_id_BaiDangChiTiet",
                table: "BaiDang",
                column: "id_BaiDangChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_BaiDang_id_DanhMucCon",
                table: "BaiDang",
                column: "id_DanhMucCon");

            migrationBuilder.CreateIndex(
                name: "IX_BaiDang_Sdt_NguoiBan",
                table: "BaiDang",
                column: "Sdt_NguoiBan");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_id_DanhMucCha",
                table: "DanhMuc",
                column: "id_DanhMucCha");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDich_DatCoc_sdtBan",
                table: "GiaoDich_DatCoc",
                column: "sdtBan");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDich_DatCoc_sdtMua",
                table: "GiaoDich_DatCoc",
                column: "sdtMua");

            migrationBuilder.CreateIndex(
                name: "IX_HinhAnh_BaiDang_id_SanPham",
                table: "HinhAnh_BaiDang",
                column: "id_SanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaoDich_DatCoc");

            migrationBuilder.DropTable(
                name: "HinhAnh_BaiDang");

            migrationBuilder.DropTable(
                name: "ThuocTinh_DanhMuc");

            migrationBuilder.DropTable(
                name: "BaiDang");

            migrationBuilder.DropTable(
                name: "BaiDang_BatDongSan");

            migrationBuilder.DropTable(
                name: "BaiDang_DoAnThucPham");

            migrationBuilder.DropTable(
                name: "BaiDang_DoDienTu");

            migrationBuilder.DropTable(
                name: "BaiDang_DoDungVanPhong");

            migrationBuilder.DropTable(
                name: "BaiDang_DoGiaDung");

            migrationBuilder.DropTable(
                name: "BaiDang_GiaiTri");

            migrationBuilder.DropTable(
                name: "BaiDang_MeVaBe");

            migrationBuilder.DropTable(
                name: "BaiDang_ThoiTrang");

            migrationBuilder.DropTable(
                name: "BaiDang_ThuCung");

            migrationBuilder.DropTable(
                name: "BaiDang_TuLanh");

            migrationBuilder.DropTable(
                name: "BaiDang_ViecLam");

            migrationBuilder.DropTable(
                name: "BaiDang_XeCo");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "NguoiDung");
        }
    }
}
