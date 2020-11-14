using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Employer
    {
        [Key]
        public int EmployerId { get; set; }

        [Required]
        [MaxLength(60)]
        public string EmployerName { get; set; }

        [Required]
        [MaxLength(40)]
        public string Location { get; set; }

        [MaxLength(80)]
        public string Logo { get; set; }

        public ICollection<Position> Positions { get; set; }
    }
}