﻿using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.Staff;

namespace LibrarySystem.Services
{

    public class StaffService
    {
        private readonly AppDbContext _context;

        public StaffService(AppDbContext context)
        {
            _context = context;
        }

        public CreateStaffResponseModel CreateStaff(CreateStaffRequestModel model)
        {
            StaffEntity staff = new StaffEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                RealName = model.RealName,
                Bio = model.Bio,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.StaffDbSet.Add(staff);
            _context.SaveChanges();

            CreateStaffResponseModel result = new CreateStaffResponseModel()
            {
                StaffId = staff.Id
            };

            return result;
        }

        public GetStaffResponseModel GetStaffById(GetStaffByIdRequestModel model)
        {
            var staff = _context.StaffDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            GetStaffResponseModel result = new GetStaffResponseModel()
            {
                Id = staff.Id,
                Name = staff.Name,
                RealName = staff.RealName,
                Bio = staff.Bio
            };


            return result;
        }

        public GetStaffListResponseModel GetStaffList(GetStaffListRequestModel model)
        {
            var result = new GetStaffListResponseModel();
            result.StaffList = _context.StaffDbSet.AsNoTracking().ToList();

            return result;
        }

        public UpdateStaffByIdResponseModel UpdateStaffById(UpdateStaffByIdRequestModel model)
        {
            var staff = _context.StaffDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            staff.Name = model.Name;
            staff.RealName = model.RealName;
            staff.Bio = model.Bio;
            staff.UpdatedUserId = "2";
            staff.UpdatedDate = DateTime.Now;


            _context.StaffDbSet.Update(staff);
            _context.SaveChanges();

            UpdateStaffByIdResponseModel result = new UpdateStaffByIdResponseModel();
            return result;
        }

        public DeleteStaffByIdResponseModel DeleteStaffById(DeleteStaffByIdRequestModel model)
        {
            var staff = _context.StaffDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.StaffDbSet.Remove(staff);
            _context.SaveChanges();

            DeleteStaffByIdResponseModel result = new DeleteStaffByIdResponseModel();
            return result;
        }
    }
}