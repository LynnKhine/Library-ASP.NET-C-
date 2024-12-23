namespace LibrarySystem.Models.Staff
{
    public class UpdateStaffByIdModel
    {

    }
    public class UpdateStaffByIdRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RoleId { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }
    }
    public class UpdateStaffByIdResponseModel
    {

    }
}
