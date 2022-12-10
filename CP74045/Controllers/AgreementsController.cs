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
    public class AgreementsController : ControllerBase
    {
        public AgreementsService _agreementsService;
        public AgreementsController(AgreementsService agreementsService)
        {
            _agreementsService = agreementsService;
        }

        [HttpPost("add-agreement")]
        public IActionResult AddAgreement([FromBody]AgreementVM agreement)
        {
            _agreementsService.AddAgreement(agreement);
            return Ok();
        }

        [HttpGet("get-all-agreements")]
        public IActionResult GetAllAgreements()
        {
            var allagreements = _agreementsService.GetAllAgreements();
            return Ok(allagreements);
        }

        [HttpGet("get-agreement-by-id/{id}")]
        public IActionResult GetAgreementById(int id)
        {
            var agreement = _agreementsService.GetAgreementById(id);
            return Ok(agreement);
        }

        [HttpPut("update-agreement-by-id/{id}")]
        public IActionResult UpdateAgreementById(int id, [FromBody]AgreementVM agreement)
        {
            var updatedAgreement = _agreementsService.UpdateAgreementById(id, agreement);
            return Ok(updatedAgreement);
        }

        [HttpDelete("delete-agreement-by-id/{id}")]
        public IActionResult DeleteAgreementById(int id)
        {
            _agreementsService.DeleteAgreementById(id);
            return Ok();
        }
    }
}