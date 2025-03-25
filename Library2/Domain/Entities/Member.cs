using Domain.Entities;

namespace Domain.Entity
{
    public class Member : BaseEntity
    {
        public virtual DateTime MemberDate { get; set; }
        //Navigation Properties
        public virtual int PresonId { get; set; }
        public virtual Person? Person { get; set; }

        public virtual int ProofId { get; set; }
        public virtual Proof? Proof { get; set; }
        public virtual int MajorId { get; set; }
        public virtual Major? Major { get; set; }
        public virtual ICollection<FormBorrow>? FormBorrows { get; set; }

    }
}
