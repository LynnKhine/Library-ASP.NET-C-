namespace LibrarySystem.Models.Customer
{
    public class GetCustomerByIdRequestModel
    {
        public string Id { get; set; }
    }

    public class GetCustomerResponseModel
    {
        public CustomerModel CustomerRes { get; set; }

    }
}
