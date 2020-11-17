namespace API.DTOs
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string StudentUrl { get; set; }
        public string LogoUrl { get; set; }
        public bool IsMain { get; set; }
    }
}