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
        [DataType(DataType.EmailAddress)]
        public string ColUserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HsName { get; set; }
        public string HsLocation { get; set; }
        public string ClassYear { get; set; }
        public DateTime HsGradDate { get; set; } = DateTime.Now;
        public string CollegeName { get; set; }
        public string CollegeLocation { get; set; }
        public string CollegeEnrollment { get; set; }
        public int Tuition { get; set; }
        public int RoomAndBoard { get; set; }
        public int AverageAid { get; set; }
        public int NetPay { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string ColUserType { get; set; }
        public bool Active { get; set; } = true;
        public ICollection<ColPhoto> ColPhotos { get; set; }
        public IList<College> Colleges { get; set; }
        public IList<HsPrep> HsPreps { get; set; }
    }
}