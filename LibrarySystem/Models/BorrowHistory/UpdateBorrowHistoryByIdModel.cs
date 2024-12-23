namespace LibrarySystem.Models.BorrowHistory
{
    public class UpdateBorrowHistoryByIdModel
    {

    }
    public class UpdateBorrowHistoryByIdRequestModel
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public string BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
    public class UpdateBorrowHistoryByIdResponseModel
    {

    }
}
