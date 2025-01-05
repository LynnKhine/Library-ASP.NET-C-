namespace LibrarySystem.Models.Book
{
    public class CreateBookRequestModel
    {
        public string Name { get; set; }
        public string AuthorId { get; set; }
        public string CategoryId { get; set; }
        public int PublishedYear { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
    }

    public class CreateBookListModel
    {
        public List<CreateBookRequestModel> BookList { get; set; } = new List<CreateBookRequestModel>();
    }

    public class CreateBookResponseModel
    {
        public BookModel BookRes { get; set; }

        //public string BookId { get; set; }
    }
}
