using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class MajorCat
    {
        [Key]
        public int MajorCatId { get; set; }

        [Required]
        [MaxLength(80)]
        public string MajorCatName { get; set; }
        
        public ICollection<Major> Majors { get; set; }
    }
}