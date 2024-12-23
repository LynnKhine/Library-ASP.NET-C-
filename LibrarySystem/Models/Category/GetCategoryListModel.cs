using LibrarySystem.Entities;

namespace LibrarySystem.Models.Category
{
    public class GetCategoryListModel
    {

    }

    public class GetCategoryListRequestModel
    {

    }

    public class GetCategoryListResponseModel
    {
        public List<CategoryEntity> CategoryList { get; set; } = new List<CategoryEntity>();
    }
}
