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

        public List<Asset> GetAllAssets() => _context.Assets.ToList();

        public Asset GetAssetById(int assetId) => _context.Assets.FirstOrDefault(n => n.AssetId == assetId);

        public Asset UpdateAssetById(int Id, AssetVM asset)
        {
            var _asset = _context.Assets.FirstOrDefault(n => n.AssetId == Id);
            if (_asset != null)
            {

                _asset.AssetType = asset.AssetType;
                _asset.ModelNumber = asset.ModelNumber;

                _context.SaveChanges();
            }
            return _asset;
        }

        public void DeleteAssetById(int assetId)
        {
            var _asset = _context.Assets.FirstOrDefault(n => n.AssetId == assetId);
            if (_asset != null)
            {
                _context.Assets.Remove(_asset);
                _context.SaveChanges();
            }
        }
    }
}
