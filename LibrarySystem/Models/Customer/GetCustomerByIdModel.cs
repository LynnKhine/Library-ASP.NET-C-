namespace LibrarySystem.Models.Customer
{
    public class GetCustomerRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public bool IsBorrowed { get; set; }

    }

    public class GetCustomerResponseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public bool IsBorrowed { get; set; }

    }

    public class GetCustomerByIdModel
    {
        public string Id { get; set; }
    }
}
