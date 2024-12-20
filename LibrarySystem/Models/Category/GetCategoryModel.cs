namespace LibrarySystem.Models.Category
{
    public class GetCategoryRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class GetCategoryResponseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class GetCategoryListResponseModel
    {
        public List<GetCategoryRequestModel> ListCategories { get; set; } = new List<GetCategoryRequestModel>();
    }
}
