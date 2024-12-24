using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Author;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;

        public AuthorController(AuthorService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateAuthor")]
        public IActionResult CreateAuthor(CreateAuthorRequestModel model)
        {
            var result = _service.CreateAuthor(model);

            return Ok(result);
        }

        //[HttpGet]
        //[Route("GetAuthorById")]

        //public IActionResult GetAuthorById(GetAuthorByIdRequestModel model)
        //{
        //    var result = _service.GetAuthorById(model);

        //    return Ok(result);
        //}

        [HttpPost]
        [Route("GetAuthorById")]

        public IActionResult GetAuthorById(GetAuthorByIdRequestModel model)
        {
            var result = _service.GetAuthorById(model);

            return Ok(result);
        }

        [HttpPost]
        [Route("GetAuthorList")]

        public IActionResult GetAuthorList(GetAuthorListRequestModel model)
        {
            var result = _service.GetAuthorList(model);

            return Ok(result);
        }

        [HttpPost]
        [Route("DeleteAuthorById")]

        public IActionResult DeleteAuthorById(DeleteAuthorByIdRequestModel model)
        {
            var result = _service.DeleteAuthorById(model);

            return Ok("Successfully Deleted");
        }

        [HttpPost]
        [Route("UpdateAuthorById")]

        public IActionResult UpdateAuthorById(UpdateAuthorByIdRequestModel model)
        {
            var result = _service.UpdateAuthorById(model);

            return Ok("Succesfully Updated");
        }
    }
}
