using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Book;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly BookService _service;

        public BookController(BookService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateBook")]
        public IActionResult CreateBook(CreateBookRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.CreateBook(model);

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
        [Route("GetBookById")]

        public IActionResult GetBookByIdHttpGet(string id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var model = new GetBookByIdRequestModel { Id = id };
                var result = _service.GetBookByIdJoin(model);

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
        [Route("GetBookById")]

        public IActionResult GetBookById(GetBookByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetBookByIdJoin(model);

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
        [Route("GetBookList")]

        public IActionResult GetBookList(GetBookListRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetBookListJoin(model);

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
        [Route("UpdateBookById")]

        public IActionResult UpdateBookById(UpdateBookByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.UpdateBookById(model);

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
        [Route("DeleteBookById")]

        public IActionResult DeleteBookById(DeleteBookByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.DeleteBookById(model);

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
}
