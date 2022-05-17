﻿namespace STU.LVTN.SERVER.Model.DTO.DoGiaDung.BanGhe
{
    public class BaiDangDoGiaDungBanGhe_DTO
    {
        #region BaiDang
        public int IdDanhMucCha { get; set; }
        public string? SdtNguoiBan { get; set; }
        public string? SdtNguoiMua { get; set; }
        public bool AnTin { get; set; } = false;
        public bool TrangThai { get; set; } = false;
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
        #endregion

        #region BaiDangDoGiaDung
        public bool? DaSuDung { get; set; }
        public string? LoaiSanPham { get; set; }
        public string? BanGheChatLieu { get; set; }
        #endregion
        public List<HinhAnh_BaiDangDTO> hinhAnh_BaiDangs { get; set; }

    }
}
