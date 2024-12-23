using LibrarySystem.Entities;

namespace LibrarySystem.Models.Customer
{
    public class GetCustomerListModel
    {

    }

    public class GetCustomerListRequestModel
    {

    }

    public class GetCustomerListResponseModel
    {
        public List<CustomerEntity> CustomerList { get; set; } = new List<CustomerEntity>();
    }
}
