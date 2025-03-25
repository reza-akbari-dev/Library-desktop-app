namespace ViewModel.People
{
    public class PeopleSearchModel : BaseModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public long NationalCode { get; set; }
        public byte[]? PersonPicture { get; set; }
    }
}
