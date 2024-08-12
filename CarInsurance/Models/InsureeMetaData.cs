using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class InsureeMetaData
    {
        [Required(ErrorMessage = "Insuree First Name is required")]
        [Display(Name = "Insuree First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Insuree Last Name")]
        public string LastName { get; set; }

    }
}