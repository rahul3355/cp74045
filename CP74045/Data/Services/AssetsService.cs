using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class AssetsService
    {
        private AppDbContext _context;
        public AssetsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAsset(AssetVM asset)
        {
            var _asset = new Asset()
            {
                AssetType = asset.AssetType,
                ModelNumber = asset.ModelNumber,
                
            };
            _context.Assets.Add(_asset);
            _context.SaveChanges();
        }
    }
}
