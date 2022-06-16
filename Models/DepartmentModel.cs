using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }

        [Required, Display(Name = "Department Name")]
        public string? DeptName { get; set; }
    }
}
