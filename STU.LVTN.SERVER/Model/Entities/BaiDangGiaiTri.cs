using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangGiaiTri
    {
        public BaiDangGiaiTri()
        {
            BaiDangs = new HashSet<BaiDangEntities>();
        }

        public int IdBaiDang { get; set; }
        public bool? DaSuDung { get; set; }
        public bool? MienPhi { get; set; }
        public string? NhacCuLoaiNhacCu { get; set; }
        public string? DoSuuTamLoaiSanPham { get; set; }

        public virtual ICollection<BaiDangEntities> BaiDangs { get; set; }
    }
}
