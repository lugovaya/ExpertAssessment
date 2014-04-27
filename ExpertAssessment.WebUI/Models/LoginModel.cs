using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpertAssessment.WebUI.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Login")]
        [Remote("DoesExpertLoginEdites", "Account", HttpMethod = "POST",
            ErrorMessage = "Expert login hasn't been found. Please enter a correct expert login.")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }
    }
}