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
    public class Client_ProjectsController : ControllerBase
    {
        public Client_ProjectsService _client_projectsService;
        public Client_ProjectsController(Client_ProjectsService client_projectsService)
        {
            _client_projectsService = client_projectsService;
        }

        [HttpPost("add-client_project")]
        public IActionResult AddClient_Project([FromBody]Client_ProjectVM client_project)
        {
            _client_projectsService.AddClient_Project(client_project);
            return Ok();
        }

        [HttpGet("get-all-client_projects")]
        public IActionResult GetAllClient_Projects()
        {
            var allclient_projects = _client_projectsService.GetAllClient_Projects();
            return Ok(allclient_projects);
        }

        [HttpGet("get-client_project-by-id/{id}")]
        public IActionResult GetClient_ProjectById(int id)
        {
            var client_project = _client_projectsService.GetClient_ProjectById(id);
            return Ok(client_project);
        }

        [HttpGet("get-client_project-by-clientid/{id}")]
        public IActionResult GetClient_ProjectByClientId(int id)
        {
            var client_project = _client_projectsService.GetClient_ProjectByClientId(id);
            return Ok(client_project);
        }

        [HttpGet("get-client_project-by-projectid/{id}")]
        public IActionResult GetClient_ProjectByProjectId(int id)
        {
            var client_project = _client_projectsService.GetClient_ProjectByProjectId(id);
            return Ok(client_project);
        }

        [HttpPut("update-client_project-by-id/{id}")]
        public IActionResult UpdateClient_ProjectById(int id, [FromBody]Client_ProjectVM client_project)
        {
            var updatedClient_Project = _client_projectsService.UpdateClient_ProjectById(id, client_project);
            return Ok(updatedClient_Project);
        }

        [HttpDelete("delete-client_project-by-id/{id}")]
        public IActionResult DeleteClient_ProjectById(int id)
        {
            _client_projectsService.DeleteClient_ProjectById(id);
            return Ok();
        }
    }
}