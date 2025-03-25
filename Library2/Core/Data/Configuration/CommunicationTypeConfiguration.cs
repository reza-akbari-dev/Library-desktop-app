using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configuration
{
    public class CommunicationTypeConfiguration : IEntityTypeConfiguration<CommunicationType>
    {
        public void Configure(EntityTypeBuilder<CommunicationType> builder)
        {
            builder.Property(p => p.CommunicationTypeName).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.CommunicationTypeName).IsUnique();
            builder.Property(p => p.Id).ValueGeneratedNever();

            List<CommunicationType> communicationTypes = new List<CommunicationType>();
            communicationTypes.Add(new CommunicationType
            {
                Id = 10,
                CommunicationTypeName = "Telphone"
            });
            communicationTypes.Add(new CommunicationType
            {
                Id = 20,
                CommunicationTypeName = "Fax"
            });
            communicationTypes.Add(new CommunicationType
            {
                Id = 30,
                CommunicationTypeName = "Email"
            });
            communicationTypes.Add(new CommunicationType
            {
                Id = 40,
                CommunicationTypeName = "Mail"
            });
            builder.HasData(communicationTypes);
        }
    }
}
