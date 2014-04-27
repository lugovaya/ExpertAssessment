using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace ExpertAssessment.Domain.Entities
{
    public class Expert
    {
        public Expert()
        {
            DateCreate = DateTime.Now;
            IsLoginIn = false;
        }

        [Column("expert_login")]
        [Key]
        [Required]
        [Display(Name="Login")]
        [Remote("DoesUserNameExist", "Account", HttpMethod = "POST", 
            ErrorMessage = "User name already exists. Please enter a different user name.")]
        public string Login { get; set; }

        [Column("expert_email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Column("expert_pass")]
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }

        [Column("expert_fullName")]
        [Required]
        public string FullName { get; set; }

        [Column("expert_expertRole")]
        public bool HasExpertRole { get; set; }

        [Column("expert_analyticRole")]
        public bool HasAnalyticRole { get; set; }

        [Column("expert_dateCreate")]
        public DateTime DateCreate { get; set; }

        public bool IsLoginIn { get; set; }
    }
}
