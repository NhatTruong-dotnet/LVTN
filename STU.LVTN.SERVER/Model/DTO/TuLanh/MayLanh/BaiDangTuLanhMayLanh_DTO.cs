﻿namespace STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh
{
    public class BaiDangTuLanhMayLanh_DTO
    {
        #region BaiDang
        public int? IdBaiDang { get; set; }
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
        public bool? isReviewed { get; set; } = false;
        #endregion

        #region BaiDangMayLanh
        public bool? DaSuDung { get; set; }
        public string? Hang { get; set; }
        public string? MayLanhCongSuat { get; set; }
        #endregion
        public List<HinhAnh_BaiDangDTO> hinhAnh_BaiDangs { get; set; }

    }
}
