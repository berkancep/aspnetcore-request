using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class ResponseAnswerViewModel
    {
        public int Id { get; set; }


        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Belge")]
        public string Document { get; set; }

        
        public DateTime ReplyDate { get; set; } = DateTime.Now;

        [Display(Name = "Sonuç")]
        public bool IsPositive { get; set; }

        [Display(Name = "Cevap")]
        public string Reply { get; set; }

        public int AdminId { get; set; }
        public int UserId { get; set; }
    }
}
