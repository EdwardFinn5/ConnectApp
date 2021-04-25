using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Position
    {
        [Key]
        public int PostionId { get; set; }

        [Required]
        [MaxLength(80)]
        public string PositionName { get; set; }

        [Required]
        [MaxLength(300)]
        public string PositionDescription { get; set; }

        [Required]
        public string JobType { get; set; }

        [Required]
        public DateTime StartingDate { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;

    }
}