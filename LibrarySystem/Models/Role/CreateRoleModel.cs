﻿namespace LibrarySystem.Models.Role
{
    public class CreateRoleRequestModel
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class CreateRoleListModel
    {
        public List<CreateRoleRequestModel> RoleList { get; set; } = new List<CreateRoleRequestModel>();
    }

    public class CreateRoleResponseModel
    {
        public string RoleId { get; set; }
    }
}
