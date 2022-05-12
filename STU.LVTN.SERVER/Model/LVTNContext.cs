using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace STU.LVTN.SERVER.Model
{
    public partial class LVTNContext : DbContext
    {
        public LVTNContext()
        {
        }

        public LVTNContext(DbContextOptions<LVTNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaiDangEntities> BaiDangs { get; set; } = null!;
        public virtual DbSet<BaiDangBatDongSanEntities> BaiDangBatDongSans { get; set; } = null!;
        public virtual DbSet<BaiDangDoAnThucPham> BaiDangDoAnThucPhams { get; set; } = null!;
        public virtual DbSet<BaiDangDoDienTu> BaiDangDoDienTus { get; set; } = null!;
        public virtual DbSet<BaiDangDoDungVanPhong> BaiDangDoDungVanPhongs { get; set; } = null!;
        public virtual DbSet<BaiDangDoGiaDung> BaiDangDoGiaDungs { get; set; } = null!;
        public virtual DbSet<BaiDangGiaiTri> BaiDangGiaiTris { get; set; } = null!;
        public virtual DbSet<BaiDangMeVaBe> BaiDangMeVaBes { get; set; } = null!;
        public virtual DbSet<BaiDangThoiTrang> BaiDangThoiTrangs { get; set; } = null!;
        public virtual DbSet<BaiDangThuCung> BaiDangThuCungs { get; set; } = null!;
        public virtual DbSet<BaiDangTuLanh> BaiDangTuLanhs { get; set; } = null!;
        public virtual DbSet<BaiDangViecLam> BaiDangViecLams { get; set; } = null!;
        public virtual DbSet<BaiDangXeCo> BaiDangXeCos { get; set; } = null!;
        public virtual DbSet<DanhMuc> DanhMucs { get; set; } = null!;
        public virtual DbSet<GiaoDichDatCoc> GiaoDichDatCocs { get; set; } = null!;
        public virtual DbSet<HinhAnhBaiDang> HinhAnhBaiDangs { get; set; } = null!;
        public virtual DbSet<NguoiDungEntities> NguoiDungs { get; set; } = null!;
        public virtual DbSet<ThuocTinhDanhMuc> ThuocTinhDanhMucs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=LVTN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiDangEntities>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.DiaChiCuThe).HasMaxLength(150);

                entity.Property(e => e.IdBaiDangChiTiet).HasColumnName("id_BaiDangChiTiet");

                entity.Property(e => e.IdDanhMucCha).HasColumnName("id_DanhMucCha");

                entity.Property(e => e.IdDanhMucCon).HasColumnName("id_DanhMucCon");

                entity.Property(e => e.PhuongXa).HasMaxLength(150);

                entity.Property(e => e.QuanHuyen).HasMaxLength(150);

                entity.Property(e => e.SdtNguoiBan)
                    .HasMaxLength(10)
                    .HasColumnName("Sdt_NguoiBan");

                entity.Property(e => e.SdtNguoiMua)
                    .HasMaxLength(10)
                    .HasColumnName("Sdt_NguoiMua");

                entity.Property(e => e.TablesDetail)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ThanhPho).HasMaxLength(150);

                entity.Property(e => e.TieuDe).HasMaxLength(150);

                entity.HasOne(d => d.IdDanhMucConNavigation)
                    .WithMany(p => p.BaiDangs)
                    .HasForeignKey(d => d.IdDanhMucCon)
                    .HasConstraintName("FK_BaiDang_DanhMuc");

                entity.HasOne(d => d.SdtNguoiBanNavigation)
                    .WithMany(p => p.BaiDangs)
                    .HasForeignKey(d => d.SdtNguoiBan)
                    .HasConstraintName("FK_BaiDang_NguoiDung");
            });

            modelBuilder.Entity<BaiDangBatDongSanEntities>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_BatDongSan");

                entity.Property(e => e.IdBaiDang)
                    .ValueGeneratedNever()
                    .HasColumnName("id_BaiDang");

                entity.Property(e => e.CcBlock)
                    .HasMaxLength(10)
                    .HasColumnName("CC_Block")
                    .IsFixedLength();

                entity.Property(e => e.CcChuaBanGiao).HasColumnName("CC_ChuaBanGiao");

                entity.Property(e => e.CcLoaiHinh).HasColumnName("CC_LoaiHinh");

                entity.Property(e => e.CcMaCan)
                    .HasMaxLength(10)
                    .HasColumnName("CC_MaCan")
                    .IsFixedLength();

                entity.Property(e => e.CcSoPhongNgu).HasColumnName("CC_SoPhongNgu");

                entity.Property(e => e.CcTangSo)
                    .HasMaxLength(10)
                    .HasColumnName("CC_TangSo")
                    .IsFixedLength();

                entity.Property(e => e.DatChieuDai).HasColumnName("Dat_ChieuDai");

                entity.Property(e => e.DatChieuNgang).HasColumnName("Dat_ChieuNgang");

                entity.Property(e => e.DatHemXeHoi).HasColumnName("Dat_HemXeHoi");

                entity.Property(e => e.DatHuongDat)
                    .HasMaxLength(40)
                    .HasColumnName("Dat_HuongDat");

                entity.Property(e => e.DatLoaiHinhDat).HasColumnName("Dat_LoaiHinhDat");

                entity.Property(e => e.DatMatTien).HasColumnName("Dat_MatTien");

                entity.Property(e => e.DatNoHau).HasColumnName("Dat_NoHau");

                entity.Property(e => e.NhaOChieuDai).HasColumnName("NhaO_ChieuDai");

                entity.Property(e => e.NhaOChieuNgang).HasColumnName("NhaO_ChieuNgang");

                entity.Property(e => e.NhaOHemXeHoi).HasColumnName("NhaO_HemXeHoi");

                entity.Property(e => e.NhaOLoaiHinh).HasColumnName("NhaO_LoaiHinh");

                entity.Property(e => e.NhaONoHau).HasColumnName("NhaO_NoHau");

                entity.Property(e => e.NhaOSoPhongNgu).HasColumnName("NhaO_SoPhongNgu");

                entity.Property(e => e.NhaOSoPhongVeSinh).HasColumnName("NhaO_SoPhongVeSinh");

                entity.Property(e => e.NhaOTongSoTang).HasColumnName("NhaO_TongSoTang");

                entity.Property(e => e.PhongTroSoTienCoc).HasColumnName("PhongTro_SoTienCoc");

                entity.Property(e => e.PhongTroTinhTrangNoiThat)
                    .HasMaxLength(60)
                    .HasColumnName("PhongTro_TinhTrangNoiThat");

                entity.Property(e => e.VanPhongBlock)
                    .HasMaxLength(10)
                    .HasColumnName("VanPhong_Block")
                    .IsFixedLength();

                entity.Property(e => e.VanPhongLoaiHinhVanPhong)
                    .HasMaxLength(60)
                    .HasColumnName("VanPhong_LoaiHinhVanPhong");

                entity.Property(e => e.VanPhongMaCan)
                    .HasMaxLength(50)
                    .HasColumnName("VanPhong_MaCan");

                entity.Property(e => e.VanPhongTangSo)
                    .HasMaxLength(10)
                    .HasColumnName("VanPhong_TangSo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<BaiDangDoAnThucPham>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_DoAnThucPham");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.LoaiThucPham).HasMaxLength(150);
            });

            modelBuilder.Entity<BaiDangDoDienTu>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_DoDienTu");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.DienThoaiDungLuong)
                    .HasMaxLength(15)
                    .HasColumnName("DienThoai_DungLuong");

                entity.Property(e => e.DienThoaiHang)
                    .HasMaxLength(50)
                    .HasColumnName("DienThoai_Hang");

                entity.Property(e => e.DienThoaiMauSac)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DienThoai_MauSac");

                entity.Property(e => e.LaptopBoViXuly)
                    .HasMaxLength(15)
                    .HasColumnName("Laptop_BoViXuly");

                entity.Property(e => e.LaptopCardManHinh)
                    .HasMaxLength(10)
                    .HasColumnName("Laptop_CardManHinh")
                    .IsFixedLength();

                entity.Property(e => e.LaptopHang)
                    .HasMaxLength(20)
                    .HasColumnName("Laptop_Hang")
                    .IsFixedLength();

                entity.Property(e => e.LaptopHdd).HasColumnName("Laptop_HDD");

                entity.Property(e => e.LaptopKichCoManHinh)
                    .HasMaxLength(30)
                    .HasColumnName("Laptop_KichCoManHinh")
                    .IsFixedLength();

                entity.Property(e => e.LaptopOcung)
                    .HasMaxLength(20)
                    .HasColumnName("Laptop_OCung");

                entity.Property(e => e.LaptopRam)
                    .HasMaxLength(20)
                    .HasColumnName("Laptop_RAM");

                entity.Property(e => e.LinhKienLoaiPhuKien)
                    .HasMaxLength(50)
                    .HasColumnName("LinhKien_LoaiPhuKien");

                entity.Property(e => e.LinhKienThietBi)
                    .HasMaxLength(80)
                    .HasColumnName("LinhKien_ThietBi");

                entity.Property(e => e.LinhKienTinhTrang)
                    .HasMaxLength(80)
                    .HasColumnName("LinhKien_TinhTrang");

                entity.Property(e => e.MayAnhThietBi)
                    .HasMaxLength(50)
                    .HasColumnName("MayAnh_ThietBi");

                entity.Property(e => e.MayAnhTinhTrang)
                    .HasMaxLength(80)
                    .HasColumnName("MayAnh_TinhTrang");

                entity.Property(e => e.MayTinhBang4g).HasColumnName("MayTinhBang_4g");

                entity.Property(e => e.MayTinhBangDungLuong)
                    .HasMaxLength(15)
                    .HasColumnName("MayTinhBang_DungLuong");

                entity.Property(e => e.MayTinhBangQuocTe).HasColumnName("MayTinhBang_QuocTe");

                entity.Property(e => e.MayTinhDeBanBoViXuly)
                    .HasMaxLength(15)
                    .HasColumnName("MayTinhDeBan_BoViXuly");

                entity.Property(e => e.MayTinhDeBanCardManHinh)
                    .HasMaxLength(10)
                    .HasColumnName("MayTinhDeBan_CardManHinh")
                    .IsFixedLength();

                entity.Property(e => e.MayTinhDeBanHdd).HasColumnName("MayTinhDeBan_HDD");

                entity.Property(e => e.MayTinhDeBanKichCoManHinh)
                    .HasMaxLength(30)
                    .HasColumnName("MayTinhDeBan_KichCoManHinh")
                    .IsFixedLength();

                entity.Property(e => e.MayTinhDeBanOcung)
                    .HasMaxLength(20)
                    .HasColumnName("MayTinhDeBan_OCung");

                entity.Property(e => e.MayTinhDeBanRam)
                    .HasMaxLength(20)
                    .HasColumnName("MayTinhDeBan_RAM");

                entity.Property(e => e.PhuKienLoaiPhuKien)
                    .HasMaxLength(50)
                    .HasColumnName("PhuKien_LoaiPhuKien");

                entity.Property(e => e.PhuKienThietBi)
                    .HasMaxLength(80)
                    .HasColumnName("PhuKien_ThietBi");

                entity.Property(e => e.PhuKienTinhTrang)
                    .HasMaxLength(80)
                    .HasColumnName("PhuKien_TinhTrang");

                entity.Property(e => e.ThietBiDeoThongMinhHang)
                    .HasMaxLength(80)
                    .HasColumnName("ThietBiDeoThongMinh_Hang");

                entity.Property(e => e.ThietBiDeoThongMinhThietBi)
                    .HasMaxLength(50)
                    .HasColumnName("ThietBiDeoThongMinh_ThietBi");

                entity.Property(e => e.ThietBiDeoThongMinhTinhTrang)
                    .HasMaxLength(80)
                    .HasColumnName("ThietBiDeoThongMinh_TinhTrang");

                entity.Property(e => e.TiviThietBi)
                    .HasMaxLength(50)
                    .HasColumnName("Tivi_ThietBi");

                entity.Property(e => e.TiviTinhTrang)
                    .HasMaxLength(80)
                    .HasColumnName("Tivi_TinhTrang");
            });

            modelBuilder.Entity<BaiDangDoDungVanPhong>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_DoDungVanPhong");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");
            });

            modelBuilder.Entity<BaiDangDoGiaDung>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_DoGiaDung");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.BanGheChatLieu)
                    .HasMaxLength(50)
                    .HasColumnName("BanGhe_ChatLieu");

                entity.Property(e => e.BepThuongHieu)
                    .HasMaxLength(75)
                    .HasColumnName("Bep_ThuongHieu");

                entity.Property(e => e.GiuongChatLieu)
                    .HasMaxLength(150)
                    .HasColumnName("Giuong_ChatLieu");

                entity.Property(e => e.LoaiSanPham).HasMaxLength(100);

                entity.Property(e => e.QuatThuongHieu)
                    .HasMaxLength(75)
                    .HasColumnName("Quat_ThuongHieu");

                entity.Property(e => e.ThietBiVeSinhThuongHieu)
                    .HasMaxLength(75)
                    .HasColumnName("ThietBiVeSinh_ThuongHieu");

                entity.Property(e => e.TuKeChatLieu)
                    .HasMaxLength(50)
                    .HasColumnName("TuKe_ChatLieu");
            });

            modelBuilder.Entity<BaiDangGiaiTri>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_GiaiTri");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.DoSuuTamLoaiSanPham)
                    .HasMaxLength(100)
                    .HasColumnName("DoSuuTam_LoaiSanPham");

                entity.Property(e => e.NhacCuLoaiNhacCu)
                    .HasMaxLength(100)
                    .HasColumnName("NhacCu_LoaiNhacCu");
            });

            modelBuilder.Entity<BaiDangMeVaBe>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_MeVaBe");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");
            });

            modelBuilder.Entity<BaiDangThoiTrang>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_ThoiTrang");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.LoaiSanPham).HasMaxLength(100);
            });

            modelBuilder.Entity<BaiDangThuCung>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_ThuCung");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.DoTuoi).HasMaxLength(30);

                entity.Property(e => e.GiongThuCung).HasMaxLength(250);
            });

            modelBuilder.Entity<BaiDangTuLanh>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_TuLanh");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.Hang).HasMaxLength(100);

                entity.Property(e => e.MayGiatCuaMayGiat)
                    .HasMaxLength(50)
                    .HasColumnName("MayGiat_CuaMayGiat");

                entity.Property(e => e.MayGiatKhoiLuongGiat)
                    .HasMaxLength(50)
                    .HasColumnName("MayGiat_KhoiLuongGiat");

                entity.Property(e => e.MayLanhCongSuat)
                    .HasMaxLength(50)
                    .HasColumnName("MayLanh_CongSuat");

                entity.Property(e => e.TuLanhTheTich)
                    .HasMaxLength(50)
                    .HasColumnName("TuLanh_TheTich");
            });

            modelBuilder.Entity<BaiDangViecLam>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_ViecLam");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.ChungChi).HasMaxLength(50);

                entity.Property(e => e.HinhThucTraLuong).HasMaxLength(75);

                entity.Property(e => e.HocVanToiThieu).HasMaxLength(50);

                entity.Property(e => e.KinhNghiem).HasMaxLength(20);

                entity.Property(e => e.LoaiCongViec).HasMaxLength(100);

                entity.Property(e => e.NganhNghe).HasMaxLength(150);
            });

            modelBuilder.Entity<BaiDangXeCo>(entity =>
            {
                entity.HasKey(e => e.IdBaiDang);

                entity.ToTable("BaiDang_XeCo");

                entity.Property(e => e.IdBaiDang).HasColumnName("id_BaiDang");

                entity.Property(e => e.BienSoXe).HasMaxLength(50);

                entity.Property(e => e.HangXe).HasMaxLength(50);

                entity.Property(e => e.MauSac).HasMaxLength(50);

                entity.Property(e => e.Nam)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtoHopSo)
                    .HasMaxLength(50)
                    .HasColumnName("Oto_HopSo");

                entity.Property(e => e.OtoKieuDang)
                    .HasMaxLength(50)
                    .HasColumnName("Oto_KieuDang");

                entity.Property(e => e.OtoNhieuLieu)
                    .HasMaxLength(50)
                    .HasColumnName("Oto_NhieuLieu");

                entity.Property(e => e.OtoSocho).HasColumnName("Oto_Socho");

                entity.Property(e => e.PhuTungXeLoaiPhuTung)
                    .HasMaxLength(50)
                    .HasColumnName("PhuTungXe_LoaiPhuTung");

                entity.Property(e => e.PhuongTienKhacNhienLieu)
                    .HasMaxLength(20)
                    .HasColumnName("PhuongTienKhac_NhienLieu");

                entity.Property(e => e.XeDapBaoHang)
                    .HasMaxLength(30)
                    .HasColumnName("XeDap_BaoHang");

                entity.Property(e => e.XeDapChatLuongKhung)
                    .HasMaxLength(20)
                    .HasColumnName("XeDap_ChatLuongKhung");

                entity.Property(e => e.XeDapDaSuDung).HasColumnName("XeDap_DaSuDung");

                entity.Property(e => e.XeDapKichThuocKhung)
                    .HasMaxLength(20)
                    .HasColumnName("XeDap_KichThuocKhung");

                entity.Property(e => e.XeDapMienPhi).HasColumnName("XeDap_MienPhi");

                entity.Property(e => e.XeDienDaSuDung).HasColumnName("XeDien_DaSuDung");

                entity.Property(e => e.XeDienDongCo)
                    .HasMaxLength(50)
                    .HasColumnName("XeDien_DongCo");

                entity.Property(e => e.XeDienLoaiXe)
                    .HasMaxLength(40)
                    .HasColumnName("XeDien_LoaiXe");

                entity.Property(e => e.XeDienMienPhi).HasColumnName("XeDien_MienPhi");

                entity.Property(e => e.XeMayDungtich)
                    .HasMaxLength(50)
                    .HasColumnName("XeMay_Dungtich");

                entity.Property(e => e.XeTaiNhieuLieu)
                    .HasMaxLength(30)
                    .HasColumnName("XeTai_NhieuLieu");

                entity.Property(e => e.XeTaiTrongTai)
                    .HasMaxLength(30)
                    .HasColumnName("XeTai_TrongTai");

                entity.Property(e => e.XeTaiXuatXu)
                    .HasMaxLength(50)
                    .HasColumnName("XeTai_XuatXu");

                entity.Property(e => e.Xuatxu).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.IdDanhMuc);

                entity.ToTable("DanhMuc");

                entity.Property(e => e.IdDanhMuc).HasColumnName("id_DanhMuc");

                entity.Property(e => e.IdDanhMucCha).HasColumnName("id_DanhMucCha");

                entity.Property(e => e.TenDanhMuc).HasColumnName("ten_DanhMuc");

                entity.HasOne(d => d.IdDanhMucChaNavigation)
                    .WithMany(p => p.InverseIdDanhMucChaNavigation)
                    .HasForeignKey(d => d.IdDanhMucCha)
                    .HasConstraintName("FK_DanhMuc_DanhMuc");
            });

            modelBuilder.Entity<GiaoDichDatCoc>(entity =>
            {
                entity.HasKey(e => e.IdDatCoc);

                entity.ToTable("GiaoDich_DatCoc");

                entity.Property(e => e.IdDatCoc).HasColumnName("idDatCoc");

                entity.Property(e => e.GiaoDichThanhCong).HasColumnName("giaoDichThanhCong");

                entity.Property(e => e.HuyGiaoDich).HasColumnName("huyGiaoDich");

                entity.Property(e => e.SdtBan)
                    .HasMaxLength(10)
                    .HasColumnName("sdtBan");

                entity.Property(e => e.SdtMua)
                    .HasMaxLength(10)
                    .HasColumnName("sdtMua");

                entity.HasOne(d => d.SdtBanNavigation)
                    .WithMany(p => p.GiaoDichDatCocSdtBanNavigations)
                    .HasForeignKey(d => d.SdtBan)
                    .HasConstraintName("FK_GiaoDich_DatCoc_NguoiDung");

                entity.HasOne(d => d.SdtMuaNavigation)
                    .WithMany(p => p.GiaoDichDatCocSdtMuaNavigations)
                    .HasForeignKey(d => d.SdtMua)
                    .HasConstraintName("FK_GiaoDich_DatCoc_NguoiDung1");
            });

            modelBuilder.Entity<HinhAnhBaiDang>(entity =>
            {
                entity.HasKey(e => e.IdHinhAnh);

                entity.ToTable("HinhAnh_BaiDang");

                entity.Property(e => e.IdHinhAnh).HasColumnName("id_HinhAnh");

                entity.Property(e => e.IdMediaCloud).HasColumnName("idMediaCloud");

                entity.Property(e => e.IdSanPham).HasColumnName("id_SanPham");

                entity.Property(e => e.VideoType).HasColumnName("videoType");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HinhAnhBaiDangs)
                    .HasForeignKey(d => d.IdSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HinhAnh_BaiDang_BaiDang");
            });

            modelBuilder.Entity<NguoiDungEntities>(entity =>
            {
                entity.HasKey(e => e.SoDienThoai);

                entity.ToTable("NguoiDung");

                entity.Property(e => e.SoDienThoai).HasMaxLength(10);

                entity.Property(e => e.HinhCmnd).HasColumnName("Hinh_CMND");

                entity.Property(e => e.LoaiDichVu).HasColumnName("Loai_DichVu");

                entity.Property(e => e.MsdkDoanhNghiep)
                    .HasMaxLength(20)
                    .HasColumnName("MSDK_DoanhNghiep")
                    .IsFixedLength();

                entity.Property(e => e.NgayKetThucDichVu)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKetThuc_DichVu");

                entity.Property(e => e.PasswordHash).HasColumnName("passwordHash");

                entity.Property(e => e.PasswordSalt).HasColumnName("passwordSalt");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(12)
                    .HasColumnName("So_CMND")
                    .IsFixedLength();

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<ThuocTinhDanhMuc>(entity =>
            {
                entity.HasKey(e => e.IdThuocTinh);

                entity.ToTable("ThuocTinh_DanhMuc");

                entity.Property(e => e.IdThuocTinh)
                    .ValueGeneratedNever()
                    .HasColumnName("id_ThuocTinh");

                entity.Property(e => e.IdDanhMuc).HasColumnName("id_DanhMuc");

                entity.Property(e => e.TenThuocTinh).HasColumnName("ten_ThuocTinh");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
