using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(p => p.RoleName).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.RoleName).IsUnique();
            builder.HasData(new Role
            {
                Id = -1,
                RoleName = "Administrator"
            });
        }
    }
}
