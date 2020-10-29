using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace API.Entities
{
    public class College
    {
        [Key]
        public int CollegeId { get; set; }
        
        [Required]
        [MaxLength(40)]
        public string CollegeName { get; set; }

        [Required]
        [MaxLength(40)]
        public string Location { get; set; }

        [Required]
        [MaxLength(80)]
        public string CollegePicUrl { get; set; }

        public ICollection<CollegeMajor> CollegeMajors { get; set; }
    }
}