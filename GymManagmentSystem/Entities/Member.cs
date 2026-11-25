namespace GymManagmentSystem.Entities
{
    public class Member : GymUser
    {
        public string? Photo;
        public ICollection<MemberShip> memberShips = new HashSet<MemberShip>();
    }
}
