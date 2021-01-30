using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class CollegePrep
    {
        [Key]
        public int CollegePrepId { get; set; }
        [DataType(DataType.EmailAddress)]
        public string BestEmail { get; set; }
        public string BestPhone { get; set; }
        public string Athletics { get; set; }
        public string ExtraCurricular { get; set; }
        public bool IsActive { get; set; } = true;
        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        public string GPA { get; set; }
        public string Resume { get; set; }
        public string DreamJob { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}