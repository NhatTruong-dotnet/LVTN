using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangThoiTrang
    {
        public BaiDangThoiTrang()
        {
            BaiDangs = new HashSet<BaiDangEntities>();
        }

        public int IdBaiDang { get; set; }
        public bool? DaSuDung { get; set; }
        public string? LoaiSanPham { get; set; }

        public virtual ICollection<BaiDangEntities> BaiDangs { get; set; }
    }
}
