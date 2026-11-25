using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GetDate()");

            builder.HasOne(s => s.Traineer).WithMany(t => t.sessions).HasForeignKey(s => s.TraineerId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(s =>
            {
                s.HasCheckConstraint("CapacityCheck", "Capacity between 1 and 25");
                s.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate > StartDate");
            });
        }
    }
}
