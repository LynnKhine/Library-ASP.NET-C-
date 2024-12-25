namespace LibrarySystem.Models.Category
{
    public class CreateCategoryRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class CreateCategoryListModel
    {
        public List<CreateCategoryRequestModel> CategoryList { get; set; } = new List<CreateCategoryRequestModel>();
    }

    public class CreateCategoryResponseModel
    {
        public string CategoryId { get; set; }
    }
}
