using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class ThuocTinhDanhMuc
    {
        public int IdThuocTinh { get; set; }
        public string TenThuocTinh { get; set; } = null!;
        public int IdDanhMuc { get; set; }
    }
}
