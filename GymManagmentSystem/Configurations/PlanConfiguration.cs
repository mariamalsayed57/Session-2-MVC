using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");

            builder.ToTable(p =>
            {
                p.HasCheckConstraint("PlanDurationCheck", "DurationDays between 1 and 365");
            });
        }
    }
}
