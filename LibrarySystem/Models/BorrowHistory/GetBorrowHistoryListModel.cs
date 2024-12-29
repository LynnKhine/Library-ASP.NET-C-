using LibrarySystem.Entities;

namespace LibrarySystem.Models.BorrowHistory
{
    public class GetBorrowHistoryListRequestModel
    {
        public string CustomerName { get; set; }
        public string BookName { get; set; }
    }

    //Use in without join
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
        public List<BorrowHistoryModel> BorrowHistoryList { get; set; } = new List<BorrowHistoryModel>();
    }
}
