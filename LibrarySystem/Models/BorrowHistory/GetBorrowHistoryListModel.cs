using LibrarySystem.Entities;

namespace LibrarySystem.Models.BorrowHistory
{
    public class GetBorrowHistoryListModel
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string BookId { get; set; }
        public string BookName { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }

    public class GetBorrowHistoryListRequestModel
    {
        public string CustomerName { get; set; }
        public string BookName { get; set; }
    }

    public class GetBorrowHistoryListResponseModel
    {
        public string CustomerName { get; set; }
        public string BookName { get; set; }
        public List<BorrowHistoryEntity> BorrowHistoryList { get; set; } = new List<BorrowHistoryEntity>();
    }

    public class GetBorrowHistoryListResponseModelJoin
    {
        public string CustomerName { get; set; }
        public string BookName { get; set; }
        public List<GetBorrowHistoryListModel> BorrowHistoryList { get; set; } = new List<GetBorrowHistoryListModel>();
    }
}
