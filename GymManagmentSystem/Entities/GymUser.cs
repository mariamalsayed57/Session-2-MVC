using GymManagmentSystem.Enums;

namespace GymManagmentSystem.Entities
{
    public abstract class GymUser : BaseClass
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone {  get; set; } = default!;
        public string DateBirth {  get; set; } = default!;
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
