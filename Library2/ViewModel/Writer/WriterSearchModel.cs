namespace ViewModel.Writer
{
    public class WriterSearchModel : BaseModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string fullName => FirstName + " " + LastName;

        public string? Biography { get; set; }

    }
}
