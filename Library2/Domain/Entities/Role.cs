namespace Domain.Entities
{
    public class Role : BaseEntity
    {
        public virtual string? RoleName { get; set; }

        //Navigation Properties
        public virtual ICollection<Activity>? Activities { get; set; } = new List<Activity>();
        public virtual ICollection<User>? Users { get; set; } = new List<User>();

    }
}
