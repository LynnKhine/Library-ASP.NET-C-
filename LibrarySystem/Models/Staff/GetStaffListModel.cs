using LibrarySystem.Entities;

namespace LibrarySystem.Models.Staff
{
    public class GetStaffListModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }
    }

    public class GetStaffListRequestModel
    {
        public string RoleName { get; set; }
    }

    public class GetStaffListResponseModel
    {
        public string RoleName { get; set; }
        public List<StaffEntity> StaffList { get; set; } = new List<StaffEntity>();
    }

    public class GetStaffListResponseModelJoin
    {
        public string RoleName { get; set; }
        public List<GetStaffListModel> StaffList { get; set; } = new List<GetStaffListModel>();
    }
}
