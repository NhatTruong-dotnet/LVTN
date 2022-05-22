namespace STU.LVTN.SERVER.Model.DTO.DoDienTu
{
    public class BaiDangDoDienTuMayTinhDeBan_DTO
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

        #region BaiDangMayTinhDeBan
        public bool? BaoHanh { get; set; }
        public string? TinhTrang { get; set; }
        public string? MayTinhDeBanBoViXuly { get; set; }
        public string? MayTinhDeBanRam { get; set; }
        public string? MayTinhDeBanOcung { get; set; }
        public bool? MayTinhDeBanHdd { get; set; }
        public string? MayTinhDeBanCardManHinh { get; set; }
        public string? MayTinhDeBanKichCoManHinh { get; set; }
        public bool? MayTinhDeBanMienPhi { get; set; }

        #endregion
        public List<HinhAnh_BaiDangDTO> hinhAnh_BaiDangs { get; set; }

    }
}
