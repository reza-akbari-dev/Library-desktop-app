using Domain.Entities;

namespace Domain.Entity
{
    public class PersonPicture
    {
        public virtual int Id { get; set; }
        public virtual byte[]? Picture { get; set; }
        //Navigation
        public virtual Person? Person { get; set; }

    }
}
