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
    }
}
