using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Data;
using LibrarySystem.Models.Customer;

namespace LibrarySystem.Services
{

    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public CreateCustomerResponseModel CreateCustomer(CreateCustomerRequestModel model)
        {
            CustomerEntity customer = new CustomerEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Address = model.Address,
                IsBorrowed = model.IsBorrowed,
                CreatedUserId = "1",
                CreatedDate = DateTime.Now,
            };
            _context.CustomerDbSet.Add(customer);
            _context.SaveChanges();

            CreateCustomerResponseModel result = new CreateCustomerResponseModel()
            {
                CustomerId = customer.Id
            };

            return result;
        }

        public GetCustomerResponseModel GetCustomerById(GetCustomerByIdRequestModel model)
        {
            var customer = _context.CustomerDbSet.Where(a => a.Id == model.Id).AsNoTracking().FirstOrDefault();

            CustomerModel customermodel = new CustomerModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                PhoneNumber = customer.PhoneNumber,
                Email = customer.Email,
                Address = customer.Address,
                IsBorrowed = customer.IsBorrowed
            };

            GetCustomerResponseModel result = new GetCustomerResponseModel()
            {
                CustomerRes = customermodel
            };

            return result;
        }

        public GetCustomerListResponseModel GetCustomerList(GetCustomerListRequestModel model)
        {
            var result = new GetCustomerListResponseModel();
            result.CustomerList = _context.CustomerDbSet.AsNoTracking().ToList();

            return result;
        }

        public UpdateCustomerByIdResponseModel UpdateCustomerById(UpdateCustomerByIdRequestModel model)
        {
            var customer = _context.CustomerDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            customer.Name = model.Name;
            customer.PhoneNumber = model.PhoneNumber;
            customer.Email = model.Email;
            customer.Address = model.Address;
            customer.IsBorrowed = model.IsBorrowed;
            customer.UpdatedUserId = "2";
            customer.UpdatedDate = DateTime.Now;

            _context.CustomerDbSet.Update(customer);
            _context.SaveChanges();

            UpdateCustomerByIdResponseModel result = new UpdateCustomerByIdResponseModel();
            return result;
        }

        public DeleteCustomerByIdResponseModel DeleteCustomerById(DeleteCustomerByIdRequestModel model)
        {
            var customer = _context.CustomerDbSet.Where(a => a.Id == model.Id).FirstOrDefault();
            _context.CustomerDbSet.Remove(customer);
            _context.SaveChanges();

            DeleteCustomerByIdResponseModel result = new DeleteCustomerByIdResponseModel();
            return result;
        }
    }
}