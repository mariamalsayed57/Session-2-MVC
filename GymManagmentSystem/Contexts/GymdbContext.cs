using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagmentSystem.Contexts
{
    public class GymdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MARIAM\\SQLEXPRESS;Database=GymSystem;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region Dbset
        public DbSet<Traineer> Traineers { get; set; }
        public DbSet<Session> Sessions { get; set; } 
        public DbSet<Plan> Plans { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Member> Members { get; set; }
        #endregion
    }

}
