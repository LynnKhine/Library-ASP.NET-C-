namespace LibrarySystem.Models.Role
{
    public class GetRoleRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class GetRoleResponseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }

    public class GetRoleByIdRequestModel
    {
        public string Id { get; set; }
    }
}
