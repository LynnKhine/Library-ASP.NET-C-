﻿using LibrarySystem.Entities;

namespace LibrarySystem.Models.Role
{
    public class GetRoleListRequestModel
    {

    }

    public class GetRoleListResponseModel
    {
        public List<RoleEntity> RoleList { get; set; } = new List<RoleEntity>();
    }
}
