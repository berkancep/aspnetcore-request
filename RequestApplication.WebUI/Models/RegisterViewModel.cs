using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Ad,Soyad alanı zorunludur")]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Eposta alanı zorunludur")]
        [Display(Name = "Eposta")]
        [EmailAddress(ErrorMessage = "Email Adresini düzgün formatta giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunludur")]
        [Display(Name = "Telefon")]
        [Phone(ErrorMessage ="Telefon numarasını düzgün formatta giriniz")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        [Display(Name = "Şifre")]
        [UIHint("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar alanı zorunludur")]
        [Display(Name = "Şifre Tekrar")]
        [UIHint("Password")]
        [Compare(nameof(RegisterViewModel.Password), ErrorMessage = "Parola birbiriyle uyuşmuyor.")]
        public string RePassword { get; set; }

        public int RoleId { get; set; } = 5; // varsayılan 5 yani user
    }
}
