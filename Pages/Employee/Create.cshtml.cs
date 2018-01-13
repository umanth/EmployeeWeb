using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeWeb.Service.Interface;
using EmployeeWeb.Models;

namespace EmployeeWeb.Pages.Employee
{
    public class CreateModel : PageModel
    {

        private readonly IEmployeeService _service;

        public CreateModel(IEmployeeService employeeService)
        {
            _service = employeeService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmployeeViewModel Employee { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.SaveEmployee(Employee);

            return RedirectToPage("./Index");
        }
    }

}