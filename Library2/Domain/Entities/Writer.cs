namespace Domain.Entities
{
    public class Writer : BaseEntity
    {
        public virtual String? Biography { get; set; }
        //Navigation
        public virtual ICollection<Book> books { get; set; } = new List<Book>();
        public virtual int PersonId { get; set; }
        public virtual Person? Persons { get; set; }
    }
}
