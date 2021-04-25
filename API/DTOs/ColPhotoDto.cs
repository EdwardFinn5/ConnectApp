namespace API.DTOs
{
    public class ColPhotoDto
    {
        public int ColPhotoId { get; set; }
        public string ColUrl { get; set; }
        public string HsStudentUrl { get; set; }
        public string AdminUrl { get; set; }
        public bool IsMainCol { get; set; } 
        public bool IsMainHs { get; set; }
        public bool IsMainAdmin { get; set; } 
        
    }
}