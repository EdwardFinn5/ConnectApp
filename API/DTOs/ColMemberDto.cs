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
        public string AdminUrl { get; set; }
        public string AdminContact { get; set; }
        public string AdminTitle { get; set; }
        public string HsName { get; set; }
        public string HsLocation { get; set; }
        public string ClassYear { get; set; }
        public string ProposedMajor { get; set; }
        public string ExtraCurricular { get; set; }
        public string DreamJob { get; set; }
        public string GPA { get; set; }
        public DateTime HsGradDate { get; set; }
        public string CollegeName { get; set; }
        public string CollegeLocation { get; set; }
        public string CollegeEnrollment { get; set; }
        public string CollegeDescription { get; set; }
        public string CollegeStreet { get; set; }
        public string CollegeCity { get; set; }
        public string CollegeState { get; set; }
        public string CollegeZip { get; set; }
        public string CollegeEmail { get; set; }
        public string CollegeWebsite { get; set; }
        public string CollegeVirtual { get; set; }
        public int Tuition { get; set; }
        public int RoomAndBoard { get; set; }
        public int AverageAid { get; set; }
        public int NetPay { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string ColUserType { get; set; }
        public bool Active { get; set; } = true;
        public ICollection<ColPhotoDto> ColPhotos { get; set; }
        public ICollection<CollegeDto> Colleges { get; set; }
        public ICollection<HsPrepDto> HsPreps { get; set; }
    }
}