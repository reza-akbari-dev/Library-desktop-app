using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configuration
{
    public class PersonPictureConfiguration : IEntityTypeConfiguration<PersonPicture>
    {
        public void Configure(EntityTypeBuilder<PersonPicture> builder)
        {

        }
    }
}
