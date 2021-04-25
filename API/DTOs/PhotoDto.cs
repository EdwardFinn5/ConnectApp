namespace API.DTOs
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string StudentUrl { get; set; }
        public string LogoUrl { get; set; }
        public string HrUrl { get; set; }
        public bool IsMain { get; set; }
        public bool IsMainLogo { get; set; } 
        public bool IsMainHr { get; set; } 
    }
}