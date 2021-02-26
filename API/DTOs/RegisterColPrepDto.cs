using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterColPrepDto
    {

        [Required] public string UserName { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string Major { get; set; }
        [Required] public string ClassYear { get; set; }
        [Required] public DateTime GradDate { get; set; }
        [Required] public string Hometown { get; set; }
        [Required] public string College { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
        public string AppUserType { get; set; } = "ColStudent";
    }
}