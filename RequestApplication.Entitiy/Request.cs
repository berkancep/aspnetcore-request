using System;
using System.Collections.Generic;
using System.Text;

namespace RequestApplication.Entitiy
{
    public class Request
    {
        // user
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public DateTime RequestDate { get; set; }

        // admin
        public DateTime? ReplyDate { get; set; }
        public bool? IsPositive{ get; set; }
        public string Reply { get; set; }

        public int? UserId { get; set; }
        public int? AdminId { get; set; }
        public User User { get; set; }

      

    }
}
