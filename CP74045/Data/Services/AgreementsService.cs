using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class AgreementsService
    {
        private AppDbContext _context;
        public AgreementsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAgreement(AgreementVM agreement)
        {
            var _agreement = new Agreement()
            {
                AgreementFile = agreement.AgreementFile,
                
            };
            _context.Agreements.Add(_agreement);
            _context.SaveChanges();
        }

        public List<Agreement> GetAllAgreements() => _context.Agreements.ToList();

        public Agreement GetAgreementById(int agreementId) => _context.Agreements.FirstOrDefault(n => n.AgreementId == agreementId);

        public Agreement UpdateAgreementById(int Id, AgreementVM agreement)
        {
            var _agreement = _context.Agreements.FirstOrDefault(n => n.AgreementId == Id);
            if (_agreement != null)
            {

                _agreement.AgreementFile = agreement.AgreementFile;
                

                _context.SaveChanges();
            }
            return _agreement;
        }

        public void DeleteAgreementById(int agreementId)
        {
            var _agreement = _context.Agreements.FirstOrDefault(n => n.AgreementId == agreementId);
            if (_agreement != null)
            {
                _context.Agreements.Remove(_agreement);
                _context.SaveChanges();
            }
        }

    }
}
