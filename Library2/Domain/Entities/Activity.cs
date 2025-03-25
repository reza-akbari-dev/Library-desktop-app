namespace Domain.Entities
{
    public class Activity : BaseEntity
    {
        public virtual UserActivity ActivityName { get; set; }
        public virtual string? ActivityDiscription { get; set; }

        public virtual ICollection<Role>? Roles { get; set; }


    }
    public enum UserActivity
    {
        InformationManagment = 10,
        BorrowManagment = 20,
        ReportManagement = 30,
        SoftwareManagment = 40,
        SecurityManagement = 50

    }
}
