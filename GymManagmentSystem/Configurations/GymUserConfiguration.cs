using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configurations
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar").HasMaxLength(11);

            builder.ComplexProperty(x => x.Address);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("GymUser_EmailCheck", "Email like '_%@_%._%'");
                t.HasCheckConstraint("GynUser_PhoneCheck", "Len(Phone) = 11 AND (Phone like '010%' or Phone like '011%'or Phone like '012%' or Phone like '015%')");
            });
        }
    }
}
