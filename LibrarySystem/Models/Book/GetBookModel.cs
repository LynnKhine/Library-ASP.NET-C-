namespace LibrarySystem.Models.Book
{
    public class GetBookRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string AuthorId { get; set; }

        public string CategoryId { get; set; }

        public int PublishedYear { get; set; }

        public int TotalQuantity { get; set; }

        public int AvailableQuantity { get; set; }
    }

    public class GetBookResponseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string AuthorId { get; set; }

        public string CategoryId { get; set; }

        public int PublishedYear { get; set; }

        public int TotalQuantity { get; set; }

        public int AvailableQuantity { get; set; }
    }

    public class GetBookListResponseModel
    {
        public List<GetBookRequestModel> ListBooks { get; set; } = new List<GetBookRequestModel>();
    }
}
