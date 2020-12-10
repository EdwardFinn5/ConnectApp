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

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string FullName { get; set; }

        public string NickName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string AppUserType { get; set; }
        public bool Active { get; set; } = true;
        public IList<CollegePrep> CollegePreps { get; set; }
        public IList<EmpOpp> EmpOpps { get; set; }
        // [ForeignKey("UserFk")]
        public ICollection<Photo> Photos { get; set; }
    }
}