namespace STU.LVTN.SERVER.Model.DTO
{
    public class UserProfileDTO
    {
        public string SoDienThoai { get; set; } = null!;
        public string? Ten { get; set; }
        public string? DiaChi { get; set; }
        public string? DanhGiaHeThong { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

    }
}
