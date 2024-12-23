﻿namespace LibrarySystem.Models.Customer
{
    public class CreateCustomerRequestModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public bool IsBorrowed { get; set; }
    }

    public class CreateCustomerListModel
    {
        public List<CreateCustomerRequestModel> CustomerList { get; set; } = new List<CreateCustomerRequestModel>();
    }

    public class CreateCustomerResponseModel
    {

    }
}