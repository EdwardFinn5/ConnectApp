namespace API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 6;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string CurrentUsername { get; set; }
        public string AppUserType { get; set; }

        public string Major { get; set; } = "Accounting";

        public string Position { get; set; } = "Finance";

        public string OrderBy { get; set; } = "created";






    }
}