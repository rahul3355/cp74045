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
    public class AssetsController : ControllerBase
    {
        public AssetsService _assetsService;
        public AssetsController(AssetsService assetsService)
        {
            _assetsService = assetsService;
        }

        [HttpPost("add-asset")]
        public IActionResult AddAsset([FromBody]AssetVM asset)
        {
            _assetsService.AddAsset(asset);
            return Ok();
        }
    }
}