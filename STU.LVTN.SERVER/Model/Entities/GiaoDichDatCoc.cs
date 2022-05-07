using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class GiaoDichDatCoc
    {
        public int IdDatCoc { get; set; }
        public double? SoTienDatCoc { get; set; }
        public string? SdtBan { get; set; }
        public string? SdtMua { get; set; }
        public bool? GiaoDichThanhCong { get; set; }
        public bool? HuyGiaoDich { get; set; }

        public virtual NguoiDungEntities? SdtBanNavigation { get; set; }
        public virtual NguoiDungEntities? SdtMuaNavigation { get; set; }
    }
}
