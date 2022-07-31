using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CURDOprationsDimo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Display(Name="ID")] 
        public int? EmployeeId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [Column(TypeName ="varchar(250)")]
        public string EmployeeName { get; set; } = string.Empty;

        [Required]
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required,Display(Name ="Salary"),Column(TypeName ="float")]
        public float Salary { get; set; }

        [Required]
        [Display(Name ="Hiring Date")]
        [DataType(DataType.Date)] [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}")]
        public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name ="National ID")]
        [Column (TypeName ="varchar(14)")]
        [MaxLength(14)]
        [MinLength(14)]
        public string NationalId { get; set; } = string.Empty;

    }
}
