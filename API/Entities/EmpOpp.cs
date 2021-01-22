using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class EmpOpp
    {
        [Key]
        public int EmpOppId { get; set; }
        public string CompanyDescription { get; set; }
        public bool IsActive { get; set; } = true;
        public string PositionDescription { get; set; }
        public string Contact { get; set; }
        public string ContactTitle { get; set; }
        public string HowToApply { get; set; }
        [DataType(DataType.EmailAddress)]
        public string ApplyEmail { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
