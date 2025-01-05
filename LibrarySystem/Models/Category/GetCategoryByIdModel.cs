namespace LibrarySystem.Models.Category
{
    public class GetCategoryByIdRequestModel
    {
        public string Id { get; set; }
    }

    public class GetCategoryByIdResponseModel
    {
        public CategoryModel CategoryRes { get; set; }

    }
}
