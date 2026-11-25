using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configurations
{
    public class TraineerConfiguration :GymUserConfiguration<Traineer> , IEntityTypeConfiguration<Traineer>
    {
        public new void Configure(EntityTypeBuilder<Traineer> builder)
        {
            builder.Property(m => m.CreatedAt).HasDefaultValueSql("GetDate()");

            base.Configure(builder);
        }
    }
}
