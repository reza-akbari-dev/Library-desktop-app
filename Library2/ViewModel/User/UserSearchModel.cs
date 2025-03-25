namespace ViewModel.User
{
    public class UserSearchModel : BaseModel
    {
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
    }
}
