﻿namespace LibrarySystem.Models.Author
{
    public class CreateAuthorRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RealName { get; set; }

        public string Bio { get; set; }
    }

    public class CreateAuthorListModel
    {
        public List<CreateAuthorRequestModel> AuthorList { get; set; } = new List<CreateAuthorRequestModel>();

    }

    public class CreateAuthorResponseModel
    {

    }
}