using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class EmpUser
    {
        [Key]
        public int EmpUserId { get; set; }
        public string EmpUserName { get; set; }
    }
}