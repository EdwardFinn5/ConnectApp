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
        [MaxLength(40)]
        public string ColUserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(30)]
        public string NickName { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;

        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string ColEmail { get; set; }

        [MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string ColPhone { get; set; }

        public string ColUserType { get; set; } = "ColAdmin";

        public bool Active { get; set; } = true;

        public ICollection<ColPhoto> ColPhotos { get; set; }

        public IList<College> Colleges { get; set; }

        public IList<HsPrep> HsPreps { get; set; }
    }
}