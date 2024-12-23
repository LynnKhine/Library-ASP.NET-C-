namespace LibrarySystem.Models.Author
{
    public class GetAuthorRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RealName { get; set; }

        public string Bio {  get; set; }

    }

    public class GetAuthorResponseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string RealName { get; set; }

        public string Bio { get; set; }

        //public string CreatedUserId { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public string? UpdatedUserId { get; set; }

        //public DateTime? UpdatedDate { get; set; }
    }

    public class GetAuthorByIdRequestModel
    {
        public string Id { get; set; }
    }
}
