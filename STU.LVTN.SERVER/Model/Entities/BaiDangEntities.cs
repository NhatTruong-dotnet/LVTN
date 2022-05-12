using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangEntities
    {
        public BaiDangEntities()
        {
            HinhAnhBaiDangs = new HashSet<HinhAnhBaiDang>();
        }

        public int IdBaiDang { get; set; }
        public int IdDanhMucCha { get; set; }
        public string? SdtNguoiBan { get; set; }
        public string? SdtNguoiMua { get; set; }
        public bool AnTin { get; set; }
        public bool TrangThai { get; set; }
        public string? ThanhPho { get; set; }
        public string? QuanHuyen { get; set; }
        public string? PhuongXa { get; set; }
        public string? DiaChiCuThe { get; set; }
        public string? TieuDe { get; set; }
        public int? IdBaiDangChiTiet { get; set; }
        public string? TablesDetail { get; set; }
        public int? IdDanhMucCon { get; set; }
        public string? Mota { get; set; }
        public bool? MienPhi { get; set; }
        public double? Gia { get; set; }
        public bool? CaNhan { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual DanhMuc? IdDanhMucConNavigation { get; set; }
        public virtual NguoiDungEntities? SdtNguoiBanNavigation { get; set; }
        public virtual ICollection<HinhAnhBaiDang> HinhAnhBaiDangs { get; set; }
    }
}
