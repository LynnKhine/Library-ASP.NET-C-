namespace LibrarySystem.Models.Role
{
    public class GetRoleByIdRequestModel
    {
        public string Id { get; set; }
    }

    public class GetRoleByIdResponseModel
    {
        public RoleModel RoleRes { get; set; }

    }
}
