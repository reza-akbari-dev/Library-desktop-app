namespace Domain.Entities
{
    public class Communication : BaseEntity
    {
        public virtual string? Value { get; set; }

        //Navigation
        public virtual int CommunicationTypeId { get; set; }
        public virtual CommunicationType? CommunicationTypes { get; set; }
        public virtual ICollection<Person> People { get; set; } = new List<Person>();
    }
}
