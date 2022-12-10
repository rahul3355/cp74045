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
    public class Project_TeamsController : ControllerBase
    {
        public Project_TeamsService _project_teamsService;
        public Project_TeamsController(Project_TeamsService project_teamsService)
        {
            _project_teamsService = project_teamsService;
        }

        [HttpPost("add-project-team")]
        public IActionResult AddProject_Team([FromBody]Project_TeamVM project_team)
        {
            _project_teamsService.AddProject_Team(project_team);
            return Ok();
        }

        [HttpGet("get-all-project_teams")]
        public IActionResult GetAllProject_Teams()
        {
            var allproject_teams = _project_teamsService.GetAllProject_Teams();
            return Ok(allproject_teams);
        }

        [HttpGet("get-project_team-by-id/{id}")]
        public IActionResult GetProject_TeamById(int id)
        {
            var project_team = _project_teamsService.GetProject_TeamById(id);
            return Ok(project_team);
        }

        [HttpGet("get-project_team-by-projectid/{id}")]
        public IActionResult GetProject_TeamByProjectId(int id)
        {
            var project_team = _project_teamsService.GetProject_TeamByProjectId(id);
            return Ok(project_team);
        }

        [HttpGet("get-project_team-by-teamid/{id}")]
        public IActionResult GetProject_TeamByTeamId(int id)
        {
            var project_team = _project_teamsService.GetProject_TeamByTeamId(id);
            return Ok(project_team);
        }

        [HttpPut("update-project_team-by-id/{id}")]
        public IActionResult UpdateProject_TeamById(int id, [FromBody]Project_TeamVM project_team)
        {
            var updatedProject_Team = _project_teamsService.UpdateProject_TeamById(id, project_team);
            return Ok(updatedProject_Team);
        }

        [HttpDelete("delete-project_team-by-id/{id}")]
        public IActionResult DeleteProject_TeamById(int id)
        {
            _project_teamsService.DeleteProject_TeamById(id);
            return Ok();
        }
    }
}