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
    public class ProjectsController : ControllerBase
    {
        public ProjectsService _projectsService;
        public ProjectsController(ProjectsService projectsService)
        {
            _projectsService = projectsService;
        }

        [HttpPost("add-project")]
        public IActionResult AddProject([FromBody]ProjectVM project)
        {
            _projectsService.AddProject(project);
            return Ok();
        }

        [HttpGet("get-all-projects")]
        public IActionResult GetAllProjects()
        {
            var allprojects = _projectsService.GetAllProjects();
            return Ok(allprojects);
        }

        [HttpGet("get-project-by-id/{id}")]
        public IActionResult GetProjectById(int id)
        {
            var project = _projectsService.GetProjectById(id);
            return Ok(project);
        }

        [HttpPut("update-project-by-id/{id}")]
        public IActionResult UpdateProjectById(int id, [FromBody]ProjectVM project)
        {
            var updatedProject = _projectsService.UpdateProjectById(id, project);
            return Ok(updatedProject);
        }

        [HttpDelete("delete-client-by-id/{id}")]
        public IActionResult DeleteProjectById(int id)
        {
            _projectsService.DeleteProjectById(id);
            return Ok();
        }
    }
}