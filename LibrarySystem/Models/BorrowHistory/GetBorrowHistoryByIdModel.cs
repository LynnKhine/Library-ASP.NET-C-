using LibrarySystem.Models.Book;

namespace LibrarySystem.Models.BorrowHistory
{
    public class GetBorrowHistoryByIdRequestModel
    {
        public string Id { get; set; }
    }

    public class GetBorrowHistoryByIdResponseModel
    {
        public BorrowHistoryModel BorrowHistoryRes { get; set; }
    }
}
