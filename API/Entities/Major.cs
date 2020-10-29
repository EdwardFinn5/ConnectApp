using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Major
    {
        [Key]
        public int MajorId { get; set; }
        
        [Required]
        [MaxLength(80)]
        public string MajorName { get; set; }

        public MajorCat MajorCat { get; set; }

        public ICollection<CollegeMajor> CollegeMajors { get; set; }
    }
}