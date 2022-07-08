using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class NguoiDungEntities
    {
        public NguoiDungEntities()
        {
            BaiDangs = new HashSet<BaiDangEntities>();
            GiaoDichDatCocSdtBanNavigations = new HashSet<GiaoDichDatCoc>();
            GiaoDichDatCocSdtMuaNavigations = new HashSet<GiaoDichDatCoc>();
        }

        public string SoDienThoai { get; set; } = null!;
        public string? Ten { get; set; }
        public DateTime? NgayKetThucDichVu { get; set; }
        public byte? LoaiDichVu { get; set; }
        public string? SoCmnd { get; set; }
        public string? DiaChi { get; set; }
        public string? DanhGiaHeThong { get; set; }
        public bool? Admin { get; set; }
        public string? HinhCmnd { get; set; }
        public string? MsdkDoanhNghiep { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public DateTime? CreatedDate { get; set; }= DateTime.Now;
        public string? AnhDaiDienSource { get; set; }
        public bool? Active { get; set; }
        public DateTime? LockTime { get; set; }
        public virtual ICollection<BaiDangEntities> BaiDangs { get; set; }
        public virtual ICollection<GiaoDichDatCoc> GiaoDichDatCocSdtBanNavigations { get; set; }
        public virtual ICollection<GiaoDichDatCoc> GiaoDichDatCocSdtMuaNavigations { get; set; }
    }
}
