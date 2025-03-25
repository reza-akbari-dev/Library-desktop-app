using Domain.Entity;

namespace Domain.Entities
{
    public class Person : BaseEntity
    {

        public virtual string FirstName { get; set; } = string.Empty;
        public virtual string LastName { get; set; } = string.Empty;
        public virtual long NationalCode { get; set; }

        //navigation
        public virtual ICollection<Communication>? Communications { get; set; } = new List<Communication>();
        public virtual PersonPicture? PersonPicture { get; set; }



    }
}
