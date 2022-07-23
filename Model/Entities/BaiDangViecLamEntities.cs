using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangViecLamEntities
    {
        public int IdBaiDang { get; set; }
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
    }
}
