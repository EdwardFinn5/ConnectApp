using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class CollegeMajor
    {     
        public int CollegeId { get; set; }
        public College College { get; set; }
        public int MajorId { get; set; }
        public Major Major { get; set; }
    }
}