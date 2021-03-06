namespace API.Helpers
{
    public class UserParams : PaginationParams
    {

        public string CurrentUsername { get; set; }
        public string AppUserType { get; set; }

        public string Major { get; set; } = "Accounting";

        public string Position { get; set; } = "Finance";

        public string OrderBy { get; set; } = "created";

    }
}