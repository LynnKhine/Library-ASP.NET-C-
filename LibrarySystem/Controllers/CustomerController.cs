using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Customer;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : Controller
{
    private readonly CustomerService _service;

    public CustomerController(CustomerService service)
    {
        _service = service;
    }

    [HttpPost]
    [Route("CreateCustomer")]
    public IActionResult CreateCustomer(CreateCustomerRequestModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.CreateCustomer(model);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        catch (Exception ex)
        {
            var message = ex.Message;
            return BadRequest(message);
        }

    }

    [HttpGet]
    [Route("GetCustomerById")]

    public IActionResult GetCustomerByIdHttpGet(string id)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var model = new GetCustomerByIdRequestModel { Id = id };
            var result = _service.GetCustomerById(model);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        catch (Exception ex)
        {
            var message = ex.Message;
            return BadRequest(message);
        }
    }

    [HttpPost]
    [Route("GetCustomerById")]

    public IActionResult GetCustomerById(GetCustomerByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetCustomerById(model);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        catch (Exception ex)
        {
            var message = ex.Message;
            return BadRequest(message);
        }
    }

    [HttpPost]
    [Route("GetCustomerList")]

    public IActionResult GetCustomerList(GetCustomerListRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetCustomerList(model);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        catch (Exception ex)
        {
            var message = ex.Message;
            return BadRequest(message);
        }
    }

    [HttpPost]
    [Route("UpdateCustomerById")]

    public IActionResult UpdateCustomerById(UpdateCustomerByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.UpdateCustomerById(model);

            if (result != null)
            {
                return Ok("Succesfully Updated");
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        catch (Exception ex)
        {
            var message = ex.Message;
            return BadRequest(message);
        }
    }

    [HttpPost]
    [Route("DeleteCustomerById")]

    public IActionResult DeleteCustomerById(DeleteCustomerByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.DeleteCustomerById(model);

            if (result != null)
            {
                return Ok("Successfully Deleted");
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        catch (Exception ex)
        {
            var message = ex.Message;
            return BadRequest(message);
        }
    }
}
