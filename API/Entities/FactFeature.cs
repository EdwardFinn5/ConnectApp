using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class FactFeature
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FactId { get; set; }
        public string FactBullet { get; set; }
        public int CollegeId { get; set; }
        public College College { get; set; }
        
    }
}