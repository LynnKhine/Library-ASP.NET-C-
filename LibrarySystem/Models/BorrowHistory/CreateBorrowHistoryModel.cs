namespace LibrarySystem.Models.BorrowHistory
{
    public class CreateBorrowHistoryRequestModel
    {
        public string CustomerId { get; set; }

        public string BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }

    public class CreateBorrowHistoryListModel
    {
        public List<CreateBorrowHistoryRequestModel> BorrowHistoryList { get; set; } = new List<CreateBorrowHistoryRequestModel>();
    }

    public class CreateBorrowHistoryResponseModel
    {
        public string BorrowHistoryId { get; set; }
    }
}
