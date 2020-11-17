namespace API.Entities
{
    public class EmpOppDto
    {
        public int EmpOppId { get; set; }
        public bool IsActive { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string PositionType { get; set; }
        public string PositionDescription { get; set; }

    }
}