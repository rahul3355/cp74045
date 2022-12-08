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
    public class TeamsController : ControllerBase
    {
        public TeamsService _teamsService;
        public TeamsController(TeamsService teamsService)
        {
            _teamsService = teamsService;
        }

        [HttpPost("add-team")]
        public IActionResult AddClient([FromBody]TeamVM client)
        {
            _teamsService.AddTeam(client);
            return Ok();
        }

        [HttpGet("get-all-teams")]
        public IActionResult GetAllTeams()
        {
            var allteams = _teamsService.GetAllTeams();
            return Ok(allteams);
        }

        [HttpGet("get-team-by-id/{id}")]
        public IActionResult GetTeamById(int id)
        {
            var team = _teamsService.GetTeamById(id);
            return Ok(team);
        }

        [HttpPut("update-team-by-id/{id}")]
        public IActionResult UpdateTeamById(int id, [FromBody]TeamVM team)
        {
            var updatedTeam = _teamsService.UpdateTeamById(id, team);
            return Ok(updatedTeam);
        }

        [HttpDelete("delete-team-by-id/{id}")]
        public IActionResult DeleteTeamById(int id)
        {
            _teamsService.DeleteTeamById(id);
            return Ok();
        }
    }
}