using System.ComponentModel.DataAnnotations;
namespace ScondDemoModels.Models
{
    public class Employee:IValidatableObject
    {
        [Required(ErrorMessage = "EmpId is required")]
        [Display(Name = "Emp Id")]
        public int EmpId { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Employee Name")]
        [MaxLength(40, ErrorMessage = "Name must have less than 40 characters")]
        [MinLength(2)]
        public string? Name { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }
        [Required]
        public double Salary { get; set; }


        [Required]
        [Range(18, 60)]
        public int Age { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage = "Password does not match")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var PName = new[] { "Dob" };
            if (Dob > DateTime.Now)
            {
                yield return new ValidationResult("Date of birth can not be in future", PName);
            }
            if (Dob < DateTime.Now.AddYears(-100))
            {
                yield return new ValidationResult("Date of birth can not be in too past", PName);
            }
        }






    }

}
