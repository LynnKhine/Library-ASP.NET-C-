using LibrarySystem.Entities;

namespace LibrarySystem.Models.Book
{
    public class GetBookListModel
    {

    }

    public class GetBookListRequestModel
    {

    }

    public class GetBookListResponseModel
    {
        public List<BookEntity> BookList { get; set; } = new List<BookEntity>();
    }
}
