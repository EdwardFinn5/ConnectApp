using System;

namespace API.Entities
{
    public class EmpOpp
    {
        public int EmpOppId { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string CompanyDescription { get; set; }
        public string PositionType { get; set; }
        public bool IsActive { get; set; } = true;
        public string PositionDescription { get; set; }
        public string PositionLocation { get; set; }
        public DateTime StartDate { get; set; }
        public string Contact { get; set; }
        public string ContactTitle { get; set; }
        public string HowToApply { get; set; }
        public string ApplyEmail { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
