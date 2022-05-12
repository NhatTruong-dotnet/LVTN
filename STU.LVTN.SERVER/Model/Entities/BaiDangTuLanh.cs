using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangTuLanh
    {
        public int IdBaiDang { get; set; }
        public bool? DaSuDung { get; set; }
        public string? Hang { get; set; }
        public string? TuLanhTheTich { get; set; }
        public string? MayLanhCongSuat { get; set; }
        public string? MayGiatCuaMayGiat { get; set; }
        public string? MayGiatKhoiLuongGiat { get; set; }
    }
}
