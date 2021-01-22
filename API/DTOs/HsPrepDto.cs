using System;

namespace API.DTOs
{
    public class HsPrepDto
    {
        public int HsPrepId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime GradDate { get; set; }
        public float GPA { get; set; }
        public string ProposedMajor { get; set; }
        public string ExtraCurricular { get; set; }
        public string DreamJob { get; set; }
    }
}