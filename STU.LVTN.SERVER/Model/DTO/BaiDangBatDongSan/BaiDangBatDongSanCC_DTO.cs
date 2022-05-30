﻿namespace STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan
{
    public class BaiDangBatDongSanCC_DTO
    {
        public int IdDanhMucCha { get; set; }
        public string? SdtNguoiBan { get; set; }
        public string? SdtNguoiMua { get; set; }
        public bool AnTin { get; set; } = false;
        public bool CanBan { get; set; } = false;
        public bool TrangThai { get; set; } = false ;
        public string? ThanhPho { get; set; }
        public string? QuanHuyen { get; set; }
        public string? PhuongXa { get; set; }
        public string? DiaChiCuThe { get; set; }
        public string? TieuDe { get; set; }
        public int? IdBaiDangChiTiet { get; set; }
        public string? TablesDetail { get; set; }
        public int? IdDanhMucCon { get; set; }
        public string? Mota { get; set; }
        public bool? MienPhi { get; set; }
        public double? Gia { get; set; }
        public bool? CaNhan { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string? TenDuAn { get; set; }
        public double? DienTich { get; set; }
        public string MaCan { get; set; }
        public string Block { get; set; }
        public string TangSo { get; set; }
        public bool ChuaBanGiao { get; set; }
        public string LoaiHinh { get; set; }
        public int SoPhongNgu { get; set; }
        public string? CcHuongCuaChinh { get; set; }
        public string? CcBanCong { get; set; }
        public string? CcGiayToPhapLy { get; set; }
        public string? CcTinhTrangNoiThat { get; set; }
        public float? SoTienCoc { get; set; }
        public bool? isReviewed { get; set; } = false;
        public List<HinhAnh_BaiDangDTO> hinhAnh_BaiDangs { get; set; }
         
    }
}
