using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");

            builder.HasOne(m => m.Plan).WithMany(p => p.memberShips).HasForeignKey(p=> p.PlanID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
