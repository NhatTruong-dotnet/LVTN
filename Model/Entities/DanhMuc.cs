using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            BaiDangs = new HashSet<BaiDangEntities>();
            InverseIdDanhMucChaNavigation = new HashSet<DanhMuc>();
        }

        public int IdDanhMuc { get; set; }
        public string TenDanhMuc { get; set; } = null!;
        public int? IdDanhMucCha { get; set; }

        public virtual DanhMuc? IdDanhMucChaNavigation { get; set; }
        public virtual ICollection<BaiDangEntities> BaiDangs { get; set; }
        public virtual ICollection<DanhMuc> InverseIdDanhMucChaNavigation { get; set; }
    }
}
