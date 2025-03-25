using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Core.Data.Configuration
{
    public class ProofConfiguration : IEntityTypeConfiguration<Proof>
    {
        public void Configure(EntityTypeBuilder<Proof> builder)
        {
            builder.Property(p => p.ProofName).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.ProofName).IsUnique();
            builder.HasMany(p => p.Members).WithOne(p => p.Proof).HasForeignKey(p => p.ProofId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.Id).ValueGeneratedNever();
            var _list = new List<Proof>();
            _list.Add(new Proof { Id = -1, ProofName = "" });
            _list.Add(new Proof { Id = 1, ProofName = "Under Secondary school" });
            _list.Add(new Proof { Id = 2, ProofName = "Associate" });
            _list.Add(new Proof { Id = 3, ProofName = "Bachelor" });
            _list.Add(new Proof { Id = 4, ProofName = "Master" });
            _list.Add(new Proof { Id = 5, ProofName = "Phd" });
            _list.Add(new Proof { Id = 6, ProofName = "Uper Phd" });
            builder.HasData(_list);
        }
    }
}
