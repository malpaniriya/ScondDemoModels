using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ScondDemoModels.Models
{
    public class Student
    {
        [Required(ErrorMessage = "StudId is required")]
        [Display(Name = "Stud Id")]
        public int StudId { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Stud Name")]
        [MaxLength(40, ErrorMessage = "Name must have less than 40 characters")]
        [MinLength(2)]
        public string? Name { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }
        [Required]
        public double Salary { get; set; }


        [Required(ErrorMessage = "Branch name is required")]
        [Display(Name="Branch Name")]
        public string Branch { get; set; }




        [Required]
        [Range(18, 60)]
        public int Age { get; set; }


        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }



        [Required]
        [Range(50,75)]
        public double Percentage { get; set; }



    }
}
