using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Models.Role;
using LibrarySystem.Services;

namespace LibrarySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        private readonly RoleService _service;

        public RoleController(RoleService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("CreateRole")]
        public IActionResult CreateRole(CreateRoleRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.CreateRole(model);

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
        [Route("GetRoleById")]

        public IActionResult GetRoleByIdHttpGet(string id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var model = new GetRoleByIdRequestModel { Id = id };
                var result = _service.GetRoleById(model);

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
        [Route("GetRoleById")]

        public IActionResult GetRoleById(GetRoleByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetRoleById(model);

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
        [Route("GetRoleList")]

        public IActionResult GetRoleList(GetRoleListRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.GetRoleList(model);

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
        [Route("DeleteRoleById")]

        public IActionResult DeleteRoleById(DeleteRoleByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.DeleteRoleById(model);

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
        [Route("UpdateRoleById")]

        public IActionResult UpdateRoleById(UpdateRoleByIdRequestModel model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _service.UpdateRoleById(model);

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
