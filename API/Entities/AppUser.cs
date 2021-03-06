using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
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
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string AppUserType { get; set; }
        public bool Active { get; set; } = true;
        public ICollection<CollegePrep> CollegePreps { get; set; }
        public ICollection<EmpOpp> EmpOpps { get; set; }
        // [ForeignKey("UserFk")]
        public ICollection<Photo> Photos { get; set; }
        public ICollection<UserLike> LikedByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }


    }
}