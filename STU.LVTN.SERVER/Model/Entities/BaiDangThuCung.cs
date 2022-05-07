using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangThuCung
    {
        public BaiDangThuCung()
        {
            BaiDangs = new HashSet<BaiDangEntities>();
        }

        public int IdBaiDang { get; set; }
        public string? GiongThuCung { get; set; }
        public string? DoTuoi { get; set; }

        public virtual ICollection<BaiDangEntities> BaiDangs { get; set; }
    }
}
