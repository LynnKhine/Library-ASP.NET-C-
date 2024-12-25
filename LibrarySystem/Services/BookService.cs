using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.Book;

namespace LibrarySystem.Services
{

    public class BookService
    {
        private readonly AppDbContext _context;

        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public CreateBookResponseModel CreateBook(CreateBookRequestModel model)
        {
            BookEntity book = new BookEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                PublishedYear = model.PublishedYear,
                TotalQuantity = model.TotalQuantity,
                AvailableQuantity = model.AvailableQuantity,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.BookDbSet.Add(book);
            _context.SaveChanges();

            CreateBookResponseModel result = new CreateBookResponseModel()
            {
                BookId = book.Id
            };

            return result;
        }

        public GetBookResponseModel GetBookById(GetBookByIdRequestModel model)
        {
            var book = _context.BookDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            GetBookResponseModel result = new GetBookResponseModel()
            {
                Id = book.Id,
                Name = book.Name,
                PublishedYear = book.PublishedYear,
                TotalQuantity = book.TotalQuantity,
                AvailableQuantity = book.AvailableQuantity
            };


            return result;
        }

        public GetBookListResponseModel GetBookList(GetBookListRequestModel model)
        {
            var result = new GetBookListResponseModel();
            result.BookList = _context.BookDbSet.AsNoTracking().ToList();

            return result;
        }

        public UpdateBookByIdResponseModel UpdateBookById(UpdateBookByIdRequestModel model)
        {
            var book = _context.BookDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            book.Name = model.Name;
            book.PublishedYear = model.PublishedYear;
            book.TotalQuantity = model.TotalQuantity;
            book.AvailableQuantity = model.AvailableQuantity;
            book.UpdatedUserId = "2";
            book.UpdatedDate = DateTime.Now;


            _context.BookDbSet.Update(book);
            _context.SaveChanges();

            UpdateBookByIdResponseModel result = new UpdateBookByIdResponseModel();
            return result;
        }

        public DeleteBookByIdResponseModel DeleteBookById(DeleteBookByIdRequestModel model)
        {
            var book = _context.BookDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.BookDbSet.Remove(book);
            _context.SaveChanges();

            DeleteBookByIdResponseModel result = new DeleteBookByIdResponseModel();
            return result;
        }
    }
}