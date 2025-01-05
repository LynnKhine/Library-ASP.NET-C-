using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.Category;

namespace LibrarySystem.Services
{

    public class CategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public CreateCategoryResponseModel CreateCategory(CreateCategoryRequestModel model)
        {
            CategoryEntity category = new CategoryEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Description = model.Description,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.CategoryDbSet.Add(category);
            _context.SaveChanges();

            CreateCategoryResponseModel result = new CreateCategoryResponseModel()
            {
                CategoryId = category.Id
            };

            return result;
        }

        public GetCategoryByIdResponseModel GetCategoryById(GetCategoryByIdRequestModel model)
        {
            var category = _context.CategoryDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            CategoryModel categoryModel = new CategoryModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };

            GetCategoryByIdResponseModel result = new GetCategoryByIdResponseModel()
            {
               CategoryRes = categoryModel
            };


            return result;
        }

        public GetCategoryListResponseModel GetCategoryList(GetCategoryListRequestModel model)
        {
            var result = new GetCategoryListResponseModel();
            result.CategoryList = _context.CategoryDbSet.AsNoTracking().ToList();

            return result;
        }

        public UpdateCategoryByIdResponseModel UpdateCategoryById(UpdateCategoryByIdRequestModel model)
        {
            var category = _context.CategoryDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            category.Name = model.Name;
            category.Description = model.Description;
            category.UpdatedUserId = "2";
            category.UpdatedDate = DateTime.Now;


            _context.CategoryDbSet.Update(category);
            _context.SaveChanges();

            UpdateCategoryByIdResponseModel result = new UpdateCategoryByIdResponseModel();
            return result;
        }

        public DeleteCategoryByIdResponseModel DeleteCategoryById(DeleteCategoryByIdRequestModel model)
        {
            var category = _context.CategoryDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.CategoryDbSet.Remove(category);
            _context.SaveChanges();

            DeleteCategoryByIdResponseModel result = new DeleteCategoryByIdResponseModel();
            return result;
        }
    }
}