using LibrarySystem.Entities;

namespace LibrarySystem.Models.BorrowHistory
{
    public class GetBorrowHistoryListModel
    {

    }

    public class GetBorrowHistoryListRequestModel
    {

    }

    public class GetBorrowHistoryListResponseModel
    {
        public List<BorrowHistoryEntity> BorrowHistoryList { get; set; } = new List<BorrowHistoryEntity>();
    }
}
