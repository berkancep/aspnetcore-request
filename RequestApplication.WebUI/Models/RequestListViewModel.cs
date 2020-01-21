using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class RequestListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool? IsPositive { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ReplyDate { get; set; }
    }
}
