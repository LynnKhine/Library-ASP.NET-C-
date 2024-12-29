namespace LibrarySystem.Models.Staff
{
    public class CreateStaffRequestModel
    {
        public string Name { get; set; }

        public string RoleId { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }
    }

    public class CreateStaffListModel
    {
        public List<CreateStaffRequestModel> StaffList { get; set; } = new List<CreateStaffRequestModel>();
    }

    public class CreateStaffResponseModel
    {
        public string StaffId { get; set; }
    }
}
