using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class ColPhoto
    {
        [Key]
        public int ColPhotoId { get; set; }
        public string ColUrl { get; set; }
        public string HsStudentUrl { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public virtual ColUser ColUser { get; set; }
        public int ColUserId { get; set; }
    }
}