using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangBatDongSanEntities
    {
        public int IdBaiDang { get; set; }
        public string? TenDuAn { get; set; }
        public double? DienTich { get; set; }
        public string? CcMaCan { get; set; }
        public string? CcBlock { get; set; }
        public string? CcTangSo { get; set; }
        public bool? CcChuaBanGiao { get; set; }
        public string? CcLoaiHinh { get; set; }
        public byte? CcSoPhongNgu { get; set; }
        public string? NhaOLoaiHinh { get; set; }
        public byte? NhaOSoPhongNgu { get; set; }
        public byte? NhaOSoPhongVeSinh { get; set; }
        public byte? NhaOTongSoTang { get; set; }
        public bool? NhaOHemXeHoi { get; set; }
        public bool? NhaONoHau { get; set; }
        public double? NhaOChieuNgang { get; set; }
        public double? NhaOChieuDai { get; set; }
        public string? DatLoaiHinhDat { get; set; }
        public string? DatHuongDat { get; set; }
        public bool? DatMatTien { get; set; }
        public bool? DatHemXeHoi { get; set; }
        public bool? DatNoHau { get; set; }
        public double? DatChieuNgang { get; set; }
        public double? DatChieuDai { get; set; }
        public string? VanPhongMaCan { get; set; }
        public string? VanPhongBlock { get; set; }
        public string? VanPhongTangSo { get; set; }
        public string? VanPhongLoaiHinhVanPhong { get; set; }
        public string? PhongTroTinhTrangNoiThat { get; set; }
        public double? PhongTroSoTienCoc { get; set; }
        public bool? CanBan { get; set; }
    }
}
