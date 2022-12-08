using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class EmployeesService
    {
        private AppDbContext _context;
        public EmployeesService(AppDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(EmployeeVM employee)
        {
            var _employee = new Employee()
            {
                EmployeeUsername = employee.EmployeeUsername,
                EmployeePassword = employee.EmployeePassword,
                EmployeeName = employee.EmployeeName,
                EmployeePicture = employee.EmployeePicture,
                EmployeePhone = employee.EmployeePhone,
                EmployeeEmail = employee.EmployeeEmail,
                EmployeeGender = employee.EmployeeGender,
                EmployeeDesignation = employee.EmployeeDesignation,
                EmployeeLocation = employee.EmployeeLocation
            };
            _context.Employees.Add(_employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees() => _context.Employees.ToList();

        public Employee GetEmployeeById(int employeeId) => _context.Employees.FirstOrDefault(n => n.EmployeeId == employeeId);

        public Employee UpdateEmployeeById(int Id, EmployeeVM employee)
        {
            var _employee = _context.Employees.FirstOrDefault(n => n.EmployeeId == Id);
            if (_employee != null)
            {

                _employee.EmployeeUsername = employee.EmployeeUsername;
                _employee.EmployeePassword = employee.EmployeePassword;
                _employee.EmployeeName = employee.EmployeeName;
                _employee.EmployeePicture = employee.EmployeePicture;
                _employee.EmployeePhone = employee.EmployeePhone;
                _employee.EmployeeEmail = employee.EmployeeEmail;
                _employee.EmployeeGender = employee.EmployeeGender;
                _employee.EmployeeDesignation = employee.EmployeeDesignation;
                _employee.EmployeeLocation = employee.EmployeeLocation;

                _context.SaveChanges();
            }
            return _employee;
        }

        public void DeleteEmployeeById(int employeeId)
        {
            var _employee = _context.Employees.FirstOrDefault(n => n.EmployeeId == employeeId);
            if (_employee != null)
            {
                _context.Employees.Remove(_employee);
                _context.SaveChanges();
            }
        }

    }
}
