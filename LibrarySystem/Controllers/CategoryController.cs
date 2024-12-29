using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Category;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : Controller
{
    private readonly CategoryService _service;

    public CategoryController(CategoryService service)
    {
        _service = service;
    }

    [HttpPost]
    [Route("CreateCategory")]
    public IActionResult CreateCategory(CreateCategoryRequestModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.CreateCategory(model);

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
    [Route("GetCategoryById")]

    public IActionResult GetCategoryByIdHttpGet(string id)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var model = new GetCategoryByIdRequestModel { Id = id };
            var result = _service.GetCategoryById(model);

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
    [Route("GetCategoryById")]

    public IActionResult GetCategoryById(GetCategoryByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetCategoryById(model);

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
    [Route("GetCategoryList")]

    public IActionResult GetCategoryList(GetCategoryListRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetCategoryList(model);

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
    [Route("DeleteCategoryById")]

    public IActionResult DeleteCategoryById(DeleteCategoryByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.DeleteCategoryById(model);

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

    [HttpPost]
    [Route("UpdateCategoryById")]

    public IActionResult UpdateCategoryById(UpdateCategoryByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.UpdateCategoryById(model);

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
}
