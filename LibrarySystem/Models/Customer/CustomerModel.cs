namespace LibrarySystem.Models.Customer
{
    public class CustomerModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public bool IsBorrowed { get; set; }
    }
}
