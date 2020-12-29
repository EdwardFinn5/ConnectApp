using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class HsPrep
    {
        [Key]
        public int HsPrepId { get; set; }
        public bool IsActive { get; set; } = true;
        public string HsName { get; set; }
        public string HsLocation { get; set; }
        public string ClassYear { get; set; }
        public DateTime GradDate { get; set; }
        public float GPA { get; set; }
        public string ProposedMajor { get; set; }
        public string ExtraCurricular { get; set; }
        public string DreamJob { get; set; }

        public virtual ColUser ColUser { get; set; }
        public int ColUserId { get; set; }
    }
}