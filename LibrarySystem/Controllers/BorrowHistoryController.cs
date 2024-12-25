using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.BorrowHistory;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowHistoryController : Controller
    {
        private readonly BorrowHistoryService _service;

        public BorrowHistoryController(BorrowHistoryService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateBorrowHistory")]
        public IActionResult CreateBorrowHistory(CreateBorrowHistoryRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.CreateBorrowHistory(model);

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
        [Route("GetBorrowHistoryById")]

        public IActionResult GetBorrowHistoryByIdHttpGet(string id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var model = new GetBorrowHistoryByIdRequestModel { Id = id };
                var result = _service.GetBorrowHistoryById(model);

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
        [Route("GetBorrowHistoryById")]

        public IActionResult GetBorrowHistoryById(GetBorrowHistoryByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetBorrowHistoryById(model);

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
        [Route("GetBorrowHistoryList")]

        public IActionResult GetBorrowHistoryList(GetBorrowHistoryListRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetBorrowHistoryList(model);

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
        [Route("DeleteBorrowHistoryById")]

        public IActionResult DeleteBorrowHistoryById(DeleteBorrowHistoryByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.DeleteBorrowHistoryById(model);

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
        [Route("UpdateBorrowHistoryById")]

        public IActionResult UpdateBorrowHistoryById(UpdateBorrowHistoryByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.UpdateBorrowHistoryById(model);

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
}
