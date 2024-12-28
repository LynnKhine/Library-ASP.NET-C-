using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.Book;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        //Without Join for Get
        public GetBookByIdResponseModel GetBookById(GetBookByIdRequestModel model)
        {
            var book = _context.BookDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            BookModel bookmodel = new BookModel()
            {
                Id = book.Id,
                Name = book.Name,
                PublishedYear = book.PublishedYear,
                TotalQuantity = book.TotalQuantity,
                AvailableQuantity = book.AvailableQuantity
            };

            GetBookByIdResponseModel result = new GetBookByIdResponseModel()
            {
                Book = bookmodel
            };

            return result;

            //return new GetBookByIdResponseModel
            //{
            //    Book = result
            //};
        }

        public GetBookListResponseModel GetBookList(GetBookListRequestModel model)
        {
            var result = new GetBookListResponseModel();
            result.BookList = _context.BookDbSet.AsNoTracking().ToList();

            return result;
        }

        //With Join for Get
        public GetBookByIdResponseModel GetBookByIdJoin(GetBookByIdRequestModel model)
        {
            var bookdetails = _context.BookDbSet
                .Join(_context.AuthorDbSet,
                        book => book.AuthorId,
                        author => author.Id,
                        (book, author) => new { book, author })
                .Join(_context.CategoryDbSet,
                        book_author => book_author.book.CategoryId,
                        category => category.Id,
                        (book_author, category) => new
                        {
                            book_author.book,
                            book_author.author,
                            category
                        })
                //.Where(book => book.author.Id == model.AuthorId && book.category.Id == model.CategoryId)
                .Select(book => new BookModel
                {
                    Id = book.book.Id,
                    Name = book.book.Name,
                    AuthorId = book.book.AuthorId,
                    AuthorName = book.author.Name,
                    CategoryId = book.book.CategoryId,
                    CategoryName = book.category.Name,
                    PublishedYear = book.book.PublishedYear,
                    TotalQuantity = book.book.TotalQuantity,
                    AvailableQuantity = book.book.AvailableQuantity
                }).FirstOrDefault();

            //if (bookdetails == null)
            //{
            //    throw new KeyNotFoundException($"Book with Id {bookdetails} not found.");
            //}

            GetBookByIdResponseModel result = new GetBookByIdResponseModel()
            {
                Book = bookdetails
            };

            return result;
        }

        public GetBookListResponseModelJoin GetBookListJoin(GetBookListRequestModel model)
        {
            var booklist = _context.BookDbSet
                .Join(_context.AuthorDbSet,
                        book => book.AuthorId,
                        author => author.Id,
                        (book, author) => new { book, author })
                .Join(_context.CategoryDbSet,
                        book_author => book_author.book.CategoryId,
                        category => category.Id,
                        (book_author, category) => new
                        {
                            book_author.book,
                            book_author.author,
                            category
                        })
                .Where(book => book.author.Name == model.AuthorName && book.category.Name == model.CategoryName)
                .AsNoTracking()
                .Select(book => new BookModel
                {
                    Id = book.book.Id,
                    Name = book.book.Name,
                    AuthorId = book.author.Id,
                    AuthorName = book.author.Name,
                    CategoryId = book.category.Id,
                    CategoryName = book.category.Name,
                    PublishedYear = book.book.PublishedYear,
                    TotalQuantity = book.book.TotalQuantity,
                    AvailableQuantity = book.book.AvailableQuantity
                }).ToList();

            var author = _context.AuthorDbSet.Where(a => a.Name == model.AuthorName)
                .AsNoTracking().FirstOrDefault();
            var category = _context.CategoryDbSet.Where(c => c.Name == model.CategoryName)
                .AsNoTracking().FirstOrDefault();

            GetBookListResponseModelJoin result = new GetBookListResponseModelJoin()
            {
                AuthorName = author.Name,
                CategoryName = category.Name,
                BookList = booklist
            };

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