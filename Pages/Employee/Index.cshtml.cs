using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeWeb.Models;
using EmployeeWeb.Service.Interface;

namespace EmployeeWeb.Pages.Employee
{
    public class EmployeeModel : PageModel
    {

        private readonly IEmployeeService _service;

        public EmployeeModel(IEmployeeService employeeService)
        {
            _service = employeeService;
        }

        public IList<EmployeeViewModel> Employees { get; set; }

        public void OnGet()
        {
            Employees = _service.GetEmployees();
        }

    }
}