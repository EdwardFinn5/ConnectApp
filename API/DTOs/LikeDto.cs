namespace API.DTOs
{
    public class LikeDto
    {
        public int Id { get; set; } //Id is UserId
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Major { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string StudentUrl { get; set; }
        public string LogoUrl { get; set; }
        public string AppUserType { get; set; }
        public string Athletics { get; set; }
    }
}