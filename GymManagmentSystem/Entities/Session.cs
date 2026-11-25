namespace GymManagmentSystem.Entities
{
    public class Session : BaseClass
    {
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TraineerId { get; set; }
        public Traineer Traineer { get; set; }
    }
}
