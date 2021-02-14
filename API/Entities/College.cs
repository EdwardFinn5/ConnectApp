using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class College
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CollegeId { get; set; }
        public string CollegeDescription { get; set; }
        public bool IsActive { get; set; } = true;
        public string CollegeStreet { get; set; }
        public string CollegeCity { get; set; }
        public string CollegeState { get; set; }
        public string CollegeZip { get; set; }
        public string CollegePhone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string CollegeEmail { get; set; }
        public string CollegeWebsite { get; set; }
        public string CollegeVirtual { get; set; }
        public string CollegeYearFounded { get; set; }
        public string CollegePresident { get; set; }
        public string AdminContact { get; set; }
        public string AdminTitle { get; set; }
        public IList<CollegeMajor> CollegeMajors { get; set; }
        public IList<FactFeature> FactFeatures { get; set; }

        public virtual ColUser ColUser { get; set; }
        public int ColUserId { get; set; }

        // public decimal GetNet()
        // {
        //     return NetPay.CalculateNetPay();
        // }

    }
}