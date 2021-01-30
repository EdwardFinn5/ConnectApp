namespace API.Entities
{
    public class EmpOppDto
    {
        public int EmpOppId { get; set; }
        public bool IsActive { get; set; } = true;
        public string Position { get; set; }
        public string Company { get; set; }
        public string CompanyDescription { get; set; }
        public string PositionType { get; set; }
        public string PositionDescription { get; set; }
        public string LookingFor { get; set; }

    }
}