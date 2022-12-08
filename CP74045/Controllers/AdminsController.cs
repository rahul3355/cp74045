using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP74045.Data.Services;
using CP74045.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CP74045.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        public AdminsService _adminsService;
        public AdminsController(AdminsService adminsService)
        {
            _adminsService = adminsService;
        }

        [HttpPost("add-admin")]
        public IActionResult AddClient([FromBody]AdminVM client)
        {
            _adminsService.AddAdmin(client);
            return Ok();
        }

        [HttpGet("get-all-admins")]
        public IActionResult GetAllAdmins()
        {
            var alladmins = _adminsService.GetAllAdmins();
            return Ok(alladmins);
        }

        [HttpGet("get-admin-by-id/{id}")]
        public IActionResult GetAdminById(int id)
        {
            var admin = _adminsService.GetAdminById(id);
            return Ok(admin);
        }

        [HttpPut("update-admin-by-id/{id}")]
        public IActionResult UpdateAdminById(int id, [FromBody]AdminVM admin)
        {
            var updatedAdmin = _adminsService.UpdateAdminById(id, admin);
            return Ok(updatedAdmin);
        }

        [HttpDelete("delete-admin-by-id/{id}")]
        public IActionResult DeleteAdminById(int id)
        {
            _adminsService.DeleteAdminById(id);
            return Ok();
        }
    }
}