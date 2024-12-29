using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.BorrowHistory;
using LibrarySystem.Models.Book;

namespace LibrarySystem.Services
{

    public class BorrowHistoryService
    {
        private readonly AppDbContext _context;

        public BorrowHistoryService(AppDbContext context)
        {
            _context = context;
        }

        public CreateBorrowHistoryResponseModel CreateBorrowHistory(CreateBorrowHistoryRequestModel model)
        {
            BorrowHistoryEntity borrowhistory = new BorrowHistoryEntity()
            {
                Id = Guid.NewGuid().ToString(),
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14),
                ReturnDate = DateTime.MinValue,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.BorrowHistoryDbSet.Add(borrowhistory);
            _context.SaveChanges();

            CreateBorrowHistoryResponseModel result = new CreateBorrowHistoryResponseModel()
            {
                BorrowHistoryId = borrowhistory.Id
            };

            return result;
        }

        //Without Join for Get
        public GetBorrowHistoryByIdResponseModel GetBorrowHistoryById(GetBorrowHistoryByIdRequestModel model)
        {
            var borrowhistory = _context.BorrowHistoryDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            BorrowHistoryModel borrowhistorymodel = new BorrowHistoryModel()
            {
                Id = borrowhistory.Id,
                BorrowDate = borrowhistory.BorrowDate,
                DueDate= borrowhistory.DueDate,
                ReturnDate = borrowhistory.ReturnDate
            };

            GetBorrowHistoryByIdResponseModel result = new GetBorrowHistoryByIdResponseModel()
            {
                BorrowHistoryRes = borrowhistorymodel
            };

            return result;
        }

        public GetBorrowHistoryListResponseModel GetBorrowHistoryList(GetBorrowHistoryListRequestModel model)
        {
            var result = new GetBorrowHistoryListResponseModel();
            result.BorrowHistoryList = _context.BorrowHistoryDbSet.AsNoTracking().ToList();

            return result;
        }

        //With Join for Get
        public GetBorrowHistoryByIdResponseModel GetBorrowHistoryByIdJoin(GetBorrowHistoryByIdRequestModel model)
        {
            var borrowhistorydetails = _context.BorrowHistoryDbSet
                .Join(_context.CustomerDbSet,
                        borrowhistory => borrowhistory.CustomerId,
                        customer => customer.Id,
                        (borrowhistory, customer) => new {borrowhistory,  customer})
                .Join(_context.BookDbSet,
                        borrowhistory_customer => borrowhistory_customer.borrowhistory.BookId,
                        book => book.Id,
                        (borrowhistory_customer, book) => new
                        {
                            borrowhistory_customer.borrowhistory,
                            borrowhistory_customer.customer,
                            book
                        })
                .Select(borrowhistory => new BorrowHistoryModel
                {
                    Id = borrowhistory.borrowhistory.Id,
                    CustomerId = borrowhistory.customer.Id,
                    CustomerName = borrowhistory.customer.Name,
                    BookId = borrowhistory.book.Id,
                    BookName = borrowhistory.book.Name,
                    BorrowDate = borrowhistory.borrowhistory.BorrowDate,
                    DueDate = borrowhistory.borrowhistory.DueDate,
                    ReturnDate = borrowhistory.borrowhistory.ReturnDate
                }).FirstOrDefault();

            GetBorrowHistoryByIdResponseModel result = new GetBorrowHistoryByIdResponseModel()
            {
                BorrowHistoryRes = borrowhistorydetails
            };

            return result;
        }

        public GetBorrowHistoryListResponseModelJoin GetBorrowHistoryListJoin(GetBorrowHistoryListRequestModel model)
        {
            var borrowhistorylist = _context.BorrowHistoryDbSet
                .Join(_context.CustomerDbSet,
                    borrowhistory => borrowhistory.CustomerId,
                    customer => customer.Id,
                    (borrowhistory, customer) => new { borrowhistory, customer })
                .Join(_context.BookDbSet,
                    borrowhistory_customer => borrowhistory_customer.borrowhistory.BookId,
                    book => book.Id,
                    (borrowhistory_customer, book) => new
                    {
                        borrowhistory_customer.borrowhistory,
                        borrowhistory_customer.customer,
                        book
                    })
                .Where(borrowhistory => borrowhistory.customer.Name == model.CustomerName && 
                                        borrowhistory.book.Name == model.BookName)
                .AsNoTracking()
                .Select(borrowhistory => new BorrowHistoryModel
                {
                    Id = borrowhistory.borrowhistory.Id,
                    CustomerId = borrowhistory.customer.Id,
                    CustomerName = borrowhistory.customer.Name,
                    BookId = borrowhistory.book.Id,
                    BookName = borrowhistory.book.Name,
                    BorrowDate = borrowhistory.borrowhistory.BorrowDate,
                    DueDate = borrowhistory.borrowhistory.DueDate,
                    ReturnDate = borrowhistory.borrowhistory.ReturnDate
                }).ToList();

            var customer = _context.CustomerDbSet.Where(c => c.Name == model.CustomerName)
                .AsNoTracking().FirstOrDefault();
            var book = _context.BookDbSet.Where(b => b.Name == model.BookName) 
                .AsNoTracking().FirstOrDefault();

            GetBorrowHistoryListResponseModelJoin result = new GetBorrowHistoryListResponseModelJoin()
            {
                CustomerName = customer.Name,
                BookName = book.Name,
                BorrowHistoryList = borrowhistorylist
            };

            return result;

        }


        public UpdateBorrowHistoryByIdResponseModel UpdateBorrowHistoryById(UpdateBorrowHistoryByIdRequestModel model)
        {
            var borrowhistory = _context.BorrowHistoryDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            borrowhistory.BorrowDate = model.BorrowDate;
            borrowhistory.DueDate = model.DueDate;
            borrowhistory.ReturnDate = model.ReturnDate;
            borrowhistory.UpdatedUserId = "2";
            borrowhistory.UpdatedDate = DateTime.Now;


            _context.BorrowHistoryDbSet.Update(borrowhistory);
            _context.SaveChanges();

            UpdateBorrowHistoryByIdResponseModel result = new UpdateBorrowHistoryByIdResponseModel();
            return result;
        }

        public DeleteBorrowHistoryByIdResponseModel DeleteBorrowHistoryById(DeleteBorrowHistoryByIdRequestModel model)
        {
            var borrowhistory = _context.BorrowHistoryDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.BorrowHistoryDbSet.Remove(borrowhistory);
            _context.SaveChanges();

            DeleteBorrowHistoryByIdResponseModel result = new DeleteBorrowHistoryByIdResponseModel();
            return result;
        }
    }
}