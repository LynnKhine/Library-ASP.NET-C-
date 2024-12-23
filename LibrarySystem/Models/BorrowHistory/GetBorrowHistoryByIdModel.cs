namespace LibrarySystem.Models.BorrowHistory
{
    public class GetBorrowHistoryRequestModel
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public string BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }

    }

    public class GetBorrowHistoryResponseModel
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public string BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }

    }

    public class GetBorrowHistoryByIdModel
    {
        public string Id { get; set; }
    }
}
