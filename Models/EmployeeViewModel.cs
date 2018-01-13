using System.ComponentModel.DataAnnotations;

namespace EmployeeWeb.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}
