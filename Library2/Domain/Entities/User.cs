namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public virtual string? UserName { get; set; }
        public virtual string? Password { get; set; }
        public virtual DateTime? LastOnLogin { get; set; }

        //navigartion 
        public virtual int? PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public virtual ICollection<Role>? Roles { get; set; }
    }
}
