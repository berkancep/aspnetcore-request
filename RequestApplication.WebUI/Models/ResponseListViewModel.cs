using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestApplication.WebUI.Models
{
    public class ResponseListViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
