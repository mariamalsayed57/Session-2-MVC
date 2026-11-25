using GymManagmentSystem.Enums;

namespace GymManagmentSystem.Entities
{
    public class Traineer : GymUser
    {
        public DateTime HiteDate { get; set; }
        public Specialties Specialties { get; set; }
        public ICollection<Session> sessions = new HashSet<Session>();
    }
}
