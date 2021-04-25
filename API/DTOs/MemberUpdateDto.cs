using System;

namespace API.DTOs
{
    public class MemberUpdateDto
    {
        public string ClassYear { get; set; }
        public string Major { get; set; }
        public string Hometown { get; set; }
        public string College { get; set; }
        public string AcademicPlus { get; set; }
        public string Athletics { get; set; }
        public string Arts { get; set; }
        public string ExtraCurricular { get; set; }
        public string WorkPlus { get; set; }
        public string GPA { get; set; }
        public DateTime GradDate { get; set; }
        public string BestEmail { get; set; }
        public string BestPhone { get; set; }
        public string Resume { get; set; }
        public string DreamJob { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string PositionType { get; set; }
        public string PositionLocation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime AppDeadline { get; set; }
        public string CompanyDescription { get; set; }
        public string PostionDescription { get; set; }
        public string Contact { get; set; }
        public string ContactTitle { get; set; }
        public string HowToApply { get; set; }
        public string LookingFor { get; set; }
        public string ApplyEmail { get; set; }

    }
}