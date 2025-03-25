using Domain.Entities;

namespace Domain.Entity
{
    public class FormBorrow : BaseEntity
    {
        public virtual DateTime BorrowDate { get; set; }
        public virtual int NumberOfDay { get; set; }

        //Navigation Properties
        public virtual int MemberId { get; set; }
        public virtual Member? Member { get; set; }
        public virtual int BookId { get; set; }
        public virtual Book? Book { get; set; }
    }
}
