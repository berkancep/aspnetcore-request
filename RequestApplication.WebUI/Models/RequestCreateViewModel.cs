using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class RequestCreateViewModel
    {
        [Required(ErrorMessage = "Başlık alanı zorunludur")]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Belge")]
        public string Document { get; set; }

        public DateTime RequestDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }

    }
}
