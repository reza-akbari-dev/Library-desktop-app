namespace Domain.Entity
{
    public class Proof : BaseEntity
    {
        public virtual string? ProofName { get; set; }
        //Navigation Properties
        public virtual ICollection<Member>? Members { get; set; }
    }
}
