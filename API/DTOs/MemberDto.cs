using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
         public int Id { get; set; }

        public string Username { get; set; }

        public string PhotUrl { get; set; }

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