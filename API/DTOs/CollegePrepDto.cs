namespace API.DTOs
{
    public class CollegePrepDto
    {
        public int CollegePrepId { get; set; }
        public bool IsActive { get; set; } = true;
        public string ClassYear { get; set; }
        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        public float GPA { get; set; }
        public string Major { get; set; }
    }
}