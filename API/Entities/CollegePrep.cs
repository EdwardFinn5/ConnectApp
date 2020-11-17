using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class CollegePrep
    {
        [Key]
        public int CollegePrepId { get; set; }

        public string ClassYear { get; set; }
        public bool IsActive { get; set; }
        public DateTime GradDate { get; set; }

        public string AcademicPlus { get; set; }

        public string WorkPlus { get; set; }

        public float GPA { get; set; }

        public string Major { get; set; }

        public string Resume { get; set; }

        public string DreamJob { get; set; }

        public string Hometown { get; set; }

        public virtual AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}