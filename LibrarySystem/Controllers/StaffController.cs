using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Staff;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : Controller
    {
        private readonly StaffService _service;

        public StaffController(StaffService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateStaff")]
        public IActionResult CreateStaff(CreateStaffRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.CreateStaff(model);

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
        [Route("GetStaffById")]

        public IActionResult GetStaffByIdHttpGet(string id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var model = new GetStaffByIdRequestModel { Id = id };
                var result = _service.GetStaffByIdJoin(model);

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
        [Route("GetStaffById")]

        public IActionResult GetStaffById(GetStaffByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetStaffByIdJoin(model);

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
        [Route("GetStaffList")]

        public IActionResult GetStaffList(GetStaffListRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetStaffListJoin(model);

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
        [Route("DeleteStaffById")]

        public IActionResult DeleteStaffById(DeleteStaffByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.DeleteStaffById(model);

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
        [Route("UpdateStaffById")]

        public IActionResult UpdateStaffById(UpdateStaffByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.UpdateStaffById(model);

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
