using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webCrud.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "This field is required.")]
        public string Email { get; set; }

        [DisplayName("Salary")]
        [Required(ErrorMessage = "This field is required.")]
        public long Salary { get; set; }

        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime DateOfBirth { get; set;}
        public string Department { get; set; }
    }
}
