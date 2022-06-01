namespace STU.LVTN.SERVER.Model.DTO
{
    public class ChatText_DTO
    {
        public string MessageContent { get; set; }
        public string MessageBy { get; set; }
        public string MessageTo { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;

    }
}
