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

        [HttpGet("get-all-assets")]
        public IActionResult GetAllAssets()
        {
            var allassets = _assetsService.GetAllAssets();
            return Ok(allassets);
        }

        [HttpGet("get-asset-by-id/{id}")]
        public IActionResult GetAssetById(int id)
        {
            var asset = _assetsService.GetAssetById(id);
            return Ok(asset);
        }

        [HttpPut("update-asset-by-id/{id}")]
        public IActionResult UpdateAssetById(int id, [FromBody]AssetVM asset)
        {
            var updatedAsset = _assetsService.UpdateAssetById(id, asset);
            return Ok(updatedAsset);
        }

        [HttpDelete("delete-asset-by-id/{id}")]
        public IActionResult DeleteAssetById(int id)
        {
            _assetsService.DeleteAssetById(id);
            return Ok();
        }
    }
}