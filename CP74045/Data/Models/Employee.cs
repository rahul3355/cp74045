using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeePicture { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeDesignation { get; set; }
        public string EmployeeLocation { get; set; }

    }
}
