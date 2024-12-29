using Microsoft.EntityFrameworkCore;
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
                RoleId = model.RoleId,
                Email = model.Email,
                UserName = model.UserName,
                HashedPassword = model.HashedPassword,
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

        //Without Join for Get
        public GetStaffByIdResponseModel GetStaffById(GetStaffByIdRequestModel model)
        {
            var staff = _context.StaffDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            StaffModel staffmodel = new StaffModel()
            {
                Id = staff.Id,
                Name = staff.Name,
                Email = staff.Email,
                UserName = staff.UserName,
                HashedPassword = staff.HashedPassword
            };


            GetStaffByIdResponseModel result = new GetStaffByIdResponseModel()
            {
                StaffRes = staffmodel
            };

            return result;
        }

        public GetStaffListResponseModel GetStaffList(GetStaffListRequestModel model)
        {
            var result = new GetStaffListResponseModel(); // might not work no where condition for role name
            result.StaffList = _context.StaffDbSet.AsNoTracking().ToList();

            return result;
        }


        //With Join for Get

        public GetStaffByIdResponseModel GetStaffByIdJoin(GetStaffByIdRequestModel model)
        {
            var staffdetails = _context.StaffDbSet
                .Join(_context.RoleDbSet,
                        staff => staff.RoleId,
                        role => role.Id,
                        (staff, role) => new { staff, role })
                .Select(staff => new StaffModel
                {
                    Id = staff.staff.Id,
                    Name = staff.staff.Name,
                    RoleId = staff.role.Id,
                    RoleName = staff.role.Name,
                    Email = staff.staff.Email,
                    UserName = staff.staff.UserName,
                    HashedPassword = staff.staff.HashedPassword
                }).FirstOrDefault();

            GetStaffByIdResponseModel result = new GetStaffByIdResponseModel()
            {
                StaffRes = staffdetails
            };

            return result;
        }

        public GetStaffListResponseModelJoin GetStaffListJoin(GetStaffListRequestModel model)
        {
            var stafflist = _context.StaffDbSet
                .Join(_context.RoleDbSet,
                        staff => staff.RoleId,
                        role => role.Id,
                        (staff, role) => new { staff, role })
                .Where(staff => staff.role.Name == model.RoleName)
                .AsNoTracking()
                .Select(staff => new StaffModel
                {
                    Id = staff.staff.Id,
                    Name = staff.staff.Name,
                    RoleId = staff.role.Id,
                    RoleName = staff.role.Name,
                    Email = staff.staff.Email,
                    UserName = staff.staff.UserName,
                    HashedPassword = staff.staff.HashedPassword
                }).ToList();

            var role = _context.RoleDbSet.Where(r => r.Name == model.RoleName)
                .AsNoTracking().FirstOrDefault();

            GetStaffListResponseModelJoin result = new GetStaffListResponseModelJoin()
            {
                RoleName = role.Name,
                StaffList = stafflist
            };

            return result;
        }

        public UpdateStaffByIdResponseModel UpdateStaffById(UpdateStaffByIdRequestModel model)
        {
            var staff = _context.StaffDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            staff.Name = model.Name;
            staff.RoleId = model.RoleId;
            staff.Email = model.Email;
            staff.UserName = model.UserName;
            staff.HashedPassword = model.HashedPassword;
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