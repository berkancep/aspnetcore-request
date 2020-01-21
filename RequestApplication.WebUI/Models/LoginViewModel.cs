using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Eposta alanı zorunludur")]
        [Display(Name = "Eposta")]
        [EmailAddress(ErrorMessage = "Email Adresini düzgün formatta giriniz")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        [Display(Name = "Şifre")]
        [UIHint("Password")]
        public string Password { get; set; }
        public string RoleName   { get; set; }

    }
}
