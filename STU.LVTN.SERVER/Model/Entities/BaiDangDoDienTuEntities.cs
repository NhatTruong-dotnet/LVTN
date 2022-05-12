using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangDoDienTuEntities
    {
        public int IdBaiDang { get; set; }
        public bool? BaoHanh { get; set; }
        public string? TinhTrang { get; set; }
        public string? DienThoaiHang { get; set; }
        public string? DienThoaiMauSac { get; set; }
        public string? DienThoaiDungLuong { get; set; }
        public bool? MayTinhBangQuocTe { get; set; }
        public bool? MayTinhBang4g { get; set; }
        public string? MayTinhBangDungLuong { get; set; }
        public string? MayTinhDeBanBoViXuly { get; set; }
        public string? MayTinhDeBanRam { get; set; }
        public string? MayTinhDeBanOcung { get; set; }
        public bool? MayTinhDeBanHdd { get; set; }
        public string? MayTinhDeBanCardManHinh { get; set; }
        public string? MayTinhDeBanKichCoManHinh { get; set; }
        public string? LaptopBoViXuly { get; set; }
        public string? LaptopRam { get; set; }
        public string? LaptopOcung { get; set; }
        public bool? LaptopHdd { get; set; }
        public string? LaptopCardManHinh { get; set; }
        public string? LaptopKichCoManHinh { get; set; }
        public string? LaptopHang { get; set; }
        public string? MayAnhThietBi { get; set; }
        public string? MayAnhTinhTrang { get; set; }
        public string? TiviThietBi { get; set; }
        public string? TiviTinhTrang { get; set; }
        public string? ThietBiDeoThongMinhThietBi { get; set; }
        public string? ThietBiDeoThongMinhTinhTrang { get; set; }
        public string? ThietBiDeoThongMinhHang { get; set; }
        public string? PhuKienLoaiPhuKien { get; set; }
        public string? PhuKienThietBi { get; set; }
        public string? PhuKienTinhTrang { get; set; }
        public string? LinhKienLoaiPhuKien { get; set; }
        public string? LinhKienThietBi { get; set; }
        public string? LinhKienTinhTrang { get; set; }
    }
}
