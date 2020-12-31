using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class ColUser
    {
        [Key]
        public int ColUserId { get; set; }
    
        public string ColUserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string FullName { get; set; }

        public string NickName { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;

        [DataType(DataType.EmailAddress)]
        public string ColEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string ColPhone { get; set; }

        public string ColUserType { get; set; }

        public bool Active { get; set; } = true;

        public ICollection<ColPhoto> ColPhotos { get; set; }

        public IList<College> Colleges { get; set; }

        public IList<HsPrep> HsPreps { get; set; }
    }
}