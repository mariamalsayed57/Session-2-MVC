namespace GymManagmentSystem.Entities
{
    public class Plan : BaseClass
    {
        public string Name { get; set; } = default!;
        public string Dwscription { get; set; } = default!;
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<MemberShip> memberShips = new HashSet<MemberShip>();
    }
}
