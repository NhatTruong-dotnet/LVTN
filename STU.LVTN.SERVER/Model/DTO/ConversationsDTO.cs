namespace STU.LVTN.SERVER.Model.DTO
{
    public class ConversationsDTO
    {
        public int ConversationId { get; set; }
        public string? SdtNguoiBan { get; set; }
        public string? SdtNguoiMua { get; set; }
        public string? ImageSourceNguoiBan { get; set; }
        public string? ImageSourceNguoiMua { get; set; }
        public string LastMessage { get; set; }
        public string Time { get; set; }
    }
}
