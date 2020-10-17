using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class EnrollUser
    {
        [Key]
        public int EnrollUserId { get; set; }
        public string EnrollUserName { get; set; }
    }
}