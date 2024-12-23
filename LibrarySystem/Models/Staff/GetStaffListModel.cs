using LibrarySystem.Entities;

namespace LibrarySystem.Models.Staff
{
    public class GetStaffListModel
    {

    }

    public class GetStaffListRequestModel
    {

    }

    public class GetStaffListResponseModel
    {
        public List<StaffEntity> StaffList { get; set; } = new List<StaffEntity>();
    }
}
