using LibrarySystem.Entities;

namespace LibrarySystem.Models.Staff
{
    public class GetStaffListRequestModel
    {
        //public string RoleName { get; set; }
    }

    //use in without join
    public class GetStaffListResponseModel
    {
        //public string RoleName { get; set; }
        public List<StaffEntity> StaffList { get; set; } = new List<StaffEntity>();
    }

    public class GetStaffListResponseModelJoin
    {
        //public string RoleName { get; set; }
        public List<StaffModel> StaffList { get; set; } = new List<StaffModel>();
    }
}
