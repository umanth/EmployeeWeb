using EmployeeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWeb.Service.Interface
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetEmployees();
        List<EmployeeViewModel> SaveEmployee(EmployeeViewModel emp);
    }
}
