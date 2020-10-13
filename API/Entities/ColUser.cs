using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class ColUser
    {
        [Key]
        public int ColUserId { get; set; }
        public string ColUserName { get; set; }
    }
}