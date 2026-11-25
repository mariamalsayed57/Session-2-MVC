using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configurations
{
    public class MemberConfiguration :GymUserConfiguration<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GetDate()");

            base.Configure(builder);
        }
    }
}
