namespace GymManagmentSystem.Entities
{
    public class MemberShip : BaseClass
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanID { get; set; }
        public Plan Plan { get; set; } = default!;
        public string Status => StartDate > DateTime.Now ? "upComing" : EndDate > DateTime.Now ? "Active" : "Expired";

    }
}
