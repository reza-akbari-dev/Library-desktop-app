namespace ViewModel.Book
{
    public class BookSearchModel : BaseModel
    {
        public string? BookName { get; set; }
        public string? writers { get; set; }
        public string? SubjectName { get; set; }
        public string? ISBN { get; set; }
        public string? Abstract { get; set; }
    }
}
