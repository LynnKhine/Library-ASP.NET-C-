using LibrarySystem.Entities;

namespace LibrarySystem.Models.Book
{
    
    public class GetBookListRequestModel
    {
        public string AuthorName { get; set; }

        public string CategoryName { get; set; }
    }

    public class GetBookListResponseModel //Delete Later
    {
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }

        public List<BookEntity> BookList { get; set; } = new List<BookEntity>();
    }
    public class GetBookListResponseModelJoin
    {
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }

        public List<BookModel> BookList { get; set; } = new List<BookModel>();
    }

}
