using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.BorrowHistory;

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
        public GetBorrowHistoryResponseModel GetBorrowHistoryById(GetBorrowHistoryByIdRequestModel model)
        {
            var borrowhistory = _context.BorrowHistoryDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            GetBorrowHistoryResponseModel result = new GetBorrowHistoryResponseModel()
            {
                Id = borrowhistory.Id,
                BorrowDate = borrowhistory.BorrowDate,
                DueDate= borrowhistory.DueDate,
                ReturnDate = borrowhistory.ReturnDate
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
        public GetBorrowHis

        Customer Book Id 


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