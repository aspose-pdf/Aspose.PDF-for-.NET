using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc5.SampleProject.Models
{

    public class Apartment
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Region")]
        [StringLength(6)]
        public string Region { get; set; }

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
