using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class HinhAnhBaiDang
    {
        public int IdHinhAnh { get; set; }
        public string IdMediaCloud { get; set; } = null!;
        public int IdSanPham { get; set; }
        public bool? VideoType { get; set; }

        public virtual BaiDangEntities IdSanPhamNavigation { get; set; } = null!;
    }
}
