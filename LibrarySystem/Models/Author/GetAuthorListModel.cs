using LibrarySystem.Entities;
using System.Diagnostics.Contracts;

namespace LibrarySystem.Models.Author
{
    public class GetAuthorListRequestModel
    {

    }

    public class GetAuthorListResponseModel
    {
        public List<AuthorEntity> AuthorList { get; set; } = new List<AuthorEntity>();
    }
}
