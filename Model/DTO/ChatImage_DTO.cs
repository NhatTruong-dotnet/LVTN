namespace STU.LVTN.SERVER.Model.DTO
{
    public class ChatImage_DTO
    {
        public string MessageBy { get; set; }
        public string MessageTo { get; set; }
        public string ImageSource { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
