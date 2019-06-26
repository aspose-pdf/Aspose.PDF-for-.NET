using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc5.SampleProject.Models
{
    public class Tenant
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Tenant's Full Name")]
        [StringLength(65)]
        public string FullName { get; set; }
        [Display(Name = "Rental Property Address")]
        [StringLength(65)]
        public string RentalPropertyAddress { get; set; }

        [Display(Name = "Move-In Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]

        public DateTime MoveInDate { get; set; }
        [Display(Name = "Lease-End Date")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        [DataType(DataType.Date)]
        public DateTime LeaseEndDate { get; set; }

        [Display(Name = "Monthly Payment")]
        [DataType(DataType.Currency)]
        public decimal MonthlyPayment { get; set; }
    }
}
