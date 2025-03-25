namespace Domain.Entities
{
    public class CommunicationType : BaseEntity
    {
        public virtual String? CommunicationTypeName { get; set; }

        //navigation
        public virtual ICollection<Communication> Communications { get; set; } = new List<Communication>();

    }
}
