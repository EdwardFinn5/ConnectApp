using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassYear { get; set; }
        public DateTime GradDate { get; set; } = DateTime.Now;

        public string Major { get; set; }

        public string Hometown { get; set; }
        public string College { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string PositionType { get; set; }
        public string PositionLocation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string AppUserType { get; set; }
        public bool Active { get; set; } = true;
        public bool IsActive { get; set; } = true;

        public string BestEmail { get; set; }
        public string BestPhone { get; set; }
        public string Athletics { get; set; }
        public string Arts { get; set; }
        public string ExtraCurricular { get; set; }
        public string AcademicPlus { get; set; }
        public string WorkPlus { get; set; }
        public string GPA { get; set; }
        public string Resume { get; set; }
        public string DreamJob { get; set; }

        public string CompanyDescription { get; set; }
        public string PositionDescription { get; set; }
        public string Contact { get; set; }
        public string ContactTitle { get; set; }
        public string HowToApply { get; set; }
        public string LookingFor { get; set; }
        [DataType(DataType.EmailAddress)]
        public string ApplyEmail { get; set; }

        // public ICollection<CollegePrep> CollegePreps { get; set; }
        // public ICollection<EmpOpp> EmpOpps { get; set; }
        // [ForeignKey("UserFk")]
        public ICollection<Photo> Photos { get; set; }
        public ICollection<UserLike> LikedByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }

    }
}