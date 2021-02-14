namespace API.DTOs
{
    public class CollegePrepDto
    {
        public int CollegePrepId { get; set; }
        public bool IsActive { get; set; } = true;
        public string ClassYear { get; set; }
        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        public string Athletics { get; set; }
        public string Arts { get; set; }
        public string GPA { get; set; }
        public string Major { get; set; }
        public string BestEmail { get; set; }
        public string BestPhone { get; set; }
    }
}