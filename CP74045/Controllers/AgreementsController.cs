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
    }
}