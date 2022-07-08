namespace STU.LVTN.SERVER.Model.DTO
{
    public class Admin_NguoiDungDTO
    {
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public bool XacThuc { get; set; }
        public bool? Active { get; set; }
        public string? LockTime { get; set; }
        public string DanhGiaHeThong { get; set; }
    }
}
