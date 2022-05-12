using System;
using System.Collections.Generic;

namespace STU.LVTN.SERVER.Model
{
    public partial class BaiDangXeCo
    {
        public int IdBaiDang { get; set; }
        public string? HangXe { get; set; }
        public string? Nam { get; set; }
        public double? SoKmDaDi { get; set; }
        public double? Gia { get; set; }
        public bool? DaSuDung { get; set; }
        public string? Xuatxu { get; set; }
        public string? MauSac { get; set; }
        public string? BienSoXe { get; set; }
        public string? OtoHopSo { get; set; }
        public string? OtoNhieuLieu { get; set; }
        public string? OtoKieuDang { get; set; }
        public byte? OtoSocho { get; set; }
        public string? XeMayDungtich { get; set; }
        public string? XeTaiTrongTai { get; set; }
        public string? XeTaiNhieuLieu { get; set; }
        public string? XeTaiXuatXu { get; set; }
        public string? XeDienLoaiXe { get; set; }
        public string? XeDienDongCo { get; set; }
        public bool? XeDienDaSuDung { get; set; }
        public bool? XeDienMienPhi { get; set; }
        public string? XeDapKichThuocKhung { get; set; }
        public string? XeDapChatLuongKhung { get; set; }
        public bool? XeDapDaSuDung { get; set; }
        public bool? XeDapMienPhi { get; set; }
        public string? XeDapBaoHang { get; set; }
        public string? PhuongTienKhacNhienLieu { get; set; }
        public string? PhuTungXeLoaiPhuTung { get; set; }
    }
}
