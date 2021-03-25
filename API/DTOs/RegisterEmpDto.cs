using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterEmpDto
    {
        [Required] public string Username { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string Position { get; set; }
        [Required] public string Company { get; set; }
        [Required] public DateTime StartDate { get; set; }
        [Required] public string PositionLocation { get; set; }
        [Required] public string PositionType { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
        public string AppUserType { get; set; } = "EmpHr";

    }
}