namespace LibrarySystem.Models.Staff
{
    public class GetStaffRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RoleId { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }

    }

    public class GetStaffResponseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RoleId { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }

    }

    public class GetStaffListResponseModel
    {
        public List<GetStaffRequestModel> ListStaff { get; set; } = new List<GetStaffRequestModel>();
    }
}
