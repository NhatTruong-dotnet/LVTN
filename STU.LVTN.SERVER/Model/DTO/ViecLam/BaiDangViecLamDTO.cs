namespace STU.LVTN.SERVER.Model.DTO.ViecLam
{
    public class BaiDangViecLamDTO
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

        #region BaiDangViecLam
        public string? TenHoKinhDoanh { get; set; }
        public byte? SoLuongTuyenDung { get; set; }
        public string? NganhNghe { get; set; }
        public string? LoaiCongViec { get; set; }
        public string? HinhThucTraLuong { get; set; }
        public double? LuongToiThieu { get; set; }
        public double? LuongToiDa { get; set; }
        public bool? Nam { get; set; }
        public string? HocVanToiThieu { get; set; }
        public string? KinhNghiem { get; set; }
        public string? ChungChi { get; set; }
        public string? QuyenLoi { get; set; }
        #endregion
        public List<HinhAnh_BaiDangDTO> hinhAnh_BaiDangs { get; set; }

    }
}
