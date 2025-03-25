namespace ViewModel.FormBorrow
{
    public class FormBorrowSearchModel : BaseModel
    {
        public string? BookName { get; set; }
        public int? NumberOfDay { get; set; }
        public DateTime? BorrowDate { get; set; }
    }
}
