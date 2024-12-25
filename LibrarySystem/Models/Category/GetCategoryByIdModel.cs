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

    public class GetCategoryByIdRequestModel
    {
        public string Id { get; set; }
    }
}
