using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class RequestDetailsViewModel
    {
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Dosya")]
        public string Document { get; set; }

        [Display(Name = "Cevap")]
        public string Reply { get; set; }

    }
}
