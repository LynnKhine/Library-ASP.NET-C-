namespace LibrarySystem.Models.BorrowHistory
{
    public class CreateBorrowHistoryRequestModel
    {
        public string CustomerId { get; set; }

        public string BookId { get; set; }

    }

    public class CreateBorrowHistoryListModel
    {
        public List<CreateBorrowHistoryRequestModel> BorrowHistoryList { get; set; } = new List<CreateBorrowHistoryRequestModel>();
    }

    public class CreateBorrowHistoryResponseModel
    {
        public BorrowHistoryModel BorrowHistoryRes { get; set; }

        //public string BorrowHistoryId { get; set; }
    }
}
