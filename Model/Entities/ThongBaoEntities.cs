using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class ThongBaoEntities
    {
        public int IdThongBao { get; set; }
        public string? SdtNguoiDung { get; set; }
        public string? TieuDeThongBao { get; set; }
        public string? Comment { get; set; }
        public bool? Checked { get; set; }
        public int? IDPost { get; set; }
    }
}
