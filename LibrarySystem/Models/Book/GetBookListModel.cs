using LibrarySystem.Entities;

namespace LibrarySystem.Models.Book
{
    public class GetBookListModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string AuthorId { get; set; }
        public string AuthorName { get; set; }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int PublishedYear { get; set; }

        public int TotalQuantity { get; set; }

        public int AvailableQuantity { get; set; }
    }

    public class GetBookListRequestModel
    {
        public string AuthorName { get; set; }

        public string CategoryName { get; set; }
    }

    public class GetBookListResponseModel
    {
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }

        public List<BookEntity> BookList { get; set; } = new List<BookEntity>();
    }
    public class GetBookListResponseModelJoin
    {
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }

        public List<GetBookListModel> BookList { get; set; } = new List<GetBookListModel>();
    }

}
