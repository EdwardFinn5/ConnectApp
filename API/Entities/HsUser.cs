using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class HsUser
    {
        [Key]
        public int HsUserId { get; set; }
        public string HsUserName { get; set; }
    }
}