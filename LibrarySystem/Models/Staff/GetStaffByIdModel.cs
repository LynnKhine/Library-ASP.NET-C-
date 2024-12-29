namespace LibrarySystem.Models.Staff
{
    public class GetStaffByIdRequestModel
    {
        public string Id { get; set; }
    }

    public class GetStaffByIdResponseModel
    {
        public StaffModel StaffRes { get; set; }
    }
}
