using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string CollegeLocation { get; set; }

        public string CollegeDescription { get; set; }

        public ICollection<CollegeMajor> CollegeMajors { get; set; }

        public virtual ColUser ColUser { get; set; }
        public int ColUserId { get; set; }
    }
}