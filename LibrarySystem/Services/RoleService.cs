using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.Role;

namespace LibrarySystem.Services
{

    public class RoleService
    {
        private readonly AppDbContext _context;

        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public CreateRoleResponseModel CreateRole(CreateRoleRequestModel model)
        {
            RoleEntity role = new RoleEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Description = model.Description,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.RoleDbSet.Add(role);
            _context.SaveChanges();

            RoleModel roleModel = new RoleModel()
            {
                Id = role.Id,
                Name = model.Name,
                Description = model.Description
            };

            CreateRoleResponseModel result = new CreateRoleResponseModel()
            {
                RoleRes = roleModel

                //RoleId = role.Id
            };

            return result;
        }

        public GetRoleByIdResponseModel GetRoleById(GetRoleByIdRequestModel model)
        {
            var role = _context.RoleDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            RoleModel roleModel = new RoleModel()
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description
            };

            GetRoleByIdResponseModel result = new GetRoleByIdResponseModel()
            {
                RoleRes = roleModel
            };

            return result;
        }

        public GetRoleListResponseModel GetRoleList(GetRoleListRequestModel model)
        {
            var result = new GetRoleListResponseModel();
            result.RoleList = _context.RoleDbSet.AsNoTracking().ToList();

            return result;
        }

        public UpdateRoleByIdResponseModel UpdateRoleById(UpdateRoleByIdRequestModel model)
        {
            var role = _context.RoleDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            role.Name = model.Name;
            role.Description = model.Description;
            role.UpdatedUserId = "2";
            role.UpdatedDate = DateTime.Now;


            _context.RoleDbSet.Update(role);
            _context.SaveChanges();

            UpdateRoleByIdResponseModel result = new UpdateRoleByIdResponseModel();
            return result;
        }

        public DeleteRoleByIdResponseModel DeleteRoleById(DeleteRoleByIdRequestModel model)
        {
            var role = _context.RoleDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.RoleDbSet.Remove(role);
            _context.SaveChanges();

            DeleteRoleByIdResponseModel result = new DeleteRoleByIdResponseModel();
            return result;
        }
    }
}