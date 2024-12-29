namespace LibrarySystem.Models.Staff
{
    public class StaffModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }
    }
}

