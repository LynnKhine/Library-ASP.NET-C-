using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models;
using LibrarySystem.Models.Author;

namespace LibrarySystem.Services
{

    public class AuthorService
    {
        private readonly AppDbContext _context;

        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public CreateAuthorResponseModel CreateAuthor(CreateAuthorRequestModel model)
        {
            AuthorEntity author = new AuthorEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                RealName = model.RealName,
                Bio = model.Bio,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.AuthorDbSet.Add(author);
            _context.SaveChanges();

            CreateAuthorResponseModel result = new CreateAuthorResponseModel()
            {
                AuthorId = author.Id
            };

            return result;
        }

        public GetAuthorResponseModel GetAuthorById(GetAuthorByIdRequestModel model)
        {
            var author = _context.AuthorDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            GetAuthorResponseModel result = new GetAuthorResponseModel()
            {
                Id = author.Id,
                Name = author.Name,
                RealName = author.RealName,
                Bio = author.Bio
            };


            return result;
        }

        public GetAuthorListResponseModel GetAuthorList(GetAuthorListRequestModel model)
        {
            var result = new GetAuthorListResponseModel();
            result.AuthorList = _context.AuthorDbSet.AsNoTracking().ToList();

            return result;
        }

        public UpdateAuthorByIdResponseModel UpdateAuthorById(UpdateAuthorByIdRequestModel model)
        {
            var author = _context.AuthorDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            author.Name = model.Name;
            author.RealName = model.RealName;
            author.Bio = model.Bio;
            author.UpdatedUserId = "2";
            author.UpdatedDate = DateTime.Now;


            _context.AuthorDbSet.Update(author);
            _context.SaveChanges();

            UpdateAuthorByIdResponseModel result = new UpdateAuthorByIdResponseModel();
            return result;
        }

        public DeleteAuthorByIdResponseModel DeleteAuthorById(DeleteAuthorByIdRequestModel model)
        {
            var author = _context.AuthorDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.AuthorDbSet.Remove(author);
            _context.SaveChanges();

            DeleteAuthorByIdResponseModel result = new DeleteAuthorByIdResponseModel();
            return result;
        }
    }
}