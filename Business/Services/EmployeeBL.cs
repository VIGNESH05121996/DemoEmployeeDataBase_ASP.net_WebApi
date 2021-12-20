using Business.Interfaces;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class EmployeeBL : Interfaces.IEmployeeBL<Employee>
    {
        public Repository.Interfaces.IEmployeeRL<Employee> employeeRL;

        public EmployeeBL(Repository.Interfaces.IEmployeeRL<Employee> employeeRL)
        {
            this.employeeRL = employeeRL;
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.employeeRL.GetAll();
        }
    }
}
