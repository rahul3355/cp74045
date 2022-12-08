using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class AdminsService
    {
        private AppDbContext _context;
        public AdminsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAdmin(AdminVM admin)
        {
            var _admin = new Admin()
            {
                AdminUsername = admin.AdminUsername,
                AdminPassword = admin.AdminPassword
            };
            _context.Admins.Add(_admin);
            _context.SaveChanges();
        }

        public List<Admin> GetAllAdmins() => _context.Admins.ToList();

        public Admin GetAdminById(int adminId) => _context.Admins.FirstOrDefault(n => n.AdminId == adminId);

        public Admin UpdateAdminById(int Id, AdminVM admin)
        {
            var _admin = _context.Admins.FirstOrDefault(n => n.AdminId == Id);
            if (_admin != null)
            {
             
                _admin.AdminUsername = admin.AdminUsername;
                _admin.AdminPassword = admin.AdminPassword;

                _context.SaveChanges();
            }
            return _admin;
        }

        public void DeleteAdminById(int adminId)
        {
            var _admin = _context.Admins.FirstOrDefault(n => n.AdminId == adminId);
            if (_admin != null)
            {
                _context.Admins.Remove(_admin);
                _context.SaveChanges();
            }
        }



    }
}
