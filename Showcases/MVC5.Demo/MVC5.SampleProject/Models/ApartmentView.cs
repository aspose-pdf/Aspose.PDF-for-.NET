using System.ComponentModel.DataAnnotations;

namespace Mvc5.SampleProject.Models
{
    public class ApartmentView
    {
        [Display(Name = "City")]
        [StringLength(6)]
        public string City { get; set; }

        [Display(Name = "Rental Property Address")]
        [StringLength(65)]
        public string Address { get; set; }

        [Display(Name = "Total area of apartment")]
        public double TotalArea { get; set; }
    }
}
