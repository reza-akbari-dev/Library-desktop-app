using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configuration
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {

        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.Property(p => p.ActivityDiscription).IsRequired();
            builder.HasIndex(p => p.ActivityName).IsUnique();
            builder.Property(p => p.Id).ValueGeneratedNever();

            List<Activity> Activities = new List<Activity>();
            Activities.Add(new Activity
            {
                Id = 1,
                ActivityName = UserActivity.InformationManagment,
                ActivityDiscription = "Access to Information Management"
            });
            Activities.Add(new Activity
            {
                Id = 2,
                ActivityName = UserActivity.BorrowManagment,
                ActivityDiscription = "ccess to Borrow Management"

            });
            Activities.Add(new Activity
            {
                Id = 3,
                ActivityName = UserActivity.ReportManagement,
                ActivityDiscription = "Access to Reports"
            });
            Activities.Add(new Activity
            {
                Id = 4,
                ActivityName = UserActivity.SoftwareManagment,
                ActivityDiscription = "Access to Software setting"
            });
            Activities.Add(new Activity
            {
                Id = 5,
                ActivityName = UserActivity.SecurityManagement,
                ActivityDiscription = "Access to Securtiy Setting"
            });
            builder.HasData(Activities);
        }
    }
}
