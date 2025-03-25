using Domain.Entity;

namespace Domain.Entities
{
    public class Major : BaseEntity
    {
        public virtual string? MajorName { get; set; }
        public virtual ICollection<Member> Members { get; set; } = new List<Member>();
    }
}
