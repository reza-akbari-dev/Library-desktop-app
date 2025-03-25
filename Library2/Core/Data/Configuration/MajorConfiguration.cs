using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configuration
{
    public class MajorConfiguration : IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder.Property(p => p.MajorName).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.MajorName).IsUnique();
            builder.HasMany(p => p.Members).WithOne(p => p.Major).HasForeignKey(p => p.MajorId).
                OnDelete(DeleteBehavior.NoAction);
            builder.HasData(new Major
            {
                Id = -1,
                MajorName = ""
            });
        }
    }
}
