using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class RegisterMode
    {
        [Required]
        [Display(Name="User name")]
        public string Username { get; set; }

        public string Email { get; set; }

        [Required]
        [StringLength(100,ErrorMessage="The {0} must be at least {2} ",MinimumLength=6)]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
    }
}