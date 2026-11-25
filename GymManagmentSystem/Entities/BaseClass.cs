namespace GymManagmentSystem.Entities
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }

    }
}
