using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangDoAnThucPham
    {
        public BaiDangDoAnThucPham()
        {
            BaiDangs = new HashSet<BaiDangEntities>();
        }

        public int IdBaiDang { get; set; }
        public string? LoaiThucPham { get; set; }

        public virtual ICollection<BaiDangEntities> BaiDangs { get; set; }
    }
}
