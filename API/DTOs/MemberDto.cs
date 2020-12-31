using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string PhotoUrl { get; set; }
        public string LogoUrl { get; set; }
        public string ClassYear { get; set; }
        public string College { get; set; }
        
         
        public string Major { get; set; } 
        public string Hometown { get; set; } 

        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        public string DreamJob { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }

        public string FullName { get; set; }

        public string NickName { get; set; }
        // [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public string AppUserType { get; set; }

        public bool Active { get; set; } = true;

        public ICollection<CollegePrepDto> CollegePreps { get; set; }

        public ICollection<EmpOppDto> EmpOpps { get; set; }
        // [ForeignKey("UserFk")]
        public ICollection<PhotoDto> Photos { get; set; }

    }
}