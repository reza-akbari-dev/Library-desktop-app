namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public virtual string? BookName { get; set; }

        public virtual string? ISBN { get; set; }
        public virtual string? Abstract { get; set; }

        // Navigations
        public virtual int SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual int WriterId { get; set; }
        public virtual ICollection<Writer> Writers { get; set; } = new List<Writer>();
    }
}
