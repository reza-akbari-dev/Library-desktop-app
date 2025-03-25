namespace Domain.Entities
{
    public class Subject : BaseEntity
    {
        public virtual string? SubjectName { get; set; }
        //Navigation
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
