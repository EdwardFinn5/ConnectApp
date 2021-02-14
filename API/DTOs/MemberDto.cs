using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string StudentUrl { get; set; }
        public string LogoUrl { get; set; }
        public string HrUrl { get; set; }
        public string ClassYear { get; set; }
        public string College { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Major { get; set; }
        public string Hometown { get; set; }

        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        public string DreamJob { get; set; }
        public string Athletics { get; set; }
        public string Arts { get; set; }
        public string ExtraCurricular { get; set; }
        public DateTime GradDate { get; set; }
        public string GPA { get; set; }
        
        
        public string BestEmail { get; set; }
        public string BestPhone { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string PositionLocation { get; set; }
        public string CompanyDescription { get; set; }
        public string PositionDescription { get; set; }
        public string PositionType { get; set; }
        public DateTime StartDate { get; set; }
        // [DataType(DataType.EmailAddress)]
        public string ApplyEmail { get; set; }
        public string LookingFor { get; set; }
        public string HowToApply { get; set; }
        public string Contact { get; set; }
        public string ContactTitle { get; set; }

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