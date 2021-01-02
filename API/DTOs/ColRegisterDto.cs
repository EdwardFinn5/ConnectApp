using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class ColRegisterDto
    {
        [Required]
        public string ColUserName { get; set; }
        
        [Required]
        public string Password { get; set; }
    
    }
}