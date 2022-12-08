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
    public class ClientsController : ControllerBase
    {
        public ClientsService _clientsService;
        public ClientsController(ClientsService clientsService)
        {
            _clientsService = clientsService;
        }

        [HttpPost("add-client")]
        public IActionResult AddClient([FromBody]ClientVM client)
        {
            _clientsService.AddClient(client);
            return Ok();
        }

        [HttpGet("get-all-clients")]
        public IActionResult GetAllClients()
        {
            var allclients = _clientsService.GetAllClients();
            return Ok(allclients);
        }

        [HttpGet("get-client-by-id/{id}")]
        public IActionResult GetClientById(int id)
        {
            var client = _clientsService.GetClientById(id);
            return Ok(client);
        }

        [HttpPut("update-client-by-id/{id}")]
        public IActionResult UpdateClientById(int id, [FromBody]ClientVM client)
        {
            var updatedClient = _clientsService.UpdateClientById(id, client);
            return Ok(updatedClient);
        }

        [HttpDelete("delete-client-by-id/{id}")]
        public IActionResult DeleteClientById(int id)
        {
            _clientsService.DeleteClientById(id);
            return Ok();
        }

    }
}