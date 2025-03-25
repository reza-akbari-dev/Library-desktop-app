namespace ViewModel.Member
{
    public class MemberSearchModel : BaseModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public DateTime MemberDate { get; set; }
        public string? ProofName { get; set; }
        public string? MajorName { get; set; }
    }
}
