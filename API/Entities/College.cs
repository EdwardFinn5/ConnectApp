using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class College
    {
        [Key]
        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
    }
}