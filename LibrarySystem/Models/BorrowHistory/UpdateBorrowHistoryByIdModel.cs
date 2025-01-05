namespace LibrarySystem.Models.BorrowHistory
{
    public class UpdateBorrowHistoryByIdRequestModel
    {
        public string Id { get; set; }

        public string CustomerId { get; set; } // ID should not be updated also, but Customer name and book name should be

        public string BookId { get; set; }

        public DateTime BorrowDate { get; set; } // BorrowDate and DueDate should not be updated

        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
    public class UpdateBorrowHistoryByIdResponseModel
    {

    }
}
