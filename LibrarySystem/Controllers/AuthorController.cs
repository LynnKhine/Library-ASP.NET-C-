﻿using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Author;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : Controller
{
    private readonly AuthorService _service;
    private readonly ILogger<AuthorController> _logger;

    public AuthorController(AuthorService service, ILogger<AuthorController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [HttpPost]
    [Route("CreateAuthor")]
    public IActionResult CreateAuthor(CreateAuthorRequestModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.CreateAuthor(model);

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
    [Route("GetAuthorById")]

    public IActionResult GetAuthorByIdHttpGet(string id)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var model = new GetAuthorByIdRequestModel { Id = id };
            var result = _service.GetAuthorById(model);

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
    [Route("GetAuthorById")]

    public IActionResult GetAuthorById(GetAuthorByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetAuthorById(model);

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
    [Route("GetAuthorByName")]

    public IActionResult GetAuthorByName(GetAuthorByNameRequestModel model)
    {
        _logger.LogInformation("GetAuthorByName executing ... ");


        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetAuthorByName(model);

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
        finally
        {
            _logger.LogInformation("GetAuthorByName Finished ...");
        }
    }
    [HttpPost]
    [Route("GetAuthorList")]

    public IActionResult GetAuthorList(GetAuthorListRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.GetAuthorList(model);

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
    [Route("UpdateAuthorById")]

    public IActionResult UpdateAuthorById(UpdateAuthorByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.UpdateAuthorById(model);

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
    [Route("DeleteAuthorById")]

    public IActionResult DeleteAuthorById(DeleteAuthorByIdRequestModel model)
    {

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = _service.DeleteAuthorById(model);

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

