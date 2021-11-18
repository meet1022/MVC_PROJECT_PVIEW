using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_PROJECT_PVIEW.Models
{
    public class EmployeeModel
    {


        [StringLength(10, ErrorMessage = "Length Should be between 5 to 10", MinimumLength = 5)][Required]
        public string EmpCode { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.Date)][Required]
        public DateTime DateOfBirth { get; set; }
        [Range(2, 8)]
        public int YearsOfExperience { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required]
        public string Email { get; set; }
        [RegularExpression(@"\+?\d[\d -]{8,12}\d",ErrorMessage = "Entered phone format is not valid.")][Required]
        public string PhoneNo { get; set; }

    }
}