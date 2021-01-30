using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class HsPrep
    {
        [Key]
        public int HsPrepId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime GradDate { get; set; }
        public string GPA { get; set; }
        public string ProposedMajor { get; set; }
        public string ExtraCurricular { get; set; }
        public string DreamJob { get; set; }
        public virtual ColUser ColUser { get; set; }
        public int ColUserId { get; set; }
    }
}