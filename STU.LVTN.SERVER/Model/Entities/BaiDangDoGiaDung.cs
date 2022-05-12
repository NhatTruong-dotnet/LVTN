using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangDoGiaDung
    {
        public int IdBaiDang { get; set; }
        public bool? DaSuDung { get; set; }
        public string? LoaiSanPham { get; set; }
        public string? BanGheChatLieu { get; set; }
        public string? TuKeChatLieu { get; set; }
        public string? GiuongChatLieu { get; set; }
        public string? BepThuongHieu { get; set; }
        public string? QuatThuongHieu { get; set; }
        public string? ThietBiVeSinhThuongHieu { get; set; }
    }
}
