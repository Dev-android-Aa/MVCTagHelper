using System.ComponentModel.DataAnnotations;

namespace HRApplicationnew.Models
{
    public class Employees
    {
        private string? employeeName;
        private string? departement;
        private Boolean isActive;
        private string? jobTitle;
        private DateTime dateNaissance;
        private string? emailAdresse;

        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(20,MinimumLength =5 , ErrorMessage = "Invalid Name")]
        public string? EmployeeName { get => employeeName; set => employeeName = value; }

        [Required(ErrorMessage = "Please Enter Departement")]
        public string? Departement { get => departement; set => departement = value; }

        public bool IsActive { get => isActive; set => isActive = value; }

        [Required(ErrorMessage = "Please Enter Job")]
        [DataType(DataType.Text)]
        public string? JobTitle { get => jobTitle; set => jobTitle = value; }

        [Required(ErrorMessage = "Please Enter Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }

        [Required(ErrorMessage = "Please Enter Email")]
        [DataType(DataType.EmailAddress)]
        public string? EmailAdresse { get => emailAdresse; set => emailAdresse = value; }
    }
}
