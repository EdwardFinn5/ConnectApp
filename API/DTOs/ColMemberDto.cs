using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API.Entities;

namespace API.DTOs
{
    public class ColMemberDto
    {
        public int ColUserId { get; set; }
        // [DataType(DataType.EmailAddress)]
        public string ColUserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ColUrl { get; set; }
        public string HsStudentUrl { get; set; }
        public string HsName { get; set; }
        public string HsLocation { get; set; }
        public string ClassYear { get; set; }
        public string CollegeName { get; set; }
        public string CollegeLocation { get; set; }
        public string CollegeEnrollment { get; set; }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; } 
        public string ColUserType { get; set; }
        public bool Active { get; set; } = true;
        public ICollection<ColPhotoDto> ColPhotos { get; set; }
        public IList<CollegeDto> Colleges { get; set; }
        public IList<HsPrepDto> HsPreps { get; set; } 
    }
}